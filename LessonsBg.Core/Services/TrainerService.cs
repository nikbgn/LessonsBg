namespace LessonsBg.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Data.Models;
    using LessonsBg.Core.Models.Trainer;
    using Microsoft.EntityFrameworkCore;

    public class TrainerService : ITrainerService
	{

		private readonly ApplicationDbContext context;

		public TrainerService(ApplicationDbContext _context)
		{
			context = _context;
		}

		/// <summary>
		/// Adds a training to the trainer's collection of sports that he can teach.
		/// </summary>

		public async Task AddTrainingToTrainingsCollectionAsync(Guid trainingId, string trainerId)
		{
			var training = await context.Trainings.Include(t => t.ApplicationUsersTrainings).FirstOrDefaultAsync(t => t.Id == trainingId);
			var trainer = await context.Users.Include(t => t.ApplicationUsersTrainings).FirstOrDefaultAsync(u => u.Id == trainerId);

			if (training == null) throw new ArgumentException("Invalid training id!");
			if (trainer == null) throw new ArgumentException("Invalid trainer id!");

			if(!training.ApplicationUsersTrainings.Any(u => u.ApplicationUserId == trainerId))
			{
				trainer.ApplicationUsersTrainings.Add(new ApplicationUserTraining()
				{
					TrainingId = training.Id,
					ApplicationUserId = trainer.Id,
					ApplicationUser = trainer,
					Training = training
				});

				await context.SaveChangesAsync();
			}
		}

		/// <summary>
		/// Gets information needed to fill a trainer card for illustration purposes
		/// </summary>

		public async Task<IEnumerable<TrainerCardModel>> GetTrainersCardsForTrainingAsync(string trainingName)
			=> await context.Users
				.Include(u => u.ApplicationUsersTrainings)
				.Where(u => u.ApplicationUsersTrainings
				.Any(t => t.Training.Name == trainingName))
				.Select(u => new TrainerCardModel
				{
					FirstName = u.FirstName,
					LastName = u.LastName,
					PhoneNumber = u.PhoneNumber,
					ProfileImage = u.ProfileImage
				})
				.ToListAsync();

		/// <summary>
		/// Gets trainer's sports
		/// </summary>

		public async Task<IEnumerable<TrainingModel>> GetTrainerTrainingsAsync(string trainerId)
		{
			var trainer = await context.Users
				.Where(u => u.Id == trainerId)
				.Include(u => u.ApplicationUsersTrainings)
				.ThenInclude(at => at.Training)
				.ThenInclude(a => a.TrainingType)
				.FirstOrDefaultAsync();

			if (trainer == null) throw new ArgumentException("Invalid user ID");

			return trainer.ApplicationUsersTrainings
				.Select(t => new TrainingModel
				{
					Id = t.TrainingId,
					TrainingTypeId = t.Training.TrainingTypeId,
					Name = t.Training.Name
				});
		}

		/// <summary>
		/// Removes a training from the trainer's collection of sports that he can teach.
		/// </summary>

		public async Task RemoveTrainingFromTrainingsCollectionAsync(Guid trainingId, string trainerId)
		{
			var trainer = await context.Users
				.Where(u => u.Id == trainerId)
				.Include(u => u.ApplicationUsersTrainings)
				.ThenInclude(at => at.Training)
				.ThenInclude(a => a.TrainingType)
				.FirstOrDefaultAsync();

			if (trainer == null) throw new ArgumentException("Invalid trainer ID");

			var training = trainer.ApplicationUsersTrainings.FirstOrDefault(t => t.TrainingId == trainingId);

			if(training != null)
			{
				trainer.ApplicationUsersTrainings.Remove(training);
				await context.SaveChangesAsync();
			}
		}
	}
}
