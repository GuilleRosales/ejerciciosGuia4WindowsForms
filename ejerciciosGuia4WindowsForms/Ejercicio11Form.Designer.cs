namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio11Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(444, 83);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(356, 358);
            this.lblResultado.TabIndex = 39;
            this.lblResultado.Text = "Esperando datos...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(80, 246);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 38;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(80, 111);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 36;
            // 
            // btnResultado
            // 
            this.btnResultado.AutoSize = true;
            this.btnResultado.BackColor = System.Drawing.Color.PaleGreen;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(17, 375);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(222, 37);
            this.btnResultado.TabIndex = 35;
            this.btnResultado.Text = "Calcular descuento";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Precio del producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo de cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ingrese datos del cliente y del producto";
            // 
            // lblCampo1
            // 
            this.lblCampo1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo1.Location = new System.Drawing.Point(-11, 83);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(291, 25);
            this.lblCampo1.TabIndex = 31;
            this.lblCampo1.Text = "Nombre del cliente";
            this.lblCampo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 41);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "11. Descuento en una compra";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(80, 315);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cantidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(75, 180);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCliente.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(712, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio11Form";
            this.Text = "11. Descuento en una compra";
            this.Load += new System.EventHandler(this.Ejercicio11Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}