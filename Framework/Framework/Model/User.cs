using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public class User
    {
        public User(string email,string password)
        {
            this.EMail = email;
            this.Password = password;
        }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
