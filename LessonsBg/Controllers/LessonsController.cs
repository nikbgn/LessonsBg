namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Logging;

	public class LessonsController : Controller
	{

		private readonly ISubjectsService subjectsService;
		private readonly ITeacherService teachersService;
		private readonly ILogger<LessonsController> logger;

		public LessonsController(
			ISubjectsService _subjectsService,
			ITeacherService _teachersService,
			ILogger<LessonsController> _logger)
		{
			subjectsService = _subjectsService;
			teachersService = _teachersService;
			logger = _logger;
		}


		public async Task<IActionResult> All()
		{

			try
			{
				var subjectTypesNames = await subjectsService.GetAllSubjectTypesNamesAsync();
				var allLessonsModel = await subjectsService.GetAllLessonsAsync(subjectTypesNames);

				return View(allLessonsModel);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}

		[HttpPost]
		public async Task<IActionResult> LessonsFor(string subjectName)
		{
			var subjectNames = await subjectsService.GetAllSubjectNamesAsync();
			if (!subjectNames.Any(s => s == subjectName))
			{
				return BadRequest();
			}

			try
			{
				var teachers = await teachersService.GetTeachersCardsForSubjectAsync(subjectName);
				return View(teachers);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
