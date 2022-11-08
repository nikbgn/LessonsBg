namespace LessonsBg.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Имейл")]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(PasswordRepeat))]
        [DataType(DataType.Password)]
        [DisplayName("Парола")]
        public string Password { get; set; } 

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Повторете паролата")]
        public string PasswordRepeat { get; set; }

        [Required]
        [DisplayName("Име")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Фамилно име")]
        public string LastName { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Телефонен номер")]
        public string PhoneNumber { get; set; }

        [Required]
        public int RegistrationFlag { get; set; }
    }
}
