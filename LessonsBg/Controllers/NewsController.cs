namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	public class NewsController : Controller
	{
		private readonly INewsService newsService;
		private readonly ILogger<NewsController> logger;

		public NewsController(INewsService _newsService, ILogger<NewsController> _logger)
		{
			newsService = _newsService;
			logger = _logger;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			try
			{
				var news = await newsService.GetAllNewsAsync();

				news = news
					.OrderByDescending(a => a.CreatedOn)
					.ToList();

				return View(news);	
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		[Authorize(Roles = RoleConstants.Administrator)]
		public IActionResult Add()
		{
			try
			{
				var model = new NewsArticleModel();
				ViewData["Title"] = "Добави новина";
				return View(model);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpPost]
		[Authorize(Roles = RoleConstants.Administrator)]
		public async Task<IActionResult> Add(NewsArticleModel model)
		{
			ViewData["Title"] = "Добави новина";

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				await newsService.AddAsync(model);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[Authorize(Roles = RoleConstants.Administrator)]
		public async Task<IActionResult> Delete(Guid newsArticleId)
		{
			try
			{
				await newsService.RemoveAsync(newsArticleId);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		[Route("/News/ViewArticle/{newsArticleId}")]
		public async Task<IActionResult> ViewArticle(Guid newsArticleId)
		{
			try
			{
				var article = await newsService.GetNewsArticleAsync(newsArticleId);
				return View(article);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
