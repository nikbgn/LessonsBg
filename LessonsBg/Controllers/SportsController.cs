namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;

    [AutoValidateAntiforgeryToken]
    public class SportsController : Controller
	{
		private readonly ITrainingsService trainingsService;
		private readonly ITrainerService trainerService;
		private readonly ILogger<SportsController> logger;

		public SportsController
			(ITrainingsService _trainingsService,
			ITrainerService _trainerService,
			ILogger<SportsController> _logger)
		{
			trainingsService = _trainingsService;
			trainerService = _trainerService;
			logger = _logger;
		}

		[ResponseCache(CacheProfileName = "DefaultCacheProfile30s")]
		public async Task<IActionResult> All()
		{
			try
			{
				var trainingTypesNames = await trainingsService.GetAllTrainingTypesNamesAsync();
				var allSportsModel = await trainingsService.GetAllSportsAsync(trainingTypesNames);

				return View(allSportsModel);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }

		}

		[HttpGet]
		[Route("/Sports/TrainingsFor/{trainingName}")]
		public async Task<IActionResult> TrainingsFor(string trainingName, string teachingLocation = "Онлайн")
		{
			var trainingNames = await trainingsService.GetAllTrainingsNamesAsync();
			if (!trainingNames.Any(t => t == trainingName))
			{
				return BadRequest();
			}

			try
			{
				var trainers = await trainerService.GetTrainersCardsForTrainingAsync(trainingName, teachingLocation);
				return View(trainers);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
