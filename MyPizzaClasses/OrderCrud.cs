using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyPizzaClasses
{
    public class OrderCrud
    {
        public List<Order> orders { get; set; } = null;

        MyPizzaCrud myPizzaCrud = new MyPizzaCrud();
        public bool LoadOrdersFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myPizzaCrud.ConnectionString;
                try
                {
                    conn.Open();
                }
                catch
                {
                    return false;
                }

                SqlCommand command = new SqlCommand(myPizzaCrud.ConnectionString, conn);

                command.CommandText = "Select OrderId, UserName , Name ,Price ,TimeOfOrder  from Orders,Pizza , Users where Orders.UserId = Users.UserId and Orders.PizzaId = Pizza.PizzaId";

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var list = new List<Order>();
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object userName = reader.GetValue(1);
                        object pizzaName = reader.GetValue(2);
                        object price = reader.GetValue(3);
                        object timeOfOrder = reader.GetValue(4);
                       
                            var order = new Order(Convert.ToInt32(id), userName.ToString(), pizzaName.ToString(),
                                Convert.ToDecimal(price), Convert.ToDateTime(timeOfOrder));
                            list.Add(order);

                        
                    }
                    orders = list;
                    return true;
                }
            }
            return false;
        }
        public bool InsertANewOrder(Order order)
        {
            using (SqlConnection conn = new SqlConnection(myPizzaCrud.ConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(myPizzaCrud.ConnectionString, conn);

                SqlParameter pizzaName = new SqlParameter("@pizzaName" , order.NameOfPizza);
                SqlParameter userName = new SqlParameter("@userName", order.UserName);
                SqlParameter timeOfOrder = new SqlParameter("@timeOfOrder", order.TimeOfOrder);

                command.Parameters.Add(pizzaName);
                command.Parameters.Add(userName);
                command.Parameters.Add(timeOfOrder);

                command.CommandText = "Insert Orders(PizzaId , UserId , TimeOfOrder) values((select PizzaId from Pizza where Name=@pizzaName) ,(select UserId from Users where UserName=@userName) , @timeOfOrder );";

                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    }
}
