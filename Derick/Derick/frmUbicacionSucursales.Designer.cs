namespace Derick
{
    partial class frmUbicacionSucursales
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
            pnlTituloBuscarSucursales = new Panel();
            lblDescripcionSuc = new Label();
            pbxIconoDerick = new PictureBox();
            lblUbiSucursal = new Label();
            pnlInformacion = new Panel();
            lblCodigo = new Label();
            lblEncargadoSucursal = new Label();
            lblCorreo = new Label();
            lbltelefono = new Label();
            lblDireccion = new Label();
            lblCiudadSucursal = new Label();
            lblNombreSucursal = new Label();
            lbEstadoSucursal = new Label();
            lblInformacion = new Label();
            pbxUbiMapa = new PictureBox();
            pnlUbicacion = new Panel();
            button1 = new Button();
            lblUbi = new Label();
            cbxSucursal = new ComboBox();
            pnlTituloBuscarSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).BeginInit();
            pnlUbicacion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTituloBuscarSucursales
            // 
            pnlTituloBuscarSucursales.BackColor = Color.Black;
            pnlTituloBuscarSucursales.Controls.Add(lblDescripcionSuc);
            pnlTituloBuscarSucursales.Controls.Add(pbxIconoDerick);
            pnlTituloBuscarSucursales.Controls.Add(lblUbiSucursal);
            pnlTituloBuscarSucursales.Location = new Point(269, 13);
            pnlTituloBuscarSucursales.Margin = new Padding(4);
            pnlTituloBuscarSucursales.Name = "pnlTituloBuscarSucursales";
            pnlTituloBuscarSucursales.Size = new Size(626, 100);
            pnlTituloBuscarSucursales.TabIndex = 2;
            // 
            // lblDescripcionSuc
            // 
            lblDescripcionSuc.AutoSize = true;
            lblDescripcionSuc.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcionSuc.ForeColor = Color.White;
            lblDescripcionSuc.Location = new Point(175, 51);
            lblDescripcionSuc.Margin = new Padding(4, 0, 4, 0);
            lblDescripcionSuc.Name = "lblDescripcionSuc";
            lblDescripcionSuc.Size = new Size(333, 19);
            lblDescripcionSuc.TabIndex = 2;
            lblDescripcionSuc.Text = "Consulta la ubicación de las sucursales registradas";
            // 
            // pbxIconoDerick
            // 
            pbxIconoDerick.BackgroundImage = Properties.Resources.DerickRecortado;
            pbxIconoDerick.BackgroundImageLayout = ImageLayout.Zoom;
            pbxIconoDerick.Location = new Point(15, 4);
            pbxIconoDerick.Margin = new Padding(4);
            pbxIconoDerick.Name = "pbxIconoDerick";
            pbxIconoDerick.Size = new Size(105, 89);
            pbxIconoDerick.TabIndex = 1;
            pbxIconoDerick.TabStop = false;
            // 
            // lblUbiSucursal
            // 
            lblUbiSucursal.AutoSize = true;
            lblUbiSucursal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbiSucursal.ForeColor = Color.WhiteSmoke;
            lblUbiSucursal.Location = new Point(156, 14);
            lblUbiSucursal.Margin = new Padding(4, 0, 4, 0);
            lblUbiSucursal.Name = "lblUbiSucursal";
            lblUbiSucursal.Size = new Size(352, 37);
            lblUbiSucursal.TabIndex = 0;
            lblUbiSucursal.Text = "Ubicación de sucursal";
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(lblCodigo);
            pnlInformacion.Controls.Add(lblEncargadoSucursal);
            pnlInformacion.Controls.Add(lblCorreo);
            pnlInformacion.Controls.Add(lbltelefono);
            pnlInformacion.Controls.Add(lblDireccion);
            pnlInformacion.Controls.Add(lblCiudadSucursal);
            pnlInformacion.Controls.Add(lblNombreSucursal);
            pnlInformacion.Controls.Add(lbEstadoSucursal);
            pnlInformacion.Controls.Add(lblInformacion);
            pnlInformacion.Location = new Point(41, 186);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(371, 383);
            pnlInformacion.TabIndex = 24;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(14, 59);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(142, 20);
            lblCodigo.TabIndex = 31;
            lblCodigo.Text = "Código sucursal:";
            // 
            // lblEncargadoSucursal
            // 
            lblEncargadoSucursal.AutoSize = true;
            lblEncargadoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncargadoSucursal.Location = new Point(14, 287);
            lblEncargadoSucursal.Name = "lblEncargadoSucursal";
            lblEncargadoSucursal.Size = new Size(217, 20);
            lblEncargadoSucursal.TabIndex = 30;
            lblEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(14, 246);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(161, 20);
            lblCorreo.TabIndex = 29;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefono.Location = new Point(14, 205);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(84, 20);
            lbltelefono.TabIndex = 28;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(14, 167);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 20);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudadSucursal.Location = new Point(14, 130);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(70, 20);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.Location = new Point(14, 95);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(192, 20);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstadoSucursal.Location = new Point(14, 329);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(187, 20);
            lbEstadoSucursal.TabIndex = 32;
            lbEstadoSucursal.Text = "Estado de la sucursal:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.FromArgb(112, 34, 246);
            lblInformacion.Location = new Point(14, 14);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(207, 20);
            lblInformacion.TabIndex = 24;
            lblInformacion.Text = "Información por sucursal";
            // 
            // pbxUbiMapa
            // 
            pbxUbiMapa.BorderStyle = BorderStyle.Fixed3D;
            pbxUbiMapa.Location = new Point(76, 67);
            pbxUbiMapa.Name = "pbxUbiMapa";
            pbxUbiMapa.Size = new Size(588, 248);
            pbxUbiMapa.TabIndex = 25;
            pbxUbiMapa.TabStop = false;
            // 
            // pnlUbicacion
            // 
            pnlUbicacion.BackColor = Color.White;
            pnlUbicacion.Controls.Add(button1);
            pnlUbicacion.Controls.Add(lblUbi);
            pnlUbicacion.Controls.Add(pbxUbiMapa);
            pnlUbicacion.Location = new Point(421, 160);
            pnlUbicacion.Name = "pnlUbicacion";
            pnlUbicacion.Size = new Size(735, 409);
            pnlUbicacion.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 34, 246);
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(280, 337);
            button1.Name = "button1";
            button1.Size = new Size(217, 35);
            button1.TabIndex = 27;
            button1.Text = "Abrir en Google Maps";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbi.Location = new Point(10, 14);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(209, 20);
            lblUbi.TabIndex = 26;
            lblUbi.Text = "Ubicación de la sucursal:";
            // 
            // cbxSucursal
            // 
            cbxSucursal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxSucursal.FormattingEnabled = true;
            cbxSucursal.Location = new Point(41, 154);
            cbxSucursal.Name = "cbxSucursal";
            cbxSucursal.Size = new Size(217, 26);
            cbxSucursal.TabIndex = 33;
            cbxSucursal.Text = "Seleccione una sucursal...";
            // 
            // frmUbicacionSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1184, 611);
            Controls.Add(cbxSucursal);
            Controls.Add(pnlUbicacion);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlTituloBuscarSucursales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUbicacionSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUbicacionSucursales";
            pnlTituloBuscarSucursales.ResumeLayout(false);
            pnlTituloBuscarSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).EndInit();
            pnlUbicacion.ResumeLayout(false);
            pnlUbicacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTituloBuscarSucursales;
        private Label lblDescripcionSuc;
        private PictureBox pbxIconoDerick;
        private Label lblUbiSucursal;
        private Panel pnlInformacion;
        private Label lblCodigo;
        private Label lblEncargadoSucursal;
        private Label lblCorreo;
        private Label lbltelefono;
        private Label lblDireccion;
        private Label lblCiudadSucursal;
        private Label lblNombreSucursal;
        private Label lbEstadoSucursal;
        private Label lblInformacion;
        private PictureBox pbxUbiMapa;
        private Panel pnlUbicacion;
        private Button button1;
        private Label lblUbi;
        private ComboBox cbxSucursal;
    }
}