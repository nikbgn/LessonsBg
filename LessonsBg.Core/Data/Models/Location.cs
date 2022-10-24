namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Locations (cities in Bulgaria and their regions).")]
    public class Location
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [Comment("City name.")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("City region.")]
        public string Region { get; set; } = null!;
    }
}
