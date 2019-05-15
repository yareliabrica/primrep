using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class Agrega_Cliente1
    {
       /* public static int AltaClientes(String Nombre, String APEP, String APEM, String Pais, String Estado, String Municipio, String Colonia, String Calle, String NE, String NI, String RFC, String Telefono, String Correo)
        {
            int retorno = 0;
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO clientes (Nombre, ApellidoP, ApellidoM, Pais, Estado, Municipio, Colonia, Calle, NumeroExt, NumeroInt, RFC, Telefono, Correo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", Nombre, APEP, APEM, Pais, Estado, Municipio, Colonia, Calle, NE, NI, RFC, Telefono, Correo), conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                retorno = 1;
            }
            conexion.Close();
            return retorno;*/
        }
}

