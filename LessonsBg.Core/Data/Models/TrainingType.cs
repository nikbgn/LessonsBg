namespace LessonsBg.Core.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    [Comment("Training type")]
    public class TrainingType
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [Comment("Training type.")]
        public string Type { get; set; } = null!;

        public IEnumerable<Training> Trainings { get; set; } = new List<Training>();
    }
}
