namespace LessonsBg.Core.Models
{
	using System.ComponentModel.DataAnnotations;

	using static LessonsBg.Core.Data.DataValidationConstants.BlogCommentValidation;

	public class BlogCommentModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(BlogCommentTextMaxLength, MinimumLength = BlogCommentTextMinLength)]
		public string CommentText { get; set; } = null!;

		[Required]
		public DateTime CreatedOn { get; set; }

		[Required]
		public string AuthorId { get; set; } = null!;

		[Required]
		public Guid BlogPostId { get; set; }
	}
}
