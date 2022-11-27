namespace LessonsBg.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Попълването на това поле е задължително!")]
        [EmailAddress(ErrorMessage = "Моля попълнете валиден имейл!")]
        [DisplayName("Имейл")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Попълването на това поле е задължително!")]
        [DataType(DataType.Password)]
        [DisplayName("Парола")]
        public string Password { get; set; }

        [UIHint("hidden")]
        public string? ReturnUrl { get; set; }
    }
}
