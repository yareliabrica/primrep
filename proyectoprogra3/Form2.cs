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

    public partial class Form2 : Form
    {
        String nivelu;
        public void nivel(String a)
        {
            nivelu = a;
        }

        public Form2()
        {
            InitializeComponent();
            button3.Visible = false;//usuarios
            label1.Visible = false;//label usuarios
            button6.Visible = false;//pedidos
            label6.Visible = false;//label pedidos
            button5.Visible = false;//ventas
            label3.Visible = false;//label ventas
            button1.Visible = false;//clientes
            label2.Visible = false;//label clientes
            button2.Visible = false;//articulos
            btValida.Visible = true;

        }
        public String getNivel()
        {
            return nivelu;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //this.Hide();
            Form3 men = new Form3();
            men.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Hide();
            Form1 men = new Form1();
            men.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            articulos men = new articulos();
            men.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form4 men = new Form4();
            men.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ventas men = new ventas();
            men.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ventas men = new ventas();
            men.Show();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btValida_Click(object sender, EventArgs e)
        {
            
            if (nivelu.Equals("1"))
            {
                button3.Visible = true;//usuarios
                label1.Visible = true;//label usuarios
                button6.Visible = true;//pedidos
                label6.Visible = true;//label pedidos
                button5.Visible = true;//ventas
                label3.Visible = true;//label ventas
                button1.Visible = true;//clientes
                label2.Visible = true;//label clientes
                button2.Visible = true;//articulos
                btValida.Visible = false;
            }
            else if (nivelu.Equals("2"))
            {
                button3.Visible = false;//usuarios
                label1.Visible = false;//label usuarios
                button6.Visible = true;//pedidos
                label6.Visible = true;//label pedidos
                button5.Visible = true;//ventas
                label3.Visible = true;//label ventas
                button1.Visible = true;//clientes
                label2.Visible = true;//label clientes
                button2.Visible = true;//articulos
                btValida.Visible = false;

            }
            else if (nivelu.Equals("3"))
            {
                button3.Visible = false;//usuarios
                label1.Visible = false;//label usuarios
                button6.Visible = false;//pedidos
                label6.Visible = false;//label pedidos
                button5.Visible = false;//ventas
                label3.Visible = false;//label ventas
                button1.Visible = false;//clientes
                label2.Visible = false;//label clientes
                button2.Visible = true;//articulos
                btValida.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

