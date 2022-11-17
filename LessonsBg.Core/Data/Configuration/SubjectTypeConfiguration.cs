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

		private List<SubjectType> CreateSubjectTypes()
		{
			var subjectTypes = new List<SubjectType>()
			{
				 new SubjectType()
				{
					Id = 1,
					Type = "Academic"
				},
				new SubjectType()
				{
					Id = 2,
					Type = "Language"
				},
				new SubjectType()
				{
					Id = 3,
					Type = "IT"
				}
			};
			return subjectTypes;
		}
	}
}
