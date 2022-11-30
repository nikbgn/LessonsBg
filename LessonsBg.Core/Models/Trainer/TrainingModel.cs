namespace LessonsBg.Core.Models.Trainer
{
    using System.ComponentModel.DataAnnotations;

    public class TrainingModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int TrainingTypeId { get; set; }
    }
}
