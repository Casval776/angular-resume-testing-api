using resume_testing_api.ViewReaders.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resume_testing_api.Models.UserModel.Interfaces;

namespace resume_testing_api.ViewReaders.Users
{
    public class UserViewReader : IUserViewReader
    {
        public string Login(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool Logout(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}