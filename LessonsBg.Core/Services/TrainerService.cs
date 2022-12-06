namespace LessonsBg.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Models;
	using LessonsBg.Core.Models.Trainer;
    using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class TrainerService : ITrainerService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<TrainerService> logger;

		public TrainerService(
			ApplicationDbContext _context,
			ILogger<TrainerService> _logger
			)
		{
			context = _context;
			logger = _logger;
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

			try
			{
				if (!training.ApplicationUsersTrainings.Any(u => u.ApplicationUserId == trainerId))
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
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Adding training to trainings collection failed.", ex);
			}

		}

		/// <summary>
		/// Gets information needed to fill a trainer card for illustration purposes
		/// </summary>

		public async Task<TrainingsForQueryModel> GetTrainersCardsForTrainingAsync(string trainingName, string teachingLocation)
		{
			try
			{
				var locations = await context
						.Locations.
						Select(l => new LocationModel
						{
							Id = l.Id,
							Name = l.Name,
							Region = l.Region
						}).ToListAsync();

				var result = new TrainingsForQueryModel()
				{
					TeachingLocation = teachingLocation,
					Locations = locations
				};
				result.TrainerCards = await context.Users
					.Include(u => u.ApplicationUsersTrainings)
					.Where(u => u.TeachingLocation == teachingLocation)
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

				return result;
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting trainer cards for training.", ex);
			}
		}

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

			try
			{
				return trainer.ApplicationUsersTrainings
					.Select(t => new TrainingModel
					{
						Id = t.TrainingId,
						TrainingTypeId = t.Training.TrainingTypeId,
						Name = t.Training.Name
					});
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting trainer's trainings.", ex);
			}
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
				try
				{
					trainer.ApplicationUsersTrainings.Remove(training);
					await context.SaveChangesAsync();
				}
				catch (Exception ex)
				{
					logger.LogError(nameof(ex), ex.Message);
					throw new ApplicationException("Failed removing training from trainings collection.", ex);
				}
			}
			else
			{
				throw new ArgumentException("Invalid training ID.");
			}
		}
	}
}
