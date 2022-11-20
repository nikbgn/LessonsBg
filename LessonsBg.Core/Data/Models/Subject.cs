namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    [Comment("Subjects")]
    public class Subject
    {
        [Key]
        [Comment("Primary key.")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Name of the subject.")]
        public string Name { get; set; } = null!;

        [Comment("Type of the subject.")]
        public int SubjectTypeId { get; set; }

        [ForeignKey(nameof(SubjectTypeId))]
        public SubjectType SubjectType { get; set; } = null!;

        public List<ApplicationUserSubject> ApplicationUsersSubjects { get; set; } = new List<ApplicationUserSubject>();


    }
}
