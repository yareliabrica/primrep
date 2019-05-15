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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String folios = textBox1.Text;
            String fecha = dateTimePicker1.Text;
            String clientes = comboBox1.Text;
            String aticulost = comboBox2.Text;
            String cantidadS = textBox3.Text;
            String TipoS = comboBox3.Text;

            int folio = int.Parse(folios);
            int cantidad = int.Parse(cantidadS);
            agrega_ventas.Altaventas(folio, fecha, clientes, aticulost, cantidad, TipoS);
            MessageBox.Show("se a guardado");
        }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
              dataGridView1.DataSource = Articulos2.Mostrar(textBox9.Text);
          }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Cliente.Mostrars();
            dataGridView2.DataSource = LlenarArticulo.Mostrars();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = LlenarCliente.idcliente();
           comboBox1.DisplayMember = "idClientes";
           comboBox1.ValueMember = "RFC";
            comboBox2.DataSource = LlenarArticulo.Mostrars();
            comboBox2.DisplayMember = "idArticulos";
            comboBox2.ValueMember = "Nombre";
           


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            /*Form2 men = new Form2();
            men.Show();*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
