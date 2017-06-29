using resume_testing_api.Models.UserModel.Interfaces;

namespace resume_testing_api.Helpers.Users
{
    /// <summary>
    /// Helper class to encapsulate common functions to the IUser domain model object.
    /// </summary>
    public static class UserHelper
    {
        /// <summary>
        /// Generates the mock token.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public static string GenerateMockToken(IUser user) => 
            $"{user.Username}{user.Password}-776".GetHashCode().ToString();
    }
}