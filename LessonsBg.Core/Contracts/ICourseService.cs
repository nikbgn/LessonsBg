namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models.Course;

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

		/// <summary>
		/// Gets all information about a specific course by ID.
		/// </summary>
		/// <param name="courseId">Course ID.</param>

		public Task<ReadMoreCourseModel> GetCourseInDepthInfoById(Guid courseId);

		/// <summary>
		/// Gets a course by ID.
		/// </summary>
		/// <param name="courseId">Course ID.</param>
		/// <returns></returns>

		public Task<CourseModel> GetCourseByIdAsync(Guid courseId);
	}
}
