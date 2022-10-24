namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Filter badge that helps show, who is a course appropriate for.")]
    public class FilterBadge
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [Comment("FilterBadge type.")]
        public string FilterBadgeType { get; set; } = null!;

        public IEnumerable<Course> Courses { get; set; } = new List<Course>();
    }
}
