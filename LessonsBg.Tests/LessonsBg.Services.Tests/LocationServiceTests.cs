namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Services;

	using Microsoft.Extensions.Logging;

	using Moq;

	public class LocationServiceTests
	{
		private readonly ILogger<LocationService> ILoggerMock = new Mock<ILogger<LocationService>>().Object;

		[Fact]
		public async void LocationService_GetLocations_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var locationService = new LocationService(db.DbContext, this.ILoggerMock);
			db.DbContext.Locations.AddRange(GenerateLocationsForSeed());
			db.DbContext.SaveChanges();

			int locationsCount = db.DbContext.Locations.Count();

			var locations = await locationService.GetLocationsAsync();


			Assert.NotNull(locations);
			Assert.True(locations.Count() == locationsCount);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void LocationService_GetLocationsById_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var locationService = new LocationService(db.DbContext, this.ILoggerMock);
			db.DbContext.Locations.AddRange(GenerateLocationsForSeed());
			db.DbContext.SaveChanges();

			var locationFromDB = db.DbContext.Locations.First(l => l.Id == 1);
			var location = await locationService.GetLocationByIdAsync(1);

			Assert.True(location.Id == locationFromDB.Id);
			Assert.True(location.Name == locationFromDB.Name);
			Assert.True(location.Region == locationFromDB.Region);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void LocationService_GetLocationsById_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var locationService = new LocationService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => locationService.GetLocationByIdAsync(-1));

			db.DbContext.Dispose();
		}

		private List<Location> GenerateLocationsForSeed()
		{
			var locations = new List<Location>()
			{
				new Location { Id = 1, Name = "Online", Region = "Online" },
				new Location { Id = 2, Name = "Cool location", Region = "Somewhere" },
				new Location { Id = 3, Name = "Another cool location", Region = "Somewhere else" }
			};

			return locations;
		}
	}
}
