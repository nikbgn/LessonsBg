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
		/// Gets all lessons. (SubjectsTypes and subjects of that type)
		/// </summary>
		public async Task<List<AllLessonsModel>> GetAllLessonsAsync(List<string> subjectTypesNames)
		{
			var allLessons = new List<AllLessonsModel>();

			foreach (var subjectType in subjectTypesNames)
			{
				var newModel = new AllLessonsModel();
				newModel.SubjectTypeName = subjectType;

				newModel.SubjectsOfSubjectTypeName = await context.Subjects
					.Where(s => s.SubjectType.Type == subjectType)
					.Select(s => s.Name)
					.ToListAsync();

				allLessons.Add(newModel);
			}

			return allLessons;
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


		/// <summary>
		/// Gets all subject type names
		/// </summary>
		
		public async Task<List<string>> GetAllSubjectTypesNamesAsync()
			=>	await context
					.SubjectTypes
					.Select(s => s.Type)
					.ToListAsync();

		/// <summary>
		/// Gets all subjects names
		/// </summary>

		public async Task<List<string>> GetAllSubjectNamesAsync()
			=> await context
					.Subjects
					.Select(s => s.Name)
					.ToListAsync();


	}
}
