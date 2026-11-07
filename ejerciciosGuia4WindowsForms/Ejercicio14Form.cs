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
    public partial class Ejercicio14Form : Form
    {
        public Ejercicio14Form()
        {
            InitializeComponent();
        }

        private void Ejercicio14Form_Load(object sender, EventArgs e)
        {

        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int limite = Convert.ToInt32(nudNumero.Value);

            if (limite < 0)
            {
                MessageBox.Show("Ingrese un número positivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            for (int i = 1; i <= limite; i++)
            {
                if (i % 2 != 0)
                {
                }
                else
                {
                    lstResultados.Items.Add(
                        i
                    );
                }
            }

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
