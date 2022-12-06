namespace LessonsBg.Core.Models
{
	using LessonsBg.Core.Models.Teacher;

	public class LessonsForQueryModel
	{
		public IEnumerable<TeacherCardModel> TeacherCards { get; set; }

		public IEnumerable<LocationModel> Locations { get; set; }

		public string TeachingLocation { get; set; }
	}
}
