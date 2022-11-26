namespace LessonsBg.Core.Models
{
	using System.ComponentModel.DataAnnotations;

	public class CourseTypeModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string Type { get; set; } = null!;
	}
}
