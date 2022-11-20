namespace LessonsBg.Areas.Teacher.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;
	using LessonsBg.Core.Services;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Teacher")]
	[Authorize(Roles = $"{RoleConstants.Administrator},{RoleConstants.Teacher}")]
	public class SubjectsController : Controller
	{

		private readonly ISubjectsService subjectsService;
		private readonly ITeacherService teacherService;

		public SubjectsController(ISubjectsService _subjectsService, ITeacherService _teacherService)
		{
			subjectsService = _subjectsService;
			teacherService = _teacherService;
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		
		{
			var subjects = await subjectsService.GetAllSubjectsAsync();
			return View(subjects);
		}

		[HttpPost]
		public async Task<IActionResult> Add(Guid sId)
		{
			var teacherId = User.Id();
			await teacherService.AddSubjectToSubjectsCollectionAsync(sId, teacherId);
			return RedirectToAction(nameof(Add));
		}

		[HttpGet]
		public async Task<IActionResult> MySubjects()
		{
			var teacherId = User.Id();
			var subjects = await teacherService.GetTeacherSubjectsAsync(teacherId);
			return View(subjects);
		}

		public async Task<IActionResult> Remove(Guid sId)
		{
			var teacherId = User.Id();
			await teacherService.RemoveSubjectFromSubjectsCollectionAsync(sId, teacherId);
			return RedirectToAction(nameof(MySubjects));
		}

	}
}
