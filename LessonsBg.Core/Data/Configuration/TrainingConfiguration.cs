namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class TrainingConfiguration : IEntityTypeConfiguration<Training>
	{
		public void Configure(EntityTypeBuilder<Training> builder)
		{
			builder.HasData(CreateTrainings());
		}

		public List<Training> CreateTrainings()
		{
			var trainings = new List<Training>()
			{
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Карате",
					TrainingTypeId = 1
				},
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Кикбокс",
					TrainingTypeId = 1
				},
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Таекуондо",
					TrainingTypeId = 1
				},				
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Баскетбол",
					TrainingTypeId = 2
				},				
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Футбол",
					TrainingTypeId = 2
				},				
				new Training()
				{
					Id = Guid.NewGuid(),
					Name = "Волейбол",
					TrainingTypeId = 2
				}
			};

			return trainings;
		}
	}
}
