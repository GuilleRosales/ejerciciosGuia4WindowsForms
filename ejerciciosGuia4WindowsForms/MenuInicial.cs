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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void abrirForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio1Form());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio2Form());
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio3Form());
        }

        private void btnEj4_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio4Form());
        }

        private void btnEj5_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio5Form());
        }

        private void btnEj6_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio6Form());
        }

        private void btnEj7_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio7Form());
        }

        private void btnEj8_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio8Form());
        }

        private void btnEj9_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio9Form());
        }

        private void btnEj10_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio10Form());
        }

        private void btnEj11_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio11Form());
        }

        private void btnEj12_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio12Form());
        }

        private void btnEj13_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio13Form());
        }

        private void btnEj14_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio14Form());
        }

        private void btnEj15_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio15Form());
        }

        private void btnEj16_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio16Form());
        }
    }
}
