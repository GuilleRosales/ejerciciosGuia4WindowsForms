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
    public partial class Ejercicio10Form : Form
    {
        public Ejercicio10Form()
        {
            InitializeComponent();
        }

        private void Ejercicio10Form_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(txtNota3.Text))
            {
                MessageBox.Show("Rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);

            if (nota1 > 10 || nota2 > 10 || nota3 > 10)
            {
                MessageBox.Show("Las notas no pueden exceder de 10.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nota1 < 0 || nota2 < 0 || nota3 < 0)
            {
                MessageBox.Show("Las notas no pueden ser menores que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio < 7)
            {
                lblResultado.Text = $"El promedio es {promedio}. El estudiante ha reprobado.";
            }
            else
            { 
                lblResultado.Text = $"El promedio es {promedio}. El estudiante ha aprobado.";
            }
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblCampo1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
