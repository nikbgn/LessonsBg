namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using static DataValidationConstants.BlogPostValidation;

    [Comment("Blog posts.")]
    public class BlogPost
    {
        [Key]
        [Comment("Primary key.")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(BlogTitleMaxLength, MinimumLength = BlogTitleMinLength)]
        [Comment("The title of the post.")]
        public string Title { get; set; } = null!;

        [Required]
        [Url]
        [Comment("The thumbnail image of the post.")]
        public string PostThumbnailURL { get; set; } = null!;

        [Required]
        [Url]
        [Comment("The leading image of the post.")]
        public string PostTextHeadingImageURL { get; set; } = null!;

        [Required]
        [MinLength(BlogPostTextMinLength)]
        [Comment("The post text.")]
        public string PostText { get; set; } = null!;

        [Required]
        [Comment("Date of creation of the post.")]
        public DateTime CreatedOn { get; set; }

        [Comment("Blog post comments.")]
        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();

    }
}
