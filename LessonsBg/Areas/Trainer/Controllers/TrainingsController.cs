namespace LessonsBg.Areas.Trainer.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;
	using LessonsBg.Core.Services;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Trainer")]
	[Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Trainer}")]
    [AutoValidateAntiforgeryToken]
    public class TrainingsController : Controller
	{
		private readonly ITrainingsService trainingsService;
		private readonly ITrainerService trainerService;
		private readonly ILocationService locationService;
		private readonly IAccountService accountService;
		private readonly ILogger<TrainingsController> logger;

		public TrainingsController(
			ITrainingsService _trainingsService,
			ITrainerService _trainerService,
			ILocationService _locationService,
			IAccountService _accountService,
			ILogger<TrainingsController> _logger)
		{
			trainingsService = _trainingsService;
			trainerService = _trainerService;
			locationService = _locationService;
			accountService = _accountService;
			logger = _logger;
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			try
			{
				var trainings = await trainingsService.GetAllTrainingsAsync();
				return View(trainings);
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpPost]
		public async Task<IActionResult> Add(Guid trainingId)
		{
			try
			{
				var trainerId = User.Id();
				await trainerService.AddTrainingToTrainingsCollectionAsync(trainingId, trainerId);
				return RedirectToAction(nameof(Add));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		[HttpGet]
		public async Task<IActionResult> MyTrainings()
		{
			try
			{
				var trainerId = User.Id();
				var trainings = await trainerService.GetTrainerTrainingsAsync(trainerId);
				return View(trainings);
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
				return RedirectToAction("Index", "Home", new { area = "Trainer" });
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}

		public async Task<IActionResult> Remove(Guid trainingId)
		{
			try
			{
				var trainerId = User.Id();
				await trainerService.RemoveTrainingFromTrainingsCollectionAsync(trainingId, trainerId);
				return RedirectToAction(nameof(MyTrainings));
			}
			catch (Exception ex) { logger.LogError($"ERROR MESSAGE: {ex.Message}"); return BadRequest(); }
		}
	}
}
