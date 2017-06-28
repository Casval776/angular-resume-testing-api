using resume_testing_api.Models.UserModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume_testing_api.ViewReaders.Users.Interfaces
{
    public interface IUserViewReader
    {
        string Login(IUser user);

        bool Logout(IUser user);
    }
}