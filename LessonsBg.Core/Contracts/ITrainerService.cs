namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models.Trainer;


    /// <summary>
    /// Interface for the Trainer Service.
    /// </summary>

    public interface ITrainerService
	{
		/// <summary>
		/// Adds a training to the trainer's collection of sports that he can teach.
		/// </summary>
		
		public Task AddTrainingToTrainingsCollectionAsync(Guid trainingId, string trainerId);

		/// <summary>
		/// Removes a training from the trainer's collection of sports that he can teach.
		/// </summary>

		public Task RemoveTrainingFromTrainingsCollectionAsync(Guid trainingId, string trainerId);

		/// <summary>
		/// Gets trainer's sports
		/// </summary>

		public Task<IEnumerable<TrainingModel>> GetTrainerTrainingsAsync(string trainerId);

		/// <summary>
		/// Gets information needed to fill a trainer card for illustration purposes
		/// </summary>

		public Task<IEnumerable<TrainerCardModel>> GetTrainersCardsForTrainingAsync(string trainingName);

	}
}
