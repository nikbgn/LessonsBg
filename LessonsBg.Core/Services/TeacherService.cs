namespace LessonsBg.Core.Services
{
    using System;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Models;
	using LessonsBg.Core.Models.Subject;
    using LessonsBg.Core.Models.Teacher;
    using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Logging;

	public class TeacherService : ITeacherService
	{


		private readonly ApplicationDbContext context;
		private readonly ILogger<TeacherService> logger;

		public TeacherService(
			ApplicationDbContext _context,
			ILogger<TeacherService> _logger
			)
		{
			context = _context;
			logger = _logger;
		}


		/// <summary>
		/// Adds a subject to the teachers collection of subjects that he can teach.
		/// </summary>
		
		public async Task AddSubjectToSubjectsCollectionAsync(Guid subjectId, string teacherId)
		{
			var subject = await context.Subjects.Include(s => s.ApplicationUsersSubjects).FirstOrDefaultAsync(s => s.Id == subjectId);
			var teacher = await context.Users.Include(s => s.ApplicationUsersSubjects).FirstOrDefaultAsync(u => u.Id == teacherId);

			if (subject == null) throw new ArgumentException("Invalid subject id!");
			if (teacher == null) throw new ArgumentException("Invalid teacher id!");

			try
			{
				if (!subject.ApplicationUsersSubjects.Any(u => u.ApplicationUserId == teacherId))
				{
					teacher.ApplicationUsersSubjects.Add(new ApplicationUserSubject()
					{
						SubjectId = subject.Id,
						ApplicationUserId = teacher.Id,
						ApplicationUser = teacher,
						Subject = subject
					});

					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Adding a subject to subjects collection failed.", ex);
			}


		}

		/// <summary>
		/// Gets information needed to fill a teacher card for illustration purposes
		/// </summary>
		
		public async Task<LessonsForQueryModel> GetTeachersCardsForSubjectAsync(string subjectName, string teachingLocation)
		{
			try
			{
				var locations = await context
					.Locations.
					Select(l => new LocationModel
					{
						Id = l.Id,
						Name = l.Name,
						Region = l.Region
					}).ToListAsync();

				var result = new LessonsForQueryModel() 
				{ 
					TeachingLocation = teachingLocation ,
					Locations = locations
				};
				result.TeacherCards = await context.Users
					.Include(u => u.ApplicationUsersSubjects)
					.Where(u => u.TeachingLocation == teachingLocation)
					.Where(u => u.ApplicationUsersSubjects
					.Any(s => s.Subject.Name == subjectName))
					.Select(u => new TeacherCardModel
					{
						FirstName = u.FirstName,
						LastName = u.LastName,
						PhoneNumber = u.PhoneNumber,
						ProfileImage = u.ProfileImage
					})
					.ToListAsync();

				return result;
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting teachers cards for subject failed.", ex);
			}
		}

		/// <summary>
		/// Gets teacher's subjects
		/// </summary>

		public async Task<IEnumerable<SubjectModel>> GetTeacherSubjectsAsync(string teacherId)
		{
			var teacher = await context.Users
				.Where(u => u.Id == teacherId)
				.Include(u => u.ApplicationUsersSubjects)
				.ThenInclude(ap => ap.Subject)
				.ThenInclude(a => a.SubjectType)
				.FirstOrDefaultAsync();

			if (teacher == null) throw new ArgumentException("Invalid user ID");

			try
			{
				return teacher.ApplicationUsersSubjects
					.Select(s => new SubjectModel
					{
						Id = s.SubjectId,
						SubjectTypeId = s.Subject.SubjectTypeId,
						Name = s.Subject.Name
					});
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Getting teacher's subjects failed.", ex);
			}

		}

		/// <summary>
		/// Removes a subject from the teachers collection of subjects that he can teach.
		/// </summary>
		
		public async Task RemoveSubjectFromSubjectsCollectionAsync(Guid subjectId, string teacherId)
		{
			var teacher = await context.Users
				.Where(u => u.Id == teacherId)
				.Include(u => u.ApplicationUsersSubjects)
				.ThenInclude(ap => ap.Subject)
				.ThenInclude(a => a.SubjectType)
				.FirstOrDefaultAsync();

			if (teacher == null) throw new ArgumentException("Invalid teacher ID");

			try
			{
				var subject = teacher.ApplicationUsersSubjects.FirstOrDefault(s => s.SubjectId == subjectId);
				if(subject != null)
				{
					teacher.ApplicationUsersSubjects.Remove(subject);
					await context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Removing subject from subjects collection failed.", ex);
			}

		}
	}
}
