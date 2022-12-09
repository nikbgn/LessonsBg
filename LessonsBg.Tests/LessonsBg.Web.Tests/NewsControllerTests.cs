using LessonsBg.Core.Contracts;
using LessonsBg.Core.Data.Models;
using LessonsBg.Core.Models;
using LessonsBg.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
    public class NewsControllerTests
    {

        private readonly Mock<ILogger<NewsController>> mockILoggerService = new Mock<ILogger<NewsController>>();
        private readonly Mock<ILogger<NewsService>> mockILoggerServiceNewsService = new Mock<ILogger<NewsService>>();

        [Fact]
        public async Task Index_Should_Return_View()
        {
            DatabaseSetup db = new DatabaseSetup();

            var newsService = new NewsService(db.DbContext, mockILoggerServiceNewsService.Object);
            var newsCotroller = new NewsController(newsService, mockILoggerService.Object);


            var result = await newsCotroller.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

            db.DbContext.Dispose();
        }

        [Fact]
        public async Task Index_Should_Return_BadRequest()
        {
            DatabaseSetup db = new DatabaseSetup();

            var mock = new Mock<INewsService>();
            mock.Setup(g => g.GetAllNewsAsync()).ThrowsAsync(new Exception());

            var newsCotroller = new NewsController(mock.Object, mockILoggerService.Object);


            var result = await newsCotroller.Index();

            Assert.IsType<BadRequestResult>(result);

            db.DbContext.Dispose();
        }

        [Fact]
        public async Task GET_Add_Should_Return_View()
        {
            var mock = new Mock<INewsService>();
            mock.Setup(g => g.GetAllNewsAsync()).ThrowsAsync(new Exception());
            var newsController = new NewsController(mock.Object, mockILoggerService.Object);
            var result = newsController.Add();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task POST_Add_Should_Return_RedirectToAction_Or_ViewResult()
        {
            var mock = new Mock<INewsService>();
            var newsArticleMock = new Mock<NewsArticleModel>().Object;
            var newsController = new NewsController(mock.Object, mockILoggerService.Object);
            var newsController2 = new NewsController(mock.Object, mockILoggerService.Object);
            newsController2.ModelState.AddModelError("","EROOOOOOOOOOOOOOOOOOOOR");
            var result = await newsController.Add(newsArticleMock);
            var result2 = await newsController2.Add(newsArticleMock);
            Assert.IsType<RedirectToActionResult>(result);
            Assert.IsType<ViewResult>(result2);
        }


        [Fact]
        public async Task Delete_Should_Return_RedirectToActionResult()
        {
            var mock = new Mock<INewsService>();
            var newsArticleMock = new Mock<NewsArticleModel>().Object;
            var newsController = new NewsController(mock.Object, mockILoggerService.Object);
            var result = await newsController.Delete(Guid.NewGuid());
            Assert.IsType<RedirectToActionResult>(result);
        }

    }
}
