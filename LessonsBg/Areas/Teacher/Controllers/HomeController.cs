namespace LessonsBg.Areas.Teacher.Controllers
{
	using LessonsBg.Core.Data;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Teacher")]
	[Authorize(Roles = $"{RoleConstants.Administrator},{RoleConstants.Teacher}")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
