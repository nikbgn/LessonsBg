namespace LessonsBg.Core.Contracts
{
	/// <summary>
	/// Account service
	/// </summary>
	public interface IAccountService
	{
		/// <summary>
		/// Changes the profile image of an user.
		/// </summary>
		/// <param name="user">The user's id.</param>
		/// <param name="newAvatarUrl">The URL address to the user's new profile image.</param>
		/// <returns></returns>
		
		public Task ChangeUserProfileImageAsync(string userId, string newAvatarUrl);

		/// <summary>
		/// Changes user's teaching location.
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="newTeachingLocation"></param>
		/// <returns></returns>
		public Task ChangeUserTeachingLocationAsync(string userId, string newTeachingLocation);
	}
}
