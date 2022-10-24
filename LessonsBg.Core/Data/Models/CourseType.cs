namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Course type")]
    public class CourseType
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [Comment("Course type.")]
        public string Type { get; set; } = null!;

        public IEnumerable<Course> Courses { get; set; } = new List<Course>();
    }
}
