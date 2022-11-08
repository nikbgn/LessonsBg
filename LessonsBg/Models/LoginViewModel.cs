namespace LessonsBg.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Имейл")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Парола")]
        public string Password { get; set; }

        //TODO: Add remember me check.

        [UIHint("hidden")]
        public string? ReturnUrl { get; set; }
    }
}
