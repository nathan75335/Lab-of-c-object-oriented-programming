using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace MyPizzaClasses
{
    public class MyPizzaCrud :IMyPizzaCrud
    {
        public List<IMyPizza>? pizzaList { get; set; } = null;
        //public static string ConnectionString { get; set; } = @"Data source=(LocalDB)\mssqllocaldb;AttachDbFilename=C:\Users\user\Desktop\CoursovaiaEvgeni\CoursWork.mdf;Integrated Security=True";
        public string ConnectionString { get; set; } = @"Data Source=DESKTOP-88KJB83\SQLEXPRESS;Initial Catalog=CoursWork;Integrated Security=True;";
 
        public bool LoadPizzaFromDataBase()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(ConnectionString, conn);

                command.CommandText = "Select * from Pizza";

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var list = new List<IMyPizza>();

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object Name = reader.GetValue(1);
                        object Description = reader.GetValue(2);
                        object Picture = reader.GetValue(3);
                        object Price = reader.GetValue(4);

                        try
                        {
                            IMyPizza pizza = new MyPizza(Convert.ToInt32(id), Name.ToString(), Description.ToString(),
                               Convert.ToDecimal(Price), Picture.ToString());

                            list.Add(pizza);
                        }
                        catch
                        {
                            throw;

                        }
                    }

                    pizzaList = list;
                }


            }

            return true;
        }

        public bool InsertANewPizzaToDatabase(IMyPizza pizza)
        {
            LoadPizzaFromDataBase();

            if (pizzaList == null)

                pizzaList = new List<IMyPizza>();

            var pizzaseek = GetPizzaByName(pizza.Name);

            if (pizzaseek == null)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(ConnectionString, conn);

                    SqlParameter nameParameter = new SqlParameter("@name", pizza.Name);
                    SqlParameter priceParameter = new SqlParameter("@price", pizza.Price);
                    SqlParameter pictureParameter = new SqlParameter("@picture", pizza.Picture);
                    SqlParameter descriptionParameter = new SqlParameter("@description", pizza.Description);

                    command.Parameters.Add(nameParameter);
                    command.Parameters.Add(priceParameter);
                    command.Parameters.Add(pictureParameter);
                    command.Parameters.Add(descriptionParameter);

                    command.CommandText = $"INSERT Pizza(Name ,Price , Picture , Description) values(@name , @price , @picture , @description )";

                    command.ExecuteNonQuery();
                }

                return true;
            }
            return false;
        }

        public bool UpdatePizza(IMyPizza pizza)
        {
            LoadPizzaFromDataBase();

            if (pizzaList == null)

                pizzaList = new List<IMyPizza>();

            var pizzaseek = GetIdPizza(pizza.Name);

            if (pizzaseek != null)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(ConnectionString, conn);

                    SqlParameter idParameter = new SqlParameter("@id", pizzaseek);
                    SqlParameter nameParameter = new SqlParameter("@name", pizza.Name);
                    SqlParameter priceParameter = new SqlParameter("@price", pizza.Price);
                    SqlParameter pictureParameter = new SqlParameter("@picture", pizza.Picture);
                    SqlParameter descriptionParameter = new SqlParameter("@description", pizza.Description);

                    command.Parameters.Add(nameParameter);
                    command.Parameters.Add(priceParameter);
                    command.Parameters.Add(pictureParameter);
                    command.Parameters.Add(descriptionParameter);
                    command.Parameters.Add(idParameter);

                    command.CommandText = "UPDATE Pizza SET Name = @name ,Picture = @picture , Price =@price , Description = @description WHERE PizzaId = @id";
                    
                        command.ExecuteNonQuery();
                   
                        return true;
                   
                }
            }
            return false;
        }

        public bool DeletePizzaFromDataBase(IMyPizza pizza)
        {
            LoadPizzaFromDataBase();

            if (pizzaList == null)

                pizzaList = new List<IMyPizza>();

            var pizzaseek = GetIdPizza(pizza.Name);

            if (pizzaseek != null)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(ConnectionString, conn);
                    SqlParameter idParameter = new SqlParameter("@id", pizzaseek);
                    command.Parameters.Add(idParameter);
                    command.CommandText = "Delete Pizza WHERE PizzaId = @id";
              
                    command.ExecuteNonQuery();

                    return true;

                }
            }
            return false;
        }
        public IMyPizza GetPizzaByName(string Name)
        {
            var pizza = (from pizz in pizzaList
                         where pizz.Name == Name
                         select pizz).FirstOrDefault();


            return pizza;
        }
        public int GetIdPizza(string Name)
        {
            var id = (from pizz in pizzaList
                      where pizz.Name == Name
                      select pizz.PizzaId).FirstOrDefault();
            return id;
        }
    }
}
