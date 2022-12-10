using Microsoft.AspNetCore.Mvc;

namespace LessonsBg.Tests.LessonsBg.Web.TeacherArea.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Should_Return_View()
        {
            var homeController = new Areas.Teacher.Controllers.HomeController();

            var result = homeController.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
