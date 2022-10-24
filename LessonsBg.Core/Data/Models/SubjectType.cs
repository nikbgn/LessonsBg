namespace LessonsBg.Core.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    [Comment("Subject type")]
    public class SubjectType
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [Comment("Subject type.")]
        public string Type { get; set; } = null!;

        public IEnumerable<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
