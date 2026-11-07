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
    public partial class Ejercicio12Form : Form
    {
        public Ejercicio12Form()
        {
            InitializeComponent();
        }

        private void Ejercicio12Form_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;

            bool numero1Valido = double.TryParse(txtPeso.Text, out peso);
            bool numero2Valido = double.TryParse(txtAltura.Text, out altura);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                        
            if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Los campos de los números no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (altura <= 0 || peso <= 0)
            {
                MessageBox.Show("Ingrese valores mayores que cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double IMC = peso / Math.Pow(altura, 2);

            if (IMC < 18.5)
            {
                lblResultado.Text = $"IMC: {IMC} Clasificación: Bajo peso";
            }
            
            if (IMC >= 18.5 && IMC <= 24.9)
            {
                lblResultado.Text = $"IMC: {IMC} Clasificación: Peso normal";
            }

            if (IMC >= 25 && IMC <= 29.9)
            {
                lblResultado.Text = $"IMC: {IMC} Clasificación: Sobrepeso";
            }

            if (IMC >= 30)
            {
                lblResultado.Text = $"IMC: {IMC} Clasificación: Obesidad";
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
