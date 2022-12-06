namespace LessonsBg.Core.Models
{
	public class ChangeTeachingLocationModel
	{
		public IEnumerable<LocationModel> Locations { get; set; }

		public string TeachingLocation { get; set; }
	}
}
