using resume_testing_api.Models.UserModel;
using System.Web.Http;

namespace resume_testing_api.Controllers.Users.Interfaces
{
    public interface IUserController
    {
        /// <summary>
        /// Public-facing endpoint to log in a user with the specified credentials.
        /// </summary>
        /// <param name="user">Qualified User object containing username/password</param>
        /// <returns>IHttpActionResult.Ok with result of login process</returns>
        IHttpActionResult Login([FromBody]User user);

        /// <summary>
        /// Public-facing endpoint to log out a user with the specified credentials.
        /// </summary>
        /// <param name="user">Qualified User object containing username/token</param>
        /// <returns>IHttpActionResult.Ok with result of logout process</returns>
        IHttpActionResult Logout([FromBody]User user);
    }
}