using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public class Administrator
    {
        public Administrator()
        {
            UserId = "Evgeni";

            Password = "Evgeni@145";
        }

        public string UserId { get; set; }

        public string Password { get; set; }
    }
}
