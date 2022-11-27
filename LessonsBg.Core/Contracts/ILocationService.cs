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

		/// <summary>
		/// Gets location by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Task<LocationModel> GetLocationByIdAsync(int id);
	}
}
