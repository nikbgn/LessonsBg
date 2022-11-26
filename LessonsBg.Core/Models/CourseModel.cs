namespace LessonsBg.Core.Models
{
	using System.ComponentModel.DataAnnotations;
	using static LessonsBg.Core.Data.DataValidationConstants.CourseValidation;

	public class CourseModel
	{
		public Guid Id { get; set; }

		[Required]
		[StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength)]
		public string CourseName { get; set; } = null!;

		[Required]
		[Url]
		public string CourseImageURL { get; set; } = null!;

		[Required]
		public int CourseTypeId { get; set; }

		[Required]
		[Phone]
		[RegularExpression("(\\+)?(359|0)8[789]\\d{1}(|-| )\\d{3}(|-| )\\d{3}")]
		public string PhoneNumber { get; set; } = null!;

		[Required]
		public int LocationId { get; set; }

		[Url]
		public string? Website { get; set; }

		[Required]
		[MinLength(CourseDescriptionMinLength)]
		public string CourseDescription { get; set; } = null!;


	}
}
