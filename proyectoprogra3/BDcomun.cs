using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyectoprogra3
{
    public class BDcomun
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=libreriabd; Uid=root; pwd=soyinvisible;");

            conectar.Open();
            return conectar;
        }

    }
}