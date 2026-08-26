namespace Derick
{
    partial class FrmMiPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiPerfil));
            pbFoto = new PictureBox();
            panel1 = new Panel();
            label27 = new Label();
            btnCambiarFoto = new Button();
            label1 = new Label();
            lblMiPerfil = new Label();
            panel2 = new Panel();
            txtfechan = new TextBox();
            txtdireccion = new TextBox();
            txtcorreo = new TextBox();
            txttelefono = new TextBox();
            txtgenero = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtcedula = new TextBox();
            txtcodigo = new TextBox();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            btnEditInf = new Button();
            txttelemerg = new TextBox();
            txtcontacemer = new TextBox();
            label25 = new Label();
            label26 = new Label();
            label24 = new Label();
            panel3 = new Panel();
            txtestado = new TextBox();
            txttipocon = new TextBox();
            txtfechai = new TextBox();
            txtdep = new TextBox();
            txtcargo = new TextBox();
            label6 = new Label();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel4 = new Panel();
            btnAcContra = new Button();
            txtconfcont = new TextBox();
            txtcambcontr = new TextBox();
            txtcontraa = new TextBox();
            txtrol = new TextBox();
            txtusuario = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label22 = new Label();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.Cursor = Cursors.Hand;
            pbFoto.Image = (Image)resources.GetObject("pbFoto.Image");
            pbFoto.Location = new Point(16, 10);
            pbFoto.Margin = new Padding(3, 2, 3, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(81, 73);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 43;
            pbFoto.TabStop = false;
            pbFoto.Click += pbFoto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label27);
            panel1.Controls.Add(btnCambiarFoto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMiPerfil);
            panel1.Controls.Add(pbFoto);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 100);
            panel1.TabIndex = 44;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Cursor = Cursors.Hand;
            label27.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(952, 0);
            label27.Name = "label27";
            label27.Size = new Size(24, 25);
            label27.TabIndex = 46;
            label27.Text = "X";
            label27.Click += label27_Click;
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.Cursor = Cursors.Hand;
            btnCambiarFoto.Location = new Point(103, 61);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(110, 23);
            btnCambiarFoto.TabIndex = 0;
            btnCambiarFoto.Text = "Cambiar Foto";
            btnCambiarFoto.UseVisualStyleBackColor = true;
            btnCambiarFoto.Click += btnCambiarFoto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 38);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 45;
            label1.Text = "Consulta tu información personal y  de tu cuenta";
            // 
            // lblMiPerfil
            // 
            lblMiPerfil.AutoSize = true;
            lblMiPerfil.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblMiPerfil.Location = new Point(103, 8);
            lblMiPerfil.Name = "lblMiPerfil";
            lblMiPerfil.Size = new Size(97, 30);
            lblMiPerfil.TabIndex = 44;
            lblMiPerfil.Text = "Mi Perfil";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtfechan);
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(txtcorreo);
            panel2.Controls.Add(txttelefono);
            panel2.Controls.Add(txtgenero);
            panel2.Controls.Add(txtapellido);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(txtcedula);
            panel2.Controls.Add(txtcodigo);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 233);
            panel2.TabIndex = 45;
            // 
            // txtfechan
            // 
            txtfechan.Location = new Point(140, 158);
            txtfechan.Name = "txtfechan";
            txtfechan.ReadOnly = true;
            txtfechan.Size = new Size(148, 23);
            txtfechan.TabIndex = 20;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(381, 129);
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(203, 52);
            txtdireccion.TabIndex = 19;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(373, 100);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(213, 23);
            txtcorreo.TabIndex = 18;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(373, 72);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(100, 23);
            txttelefono.TabIndex = 17;
            // 
            // txtgenero
            // 
            txtgenero.Location = new Point(373, 45);
            txtgenero.Name = "txtgenero";
            txtgenero.ReadOnly = true;
            txtgenero.Size = new Size(100, 23);
            txtgenero.TabIndex = 16;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(82, 130);
            txtapellido.Name = "txtapellido";
            txtapellido.ReadOnly = true;
            txtapellido.Size = new Size(206, 23);
            txtapellido.TabIndex = 15;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(82, 100);
            txtnombre.Name = "txtnombre";
            txtnombre.ReadOnly = true;
            txtnombre.Size = new Size(206, 23);
            txtnombre.TabIndex = 14;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(72, 72);
            txtcedula.Name = "txtcedula";
            txtcedula.ReadOnly = true;
            txtcedula.Size = new Size(100, 23);
            txtcedula.TabIndex = 13;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(72, 45);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 12;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(219, 190);
            button1.Name = "button1";
            button1.Size = new Size(127, 31);
            button1.TabIndex = 11;
            button1.Text = "Editar Información";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 75);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 10;
            label12.Text = "Cédula:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(319, 75);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 9;
            label11.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(319, 103);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 8;
            label10.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 133);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 7;
            label9.Text = "Dirección:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 166);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 6;
            label8.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 48);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 5;
            label7.Text = "Género:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 133);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 3;
            label5.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 103);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 48);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 9);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 0;
            label2.Text = "Información Personal";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnEditInf);
            panel5.Controls.Add(txttelemerg);
            panel5.Controls.Add(txtcontacemer);
            panel5.Controls.Add(label25);
            panel5.Controls.Add(label26);
            panel5.Controls.Add(label24);
            panel5.Location = new Point(619, 376);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 164);
            panel5.TabIndex = 48;
            // 
            // btnEditInf
            // 
            btnEditInf.Cursor = Cursors.Hand;
            btnEditInf.Location = new Point(133, 106);
            btnEditInf.Name = "btnEditInf";
            btnEditInf.Size = new Size(122, 31);
            btnEditInf.TabIndex = 22;
            btnEditInf.Text = "Editar Información";
            btnEditInf.UseVisualStyleBackColor = true;
            btnEditInf.Click += btnEditInf_Click;
            // 
            // txttelemerg
            // 
            txttelemerg.Location = new Point(79, 75);
            txttelemerg.MaxLength = 10;
            txttelemerg.Name = "txttelemerg";
            txttelemerg.Size = new Size(120, 23);
            txttelemerg.TabIndex = 17;
            // 
            // txtcontacemer
            // 
            txtcontacemer.Location = new Point(163, 45);
            txtcontacemer.Name = "txtcontacemer";
            txtcontacemer.Size = new Size(178, 23);
            txtcontacemer.TabIndex = 16;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(17, 75);
            label25.Name = "label25";
            label25.Size = new Size(56, 15);
            label25.TabIndex = 15;
            label25.Text = "Teléfono:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(17, 48);
            label26.Name = "label26";
            label26.Size = new Size(140, 15);
            label26.TabIndex = 14;
            label26.Text = "Contacto de Emergencia:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(17, 17);
            label24.Name = "label24";
            label24.Size = new Size(196, 25);
            label24.TabIndex = 1;
            label24.Text = "Información Adicional";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtestado);
            panel3.Controls.Add(txttipocon);
            panel3.Controls.Add(txtfechai);
            panel3.Controls.Add(txtdep);
            panel3.Controls.Add(txtcargo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Location = new Point(618, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 233);
            panel3.TabIndex = 49;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(72, 158);
            txtestado.Name = "txtestado";
            txtestado.ReadOnly = true;
            txtestado.Size = new Size(148, 23);
            txtestado.TabIndex = 20;
            // 
            // txttipocon
            // 
            txttipocon.Location = new Point(122, 129);
            txttipocon.Name = "txttipocon";
            txttipocon.ReadOnly = true;
            txttipocon.Size = new Size(148, 23);
            txttipocon.TabIndex = 15;
            // 
            // txtfechai
            // 
            txtfechai.Location = new Point(122, 100);
            txtfechai.Name = "txtfechai";
            txtfechai.ReadOnly = true;
            txtfechai.Size = new Size(148, 23);
            txtfechai.TabIndex = 14;
            // 
            // txtdep
            // 
            txtdep.Location = new Point(109, 75);
            txtdep.Name = "txtdep";
            txtdep.ReadOnly = true;
            txtdep.Size = new Size(100, 23);
            txtdep.TabIndex = 13;
            // 
            // txtcargo
            // 
            txtcargo.Location = new Point(72, 45);
            txtcargo.Name = "txtcargo";
            txtcargo.ReadOnly = true;
            txtcargo.Size = new Size(100, 23);
            txtcargo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 75);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 10;
            label6.Text = "Departamento:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 161);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 6;
            label16.Text = "Estado:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 133);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 3;
            label18.Text = "Tipo de Contrato:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 103);
            label19.Name = "label19";
            label19.Size = new Size(99, 15);
            label19.TabIndex = 2;
            label19.Text = "Fecha de Ingreso:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 48);
            label20.Name = "label20";
            label20.Size = new Size(42, 15);
            label20.TabIndex = 1;
            label20.Text = "Cargo:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(14, 9);
            label21.Name = "label21";
            label21.Size = new Size(180, 25);
            label21.TabIndex = 0;
            label21.Text = "Información Laboral";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnAcContra);
            panel4.Controls.Add(txtconfcont);
            panel4.Controls.Add(txtcambcontr);
            panel4.Controls.Add(txtcontraa);
            panel4.Controls.Add(txtrol);
            panel4.Controls.Add(txtusuario);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label23);
            panel4.Location = new Point(12, 376);
            panel4.Name = "panel4";
            panel4.Size = new Size(599, 164);
            panel4.TabIndex = 50;
            // 
            // btnAcContra
            // 
            btnAcContra.Cursor = Cursors.Hand;
            btnAcContra.Location = new Point(391, 106);
            btnAcContra.Name = "btnAcContra";
            btnAcContra.Size = new Size(136, 31);
            btnAcContra.TabIndex = 21;
            btnAcContra.Text = "Actualizar Contraseña";
            btnAcContra.UseVisualStyleBackColor = true;
            btnAcContra.Click += btnAcContra_Click;
            // 
            // txtconfcont
            // 
            txtconfcont.Location = new Point(436, 72);
            txtconfcont.Name = "txtconfcont";
            txtconfcont.Size = new Size(148, 23);
            txtconfcont.TabIndex = 20;
            // 
            // txtcambcontr
            // 
            txtcambcontr.Location = new Point(436, 40);
            txtcambcontr.Name = "txtcambcontr";
            txtcambcontr.Size = new Size(148, 23);
            txtcambcontr.TabIndex = 15;
            // 
            // txtcontraa
            // 
            txtcontraa.Location = new Point(130, 103);
            txtcontraa.Name = "txtcontraa";
            txtcontraa.ReadOnly = true;
            txtcontraa.Size = new Size(148, 23);
            txtcontraa.TabIndex = 14;
            // 
            // txtrol
            // 
            txtrol.Location = new Point(72, 77);
            txtrol.Name = "txtrol";
            txtrol.ReadOnly = true;
            txtrol.Size = new Size(100, 23);
            txtrol.TabIndex = 13;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(72, 45);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 75);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 10;
            label13.Text = "Rol:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(305, 75);
            label14.Name = "label14";
            label14.Size = new Size(127, 15);
            label14.TabIndex = 6;
            label14.Text = "Confirmar Contraseña:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(305, 48);
            label15.Name = "label15";
            label15.Size = new Size(118, 15);
            label15.TabIndex = 3;
            label15.Text = "Cambiar Contraseña:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 106);
            label17.Name = "label17";
            label17.Size = new Size(107, 15);
            label17.TabIndex = 2;
            label17.Text = "Contraseña Actual:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(18, 48);
            label22.Name = "label22";
            label22.Size = new Size(50, 15);
            label22.TabIndex = 1;
            label22.Text = "Usuario:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(14, 9);
            label23.Name = "label23";
            label23.Size = new Size(168, 25);
            label23.TabIndex = 0;
            label23.Text = "Cuenta de Usuario";
            // 
            // FrmMiPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 562);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMiPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMiPerfil";
            Load += FrmMiPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFoto;
        private Panel panel1;
        private Label lblMiPerfil;
        private Label label1;
        private Panel panel2;
        private Button btnCambiarFoto;
        private Panel panel5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Button button1;
        private TextBox txtdireccion;
        private TextBox txtcorreo;
        private TextBox txttelefono;
        private TextBox txtgenero;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtcedula;
        private TextBox txtcodigo;
        private TextBox txtfechan;
        private Panel panel3;
        private TextBox txtestado;
        private TextBox txttipocon;
        private TextBox txtfechai;
        private TextBox txtdep;
        private TextBox txtcargo;
        private Label label6;
        private Label label16;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel4;
        private TextBox txtconfcont;
        private TextBox txtcambcontr;
        private TextBox txtcontraa;
        private TextBox txtrol;
        private TextBox txtusuario;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label22;
        private Label label23;
        private Button btnEditInf;
        private TextBox txttelemerg;
        private TextBox txtcontacemer;
        private Label label25;
        private Label label26;
        private Label label24;
        private Button btnAcContra;
        private Label label27;
    }
}