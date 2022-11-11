namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Models;
    using LessonsBg.Core.Services;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Blog with interesting posts.
    /// </summary>

    public class BlogController : Controller
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService _blogService)
        {
            blogService = _blogService;
        }

        /// <summary>
        /// Displays a page with blog posts.
        /// </summary>
        /// <returns></returns>

        public async Task<IActionResult> Index()
        {
            var blogPosts = await blogService.GetAllAsync();
            ViewData["Title"] = "Блог";

            return View(blogPosts.OrderByDescending(c=>c.CreatedOn.Day));
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

			await blogService.AddAsync(model);

			return RedirectToAction(nameof(Index));
		}

        [HttpGet]
        [Route("/Blog/ViewPost/blogPostId={blogPostId}")]
        public async Task <IActionResult> ViewPost(Guid blogPostId)
        {
            var post = await blogService.GetPostAsync(blogPostId);
            return View(post);
        }
	}
}
