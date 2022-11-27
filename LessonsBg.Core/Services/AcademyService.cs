namespace LessonsBg.Core.Services
{
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;

	public class AcademyService : IAcademyService
	{

		private readonly ApplicationDbContext context;

		public AcademyService(ApplicationDbContext _context)
		{
			context = _context;
		}

		/// <summary>
		/// Creates a course.
		/// </summary>
		/// <param name="academyId">The identifier of the academy that is creating the course.</param>s
		
		public async Task CreateCourse(string academyId, CreateCourseModel model, LocationModel locationModel, CourseTypeModel courseTypeModel)
		{
			var academy = await context.Users.Include(c => c.ApplicationUsersCourses).FirstOrDefaultAsync(a => a.Id == academyId);

			if (academy == null) throw new ArgumentException("Invalid academy id!");

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

			if(!academy.ApplicationUsersCourses.Any(c => c.CourseId == course.Id))
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



	}
}
