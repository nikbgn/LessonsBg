using LessonsBg.Areas.Teacher.Controllers;
using LessonsBg.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.TeacherArea.Tests
{
    public class SubjectsControllerTests
    {
        private readonly Mock<ISubjectsService> subjectsServiceMock = new Mock<ISubjectsService>();
        private readonly Mock<ITeacherService> teacherServiceMock = new Mock<ITeacherService>();
        private readonly Mock<ILocationService> locationServiceMock = new Mock<ILocationService>();
        private readonly Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
        private readonly Mock<ILogger<Areas.Teacher.Controllers.SubjectsController>> loggerMock = new Mock<ILogger<Areas.Teacher.Controllers.SubjectsController>>();

        [Fact]
        public async Task GET_Add_Should_Return_View()
        {
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = await homeController.Add();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task GET_Add_Should_Return_BadRequest()
        {
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            subjectsServiceMock.Setup(s => s.GetAllSubjectsAsync()).ThrowsAsync(new Exception());
            var result = await homeController.Add();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task MySubjects_Should_Return_BadRequest()
        {
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            teacherServiceMock.Setup(s => s.GetTeacherSubjectsAsync("asdsadsad")).ThrowsAsync(new Exception());
            var result = await homeController.MySubjects();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task POST_Add_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            teacherServiceMock.Setup(t => t.AddSubjectToSubjectsCollectionAsync(guid,"adsadsadsa")).ThrowsAsync(new Exception());
            var result = await homeController.Add(guid);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GET_ChangeTeachingLocation_Should_Return_View()
        {
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = await homeController.ChangeTeachingLocation();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task GET_ChangeTeachingLocation_Should_Return_BadRequest()
        {
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            locationServiceMock.Setup(l => l.GetLocationsAsync()).ThrowsAsync(new Exception());
            var result = await homeController.ChangeTeachingLocation();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Remove_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            var homeController = new Areas.Teacher.Controllers.SubjectsController
                (subjectsServiceMock.Object,
                teacherServiceMock.Object,
                locationServiceMock.Object,
                accountServiceMock.Object,
                loggerMock.Object);

            teacherServiceMock.Setup(t => t.RemoveSubjectFromSubjectsCollectionAsync(guid, "adsadsadsa")).ThrowsAsync(new Exception());
            var result = await homeController.Remove(guid);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
