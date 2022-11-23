namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;


	/// <summary>
	/// Interface for the Teacher Service.
	/// </summary>

	public interface ITeacherService
	{
		/// <summary>
		/// Adds a subject to the teacher's collection of subjects that he can teach.
		/// </summary>

		public Task AddSubjectToSubjectsCollectionAsync(Guid subjectId, string teacherId);

		/// <summary>
		/// Removes a subject from the teacher's collection of subjects that he can teach.
		/// </summary>

		public Task RemoveSubjectFromSubjectsCollectionAsync(Guid subjectId, string teacherId);

		/// <summary>
		/// Gets teacher's subjects
		/// </summary>

		public Task<IEnumerable<SubjectModel>> GetTeacherSubjectsAsync(string teacherId);

		/// <summary>
		/// Gets information needed to fill a teacher card for illustration purposes
		/// </summary>

		public Task<IEnumerable<TeacherCardModel>> GetTeachersCardsForSubjectAsync(string subjectName);
	}
}
