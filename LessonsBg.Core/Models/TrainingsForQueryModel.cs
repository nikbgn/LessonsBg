namespace LessonsBg.Core.Models
{
	using LessonsBg.Core.Models.Trainer;

	public class TrainingsForQueryModel
	{
		public IEnumerable<TrainerCardModel> TrainerCards { get; set; }

		public IEnumerable<LocationModel> Locations { get; set; }

		public string TeachingLocation { get; set; }
	}
}
