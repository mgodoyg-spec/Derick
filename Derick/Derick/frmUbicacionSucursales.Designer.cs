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
            lblCiudadSucursal = new Label();
            lblNombreSucursal = new Label();
            lbEstadoSucursal = new Label();
            pnlUbicacion = new Panel();
            webMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblDireccion = new Label();
            lblDir = new Label();
            lblEstado = new Label();
            lblCiudad = new Label();
            lblSucursal = new Label();
            btnAbrirGMaps = new Button();
            lblSalirV = new Label();
            picUbi = new PictureBox();
            lblUbi = new Label();
            pictureBox1 = new PictureBox();
            pnlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webMapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUbi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudadSucursal.ForeColor = Color.Black;
            lblCiudadSucursal.Location = new Point(577, 32);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(69, 23);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.ForeColor = Color.Black;
            lblNombreSucursal.Location = new Point(3, 8);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(191, 23);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstadoSucursal.ForeColor = Color.Black;
            lbEstadoSucursal.Location = new Point(577, 9);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(179, 23);
            lbEstadoSucursal.TabIndex = 32;
            lbEstadoSucursal.Text = "Estado de la sucursal:";
            // 
            // pnlUbicacion
            // 
            pnlUbicacion.BackColor = Color.White;
            pnlUbicacion.Controls.Add(webMapa);
            pnlUbicacion.Controls.Add(lblDireccion);
            pnlUbicacion.Controls.Add(lblDir);
            pnlUbicacion.Controls.Add(lblEstado);
            pnlUbicacion.Controls.Add(lblCiudad);
            pnlUbicacion.Controls.Add(lblSucursal);
            pnlUbicacion.Controls.Add(btnAbrirGMaps);
            pnlUbicacion.Controls.Add(lbEstadoSucursal);
            pnlUbicacion.Controls.Add(lblCiudadSucursal);
            pnlUbicacion.Controls.Add(lblNombreSucursal);
            pnlUbicacion.Location = new Point(12, 55);
            pnlUbicacion.Name = "pnlUbicacion";
            pnlUbicacion.Size = new Size(886, 466);
            pnlUbicacion.TabIndex = 26;
            // 
            // webMapa
            // 
            webMapa.AllowExternalDrop = true;
            webMapa.CreationProperties = null;
            webMapa.DefaultBackgroundColor = Color.White;
            webMapa.Location = new Point(22, 58);
            webMapa.Name = "webMapa";
            webMapa.Size = new Size(841, 357);
            webMapa.TabIndex = 40;
            webMapa.ZoomFactor = 1D;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(99, 32);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(14, 23);
            lblDireccion.TabIndex = 39;
            lblDireccion.Text = "l";
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDir.ForeColor = Color.Black;
            lblDir.Location = new Point(3, 31);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(90, 23);
            lblDir.TabIndex = 38;
            lblDir.Text = "Dirección:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(762, 8);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(14, 23);
            lblEstado.TabIndex = 37;
            lblEstado.Text = "l";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCiudad.Location = new Point(652, 32);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(14, 23);
            lblCiudad.TabIndex = 36;
            lblCiudad.Text = "l";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(200, 4);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(14, 23);
            lblSucursal.TabIndex = 35;
            lblSucursal.Text = "l";
            // 
            // btnAbrirGMaps
            // 
            btnAbrirGMaps.BackColor = Color.FromArgb(112, 34, 246);
            btnAbrirGMaps.Cursor = Cursors.Hand;
            btnAbrirGMaps.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirGMaps.ForeColor = Color.White;
            btnAbrirGMaps.Location = new Point(356, 421);
            btnAbrirGMaps.Name = "btnAbrirGMaps";
            btnAbrirGMaps.Size = new Size(217, 42);
            btnAbrirGMaps.TabIndex = 27;
            btnAbrirGMaps.Text = "Abrir en Google Maps";
            btnAbrirGMaps.UseVisualStyleBackColor = false;
            btnAbrirGMaps.Click += btnAbrirGMaps_Click;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(884, 0);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(27, 25);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // picUbi
            // 
            picUbi.BackgroundImage = Properties.Resources.pasador_de_ubicacion;
            picUbi.BackgroundImageLayout = ImageLayout.Zoom;
            picUbi.Location = new Point(1, -1);
            picUbi.Name = "picUbi";
            picUbi.Size = new Size(39, 40);
            picUbi.TabIndex = 28;
            picUbi.TabStop = false;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbi.ForeColor = Color.FromArgb(112, 34, 246);
            lblUbi.Location = new Point(46, -1);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(230, 29);
            lblUbi.TabIndex = 26;
            lblUbi.Text = "Ubicación de sucursal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detallemorado__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(46, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 11);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // frmUbicacionSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(910, 533);
            Controls.Add(pictureBox1);
            Controls.Add(pnlUbicacion);
            Controls.Add(lblSalirV);
            Controls.Add(picUbi);
            Controls.Add(lblUbi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUbicacionSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubicación Sucursal";
            Load += frmUbicacionSucursales_Load;
            pnlUbicacion.ResumeLayout(false);
            pnlUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webMapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUbi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCiudadSucursal;
        private Label lblNombreSucursal;
        private Label lbEstadoSucursal;
        private Panel pnlUbicacion;
        private Button btnAbrirGMaps;
        private Label lblUbi;
        private PictureBox picUbi;
        private Label lblSalirV;
        private PictureBox pictureBox1;
        private Label lblEstado;
        private Label lblCiudad;
        private Label lblSucursal;
        private Label lblDireccion;
        private Label lblDir;
        private Microsoft.Web.WebView2.WinForms.WebView2 webMapa;
    }
}