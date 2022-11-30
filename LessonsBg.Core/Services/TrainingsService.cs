namespace LessonsBg.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Models.Trainer;
    using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class TrainingsService : ITrainingsService
	{
        private readonly ApplicationDbContext context;
        private readonly ILogger<TrainingsService> logger;

        public TrainingsService(
			ApplicationDbContext _context,
			ILogger<TrainingsService> _logger)
        {
            context = _context;
            logger = _logger;
        }

		/// <summary>
		/// Gets all sports
		/// </summary>

		public async Task<List<AllTrainingsModel>> GetAllSportsAsync(List<string> trainingTypes)
		{
			try
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
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all sports.", ex);
			}

		}

		/// <summary>
		/// Gets all trainings
		/// </summary>
		/// <returns>All trainings</returns>

		public async Task<IEnumerable<TrainingModel>> GetAllTrainingsAsync()
		{
			try
			{
				return await context
					.Trainings
					.Include(t => t.TrainingType)
					.Select(t => new TrainingModel()
					{
						Id = t.Id,
						Name = t.Name,
						TrainingTypeId = t.TrainingTypeId
					})
					.ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting all trainings failed.", ex);
			}
		}


		/// <summary>
		/// Gets all trainings names
		/// </summary>
		/// <returns></returns>

		public async Task<List<string>> GetAllTrainingsNamesAsync()
		{
			try
			{
				return await context
					.Trainings
					.Select(t => t.Name)
					.ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all trainings names.", ex);
			}
		}


		/// <summary>
		/// Gets all training type names
		/// </summary>
		/// <returns>List of all training type names</returns>

		public async Task<List<string>> GetAllTrainingTypesNamesAsync()
		{
			try
			{
				return await context
					.TrainingTypes
					.Select(tt => tt.Type)
					.ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all training types names.", ex);
			}
		}
	}
}
