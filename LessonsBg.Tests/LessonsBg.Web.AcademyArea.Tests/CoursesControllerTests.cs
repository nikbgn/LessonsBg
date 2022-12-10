using LessonsBg.Core.Contracts;
using LessonsBg.Core.Models;
using LessonsBg.Core.Models.Course;
using LessonsBg.Core.Services;
using LessonsBg.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NuGet.Protocol.Core.Types;
using System.Security.Claims;

namespace LessonsBg.Tests.LessonsBg.Web.AcademyArea.Tests
{
    public class CoursesControllerTests
    {

        private readonly Mock<IAcademyService> academyServiceMock = new Mock<IAcademyService>();
        private readonly Mock<ILocationService> locationServiceMock = new Mock<ILocationService>();
        private readonly Mock<ICourseService> courseServiceMock = new Mock<ICourseService>();
        private readonly Mock<ILogger<Areas.Academy.Controllers.CoursesController>> loggerMock = new Mock<ILogger<Areas.Academy.Controllers.CoursesController>>();

        [Fact]
        public async Task GET_CreateCourse_Should_Return_View()
        {
            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var result = await coursesController.CreateCourse();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

        }        
        [Fact]
        public async Task POST_CreateCourse_Should_Return_RedirectToAction()
        {
            var courseModel = new CourseModel()
            {

                CourseImageURL = "https://www.some-link.com/some_image.png",
                CourseName = "Course for beginners",
                CourseDescription = "This is a very nice course for beginners",
                CourseTypeId = 1,
                LocationId = 1,
                PhoneNumber = "0891244589",
                Website = null
            };

            var locationModel = new LocationModel()
            {
                Id = 1,
                Name = "Online",
                Region = "Online"
            };

            var courseTypeModel = new CourseTypeModel()
            {
                Id = 1,
                Type = "Пиано"
            };

            var createCourseModel = new CreateCourseModel()
            {
                CourseModel = courseModel,
                Locations = new List<LocationModel>(),
                CourseTypes = new List<CourseTypeModel>()
            };


            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            var result = await coursesController.CreateCourse(createCourseModel);

            Assert.NotNull(result);
            Assert.IsType<RedirectToActionResult>(result);

        }

        [Fact]
        public async Task POST_CreateCourse_Should_Return_View_InvalidModelState()
        {
            var courseModel = new CourseModel()
            {

                CourseImageURL = "https://www.some-link.com/some_image.png",
                CourseName = "Course for beginners",
                CourseDescription = "This is a very nice course for beginners",
                CourseTypeId = 1,
                LocationId = 1,
                PhoneNumber = "0891244589",
                Website = null
            };

            var locationModel = new LocationModel()
            {
                Id = 1,
                Name = "Online",
                Region = "Online"
            };

            var courseTypeModel = new CourseTypeModel()
            {
                Id = 1,
                Type = "Пиано"
            };

            var createCourseModel = new CreateCourseModel()
            {
                CourseModel = courseModel,
                Locations = new List<LocationModel>(),
                CourseTypes = new List<CourseTypeModel>()
            };


            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            coursesController.ModelState.AddModelError("", "Error");
            var result = await coursesController.CreateCourse(createCourseModel);

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task POST_CreateCourse_Should_Return_BadRequest()
        {
            var createCourseModel = new Mock<CreateCourseModel>().Object;

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);


            var result = await coursesController.CreateCourse(createCourseModel);


            Assert.IsType<BadRequestResult>(result);

        }

        [Fact]
        public async Task GET_MyCourses_Should_Return_View()
        {
            var createCourseModel = new Mock<CreateCourseModel>().Object;

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };


            var result = await coursesController.MyCourses();


            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_MyCourses_Should_Return_BadRequest()
        {
            var createCourseModel = new Mock<CreateCourseModel>().Object;

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.GetAcademyCoursesAsync(user.Id())).ThrowsAsync(new Exception());
            var result = await coursesController.MyCourses();


            Assert.IsType<BadRequestResult>(result);

        }


        [Fact]
        public async Task GET_CreateCourse_Should_Return_BadRequest()
        {
            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            locationServiceMock.Setup(l => l.GetLocationsAsync()).ThrowsAsync(new Exception());
            courseServiceMock.Setup(c => c.GetCourseTypesAsync()).ThrowsAsync(new Exception());

            var result = await coursesController.CreateCourse();

            Assert.IsType<BadRequestResult>(result);
        }


        [Fact]
        public async Task GET_EditCourse_Should_Return_View()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(),guid)).ReturnsAsync(true);

            var result = await coursesController.EditCourse(guid);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task GET_EditCourse_Should_Return_RedirectToAction()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "NotAdministrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(), guid)).ReturnsAsync(false);

            var result = await coursesController.EditCourse(guid);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task GET_EditCourse_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(), guid)).ThrowsAsync(new Exception());

            var result = await coursesController.EditCourse(guid);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task POST_EditCourse_Should_Return_RedirectToAction()
        {

            var courseModel = new CourseModel()
            {

                CourseImageURL = "https://www.some-link.com/some_image.png",
                CourseName = "Course for beginners",
                CourseDescription = "This is a very nice course for beginners",
                CourseTypeId = 1,
                LocationId = 1,
                PhoneNumber = "0891244589",
                Website = null
            };

            var locationModel = new LocationModel()
            {
                Id = 1,
                Name = "Online",
                Region = "Online"
            };

            var courseTypeModel = new CourseTypeModel()
            {
                Id = 1,
                Type = "Пиано"
            };

            var createCourseModel = new CreateCourseModel()
            {
                CourseModel = courseModel,
                Locations = new List<LocationModel>(),
                CourseTypes = new List<CourseTypeModel>()
            };


            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var result = await coursesController.EditCourse(createCourseModel);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task POST_EditCourse_Should_Return_BadRequest()
        {

            var courseModel = new CourseModel()
            {

                CourseImageURL = "https://www.some-link.com/some_image.png",
                CourseName = "Course for beginners",
                CourseDescription = "This is a very nice course for beginners",
                CourseTypeId = 1,
                LocationId = 1,
                PhoneNumber = "0891244589",
                Website = null
            };

            var locationModel = new LocationModel()
            {
                Id = 1,
                Name = "Online",
                Region = "Online"
            };

            var courseTypeModel = new CourseTypeModel()
            {
                Id = 1,
                Type = "Пиано"
            };

            var createCourseModel = new CreateCourseModel()
            {
                CourseModel = courseModel,
                Locations = new List<LocationModel>(),
                CourseTypes = new List<CourseTypeModel>()
            };


            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            academyServiceMock.Setup(a => a.EditCourseAsync(createCourseModel)).ThrowsAsync(new Exception());
            var result = await coursesController.EditCourse(createCourseModel);

            Assert.IsType<BadRequestResult>(result);
        }


        [Fact]
        public async Task Delete_Should_Return_RedirectToAction()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(), guid)).ReturnsAsync(true);

            var result = await coursesController.Delete(guid);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task Delete_Should_Return_RedirectToAction_On_ConfirmAuthorFailure()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "NotAdministrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(), guid)).ReturnsAsync(false);

            var result = await coursesController.Delete(guid);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task Delete_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();

            var coursesController = new Areas.Academy.Controllers.CoursesController
                (academyServiceMock.Object,
                locationServiceMock.Object,
                courseServiceMock.Object,
                loggerMock.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Name, "dedeed@de.com"),
                                        new Claim(ClaimTypes.Role, "Administrator")
                                   }, "TestAuthentication"));

            coursesController.ControllerContext = new ControllerContext();
            coursesController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };

            academyServiceMock.Setup(a => a.CheckAcademyIsAuthorOfCourse(user.Id(), guid)).ThrowsAsync(new Exception());

            var result = await coursesController.Delete(guid);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
