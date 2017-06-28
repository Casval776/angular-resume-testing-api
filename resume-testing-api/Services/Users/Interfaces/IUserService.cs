using resume_testing_api.Models.UserModel;
using resume_testing_api.Models.UserModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume_testing_api.Services.Users.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Processes the login functionality, successfully logging the user in and returning a token.
        /// </summary>
        /// <param name="user">Qualified User credentials</param>
        /// <returns>Login Token or null if unsuccessful</returns>
        string Login(IUser user);

        /// <summary>
        /// Processes the logout functionality, successfully logging the user out and returning success value.
        /// </summary>
        /// <param name="user">Qualified User object</param>
        /// <returns>True if success, False otherwise</returns>
        bool Logout(IUser user);
    }
}