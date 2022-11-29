namespace LessonsBg.Core.Services
{
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;

	public class AccountService : IAccountService
	{

		private readonly ApplicationDbContext context;

		public AccountService(ApplicationDbContext _context)
		{
			context = _context;
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
				//Log exception.
				throw new ApplicationException("Something went wrong, while trying to change the user's profile image.");
			}
		}
	}
}
