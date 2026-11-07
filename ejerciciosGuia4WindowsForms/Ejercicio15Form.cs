using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosGuia4WindowsForms
{
    public partial class Ejercicio15Form : Form
    {
        public Ejercicio15Form()
        {
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int numero = Convert.ToInt32(nudNumero.Value);

            if (numero < 0)
            {
                MessageBox.Show("Ingrese un número positivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int suma = 0;

            lstResultados.Items.Add($"Entrada: {numero}");
            lstResultados.Items.Add($"Proceso:");
            for (int i = 1; i <= numero; i++)
            {
                if (i == 1)
                {
                    lstResultados.Items.Add($"{i}");
                    suma += i;
                    continue;
                }
                lstResultados.Items.Add($"+ {i}");
                suma += i;
            }
            lstResultados.Items.Add($"Salida: {suma}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
