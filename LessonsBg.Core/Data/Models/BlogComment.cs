namespace LessonsBg.Core.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using static LessonsBg.Core.Data.DataValidationConstants.BlogCommentValidation;

    [Comment("Comments under a blog post.")]
    public class BlogComment
    {
        [Key]
        [Comment("Primary key.")]
        public int Id { get; set; }

        [Required]
        [StringLength(BlogCommentTextMaxLength, MinimumLength = BlogCommentTextMinLength)]
        [Comment("Blog comment text.")]
        public string CommentText { get; set; } = null!;

        [Required]
        [Comment("Date of creation of the blog commment.")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Author ID")]
        public string AuthorId { get; set; } = null!;

        [ForeignKey(nameof(AuthorId))]
        public ApplicationUser Author { get; set; } = null!;

        [Required]
        [Comment("BlogPost ID")]
        public Guid BlogPostId { get; set; }

        [ForeignKey(nameof(BlogPostId))]
        public BlogPost BlogPost { get; set; } = null!;
    }
}
