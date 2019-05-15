using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyectoprogra3
{
    class Use
    {
        String ObtenerNivel;// 
        public static int Autenticar (String pUsuario , String pContraseña)
        { 
        int retorno = -1;
        MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select*from Usuarios where Nombreusuario='{0}' and contraseña='{1}'",
                pUsuario, pContraseña), conexion);

                MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) 
            {
                retorno = 50;
            }
            conexion.Close();
            return retorno;
    }

        public static List<CU> Mostrar(String Us)
        {
            List<CU> lista = new List<CU>();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * from Usuarios ", Us), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

               CU usua = new CU();
                usua.ID= reader.GetString(0);
                usua.Usuario = reader.GetString(4);
                usua.Nombre = reader.GetString(1);
                usua.ApellidoP = reader.GetString(2);
                usua.ApellidoM = reader.GetString(3);



                lista.Add(usua);
            }
            conexion.Close();
            return lista;


        }
        public static String nivel(String usuario)
        {
            String nivelu;
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * from Usuarios where Nombreusuario='{0}'", usuario), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            nivelu = reader["Nivel"].ToString();
            String ObtenerNivel = nivelu;

            return nivelu;
        }

    }

}
