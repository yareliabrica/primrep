using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class OrdenaUsuario
    {
        public static List<CU> ordenaid()
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * From usuarios ORDER BY idUsuarios"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                CU usua = new CU();
                usua.ID = reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;
        }
        public static List<CU> ordenaNom()
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * From usuarios ORDER BY Nombre"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                CU usua = new CU();
                usua.ID = reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;
        }
        public static List<CU> ordenaAPP()
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * From usuarios ORDER BY ApellidoP"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                CU usua = new CU();
                usua.ID = reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;
        }
        public static List<CU> ordenaAPM()
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * From usuarios ORDER BY ApellidoM"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                CU usua = new CU();
                usua.ID = reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;
        }
        public static List<CU> ordenausuario()
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * From usuarios ORDER BY NombreUsuario"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                CU usua = new CU();
                usua.ID = reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;
        }
     
        }
    }

