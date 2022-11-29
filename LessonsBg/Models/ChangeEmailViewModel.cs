namespace LessonsBg.Models
{
	using System.ComponentModel.DataAnnotations;

	public class ChangeEmailViewModel
	{
		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[EmailAddress(ErrorMessage = "Моля въведете валиден имейл!")]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Нов имейл")]
		public string NewEmail { get; set; }
	}
}
