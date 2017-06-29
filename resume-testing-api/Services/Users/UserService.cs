using resume_testing_api.Services.Users.Interfaces;
using System;
using resume_testing_api.Models.UserModel.Interfaces;
using resume_testing_api.ViewReaders.Users.Interfaces;
using resume_testing_api.ViewReaders.Users;

namespace resume_testing_api.Services.Users
{
    /// <summary>
    /// Implementation of the IUserService interface for basic User CRUD operations.
    /// </summary>
    /// <seealso cref="resume_testing_api.Services.Users.Interfaces.IUserService" />
    public class UserService : IUserService
    {
        private readonly IUserViewReader rdr;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        public UserService()
        {
            if (rdr == null) rdr = new UserViewReader();
        }

        /// <summary>
        /// Processes the login functionality, successfully logging the user in and returning a token.
        /// </summary>
        /// <param name="user">Qualified User credentials</param>
        /// <returns>
        /// Login Token or null if unsuccessful
        /// </returns>
        public string Login(IUser user)
        {
            return rdr.Login(user);
        }

        /// <summary>
        /// Processes the logout functionality, successfully logging the user out and returning success value.
        /// </summary>
        /// <param name="user">Qualified User object</param>
        /// <returns>
        /// True if success, False otherwise
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Logout(IUser user)
        {
            return rdr.Logout(user);
        }
    }
}