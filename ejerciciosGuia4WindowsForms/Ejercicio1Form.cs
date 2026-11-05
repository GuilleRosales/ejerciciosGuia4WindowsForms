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
    public partial class Ejercicio1Form : Form
    {
        public Ejercicio1Form()
        {
            InitializeComponent();
        }

        private void Ejercicio1Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) == false)
            {
                lblResultado.Text = $"¡Bienvenido/a, {txtNombre.Text}!";
            }
            else
            {
                MessageBox.Show("No se ha podido saludar. Rellene el campo de nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
