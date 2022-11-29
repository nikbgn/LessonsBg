namespace LessonsBg.Models
{
	using System.ComponentModel.DataAnnotations;

	public class ChangePhoneNumberViewModel
	{
		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[Phone(ErrorMessage = "Телефонът трябва да е валиден български номер! (08XXXXXXXX)")]
		[RegularExpression("(\\+)?(359|0)8[789]\\d{1}(|-| )\\d{3}(|-| )\\d{3}", ErrorMessage = "Телефонът трябва да е валиден български номер! (08XXXXXXXX)")]
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Нов телефонен номер")]
		public string NewPhoneNumber { get; set; } = null!;
	}
}
