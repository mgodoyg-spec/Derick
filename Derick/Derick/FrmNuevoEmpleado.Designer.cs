namespace Derick
{
    partial class FrmNuevoEmpleado
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
            pnlNuevoEmple = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            pnlInfoLaboral = new Panel();
            txtObservaciones = new TextBox();
            txtTeleEmergencia = new TextBox();
            txtEmerNombre = new TextBox();
            cmbEstado = new ComboBox();
            cmbTipoContrato = new ComboBox();
            txtSalario = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            cmbDepartamento = new ComboBox();
            cmbCargo = new ComboBox();
            lblObservaciones = new Label();
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
            pnlFoto = new Panel();
            btnQuitarImagen = new Button();
            btnSeleccionarImagen = new Button();
            picfoto = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            ofdImagen = new OpenFileDialog();
            pnlNuevoEmple.SuspendLayout();
            pnlInfoLaboral.SuspendLayout();
            pnlInfoPersonal.SuspendLayout();
            pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picfoto).BeginInit();
            SuspendLayout();
            // 
            // pnlNuevoEmple
            // 
            pnlNuevoEmple.BackColor = Color.White;
            pnlNuevoEmple.Controls.Add(btnCancelar);
            pnlNuevoEmple.Controls.Add(btnGuardar);
            pnlNuevoEmple.Controls.Add(pnlInfoLaboral);
            pnlNuevoEmple.Controls.Add(pnlInfoPersonal);
            pnlNuevoEmple.Controls.Add(pnlFoto);
            pnlNuevoEmple.Controls.Add(panel3);
            pnlNuevoEmple.Controls.Add(label1);
            pnlNuevoEmple.Dock = DockStyle.Fill;
            pnlNuevoEmple.Location = new Point(0, 0);
            pnlNuevoEmple.Name = "pnlNuevoEmple";
            pnlNuevoEmple.Size = new Size(1353, 821);
            pnlNuevoEmple.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(803, 660);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(213, 53);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Purple;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1033, 660);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 53);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlInfoLaboral
            // 
            pnlInfoLaboral.Controls.Add(txtObservaciones);
            pnlInfoLaboral.Controls.Add(txtTeleEmergencia);
            pnlInfoLaboral.Controls.Add(txtEmerNombre);
            pnlInfoLaboral.Controls.Add(cmbEstado);
            pnlInfoLaboral.Controls.Add(cmbTipoContrato);
            pnlInfoLaboral.Controls.Add(txtSalario);
            pnlInfoLaboral.Controls.Add(dtpFechaIngreso);
            pnlInfoLaboral.Controls.Add(cmbDepartamento);
            pnlInfoLaboral.Controls.Add(cmbCargo);
            pnlInfoLaboral.Controls.Add(lblObservaciones);
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
            pnlInfoLaboral.Location = new Point(773, 61);
            pnlInfoLaboral.Name = "pnlInfoLaboral";
            pnlInfoLaboral.Size = new Size(473, 579);
            pnlInfoLaboral.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(211, 507);
            txtObservaciones.MaxLength = 200;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(250, 50);
            txtObservaciones.TabIndex = 25;
            // 
            // txtTeleEmergencia
            // 
            txtTeleEmergencia.Location = new Point(211, 449);
            txtTeleEmergencia.MaxLength = 10;
            txtTeleEmergencia.Name = "txtTeleEmergencia";
            txtTeleEmergencia.Size = new Size(250, 27);
            txtTeleEmergencia.TabIndex = 24;
            txtTeleEmergencia.KeyPress += txtTeleEmergencia_KeyPress;
            // 
            // txtEmerNombre
            // 
            txtEmerNombre.Location = new Point(211, 399);
            txtEmerNombre.MaxLength = 50;
            txtEmerNombre.Name = "txtEmerNombre";
            txtEmerNombre.Size = new Size(250, 27);
            txtEmerNombre.TabIndex = 23;
            txtEmerNombre.KeyPress += txtEmerNombre_KeyPress;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(211, 301);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(250, 28);
            cmbEstado.TabIndex = 22;
            // 
            // cmbTipoContrato
            // 
            cmbTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoContrato.FormattingEnabled = true;
            cmbTipoContrato.Items.AddRange(new object[] { "Indefinido", "Temporal" });
            cmbTipoContrato.Location = new Point(211, 247);
            cmbTipoContrato.Name = "cmbTipoContrato";
            cmbTipoContrato.Size = new Size(250, 28);
            cmbTipoContrato.TabIndex = 21;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(211, 191);
            txtSalario.MaxLength = 10;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(250, 27);
            txtSalario.TabIndex = 20;
            txtSalario.TextChanged += txtSalario_TextChanged;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(211, 139);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(250, 27);
            dtpFechaIngreso.TabIndex = 19;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cmbDepartamento.Location = new Point(211, 82);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(250, 28);
            cmbDepartamento.TabIndex = 18;
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Gerente general", "Empleado" });
            cmbCargo.Location = new Point(211, 36);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(250, 28);
            cmbCargo.TabIndex = 17;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(21, 507);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(135, 22);
            lblObservaciones.TabIndex = 12;
            lblObservaciones.Text = "Observaciones:";
            // 
            // lblTelEmergencia
            // 
            lblTelEmergencia.AutoSize = true;
            lblTelEmergencia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelEmergencia.Location = new Point(21, 454);
            lblTelEmergencia.Name = "lblTelEmergencia";
            lblTelEmergencia.Size = new Size(184, 22);
            lblTelEmergencia.TabIndex = 11;
            lblTelEmergencia.Text = "Teléfono emergencia:";
            // 
            // lblEmergencia
            // 
            lblEmergencia.AutoSize = true;
            lblEmergencia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergencia.Location = new Point(21, 401);
            lblEmergencia.Name = "lblEmergencia";
            lblEmergencia.Size = new Size(187, 22);
            lblEmergencia.TabIndex = 10;
            lblEmergencia.Text = "Emergencia (nombre):";
            // 
            // lblInfoAdicional
            // 
            lblInfoAdicional.AutoSize = true;
            lblInfoAdicional.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoAdicional.Location = new Point(3, 352);
            lblInfoAdicional.Name = "lblInfoAdicional";
            lblInfoAdicional.Size = new Size(219, 25);
            lblInfoAdicional.TabIndex = 9;
            lblInfoAdicional.Text = "Información Adicional";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(21, 301);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 22);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoContrato.Location = new Point(21, 247);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(146, 22);
            lblTipoContrato.TabIndex = 7;
            lblTipoContrato.Text = "Tipo de contrato:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(21, 197);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(71, 22);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salario:";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaIngreso.Location = new Point(21, 146);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(154, 22);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.Location = new Point(21, 88);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(128, 22);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(21, 36);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(64, 22);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo:";
            // 
            // lblInfoLaboral
            // 
            lblInfoLaboral.AutoSize = true;
            lblInfoLaboral.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoLaboral.Location = new Point(3, 0);
            lblInfoLaboral.Name = "lblInfoLaboral";
            lblInfoLaboral.Size = new Size(195, 25);
            lblInfoLaboral.TabIndex = 2;
            lblInfoLaboral.Text = "Información laboral";
            // 
            // pnlInfoPersonal
            // 
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
            pnlInfoPersonal.Location = new Point(279, 61);
            pnlInfoPersonal.Name = "pnlInfoPersonal";
            pnlInfoPersonal.Size = new Size(467, 522);
            pnlInfoPersonal.TabIndex = 11;
            // 
            // txtDirreccion
            // 
            txtDirreccion.Location = new Point(199, 457);
            txtDirreccion.MaxLength = 200;
            txtDirreccion.Multiline = true;
            txtDirreccion.Name = "txtDirreccion";
            txtDirreccion.Size = new Size(250, 50);
            txtDirreccion.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(199, 403);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 27);
            txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(199, 353);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 17;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(199, 304);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(250, 28);
            cmbGenero.TabIndex = 16;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(199, 250);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 15;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(199, 195);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(250, 27);
            txtCedula.TabIndex = 14;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(199, 144);
            txtApellidos.MaxLength = 50;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(250, 27);
            txtApellidos.TabIndex = 13;
            txtApellidos.KeyPress += txtApellidos_keyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 91);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 12;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(13, 457);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(90, 22);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(13, 403);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 22);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(13, 353);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 22);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.Location = new Point(13, 304);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(75, 22);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Género:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(13, 250);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(181, 22);
            lblFechaNacimiento.TabIndex = 7;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(13, 195);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(117, 22);
            lblCedula.TabIndex = 6;
            lblCedula.Text = "Cédula / DNI:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(13, 144);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(88, 22);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(13, 92);
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
            txtCodigo.Size = new Size(250, 27);
            txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(13, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(104, 22);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "ID / Código:";
            // 
            // lblInfoPeronal
            // 
            lblInfoPeronal.AutoSize = true;
            lblInfoPeronal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoPeronal.Location = new Point(3, 0);
            lblInfoPeronal.Name = "lblInfoPeronal";
            lblInfoPeronal.Size = new Size(213, 25);
            lblInfoPeronal.TabIndex = 1;
            lblInfoPeronal.Text = "Información personal";
            // 
            // pnlFoto
            // 
            pnlFoto.BorderStyle = BorderStyle.FixedSingle;
            pnlFoto.Controls.Add(btnQuitarImagen);
            pnlFoto.Controls.Add(btnSeleccionarImagen);
            pnlFoto.Controls.Add(picfoto);
            pnlFoto.Location = new Point(3, 75);
            pnlFoto.Name = "pnlFoto";
            pnlFoto.Size = new Size(255, 404);
            pnlFoto.TabIndex = 10;
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitarImagen.Location = new Point(20, 321);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(213, 53);
            btnQuitarImagen.TabIndex = 11;
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.UseVisualStyleBackColor = true;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.BackColor = Color.RoyalBlue;
            btnSeleccionarImagen.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarImagen.Location = new Point(20, 278);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(213, 37);
            btnSeleccionarImagen.TabIndex = 1;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // picfoto
            // 
            picfoto.BorderStyle = BorderStyle.FixedSingle;
            picfoto.Location = new Point(34, 66);
            picfoto.Name = "picfoto";
            picfoto.Size = new Size(182, 180);
            picfoto.SizeMode = PictureBoxSizeMode.Zoom;
            picfoto.TabIndex = 0;
            picfoto.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.Location = new Point(3, 42);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 10);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Empleado";
            // 
            // ofdImagen
            // 
            ofdImagen.FileName = "openFileDialog1";
            ofdImagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            ofdImagen.Title = "Seleccionar imagen del empleado";
            // 
            // FrmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 821);
            Controls.Add(pnlNuevoEmple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoEmpleado";
            Text = "FrmNuevoEmpleado";
            Load += FrmNuevoEmpleado_Load;
            pnlNuevoEmple.ResumeLayout(false);
            pnlNuevoEmple.PerformLayout();
            pnlInfoLaboral.ResumeLayout(false);
            pnlInfoLaboral.PerformLayout();
            pnlInfoPersonal.ResumeLayout(false);
            pnlInfoPersonal.PerformLayout();
            pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picfoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevoEmple;
        private Label label1;
        private Panel panel3;
        private Panel pnlFoto;
        private PictureBox picfoto;
        private Button btnQuitarImagen;
        private Button btnSeleccionarImagen;
        private Panel pnlInfoPersonal;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblInfoPeronal;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblGenero;
        private Label lblFechaNacimiento;
        private Label lblCedula;
        private Label lblApellidos;
        private Label lblNombres;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtCedula;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtDirreccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private ComboBox cmbGenero;
        private OpenFileDialog ofdImagen;
        private Panel pnlInfoLaboral;
        private Label lblInfoLaboral;
        private Label lblObservaciones;
        private Label lblTelEmergencia;
        private Label lblEmergencia;
        private Label lblInfoAdicional;
        private Label lblEstado;
        private Label lblTipoContrato;
        private Label lblSalario;
        private Label lblFechaIngreso;
        private Label lblDepartamento;
        private Label lblCargo;
        private TextBox txtObservaciones;
        private TextBox txtTeleEmergencia;
        private TextBox txtEmerNombre;
        private ComboBox cmbEstado;
        private ComboBox cmbTipoContrato;
        private TextBox txtSalario;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox cmbDepartamento;
        private ComboBox cmbCargo;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}