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

		/// <summary>
		/// Gets all sports
		/// </summary>

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

		/// <summary>
		/// Gets all trainings
		/// </summary>
		/// <returns>All trainings</returns>

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


		/// <summary>
		/// Gets all trainings names
		/// </summary>
		/// <returns></returns>

		public async Task<List<string>> GetAllTrainingsNamesAsync()
			=> await context
				.Trainings
				.Select(t => t.Name)
				.ToListAsync();


		/// <summary>
		/// Gets all training type names
		/// </summary>
		/// <returns>List of all training type names</returns>

		public async Task<List<string>> GetAllTrainingTypesNamesAsync()
			=> await context
				.TrainingTypes
				.Select(tt => tt.Type)
				.ToListAsync();
	}
}
