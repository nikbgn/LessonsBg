namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Logging;

    [AutoValidateAntiforgeryToken]
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

		[ResponseCache(CacheProfileName = "DefaultCacheProfile30s")]
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

		[HttpGet]
		[Route("/Lessons/LessonsFor/{subjectName}")]

		public async Task<IActionResult> LessonsFor(string subjectName, string teachingLocation = "Онлайн")
		{
			var subjectNames = await subjectsService.GetAllSubjectNamesAsync();
			if (!subjectNames.Any(s => s == subjectName))
			{
				return BadRequest();
			}

			try
			{
				var teachers = await teachersService.GetTeachersCardsForSubjectAsync(subjectName, teachingLocation);
				return View(teachers);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
