using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class agrega_articulos
    {
        public static int Altaart(String Nombre, String Est, int Sto, double Pr)
        {
            int retorno = 0;
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("insert into articulos (Nombre, Estado, Stock, Precio) values ('{0}','{1}','{2}','{3}')", 
                Nombre, Est, Sto, Pr), conexion);

           retorno = comando.ExecuteNonQuery();
           
            conexion.Close();
            return retorno;
        }
    }
}
