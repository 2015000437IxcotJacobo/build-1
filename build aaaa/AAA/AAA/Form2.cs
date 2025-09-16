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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=aaa;Integrated Security=True");

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                if (textBox5.Text == textBox6.Text)
                {
                    SqlCommand comando = new SqlCommand("INSERT INTO loginA(nombre, apellido, usuario, contrasena) VALUES(@nombre,@apellido,@usuario,@contrasena)", conexion);
                    comando.Parameters.AddWithValue("@nombre", textBox1.Text);
                    comando.Parameters.AddWithValue("@apellido", textBox2.Text);
                    comando.Parameters.AddWithValue("@usuario", textBox3.Text);
                    comando.Parameters.AddWithValue("@contrasena", textBox5.Text);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registrado exitosamente");
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    
                }
                else MessageBox.Show("Las contraseñas deben coincidir");
            }
            catch (Exception)
            {

                throw;
            }
            conexion.Close();
        }
    }
}
