using resume_testing_api.Controllers.Users.Interfaces;
using System;
using System.Web.Http;
using resume_testing_api.Models.UserModel;
using resume_testing_api.Services.Users.Interfaces;
using resume_testing_api.Services.Users;

namespace resume_testing_api.Controllers.Users
{
    public class UserController : ApiController, IUserController
    {
        private readonly IUserService svc;

        public UserController()
        {
            if (svc == null) svc = new UserService();
        }

        /// <summary>
        /// Public-facing endpoint to log in a user with the specified credentials.
        /// </summary>
        /// <param name="user">Qualified User object containing username/password</param>
        /// <returns>
        /// IHttpActionResult.Ok with result of login process
        /// </returns>
        [HttpPost]
        [Route("api/user/login/")]
        public IHttpActionResult Login([FromBody] User user)
        {
            //Obligatory requirement checks
            if (string.IsNullOrEmpty(user.Username.Trim()) ||
                string.IsNullOrEmpty(user.Password.Trim()))
                return Ok(new
                {
                    res = string.Empty
                });

            //Post to service and return
            return Ok(new
            {
                res = svc.Login(user)
            });
        }

        /// <summary>
        /// Public-facing endpoint to log out a user with the specified credentials.
        /// </summary>
        /// <param name="user">Qualified User object containing username/token</param>
        /// <returns>
        /// IHttpActionResult.Ok with result of logout process
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        [Route("api/user/logout")]
        public IHttpActionResult Logout([FromBody] User user)
        {
            throw new NotImplementedException();
        }
    }
}
