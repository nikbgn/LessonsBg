namespace LessonsBg.Controllers
{
	using System.Diagnostics;

	using LessonsBg.Models;

	using Microsoft.AspNetCore.Mvc;

	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult About()
        {
            return View();
        }

	}
}