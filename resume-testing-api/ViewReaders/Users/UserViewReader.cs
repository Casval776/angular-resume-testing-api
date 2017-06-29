using resume_testing_api.ViewReaders.Users.Interfaces;
using System.Collections.Generic;
using resume_testing_api.Models.UserModel.Interfaces;

namespace resume_testing_api.ViewReaders.Users
{
    /// <summary>
    /// ViewReader responsible for communication with database/mock layer
    /// </summary>
    /// <seealso cref="resume_testing_api.ViewReaders.Users.Interfaces.IUserViewReader" />
    public class UserViewReader : IUserViewReader
    {
        private readonly Dictionary<string, string> userList = new Dictionary<string, string>()
        {
            { "test", "test" },
            { "admin", "admin" }
        };
        /// <summary>
        /// Logins the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// String containing a token or null
        /// </returns>
        public string Login(IUser user)
        {
            //Validate against mock data
            try
            {
                //Generate a mock token and return it
                return $"{user.Username}{userList[user.Username]}-776".GetHashCode().ToString();
            }
            catch (KeyNotFoundException knfe)
            {
                //The user does not exist in the mock data.
                return null;
            }
        }

        /// <summary>
        /// Logouts the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// True if operation was successful, False otherwise
        /// </returns>
        public bool Logout(IUser user)
        {
            //Normally we'd clear the token in the DB and set 'LoggedIn' = false
            //But we're mocking data for now, so just return true
            return true;
        }
    }
}