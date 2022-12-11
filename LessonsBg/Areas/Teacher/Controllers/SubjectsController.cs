namespace LessonsBg.Areas.Teacher.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Teacher")]
	[Authorize(Roles = $"{RoleConstants.Administrator},{RoleConstants.Teacher}")]
    [AutoValidateAntiforgeryToken]
    public class SubjectsController : Controller
	{

		private readonly ISubjectsService subjectsService;
		private readonly ITeacherService teacherService;
		private readonly ILocationService locationService;
		private readonly IAccountService accountService;
		private readonly ILogger<SubjectsController> logger;

		public SubjectsController(
			ISubjectsService _subjectsService,
			ITeacherService _teacherService,
			ILocationService _locationService,
			IAccountService _accountService,
			ILogger<SubjectsController> _logger)
		{
			subjectsService = _subjectsService;
			locationService = _locationService;
			accountService = _accountService;
			teacherService = _teacherService;
			logger = _logger;
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			try
			{
				var subjects = await subjectsService.GetAllSubjectsAsync();
				return View(subjects);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpPost]
		public async Task<IActionResult> Add(Guid sId)
		{
			try
			{
				var teacherId = User.Id();
				await teacherService.AddSubjectToSubjectsCollectionAsync(sId, teacherId);
				return RedirectToAction(nameof(Add));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		public async Task<IActionResult> MySubjects()
		{
			try
			{
				var teacherId = User.Id();
				var subjects = await teacherService.GetTeacherSubjectsAsync(teacherId);
				return View(subjects);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		public async Task<IActionResult> ChangeTeachingLocation()
		{
			try
			{
				var model = new ChangeTeachingLocationModel();
				var locations = await locationService.GetLocationsAsync();
				model.Locations = locations;
				return View(model);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}		
		[HttpPost]
		public async Task<IActionResult> ChangeTeachingLocation(string teachingLocation)
		{
			try
			{
				await accountService.ChangeUserTeachingLocationAsync(User.Id(), teachingLocation);
				return RedirectToAction("Index", "Home", new { area = "Teacher" });
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		public async Task<IActionResult> Remove(Guid sId)
		{
			try
			{
				var teacherId = User.Id();
				await teacherService.RemoveSubjectFromSubjectsCollectionAsync(sId, teacherId);
				return RedirectToAction(nameof(MySubjects));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

	}
}
