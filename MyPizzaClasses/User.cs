using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public class User
    {
        public User(int userId, string userName, string password)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
        }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

