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
    public partial class Ejercicio9Form : Form
    {
        public Ejercicio9Form()
        {
            InitializeComponent();
        }

        private void Ejercicio9Form_Load(object sender, EventArgs e)
        {
            nudNumero.Minimum = -10000000000000;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNumero.Value);

            if (numero < 0)
            {
                lblResultado.Text = $"El número ingresado es {numero}. Es negativo.";
            }
            else if (numero > 0)

            {
                lblResultado.Text = $"El número ingresado es {numero}. Es positivo.";
            }
            else if (numero == 0)
            {
                lblResultado.Text = $"El número ingresado es {numero}. Es igual a cero.";
            }
        }
    }
}
