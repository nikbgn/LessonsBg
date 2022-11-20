namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    using static Data.DataValidationConstants.ApplicationUserValidation;

    public class ApplicationUser : IdentityUser
    {
        //TODO: Migration not yet applied be aware!

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;


        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
        public IEnumerable<Course> Courses { get; set; } = new List<Course>();
		public List<ApplicationUserSubject> ApplicationUsersSubjects { get; set; } = new List<ApplicationUserSubject>();
		public IEnumerable<Training> Trainings { get; set; } = new List<Training>();
    }
}
