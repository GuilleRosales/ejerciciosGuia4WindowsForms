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
    public partial class Ejercicio6Form : Form
    {
        public Ejercicio6Form()
        {
            InitializeComponent();
        }

        private void Ejercicio6Form_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double temperatura;

            bool numero1Valido = double.TryParse(txtTemperatura.Text, out temperatura);

            if (!numero1Valido)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (rdbCelciusFahrenheit.Checked)
            {
                double fahrenheit = (temperatura * 9 / 5) + 32;

                lblResultado.Text = $"{temperatura} °C equivalen a {fahrenheit} °F";
            }
            else if (rdbFahrenheitCelcius.Checked)
            {
                double celcius = (temperatura - 32) * 5 / 9;

                lblResultado.Text = $"{temperatura} °F equivalen a {celcius} °C";
            }
            else
            {
                MessageBox.Show("Marque una opción para operar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
