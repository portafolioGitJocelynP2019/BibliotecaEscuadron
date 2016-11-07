namespace LoginForm
{
    partial class RegistroPlanDeVuelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEtd = new System.Windows.Forms.TextBox();
            this.txtQrf = new System.Windows.Forms.TextBox();
            this.txtTipoAeronave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVelocidadCrucero = new System.Windows.Forms.TextBox();
            this.txtReglasDeVuelo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtReglasDeVuelo);
            this.panel1.Controls.Add(this.txtVelocidadCrucero);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTipoAeronave);
            this.panel1.Controls.Add(this.txtQrf);
            this.panel1.Controls.Add(this.txtEtd);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(30, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 331);
            this.panel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEtd
            // 
            this.txtEtd.Location = new System.Drawing.Point(213, 82);
            this.txtEtd.Name = "txtEtd";
            this.txtEtd.Size = new System.Drawing.Size(259, 20);
            this.txtEtd.TabIndex = 1;
            this.txtEtd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtQrf
            // 
            this.txtQrf.Location = new System.Drawing.Point(213, 118);
            this.txtQrf.Name = "txtQrf";
            this.txtQrf.Size = new System.Drawing.Size(259, 20);
            this.txtQrf.TabIndex = 2;
            // 
            // txtTipoAeronave
            // 
            this.txtTipoAeronave.Location = new System.Drawing.Point(213, 157);
            this.txtTipoAeronave.Name = "txtTipoAeronave";
            this.txtTipoAeronave.Size = new System.Drawing.Size(259, 20);
            this.txtTipoAeronave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ETD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "QRF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo aeronave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Velocidad crucero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reglas de vuelo";
            // 
            // txtVelocidadCrucero
            // 
            this.txtVelocidadCrucero.Location = new System.Drawing.Point(213, 191);
            this.txtVelocidadCrucero.Name = "txtVelocidadCrucero";
            this.txtVelocidadCrucero.Size = new System.Drawing.Size(259, 20);
            this.txtVelocidadCrucero.TabIndex = 10;
            // 
            // txtReglasDeVuelo
            // 
            this.txtReglasDeVuelo.Location = new System.Drawing.Point(213, 227);
            this.txtReglasDeVuelo.Name = "txtReglasDeVuelo";
            this.txtReglasDeVuelo.Size = new System.Drawing.Size(259, 20);
            this.txtReglasDeVuelo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ingresar plan de vuelo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroPlanDeVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 458);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroPlanDeVuelo";
            this.Text = "RegistroPlanDeVuelo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReglasDeVuelo;
        private System.Windows.Forms.TextBox txtVelocidadCrucero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoAeronave;
        private System.Windows.Forms.TextBox txtQrf;
        private System.Windows.Forms.TextBox txtEtd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}