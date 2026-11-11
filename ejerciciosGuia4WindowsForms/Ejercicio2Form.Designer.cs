namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio2Form
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(122, 183);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(127, 20);
            this.nudEdad.TabIndex = 1;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.AutoCompleteCustomSource.AddRange(new string[] {
            "Ingeniería en Sistemas",
            "Administración de Empresas",
            "Diseño Gráfico",
            "Mercadeo",
            "Contaduría Pública"});
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(121, 246);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(128, 21);
            this.cmbCarrera.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(121, 345);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnviar.Size = new System.Drawing.Size(103, 42);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 41);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "2. Datos personales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carrera:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(427, 176);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(235, 25);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Esperando respuesta...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese sus datos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(712, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Ejercicio2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2. Datos personales";
            this.Load += new System.EventHandler(this.Ejercicio2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}