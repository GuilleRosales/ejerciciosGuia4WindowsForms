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
    public partial class Ejercicio7Form : Form
    {
        public Ejercicio7Form()
        {
            InitializeComponent();
        }

        private void mostrarCampos(int campos)
        {
            lblCampos.Visible = true;
            lblCampo1.Visible = true;
            txtCampo1.Visible = true;
            if (campos == 1) 
            {
                lblCampo2.Visible = false;
                txtCampo2.Visible = false;
            }
            if (campos == 2)
            {
                lblCampo2.Visible = true;
                txtCampo2.Visible = true;
            }
            btnConvertir.Visible = true;
        }

        private void Ejercicio7Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void rdbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            mostrarCampos(1);
            lblCampo1.Text = "Medida de lado";
        }

        private void rdbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarCampos(2);
            lblCampo1.Text = "Medida de base";
            lblCampo2.Text = "Medida de altura";
        }

        private void rdbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarCampos(2);
            lblCampo1.Text = "Medida de base";
            lblCampo2.Text = "Medida de altura";
        }

        private void rdbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarCampos(1);
            lblCampo1.Text = "Medida de radio";
        }

        private void txtCampo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo2.Text))
            {
                MessageBox.Show("Rellene todos los campos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdbCuadrado.Checked)
            {
                double lado = Convert.ToDouble(txtCampo1.Text);
                lblResultado.Text = $"Área de cuadrado = L × L. A = {lado * lado}";
            }
            if (rdbRectangulo.Checked)
            {
                double b = Convert.ToDouble(txtCampo1.Text);
                double altura = Convert.ToDouble(txtCampo2.Text);

                lblResultado.Text = $"Área de rectángulo = B × a. A = {b*altura}";
            }
            if (rdbTriangulo.Checked)
            {
                double b = Convert.ToDouble(txtCampo1.Text);
                double altura = Convert.ToDouble(txtCampo2.Text);

                lblResultado.Text = $"Área de triángulo = B × A / 2. A = {b * altura/2}";
            }
            if (rdbCirculo.Checked)
            {
                double radio = Convert.ToDouble(txtCampo1.Text);

                lblResultado.Text = $"Área de círculo = π × r². A = {Math.PI * Math.Pow(radio, 2)}";
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
