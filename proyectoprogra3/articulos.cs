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
    public partial class articulos : Form
    {
        String nivel;
        public void setNivel(String a)
        {
            nivel = a;
        }
        public articulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Articulos2.Mostrar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Form2 men = new Form2();
            men.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 men = new Form1();
            men.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            agregar_articulos men = new agregar_articulos();
            men.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ordenamiento = comboBox1.Text;
            if (Ordenamiento == "ID")
            {
                dataGridView1.DataSource = OrdenarArticulos.ordenaid();
            }
            else if (Ordenamiento == "Nombre")
            {
                dataGridView1.DataSource = OrdenarArticulos.ordenaNom();
            }
            else if (Ordenamiento == "Estado")
            {
                dataGridView1.DataSource = OrdenarArticulos.ordenaestdo();
            }
            else if (Ordenamiento == "Stock")
            {
                dataGridView1.DataSource = OrdenarArticulos.ordenaStock();
            }
            else if (Ordenamiento == "Precio")
            {
                dataGridView1.DataSource = OrdenarArticulos.ordenaPrec();
            }
            else
            {
                //Mensaje de opcion no valida
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                


        }
    }
}
