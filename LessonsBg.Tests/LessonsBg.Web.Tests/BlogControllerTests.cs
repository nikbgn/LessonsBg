using LessonsBg.Core.Contracts;
using LessonsBg.Core.Models.Blog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
    public class BlogControllerTests
    {
        private readonly Mock<IBlogService> blogServiceMock = new Mock<IBlogService>();
        private readonly Mock<ILogger<BlogController>> loggerMock = new Mock<ILogger<BlogController>>();

        [Fact]
        public async Task Index_Should_Return_View()
        {
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public async Task Index_Should_Return_BadRequest()
        {
            blogServiceMock.Setup(b => b.GetAllAsync()).ThrowsAsync(new Exception());
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.Index();

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GET_Add_Should_Return_View()
        {
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = blogService.Add();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task POST_Add_Should_Return_RedirectToAction()
        {
            var blogPostModelMock = new Mock<BlogPostModel>().Object;
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.Add(blogPostModelMock);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task POST_Add_Should_Return_BadRequest_Or_View()
        {
            var blogPostModelMock = new Mock<BlogPostModel>().Object;
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            blogService.ModelState.AddModelError("", "forced error");
            var result = await blogService.Add(blogPostModelMock);

            var blogService2 = new BlogController(blogServiceMock.Object, loggerMock.Object);
            blogServiceMock.Setup(b => b.AddAsync(blogPostModelMock)).ThrowsAsync(new Exception());
            var result2 = await blogService2.Add(blogPostModelMock);

            Assert.IsType<ViewResult>(result);
            Assert.IsType<BadRequestResult>(result2);
        }

        [Fact]
        public async Task ViewPost_Should_Return_View()
        {
            var guid = Guid.NewGuid();
            var blogPostModelMock = new Mock<BlogPostModel>().Object;
            blogServiceMock.Setup(b => b.GetPostAsync(guid)).ReturnsAsync(blogPostModelMock);
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.ViewPost(guid);

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task ViewPost_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            var blogPostModelMock = new Mock<BlogPostModel>().Object;
            blogServiceMock.Setup(b => b.GetPostAsync(guid)).ThrowsAsync(new Exception());
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.ViewPost(guid);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Delete_Should_Return_RedirectToActrion()
        {
            var guid = Guid.NewGuid();
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.Delete(guid);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task Delete_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            blogServiceMock.Setup(b => b.RemoveAsync(guid)).ThrowsAsync(new Exception());
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.Delete(guid);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task AddComment_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            var userId = "sadaasasasasasasasasasasassasasasasasasasasasasasasasasas";
            var blogCommentModel = new Mock<BlogCommentModel>().Object;
            
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.AddComment(blogCommentModel, userId, guid);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task RemoveComment_Should_Return_RedirectToAction()
        {
            var guid = Guid.NewGuid();
            int commentId = 1;

            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.RemoveComment(guid,commentId);

            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task RemoveComment_Should_Return_BadRequest()
        {
            var guid = Guid.NewGuid();
            int commentId = 1;
            blogServiceMock.Setup(b => b.DeleteCommentAsync(guid,commentId)).ThrowsAsync(new Exception());
            var blogService = new BlogController(blogServiceMock.Object, loggerMock.Object);

            var result = await blogService.RemoveComment(guid, commentId);

            Assert.IsType<BadRequestResult>(result);
        }

    }
}
