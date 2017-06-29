using resume_testing_api.Controllers.Users.Interfaces;
using System;
using System.Web.Http;
using resume_testing_api.Models.UserModel;
using resume_testing_api.Services.Users.Interfaces;
using resume_testing_api.Services.Users;
using resume_testing_api.Models.UserModel.Interfaces;

namespace resume_testing_api.Controllers.Users
{
    /// <summary>
    /// Implementation of the IUserController interface specifically used for basic User domain model objects
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    /// <seealso cref="resume_testing_api.Controllers.Users.Interfaces.IUserController" />
    public class UserController : ApiController, IUserController
    {
        #region Private Members
        /// <summary>
        /// The IUserService object used to process and transform data.
        /// </summary>
        private readonly IUserService svc;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        public UserController()
        {
            if (svc == null) svc = new UserService();
        }
        #endregion

        #region Public Interface Implementations
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
            //If Token is missing...
            if (string.IsNullOrEmpty(user.Token))
                return Ok(new
                {
                    res = false
                });

            //Process logout functionality
            return Ok(new
            {
                res = svc.Logout(user)
            });
        }
        #endregion
    }
}
