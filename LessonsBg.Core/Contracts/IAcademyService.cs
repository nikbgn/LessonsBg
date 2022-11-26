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
	}
}
