namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;

	/// <summary>
	/// Course service interface.
	/// </summary>

	public interface ICourseService
	{
		/// <summary>
		/// Gets a course type by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Task<CourseTypeModel> GetCourseTypeByIdAsync(int id);

		/// <summary>
		/// Gets course types.
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<CourseTypeModel>> GetCourseTypesAsync();

		/// <summary>
		/// Gets all courses.
		/// </summary>
		/// <returns></returns>
		public Task<IEnumerable<CourseModel>> GetAllCoursesAsync();
	}
}
