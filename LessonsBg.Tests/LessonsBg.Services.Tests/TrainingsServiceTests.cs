namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Services;
	using Microsoft.Extensions.Logging;
	using Moq;

	public class TrainingsServiceTests
	{
		private readonly ILogger<TrainingsService> ILoggerMock = new Mock<ILogger<TrainingsService>>().Object;


		[Fact]
		public async void TrainingsService_GetAllSports_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainingsService = new TrainingsService(db.DbContext, this.ILoggerMock);

			var trainings = await trainingsService.GetAllTrainingsAsync();

			var sample = trainings.First();

			bool verification = db.DbContext.Trainings.Any(s => s.Id == sample.Id);

			Assert.NotNull(trainings);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAllTrainings_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainingsService = new TrainingsService(db.DbContext, this.ILoggerMock);

			var allTrainings = await trainingsService.GetAllTrainingsAsync();

			Assert.NotNull(allTrainings);
			Assert.True(allTrainings.Count() > 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAllTrainingsNames_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainingsService = new TrainingsService(db.DbContext, this.ILoggerMock);

			var allTrainingsNames = await trainingsService.GetAllTrainingsNamesAsync();

			var sample = allTrainingsNames.First();

			bool verification = db.DbContext.Trainings.Any(t => t.Name == sample);

			Assert.NotNull(allTrainingsNames);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAllTrainingTypesNamesAsync_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainingsService = new TrainingsService(db.DbContext, this.ILoggerMock);

			var allTrainingTypesNames = await trainingsService.GetAllTrainingTypesNamesAsync();

			var sample = allTrainingTypesNames.First();

			bool verification = db.DbContext.TrainingTypes.Any(t => t.Type == sample);

			Assert.NotNull(allTrainingTypesNames);
			Assert.True(verification);

			db.DbContext.Dispose();
		}


	}
}
