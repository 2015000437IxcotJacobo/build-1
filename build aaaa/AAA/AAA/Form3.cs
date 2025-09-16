using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAA
{
    public partial class Form3 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=aaa;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();

        }

        String userPlaceHolder = "Usuario";
        String passPlaceHolder = "Contraseña";
        Boolean verActivado = false;
       
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
                
            
        }

        private void button2_Click_1(object sender, EventArgs e) //HOLA SIERRRAAAAAAAAA//
        {
            if (textBox1.Text == "Usuario" && textBox2.Text == "Contraseña")
            {
                MessageBox.Show("Bienvenido.");
                Form1 reg = new Form1();
                reg.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
            this.Hide();
        }
        private void colocarPlacehoderUser(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = userPlaceHolder;
                textBox1.ForeColor = Color.IndianRed;
            }
        }
        private void quitarPlacehoderUser(object sender, EventArgs e)
        {
            if (textBox1.Text == userPlaceHolder)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Firebrick;
            }
        }
        private void colocarPlacehoderPass(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = passPlaceHolder;
                textBox2.ForeColor = Color.IndianRed;
            }
        }
        private void salirPass(object sender, EventArgs e)
        {
            verActivado = false;
            button1.BackgroundImage = Properties.Resources.esconder;
        }

        private void quitarPlacehoderPass(object sender, EventArgs e)
        {
            if (textBox2.Text == passPlaceHolder)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Firebrick;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = userPlaceHolder;
            textBox1.ForeColor = Color.IndianRed;

            textBox1.Enter += quitarPlacehoderUser;
            textBox1.Leave += colocarPlacehoderUser;

            textBox2.Text = passPlaceHolder;
            textBox2.ForeColor = Color.IndianRed;

            textBox2.Enter += quitarPlacehoderPass;
            textBox2.Enter += (s, ev) => { if (!verActivado) textBox2.UseSystemPasswordChar = true; };
            textBox2.Leave += colocarPlacehoderPass;

            if (textBox2.Text != passPlaceHolder)
            {
                textBox2.Leave += salirPass;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verActivado = !verActivado;

            if (verActivado)
            {
                button1.BackgroundImage = Properties.Resources.ver;
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.esconder;
                textBox2.UseSystemPasswordChar = true;
            }
        }

    }
}
