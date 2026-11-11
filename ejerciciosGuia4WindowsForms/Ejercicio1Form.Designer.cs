namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio1Form
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "1. Saludo personalizado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(293, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.Color.Gold;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Location = new System.Drawing.Point(354, 301);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(89, 35);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Text = "¡Saludar!";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(288, 117);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(216, 25);
            this.lblInstruccion.TabIndex = 3;
            this.lblInstruccion.Text = "Ingrese su nombre:";
            // 
            // lblResultado
            // 
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResultado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(0, 427);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(800, 23);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Esperando respuesta...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(712, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1. Saludo personalizado";
            this.Load += new System.EventHandler(this.Ejercicio1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}