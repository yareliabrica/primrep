using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogra3
{
    class Cl
    {
       
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string credito { get; set; }
        public string adeudo { get; set; }
        public string pais{ get; set; }
        public string RFC { get; set; }

        public Cl() { }
        public Cl(string Nombre, string pais, string ApellidoP, string ApellidoM,string RFC,string credito,string adeudo)
        {
            this.adeudo = adeudo;
            this.credito = credito;
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.pais = pais;
            this.RFC = RFC;
        }
    }
}
  
   
  


