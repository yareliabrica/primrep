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
    public partial class agregar_articulos : Form
    {
        public agregar_articulos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Nombre = textBox1.Text;
            String Est= textBox2.Text;
            String Stos = textBox3.Text;
            String Prs = textBox4.Text;
            int Pr = int.Parse(Prs);
            int Sto = int.Parse(Stos);
            agrega_articulos.Altaart(Nombre, Est, Sto, Pr);
            MessageBox.Show("Se a registrado correctamente");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 men = new Form1();
            men.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            articulos men = new articulos();
            men.Show();
        }
    }
}
