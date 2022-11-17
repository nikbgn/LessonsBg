namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class FilterBadgeConfiguration : IEntityTypeConfiguration<FilterBadge>
	{
		public void Configure(EntityTypeBuilder<FilterBadge> builder)
		{
			builder.HasData(CreateFilterBadges());
		}

		private List<FilterBadge> CreateFilterBadges()
		{
			var filterBadges = new List<FilterBadge>() 
			{
				new FilterBadge()
				{
					Id = 1,
					FilterBadgeType = "1-4 Grade"
				},
				new FilterBadge()
				{
					Id = 2,
					FilterBadgeType = "5-8 Grade"
				},
				new FilterBadge()
				{
					Id = 3,
					FilterBadgeType = "9-12 Grade"
				},
				new FilterBadge()
				{
					Id = 4,
					FilterBadgeType = "University Students"
				},
				new FilterBadge()
				{
					Id = 5,
					FilterBadgeType = "Elderly"
				},
				new FilterBadge()
				{
					Id = 6,
					FilterBadgeType = "Online"
				},
				new FilterBadge()
				{
					Id = 7,
					FilterBadgeType = "Onsite"
				}
			};

			return filterBadges;
		}
	}
}
