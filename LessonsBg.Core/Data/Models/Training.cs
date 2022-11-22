namespace LessonsBg.Core.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Comment("Trainings")]
    public class Training
    {
        [Key]
        [Comment("Primary key.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Name of the training.")]
        public string Name { get; set; } = null!;

        [Comment("Type of the training.")]
        public int TrainingTypeId { get; set; }

        [ForeignKey(nameof(TrainingTypeId))]
        public TrainingType TrainingType { get; set; } = null!;

        [Comment("Mapping table")]
		public List<ApplicationUserTraining> ApplicationUsersTrainings { get; set; } = new List<ApplicationUserTraining>();
	}
}
