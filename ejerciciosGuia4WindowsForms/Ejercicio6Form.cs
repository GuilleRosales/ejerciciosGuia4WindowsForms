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
            if (rdbCelciusFahrenheit.Checked)
            {
                double celcius = Convert.ToDouble(txtTemperatura.Text);
                double fahrenheit = (celcius * 9 / 5) + 32;

                lblResultado.Text = $"{celcius} °C equivalen a {fahrenheit} °F";
            }
            else if (rdbFahrenheitCelcius.Checked)
            {
                double fahrenheit = Convert.ToDouble(txtTemperatura.Text);
                double celcius = (fahrenheit - 32) * 5 / 9;

                lblResultado.Text = $"{fahrenheit} °F equivalen a {celcius} °C";
            }
            else
            {
                MessageBox.Show("Marque una opción para operar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
