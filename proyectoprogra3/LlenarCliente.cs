using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class LlenarCliente
    {
        public static List<Cl> idcliente()
        {
            List<Cl> lista = new List<Cl>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select idClientes, RFC from clientes"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Cl cli = new Cl();

                cli.Nombre = reader.GetString(0);
                cli.RFC = reader.GetString(1);


                lista.Add(cli);
            }
            conexion.Close();
            return lista;
        }
    }
}
