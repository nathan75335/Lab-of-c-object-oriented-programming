using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyPizzaClasses
{
    public class TrashCrud
    {
        public List<Order>? orders { get; set; } = null;

        MyPizzaCrud myPizzaCrud = new MyPizzaCrud();
        public bool LoadOrdersFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(myPizzaCrud.ConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(myPizzaCrud.ConnectionString, conn);

                command.CommandText = "Select TrashId, UserName , Name ,Price  from Trash,Pizza , Users  where Trash.UserId = Users.UserId and Trash.PizzaId = Pizza.PizzaId";

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
                       
                            var order = new Order( userName.ToString(), pizzaName.ToString(),
                                Convert.ToDecimal(price));
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

                SqlParameter pizzaName = new SqlParameter("@pizzaName", order.NameOfPizza);
                SqlParameter userName = new SqlParameter("@userName", order.UserName);
               

                command.Parameters.Add(pizzaName);
                command.Parameters.Add(userName);
               

                command.CommandText = "Insert Trash(PizzaId , UserId ) values((select PizzaId from Pizza where Name=@pizzaName) ,(select UserId from Users where UserName=@userName));";

                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    }
}
