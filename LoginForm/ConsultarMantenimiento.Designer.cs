namespace LoginForm
{
    partial class ConsultarMantenimiento
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdTipoComp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdPadreComp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreComponente = new System.Windows.Forms.TextBox();
            this.txtIdComponente = new System.Windows.Forms.TextBox();
            this.txtCantHorasComp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDGAC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtFechaFabr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoMant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAeronave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaMant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMantencion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LoginForm.Properties.Resources.front;
            this.pictureBox2.Location = new System.Drawing.Point(176, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1155, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginForm.Properties.Resources.LogoIntra;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 191);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(439, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consulta Mantenimiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.btnbuscar);
            this.gpbDatos.Controls.Add(this.linkLabel1);
            this.gpbDatos.Controls.Add(this.txtIdentificador);
            this.gpbDatos.Controls.Add(this.lblRut);
            this.gpbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(63, 256);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDatos.Size = new System.Drawing.Size(1095, 110);
            this.gpbDatos.TabIndex = 16;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Buscar identificador de mantenimiento";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(754, 48);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(93, 36);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1020, 24);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(489, 53);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentificador.MaxLength = 7;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(258, 26);
            this.txtIdentificador.TabIndex = 5;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRut.Location = new System.Drawing.Point(332, 53);
            this.lblRut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(130, 25);
            this.lblRut.TabIndex = 2;
            this.lblRut.Text = "Identificador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdTipoComp);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtIdPadreComp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNombreComponente);
            this.groupBox1.Controls.Add(this.txtIdComponente);
            this.groupBox1.Controls.Add(this.txtCantHorasComp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFechaVencimiento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDGAC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtFechaFabr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTipoMant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdAeronave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFechaMant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdMantencion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 380);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1095, 455);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtIdTipoComp
            // 
            this.txtIdTipoComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTipoComp.Location = new System.Drawing.Point(851, 351);
            this.txtIdTipoComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdTipoComp.Name = "txtIdTipoComp";
            this.txtIdTipoComp.ReadOnly = true;
            this.txtIdTipoComp.Size = new System.Drawing.Size(217, 30);
            this.txtIdTipoComp.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(635, 351);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Id Tipo Componente";
            // 
            // txtIdPadreComp
            // 
            this.txtIdPadreComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPadreComp.Location = new System.Drawing.Point(851, 305);
            this.txtIdPadreComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPadreComp.Name = "txtIdPadreComp";
            this.txtIdPadreComp.ReadOnly = true;
            this.txtIdPadreComp.Size = new System.Drawing.Size(217, 30);
            this.txtIdPadreComp.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(616, 305);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Id Padre Componente";
            // 
            // txtNombreComponente
            // 
            this.txtNombreComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComponente.Location = new System.Drawing.Point(851, 197);
            this.txtNombreComponente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreComponente.Name = "txtNombreComponente";
            this.txtNombreComponente.ReadOnly = true;
            this.txtNombreComponente.Size = new System.Drawing.Size(217, 30);
            this.txtNombreComponente.TabIndex = 25;
            // 
            // txtIdComponente
            // 
            this.txtIdComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdComponente.Location = new System.Drawing.Point(851, 142);
            this.txtIdComponente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdComponente.Name = "txtIdComponente";
            this.txtIdComponente.ReadOnly = true;
            this.txtIdComponente.Size = new System.Drawing.Size(217, 30);
            this.txtIdComponente.TabIndex = 24;
            // 
            // txtCantHorasComp
            // 
            this.txtCantHorasComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantHorasComp.Location = new System.Drawing.Point(851, 252);
            this.txtCantHorasComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantHorasComp.Name = "txtCantHorasComp";
            this.txtCantHorasComp.ReadOnly = true;
            this.txtCantHorasComp.Size = new System.Drawing.Size(217, 30);
            this.txtCantHorasComp.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(627, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nombre Componente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(684, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id Componente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(704, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rut Mecanico";
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(851, 92);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRut.Name = "txtRut";
            this.txtRut.ReadOnly = true;
            this.txtRut.Size = new System.Drawing.Size(217, 30);
            this.txtRut.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(591, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cant. Horas Componente";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(851, 38);
            this.txtFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.ReadOnly = true;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(217, 30);
            this.txtFechaVencimiento.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(641, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha Vencimiento";
            // 
            // txtDGAC
            // 
            this.txtDGAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGAC.Location = new System.Drawing.Point(299, 356);
            this.txtDGAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDGAC.Name = "txtDGAC";
            this.txtDGAC.ReadOnly = true;
            this.txtDGAC.Size = new System.Drawing.Size(236, 30);
            this.txtDGAC.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(151, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha DGAC";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(299, 310);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(236, 30);
            this.txtMatricula.TabIndex = 13;
            // 
            // txtFechaFabr
            // 
            this.txtFechaFabr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFabr.Location = new System.Drawing.Point(299, 257);
            this.txtFechaFabr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaFabr.Name = "txtFechaFabr";
            this.txtFechaFabr.ReadOnly = true;
            this.txtFechaFabr.Size = new System.Drawing.Size(236, 30);
            this.txtFechaFabr.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(191, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(111, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Fabricante";
            // 
            // txtTipoMant
            // 
            this.txtTipoMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMant.Location = new System.Drawing.Point(299, 202);
            this.txtTipoMant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoMant.Name = "txtTipoMant";
            this.txtTipoMant.ReadOnly = true;
            this.txtTipoMant.Size = new System.Drawing.Size(236, 30);
            this.txtTipoMant.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(89, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Mantenimiento";
            // 
            // txtIdAeronave
            // 
            this.txtIdAeronave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAeronave.Location = new System.Drawing.Point(299, 97);
            this.txtIdAeronave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdAeronave.Name = "txtIdAeronave";
            this.txtIdAeronave.ReadOnly = true;
            this.txtIdAeronave.Size = new System.Drawing.Size(236, 30);
            this.txtIdAeronave.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(113, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "F. Mantenimiento";
            // 
            // txtFechaMant
            // 
            this.txtFechaMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaMant.Location = new System.Drawing.Point(299, 147);
            this.txtFechaMant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaMant.Name = "txtFechaMant";
            this.txtFechaMant.ReadOnly = true;
            this.txtFechaMant.Size = new System.Drawing.Size(236, 30);
            this.txtFechaMant.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(162, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Aeronave";
            // 
            // txtIdMantencion
            // 
            this.txtIdMantencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMantencion.Location = new System.Drawing.Point(299, 42);
            this.txtIdMantencion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdMantencion.Name = "txtIdMantencion";
            this.txtIdMantencion.ReadOnly = true;
            this.txtIdMantencion.Size = new System.Drawing.Size(236, 30);
            this.txtIdMantencion.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Location = new System.Drawing.Point(143, 46);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Id Mantencion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(293, 761);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 18;
            // 
            // ConsultarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1191, 871);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultarMantenimiento";
            this.Text = "ConsultarMantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdMantencion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreComponente;
        private System.Windows.Forms.TextBox txtIdComponente;
        private System.Windows.Forms.TextBox txtCantHorasComp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDGAC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtFechaFabr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoMant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAeronave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaMant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtIdPadreComp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdTipoComp;
        private System.Windows.Forms.Label label14;
    }
}