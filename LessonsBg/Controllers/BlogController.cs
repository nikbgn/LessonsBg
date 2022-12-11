namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Models.Blog;
    using LessonsBg.Extensions;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Blog with interesting posts.
    /// </summary>

    [AutoValidateAntiforgeryToken]
    public class BlogController : Controller
	{
		private readonly IBlogService blogService;
		private readonly ILogger<BlogController> logger;

		public BlogController(
			IBlogService _blogService,
			ILogger<BlogController> _logger)
		{
			blogService = _blogService;
			logger = _logger;
		}

		/// <summary>
		/// Displays a page with blog posts.
		/// </summary>
		/// <returns></returns>

		public async Task<IActionResult> Index()
		{

			try
			{
				var blogPosts = await blogService.GetAllAsync();
				ViewData["Title"] = "Блог";

				return View(blogPosts.OrderByDescending(c => c.CreatedOn.Day));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		[Authorize(Roles = RoleConstants.Administrator)]
		public IActionResult Add()
		{
			var model = new BlogPostModel();
			return View(model);
		}

		[HttpPost]
		[Authorize(Roles = RoleConstants.Administrator)]
		public async Task<IActionResult> Add(BlogPostModel model)
		{
			ViewData["Title"] = "Добави новина";

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await blogService.AddAsync(model);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}

		[HttpGet]
		[Route("/Blog/ViewPost/{blogPostId}")]
		public async Task<IActionResult> ViewPost(Guid blogPostId)
		{

			try
			{
				var post = await blogService.GetPostAsync(blogPostId);

				post.BlogComments = post.BlogComments
					.OrderByDescending(c => c.CreatedOn);

				return View(post);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}


		[Authorize(Roles = RoleConstants.Administrator)]
		public async Task<IActionResult> Delete(Guid blogPostId)
		{
			try
			{
				await blogService.RemoveAsync(blogPostId);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[Authorize]
		public async Task<IActionResult> AddComment(BlogCommentModel model, string authorId, Guid blogPostId)
		{
			try
			{
				authorId = User.Id();
				await blogService.AddCommentAsync(model, authorId, blogPostId);
				return RedirectToAction(nameof(ViewPost), new { blogPostId });
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[Authorize(Roles = RoleConstants.Administrator)]
		public async Task<IActionResult> RemoveComment(Guid blogPostId, int commentId)
		{
			try
			{
				await blogService.DeleteCommentAsync(blogPostId, commentId);
				return RedirectToAction(nameof(ViewPost), new {blogPostId});
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
