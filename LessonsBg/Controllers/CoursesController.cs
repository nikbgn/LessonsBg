namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Services;

	using Microsoft.AspNetCore.Mvc;

	public class CoursesController : Controller
	{

		private readonly ICourseService courseService;
		private readonly ILocationService locationService;

		public CoursesController(ICourseService _courseService, ILocationService _locationService)
		{
			courseService = _courseService;
			locationService = _locationService;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			try
			{
				var courses = await courseService.GetAllCoursesAsync();
				return View(courses);
			}
			catch (Exception ex)
			{
				return BadRequest();
			}

		}



		[HttpGet]
		[Route("/Courses/ReadMore/courseId={courseId}")]
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
			catch (Exception ex)
			{
				//LOG exception message!
				return BadRequest();
			}

		}
	}
}
