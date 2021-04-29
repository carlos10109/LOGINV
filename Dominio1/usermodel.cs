using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;



namespace Dominio1
{
    public class usermodel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)//enviando parametros requeridos, en esta clase se realiza toda la logica de negocios, validacion y seguridad
        {

            return userDao.Login(user, pass); //capa de negocios en ves de capa de nominios para que no maneje capas de negocios

        }
        
        
    }
}
