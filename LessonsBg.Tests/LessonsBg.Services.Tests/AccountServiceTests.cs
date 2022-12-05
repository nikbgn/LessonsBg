namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Services;
	using Microsoft.Extensions.Logging;
	using Moq;

	public class AccountServiceTests
	{
		private readonly ILogger<AccountService> ILoggerMock = new Mock<ILogger<AccountService>>().Object;

		[Fact]
		public async void TrainingsService_GetAllSports_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var accountService = new AccountService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			var newUrl = "https://www.new-url-image.com/new_image.png";

			var adminOldProfileImage = admin.ProfileImage;

			await accountService.ChangeUserProfileImageAsync(admin.Id, newUrl);

			Assert.True(admin.ProfileImage != adminOldProfileImage);
			Assert.True(admin.ProfileImage == newUrl);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAllSports_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var accountService = new AccountService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => accountService.ChangeUserProfileImageAsync("non-existing id", "not-real-url"));

			db.DbContext.Dispose();
		}
	}
}
