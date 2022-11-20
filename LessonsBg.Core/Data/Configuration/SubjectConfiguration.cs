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
					Name = "Math",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Bulgarian Language",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "English Language",
					SubjectTypeId = 3
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Informational Technologies",
					SubjectTypeId = 4
				},
			};

			return subjects;
		}
	}
}
