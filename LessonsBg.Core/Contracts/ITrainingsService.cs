namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models.Trainer;

    /// <summary>
    /// Interface for the Trainings Service.
    /// </summary>

    public interface ITrainingsService
	{
		/// <summary>
		/// Gets all trainings
		/// </summary>
		/// <returns>All trainings</returns>
		public Task<IEnumerable<TrainingModel>> GetAllTrainingsAsync();

		/// <summary>
		/// Gets all training type names
		/// </summary>
		/// <returns>List of all training type names</returns>
		public Task<List<string>> GetAllTrainingTypesNamesAsync();

		/// <summary>
		/// Gets all sports
		/// </summary>
		public Task<List<AllTrainingsModel>> GetAllSportsAsync(List<string> trainingTypes);

		/// <summary>
		/// Gets all trainings names
		/// </summary>
		/// <returns></returns>
		public Task<List<string>> GetAllTrainingsNamesAsync();

	}
}
