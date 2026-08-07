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
            pnlInformacion = new Panel();
            lblEncargadoSucursal = new Label();
            lbltelefono = new Label();
            lblCiudadSucursal = new Label();
            lblNombreSucursal = new Label();
            lbEstadoSucursal = new Label();
            lblInformacion = new Label();
            pbxUbiMapa = new PictureBox();
            pnlUbicacion = new Panel();
            lblLongitud = new Label();
            lblLatitud = new Label();
            picUbi = new PictureBox();
            button1 = new Button();
            lblUbi = new Label();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).BeginInit();
            pnlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUbi).BeginInit();
            SuspendLayout();
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(lblEncargadoSucursal);
            pnlInformacion.Controls.Add(lbltelefono);
            pnlInformacion.Controls.Add(lblCiudadSucursal);
            pnlInformacion.Controls.Add(lblNombreSucursal);
            pnlInformacion.Controls.Add(lbEstadoSucursal);
            pnlInformacion.Controls.Add(lblInformacion);
            pnlInformacion.Location = new Point(81, 382);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(587, 139);
            pnlInformacion.TabIndex = 24;
            // 
            // lblEncargadoSucursal
            // 
            lblEncargadoSucursal.AutoSize = true;
            lblEncargadoSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncargadoSucursal.ForeColor = Color.DimGray;
            lblEncargadoSucursal.Location = new Point(287, 34);
            lblEncargadoSucursal.Name = "lblEncargadoSucursal";
            lblEncargadoSucursal.Size = new Size(207, 23);
            lblEncargadoSucursal.TabIndex = 30;
            lblEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefono.ForeColor = Color.DimGray;
            lbltelefono.Location = new Point(7, 110);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(83, 23);
            lbltelefono.TabIndex = 28;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudadSucursal.ForeColor = Color.DimGray;
            lblCiudadSucursal.Location = new Point(7, 71);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(69, 23);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.ForeColor = Color.DimGray;
            lblNombreSucursal.Location = new Point(7, 34);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(191, 23);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstadoSucursal.ForeColor = Color.DimGray;
            lbEstadoSucursal.Location = new Point(287, 71);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(179, 23);
            lbEstadoSucursal.TabIndex = 32;
            lbEstadoSucursal.Text = "Estado de la sucursal:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.Black;
            lblInformacion.Location = new Point(7, 6);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(180, 23);
            lblInformacion.TabIndex = 24;
            lblInformacion.Text = "Información adicional";
            // 
            // pbxUbiMapa
            // 
            pbxUbiMapa.BackgroundImage = Properties.Resources.mapa;
            pbxUbiMapa.BackgroundImageLayout = ImageLayout.Zoom;
            pbxUbiMapa.BorderStyle = BorderStyle.Fixed3D;
            pbxUbiMapa.Location = new Point(39, 56);
            pbxUbiMapa.Name = "pbxUbiMapa";
            pbxUbiMapa.Size = new Size(588, 248);
            pbxUbiMapa.TabIndex = 25;
            pbxUbiMapa.TabStop = false;
            // 
            // pnlUbicacion
            // 
            pnlUbicacion.BackColor = Color.White;
            pnlUbicacion.Controls.Add(lblLongitud);
            pnlUbicacion.Controls.Add(lblLatitud);
            pnlUbicacion.Controls.Add(picUbi);
            pnlUbicacion.Controls.Add(button1);
            pnlUbicacion.Controls.Add(lblUbi);
            pnlUbicacion.Controls.Add(pbxUbiMapa);
            pnlUbicacion.Location = new Point(41, 12);
            pnlUbicacion.Name = "pnlUbicacion";
            pnlUbicacion.Size = new Size(667, 364);
            pnlUbicacion.TabIndex = 26;
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongitud.Location = new Point(22, 333);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(84, 23);
            lblLongitud.TabIndex = 34;
            lblLongitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLatitud.Location = new Point(22, 310);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(70, 23);
            lblLatitud.TabIndex = 33;
            lblLatitud.Text = "Latitud:";
            // 
            // picUbi
            // 
            picUbi.BackgroundImage = Properties.Resources.pasador_de_ubicacion;
            picUbi.BackgroundImageLayout = ImageLayout.Zoom;
            picUbi.Location = new Point(0, 0);
            picUbi.Name = "picUbi";
            picUbi.Size = new Size(52, 50);
            picUbi.TabIndex = 28;
            picUbi.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 34, 246);
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(428, 310);
            button1.Name = "button1";
            button1.Size = new Size(217, 42);
            button1.TabIndex = 27;
            button1.Text = "Abrir en Google Maps";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbi.ForeColor = Color.FromArgb(112, 34, 246);
            lblUbi.Location = new Point(58, 11);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(203, 23);
            lblUbi.TabIndex = 26;
            lblUbi.Text = "Ubicación de la sucursal:";
            // 
            // frmUbicacionSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(730, 520);
            Controls.Add(pnlUbicacion);
            Controls.Add(pnlInformacion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmUbicacionSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubicación Sucursal";
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).EndInit();
            pnlUbicacion.ResumeLayout(false);
            pnlUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUbi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlInformacion;
        private Label lblEncargadoSucursal;
        private Label lbltelefono;
        private Label lblCiudadSucursal;
        private Label lblNombreSucursal;
        private Label lbEstadoSucursal;
        private Label lblInformacion;
        private PictureBox pbxUbiMapa;
        private Panel pnlUbicacion;
        private Button button1;
        private Label lblUbi;
        private PictureBox picUbi;
        private Label lblLongitud;
        private Label lblLatitud;
    }
}