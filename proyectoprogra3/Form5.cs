using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoprogra3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nombre = textBox1.Text;
            String APP = textBox2.Text;
            String APM = textBox3.Text;
            String Usuario = textBox4.Text;
            String Contraseña = textBox5.Text;
            String Nivel = textBox6.Text;
            if ( Nombre == null)
            {
                MessageBox.Show("Falta agregar nombre");
            }
            if (APP == null)
            {
                MessageBox.Show("Falta agregar apellido paterno");
            }
            if (APM == null)
            {
                MessageBox.Show("Falta agregar apellido materno");
            }
            if (Usuario == null)
            {
                MessageBox.Show("Falta agregar usuario ");
            }
            if (Contraseña == null)
            {
                MessageBox.Show("Falta agregar contraseña");
            }
            if (Nivel == null)
            {
                MessageBox.Show("Falta agregar nivel");
            }
            else if (Nombre != null && APP != null && APM != null && Usuario != null && Contraseña != null && Nivel != null)
            {
                AgregaUsuario.AltaUsuario(Nombre, APP, APM, Usuario, Contraseña, Nivel);
                MessageBox.Show("Se a registrado correctamente");

                /* Autenticar(Nombre, APP, APM, Usuario, Contraseña, Nivel);

                  MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=libreriabd; Uid=root; pwd=soyinvisible;");
                   MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios (Nombre, ApellidoP, ApellidoM, NombreUsuario, Contraseña, Nivel) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',)", Nombre, APP, APM,Usuario, Contraseña, Nivel),BDcomun.ObtenerConexion());
                   MySqlCommand reader = comando.ExecuteReader();
                   MessageBox.Show("Se registro el usuario exitosamente ");*/

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 men = new Form4();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 men = new Form1();
            men.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
