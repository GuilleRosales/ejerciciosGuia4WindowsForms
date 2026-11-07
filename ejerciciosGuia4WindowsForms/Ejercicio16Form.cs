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
    public partial class Ejercicio16Form : Form
    {
        public Ejercicio16Form()
        {
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int numero = Convert.ToInt32(nudNumero.Value);
            long factorial = 1;

            if (numero == 0)
            {
                factorial = 1;
            }


            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            lstResultados.Items.Add($"{numero}! =");

            for (int i = numero; i >= 1; i--)
            {
                if (i == numero)
                {
                    lstResultados.Items.Add($"{i}");
                    continue;
                }
                lstResultados.Items.Add($"× {i}");
            }

            lstResultados.Items.Add($"{numero}! = {factorial}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
