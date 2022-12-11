namespace LessonsBg.Controllers
{
	using System.Diagnostics;

	using LessonsBg.Models;

	using Microsoft.AspNetCore.Mvc;

	[AutoValidateAntiforgeryToken]
	public class HomeController : Controller
	{
        [ResponseCache(CacheProfileName = "DefaultCacheProfile30s")]
        public IActionResult Index()
		{
			return View();
		}

        [ResponseCache(CacheProfileName = "DefaultCacheProfile30s")]
        public IActionResult About()
        {
            return View();
        }

	}
}