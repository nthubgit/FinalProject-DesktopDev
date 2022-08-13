using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DesktopDev.Business
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        public User(string username, string password, int role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public User() //for login
        {
            Role = 0;
        }
    }
}
