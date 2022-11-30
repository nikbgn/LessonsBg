namespace LessonsBg.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Models.Subject;
    using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class SubjectsService : ISubjectsService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<SubjectsService> logger;

		public SubjectsService(
			ApplicationDbContext _context,
			ILogger<SubjectsService> _logger)
		{
			context = _context;
			logger = _logger;
		}

		/// <summary>
		/// Gets all lessons. (SubjectsTypes and subjects of that type)
		/// </summary>
		public async Task<List<AllLessonsModel>> GetAllLessonsAsync(List<string> subjectTypesNames)
		{
			try
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
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all lessons.", ex);
			}
		}


		/// <summary>
		/// Gets all subjects
		/// </summary>
		/// <returns>All subjects</returns>
		public async Task<IEnumerable<SubjectModel>> GetAllSubjectsAsync()
		{
			try
			{
				return await context
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
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all subjects.", ex);
			}
		}


		/// <summary>
		/// Gets all subject type names
		/// </summary>
		
		public async Task<List<string>> GetAllSubjectTypesNamesAsync()
		{
			try
			{
				return	await context
						.SubjectTypes
						.Select(s => s.Type)
						.ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all subject type names.", ex);
			}
		}

		/// <summary>
		/// Gets all subjects names
		/// </summary>

		public async Task<List<string>> GetAllSubjectNamesAsync()
		{
			try
			{
				return await context
						.Subjects
						.Select(s => s.Name)
						.ToListAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed getting all subject names.", ex);
			}
		}


	}
}
