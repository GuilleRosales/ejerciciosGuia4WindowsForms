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
    public partial class Ejercicio13Form : Form
    {
        public Ejercicio13Form()
        {
            InitializeComponent();
        }

        private void Ejercicio13Form_Load(object sender, EventArgs e)
        {

        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int numero = Convert.ToInt32(nudNumero.Value);

            for (int i = 1; i <= 10; i++)
            {
                lstResultados.Items.Add(
                    numero + " × " + i + " = " + numero * i
                );
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
