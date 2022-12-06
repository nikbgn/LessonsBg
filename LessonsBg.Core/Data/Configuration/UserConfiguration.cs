namespace LessonsBg.Core.Data.Configuration
{
	using LessonsBg.Core.Data.Models;

	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.HasData(SeedAdmin());
		}

		public ApplicationUser SeedAdmin()
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			var adminUser = new ApplicationUser()
			{
				Id = Guid.NewGuid().ToString(),
				FirstName = "Николай",
				LastName = "Иванов",
				UserName = "niki_admin@niki.bg",
				NormalizedUserName = "NIKI_ADMIN@NIKI.BG",
				Email = "niki_admin@niki.bg",
				NormalizedEmail = "NIKI_ADMIN@NIKI.BG",
				EmailConfirmed = true,
				PhoneNumber = "0891111111",
				PhoneNumberConfirmed = true,
				ProfileImage = "https://i.imgur.com/zqWjZFV.png",
				TeachingLocation = "Онлайн"
			};

			adminUser.PasswordHash = hasher.HashPassword(adminUser, "Adminche@123");
	
			return adminUser;
		}
	}
}
