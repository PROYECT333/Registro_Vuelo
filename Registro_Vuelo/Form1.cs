using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Registro_Vuelo
{
    public partial class Form1 : Form
    {

        string conexion = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                AttachDbFilename=C:\USERS\CHARLY\SOURCE\REPOS\REGISTRO_VUELO\REGISTRO_VUELO\VUELOS.MDF;
                                Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        void CargarDatos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlDataAdapter da = new("SELECT * FROM Vuelos", conn);
                    DataTable dt = new();
                    int v = da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana2 ventana = new Ventana2();
            ventana.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(conexion);
                conn.Open();

                MessageBox.Show("Conexión exitosa ✔️");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            string id = numericUpDown1.Text.ToString();
            string clase = comboBox2.Text.ToString();
            string origen = comboBox1.Text.ToString();
            string destino = comboBox3.Text.ToString();
            DateTime salida = dateTimePicker1.Value;
            DateTime retorno = dateTimePicker2.Value;
            string pasajeros = comboBox4.Text.ToString();
            string pasajeross = numericUpDown2.Text.ToString();
            string ida = "";
            if (radioButton1.Checked)
            {
                ida = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                ida = radioButton2.Text;
            }

            string query = @"INSERT INTO Vuelos (Id, clase, origen, destino, salida, retorno, pasajeros, pasajeross, ida) 
VALUES (@Id, @clase, @origen, @destino, @salida, @retorno, @pasajeros, @pasajeross, @ida)";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (int)numericUpDown1.Value;
                    cmd.Parameters.Add("@clase", SqlDbType.VarChar).Value = comboBox2.Text;
                    cmd.Parameters.Add("@origen", SqlDbType.VarChar).Value = comboBox1.Text;
                    cmd.Parameters.Add("@destino", SqlDbType.VarChar).Value = comboBox3.Text;
                    cmd.Parameters.Add("@salida", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@retorno", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                    cmd.Parameters.Add("@pasajeros", SqlDbType.VarChar).Value = comboBox4.Text;
                    cmd.Parameters.Add("@pasajeross", SqlDbType.Int).Value = (int)numericUpDown2.Value;
                    cmd.Parameters.Add("@ida", SqlDbType.VarChar).Value = ida;

                    cmd.ExecuteNonQuery();
                    CargarDatos();

                }

                MessageBox.Show("Insertado correctamente ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            numericUpDown1.Value = 0;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            numericUpDown2.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
