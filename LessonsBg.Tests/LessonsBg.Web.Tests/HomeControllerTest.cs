namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
	using Microsoft.AspNetCore.Mvc;

	public class HomeControllerTest
	{
		[Fact]
		public void Index_Should_Return_View()
		{
			var homeController = new HomeController();

			var result = homeController.Index();

			Assert.NotNull(result);
			Assert.IsType<ViewResult>(result);
		}
	}
}
