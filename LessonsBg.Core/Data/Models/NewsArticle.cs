namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static LessonsBg.Core.Data.DataValidationConstants.NewsArticleValidation;

    [Comment("News article")]
    public class NewsArticle
    {
        [Key]
        [Comment("Primary key.")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(NewsArticleNameMaxLength, MinimumLength = NewsArticleNameMinLength)]
        [Comment("News article name.")]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(NewsArticleTextMinLength)]
        [Comment("The news article's text.")]
        public string Text { get; set; } = null!;

        [Required]
        [Url]
        [Comment("The image of the news article.")]
        public string ImageURL { get; set; } = null!;

        [Required]
        [Comment("Date of creation.")]
        public DateTime CreatedOn { get; set; }

    }
}
