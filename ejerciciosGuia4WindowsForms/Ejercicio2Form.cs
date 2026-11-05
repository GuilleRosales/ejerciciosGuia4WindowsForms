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
    public partial class Ejercicio2Form : Form
    {
        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        private void Ejercicio2Form_Load(object sender, EventArgs e)
        {
            cmbCarrera.Items.AddRange(new string[]
                { 
                    "Ingeniería en Sistemas",
                    "Administración de Empresas",
                    "Diseño Gráfico",
                    "Mercadeo",
                    "Contaduría Pública"
                }
            );
            nudEdad.Minimum = 1;
            nudEdad.Maximum = 100;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Llene el campo de nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblResultado.Text = $"Nombre: {txtNombre.Text}\n" +
                    $"Edad: {nudEdad.Value.ToString()}\n" +
                    $"Carrera: {cmbCarrera.SelectedItem.ToString()}";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
