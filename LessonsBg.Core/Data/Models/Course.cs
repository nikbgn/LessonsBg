namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static LessonsBg.Core.Data.DataValidationConstants.CourseValidation;

    [Comment("Courses")]
    public class Course
    {
        [Key]
        [Comment("Primary key")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength)]
        [Comment("Name of the course.")]
        public string CourseName { get; set; } = null!;

        [Required]
        [Url]
        [Comment("Course image.")]
        public string CourseImageURL { get; set; } = null!;

        [Comment("Type of the course.")]
        public int CourseTypeId { get; set; } 

        [ForeignKey(nameof(CourseTypeId))]
        public CourseType CourseType { get; set; } = null!;

        [Phone]
        [RegularExpression("(\\+)?(359|0)8[789]\\d{1}(|-| )\\d{3}(|-| )\\d{3}")]
        [Comment("Phone number to call if you are interested in the course.")]
        public string PhoneNumber { get; set; } = null!;


        [Comment("Location of the course.")]
        public int LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location Location { get; set; } = null!;

        [Url]
        [Comment("Website link with additional information about the course.")]
        public string? Website { get; set; }

        [Required]
        [MinLength(CourseDescriptionMinLength)]
        [Comment("Description of the course.")]
        public string CourseDescription { get; set; } = null!;

		public List<ApplicationUserCourse> ApplicationUsersCourses { get; set; } = new List<ApplicationUserCourse>();

	}
}
