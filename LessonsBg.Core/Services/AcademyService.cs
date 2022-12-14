namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Models;
	using LessonsBg.Core.Models.Course;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class AcademyService : IAcademyService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<AcademyService> logger;

		public AcademyService(
			ApplicationDbContext _context,
			ILogger<AcademyService> _logger)
		{
			context = _context;
			logger = _logger;
		}

		/// <summary>
		/// Creates a course.
		/// </summary>
		/// <param name="academyId">The identifier of the academy that is creating the course.</param>s

		public async Task CreateCourse(string academyId, CreateCourseModel model, LocationModel locationModel, CourseTypeModel courseTypeModel)
		{
			var academy = await context.Users.Include(c => c.ApplicationUsersCourses).FirstOrDefaultAsync(a => a.Id == academyId);

			if (academy == null) throw new ArgumentException("Invalid academy id!");

			try
			{
				var course = new Course()
				{
					Id = model.CourseModel.Id,
					CourseName = model.CourseModel.CourseName,
					CourseImageURL = model.CourseModel.CourseImageURL,
					CourseDescription = model.CourseModel.CourseDescription,
					CourseTypeId = courseTypeModel.Id,
					LocationId = locationModel.Id,
					Website = model.CourseModel.Website,
					PhoneNumber = model.CourseModel.PhoneNumber
				};

				if (!academy.ApplicationUsersCourses.Any(c => c.CourseId == course.Id))
				{
					academy.ApplicationUsersCourses.Add(new ApplicationUserCourse()
					{
						ApplicationUser = academy,
						ApplicationUserId = academy.Id,
						Course = course,
						CourseId = course.Id
					});

					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed to create course.", ex);
			}
		}


		/// <summary>
		/// Edits a course.
		/// </summary>
		/// <param name="courseId">Course ID</param>
		/// <param name="model"></param>
		/// <returns></returns>

		public async Task EditCourseAsync(CreateCourseModel model)
		{
			var course = await context.Courses.FirstOrDefaultAsync(c => c.Id == model.CourseModel.Id);

			if (course == null) throw new ArgumentException("Invalid course ID!");

			try
			{
				course.Id = model.CourseModel.Id;
				course.CourseName = model.CourseModel.CourseName;
				course.CourseDescription = model.CourseModel.CourseDescription;
				course.CourseImageURL = model.CourseModel.CourseImageURL;
				course.PhoneNumber = model.CourseModel.PhoneNumber;
				course.LocationId = model.CourseModel.LocationId;
				course.Website = model.CourseModel.Website;
				course.CourseDescription = model.CourseModel.CourseDescription;

				await context.SaveChangesAsync();

			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed to edit course.", ex);
			}

		}

		/// <summary>
		/// Gets the courses created from a specific academy.
		/// </summary>
		/// <param name="academyId">Academy identifier.</param>
		/// <returns>List of courses created by the academy.</returns>

		public async Task<IEnumerable<CourseModel>> GetAcademyCoursesAsync(string academyId)
		{
			var academy = await context.Users
				.Where(u => u.Id == academyId)
				.Include(u => u.ApplicationUsersCourses)
				.ThenInclude(c => c.Course)
				.FirstOrDefaultAsync();

			if (academy == null) throw new ArgumentException("Invalid academy id!");

			try
			{
				return academy.ApplicationUsersCourses
					.Select(c => new CourseModel
					{
						Id = c.CourseId,
						CourseDescription = c.Course.CourseDescription,
						CourseImageURL = c.Course.CourseImageURL,
						CourseName = c.Course.CourseName,
						CourseTypeId = c.Course.CourseTypeId,
						LocationId = c.Course.LocationId,
						PhoneNumber = c.Course.PhoneNumber,
						Website = c.Course.Website
					}).ToList();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting academy courses failed.", ex);
			}


		}

		/// <summary>
		/// Checks if the academy is the author of a course.
		/// </summary>
		/// 
		public async Task<bool> CheckAcademyIsAuthorOfCourse(string academyId, Guid courseId)
		{
			var academy = await context
				.Users
				.Include(u => u.ApplicationUsersCourses)
				.FirstOrDefaultAsync(u => u.Id == academyId);

			if (academy == null) throw new ArgumentException("Invalid academy ID!");

			try
			{
				bool check = academy.ApplicationUsersCourses.Any(c => c.CourseId == courseId);
				return check;
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Checking if the academy is the author of the course failed.", ex);
			}

		}

		/// <summary>
		/// Removes a course.
		/// </summary>
		/// <param name="courseId">Course ID</param>
		/// <returns></returns>

		public async Task RemoveCourse(Guid courseId)
		{
			var course = await context.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
			if (course == null) throw new ArgumentException("Invalid course ID!");
			try
			{
				context.Courses.Remove(course);
				await context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed removing course.", ex);
			}
		}
	}
}
