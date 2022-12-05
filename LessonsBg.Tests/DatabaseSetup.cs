namespace LessonsBg.Tests
{
	using global::LessonsBg.Core.Data;
	using global::LessonsBg.Core.Data.Configuration;
	using global::LessonsBg.Core.Services;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.Logging;

	using Moq;

	public class DatabaseSetup
	{
		private ApplicationDbContext dbContext;

		public DatabaseSetup()
		{
			dbContext = GetInMemoryContext();
			SeedDB();
		}

		public ApplicationDbContext DbContext
		{
			get => this.dbContext;
		}

		private ApplicationDbContext GetInMemoryContext()
		{
			var guid = Guid.NewGuid().ToString();

			var configuration = new Mock<IConfiguration>();
			configuration
				.SetupGet(g => g.GetSection("DataFiles:Locations").Value)
				.Returns("C:\\Users\\HomePC\\source\\repos\\LessonsBg\\LessonsBg\\bin\\Debug\\net6.0\\Data\\towns.json");

			var logger = new Mock<ILogger<AcademyService>>().Object;

			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
				.UseInMemoryDatabase(guid);

			return new ApplicationDbContext(options.Options, configuration.Object);
		}

		private void SeedDB()
		{

			dbContext.Users.Add(new UserConfiguration().SeedAdmin());
			dbContext.SaveChanges();

			dbContext.CourseTypes.AddRange(new CourseTypeConfiguration().CreateCourseTypes());
			dbContext.SaveChanges();

			dbContext.SubjectTypes.AddRange(new SubjectTypeConfiguration().CreateSubjectTypes());
			dbContext.SaveChanges();

			dbContext.TrainingTypes.AddRange(new TrainingTypeConfiguration().CreateTrainingTypes());
			dbContext.SaveChanges();

			dbContext.Subjects.AddRange(new SubjectConfiguration().CreateSubjects());
			dbContext.SaveChanges();

			dbContext.Trainings.AddRange(new TrainingConfiguration().CreateTrainings());
			dbContext.SaveChanges();
		}
	}
}
