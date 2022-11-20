namespace LessonsBg.Core.Data.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using System.ComponentModel.DataAnnotations;

	public class ApplicationUserSubject
	{
		[Required]
		public string ApplicationUserId { get; set; }

		[ForeignKey(nameof(ApplicationUserId))]

		public ApplicationUser ApplicationUser { get; set; }

		[Required]
		public Guid SubjectId { get; set; }

		[ForeignKey(nameof(SubjectId))]

		public Subject Subject { get; set; }
	}
}
