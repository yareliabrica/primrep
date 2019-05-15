using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra3
{
  public partial class CU
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM{ get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public CU() { }
        public CU (string Nombre,string Usuario,string ApellidoP,string ApellidoM)
        {
            this.ID = ID;
            this.Nombre=Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.Usuario = Usuario;

        }
    }
}
