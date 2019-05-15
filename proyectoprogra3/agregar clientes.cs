using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoprogra3
{
    public partial class agregar_clientes : Form
    {
        public agregar_clientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 men = new Form3();
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nombre = textBox1.Text;
            String APEP = textBox2.Text;
            String APEM = textBox3.Text;
            String Pais = textBox4.Text;
            String Estado = textBox5.Text;
            String Municipio= textBox6.Text;
            String Colonia = textBox7.Text;
            String Calle = textBox8.Text;
            String NES = textBox9.Text;
            String NIS = textBox10.Text;
            String RFC = textBox11.Text;
            String TelefonoS = textBox14.Text;
            String Correo = textBox13.Text;
            String creditos = textBox12.Text;
            String Adeudos = textBox15.Text;
          
            int NE = int.Parse(NES);
            int NI = int.Parse(NIS);
            int Telefono = int.Parse(TelefonoS);
            double credito = double.Parse(creditos);
            double adeudo = double.Parse(Adeudos);
            AgregaClientes.AltaClientes(Nombre, APEP, APEM, Pais, Estado, Municipio,Colonia,Calle,NE,NI,RFC,Telefono,Correo,credito,adeudo);

          //  Agrega_Cliente1.AltaClientes(Nombre, APEP, APEM, Pais, Estado, Municipio, Colonia, Calle, NE, NI, RFC, Telefono, Correo);                 
                MessageBox.Show("Se a registrado correctamente");


            }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_clientes_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
       

