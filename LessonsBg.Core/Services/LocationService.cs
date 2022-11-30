namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class LocationService : ILocationService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<LocationService> logger;

		public LocationService(
			ApplicationDbContext _context,
			ILogger<LocationService> _logger)
		{
			context = _context;
			logger = _logger;
		}


		/// <summary>
		/// Gets locations.
		/// </summary>

		public async Task<IEnumerable<LocationModel>> GetLocationsAsync()
		{
			try
			{
				return await context
					.Locations
					.Select(l => new LocationModel
					{
						Id = l.Id,
						Name = l.Name,
						Region = l.Region
					}).ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting locations.", ex);
			}
		}

		/// <summary>
		/// Gets location by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		
		public async Task<LocationModel> GetLocationByIdAsync(int id)
		{
			//Fix The instance of entity type 'Location' cannot be tracked because another instance with the same key value for {'Id'} is already being tracked. error by adding as no tracking.
			var location = await context.Locations.AsNoTracking().FirstOrDefaultAsync(l => l.Id == id);
			if (location == null) throw new ArgumentException("Invalid location ID");
			var locationModel = new LocationModel()
			{
				Id = location.Id,
				Name = location.Name,
				Region = location.Region
			};
			return locationModel;
		}
	}
}
