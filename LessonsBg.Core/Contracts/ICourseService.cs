namespace LessonsBg.Core.Contracts
{
	using LessonsBg.Core.Models;

	/// <summary>
	/// Course service interface.
	/// </summary>

	public interface ICourseService
	{
		public Task<CourseTypeModel> GetCourseTypeById(int id);

		public Task<IEnumerable<CourseTypeModel>> GetCourseTypesAsync();
	}
}
