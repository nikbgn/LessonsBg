using LessonsBg.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.TrainerArea.Tests
{
    public class TrainingsController
    {
        private readonly Mock<ITrainingsService> trainingsServiceMock = new Mock<ITrainingsService>();
        private readonly Mock<ITrainerService> trainerServiceMock = new Mock<ITrainerService>();
        private readonly Mock<ILocationService> locationServiceMock = new Mock<ILocationService>();
        private readonly Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
        private readonly Mock<ILogger<Areas.Trainer.Controllers.TrainingsController>> loggerMock = new Mock<ILogger<Areas.Trainer.Controllers.TrainingsController>>();

        [Fact]
        public async Task GET_Add_Should_Return_View()
        {
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = await trainingsController.Add();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_Add_Should_Return_BadRequest()
        {
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            trainingsServiceMock.Setup(t => t.GetAllTrainingsAsync()).ThrowsAsync(new Exception());
            
            var result = await trainingsController.Add();

            Assert.IsType<BadRequestResult>(result);

        }


        [Fact]
        public async Task POST_Add_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();

            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            trainerServiceMock.Setup(t => t.AddTrainingToTrainingsCollectionAsync(guid,"sadsadsad")).ThrowsAsync(new Exception());
            var result = await trainingsController.Add(guid);

            Assert.IsType<BadRequestResult>(result);

        }

        [Fact]
        public async Task GET_MyTrainings_Should_Return_BadRequest()
        {
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            trainerServiceMock.Setup(t => t.GetTrainerTrainingsAsync("asdsadsadsa")).ThrowsAsync(new Exception());
            var result = await trainingsController.MyTrainings();

            Assert.IsType<BadRequestResult>(result);

        }

        [Fact]
        public async Task Remove_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            trainerServiceMock.Setup(t => t.RemoveTrainingFromTrainingsCollectionAsync(guid,"asdsadsad")).ThrowsAsync(new Exception());
            var result = await trainingsController.Remove(guid);

            Assert.IsType<BadRequestResult>(result);

        }

        [Fact]
        public async Task GET_ChangeTeachingLocation_Should_Return_View()
        {
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = await trainingsController.ChangeTeachingLocation();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_ChangeTeachingLocation_Should_Return_BadRequest()
        {
            var trainingsController = new Areas.Trainer.Controllers.TrainingsController
                (trainingsServiceMock.Object,
                trainerServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            locationServiceMock.Setup(l => l.GetLocationsAsync()).ThrowsAsync(new Exception());
            var result = await trainingsController.ChangeTeachingLocation();

            Assert.IsType<BadRequestResult>(result);

        }
    }
}
