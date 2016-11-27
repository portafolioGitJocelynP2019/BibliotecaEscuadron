namespace LoginForm
{
    partial class AdminUsuarioForm
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
            this.lklSalir = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cboTipoPerfil = new System.Windows.Forms.ComboBox();
            this.cboPiloto = new System.Windows.Forms.ComboBox();
            this.dtFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lklSalir
            // 
            this.lklSalir.AutoSize = true;
            this.lklSalir.Location = new System.Drawing.Point(-54, 202);
            this.lklSalir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklSalir.Name = "lklSalir";
            this.lklSalir.Size = new System.Drawing.Size(40, 20);
            this.lklSalir.TabIndex = 13;
            this.lklSalir.TabStop = true;
            this.lklSalir.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(423, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro de Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1228, 235);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.cboTipoPerfil);
            this.gpbDatos.Controls.Add(this.cboPiloto);
            this.gpbDatos.Controls.Add(this.dtFechNac);
            this.gpbDatos.Controls.Add(this.txtEmail);
            this.gpbDatos.Controls.Add(this.txtPassword);
            this.gpbDatos.Controls.Add(this.txtUserName);
            this.gpbDatos.Controls.Add(this.lblFechNac);
            this.gpbDatos.Controls.Add(this.lblTipoPerfil);
            this.gpbDatos.Controls.Add(this.lblPiloto);
            this.gpbDatos.Controls.Add(this.lblEmail);
            this.gpbDatos.Controls.Add(this.lblPassword);
            this.gpbDatos.Controls.Add(this.lblUser);
            this.gpbDatos.Controls.Add(this.txtRut);
            this.gpbDatos.Controls.Add(this.txtApellido);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.lblRut);
            this.gpbDatos.Controls.Add(this.lblApellido);
            this.gpbDatos.Controls.Add(this.lblNombre);
            this.gpbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(64, 260);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDatos.Size = new System.Drawing.Size(1204, 263);
            this.gpbDatos.TabIndex = 15;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "DATOS";
            // 
            // cboTipoPerfil
            // 
            this.cboTipoPerfil.FormattingEnabled = true;
            this.cboTipoPerfil.Location = new System.Drawing.Point(597, 220);
            this.cboTipoPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoPerfil.Name = "cboTipoPerfil";
            this.cboTipoPerfil.Size = new System.Drawing.Size(258, 28);
            this.cboTipoPerfil.TabIndex = 17;
            // 
            // cboPiloto
            // 
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.Location = new System.Drawing.Point(194, 220);
            this.cboPiloto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(258, 28);
            this.cboPiloto.TabIndex = 16;
            // 
            // dtFechNac
            // 
            this.dtFechNac.Location = new System.Drawing.Point(876, 103);
            this.dtFechNac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFechNac.Name = "dtFechNac";
            this.dtFechNac.Size = new System.Drawing.Size(298, 26);
            this.dtFechNac.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(597, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(597, 102);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 26);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(597, 42);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 26);
            this.txtUserName.TabIndex = 12;
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.Enabled = false;
            this.lblFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechNac.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechNac.Location = new System.Drawing.Point(910, 42);
            this.lblFechNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(185, 25);
            this.lblFechNac.TabIndex = 11;
            this.lblFechNac.Text = "Fecha Nacimiento";
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipoPerfil.Location = new System.Drawing.Point(476, 222);
            this.lblTipoPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(110, 25);
            this.lblTipoPerfil.TabIndex = 10;
            this.lblTipoPerfil.Text = "Tipo Perfil";
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiloto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPiloto.Location = new System.Drawing.Point(27, 225);
            this.lblPiloto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(160, 25);
            this.lblPiloto.TabIndex = 9;
            this.lblPiloto.Text = "Piloto asignado";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(477, 163);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Location = new System.Drawing.Point(477, 102);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUser.Location = new System.Drawing.Point(476, 42);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(113, 25);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "UserName";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(194, 166);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(258, 26);
            this.txtRut.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(194, 103);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(258, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(194, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRut.Location = new System.Drawing.Point(28, 166);
            this.lblRut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(44, 25);
            this.lblRut.TabIndex = 2;
            this.lblRut.Text = "Rut";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblApellido.Location = new System.Drawing.Point(26, 105);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(90, 25);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Location = new System.Drawing.Point(26, 40);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(64, 532);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1204, 140);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::LoginForm.Properties.Resources.MenuEliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEliminar.Location = new System.Drawing.Point(838, 42);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(253, 50);
            this.btnEliminar.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::LoginForm.Properties.Resources.MenuModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificar.Location = new System.Drawing.Point(482, 46);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(253, 50);
            this.btnModificar.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::LoginForm.Properties.Resources.MenuRegistrar;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnRegistrar.Location = new System.Drawing.Point(128, 46);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(253, 50);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginForm.Properties.Resources.LogoIntra;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 191);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LoginForm.Properties.Resources.front;
            this.pictureBox2.Location = new System.Drawing.Point(172, -6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1155, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // AdminUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1324, 685);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lklSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(220, 193);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion de Usuarios";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lklSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.ComboBox cboTipoPerfil;
        private System.Windows.Forms.ComboBox cboPiloto;
        private System.Windows.Forms.DateTimePicker dtFechNac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel btnRegistrar;
        private System.Windows.Forms.Panel btnModificar;
        private System.Windows.Forms.Panel btnEliminar;
    }
}