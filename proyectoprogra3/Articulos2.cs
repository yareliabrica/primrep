using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class Articulos2
    {
        public static List<articulos1> Mostrar(String Us)
        {
            List<articulos1> lista = new List<articulos1>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * from articulos ", Us), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                articulos1 art= new articulos1();
                
                art.ID = reader.GetString(0);
                art.Nombre = reader.GetString(1);

                art.Estado= reader.GetString(2);
                art.Stock= reader.GetString(3);
                art.Precio= reader.GetString(4);



                lista.Add(art);
            }
            conexion.Close();
            return lista;
        }
    }
}
