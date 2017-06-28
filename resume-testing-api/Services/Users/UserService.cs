using resume_testing_api.Services.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resume_testing_api.Models.UserModel.Interfaces;
using resume_testing_api.ViewReaders.Users.Interfaces;
using resume_testing_api.ViewReaders.Users;

namespace resume_testing_api.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserViewReader rdr;

        public UserService()
        {
            if (rdr == null) rdr = new UserViewReader();
        }
        public string Login(IUser user)
        {
            return rdr.Login(user);
        }

        public bool Logout(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}