using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                comboBox2.Enabled = true;
            }
            comboBox2.Items.Clear();
            dep();

        }
        private void dep()
        {// hola :D 
            String[] items = null;
            switch (comboBox1.SelectedItem)
            {
                case "Alta Verapaz":
                     items = new string[] {"Chahal", "Chisec", "Cobán", "Fray Bartolomé de las Casas", "La Tinta", "Lanquín", "Panzós","Raxruhá", "San Cristóbal Verapaz", "San Juan Chamelco", "San Pedro Carchá", "Santa Cruz Verapaz","Cahabón", "Senahú", "Tamahú", "Tactic", "Tucurú"};
                    break;
                case "Baja Verapaz":
                     items = new string[] {"Cubulco", "Granados", "Purulhá", "Rabinal", "Salamá", "San Jerónimo", "San Miguel Chicaj", "Santa Cruz el Chol"};
                    break;
                case "Chimaltenango":
                     items = new string[] { "Chimaltenango", "San Martín Jilotepeque", "Parramos", "El Tejar", "San José Poaquil", "Acatenango", "Santa Apolonia", "Tecpán Guatemala", "Patzún", "Santa Cruz Balanyá", "Patzicia", "Pochuta", "San Pedro Yepocapa", "Zaragoza","Comalapa","Iztapa", };
                    break;
                case "Chiquimula":
                     items = new string[] { "Chiquimula", "Olopa", "San Juan Ermita", "La Unión", "Camotán", "Jocotán", "Concepción Las Minas", "Esquipulas","Ipala","Quetzaltepec","Arada","San Jacinto"};
                    break;
                case "El Progreso":
                    items = new string[] {"El Jícaro", "Guastatoya", "Morazán", "San Agustín Acasaguastlán", "San Antonio La Paz","San Cristóbal Acasaguastlán", "Sanarate", "Sansare"};                 
                    break;
                case "Escuintla":
                    items = new string[] {"Escuintla", "Guanagazapa", "Iztapa", "La Democracia", "La Gomera", "Masagua", "Nueva Concepción","Palín", "San José", "San Vicente Pacaya", "Santa Lucía Cotzumalguapa", "Siquinalá", "Tiquisate"};
                    break;
                case "Guatemala":
                    items = new string[] {"Amatitlán", "Chinautla", "Chuarrancho", "Ciudad de Guatemala", "Fraijanes", "Mixco", "Palencia","San José del Golfo", "San José Pinula", "San Juan Sacatepéquez", "San Miguel Petapa", "San Pedro Ayampuc", "San Pedro Sacatepéquez", "San Raymundo", "Santa Catarina Pinula", "Villa Canales", "Villa Nueva"};
                    break;
                case "Huehuetenango":
                    items = new string[] {"Aguacatán", "Chiantla", "Colotenango", "Concepción Huista", "Cuilco", "Huehuetenango","Jacaltenango", "La Democracia", "La Libertad", "Malacatancito", "Nentón","San Antonio Huista", "San Gaspar Ixchil", "San Ildefonso Ixtahuacán", "San Juan Atitán","San Juan Ixcoy", "San Mateo Ixtatán", "San Miguel Acatán", "San Pedro Nécta", "San Pedro Soloma","San Rafael La Independencia", "San Rafael Pétzal", "San Sebastián Cotán", "San Sebastián Huehuetenango","Santa Ana Huista", "Santa Bárbara", "Santa Cruz Barillas", "Santa Eulalia", "Santiago Chimaltenango", "Todos Santos Cuchumatán"};
                    break;
                case "Izabal":
                    items = new string[] {"El Estor", "Livingston", "Los Amates", "Morales", "Puerto Barrios"};
                    break;
                case "Jalapa":
                    items = new string[] {"Jalapa", "Mataquescuintla", "Monjas", "San Carlos Alzatate", "San Luis Jilotepeque", "San Manuel Chaparrón", "San Pedro Pinula"};
                    break;
                case "Jutiapa":
                    items = new string[] {"Agua Blanca", "Asunción Mita", "Atescatempa", "Comapa", "Conguaco", "El Adelanto", "El Progreso","Jalpatagua","Jerez", "Jutiapa", "Moyuta", "Pasaco", "Quesada", "San José Acatempa", "Santa Catarina Mita","Yupiltepeque", "Zapotitlán"};
                    break;
                case "Petén":
                    items = new string[] {"Dolores", "Isla de Flores (Santa Elena de la Cruz)", "La Libertad","Melchor de Mencos", "Poptún", "San Andrés", "San Benito", "San Francisco", "San José", "San Luis","Santa Ana", "Sayaxché"};
                    break;
                case "Quetzaltenango":
                    items = new string[] {"Almolonga", "Cabricán", "Cajolá", "Cantel", "Colomba Costa Cuca", "Concepción Chiquirichapa","El Palmar", "Flores Costa Cuca", "Génova", "Huitán", "La Esperanza", "Olintepeque","Palestina de Los Altos", "Quetzaltenango","Coatepeque", "Salcajá", "San Carlos Sija", "San Francisco La Unión","San Juan Ostuncalco", "San Martín Sacatepéquez", "San Mateo", "San Miguel Sigüilá", "Sibilia", "Zunil"};
                    break;
                case "Quiché":
                    items = new string[] {"Canillá", "Chajul", "Chicamán", "Chiché", "Santo Tomás Chichicastenango", "Chinique", "Cunén","Ixcán", "Joyabaj", "Nebaj", "Pachalum", "Patzité", "Sacapulas", "San Andrés Sajcabajá","San Antonio Ilotenango", "San Bartolomé Jocotenango", "San Juan Cotzal", "San Pedro Jocopilas","Santa Cruz del Quiché", "Uspantán", "Zacualpa"};
                    break;
                case "Sacatepéquez":
                    items = new string[] {"Alotenango", "Antigua Guatemala", "Ciudad Vieja", "Jocotenango", "Magdalena Milpas Altas","Pastores", "San Antonio Aguas Calientes", "San Bartolomé Milpas Altas", "San Lucas Sacatepéquez","San Miguel Dueñas", "Santa Catalina Barahona", "Santa Lucía Milpas Altas", "Santa María de Jesús","Santiago Sacatepéquez", "Santo Domingo Xenacoj", "Sumpango"};
                    break;
                case "San Marcos":
                    items = new string[] {"Ayutla", "Catarina", "Comitancillo", "Concepción Tutuapa", "El Quetzal", "El Tumbador", "Esquipulas Palo Gordo","Ixchiguán", "La Blanca", "La Reforma", "Malacatán", "Nuevo Progreso", "Ocós", "Pajapita", "Río Blanco","San Antonio Sacatepéquez", "San Cristóbal Cucho", "San José El Rodeo", "San José Ojetenam", "San Lorenzo","San Marcos", "San Miguel Ixtahuacán", "San Pablo", "San Pedro Sacatepéquez", "San Rafael Pie de la Cuesta","Sibinal", "Sipacapa", "Tacaná", "Tajumulco", "Tejutla"};
                    break;
                case "Santa Rosa":
                    items = new string[] {"Barberena", "Casillas", "Chiquimulilla", "Cuilapa", "Guazacapán", "Nueva Santa Rosa", "Oratorio","Pueblo Nuevo Viñas", "San Juan Tecuaco", "San Rafael Las Flores", "Santa Cruz Naranjo","Santa María Ixhuatán", "Santa Rosa de Lima", "Taxisco"};
                    break;
                case "Sololá":
                    items = new string[] {"Concepción", "Nahualá", "Panajachel", "San Andrés Semetabaj", "San Antonio Palopó", "San José Chacayá","San Juan La Laguna", "San Lucas Tolimán", "San Marcos La Laguna", "San Pablo La Laguna", "San Pedro La Laguna","Santa Catarina Ixtahuacán", "Santa Catarina Palopó", "Santa Clara La Laguna", "Santa Cruz La Laguna","Santa Lucía Utatlán", "Santa María Visitación", "Santiago Atitlán", "Sololá"};
                    break;
                case "Suchitepéquez":
                    items = new string[] {"Chicacao", "Cuyotenango", "Mazatenango", "Patulul", "Pueblo Nuevo", "Río Bravo", "San Antonio Suchitepéquez","San Bernardino", "San Felipe", "San Francisco Zapotitlán", "San José El Idolo", "San Jorge","Santo Domingo Suchitepéquez", "Santo Tomás La Unión","San Lorenzo","Samayac","San Pablo Jocopilas","Sn Miguel Panan","San Gabriel","Santa Barbara","San Juan Bautista"};
                    break;
                case "Totonicapán":
                    items = new string[] {"Momostenango", "San Andrés Xecul", "San Bartolo", "San Cristóbal Totonicapán", "San Francisco el Alto", "Santa Lucía La Reforma", "Totonicapán"};
                    break;
                case "Zacapa":
                    items = new string[] {"Cabañas", "Estanzuela", "Huité", "La Unión", "Río Hondo", "San Diego","San Jorge", "Teculután", "Usumatlán", "Zacapa", "Gualán"};
                    break;
                case "Retalhuleu":
                    items = new string[] {"Champerico","El Asintal","Nuevo San Carlos","Retalhuleu","San Andrés Villa Seca","San Felipe","San Martín Zapotitlán","San Sebastián","Santa Cruz Muluá"};
                    break;
                default:
                    items = new string[] { "" };
                    break;
            }
            comboBox2.Items.AddRange(items);
            
        }
    }
}
