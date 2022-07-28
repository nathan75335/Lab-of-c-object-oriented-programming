using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyPizzaClasses
{
    public class UserCrud
    {
        public List<User>? Users { get; set; } = null;

        MyPizzaCrud myPizzaCrud = new MyPizzaCrud();
        public bool LoadUserFromDatabase()
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

                command.CommandText = "Select * from Users";

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var list = new List<User>();

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object userName = reader.GetValue(1);
                        object password = reader.GetValue(2);
                        try
                        {
                            list.Add(new User(Convert.ToInt32(id), userName.ToString(), password.ToString()));
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    Users = list;
                }
            }
            return true;
        }
        public bool InsertANewUser(User user)
        {
            LoadUserFromDatabase();

            if (Users == null)

                Users = new List<User>();

            var userseek = GetUserByName(user.UserName);

            if (userseek == null)
            {
                using (SqlConnection conn = new SqlConnection(myPizzaCrud.ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(myPizzaCrud.ConnectionString, conn);
                    SqlParameter userNameParameter = new SqlParameter("@userName", user.UserName);
                    SqlParameter passwordParameter = new SqlParameter("@password", user.Password);
                    command.Parameters.Add(userNameParameter);
                    command.Parameters.Add(passwordParameter);
                    command.CommandText = "INSERT Users(UserName , Password) VALUES(@userName , @password);";
                    command.ExecuteNonQuery();
                    return true;
                   
                }
            }
            return false;
        }

        public User? GetUserByName(string Name)
        {
            var user = (from u in Users where u.UserName == Name select u).FirstOrDefault();
            return user;
        }
    }
}
