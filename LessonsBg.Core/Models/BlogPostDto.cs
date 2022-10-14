namespace LessonsBg.Core.Models
{
    using System.ComponentModel.DataAnnotations;

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
        [StringLength(50)]
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
        public string PostText { get; set; }


        /// <summary>
        /// Blog post time of creation.
        /// </summary>

        public DateTime CreatedOn { get; set; }
    }
}

/*
 * Future improvements:
 *  - Author
 *  - Blog post comments?
 */
