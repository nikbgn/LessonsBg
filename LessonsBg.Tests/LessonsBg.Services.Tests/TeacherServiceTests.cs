namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Services;

	using Microsoft.Extensions.Logging;

	using Moq;

	public class TeacherServiceTests
	{
		private readonly ILogger<TeacherService> ILoggerMock = new Mock<ILogger<TeacherService>>().Object;

		[Fact]
		public async void TeacherService_AddSubjectToSubjectsCollection_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			var subject = db.DbContext.Subjects.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await teacherService.AddSubjectToSubjectsCollectionAsync(subject.Id, admin.Id);

			Assert.True(admin.ApplicationUsersSubjects.Count != 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TeacherService_AddSubjectToSubjectsCollection_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => teacherService.AddSubjectToSubjectsCollectionAsync(Guid.NewGuid(), null));

			db.DbContext.Dispose();
		}

        
		[Fact]
		public async void TeacherService_GetTeachersCardsForSubject_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			var subject = db.DbContext.Subjects.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await teacherService.AddSubjectToSubjectsCollectionAsync(subject.Id, admin.Id);

			var cards = await teacherService.GetTeachersCardsForSubjectAsync(subject.Name,admin.TeachingLocation);
			bool teacherCardExists = cards.TeacherCards.Any(c => c.PhoneNumber == admin.PhoneNumber);

			Assert.True(teacherCardExists);

			db.DbContext.Dispose();
		}
		

        [Fact]
		public async void TeacherService_GetTeacherSubjectsAsync_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			var subject = db.DbContext.Subjects.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await teacherService.AddSubjectToSubjectsCollectionAsync(subject.Id, admin.Id);

			var teacherSubjects = await teacherService.GetTeacherSubjectsAsync(admin.Id);
			bool verification = teacherSubjects.First().Name == subject.Name;

			Assert.NotNull(teacherSubjects);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TeacherService_GetTeacherSubjectsAsync_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => teacherService.GetTeacherSubjectsAsync("fake non-existing id"));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TeacherService_RemoveSubjectFromSubjectsCollection_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			var subject = db.DbContext.Subjects.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await teacherService.AddSubjectToSubjectsCollectionAsync(subject.Id, admin.Id);
			await teacherService.RemoveSubjectFromSubjectsCollectionAsync(subject.Id, admin.Id);

			Assert.True(admin.ApplicationUsersSubjects.Count == 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TeacherService_RemoveSubjectFromSubjectsCollection_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var teacherService = new TeacherService(db.DbContext, this.ILoggerMock);

			var subject = db.DbContext.Subjects.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await teacherService.AddSubjectToSubjectsCollectionAsync(subject.Id, admin.Id);

			await Assert.ThrowsAnyAsync<Exception>(() => teacherService.RemoveSubjectFromSubjectsCollectionAsync(subject.Id, "badddd"));

			db.DbContext.Dispose();
		}

	}
}
