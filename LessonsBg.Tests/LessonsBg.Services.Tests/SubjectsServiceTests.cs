namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Services;
	using Microsoft.Extensions.Logging;
	using Moq;

	public class SubjectsServiceTests
	{
		private readonly ILogger<SubjectsService> ILoggerMock = new Mock<ILogger<SubjectsService>>().Object;


		[Fact]
		public async void SubjectsService_GetAllSubjects_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var subjectsService = new SubjectsService(db.DbContext, this.ILoggerMock);

			var subjects = await subjectsService.GetAllSubjectsAsync();

			var sample = subjects.First();

			bool verification = db.DbContext.Subjects.Any(s => s.Id == sample.Id);

			Assert.NotNull(subjects);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void SubjectsService_GetAllSubjectTypesNames_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var subjectsService = new SubjectsService(db.DbContext, this.ILoggerMock);

			var subjectTypes = await subjectsService.GetAllSubjectTypesNamesAsync();

			var sample = subjectTypes.First();

			bool verification = db.DbContext.SubjectTypes.Any(s => s.Type == sample);

			Assert.NotNull(subjectTypes);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void SubjectsService_GetAllSubjectNames_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var subjectsService = new SubjectsService(db.DbContext, this.ILoggerMock);

			var subjectNames = await subjectsService.GetAllSubjectNamesAsync();

			var sample = subjectNames.First();

			bool verification = db.DbContext.Subjects.Any(s => s.Name == sample);

			Assert.NotNull(subjectNames);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void SubjectsService_GetAllLessons_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var subjectsService = new SubjectsService(db.DbContext, this.ILoggerMock);

			var subjectTypesNames = await subjectsService.GetAllSubjectTypesNamesAsync();

			var allLessons = await subjectsService.GetAllLessonsAsync(subjectTypesNames);

			Assert.NotNull(allLessons);
			Assert.True(allLessons.Count > 0);

			db.DbContext.Dispose();
		}
	}
}
