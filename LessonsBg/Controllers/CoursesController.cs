namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;

	public class CoursesController : Controller
	{

		private readonly ICourseService courseService;

		public CoursesController(ICourseService _courseService)
		{
			courseService = _courseService;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			var courses = await courseService.GetAllCoursesAsync();
			return View(courses);
		}
	}
}
