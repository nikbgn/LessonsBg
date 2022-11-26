namespace LessonsBg.Core.Data.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using System.ComponentModel.DataAnnotations;

	public class ApplicationUserCourse
	{
		[Required]
		public string ApplicationUserId { get; set; }

		[ForeignKey(nameof(ApplicationUserId))]

		public ApplicationUser ApplicationUser { get; set; }


		[Required]
		public Guid CourseId { get; set; }

		[ForeignKey(nameof(CourseId))]

		public Course Course { get; set; }
	}
}
