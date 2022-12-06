namespace LessonsBg.Models
{
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	using LessonsBg.Core.Data.Models;

	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[EmailAddress(ErrorMessage = "Моля попълнете валиден имейл адрес!")]
		[DisplayName("Имейл")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[Compare(nameof(PasswordRepeat), ErrorMessage = "Паролата не съвпада.")]
		[DataType(DataType.Password)]
		[DisplayName("Парола")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[DataType(DataType.Password, ErrorMessage = "Паролата не съвпада.")]
		[DisplayName("Повторете паролата")]
		public string PasswordRepeat { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[DisplayName("Име")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[DisplayName("Фамилно име")]
		public string LastName { get; set; } = "Академия";

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[Phone(ErrorMessage = "Моля попълнете валиден телефонен номер! (08XXXXXXXX)")]
		[RegularExpression("(\\+)?(359|0)8[789]\\d{1}(|-| )\\d{3}(|-| )\\d{3}", ErrorMessage = "Моля попълнете валиден телефонен номер! (08XXXXXXXX)")]
		[DataType(DataType.PhoneNumber)]
		[DisplayName("Телефонен номер")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		public int RegistrationFlag { get; set; }
	}
}
