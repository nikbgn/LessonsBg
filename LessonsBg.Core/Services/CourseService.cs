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

		public async Task<CourseTypeModel> GetCourseTypeById(int id)
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

		public async Task<IEnumerable<CourseTypeModel>> GetCourseTypesAsync()
			=> await context
				.CourseTypes
				.Select(c => new CourseTypeModel
				{
					Id = c.Id,
					Type = c.Type
				}).ToListAsync();


	}
}
