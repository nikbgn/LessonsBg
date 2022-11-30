namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models.Course;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class CourseService : ICourseService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<CourseService> logger;

		public CourseService(
			ApplicationDbContext _context,
			ILogger<CourseService> _logger
			)
		{
			context = _context;
			logger = _logger;
		}

		/// <summary>
		/// Gets all courses.
		/// </summary>
		/// <returns></returns>

		public async Task<IEnumerable<CourseModel>> GetAllCoursesAsync()
		{
			try
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
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting all courses failed.", ex);
			}

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

			try
			{
				var courseModel = new ReadMoreCourseModel()
				{
					CourseModel = course
				};

				return courseModel;
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting information about the course failed.", ex);
			}


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
			try
			{
				var courseModel = new CourseTypeModel()
				{
					Id = course.Id,
					Type = course.Type
				};
				return courseModel;
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting course type by ID failed.", ex);
			}
		}

		/// <summary>
		/// Gets course types.
		/// </summary>
		/// <returns></returns>

		public async Task<IEnumerable<CourseTypeModel>> GetCourseTypesAsync()
		{
			try
			{
				return await context
					.CourseTypes
					.Select(c => new CourseTypeModel
					{
						Id = c.Id,
						Type = c.Type
					}).ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting the course types.", ex);
			}
		}

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
