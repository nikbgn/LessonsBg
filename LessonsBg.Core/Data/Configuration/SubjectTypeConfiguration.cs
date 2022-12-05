namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class SubjectTypeConfiguration : IEntityTypeConfiguration<SubjectType>
	{
		public void Configure(EntityTypeBuilder<SubjectType> builder)
		{
			builder.HasData(CreateSubjectTypes());
		}

		public List<SubjectType> CreateSubjectTypes()
		{
			var subjectTypes = new List<SubjectType>()
			{
				 new SubjectType()
				{
					Id = 1,
					Type = "Академични"
				},
				new SubjectType()
				{
					Id = 2,
					Type = "Езици"
				},
				new SubjectType()
				{
					Id = 3,
					Type = "ИТ"
				}
			};
			return subjectTypes;
		}
	}
}
