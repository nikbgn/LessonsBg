namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;

	/// <summary>
	/// Locations interface.
	/// </summary>
	
	public interface ILocationService
	{
		/// <summary>
		/// Gets locations.
		/// </summary>
		 
		public Task<IEnumerable<LocationModel>> GetLocationsAsync();

		public Task<LocationModel> GetLocationByIdAsync(int id);
	}
}
