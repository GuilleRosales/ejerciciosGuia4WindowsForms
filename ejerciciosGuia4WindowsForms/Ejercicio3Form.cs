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
    public partial class Ejercicio3Form : Form
    {
        public Ejercicio3Form()
        {
            InitializeComponent();
        }

        private void restaurarApariencia()
        {
            this.BackColor = Color.Gold;
            lblTitulo.Text = "3. Cambio de apariencia";
            lblTextoEjemplo.Font = new Font(lblTextoEjemplo.Font.FontFamily, 8.25f);
                    }

        private void Ejercicio3Form_Load(object sender, EventArgs e)
        {
            nudTamanoFuente.Minimum = 1;
        }

        private void btnCambiarTitulo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RoyalBlue;
            MessageBox.Show("El color de fondo ha cambiado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCambiarTitulo_Click_1(object sender, EventArgs e)
        {
            lblTitulo.Text = txtNuevoTitulo.Text;
            MessageBox.Show("El título ha cambiado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCambiarTexto_Click(object sender, EventArgs e)
        {
            lblTextoEjemplo.Font = new Font(lblTextoEjemplo.Font.FontFamily, (float)nudTamanoFuente.Value);
            MessageBox.Show("El tamaño de fuente del texto ha cambiado correctamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            restaurarApariencia();
            MessageBox.Show("La apariencia ha sido restaurada", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
