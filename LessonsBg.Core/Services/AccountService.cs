namespace LessonsBg.Core.Services
{
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;

	using Microsoft.Extensions.Logging;

	public class AccountService : IAccountService
	{

		private readonly ApplicationDbContext context;
		private readonly ILogger<AccountService> logger;

		public AccountService(
			ApplicationDbContext _context,
			ILogger<AccountService> _logger
			)
		{
			context = _context;
			logger = _logger;
		}

		/// <summary>
		/// Changes the profile image of an user.
		/// </summary>
		/// <param name="user">The user.</param>
		/// <param name="newAvatarUrl">The URL address to the user's new profile image.</param>
		/// <returns></returns>

		public async Task ChangeUserProfileImageAsync(string userId, string newAvatarUrl)
		{
			var user = await context.Users.FindAsync(userId);

			if (user == null) throw new ArgumentException("Invalid user ID!");

			try
			{
				user.ProfileImage = newAvatarUrl;
				await context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed changing the user profile image.", ex);
			}
		}


		/// <summary>
		/// Changes user's teaching location.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="newTeachingLocation"></param>
		/// <returns></returns>
		public async Task ChangeUserTeachingLocationAsync(string userId, string newTeachingLocation)
		{
			var user = await context.Users.FindAsync(userId);

			if (user == null) throw new ArgumentException("Invalid user ID!");

			try
			{
				user.TeachingLocation = newTeachingLocation;
				await context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				logger.LogError(nameof(ex), ex.Message);
				throw new ApplicationException("Failed changing the user teaching location.", ex);
			}
		}
	}
}
