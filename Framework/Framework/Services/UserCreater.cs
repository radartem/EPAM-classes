using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services
{
    public class UserCreater
    {
        public static User RegregisteredUser()
        {
            return new User(TestDataReader.GetData("User.EMail"), TestDataReader.GetData("User.Password"));
        }

        public static User RegregisteredUserWithIncorrectPassword()
        {
            return new User(TestDataReader.GetData("User.EMail.Incorrect"), TestDataReader.GetData("User.Password.Incorrect"));
        }

        public static User NonRegregisteredUser()
        {
            return new User(TestDataReader.GetData("User.EMail.Incorrect"), TestDataReader.GetData("User.Password"));
        }
    }
}
