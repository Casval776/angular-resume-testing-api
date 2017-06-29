using resume_testing_api.Models.UserModel.Interfaces;

namespace resume_testing_api.ViewReaders.Users.Interfaces
{
    /// <summary>
    /// Interface to wrap User-related DB/Mock Layer communications into a generic model.
    /// </summary>
    public interface IUserViewReader
    {
        /// <summary>
        /// Logins the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>String containing a token or null</returns>
        string Login(IUser user);

        /// <summary>
        /// Logouts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>True if operation was successful, False otherwise</returns>
        bool Logout(IUser user);
    }
}