using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class Cliente
    {
        public static List<Cl> Mostrar(String Us)
        {
            List<Cl> lista = new List<Cl>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * from clientes ", Us), conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Cl cli = new Cl();
                
                cli.Nombre = reader.GetString(1);
                cli.ApellidoP = reader.GetString(2);
                cli.ApellidoM = reader.GetString(3);
               cli.pais = reader.GetString(4);


                lista.Add(cli);
            }
            conexion.Close();
            return lista;
        }
        public static List<Cl> EstadoCuenta()
        {
            List<Cl> lista = new List<Cl>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select Nombre, ApellidoP, ApellidoM, credito, adeudo from clientes"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Cl cli = new Cl();

                cli.Nombre = reader.GetString(1);
                cli.ApellidoP = reader.GetString(2);
                cli.ApellidoM = reader.GetString(3);
                cli.credito = reader.GetString(4);


                lista.Add(cli);
            }
            conexion.Close();
            return lista;
        }
        public static List<Cl> Mostrars()
        {
            List<Cl> lista = new List<Cl>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select idClientes, ApellidoP, ApellidoM, RFC from clientes "), conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                Cl cli = new Cl();

              
                cli.ApellidoP = reader.GetString(1);
                cli.ApellidoM = reader.GetString(2);
                cli.RFC = reader.GetString(3);


                lista.Add(cli);
            }
            conexion.Close();
            return lista;
        }

    }
}
