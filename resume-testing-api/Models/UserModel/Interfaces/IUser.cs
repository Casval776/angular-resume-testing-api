namespace resume_testing_api.Models.UserModel.Interfaces
{
    /// <summary>
    /// Interface to wrap the User domain model object into generic functionality.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        string Password { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        string Token { get; set; }
    }
}