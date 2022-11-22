namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
	{
		public void Configure(EntityTypeBuilder<Subject> builder)
		{
			builder.HasData(CreateSubjects());
		}

		private List<Subject> CreateSubjects()
		{
			var subjects = new List<Subject>()
			{
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Математика",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Български език",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Английски език",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Информационни технологии",
					SubjectTypeId = 3
				},
			};

			return subjects;
		}
	}
}
