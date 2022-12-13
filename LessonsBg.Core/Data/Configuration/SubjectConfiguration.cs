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

		public List<Subject> CreateSubjects()
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
					Name = "История и цивилизация",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "География и икономика",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Физика и астрономия",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Химия и опазване на околната среда",
					SubjectTypeId = 1
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Философия",
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
					Name = "Испански език",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Френски език",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Руски език",
					SubjectTypeId = 2
				},
				new Subject()
				{
					Id = Guid.NewGuid(),
					Name = "Немски език",
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
