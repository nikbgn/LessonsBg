namespace LessonsBg.Areas.Trainer.Controllers
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Extensions;

	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Area("Trainer")]
	[Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Trainer}")]
	public class TrainingsController : Controller
	{
		private readonly ITrainingsService trainingsService;
		private readonly ITrainerService trainerService;

		public TrainingsController(ITrainingsService _trainingsService,
			ITrainerService _trainerService)
		{
			trainingsService = _trainingsService;
			trainerService = _trainerService;
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var trainings = await trainingsService.GetAllTrainingsAsync();
			return View(trainings);
		}

		[HttpPost]
		public async Task<IActionResult> Add(Guid trainingId)
		{
			var trainerId = User.Id();
			await trainerService.AddTrainingToTrainingsCollectionAsync(trainingId, trainerId);
			return RedirectToAction(nameof(Add));
		}

		[HttpGet]
		public async Task<IActionResult> MyTrainings()
		{
			var trainerId = User.Id();
			var trainings = await trainerService.GetTrainerTrainingsAsync(trainerId);
			return View(trainings);
		}

		public async Task<IActionResult> Remove(Guid trainingId)
		{
			var trainerId = User.Id();
			await trainerService.RemoveTrainingFromTrainingsCollectionAsync(trainingId, trainerId);
			return RedirectToAction(nameof(MyTrainings));
		}
	}
}
