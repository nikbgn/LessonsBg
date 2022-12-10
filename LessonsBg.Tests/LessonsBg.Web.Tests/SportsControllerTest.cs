using LessonsBg.Core.Contracts;
using LessonsBg.Core.Models;
using LessonsBg.Core.Models.Trainer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
    public class SportsControllerTest
    {
        private readonly Mock<ITrainingsService> trainingsServiceMock = new Mock<ITrainingsService>();
        private readonly Mock<ITrainerService> trainerServiceMock = new Mock<ITrainerService>();
        private readonly Mock<ILogger<SportsController>> loggerMock = new Mock<ILogger<SportsController>>();


        [Fact]
        public async Task All_Should_Return_View()
        {
            var sportsController = new SportsController(trainingsServiceMock.Object, trainerServiceMock.Object, loggerMock.Object);

            var result = await sportsController.All();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task All_Should_Return_BadRequest()
        {
            trainingsServiceMock.Setup(t => t.GetAllTrainingTypesNamesAsync()).ThrowsAsync(new Exception());
            trainingsServiceMock.Setup(t => t.GetAllSportsAsync(new List<string>())).ThrowsAsync(new Exception());
            var sportsController = new SportsController(trainingsServiceMock.Object, trainerServiceMock.Object, loggerMock.Object);

            var result = await sportsController.All();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task TrainingsFor_Should_Return_View()
        {
            var trainingName = "Волейбол";
            var teachingLocation = "Онлайн";
            var trainingsForQueryModel = new TrainingsForQueryModel()
            {
                TrainerCards = new List<TrainerCardModel>(),
                Locations = new List<LocationModel>(),
                TeachingLocation = teachingLocation
            };
            trainingsServiceMock.Setup(t => t.GetAllTrainingsNamesAsync()).ReturnsAsync(new List<string>() { "Волейбол"});
            trainerServiceMock.Setup(t => t.GetTrainersCardsForTrainingAsync(trainingName, teachingLocation)).ReturnsAsync(trainingsForQueryModel);
            var sportsController = new SportsController(trainingsServiceMock.Object, trainerServiceMock.Object, loggerMock.Object);
            var result = await sportsController.TrainingsFor(trainingName, teachingLocation);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task TrainingsFor_Should_Return_BadRequest()
        {
            var trainingName = "Волейбол";
            var teachingLocation = "Онлайн";
            var trainingsForQueryModel = new TrainingsForQueryModel()
            {
                TrainerCards = new List<TrainerCardModel>(),
                Locations = new List<LocationModel>(),
                TeachingLocation = teachingLocation
            };
            trainingsServiceMock.Setup(t => t.GetAllTrainingsNamesAsync()).ReturnsAsync(new List<string>() { "BADDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD" });
            trainerServiceMock.Setup(t => t.GetTrainersCardsForTrainingAsync(trainingName, teachingLocation)).ThrowsAsync(new Exception());
            var sportsController = new SportsController(trainingsServiceMock.Object, trainerServiceMock.Object, loggerMock.Object);
            var result = await sportsController.TrainingsFor(trainingName, teachingLocation);
            trainingsServiceMock.Setup(t => t.GetAllTrainingsNamesAsync()).ReturnsAsync(new List<string>() { "Волейбол" });
            var result2 = await sportsController.TrainingsFor(trainingName, teachingLocation);

            Assert.IsType<BadRequestResult>(result);
            Assert.IsType<BadRequestResult>(result2);
        }

    }
}
