namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class TrainingTypeConfiguration : IEntityTypeConfiguration<TrainingType>
	{
		public void Configure(EntityTypeBuilder<TrainingType> builder)
		{
			builder.HasData(CreateTrainingTypes());
		}

		private List<TrainingType> CreateTrainingTypes()
		{
			var trainingTypes = new List<TrainingType>()
			{
				new TrainingType()
				{
					Id = 1,
					Type = "Combat sport"
				},
				new TrainingType()
				{
					Id = 2,
					Type = "Ball sport"
				}
			};

			return trainingTypes;
		}
	}
}
