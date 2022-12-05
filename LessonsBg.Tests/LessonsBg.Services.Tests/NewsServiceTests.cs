namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Models;
	using global::LessonsBg.Core.Services;



	using Microsoft.Extensions.Logging;
	using Moq;

	public class NewsServiceTests
	{
		private readonly ILogger<NewsService> ILoggerMock = new Mock<ILogger<NewsService>>().Object;


		[Fact]
		public async void NewsService_Add_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			var newsArticle = new NewsArticleModel()
			{
				Id = Guid.NewGuid(),
				Name = "News article!",
				Text = "Very important news!",
				CreatedOn = DateTime.Now,
				ImageURL = "https://fakeurl.com/coolimage.png"
			};

			int countNewsBefore = db.DbContext.NewsArticles.Count();

			await newsService.AddAsync(newsArticle);

			int countNewsAfter = db.DbContext.NewsArticles.Count();

			Assert.True(countNewsBefore < countNewsAfter);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void NewsService_Add_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => newsService.AddAsync(null));

			db.DbContext.Dispose();
		}



		[Fact]
		public async void NewsService_GetAllNews_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			db.DbContext.AddRange(SeedSomeNews());
			db.DbContext.SaveChanges();

			int countNewsInDb = db.DbContext.NewsArticles.Count();

			var news = await newsService.GetAllNewsAsync();

			Assert.NotNull(news);
			Assert.True(news.Count() == countNewsInDb);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void NewsService_GetNewsArticle_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			db.DbContext.AddRange(SeedSomeNews());
			db.DbContext.SaveChanges();

			var newsArticleFromDb = db.DbContext.NewsArticles.First();

			var newsArticle = await newsService.GetNewsArticleAsync(newsArticleFromDb.Id);

			Assert.True(newsArticle.Id == newsArticleFromDb.Id);
			Assert.True(newsArticle.Name == newsArticleFromDb.Name);
			Assert.True(newsArticle.Text == newsArticleFromDb.Text);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void NewsService_GetNewsArticle_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			var badGuid = Guid.NewGuid();

			await Assert.ThrowsAnyAsync<Exception>(() => newsService.GetNewsArticleAsync(badGuid));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void NewsService_Remove_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var testArticle = new NewsArticle()
			{
				Id = Guid.NewGuid(),
				Name = "News article oneeeeeeeeee!",
				Text = "Very important news!",
				CreatedOn = DateTime.Now,
				ImageURL = "https://fakeurl.com/coolimage.png"
			};

			db.DbContext.NewsArticles.Add(testArticle);
			db.DbContext.SaveChanges();

			int countNewsArticlesBefore = db.DbContext.NewsArticles.Count();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			await newsService.RemoveAsync(testArticle.Id);

			int countNewsArticlesAfter = db.DbContext.NewsArticles.Count();

			Assert.True(countNewsArticlesBefore > countNewsArticlesAfter);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void NewsService_Remove_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var newsService = new NewsService(db.DbContext, this.ILoggerMock);

			var badGuid = Guid.NewGuid();

			await Assert.ThrowsAnyAsync<Exception>(() => newsService.RemoveAsync(badGuid));

			db.DbContext.Dispose();
		}


		private List<NewsArticle> SeedSomeNews()
		{
			var news = new List<NewsArticle>()
			{
				new NewsArticle() 
					{
						Id = Guid.NewGuid(),
						Name = "News article oneeeeeeeeee!",
						Text = "Very important news!",
						CreatedOn = DateTime.Now,
						ImageURL = "https://fakeurl.com/coolimage.png"
					},
				new NewsArticle()
					{
						Id = Guid.NewGuid(),
						Name = "News article twoooooooooo!",
						Text = "Very important news!",
						CreatedOn = DateTime.Now,
						ImageURL = "https://fakeurl.com/coolimage2.png"
					},
				new NewsArticle()
					{
						Id = Guid.NewGuid(),
						Name = "News article threeeeeee!",
						Text = "Very important news!",
						CreatedOn = DateTime.Now,
						ImageURL = "https://fakeurl.com/coolimage3.png"
					},
			};

			return news;
		}
	}
}
