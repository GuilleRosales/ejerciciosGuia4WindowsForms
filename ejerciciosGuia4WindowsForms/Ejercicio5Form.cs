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
    public partial class Ejercicio5Form : Form
    {
        
        public Ejercicio5Form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operacion = cmbOperación.SelectedItem.ToString();

            switch (operacion)
            {
                case "Sumar":
                    lblSigno.Visible = true;
                    lblSigno.Text = "+";
                    btnOperar.Text = "Sumar";
                    break;
                case "Restar":
                    lblSigno.Visible = true;
                    lblSigno.Text = "-";
                    btnOperar.Text = "Restar";
                    break;
                case "Multiplicar":
                    lblSigno.Visible = true;
                    lblSigno.Text = "×";
                    btnOperar.Text = "Multiplicar";
                    break;
                case "Dividir":
                    lblSigno.Visible = true;
                    lblSigno.Text = "÷";
                    btnOperar.Text = "Dividir";
                    break;
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio5Form_Load(object sender, EventArgs e)
        {
            cmbOperación.Items.AddRange(new string[] 
                { 
                    "Sumar",
                    "Restar",
                    "Multiplicar",
                    "Dividir"
                }
            );
        }

        private void btnOperar_Click_1(object sender, EventArgs e)
        {
            double num1;
            double num2;

            bool numero1Valido = double.TryParse(txtNum1.Text, out num1);
            bool numero2Valido = double.TryParse(txtNum2.Text, out num2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOperación.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Los campos de los números no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string operacion = cmbOperación.SelectedItem.ToString();

            switch (operacion)
            {
                case "Sumar":
                    lblResultado.Text = $"{num1} + {num2} = {num1 + num2}";
                    break;
                case "Restar":
                    lblResultado.Text = $"{num1} - {num2} = {num1 - num2}";
                    break;
                case "Multiplicar":
                    lblResultado.Text = $"{num1} × {num2} = {num1 * num2}";
                    break;
                case "Dividir":
                    if (num2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero. Inténtelo de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    lblResultado.Text = $"{num1} ÷ {num2} = {num1 / num2}";
                    break;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
