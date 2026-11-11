namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio8Form
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
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
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
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "8. Determinar si una persona es mayor de edad";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(287, 184);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(218, 20);
            this.nudEdad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese una edad";
            // 
            // btnConvertir
            // 
            this.btnConvertir.AutoSize = true;
            this.btnConvertir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(331, 313);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(123, 37);
            this.btnConvertir.TabIndex = 16;
            this.btnConvertir.Text = "Comprobar";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 362);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(776, 91);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Esperando operación...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(712, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio8Form";
            this.Text = "8. Determinar si una persona es mayor de edad";
            this.Load += new System.EventHandler(this.Ejercicio8Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}