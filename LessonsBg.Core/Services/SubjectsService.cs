namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;

	public class SubjectsService : ISubjectsService
	{

		private readonly ApplicationDbContext context;

		public SubjectsService(ApplicationDbContext _context)
		{
			context = _context;
		}


		/// <summary>
		/// Gets all subjects
		/// </summary>
		/// <returns>All subjects</returns>
		public async Task<IEnumerable<SubjectModel>> GetAllSubjectsAsync()
			=> await context
				.Subjects
				.Include(s => s.SubjectType)
				.Select(s => new SubjectModel()
				{
					Id = s.Id,
					Name = s.Name,
					SubjectTypeId = s.SubjectTypeId
				})
				.ToListAsync();
	}
}
