namespace LessonsBg.Tests.LessonsBg.Web.Tests
{

    using global::LessonsBg.Core.Contracts;
    using global::LessonsBg.Core.Services;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    using Moq;

    public class LessonsControllerTest
    {
        private readonly Mock<ISubjectsService> mockSubjectService = new Mock<ISubjectsService>();
        private readonly Mock<ITeacherService> mockTeacherService = new Mock<ITeacherService>();
        private readonly Mock<ILogger<LessonsController>> mockILoggerService = new Mock<ILogger<LessonsController>>();
        private readonly Mock<ILogger<SubjectsService>> mockILoggerServiceSubjectService = new Mock<ILogger<SubjectsService>>();

        [Fact]
        public async Task All_Should_Return_View()
        {
            var lessonsController = new LessonsController(mockSubjectService.Object,mockTeacherService.Object,mockILoggerService.Object);

            var result = await lessonsController.All();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task All_Should_Return_BadRequest()
        {
            mockSubjectService.Setup(s => s.GetAllSubjectTypesNamesAsync()).ThrowsAsync(new Exception());
            var lessonsController = new LessonsController(mockSubjectService.Object, mockTeacherService.Object, mockILoggerService.Object);

            var result = await lessonsController.All();

            Assert.NotNull(result);
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GET_LessonsFor_Should_Return_View()
        {
            DatabaseSetup db = new DatabaseSetup();

            var subjectService = new SubjectsService(db.DbContext,mockILoggerServiceSubjectService.Object);
            var lessonsController = new LessonsController(subjectService, mockTeacherService.Object, mockILoggerService.Object);

            var result = await lessonsController.LessonsFor("Математика","Онлайн");

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

            db.DbContext.Dispose();
        }

        [Fact]
        public async Task GET_LessonsFor_Should_Return_BadRequest()
        {
            DatabaseSetup db = new DatabaseSetup();

            var badName = "fafafafafafafafa";
            var teachingLocation = "Онлайн";

            var subjectService = new SubjectsService(db.DbContext, mockILoggerServiceSubjectService.Object);
            var lessonsController = new LessonsController(subjectService, mockTeacherService.Object, mockILoggerService.Object);
            mockTeacherService.Setup(g => g.GetTeachersCardsForSubjectAsync(badName, teachingLocation)).ThrowsAsync(new Exception());

            var result = await lessonsController.LessonsFor(badName, teachingLocation);
            var result2 = await lessonsController.LessonsFor(badName, teachingLocation);

            Assert.IsType<BadRequestResult>(result);
            Assert.IsType<BadRequestResult>(result2);

            db.DbContext.Dispose();
        }

    }
}
