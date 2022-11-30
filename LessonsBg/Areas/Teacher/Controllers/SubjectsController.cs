namespace LessonsBg.Areas.Teacher.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Teacher")]
	[Authorize(Roles = $"{RoleConstants.Administrator},{RoleConstants.Teacher}")]
	public class SubjectsController : Controller
	{

		private readonly ISubjectsService subjectsService;
		private readonly ITeacherService teacherService;
		private readonly ILogger<SubjectsController> logger;

		public SubjectsController(
			ISubjectsService _subjectsService,
			ITeacherService _teacherService,
			ILogger<SubjectsController> _logger)
		{
			subjectsService = _subjectsService;
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
