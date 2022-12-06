namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    using static Data.DataValidationConstants.ApplicationUserValidation;

    public class ApplicationUser : IdentityUser
    {

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Url]
        public string ProfileImage { get; set; } = null!;

        [Required]
        public string TeachingLocation { get; set; } = "Онлайн";


        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
		public List<ApplicationUserSubject> ApplicationUsersSubjects { get; set; } = new List<ApplicationUserSubject>();
		public List<ApplicationUserTraining> ApplicationUsersTrainings { get; set; } = new List<ApplicationUserTraining>();
		public List<ApplicationUserCourse> ApplicationUsersCourses { get; set; } = new List<ApplicationUserCourse>();
    }
}
