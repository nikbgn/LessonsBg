namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;

	public class CourseService : ICourseService
	{

		private readonly ApplicationDbContext context;

		public CourseService(ApplicationDbContext _context)
		{
			context = _context;
		}

		/// <summary>
		/// Gets all courses.
		/// </summary>
		/// <returns></returns>
		
		public async Task<IEnumerable<CourseModel>> GetAllCoursesAsync()
		{
			var allCourses = await context
				.Courses
				.Select(c => new CourseModel
				{
					Id = c.Id,
					CourseDescription = c.CourseDescription,
					CourseImageURL = c.CourseImageURL,
					CourseName = c.CourseName,
					CourseTypeId = c.CourseTypeId,
					LocationId = c.LocationId,
					PhoneNumber = c.PhoneNumber,
					Website = c.Website
				})
				.ToListAsync();
			return allCourses;
		}

		/// <summary>
		/// Gets all information about a specific course by ID.
		/// </summary>
		/// <param name="courseId">Course ID.</param>

		public async Task<ReadMoreCourseModel> GetCourseInDepthInfoById(Guid courseId)
		{
			var course = await context
				.Courses
				.Where(c => c.Id == courseId)
				.Select(c => new CourseModel
				{
					Id = c.Id,
					CourseDescription = c.CourseDescription,
					CourseImageURL = c.CourseImageURL,
					CourseName = c.CourseName,
					CourseTypeId = c.CourseTypeId,
					LocationId = c.LocationId,
					PhoneNumber = c.PhoneNumber,
					Website = c.Website
				}).FirstOrDefaultAsync();

			if (course == null) throw new ArgumentException("Invalid course ID!");

			var courseModel = new ReadMoreCourseModel()
			{
				CourseModel = course
			};

			return courseModel;

		}

		/// <summary>
		/// Gets a course type by ID.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>

		public async Task<CourseTypeModel> GetCourseTypeByIdAsync(int id)
		{
			var course = await context.CourseTypes.FirstOrDefaultAsync(c => c.Id == id);
			if (course == null) throw new ArgumentException("Invalid course ID");
			var courseModel = new CourseTypeModel()
			{
				Id = course.Id,
				Type = course.Type
			};
			return courseModel;
		}

		/// <summary>
		/// Gets course types.
		/// </summary>
		/// <returns></returns>

		public async Task<IEnumerable<CourseTypeModel>> GetCourseTypesAsync()
			=> await context
				.CourseTypes
				.Select(c => new CourseTypeModel
				{
					Id = c.Id,
					Type = c.Type
				}).ToListAsync();

		/// <summary>
		/// Gets a course by ID.
		/// </summary>
		/// <param name="courseId">Course ID.</param>
		/// <returns></returns>
		
		public async Task<CourseModel> GetCourseByIdAsync(Guid courseId)
		{
			var course = await context
					.Courses
					.Where(c => c.Id == courseId)
					.Select(c => new CourseModel
					{
						Id = c.Id,
						CourseDescription = c.CourseDescription,
						CourseImageURL = c.CourseImageURL,
						CourseName = c.CourseName,
						CourseTypeId = c.CourseTypeId,
						LocationId = c.LocationId,
						PhoneNumber = c.PhoneNumber,
						Website = c.Website
					}).FirstOrDefaultAsync();

			if (course == null) throw new ArgumentException("Invalid course ID!");

			return course;
		}


	}
}
