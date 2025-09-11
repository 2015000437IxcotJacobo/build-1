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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=aaa;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            registros();
        }
        private void registros()
        {
            try
            {
                conexion.Open();
                SqlDataAdapter comando = new SqlDataAdapter("SELECT * FROM campos2", conexion);
                DataSet d = new DataSet();
                comando.Fill(d, "nombre");
                dataGridView1.DataSource = d.Tables["nombre"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void colocarPlacehoderUser(object sender, EventArgs e)
        {

        }

        private void quitarPlacehoderUser(object sender, EventArgs e)
        {

        }
        private void colocarPlacehoderPass(object sender, EventArgs e)
        {
            
        }
        private void salirPass(object sender, EventArgs e)
        {

        }

        private void quitarPlacehoderPass(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Usuario" && textBox2.Text == "Contraseña")
            {
                MessageBox.Show("Bienvenido.");
                Form3 reg = new Form3();
                reg.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO campos2(fecha, codigofac, nombreyapellido, edad, eg, referencia, telefonos, motivo, diagnostico, agendar, ecg, eco, tt, fetal, holter, consulta, medico) VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", conexion);
                comando.Parameters.AddWithValue("@1", dateTimePicker1.Value.Date);
                comando.Parameters.AddWithValue("@2", Convert.ToInt32(textBox2.Text));
                comando.Parameters.AddWithValue("@3", textBox3.Text);
                comando.Parameters.AddWithValue("@4", textBox4.Text);
                comando.Parameters.AddWithValue("@5", textBox5.Text);
                comando.Parameters.AddWithValue("@6", textBox6.Text);
                comando.Parameters.AddWithValue("@7", Convert.ToInt32(textBox7.Text));
                comando.Parameters.AddWithValue("@8", textBox8.Text);
                comando.Parameters.AddWithValue("@9", textBox9.Text);
                comando.Parameters.AddWithValue("@10", Convert.ToInt32(textBox10.Text));
                comando.Parameters.AddWithValue("@11", Convert.ToInt32(textBox11.Text));
                comando.Parameters.AddWithValue("@12", Convert.ToInt32(textBox12.Text));
                comando.Parameters.AddWithValue("@13", Convert.ToInt32(textBox13.Text));
                comando.Parameters.AddWithValue("@14", Convert.ToInt32(textBox14.Text));
                comando.Parameters.AddWithValue("@15", Convert.ToInt32(textBox15.Text));
                comando.Parameters.AddWithValue("@16", textBox16.Text);
                comando.Parameters.AddWithValue("@17", textBox17.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                registros();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update campos2 set fecha=@1, codigofac=@2, nombreyapellido=@3, edad=@4, eg=@5, referencia=@6, telefonos=@7, motivo=@8, diagnostico=@9, agendar=@10, ecg=@11, eco=@12, tt=@13, fetal=@14, holter=@15, consulta=@16, medico=@17 where id=@id", conexion);
                comando.Parameters.AddWithValue("@id", textBox1.Text);
                comando.Parameters.AddWithValue("@1", dateTimePicker1.Value.Date);
                comando.Parameters.AddWithValue("@2", Convert.ToInt32(textBox2.Text));
                comando.Parameters.AddWithValue("@3", textBox3.Text);
                comando.Parameters.AddWithValue("@4", textBox4.Text);
                comando.Parameters.AddWithValue("@5", textBox5.Text);
                comando.Parameters.AddWithValue("@6", textBox6.Text);
                comando.Parameters.AddWithValue("@7", Convert.ToInt32(textBox7.Text));
                comando.Parameters.AddWithValue("@8", textBox8.Text);
                comando.Parameters.AddWithValue("@9", textBox9.Text);
                comando.Parameters.AddWithValue("@10", Convert.ToInt32(textBox10.Text));
                comando.Parameters.AddWithValue("@11", Convert.ToInt32(textBox11.Text));
                comando.Parameters.AddWithValue("@12", Convert.ToInt32(textBox12.Text));
                comando.Parameters.AddWithValue("@13", Convert.ToInt32(textBox13.Text));
                comando.Parameters.AddWithValue("@14", Convert.ToInt32(textBox14.Text));
                comando.Parameters.AddWithValue("@15", Convert.ToInt32(textBox15.Text));
                comando.Parameters.AddWithValue("@16", textBox16.Text);
                comando.Parameters.AddWithValue("@17", textBox17.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                registros();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("delete from campos2 where id = @id", conexion);
                comando.Parameters.AddWithValue("@id", textBox1.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                registros();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlDataAdapter comando = new SqlDataAdapter("select * from campos2 WHERE id = " + textBox18.Text, conexion);
                DataSet d = new DataSet();
                comando.Fill(d, "nombre");
                dataGridView1.DataSource = d.Tables["nombre"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                registros();
            }
        }
    }
}
