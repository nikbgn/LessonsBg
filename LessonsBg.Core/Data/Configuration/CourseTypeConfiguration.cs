namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class CourseTypeConfiguration : IEntityTypeConfiguration<CourseType>
	{
		public void Configure(EntityTypeBuilder<CourseType> builder)
		{
			builder.HasData(CreateCourseTypes());
		}

		private List<CourseType> CreateCourseTypes()
		{
			var courseTypes = new List<CourseType>()
			{
				 new CourseType()
				{
					Id = 1,
					Type = "Piano"
				},
				new CourseType()
				{
					Id = 2,
					Type = "Singing"
				},
				new CourseType()
				{
					Id = 3,
					Type = "Dancing"
				},
				new CourseType()
				{
					Id = 4,
					Type = "Microsoft Excel"
				}
			};

			return courseTypes;
		}
	}
}
