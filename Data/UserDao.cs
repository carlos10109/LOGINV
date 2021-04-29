using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao:ConnetionToMySql
    {
        

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection()) //Declaracion de la variable para la conexion de la base.
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "select * from users where  (LoginName = @user and password=@pass) or (Email= @user and password= @pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())// obtenemos los datos de la columna y asignamos a los campos de la cache de usuario
                        {
                            UserCache.idUser = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
    }
}
