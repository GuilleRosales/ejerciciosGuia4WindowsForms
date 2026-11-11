namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio7Form
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.rdbRectangulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCuadrado = new System.Windows.Forms.RadioButton();
            this.rdbCirculo = new System.Windows.Forms.RadioButton();
            this.rdbTriangulo = new System.Windows.Forms.RadioButton();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.lblCampos = new System.Windows.Forms.Label();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
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
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "7. Cálculo del área de figuras";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 350);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(776, 91);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Esperando operación...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.AutoSize = true;
            this.btnConvertir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(333, 310);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(123, 37);
            this.btnConvertir.TabIndex = 12;
            this.btnConvertir.Text = "Calcular";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Visible = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // rdbRectangulo
            // 
            this.rdbRectangulo.AutoSize = true;
            this.rdbRectangulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectangulo.Location = new System.Drawing.Point(262, 81);
            this.rdbRectangulo.Name = "rdbRectangulo";
            this.rdbRectangulo.Size = new System.Drawing.Size(106, 25);
            this.rdbRectangulo.TabIndex = 15;
            this.rdbRectangulo.TabStop = true;
            this.rdbRectangulo.Text = "Rectángulo";
            this.rdbRectangulo.UseVisualStyleBackColor = true;
            this.rdbRectangulo.CheckedChanged += new System.EventHandler(this.rdbRectangulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione una figura";
            // 
            // rdbCuadrado
            // 
            this.rdbCuadrado.AutoSize = true;
            this.rdbCuadrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCuadrado.Location = new System.Drawing.Point(63, 81);
            this.rdbCuadrado.Name = "rdbCuadrado";
            this.rdbCuadrado.Size = new System.Drawing.Size(96, 25);
            this.rdbCuadrado.TabIndex = 13;
            this.rdbCuadrado.TabStop = true;
            this.rdbCuadrado.Text = "Cuadrado";
            this.rdbCuadrado.UseVisualStyleBackColor = true;
            this.rdbCuadrado.CheckedChanged += new System.EventHandler(this.rdbCuadrado_CheckedChanged);
            // 
            // rdbCirculo
            // 
            this.rdbCirculo.AutoSize = true;
            this.rdbCirculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCirculo.Location = new System.Drawing.Point(675, 81);
            this.rdbCirculo.Name = "rdbCirculo";
            this.rdbCirculo.Size = new System.Drawing.Size(77, 25);
            this.rdbCirculo.TabIndex = 17;
            this.rdbCirculo.TabStop = true;
            this.rdbCirculo.Text = "Círculo";
            this.rdbCirculo.UseVisualStyleBackColor = true;
            this.rdbCirculo.CheckedChanged += new System.EventHandler(this.rdbCirculo_CheckedChanged);
            // 
            // rdbTriangulo
            // 
            this.rdbTriangulo.AutoSize = true;
            this.rdbTriangulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriangulo.Location = new System.Drawing.Point(466, 81);
            this.rdbTriangulo.Name = "rdbTriangulo";
            this.rdbTriangulo.Size = new System.Drawing.Size(93, 25);
            this.rdbTriangulo.TabIndex = 16;
            this.rdbTriangulo.TabStop = true;
            this.rdbTriangulo.Text = "Triángulo";
            this.rdbTriangulo.UseVisualStyleBackColor = true;
            this.rdbTriangulo.CheckedChanged += new System.EventHandler(this.rdbTriangulo_CheckedChanged);
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(127, 214);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 18;
            this.txtCampo1.Visible = false;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampos.Location = new System.Drawing.Point(305, 121);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(179, 25);
            this.lblCampos.TabIndex = 19;
            this.lblCampos.Text = "Rellene los campos";
            this.lblCampos.Visible = false;
            this.lblCampos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCampo1
            // 
            this.lblCampo1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo1.Location = new System.Drawing.Point(30, 164);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(291, 25);
            this.lblCampo1.TabIndex = 20;
            this.lblCampo1.Text = "campo1";
            this.lblCampo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCampo1.Visible = false;
            // 
            // lblCampo2
            // 
            this.lblCampo2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo2.Location = new System.Drawing.Point(486, 164);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(274, 25);
            this.lblCampo2.TabIndex = 22;
            this.lblCampo2.Text = "campo 2";
            this.lblCampo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCampo2.Visible = false;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(572, 214);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(100, 20);
            this.txtCampo2.TabIndex = 21;
            this.txtCampo2.Visible = false;
            this.txtCampo2.TextChanged += new System.EventHandler(this.txtCampo2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(722, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.rdbCirculo);
            this.Controls.Add(this.rdbTriangulo);
            this.Controls.Add(this.rdbRectangulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbCuadrado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio7Form";
            this.Text = "7. Cálculo del área de figuras";
            this.Load += new System.EventHandler(this.Ejercicio7Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.RadioButton rdbRectangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCuadrado;
        private System.Windows.Forms.RadioButton rdbCirculo;
        private System.Windows.Forms.RadioButton rdbTriangulo;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}