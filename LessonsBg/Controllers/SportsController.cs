namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Contracts;

    using Microsoft.AspNetCore.Mvc;

    public class SportsController : Controller
    {
        private readonly ITrainingsService trainingsService;
        private readonly ITrainerService trainerService;

        public SportsController(ITrainingsService _trainingsService,
            ITrainerService _trainerService)
        {
            trainingsService = _trainingsService;
            trainerService = _trainerService;
        }

        public async Task<IActionResult> All()
        {
            var trainingTypesNames = await trainingsService.GetAllTrainingTypesNamesAsync();
            var allSportsModel = await trainingsService.GetAllSportsAsync(trainingTypesNames);

            return View(allSportsModel);
        }

        [HttpPost]
        public async Task<IActionResult> TrainingsFor(string trainingName)
        {
            var trainingNames = await trainingsService.GetAllTrainingsNamesAsync();
            if(!trainingNames.Any(t => t == trainingName))
            {
                return BadRequest();
            }

            var trainers = await trainerService.GetTrainersCardsForTrainingAsync(trainingName);
            return View(trainers);
        }
    }
}
