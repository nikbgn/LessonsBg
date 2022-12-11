namespace LessonsBg.Areas.Academy.Controllers
{
    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Models.Course;
    using LessonsBg.Extensions;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Area("Academy")]
	[Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Academy}")]
    [AutoValidateAntiforgeryToken]
    public class CoursesController : Controller
	{

		private readonly IAcademyService academyService;
		private readonly ILocationService locationService;
		private readonly ICourseService courseService;
		private readonly ILogger<CoursesController> logger;

		public CoursesController(
			IAcademyService _academyService,
			ILocationService _locationService,
			ICourseService _courseService,
			ILogger<CoursesController> _logger)
		{
			academyService = _academyService;
			locationService = _locationService;
			courseService = _courseService;
			logger = _logger;
		}


		[HttpGet]
		public async Task<IActionResult> CreateCourse()
		{

			try
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
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpPost]
		public async Task<IActionResult> CreateCourse(CreateCourseModel model)
		{

			try
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
				await academyService.CreateCourse(academy, model, location, courseType);
				return RedirectToAction(nameof(MyCourses));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		public async Task<IActionResult> MyCourses()
		{
			try
			{
				var academyId = User.Id();
				var myCourses = await academyService.GetAcademyCoursesAsync(academyId);
				return View(myCourses);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		[Route("/Academy/Courses/EditCourse/{courseId}")]
		public async Task<IActionResult> EditCourse(Guid courseId)
		{
			try
			{
				bool confirmAuthor = await academyService.CheckAcademyIsAuthorOfCourse(User.Id(), courseId);

				if (!confirmAuthor && !User.IsInRole(RoleConstants.Administrator))
				{
					return RedirectToAction("AccessDenied", "Account", new {area=""});
				}

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
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpPost]
		public async Task<IActionResult> EditCourse(CreateCourseModel model)
		{
			try
			{
				await academyService.EditCourseAsync(model);
				return RedirectToAction(nameof(MyCourses));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[Route("/Academy/Courses/Delete/{courseId}")]
		public async Task<IActionResult> Delete(Guid courseId)
		{
			try
			{
				bool confirmAuthor = await academyService.CheckAcademyIsAuthorOfCourse(User.Id(), courseId);

				if (!confirmAuthor && !User.IsInRole(RoleConstants.Administrator))
				{
					return RedirectToAction("AccessDenied", "Account", new { area = "" });
				}

				await academyService.RemoveCourse(courseId);

				return RedirectToAction(nameof(MyCourses));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}





	}
}
