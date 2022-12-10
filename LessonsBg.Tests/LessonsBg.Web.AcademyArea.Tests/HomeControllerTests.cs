using Microsoft.AspNetCore.Mvc;

namespace LessonsBg.Tests.LessonsBg.Web.AcademyArea.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Should_Return_View()
        {
            var homeController = new Areas.Academy.Controllers.HomeController();

            var result = homeController.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
