using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public class MyPizza :IMyPizza
    {
        public MyPizza(int pizzaId, string name, string description, decimal price, string picture)
        {
            PizzaId = pizzaId;
            Name = name;
            Description = description;
            Price = price;
            Picture = picture;
        }
        public MyPizza(string name, string description, decimal price, string picture)
        {
            Name = name;
            Description = description;
            Price = price;
            Picture=picture;    
        }

        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }
    }
}
