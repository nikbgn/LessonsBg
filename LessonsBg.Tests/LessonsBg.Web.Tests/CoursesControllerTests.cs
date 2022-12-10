using LessonsBg.Core.Contracts;
using LessonsBg.Core.Models;
using LessonsBg.Core.Models.Course;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
    public class CoursesControllerTests
    {

        private readonly Mock<ICourseService> courseServiceMock = new Mock<ICourseService>();
        private readonly Mock<ILocationService> locationServiceMock = new Mock<ILocationService>();
        private readonly Mock<ILogger<CoursesController>> loggerMock = new Mock<ILogger<CoursesController>>();


        [Fact]
        public async Task All_Should_Return_View()
        {
            var coursesController = new CoursesController(courseServiceMock.Object, locationServiceMock.Object, loggerMock.Object);

            var result = await coursesController.All();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task All_Should_Return_BadRequest()
        {
            courseServiceMock.Setup(c => c.GetAllCoursesAsync()).ThrowsAsync(new Exception());
            var coursesController = new CoursesController(courseServiceMock.Object, locationServiceMock.Object, loggerMock.Object);

            var result = await coursesController.All();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task ReadMore_Should_Return_View()
        {
            var guid = Guid.NewGuid();
            var course = new ReadMoreCourseModel()
            {
                CourseModel = new CourseModel() { Id = guid},
                LocationModel = new LocationModel(),
                CourseTypeModel = new CourseTypeModel()
            };
            courseServiceMock.Setup(c => c.GetCourseInDepthInfoById(guid)).ReturnsAsync(course);
            var coursesController = new CoursesController(courseServiceMock.Object, locationServiceMock.Object, loggerMock.Object);

            var result = await coursesController.ReadMore(guid);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task ReadMore_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();

            var coursesController = new CoursesController(courseServiceMock.Object, locationServiceMock.Object, loggerMock.Object);

            var result = await coursesController.ReadMore(guid);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
