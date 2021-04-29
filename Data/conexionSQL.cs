using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public  abstract class ConnetionToMySql //no puede instanciarse porque es una clase abstracta (ABSTRACT) y solo se una como clase tipo base 
        //el proposito de la clase abstracta es definir la funcionalidad que es comun a todas las clases que deriven de ella.
    {

        private readonly string connectionString;
        public ConnetionToMySql()
        {
            connectionString = "Server = localhost; Database= my_company;  User= root; port=3306; password=cdaR061198;"; // el erro que tuve fue poner mal el usuario es por eso que me marcaba error

        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
