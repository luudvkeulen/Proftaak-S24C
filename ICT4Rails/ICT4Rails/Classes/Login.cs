using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
    public class Login : User
    {
        public string UserName { get; set; }
        public string EncryptedPassword { get; set; }
        public string Role { get; set; }

        public Login(string username, string password, string role, string name, string surname) : base(name, surname)
        {
            UserName = username;
            EncryptedPassword = password;
            Role = role;
        }
    }
}
