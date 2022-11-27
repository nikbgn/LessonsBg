namespace LessonsBg.Core.Models
{
	using System.ComponentModel.DataAnnotations;
	using static LessonsBg.Core.Data.DataValidationConstants.CourseValidation;

	public class CourseModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[StringLength(
			CourseNameMaxLength, 
			MinimumLength = CourseNameMinLength,
			ErrorMessage = CourseNameErrorMessage)]
		[Display(Name = "Име на курса")]
		public string CourseName { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Url(ErrorMessage = CourseImageErrorMessage)]
		[Display(Name = "Картинка на курса")]
		public string CourseImageURL { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Display(Name = "Вид на курса")]
		public int CourseTypeId { get; set; }

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Phone(ErrorMessage = CoursePhoneNumberErrorMessage)]
		[RegularExpression("(\\+)?(359|0)8[789]\\d{1}(|-| )\\d{3}(|-| )\\d{3}", ErrorMessage = CoursePhoneNumberErrorMessage)]
		[Display(Name = "Телефонен номер за контакти")]
		public string PhoneNumber { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Display(Name = "Локация")]
		public int LocationId { get; set; }

		[Url(ErrorMessage = CourseWebsiteErrorMessage)]
		[Display(Name = "Уебсайт")]
		public string? Website { get; set; }

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[MinLength(CourseDescriptionMinLength, ErrorMessage = CourseDescriptionErrorMessage)]
		[Display(Name = "Описание на курса")]
		public string CourseDescription { get; set; } = null!;


	}
}
