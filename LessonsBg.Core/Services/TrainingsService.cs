namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;

	public class TrainingsService : ITrainingsService
	{
        private readonly ApplicationDbContext context;

        public TrainingsService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<List<AllTrainingsModel>> GetAllSportsAsync(List<string> trainingTypes)
		{
			var allTrainigs = new List<AllTrainingsModel>();

			foreach (var trainingType in trainingTypes)
			{
				var newModel = new AllTrainingsModel();
				newModel.TrainingTypeName = trainingType;

				newModel.TrainingsOfTrainingTypeName = await context.Trainings
					.Where(t => t.TrainingType.Type == trainingType)
					.Select(t => t.Name)
					.ToListAsync();

				allTrainigs.Add(newModel);

			}

			return allTrainigs;
		}

		public async Task<IEnumerable<TrainingModel>> GetAllTrainingsAsync()
			=> await context
				.Trainings
				.Include(t => t.TrainingType)
				.Select(t => new TrainingModel()
				{
					Id = t.Id,
					Name = t.Name,
					TrainingTypeId = t.TrainingTypeId
				})
				.ToListAsync();

		public async Task<List<string>> GetAllTrainingsNamesAsync()
			=> await context
				.Trainings
				.Select(t => t.Name)
				.ToListAsync();

		public async Task<List<string>> GetAllTrainingTypesNamesAsync()
			=> await context
				.TrainingTypes
				.Select(tt => tt.Type)
				.ToListAsync();
	}
}
