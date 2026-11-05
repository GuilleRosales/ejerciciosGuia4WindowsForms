namespace ejerciciosGuia4WindowsForms
{
    partial class Ejercicio3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3Form));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.lblTextoEjemplo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiarTitulo = new System.Windows.Forms.Button();
            this.btnCambiarTexto = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtNuevoTitulo = new System.Windows.Forms.TextBox();
            this.nudTamanoFuente = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "3. Cambio de apariencia";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.AutoSize = true;
            this.btnCambiarColor.BackColor = System.Drawing.Color.Crimson;
            this.btnCambiarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarColor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarColor.Location = new System.Drawing.Point(12, 173);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(156, 38);
            this.btnCambiarColor.TabIndex = 2;
            this.btnCambiarColor.Text = "Cambiar color ";
            this.btnCambiarColor.UseVisualStyleBackColor = false;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarTitulo_Click);
            // 
            // lblTextoEjemplo
            // 
            this.lblTextoEjemplo.Location = new System.Drawing.Point(4, 322);
            this.lblTextoEjemplo.Name = "lblTextoEjemplo";
            this.lblTextoEjemplo.Size = new System.Drawing.Size(796, 119);
            this.lblTextoEjemplo.TabIndex = 3;
            this.lblTextoEjemplo.Text = resources.GetString("lblTextoEjemplo.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click a un botón para cambiar un aspecto de la apariencia del formulario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto de ejemplo:";
            // 
            // btnCambiarTitulo
            // 
            this.btnCambiarTitulo.AutoSize = true;
            this.btnCambiarTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarTitulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTitulo.Location = new System.Drawing.Point(190, 173);
            this.btnCambiarTitulo.Name = "btnCambiarTitulo";
            this.btnCambiarTitulo.Size = new System.Drawing.Size(156, 38);
            this.btnCambiarTitulo.TabIndex = 6;
            this.btnCambiarTitulo.Text = "Cambiar título";
            this.btnCambiarTitulo.UseVisualStyleBackColor = false;
            this.btnCambiarTitulo.Click += new System.EventHandler(this.btnCambiarTitulo_Click_1);
            // 
            // btnCambiarTexto
            // 
            this.btnCambiarTexto.AutoSize = true;
            this.btnCambiarTexto.BackColor = System.Drawing.Color.SlateGray;
            this.btnCambiarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarTexto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTexto.Location = new System.Drawing.Point(363, 173);
            this.btnCambiarTexto.Name = "btnCambiarTexto";
            this.btnCambiarTexto.Size = new System.Drawing.Size(252, 38);
            this.btnCambiarTexto.TabIndex = 7;
            this.btnCambiarTexto.Text = "Cambiar tamaño de texto";
            this.btnCambiarTexto.UseVisualStyleBackColor = false;
            this.btnCambiarTexto.Click += new System.EventHandler(this.btnCambiarTexto_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AutoSize = true;
            this.btnRestaurar.BackColor = System.Drawing.Color.Lime;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(637, 173);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(156, 38);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // txtNuevoTitulo
            // 
            this.txtNuevoTitulo.Location = new System.Drawing.Point(216, 147);
            this.txtNuevoTitulo.Name = "txtNuevoTitulo";
            this.txtNuevoTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoTitulo.TabIndex = 9;
            // 
            // nudTamanoFuente
            // 
            this.nudTamanoFuente.Location = new System.Drawing.Point(433, 147);
            this.nudTamanoFuente.Name = "nudTamanoFuente";
            this.nudTamanoFuente.Size = new System.Drawing.Size(120, 20);
            this.nudTamanoFuente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color de fondo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Texto de título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor de fuente de texto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Restaurar valores";
            // 
            // Ejercicio3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTamanoFuente);
            this.Controls.Add(this.txtNuevoTitulo);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnCambiarTexto);
            this.Controls.Add(this.btnCambiarTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTextoEjemplo);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3Form";
            this.Load += new System.EventHandler(this.Ejercicio3Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.Label lblTextoEjemplo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiarTitulo;
        private System.Windows.Forms.Button btnCambiarTexto;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox txtNuevoTitulo;
        private System.Windows.Forms.NumericUpDown nudTamanoFuente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}