using resume_testing_api.Models.UserModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resume_testing_api.Models.UserModel
{
    public class User : IUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}