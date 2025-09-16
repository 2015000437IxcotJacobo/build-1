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
       


        private void button2_Click_1(object sender, EventArgs e) //sIERRA HUECOOOOOOOOOOOOOOOOO//
        {
            conexion.Open();
            string consulta = "select * from loginA where usuario= '" + textBox1.Text + "' and contrasena='" + textBox2.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader verificar;
            verificar = comando.ExecuteReader();

            if (verificar.HasRows == true)
            {
                Form1 db = new Form1();
                this.Hide();
                db.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
            }
            conexion.Close();
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
                textBox1.ForeColor = Color.RosyBrown;
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
                textBox2.ForeColor = Color.RosyBrown;
            }
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
            textBox1.ForeColor = Color.RosyBrown;

            textBox1.Enter += quitarPlacehoderUser;
            textBox1.Leave += colocarPlacehoderUser;

            textBox2.Text = passPlaceHolder;
            textBox2.ForeColor = Color.RosyBrown;

            textBox2.Enter += quitarPlacehoderPass;
            textBox2.Enter += (s, ev) => { if (!verActivado) textBox2.UseSystemPasswordChar = true; };
            textBox2.Leave += colocarPlacehoderPass;


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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
