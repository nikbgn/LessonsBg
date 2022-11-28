namespace LessonsBg.Areas.Academy.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Academy")]
	[Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Academy}")]
	public class CoursesController : Controller
	{

		private readonly IAcademyService academyService;
		private readonly ILocationService locationService;
		private readonly ICourseService courseService;

		public CoursesController(
			IAcademyService _academyService, 
			ILocationService _locationService,
			ICourseService _courseService)
		{
			academyService = _academyService;
			locationService = _locationService;
			courseService = _courseService;
		}


		[HttpGet]
		public async Task<IActionResult> CreateCourse()
		{

			var locations = await locationService.GetLocationsAsync();
			var courseTypes = await courseService.GetCourseTypesAsync();

			var model = new CreateCourseModel()
			{
				CourseModel = new CourseModel(),
				Locations = locations,
				CourseTypes = courseTypes
			};
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCourse(CreateCourseModel model)
		{
			
			model.Locations = await locationService.GetLocationsAsync();
			model.CourseTypes = await courseService.GetCourseTypesAsync();
			
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var academy = User.Id();
			var location = await locationService.GetLocationByIdAsync(model.CourseModel.LocationId);
			var courseType = await courseService.GetCourseTypeByIdAsync(model.CourseModel.CourseTypeId);
			await academyService.CreateCourse(academy,model,location,courseType);
			return RedirectToAction(nameof(MyCourses));
		}

		[HttpGet]
		public async Task<IActionResult> MyCourses()
		{
			var academyId = User.Id();
			var myCourses = await academyService.GetAcademyCoursesAsync(academyId);
			return View(myCourses);
		}

		[HttpGet]
		[Route("/Academy/Courses/EditCourse/{courseId}")]
		public async Task<IActionResult> EditCourse(Guid courseId)
		{
			var course = await courseService.GetCourseByIdAsync(courseId);
			var locations = await locationService.GetLocationsAsync();
			var courseTypes = await courseService.GetCourseTypesAsync();

			var model = new CreateCourseModel()
			{
				CourseModel = course,
				Locations = locations,
				CourseTypes = courseTypes
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> EditCourse(CreateCourseModel model)
		{
			await academyService.EditCourseAsync(model);
			return RedirectToAction(nameof(MyCourses));
		}



	}
}
