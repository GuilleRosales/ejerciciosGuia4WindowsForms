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
    public partial class Ejercicio4Form : Form
    {
        public Ejercicio4Form()
        {
            InitializeComponent();
        }

        private void Ejercicio4Form_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;

            bool numero1Valido = double.TryParse(txtNum1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNum2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
                return;
            }
            else
            {
                lblResultado.Text = $"{Convert.ToString(numero1)} + {Convert.ToString(numero2)} = {Convert.ToString(numero1 + numero2)}";
            }

        }
    }
}
