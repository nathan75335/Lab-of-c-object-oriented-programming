using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }

        public string NameOfPizza { get; set; }

        public decimal Price { get; set; }

        public DateTime TimeOfOrder { get; set; }

        public Order(int orderId, string userName, string nameOfPizza, decimal price, DateTime timeOfOrder)
        {
            OrderId = orderId;
            UserName = userName;
            NameOfPizza = nameOfPizza;
            Price = price;
            TimeOfOrder = timeOfOrder;
            TimeOfOrder = timeOfOrder;
        }
        public Order( string userName , string nameOfPizza , decimal price)
        {
           
            UserName = userName;
            NameOfPizza = nameOfPizza;
            Price = price;
        }
        public Order( string userName, string nameOfPizza, decimal price, DateTime timeOfOrder)
        {
     
            UserName = userName;
            NameOfPizza = nameOfPizza;
            Price = price;
            TimeOfOrder = timeOfOrder;
            TimeOfOrder = timeOfOrder;
        }
    }
}
