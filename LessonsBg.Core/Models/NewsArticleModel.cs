namespace LessonsBg.Core.Models
{
    using Microsoft.EntityFrameworkCore;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using static LessonsBg.Core.Data.DataValidationConstants.NewsArticleValidation;
    public class NewsArticleModel
    {
        [Required]
        [Comment("Primary key.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
        [StringLength(NewsArticleNameMaxLength, MinimumLength = NewsArticleNameMinLength, ErrorMessage = NewsArticleNameLengthErrorMessage)]
        [DisplayName("Заглавие на новината.")]
        [Comment("News article name.")]
        public string Name { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[MinLength(NewsArticleTextMinLength, ErrorMessage = NewsArticleTextLengthErrorMessage)]
        [DisplayName("Текстът на новината.")]
        [Comment("The news article's text.")]
        public string Text { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Url(ErrorMessage = NewsArticleImageURLErrorMessage)]
        [DisplayName("Картинка на новината.")]
        [Comment("The image of the news article.")]
        public string ImageURL { get; set; } = null!;

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Comment("Date of creation.")]
        public DateTime CreatedOn { get; set; }
    }
}
