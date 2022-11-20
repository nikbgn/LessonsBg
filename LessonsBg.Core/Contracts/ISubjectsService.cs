namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;

	/// <summary>
	/// Interface for the Subjects Service.
	/// </summary>

	public interface ISubjectsService
	{

		/// <summary>
		/// Gets all subjects
		/// </summary>
		/// <returns>All subjects</returns>
		Task<IEnumerable<SubjectModel>> GetAllSubjectsAsync();
	}
}
