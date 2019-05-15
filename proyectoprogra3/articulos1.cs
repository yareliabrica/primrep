using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra3
{
    class articulos1
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Stock { get; set; }
        public string Precio { get; set; }
     

        public articulos1() { }
        public articulos1(string Nombre, string Estado, string Stock, string Precio)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Estado = Estado;
            this.Stock = Stock;
            this.Precio = Precio;

        }
    }
}
