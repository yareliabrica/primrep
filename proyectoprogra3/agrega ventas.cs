using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    class agrega_ventas
    {
        public static int Altaventas(int folio, String Fecha, String cliente, String articulo, int cantidad, String Tipo)
        {
            int retorno = 0;
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando1 = new MySqlCommand(string.Format("INSERT INTO detalleventa(idDetalledeventa, cantidad, articulo ,idventa, idCliente)VALUES ('{0}','{1}','{2}','{3}','{4}')", folio, cantidad, articulo, folio, cliente), BDcomun.ObtenerConexion());
            MySqlDataReader reader1 = comando1.ExecuteReader();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO venta(idventa,cliente, tipo, fecha) VALUES ('{0}','{1}','{2}','{3}')", folio,cliente,Tipo,Fecha), BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            Consu(cliente, articulo, cantidad);
           
           
            conexion.Close();
            return retorno;
        }
        public static void Consu(String RFC, string articulosA, int cantidad)
        {
            String RFC1 = RFC;
            String articulo = articulosA;       
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando1 = new MySqlCommand(string.Format("update articulos set Stock=Stock-'{0}' WHERE Nombre='{1}'", cantidad, articulo), BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando1.ExecuteReader();
            /*MySqlCommand comando = new MySqlCommand(string.Format("update clientes, articulos set clientes.credito=clientes.credito-(articulos.precio*'{0}')  WHERE clientes.RFC = ´{1}´ AND articulos.nombre='{2}'", cantidad, RFC1, articulosA), BDcomun.ObtenerConexion());
            MySqlDataReader reader1 = comando.ExecuteReader();*/


            conexion.Close();
        
        }

    }
}
