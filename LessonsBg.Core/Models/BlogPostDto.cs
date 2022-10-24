namespace LessonsBg.Core.Models
{
    using System.ComponentModel.DataAnnotations;

    using LessonsBg.Core.Data.Models;

    using static LessonsBg.Core.Data.DataValidationConstants.BlogPostValidation;

    /// <summary>
    /// Blog post model
    /// </summary>

    public class BlogPostDto
    {
        /// <summary>
        /// Blog post identifier.
        /// </summary>

        public Guid Id { get; set; }

        /// <summary>
        /// Blog post title.
        /// </summary>

        [Required]
        [StringLength(BlogTitleMaxLength, MinimumLength = BlogTitleMinLength)]
        public string Title { get; set; }

        /// <summary>
        /// Blog post thumbnail image URL.
        /// </summary>

        [Required]
        [Url]
        public string PostThumbnailURL { get; set; }

        /// <summary>
        /// Heading image for the blog post text.
        /// </summary>

        [Required]
        [Url]
        public string PostTextHeadingImageURL { get; set; }

        /// <summary>
        /// Blog post text.
        /// </summary>

        [Required]
        [MinLength(BlogPostTextMinLength)]
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


