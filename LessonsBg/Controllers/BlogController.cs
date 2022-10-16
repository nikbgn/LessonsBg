namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Contracts;

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
            var blogPosts = await blogService.GetAll();
            ViewData["Title"] = "Блог";

            return View(blogPosts.ToList().OrderByDescending(c=>c.CreatedOn.Day));
        }
    }
}
