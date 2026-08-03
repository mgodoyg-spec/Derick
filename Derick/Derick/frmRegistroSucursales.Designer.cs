namespace Derick
{
    partial class frmRegistroSucursales
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
            pnlTituloRegistroSucursales = new Panel();
            lblDescripcionSuc = new Label();
            pbxIconoDerick = new PictureBox();
            lblRegistroSucursal = new Label();
            lblNombreSucursal = new Label();
            pnlRegistroSucursal = new Panel();
            pbxRegistrarSucursal = new PictureBox();
            txtCodigoSucursal = new TextBox();
            lblCodigo = new Label();
            lblInformacionSuc = new Label();
            txtEncargadoSucursal = new TextBox();
            lblEncargadoSucursal = new Label();
            txtCorreoSucursal = new TextBox();
            lblCorreo = new Label();
            txtTelefonoSucursal = new TextBox();
            lbltelefono = new Label();
            txtDireccionSucursal = new TextBox();
            lblDireccion = new Label();
            txtCiudadSucursal = new TextBox();
            lblCiudad = new Label();
            txtNombreSucursal = new TextBox();
            btnAgregarImagen = new Button();
            pbxImagenSucursal = new PictureBox();
            btnRegistrarSucursal = new Button();
            cbxEstadoSucursal = new ComboBox();
            ofdAgregarImagen = new OpenFileDialog();
            pnlImagen = new Panel();
            lblImagenSuc = new Label();
            pnlEstado = new Panel();
            lblDescripcionEstado = new Label();
            lblestado = new Label();
            pnlTituloRegistroSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).BeginInit();
            pnlRegistroSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxRegistrarSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenSucursal).BeginInit();
            pnlImagen.SuspendLayout();
            pnlEstado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTituloRegistroSucursales
            // 
            pnlTituloRegistroSucursales.BackColor = Color.Black;
            pnlTituloRegistroSucursales.Controls.Add(lblDescripcionSuc);
            pnlTituloRegistroSucursales.Controls.Add(pbxIconoDerick);
            pnlTituloRegistroSucursales.Controls.Add(lblRegistroSucursal);
            pnlTituloRegistroSucursales.Location = new Point(358, 12);
            pnlTituloRegistroSucursales.Name = "pnlTituloRegistroSucursales";
            pnlTituloRegistroSucursales.Size = new Size(626, 100);
            pnlTituloRegistroSucursales.TabIndex = 0;
            // 
            // lblDescripcionSuc
            // 
            lblDescripcionSuc.AutoSize = true;
            lblDescripcionSuc.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcionSuc.ForeColor = Color.White;
            lblDescripcionSuc.Location = new Point(128, 60);
            lblDescripcionSuc.Name = "lblDescripcionSuc";
            lblDescripcionSuc.Size = new Size(387, 19);
            lblDescripcionSuc.TabIndex = 2;
            lblDescripcionSuc.Text = "Complete la información para registrar una nueva sucursal";
            // 
            // pbxIconoDerick
            // 
            pbxIconoDerick.BackgroundImage = Properties.Resources.DerickRecortado;
            pbxIconoDerick.BackgroundImageLayout = ImageLayout.Zoom;
            pbxIconoDerick.Location = new Point(0, 8);
            pbxIconoDerick.Name = "pbxIconoDerick";
            pbxIconoDerick.Size = new Size(105, 89);
            pbxIconoDerick.TabIndex = 1;
            pbxIconoDerick.TabStop = false;
            // 
            // lblRegistroSucursal
            // 
            lblRegistroSucursal.AutoSize = true;
            lblRegistroSucursal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroSucursal.ForeColor = Color.WhiteSmoke;
            lblRegistroSucursal.Location = new Point(110, 23);
            lblRegistroSucursal.Name = "lblRegistroSucursal";
            lblRegistroSucursal.Size = new Size(363, 37);
            lblRegistroSucursal.TabIndex = 0;
            lblRegistroSucursal.Text = "Registro de sucursales";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.Location = new Point(29, 105);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(192, 20);
            lblNombreSucursal.TabIndex = 1;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // pnlRegistroSucursal
            // 
            pnlRegistroSucursal.BackColor = Color.White;
            pnlRegistroSucursal.Controls.Add(pbxRegistrarSucursal);
            pnlRegistroSucursal.Controls.Add(txtCodigoSucursal);
            pnlRegistroSucursal.Controls.Add(lblCodigo);
            pnlRegistroSucursal.Controls.Add(lblInformacionSuc);
            pnlRegistroSucursal.Controls.Add(txtEncargadoSucursal);
            pnlRegistroSucursal.Controls.Add(lblEncargadoSucursal);
            pnlRegistroSucursal.Controls.Add(txtCorreoSucursal);
            pnlRegistroSucursal.Controls.Add(lblCorreo);
            pnlRegistroSucursal.Controls.Add(txtTelefonoSucursal);
            pnlRegistroSucursal.Controls.Add(lbltelefono);
            pnlRegistroSucursal.Controls.Add(txtDireccionSucursal);
            pnlRegistroSucursal.Controls.Add(lblDireccion);
            pnlRegistroSucursal.Controls.Add(txtCiudadSucursal);
            pnlRegistroSucursal.Controls.Add(lblCiudad);
            pnlRegistroSucursal.Controls.Add(txtNombreSucursal);
            pnlRegistroSucursal.Controls.Add(lblNombreSucursal);
            pnlRegistroSucursal.Location = new Point(137, 118);
            pnlRegistroSucursal.Name = "pnlRegistroSucursal";
            pnlRegistroSucursal.Size = new Size(504, 491);
            pnlRegistroSucursal.TabIndex = 2;
            // 
            // pbxRegistrarSucursal
            // 
            pbxRegistrarSucursal.BackgroundImage = Properties.Resources.iconoRegistrarSuc;
            pbxRegistrarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxRegistrarSucursal.Location = new Point(3, 3);
            pbxRegistrarSucursal.Name = "pbxRegistrarSucursal";
            pbxRegistrarSucursal.Size = new Size(47, 41);
            pbxRegistrarSucursal.TabIndex = 21;
            pbxRegistrarSucursal.TabStop = false;
            // 
            // txtCodigoSucursal
            // 
            txtCodigoSucursal.Location = new Point(29, 69);
            txtCodigoSucursal.Name = "txtCodigoSucursal";
            txtCodigoSucursal.Size = new Size(292, 26);
            txtCodigoSucursal.TabIndex = 20;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(29, 46);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(186, 20);
            lblCodigo.TabIndex = 19;
            lblCodigo.Text = "Código de la sucursal:";
            // 
            // lblInformacionSuc
            // 
            lblInformacionSuc.AutoSize = true;
            lblInformacionSuc.BackColor = Color.White;
            lblInformacionSuc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacionSuc.ForeColor = Color.FromArgb(0, 102, 255);
            lblInformacionSuc.Location = new Point(56, 10);
            lblInformacionSuc.Name = "lblInformacionSuc";
            lblInformacionSuc.Size = new Size(220, 20);
            lblInformacionSuc.TabIndex = 18;
            lblInformacionSuc.Text = "Información de la sucursal";
            // 
            // txtEncargadoSucursal
            // 
            txtEncargadoSucursal.Location = new Point(29, 440);
            txtEncargadoSucursal.Name = "txtEncargadoSucursal";
            txtEncargadoSucursal.Size = new Size(292, 26);
            txtEncargadoSucursal.TabIndex = 12;
            // 
            // lblEncargadoSucursal
            // 
            lblEncargadoSucursal.AutoSize = true;
            lblEncargadoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncargadoSucursal.Location = new Point(29, 417);
            lblEncargadoSucursal.Name = "lblEncargadoSucursal";
            lblEncargadoSucursal.Size = new Size(217, 20);
            lblEncargadoSucursal.TabIndex = 11;
            lblEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // txtCorreoSucursal
            // 
            txtCorreoSucursal.Location = new Point(29, 375);
            txtCorreoSucursal.Name = "txtCorreoSucursal";
            txtCorreoSucursal.Size = new Size(292, 26);
            txtCorreoSucursal.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(29, 352);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(161, 20);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtTelefonoSucursal
            // 
            txtTelefonoSucursal.Location = new Point(29, 317);
            txtTelefonoSucursal.MaxLength = 10;
            txtTelefonoSucursal.Name = "txtTelefonoSucursal";
            txtTelefonoSucursal.Size = new Size(292, 26);
            txtTelefonoSucursal.TabIndex = 8;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefono.Location = new Point(29, 294);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(84, 20);
            lbltelefono.TabIndex = 7;
            lbltelefono.Text = "Teléfono:";
            // 
            // txtDireccionSucursal
            // 
            txtDireccionSucursal.Location = new Point(29, 253);
            txtDireccionSucursal.Name = "txtDireccionSucursal";
            txtDireccionSucursal.Size = new Size(292, 26);
            txtDireccionSucursal.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(29, 230);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 20);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección:";
            // 
            // txtCiudadSucursal
            // 
            txtCiudadSucursal.Location = new Point(29, 186);
            txtCiudadSucursal.Name = "txtCiudadSucursal";
            txtCiudadSucursal.Size = new Size(292, 26);
            txtCiudadSucursal.TabIndex = 4;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudad.Location = new Point(29, 163);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(70, 20);
            lblCiudad.TabIndex = 3;
            lblCiudad.Text = "Ciudad:";
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Location = new Point(29, 128);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(292, 26);
            txtNombreSucursal.TabIndex = 2;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.BackColor = Color.LightGray;
            btnAgregarImagen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarImagen.Location = new Point(131, 218);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(154, 28);
            btnAgregarImagen.TabIndex = 17;
            btnAgregarImagen.Text = "Agregar Imagen";
            btnAgregarImagen.UseVisualStyleBackColor = false;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // pbxImagenSucursal
            // 
            pbxImagenSucursal.BorderStyle = BorderStyle.Fixed3D;
            pbxImagenSucursal.Location = new Point(102, 36);
            pbxImagenSucursal.Name = "pbxImagenSucursal";
            pbxImagenSucursal.Size = new Size(209, 176);
            pbxImagenSucursal.TabIndex = 16;
            pbxImagenSucursal.TabStop = false;
            // 
            // btnRegistrarSucursal
            // 
            btnRegistrarSucursal.BackColor = Color.FromArgb(0, 102, 255);
            btnRegistrarSucursal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSucursal.ForeColor = Color.White;
            btnRegistrarSucursal.Location = new Point(760, 563);
            btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            btnRegistrarSucursal.Size = new Size(250, 46);
            btnRegistrarSucursal.TabIndex = 15;
            btnRegistrarSucursal.Text = "Registrar sucursal";
            btnRegistrarSucursal.UseVisualStyleBackColor = false;
            // 
            // cbxEstadoSucursal
            // 
            cbxEstadoSucursal.FormattingEnabled = true;
            cbxEstadoSucursal.Items.AddRange(new object[] { "Activa", "Inactiva", "Remodelación" });
            cbxEstadoSucursal.Location = new Point(18, 69);
            cbxEstadoSucursal.Name = "cbxEstadoSucursal";
            cbxEstadoSucursal.Size = new Size(279, 28);
            cbxEstadoSucursal.TabIndex = 14;
            // 
            // ofdAgregarImagen
            // 
            ofdAgregarImagen.FileName = "openFileDialog1";
            // 
            // pnlImagen
            // 
            pnlImagen.BackColor = Color.White;
            pnlImagen.Controls.Add(lblImagenSuc);
            pnlImagen.Controls.Add(pbxImagenSucursal);
            pnlImagen.Controls.Add(btnAgregarImagen);
            pnlImagen.Location = new Point(680, 118);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(404, 267);
            pnlImagen.TabIndex = 3;
            // 
            // lblImagenSuc
            // 
            lblImagenSuc.AutoSize = true;
            lblImagenSuc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImagenSuc.Location = new Point(6, 10);
            lblImagenSuc.Name = "lblImagenSuc";
            lblImagenSuc.Size = new Size(190, 20);
            lblImagenSuc.TabIndex = 18;
            lblImagenSuc.Text = "Imagen de la sucursal:";
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.White;
            pnlEstado.Controls.Add(lblDescripcionEstado);
            pnlEstado.Controls.Add(lblestado);
            pnlEstado.Controls.Add(cbxEstadoSucursal);
            pnlEstado.Location = new Point(680, 400);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(404, 132);
            pnlEstado.TabIndex = 4;
            // 
            // lblDescripcionEstado
            // 
            lblDescripcionEstado.AutoSize = true;
            lblDescripcionEstado.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcionEstado.ForeColor = Color.Black;
            lblDescripcionEstado.Location = new Point(6, 33);
            lblDescripcionEstado.Name = "lblDescripcionEstado";
            lblDescripcionEstado.Size = new Size(233, 19);
            lblDescripcionEstado.TabIndex = 20;
            lblDescripcionEstado.Text = "Seleccione el estado de la sucursal";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblestado.Location = new Point(6, 12);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(187, 20);
            lblestado.TabIndex = 19;
            lblestado.Text = "Estado de la sucursal:";
            // 
            // frmRegistroSucursales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1200, 651);
            Controls.Add(pnlEstado);
            Controls.Add(btnRegistrarSucursal);
            Controls.Add(pnlImagen);
            Controls.Add(pnlRegistroSucursal);
            Controls.Add(pnlTituloRegistroSucursales);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistroSucursales";
            StartPosition = FormStartPosition.Manual;
            Text = "frmRegistroSucursales";
            pnlTituloRegistroSucursales.ResumeLayout(false);
            pnlTituloRegistroSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).EndInit();
            pnlRegistroSucursal.ResumeLayout(false);
            pnlRegistroSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxRegistrarSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagenSucursal).EndInit();
            pnlImagen.ResumeLayout(false);
            pnlImagen.PerformLayout();
            pnlEstado.ResumeLayout(false);
            pnlEstado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTituloRegistroSucursales;
        private Label lblRegistroSucursal;
        private Label lblNombreSucursal;
        private Panel pnlRegistroSucursal;
        private Label lblDireccion;
        private TextBox txtCiudadSucursal;
        private Label lblCiudad;
        private TextBox txtNombreSucursal;
        private TextBox txtEstadoSucursa;
        private TextBox txtEncargadoSucursal;
        private Label lblEncargadoSucursal;
        private TextBox txtCorreoSucursal;
        private Label lblCorreo;
        private TextBox txtTelefonoSucursal;
        private Label lbltelefono;
        private TextBox txtDireccionSucursal;
        private ComboBox cbxEstadoSucursal;
        private Button btnRegistrarSucursal;
        private PictureBox pbxIconoDerick;
        private PictureBox pbxImagenSucursal;
        private Button btnAgregarImagen;
        private OpenFileDialog ofdAgregarImagen;
        private Label lblDescripcionSuc;
        private Label lblInformacionSuc;
        private Panel pnlImagen;
        private Label lblImagenSuc;
        private Panel pnlEstado;
        private Label lblDescripcionEstado;
        private Label lblestado;
        private TextBox txtCodigoSucursal;
        private Label lblCodigo;
        private PictureBox pbxRegistrarSucursal;
    }
}