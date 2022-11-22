namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;


	/// <summary>
	/// Interface for the Teacher Service.
	/// </summary>

	public interface ITeacherService
	{
		/// <summary>
		/// Adds a subject to the teachers collection of subjects that he can teach.
		/// </summary>

		public Task AddSubjectToSubjectsCollectionAsync(Guid subjectId, string teacherId);

		/// <summary>
		/// Removes a subject from the teachers collection of subjects that he can teach.
		/// </summary>

		public Task RemoveSubjectFromSubjectsCollectionAsync(Guid subjectId, string teacherId);


		public Task<IEnumerable<SubjectModel>> GetTeacherSubjectsAsync(string teacherId);


		public Task<IEnumerable<TeacherCardModel>> GetTeachersCardsForSubjectAsync(string subjectName);
	}
}
