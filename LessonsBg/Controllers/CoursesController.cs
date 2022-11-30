namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;

	public class CoursesController : Controller
	{

		private readonly ICourseService courseService;
		private readonly ILocationService locationService;
		private readonly ILogger<CoursesController> logger;

		public CoursesController(
			ICourseService _courseService,
			ILocationService _locationService,
			ILogger<CoursesController> _logger
			)
		{
			courseService = _courseService;
			locationService = _locationService;
			logger = _logger;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{

			try
			{
				var courses = await courseService.GetAllCoursesAsync();
				return View(courses);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}



		[HttpGet]
		[Route("/Courses/ReadMore/{courseId}")]
		public async Task<IActionResult> ReadMore(Guid courseId)
		{
			try
			{
				var course = await courseService.GetCourseInDepthInfoById(courseId);
				var courseLocation = await locationService.GetLocationByIdAsync(course.CourseModel.LocationId);
				var courseType = await courseService.GetCourseTypeByIdAsync(course.CourseModel.CourseTypeId);

				course.LocationModel = courseLocation;
				course.CourseTypeModel = courseType;
				return View(course);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}
	}
}
