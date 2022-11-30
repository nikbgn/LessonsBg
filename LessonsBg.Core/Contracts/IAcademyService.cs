namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;


	/// <summary>
	/// Interface for Academy service.
	/// </summary>

	public interface IAcademyService
	{
		/// <summary>
		/// Creates a course.
		/// </summary>
		/// <param name="academyId">The identifier of the academy that is creating the course.</param>

		public Task CreateCourse(string academyId, CreateCourseModel model, LocationModel locationModel, CourseTypeModel courseTypeModel);

		/// <summary>
		/// Gets the courses created from a specific academy.
		/// </summary>
		/// <param name="academyId">Academy identifier.</param>
		/// <returns>List of courses created by the academy.</returns>

		public Task<IEnumerable<CourseModel>> GetAcademyCoursesAsync(string academyId);

		/// <summary>
		/// Edits a course.
		/// </summary>
		/// <param name="courseId">Course ID</param>
		/// <param name="model"></param>
		/// <returns></returns>
		
		public Task EditCourseAsync(CreateCourseModel model);

		/// <summary>
		/// Checks if the academy is the author of a course.
		/// </summary>
		
		public Task<bool> CheckAcademyIsAuthorOfCourse(string academyId, Guid courseId);

		/// <summary>
		/// Removes a course.
		/// </summary>
		/// <param name="courseId">Course ID</param>
		/// <returns></returns>
		public Task RemoveCourse(Guid courseId);
	}
}
