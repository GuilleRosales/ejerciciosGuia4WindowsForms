namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio6Form
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
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.rdbCelciusFahrenheit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdbFahrenheitCelcius = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(323, 236);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(177, 20);
            this.txtTemperatura.TabIndex = 0;
            // 
            // rdbCelciusFahrenheit
            // 
            this.rdbCelciusFahrenheit.AutoSize = true;
            this.rdbCelciusFahrenheit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelciusFahrenheit.Location = new System.Drawing.Point(222, 132);
            this.rdbCelciusFahrenheit.Name = "rdbCelciusFahrenheit";
            this.rdbCelciusFahrenheit.Size = new System.Drawing.Size(166, 25);
            this.rdbCelciusFahrenheit.TabIndex = 1;
            this.rdbCelciusFahrenheit.TabStop = true;
            this.rdbCelciusFahrenheit.Text = "Celcius a Fahrenheit";
            this.rdbCelciusFahrenheit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione tipo de conversión";
            // 
            // btnConvertir
            // 
            this.btnConvertir.AutoSize = true;
            this.btnConvertir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(343, 299);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(123, 37);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 41);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "6. Conversor de temperatura";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 350);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(776, 91);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Esperando operación...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbFahrenheitCelcius
            // 
            this.rdbFahrenheitCelcius.AutoSize = true;
            this.rdbFahrenheitCelcius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFahrenheitCelcius.Location = new System.Drawing.Point(430, 132);
            this.rdbFahrenheitCelcius.Name = "rdbFahrenheitCelcius";
            this.rdbFahrenheitCelcius.Size = new System.Drawing.Size(170, 25);
            this.rdbFahrenheitCelcius.TabIndex = 11;
            this.rdbFahrenheitCelcius.TabStop = true;
            this.rdbFahrenheitCelcius.Text = "Fahrenheit a Celcius ";
            this.rdbFahrenheitCelcius.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese un valor de temperatura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ejerciciosGuia4WindowsForms.Properties.Resources._3279337;
            this.pictureBox1.Location = new System.Drawing.Point(712, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ejercicio6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbFahrenheitCelcius);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbCelciusFahrenheit);
            this.Controls.Add(this.txtTemperatura);
            this.Name = "Ejercicio6Form";
            this.Text = "6. Conversor de temperatura";
            this.Load += new System.EventHandler(this.Ejercicio6Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.RadioButton rdbCelciusFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rdbFahrenheitCelcius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}