namespace LessonsBg.Core.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using LessonsBg.Core.Data.Models;

    using static LessonsBg.Core.Data.DataValidationConstants.BlogPostValidation;

    /// <summary>
    /// Blog post model
    /// </summary>

    public class BlogPostModel
    {
        /// <summary>
        /// Blog post identifier.
        /// </summary>

        public Guid Id { get; set; }

        /// <summary>
        /// Blog post title.
        /// </summary>

        [Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
        [StringLength(BlogTitleMaxLength, MinimumLength = BlogTitleMinLength, ErrorMessage = BlogPostTitleLengthErrorMessage)]
		[DisplayName("Заглавие")]
		public string Title { get; set; }

		/// <summary>
		/// Blog post thumbnail image URL.
		/// </summary>

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Url(ErrorMessage = BlogPostThumbnailURLErrorMessage)]
		[DisplayName("Картинка на поста")]
		public string PostThumbnailURL { get; set; }

		/// <summary>
		/// Heading image for the blog post text.
		/// </summary>

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[Url(ErrorMessage = BlogPostTextHeadingImageURLErrorMessage)]
		[DisplayName("Главна картинка на съдържанието на поста")]
		public string PostTextHeadingImageURL { get; set; }

		/// <summary>
		/// Blog post text.
		/// </summary>

		[Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
		[MinLength(BlogPostTextMinLength, ErrorMessage = BlogPostTextLengthErrorMessage)]
		[DisplayName("Съдържание на поста")]
		public string PostText { get; set; }


        /// <summary>
        /// Blog post time of creation.
        /// </summary>

        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Comments for the blog post.
        /// </summary>
        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();

    }
}


