namespace LessonsBg.Core.Data.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using System.ComponentModel.DataAnnotations;

	public class ApplicationUserTraining
	{
		[Required]
		public string ApplicationUserId { get; set; }

		[ForeignKey(nameof(ApplicationUserId))]

		public ApplicationUser ApplicationUser { get; set; }

		[Required]
		public Guid TrainingId { get; set; }

		[ForeignKey(nameof(TrainingId))]

		public Training Training { get; set; }
	}
}
