namespace Derick
{
    partial class FrmInfoEmple
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoEmple));
            pnlNuevoEmple = new Panel();
            lblSalirV = new Label();
            pnlImagen = new Panel();
            lblSeleccionarImag = new Label();
            btnQuitarImagen = new Button();
            imageList1 = new ImageList(components);
            pbxAgregarImagen = new PictureBox();
            lblImagenEmple = new Label();
            pbxImagenEmple = new PictureBox();
            btnAgregarImagen = new Button();
            panel2 = new Panel();
            cmbRol = new ComboBox();
            txtRol = new TextBox();
            label22 = new Label();
            txtContrasena = new TextBox();
            label21 = new Label();
            txtUsuario = new TextBox();
            label20 = new Label();
            label19 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblInformacionSuc = new Label();
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            pnlInfoLaboral = new Panel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtTeleEmergencia = new TextBox();
            txtEmerNombre = new TextBox();
            cmbEstado = new ComboBox();
            cmbTipoContrato = new ComboBox();
            txtSalario = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            cmbDepartamento = new ComboBox();
            cmbCargo = new ComboBox();
            lblTelEmergencia = new Label();
            lblEmergencia = new Label();
            lblInfoAdicional = new Label();
            lblEstado = new Label();
            lblTipoContrato = new Label();
            lblSalario = new Label();
            lblFechaIngreso = new Label();
            lblDepartamento = new Label();
            lblCargo = new Label();
            lblInfoLaboral = new Label();
            pnlInfoPersonal = new Panel();
            cmbDominioCorreo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblC3 = new Label();
            txtDirreccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            cmbGenero = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtCedula = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblGenero = new Label();
            lblFechaNacimiento = new Label();
            lblCedula = new Label();
            lblApellidos = new Label();
            lblNombres = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblInfoPeronal = new Label();
            pnlNuevoEmple.SuspendLayout();
            pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenEmple).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlInfoLaboral.SuspendLayout();
            pnlInfoPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevoEmple
            // 
            pnlNuevoEmple.BackColor = Color.White;
            pnlNuevoEmple.Controls.Add(lblSalirV);
            pnlNuevoEmple.Controls.Add(pnlImagen);
            pnlNuevoEmple.Controls.Add(panel2);
            pnlNuevoEmple.Controls.Add(panel1);
            pnlNuevoEmple.Controls.Add(btnCancelar);
            pnlNuevoEmple.Controls.Add(btnGuardar);
            pnlNuevoEmple.Controls.Add(pnlInfoLaboral);
            pnlNuevoEmple.Controls.Add(pnlInfoPersonal);
            pnlNuevoEmple.Dock = DockStyle.Fill;
            pnlNuevoEmple.Location = new Point(0, 0);
            pnlNuevoEmple.Name = "pnlNuevoEmple";
            pnlNuevoEmple.Size = new Size(1186, 700);
            pnlNuevoEmple.TabIndex = 1;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1155, 5);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(31, 29);
            lblSalirV.TabIndex = 45;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pnlImagen
            // 
            pnlImagen.BackColor = Color.White;
            pnlImagen.Controls.Add(lblSeleccionarImag);
            pnlImagen.Controls.Add(btnQuitarImagen);
            pnlImagen.Controls.Add(pbxAgregarImagen);
            pnlImagen.Controls.Add(lblImagenEmple);
            pnlImagen.Controls.Add(pbxImagenEmple);
            pnlImagen.Controls.Add(btnAgregarImagen);
            pnlImagen.Location = new Point(11, 96);
            pnlImagen.Margin = new Padding(3, 4, 3, 4);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(225, 304);
            pnlImagen.TabIndex = 17;
            // 
            // lblSeleccionarImag
            // 
            lblSeleccionarImag.AutoSize = true;
            lblSeleccionarImag.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSeleccionarImag.ForeColor = Color.Black;
            lblSeleccionarImag.Location = new Point(20, 148);
            lblSeleccionarImag.Name = "lblSeleccionarImag";
            lblSeleccionarImag.Size = new Size(189, 24);
            lblSeleccionarImag.TabIndex = 21;
            lblSeleccionarImag.Text = "Seleccione una imagen";
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.BackColor = Color.Transparent;
            btnQuitarImagen.Cursor = Cursors.Hand;
            btnQuitarImagen.Font = new Font("Calibri", 12F);
            btnQuitarImagen.ForeColor = Color.Black;
            btnQuitarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitarImagen.ImageKey = "Gemini_Generated_Image_bivu61bivu61bivu.jpg";
            btnQuitarImagen.ImageList = imageList1;
            btnQuitarImagen.Location = new Point(20, 248);
            btnQuitarImagen.Margin = new Padding(3, 4, 3, 4);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(178, 43);
            btnQuitarImagen.TabIndex = 20;
            btnQuitarImagen.Text = "Quitar imagen";
            btnQuitarImagen.UseVisualStyleBackColor = false;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Gemini_Generated_Image_bivu61bivu61bivu.jpg");
            imageList1.Images.SetKeyName(1, "Gemini_Generated_Image_t4ohqat4ohqat4oh.jpg");
            // 
            // pbxAgregarImagen
            // 
            pbxAgregarImagen.Image = (Image)resources.GetObject("pbxAgregarImagen.Image");
            pbxAgregarImagen.Location = new Point(54, 52);
            pbxAgregarImagen.Name = "pbxAgregarImagen";
            pbxAgregarImagen.Size = new Size(106, 93);
            pbxAgregarImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAgregarImagen.TabIndex = 19;
            pbxAgregarImagen.TabStop = false;
            // 
            // lblImagenEmple
            // 
            lblImagenEmple.AutoSize = true;
            lblImagenEmple.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImagenEmple.ForeColor = Color.DimGray;
            lblImagenEmple.Location = new Point(2, 2);
            lblImagenEmple.Name = "lblImagenEmple";
            lblImagenEmple.Size = new Size(236, 29);
            lblImagenEmple.TabIndex = 18;
            lblImagenEmple.Text = "Imagen del empleado:";
            // 
            // pbxImagenEmple
            // 
            pbxImagenEmple.BorderStyle = BorderStyle.Fixed3D;
            pbxImagenEmple.Location = new Point(13, 38);
            pbxImagenEmple.Margin = new Padding(3, 4, 3, 4);
            pbxImagenEmple.Name = "pbxImagenEmple";
            pbxImagenEmple.Size = new Size(196, 151);
            pbxImagenEmple.TabIndex = 16;
            pbxImagenEmple.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.BackColor = Color.LightGray;
            btnAgregarImagen.Cursor = Cursors.Hand;
            btnAgregarImagen.Font = new Font("Calibri", 12F);
            btnAgregarImagen.ForeColor = Color.Black;
            btnAgregarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarImagen.ImageIndex = 1;
            btnAgregarImagen.ImageList = imageList1;
            btnAgregarImagen.Location = new Point(20, 197);
            btnAgregarImagen.Margin = new Padding(3, 4, 3, 4);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(182, 43);
            btnAgregarImagen.TabIndex = 17;
            btnAgregarImagen.Text = "Seleccionar imagen";
            btnAgregarImagen.UseVisualStyleBackColor = false;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbRol);
            panel2.Controls.Add(txtRol);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Location = new Point(3, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 270);
            panel2.TabIndex = 16;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Vendedor" });
            cmbRol.Location = new Point(5, 203);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(211, 28);
            cmbRol.TabIndex = 54;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(5, 201);
            txtRol.MaxLength = 10;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(211, 27);
            txtRol.TabIndex = 22;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(5, 176);
            label22.Name = "label22";
            label22.Size = new Size(39, 20);
            label22.TabIndex = 21;
            label22.Text = "Rol:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(5, 133);
            txtContrasena.MaxLength = 10;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(211, 27);
            txtContrasena.TabIndex = 20;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(5, 104);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 19;
            label21.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(5, 71);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(211, 27);
            txtUsuario.TabIndex = 18;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(5, 47);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 13;
            label20.Text = "Usuario:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(-1, 12);
            label19.Name = "label19";
            label19.Size = new Size(238, 20);
            label19.TabIndex = 12;
            label19.Text = "Crear usuario y contraseña";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblInformacionSuc);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 83);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(98, 41);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 44;
            label1.Text = "Los campos * son obligatorios";
            // 
            // lblInformacionSuc
            // 
            lblInformacionSuc.AutoSize = true;
            lblInformacionSuc.BackColor = Color.White;
            lblInformacionSuc.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacionSuc.ForeColor = Color.FromArgb(0, 102, 255);
            lblInformacionSuc.Location = new Point(98, 7);
            lblInformacionSuc.Name = "lblInformacionSuc";
            lblInformacionSuc.Size = new Size(208, 33);
            lblInformacionSuc.TabIndex = 43;
            lblInformacionSuc.Text = "Nuevo empleado";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(250, 635);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(213, 53);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 102, 255);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(469, 635);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 53);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlInfoLaboral
            // 
            pnlInfoLaboral.Controls.Add(label18);
            pnlInfoLaboral.Controls.Add(label17);
            pnlInfoLaboral.Controls.Add(label16);
            pnlInfoLaboral.Controls.Add(label15);
            pnlInfoLaboral.Controls.Add(label14);
            pnlInfoLaboral.Controls.Add(label13);
            pnlInfoLaboral.Controls.Add(label12);
            pnlInfoLaboral.Controls.Add(label11);
            pnlInfoLaboral.Controls.Add(txtTeleEmergencia);
            pnlInfoLaboral.Controls.Add(txtEmerNombre);
            pnlInfoLaboral.Controls.Add(cmbEstado);
            pnlInfoLaboral.Controls.Add(cmbTipoContrato);
            pnlInfoLaboral.Controls.Add(txtSalario);
            pnlInfoLaboral.Controls.Add(dtpFechaIngreso);
            pnlInfoLaboral.Controls.Add(cmbDepartamento);
            pnlInfoLaboral.Controls.Add(cmbCargo);
            pnlInfoLaboral.Controls.Add(lblTelEmergencia);
            pnlInfoLaboral.Controls.Add(lblEmergencia);
            pnlInfoLaboral.Controls.Add(lblInfoAdicional);
            pnlInfoLaboral.Controls.Add(lblEstado);
            pnlInfoLaboral.Controls.Add(lblTipoContrato);
            pnlInfoLaboral.Controls.Add(lblSalario);
            pnlInfoLaboral.Controls.Add(lblFechaIngreso);
            pnlInfoLaboral.Controls.Add(lblDepartamento);
            pnlInfoLaboral.Controls.Add(lblCargo);
            pnlInfoLaboral.Controls.Add(lblInfoLaboral);
            pnlInfoLaboral.Location = new Point(694, 93);
            pnlInfoLaboral.Name = "pnlInfoLaboral";
            pnlInfoLaboral.Size = new Size(459, 579);
            pnlInfoLaboral.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(3, 457);
            label18.Name = "label18";
            label18.Size = new Size(21, 25);
            label18.TabIndex = 51;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(3, 414);
            label17.Name = "label17";
            label17.Size = new Size(21, 25);
            label17.TabIndex = 50;
            label17.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(3, 44);
            label16.Name = "label16";
            label16.Size = new Size(21, 25);
            label16.TabIndex = 49;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(3, 96);
            label15.Name = "label15";
            label15.Size = new Size(21, 25);
            label15.TabIndex = 48;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(3, 150);
            label14.Name = "label14";
            label14.Size = new Size(21, 25);
            label14.TabIndex = 47;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(3, 197);
            label13.Name = "label13";
            label13.Size = new Size(21, 25);
            label13.TabIndex = 46;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(3, 254);
            label12.Name = "label12";
            label12.Size = new Size(21, 25);
            label12.TabIndex = 45;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(3, 305);
            label11.Name = "label11";
            label11.Size = new Size(21, 25);
            label11.TabIndex = 44;
            label11.Text = "*";
            // 
            // txtTeleEmergencia
            // 
            txtTeleEmergencia.Location = new Point(227, 449);
            txtTeleEmergencia.MaxLength = 10;
            txtTeleEmergencia.Name = "txtTeleEmergencia";
            txtTeleEmergencia.Size = new Size(223, 27);
            txtTeleEmergencia.TabIndex = 24;
            // 
            // txtEmerNombre
            // 
            txtEmerNombre.Location = new Point(227, 399);
            txtEmerNombre.MaxLength = 50;
            txtEmerNombre.Name = "txtEmerNombre";
            txtEmerNombre.Size = new Size(223, 27);
            txtEmerNombre.TabIndex = 23;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(211, 301);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(239, 28);
            cmbEstado.TabIndex = 22;
            // 
            // cmbTipoContrato
            // 
            cmbTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoContrato.FormattingEnabled = true;
            cmbTipoContrato.Items.AddRange(new object[] { "Indefinido", "Temporal" });
            cmbTipoContrato.Location = new Point(211, 247);
            cmbTipoContrato.Name = "cmbTipoContrato";
            cmbTipoContrato.Size = new Size(239, 28);
            cmbTipoContrato.TabIndex = 21;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(211, 191);
            txtSalario.MaxLength = 10;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(239, 27);
            txtSalario.TabIndex = 20;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(211, 141);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(239, 27);
            dtpFechaIngreso.TabIndex = 19;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cmbDepartamento.Location = new Point(211, 83);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(239, 28);
            cmbDepartamento.TabIndex = 18;
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Gerente general", "Empleado" });
            cmbCargo.Location = new Point(211, 36);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(239, 28);
            cmbCargo.TabIndex = 17;
            // 
            // lblTelEmergencia
            // 
            lblTelEmergencia.AutoSize = true;
            lblTelEmergencia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelEmergencia.ForeColor = Color.DimGray;
            lblTelEmergencia.Location = new Point(30, 453);
            lblTelEmergencia.Name = "lblTelEmergencia";
            lblTelEmergencia.Size = new Size(184, 22);
            lblTelEmergencia.TabIndex = 11;
            lblTelEmergencia.Text = "Teléfono emergencia:";
            // 
            // lblEmergencia
            // 
            lblEmergencia.AutoSize = true;
            lblEmergencia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergencia.ForeColor = Color.DimGray;
            lblEmergencia.Location = new Point(27, 404);
            lblEmergencia.Name = "lblEmergencia";
            lblEmergencia.Size = new Size(187, 22);
            lblEmergencia.TabIndex = 10;
            lblEmergencia.Text = "Emergencia (nombre):";
            // 
            // lblInfoAdicional
            // 
            lblInfoAdicional.AutoSize = true;
            lblInfoAdicional.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoAdicional.Location = new Point(30, 352);
            lblInfoAdicional.Name = "lblInfoAdicional";
            lblInfoAdicional.Size = new Size(219, 25);
            lblInfoAdicional.TabIndex = 9;
            lblInfoAdicional.Text = "Información Adicional";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(30, 307);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 22);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoContrato.ForeColor = Color.DimGray;
            lblTipoContrato.Location = new Point(27, 253);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(146, 22);
            lblTipoContrato.TabIndex = 7;
            lblTipoContrato.Text = "Tipo de contrato:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.ForeColor = Color.DimGray;
            lblSalario.Location = new Point(27, 195);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(71, 22);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salario:";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaIngreso.ForeColor = Color.DimGray;
            lblFechaIngreso.Location = new Point(30, 148);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(154, 22);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.DimGray;
            lblDepartamento.Location = new Point(27, 96);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(128, 22);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.ForeColor = Color.DimGray;
            lblCargo.Location = new Point(27, 44);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(64, 22);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo:";
            // 
            // lblInfoLaboral
            // 
            lblInfoLaboral.AutoSize = true;
            lblInfoLaboral.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoLaboral.Location = new Point(27, 5);
            lblInfoLaboral.Name = "lblInfoLaboral";
            lblInfoLaboral.Size = new Size(195, 25);
            lblInfoLaboral.TabIndex = 2;
            lblInfoLaboral.Text = "Información laboral";
            // 
            // pnlInfoPersonal
            // 
            pnlInfoPersonal.Controls.Add(cmbDominioCorreo);
            pnlInfoPersonal.Controls.Add(label9);
            pnlInfoPersonal.Controls.Add(label8);
            pnlInfoPersonal.Controls.Add(label7);
            pnlInfoPersonal.Controls.Add(label6);
            pnlInfoPersonal.Controls.Add(label5);
            pnlInfoPersonal.Controls.Add(label4);
            pnlInfoPersonal.Controls.Add(label3);
            pnlInfoPersonal.Controls.Add(label2);
            pnlInfoPersonal.Controls.Add(lblC3);
            pnlInfoPersonal.Controls.Add(txtDirreccion);
            pnlInfoPersonal.Controls.Add(txtCorreo);
            pnlInfoPersonal.Controls.Add(txtTelefono);
            pnlInfoPersonal.Controls.Add(cmbGenero);
            pnlInfoPersonal.Controls.Add(dtpFechaNacimiento);
            pnlInfoPersonal.Controls.Add(txtCedula);
            pnlInfoPersonal.Controls.Add(txtApellidos);
            pnlInfoPersonal.Controls.Add(txtNombre);
            pnlInfoPersonal.Controls.Add(lblDireccion);
            pnlInfoPersonal.Controls.Add(lblCorreo);
            pnlInfoPersonal.Controls.Add(lblTelefono);
            pnlInfoPersonal.Controls.Add(lblGenero);
            pnlInfoPersonal.Controls.Add(lblFechaNacimiento);
            pnlInfoPersonal.Controls.Add(lblCedula);
            pnlInfoPersonal.Controls.Add(lblApellidos);
            pnlInfoPersonal.Controls.Add(lblNombres);
            pnlInfoPersonal.Controls.Add(txtCodigo);
            pnlInfoPersonal.Controls.Add(lblCodigo);
            pnlInfoPersonal.Controls.Add(lblInfoPeronal);
            pnlInfoPersonal.Location = new Point(247, 93);
            pnlInfoPersonal.Name = "pnlInfoPersonal";
            pnlInfoPersonal.Size = new Size(441, 523);
            pnlInfoPersonal.TabIndex = 11;
            // 
            // cmbDominioCorreo
            // 
            cmbDominioCorreo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDominioCorreo.FormattingEnabled = true;
            cmbDominioCorreo.Items.AddRange(new object[] { "@gmail.com", "@hotmail.com", "@outlook.com" });
            cmbDominioCorreo.Location = new Point(326, 403);
            cmbDominioCorreo.Name = "cmbDominioCorreo";
            cmbDominioCorreo.Size = new Size(109, 28);
            cmbDominioCorreo.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(3, 457);
            label9.Name = "label9";
            label9.Size = new Size(21, 25);
            label9.TabIndex = 51;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(3, 405);
            label8.Name = "label8";
            label8.Size = new Size(21, 25);
            label8.TabIndex = 50;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(3, 355);
            label7.Name = "label7";
            label7.Size = new Size(21, 25);
            label7.TabIndex = 49;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(3, 307);
            label6.Name = "label6";
            label6.Size = new Size(21, 25);
            label6.TabIndex = 48;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(3, 251);
            label5.Name = "label5";
            label5.Size = new Size(21, 25);
            label5.TabIndex = 47;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(3, 195);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 46;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(3, 145);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 45;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 44;
            label2.Text = "*";
            // 
            // lblC3
            // 
            lblC3.AutoSize = true;
            lblC3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC3.ForeColor = Color.Red;
            lblC3.Location = new Point(3, 41);
            lblC3.Name = "lblC3";
            lblC3.Size = new Size(21, 25);
            lblC3.TabIndex = 43;
            lblC3.Text = "*";
            // 
            // txtDirreccion
            // 
            txtDirreccion.Location = new Point(197, 452);
            txtDirreccion.MaxLength = 200;
            txtDirreccion.Multiline = true;
            txtDirreccion.Name = "txtDirreccion";
            txtDirreccion.Size = new Size(230, 49);
            txtDirreccion.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(197, 403);
            txtCorreo.MaxLength = 18;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(123, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(199, 353);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(228, 27);
            txtTelefono.TabIndex = 17;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(197, 304);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(230, 28);
            cmbGenero.TabIndex = 16;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(199, 251);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 27);
            dtpFechaNacimiento.TabIndex = 15;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(199, 195);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(228, 27);
            txtCedula.TabIndex = 14;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(199, 144);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(228, 27);
            txtApellidos.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 91);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 12;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.DimGray;
            lblDireccion.Location = new Point(25, 454);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(90, 22);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.DimGray;
            lblCorreo.Location = new Point(25, 403);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 22);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.DimGray;
            lblTelefono.Location = new Point(26, 352);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 22);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.ForeColor = Color.DimGray;
            lblGenero.Location = new Point(26, 305);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(75, 22);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Género:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.ForeColor = Color.DimGray;
            lblFechaNacimiento.Location = new Point(25, 254);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(181, 22);
            lblFechaNacimiento.TabIndex = 7;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.ForeColor = Color.DimGray;
            lblCedula.Location = new Point(25, 195);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(72, 22);
            lblCedula.TabIndex = 6;
            lblCedula.Text = "Cédula:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.ForeColor = Color.DimGray;
            lblApellidos.Location = new Point(25, 144);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(88, 22);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombres.ForeColor = Color.DimGray;
            lblNombres.Location = new Point(26, 95);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(87, 22);
            lblNombres.TabIndex = 4;
            lblNombres.Text = "Nombres:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(199, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(228, 27);
            txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.DimGray;
            lblCodigo.Location = new Point(26, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 22);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "ID / Código:";
            // 
            // lblInfoPeronal
            // 
            lblInfoPeronal.AutoSize = true;
            lblInfoPeronal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoPeronal.Location = new Point(25, 5);
            lblInfoPeronal.Name = "lblInfoPeronal";
            lblInfoPeronal.Size = new Size(213, 25);
            lblInfoPeronal.TabIndex = 1;
            lblInfoPeronal.Text = "Información personal";
            // 
            // FrmInfoEmple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 700);
            Controls.Add(pnlNuevoEmple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInfoEmple";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInfoEmple";
            Load += FrmInfoEmple_Load;
            pnlNuevoEmple.ResumeLayout(false);
            pnlNuevoEmple.PerformLayout();
            pnlImagen.ResumeLayout(false);
            pnlImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenEmple).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlInfoLaboral.ResumeLayout(false);
            pnlInfoLaboral.PerformLayout();
            pnlInfoPersonal.ResumeLayout(false);
            pnlInfoPersonal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevoEmple;
        private Button btnCancelar;
        private Button btnGuardar;
        private Panel pnlInfoLaboral;
        private TextBox txtTeleEmergencia;
        private TextBox txtEmerNombre;
        private ComboBox cmbEstado;
        private ComboBox cmbTipoContrato;
        private TextBox txtSalario;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox cmbDepartamento;
        private ComboBox cmbCargo;
        private Label lblTelEmergencia;
        private Label lblEmergencia;
        private Label lblInfoAdicional;
        private Label lblEstado;
        private Label lblTipoContrato;
        private Label lblSalario;
        private Label lblFechaIngreso;
        private Label lblDepartamento;
        private Label lblCargo;
        private Label lblInfoLaboral;
        private Panel pnlInfoPersonal;
        private TextBox txtDirreccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private ComboBox cmbGenero;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtCedula;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblGenero;
        private Label lblFechaNacimiento;
        private Label lblCedula;
        private Label lblApellidos;
        private Label lblNombres;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblInfoPeronal;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblC3;
        private Label label15;
        private Label label18;
        private Label label17;
        private Label label16;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txtUsuario;
        private Label label20;
        private Label label19;
        private TextBox txtContrasena;
        private Label label21;
        private Label lblInformacionSuc;
        private Label label1;
        private Panel pnlImagen;
        private Label lblSeleccionarImag;
        private Button btnQuitarImagen;
        private PictureBox pbxAgregarImagen;
        private Label lblImagenEmple;
        private PictureBox pbxImagenEmple;
        private Button btnAgregarImagen;
        private Label lblSalirV;
        private TextBox txtRol;
        private Label label22;
        private ComboBox cmbRol;
        private ComboBox cmbDominioCorreo;
        private ImageList imageList1;
    }
}