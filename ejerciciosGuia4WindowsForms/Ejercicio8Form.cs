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
    public partial class Ejercicio8Form : Form
    {
        public Ejercicio8Form()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(nudEdad.Value);

            if (edad >= 18)
            {
                lblResultado.Text = $"Su edad es {edad}, es mayor de edad.";
            }
            else
            {
                lblResultado.Text = $"Su edad es {edad}, es menor de edad";
            }
        }

        private void Ejercicio8Form_Load(object sender, EventArgs e)
        {
            nudEdad.Minimum = 1;
            nudEdad.Maximum = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
