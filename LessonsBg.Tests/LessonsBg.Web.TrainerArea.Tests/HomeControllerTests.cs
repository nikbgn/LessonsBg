namespace LessonsBg.Tests.LessonsBg.Web.TrainerArea.Tests
{
    using Microsoft.AspNetCore.Mvc;
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Should_Return_View()
        {
            var homeController = new Areas.Trainer.Controllers.HomeController();

            var result = homeController.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

    }
}
