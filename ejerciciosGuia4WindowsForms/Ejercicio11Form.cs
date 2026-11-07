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
    public partial class Ejercicio11Form : Form
    {
        public Ejercicio11Form()
        {
            InitializeComponent();
        }

        private void Ejercicio11Form_Load(object sender, EventArgs e)
        {
            cmbTipoCliente.Items.AddRange(new string[] 
            {
                "Regular",
                "Frecuente",
                "Premium"
            }
            );
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;
            double precio;
            int cantidad; 

            bool numero1Valido = double.TryParse(txtPrecioProducto.Text, out precio);
            bool numero2Valido = int.TryParse(txtCantidad.Text, out cantidad);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double subtotal = precio * cantidad;

            double valorDescuento = 0;
            double total = 0;
            double porcentajeDescuento = 0;

            string tipoCliente = cmbTipoCliente.SelectedItem.ToString();

            switch (tipoCliente)
            {
                case "Regular":
                    porcentajeDescuento = 0;
                    valorDescuento = subtotal * porcentajeDescuento;
                    total = subtotal - valorDescuento;
                    break;
                case "Frecuente":
                    porcentajeDescuento = 0.05;
                    valorDescuento = subtotal * porcentajeDescuento;
                    total = subtotal - valorDescuento;
                    break;
                case "Premium":
                    porcentajeDescuento = 0.10;
                    valorDescuento = subtotal * porcentajeDescuento;
                    total = subtotal - valorDescuento;
                    break;
            }

            lblResultado.Text = $"Cliente: {nombre}\n" +
                $"Subtotal: ${subtotal}\n" +
                $"Descuento: ${valorDescuento}\n" +
                $"Total: ${total}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
