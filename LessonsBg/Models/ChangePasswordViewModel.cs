namespace LessonsBg.Models
{
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class ChangePasswordViewModel
	{

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[DataType(DataType.Password)]
		[DisplayName("Стара Парола")]
		public string OldPassword { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[Compare(nameof(PasswordRepeat), ErrorMessage = "Паролата не съвпада.")]
		[DataType(DataType.Password)]
		[DisplayName("Нова Парола")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[DataType(DataType.Password, ErrorMessage = "Паролата не съвпада.")]
		[DisplayName("Повторете новата парола")]
		public string PasswordRepeat { get; set; }
	}
}
