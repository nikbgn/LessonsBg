namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Models.Blog;
	using global::LessonsBg.Core.Services;


	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.Logging;

	using Moq;

	public class BlogServiceTests
	{
		private readonly IConfiguration IConfigMock = new Mock<IConfiguration>().Object;
		private readonly ILogger<BlogService> ILoggerMock = new Mock<ILogger<BlogService>>().Object;

		[Theory]
		[InlineData("Title1!!!","This is the best blog post!!!!")]
		[InlineData("Title2!!!","Heyheheyhehuyeyhye!!!!!!!!!!")]
		[InlineData("Title3!!!","SUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU")]
		public async void BlogService_Should_Add_New_BlogPost(string title, string postText)
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);
			BlogPostModel bpm = new BlogPostModel()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = postText,
				Title = title
			};

			int countBlogPostsBefore = db.DbContext.BlogPosts.Count();

			await blogService.AddAsync(bpm);

			int countBlogPostsAfter = db.DbContext.BlogPosts.Count();

			Assert.True(countBlogPostsBefore < countBlogPostsAfter);
			Assert.True(db.DbContext.BlogPosts.First().PostText == bpm.PostText);
			Assert.True(db.DbContext.BlogPosts.First().Title == bpm.Title);
			Assert.True(db.DbContext.BlogPosts.First().PostTextHeadingImageURL == bpm.PostTextHeadingImageURL);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_Should_Add_Should_Throw_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);

			BlogPostModel bpm = null;

			await Assert.ThrowsAsync<ApplicationException>(() => blogService.AddAsync(bpm));

			db.DbContext.Dispose();
		}

		[Theory]
		[InlineData("Very useful knowledge!")]
		[InlineData("Много полезна статия!")]
		public async void BlogService_Should_Add_Comment(string commentText)
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			int countBefore = db.DbContext.BlogPosts.Count();

			BlogPost bp = new BlogPost()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This is a cool post!",
				Title = "My post",
				BlogComments = new List<BlogComment>()
			};

			db.DbContext.BlogPosts.Add(bp);
			db.DbContext.SaveChanges();


			BlogCommentModel bcm = new BlogCommentModel()
			{
				AuthorId = admin.Id,
				BlogPostId = bp.Id,
				CommentText = commentText,
				CreatedOn = DateTime.Now
			};

			await blogService.AddCommentAsync(bcm, admin.Id, bp.Id);

			Assert.True(db.DbContext.BlogComments.First().CommentText == commentText);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_Add_Comment_Should_Throw_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			int countBefore = db.DbContext.BlogPosts.Count();

			BlogPost bp = new BlogPost()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This is a cool post!",
				Title = "My post",
				BlogComments = new List<BlogComment>()
			};

			BlogCommentModel bcm = new BlogCommentModel()
			{
				AuthorId = admin.Id,
				BlogPostId = bp.Id,
				CommentText = "Nice nice nice nice nice",
				CreatedOn = DateTime.Now
			};



			await Assert.ThrowsAnyAsync<Exception>(() => blogService.AddCommentAsync(bcm, "fakeID...", bp.Id));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_Delete_Comment_Should_Work()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			int countBefore = db.DbContext.BlogPosts.Count();

			BlogPost bp = new BlogPost()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This is a cool post!",
				Title = "My post",
				BlogComments = new List<BlogComment>()
			};

			db.DbContext.BlogPosts.Add(bp);
			db.DbContext.SaveChanges();


			BlogCommentModel bcm = new BlogCommentModel()
			{
				AuthorId = admin.Id,
				BlogPostId = bp.Id,
				CommentText = "This blog is very useful!",
				CreatedOn = DateTime.Now
			};

			await blogService.AddCommentAsync(bcm, admin.Id, bp.Id);

			var blogcomment = db.DbContext.BlogComments.First();

			await blogService.DeleteCommentAsync(bp.Id, blogcomment.Id);

			Assert.True(db.DbContext.BlogComments.Count() == 0);

			db.DbContext.Dispose();
		}


		[Fact]
		public async void BlogService_Delete_Comment_Should_Throw_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);

			//No such comment exists...

			await Assert.ThrowsAnyAsync<Exception>(() => blogService.DeleteCommentAsync(Guid.NewGuid(), 1));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_GetAllAsync_Should_Work()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);
			BlogPostModel bpm = new BlogPostModel()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This post is very useful!",
				Title = "Here is a very useful post!"
			};


			await blogService.AddAsync(bpm);

			var blogPosts = await blogService.GetAllAsync();

			Assert.True(blogPosts.Count() > 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_GetPost_Should_Work()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			BlogPostModel bpm = new BlogPostModel()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This post is very useful!",
				Title = "Here is a very useful post!"
			};

			BlogCommentModel bcm = new BlogCommentModel()
			{
				AuthorId = admin.Id,
				BlogPostId = bpm.Id,
				CommentText = "Nice nice nice nice nice",
				CreatedOn = DateTime.Now
			};

			//everything is the same with blog post model above
			BlogPost bp = new BlogPost()
			{
				Id = bpm.Id,
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This post is very useful!",
				Title = "Here is a very useful post!"
			};

			db.DbContext.BlogPosts.Add(bp);
			db.DbContext.SaveChanges();
			await blogService.AddCommentAsync(bcm, admin.Id, bpm.Id);

			var post = await blogService.GetPostAsync(bpm.Id);

			Assert.True(post.Title == bpm.Title);
			Assert.True(post.BlogComments.Count() > 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void BlogService_Remove_Should_Work()
		{
			DatabaseSetup db = new DatabaseSetup();

			var blogService = new BlogService(this.IConfigMock, db.DbContext, this.ILoggerMock);
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			BlogPostModel bpm = new BlogPostModel()
			{
				Id = Guid.NewGuid(),
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This post is very useful!",
				Title = "Here is a very useful post!"
			};

			BlogCommentModel bcm = new BlogCommentModel()
			{
				AuthorId = admin.Id,
				BlogPostId = bpm.Id,
				CommentText = "Nice nice nice nice nice",
				CreatedOn = DateTime.Now
			};

			//everything is the same with blog post model above
			BlogPost bp = new BlogPost()
			{
				Id = bpm.Id,
				PostTextHeadingImageURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				PostThumbnailURL = "https://www.oracle.com/img/tech/cb88-java-logo-001.jpg",
				CreatedOn = DateTime.Now,
				PostText = "This post is very useful!",
				Title = "Here is a very useful post!"
			};

			db.DbContext.BlogPosts.Add(bp);
			db.DbContext.SaveChanges();
			await blogService.AddCommentAsync(bcm, admin.Id, bpm.Id);

			await blogService.RemoveAsync(bp.Id);
			

			Assert.True(db.DbContext.BlogPosts.Count() == 0);

			db.DbContext.Dispose();
		}
	}
}
