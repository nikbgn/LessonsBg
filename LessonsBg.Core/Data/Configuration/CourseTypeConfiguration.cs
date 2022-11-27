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
					Type = "Пиано"
				},
				new CourseType()
				{
					Id = 2,
					Type = "Пеене"
				},
				new CourseType()
				{
					Id = 3,
					Type = "Танци"
				},
				new CourseType()
				{
					Id = 4,
					Type = "Microsoft Excel"
				},
								
				new CourseType()
				{
					Id = 5,
					Type = "Компютърна грамотност"
				},
												
				new CourseType()
				{
					Id = 6,
					Type = "Microsoft Word"
				},              
				new CourseType()
				{
					Id = 7,
					Type = "Microsoft Powerpoint"
				},
								
				new CourseType()
				{
					Id = 8,
					Type = "Adobe Photoshop"
				},
				new CourseType()
				{
					Id = 9,
					Type = "Adobe Illustrator"
				},
			};

			return courseTypes;
		}
	}
}
