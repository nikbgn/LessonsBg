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

        [Required]
        [Comment("Author ID.")]
        public string AuthorId { get; set; } = null!;

        [ForeignKey(nameof(AuthorId))]
        public ApplicationUser Author { get; set; } = null!;

        [Comment("Type of the course.")]
        public int CourseTypeId { get; set; } 

        [ForeignKey(nameof(CourseTypeId))]
        public CourseType CourseType { get; set; } = null!;

        [Phone]
        [Comment("Phone number to call if you are interested in the course.")]
        public string PhoneNumber { get; set; } = null!;

        [Comment("Location of the course.")]
        public Location Location { get; set; } = null!;

        [Url]
        [Comment("Website link with additional information about the course.")]
        public string? Website { get; set; }

        [Required]
        [MinLength(CourseDescriptionMinLength)]
        [Comment("Description of the course.")]
        public string CourseDescription { get; set; } = null!;

        [Comment("Filter badges that help with showing who is this course appropriate for.")]
        public IEnumerable<FilterBadge> FilterBadges { get; set; } = new List<FilterBadge>();

	}
}
