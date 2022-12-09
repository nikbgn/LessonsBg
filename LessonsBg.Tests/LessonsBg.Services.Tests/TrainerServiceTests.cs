namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Services;
	using Microsoft.Extensions.Logging;
	using Moq;

	public class TrainerServiceTests
	{
		private readonly ILogger<TrainerService> ILoggerMock = new Mock<ILogger<TrainerService>>().Object;

		[Fact]
		public async void TrainerService_AddTrainingToTrainingsCollection_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			var training = db.DbContext.Trainings.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await trainerService.AddTrainingToTrainingsCollectionAsync(training.Id, admin.Id);

			Assert.True(admin.ApplicationUsersTrainings.Count != 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainerService_AddTrainingToTrainingsCollection_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => trainerService.AddTrainingToTrainingsCollectionAsync(Guid.NewGuid(), "not real id"));

			db.DbContext.Dispose();
		}

        
		[Fact]
		public async void TrainerService_GetTrainersCardsForTraining_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			var training = db.DbContext.Trainings.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await trainerService.AddTrainingToTrainingsCollectionAsync(training.Id, admin.Id);

			var cards = await trainerService.GetTrainersCardsForTrainingAsync(training.Name, admin.TeachingLocation);
			bool trainerCardExists = cards.TrainerCards.Any(c => c.PhoneNumber == admin.PhoneNumber);

			
			Assert.True(trainerCardExists);

			db.DbContext.Dispose();
		}
		
        [Fact]
		public async void TrainerService_GetTrainerTrainings_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			var training = db.DbContext.Trainings.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await trainerService.AddTrainingToTrainingsCollectionAsync(training.Id, admin.Id);

			var trainings = await trainerService.GetTrainerTrainingsAsync(admin.Id);
			bool verification = trainings.First().Name == training.Name;

			Assert.True(trainings.Count() > 0);
			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainerService_GetTrainerTrainings_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => trainerService.GetTrainerTrainingsAsync("fake non-existent id"));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainerService_RemoveTrainingFromTrainingsCollection_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			var training = db.DbContext.Trainings.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await trainerService.AddTrainingToTrainingsCollectionAsync(training.Id, admin.Id);
			await trainerService.RemoveTrainingFromTrainingsCollectionAsync(training.Id, admin.Id);

			var trainings = await trainerService.GetTrainerTrainingsAsync(admin.Id);

			Assert.True(trainings.Count() == 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainerService_RemoveTrainingFromTrainingsCollection_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var trainerService = new TrainerService(db.DbContext, this.ILoggerMock);

			var training = db.DbContext.Trainings.First();
			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");

			await trainerService.AddTrainingToTrainingsCollectionAsync(training.Id, admin.Id);

			await Assert.ThrowsAnyAsync<Exception>(() => trainerService.RemoveTrainingFromTrainingsCollectionAsync(training.Id, "fake non-existent id"));
			await Assert.ThrowsAnyAsync<Exception>(() => trainerService.RemoveTrainingFromTrainingsCollectionAsync(Guid.NewGuid(), admin.Id));

			db.DbContext.Dispose();
		}

	}
}
