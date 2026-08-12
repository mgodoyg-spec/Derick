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
            pbxUbiMapa = new PictureBox();
            pnlUbicacion = new Panel();
            lblEstado = new Label();
            lblCiudad = new Label();
            lblSucursal = new Label();
            lblLongitud = new Label();
            lblLatitud = new Label();
            button1 = new Button();
            lblSalirV = new Label();
            picUbi = new PictureBox();
            lblUbi = new Label();
            pictureBox1 = new PictureBox();
            lblDir = new Label();
            lblDireccion = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).BeginInit();
            pnlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUbi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblCiudadSucursal.ForeColor = Color.Black;
            lblCiudadSucursal.Location = new Point(108, 33);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(60, 19);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblNombreSucursal.ForeColor = Color.Black;
            lblNombreSucursal.Location = new Point(3, 8);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(165, 19);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbEstadoSucursal.ForeColor = Color.Black;
            lbEstadoSucursal.Location = new Point(378, 8);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(155, 19);
            lbEstadoSucursal.TabIndex = 32;
            lbEstadoSucursal.Text = "Estado de la sucursal:";
            // 
            // pbxUbiMapa
            // 
            pbxUbiMapa.BackgroundImage = Properties.Resources.mapa;
            pbxUbiMapa.BackgroundImageLayout = ImageLayout.Zoom;
            pbxUbiMapa.Location = new Point(76, 55);
            pbxUbiMapa.Name = "pbxUbiMapa";
            pbxUbiMapa.Size = new Size(642, 253);
            pbxUbiMapa.TabIndex = 25;
            pbxUbiMapa.TabStop = false;
            // 
            // pnlUbicacion
            // 
            pnlUbicacion.BackColor = Color.White;
            pnlUbicacion.Controls.Add(lblDireccion);
            pnlUbicacion.Controls.Add(lblDir);
            pnlUbicacion.Controls.Add(lblEstado);
            pnlUbicacion.Controls.Add(lblCiudad);
            pnlUbicacion.Controls.Add(lblSucursal);
            pnlUbicacion.Controls.Add(lblLongitud);
            pnlUbicacion.Controls.Add(lblLatitud);
            pnlUbicacion.Controls.Add(button1);
            pnlUbicacion.Controls.Add(lbEstadoSucursal);
            pnlUbicacion.Controls.Add(pbxUbiMapa);
            pnlUbicacion.Controls.Add(lblCiudadSucursal);
            pnlUbicacion.Controls.Add(lblNombreSucursal);
            pnlUbicacion.Location = new Point(12, 51);
            pnlUbicacion.Name = "pnlUbicacion";
            pnlUbicacion.Size = new Size(786, 369);
            pnlUbicacion.TabIndex = 26;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(539, 11);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(11, 15);
            lblEstado.TabIndex = 37;
            lblEstado.Text = "l";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCiudad.Location = new Point(174, 37);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(11, 15);
            lblCiudad.TabIndex = 36;
            lblCiudad.Text = "l";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(174, 8);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(11, 15);
            lblSucursal.TabIndex = 35;
            lblSucursal.Text = "l";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongitud.Location = new Point(22, 334);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(84, 23);
            lblLongitud.TabIndex = 34;
            lblLongitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLatitud.Location = new Point(22, 311);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(70, 23);
            lblLatitud.TabIndex = 33;
            lblLatitud.Text = "Latitud:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 34, 246);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(546, 314);
            button1.Name = "button1";
            button1.Size = new Size(217, 42);
            button1.TabIndex = 27;
            button1.Text = "Abrir en Google Maps";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(783, -1);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // picUbi
            // 
            picUbi.BackgroundImage = Properties.Resources.pasador_de_ubicacion;
            picUbi.BackgroundImageLayout = ImageLayout.Zoom;
            picUbi.Location = new Point(1, 12);
            picUbi.Name = "picUbi";
            picUbi.Size = new Size(39, 36);
            picUbi.TabIndex = 28;
            picUbi.TabStop = false;
            // 
            // lblUbi
            // 
            lblUbi.AutoSize = true;
            lblUbi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbi.ForeColor = Color.FromArgb(112, 34, 246);
            lblUbi.Location = new Point(46, 9);
            lblUbi.Name = "lblUbi";
            lblUbi.Size = new Size(198, 26);
            lblUbi.TabIndex = 26;
            lblUbi.Text = "Ubicación de sucursal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detallemorado__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(46, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 14);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblDir.ForeColor = Color.Black;
            lblDir.Location = new Point(378, 33);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(77, 19);
            lblDir.TabIndex = 38;
            lblDir.Text = "Dirección:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(461, 36);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(11, 15);
            lblDireccion.TabIndex = 39;
            lblDireccion.Text = "l";
            // 
            // frmUbicacionSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(810, 433);
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
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).EndInit();
            pnlUbicacion.ResumeLayout(false);
            pnlUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUbi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCiudadSucursal;
        private Label lblNombreSucursal;
        private Label lbEstadoSucursal;
        private PictureBox pbxUbiMapa;
        private Panel pnlUbicacion;
        private Button button1;
        private Label lblUbi;
        private PictureBox picUbi;
        private Label lblLongitud;
        private Label lblLatitud;
        private Label lblSalirV;
        private PictureBox pictureBox1;
        private Label lblEstado;
        private Label lblCiudad;
        private Label lblSucursal;
        private Label lblDireccion;
        private Label lblDir;
    }
}