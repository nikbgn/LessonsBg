namespace LessonsBg.Core.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    public class LocationModel
    {
		[Required]
		[Comment("Identifier.")]
		public int Id { get; set; }

		[Required]
        [Comment("City name.")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("City region.")]
        public string Region { get; set; } = null!;
    }
}
