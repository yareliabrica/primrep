using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class AgregaUsuario
    {
        public static int AltaUsuario(String Nombre, String APP, String APM, String Usuario, String Pass, String Nivel)
        {
            int retorno = 0;
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios (Nombre, ApellidoP, ApellidoM, NombreUsuario, Contraseña, Nivel) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", Nombre, APP, APM, Usuario, Pass, Nivel), BDcomun.ObtenerConexion());

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                retorno = 1;
            }
            conexion.Close();
            return retorno;
        }
    }
}
