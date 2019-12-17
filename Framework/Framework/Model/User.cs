using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public class User
    {
        public User(string email,string password,string name,string pNumber,string experience)
        {
            this.EMail = email;
            this.Password = password;
            this.Name = name;
            this.PNumber = pNumber;
            this.Experience = experience;
        }

        public override string ToString()
        {
            return "\nUser data: \n" +
                "EMail: " + EMail + "\n"+            
                "Password: " + Password + "\n" +
                "Name: " + Name + "\n" +
                "PNumber: " + PNumber + "\n" +
                "Experience: " + Experience + "\n";
        }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
        public string PNumber { get; set; }

    }
}
