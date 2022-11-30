namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models.Subject;

    /// <summary>
    /// Interface for the Subjects Service.
    /// </summary>

    public interface ISubjectsService
	{

		/// <summary>
		/// Gets all subjects
		/// </summary>
		/// <returns>All subjects</returns>
		public Task<IEnumerable<SubjectModel>> GetAllSubjectsAsync();

		/// <summary>
		/// Gets all subject type names
		/// </summary>
		/// <returns>List of all subject type names</returns>
		public Task<List<string>> GetAllSubjectTypesNamesAsync();

		/// <summary>
		/// Gets all lessons. (SubjectsTypes and subjects of that type)
		/// </summary>
		public Task<List<AllLessonsModel>> GetAllLessonsAsync(List<string> subjectTypesNames);

		/// <summary>
		/// Gets all subjects names
		/// </summary>
		public Task<List<string>> GetAllSubjectNamesAsync();
	}
}
