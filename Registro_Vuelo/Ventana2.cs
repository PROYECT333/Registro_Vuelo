using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Registro_Vuelo
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalAsientos = 5;
            int seleccionados = (int)numericUpDown1.Value;
            int restantes = totalAsientos - seleccionados;

            label2.Text = "Asientos disponibles: " + totalAsientos;
            label4.Text = "Asientos restantes: " + restantes;

            if (restantes == 0)
            {
                MessageBox.Show("Guardado Correctamente");
                MessageBox.Show("Listos para despegar");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana3 ventana = new Ventana3();
            ventana.Show();
        }
    }
}
