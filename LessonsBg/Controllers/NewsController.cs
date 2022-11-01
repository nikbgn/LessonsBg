namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Models;

    using Microsoft.AspNetCore.Mvc;

    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService _newsService)
        {
            newsService = _newsService;
        }

        public async Task<IActionResult> Index()
        {
            var news = await newsService.GetAllNewsAsync();
            return View(news);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new NewsArticleModel();
            ViewData["Tittle"] = "Добави новина";
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(NewsArticleModel model)
        {
            ViewData["Tittle"] = "Добави новина";

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await newsService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
