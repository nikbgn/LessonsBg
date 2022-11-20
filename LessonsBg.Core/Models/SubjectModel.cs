namespace LessonsBg.Core.Models
{
	using System.ComponentModel.DataAnnotations;

	public class SubjectModel
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		[Required]
		public int SubjectTypeId { get; set; }
	}
}
