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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 men = new Form5();
            men.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Form2 men = new Form2();
            men.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 men = new Form1();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Use.Mostrar(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ordenamiento = comboBox1.Text;
            if (Ordenamiento == "ID")
            {
                dataGridView1.DataSource = OrdenaUsuario.ordenaid();
            }
            else if (Ordenamiento == "Nombre")
            {
                dataGridView1.DataSource = OrdenaUsuario.ordenaNom();
            }
            else if (Ordenamiento == "Apellido Paterno")
            {
                dataGridView1.DataSource = OrdenaUsuario.ordenaAPP();
            }
            else if (Ordenamiento == "Apellido Materno")
            {
                dataGridView1.DataSource = OrdenaUsuario.ordenaAPM();
            }
            else if (Ordenamiento == "Usuario")
            {
                dataGridView1.DataSource = OrdenaUsuario.ordenausuario();
            }

           
            else
            {
                //Mensaje de opcion no valida
            }
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
