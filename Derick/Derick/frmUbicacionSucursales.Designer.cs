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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            lblSalirV = new Label();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUbiMapa).BeginInit();
            pnlUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUbi).BeginInit();
            SuspendLayout();
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(textBox4);
            pnlInformacion.Controls.Add(comboBox1);
            pnlInformacion.Controls.Add(textBox3);
            pnlInformacion.Controls.Add(textBox2);
            pnlInformacion.Controls.Add(textBox1);
            pnlInformacion.Controls.Add(lblEncargadoSucursal);
            pnlInformacion.Controls.Add(lbltelefono);
            pnlInformacion.Controls.Add(lblCiudadSucursal);
            pnlInformacion.Controls.Add(lblNombreSucursal);
            pnlInformacion.Controls.Add(lbEstadoSucursal);
            pnlInformacion.Controls.Add(lblInformacion);
            pnlInformacion.Location = new Point(12, 382);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(776, 139);
            pnlInformacion.TabIndex = 24;
            // 
            // lblEncargadoSucursal
            // 
            lblEncargadoSucursal.AutoSize = true;
            lblEncargadoSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblEncargadoSucursal.ForeColor = Color.DimGray;
            lblEncargadoSucursal.Location = new Point(367, 34);
            lblEncargadoSucursal.Name = "lblEncargadoSucursal";
            lblEncargadoSucursal.Size = new Size(181, 19);
            lblEncargadoSucursal.TabIndex = 30;
            lblEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbltelefono.ForeColor = Color.DimGray;
            lbltelefono.Location = new Point(7, 92);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(72, 19);
            lbltelefono.TabIndex = 28;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblCiudadSucursal.ForeColor = Color.DimGray;
            lblCiudadSucursal.Location = new Point(7, 62);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(60, 19);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblNombreSucursal.ForeColor = Color.DimGray;
            lblNombreSucursal.Location = new Point(7, 34);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(165, 19);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbEstadoSucursal.ForeColor = Color.DimGray;
            lbEstadoSucursal.Location = new Point(367, 62);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(155, 19);
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
            pbxUbiMapa.Location = new Point(73, 37);
            pbxUbiMapa.Name = "pbxUbiMapa";
            pbxUbiMapa.Size = new Size(642, 248);
            pbxUbiMapa.TabIndex = 25;
            pbxUbiMapa.TabStop = false;
            // 
            // pnlUbicacion
            // 
            pnlUbicacion.BackColor = Color.White;
            pnlUbicacion.Controls.Add(lblSalirV);
            pnlUbicacion.Controls.Add(lblLongitud);
            pnlUbicacion.Controls.Add(lblLatitud);
            pnlUbicacion.Controls.Add(picUbi);
            pnlUbicacion.Controls.Add(button1);
            pnlUbicacion.Controls.Add(lblUbi);
            pnlUbicacion.Controls.Add(pbxUbiMapa);
            pnlUbicacion.Location = new Point(12, 12);
            pnlUbicacion.Name = "pnlUbicacion";
            pnlUbicacion.Size = new Size(776, 364);
            pnlUbicacion.TabIndex = 26;
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongitud.Location = new Point(22, 311);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(84, 23);
            lblLongitud.TabIndex = 34;
            lblLongitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLatitud.Location = new Point(22, 288);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(70, 23);
            lblLatitud.TabIndex = 33;
            lblLatitud.Text = "Latitud:";
            // 
            // picUbi
            // 
            picUbi.BackgroundImage = Properties.Resources.pasador_de_ubicacion;
            picUbi.BackgroundImageLayout = ImageLayout.Zoom;
            picUbi.Location = new Point(31, 3);
            picUbi.Name = "picUbi";
            picUbi.Size = new Size(30, 47);
            picUbi.TabIndex = 28;
            picUbi.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 34, 246);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(525, 301);
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
            // textBox1
            // 
            textBox1.Location = new Point(178, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(85, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(554, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(525, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 37;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.White;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(748, 0);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // frmUbicacionSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(810, 554);
            Controls.Add(pnlUbicacion);
            Controls.Add(pnlInformacion);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label lblSalirV;
    }
}