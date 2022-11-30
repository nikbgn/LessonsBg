namespace LessonsBg.Core.Models.Blog
{
    using System.ComponentModel.DataAnnotations;

    using static LessonsBg.Core.Data.DataValidationConstants.BlogCommentValidation;

    public class BlogCommentModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = ThisFieldIsRequiredErrorMessage)]
        [StringLength(
            BlogCommentTextMaxLength,
            MinimumLength = BlogCommentTextMinLength,
            ErrorMessage = BlogCommentLengthErrorMessage)]
        public string CommentText { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string AuthorId { get; set; } = null!;

        [Required]
        public Guid BlogPostId { get; set; }
    }
}
