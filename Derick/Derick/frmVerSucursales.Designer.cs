namespace Derick
{
    partial class frmVerSucursales
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
            lblSalirV = new Label();
            lblTitulo = new Label();
            lblTEncargadoSucursal = new Label();
            lblTCorreo = new Label();
            lbltelefono = new Label();
            lblTDireccion = new Label();
            lblTCiudad = new Label();
            lblNombreSucursal = new Label();
            pbxImagenSucursal = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblEstado = new Label();
            lblEncargado = new Label();
            lblCorreo = new Label();
            lblTel = new Label();
            lblDireccion = new Label();
            lblCiudad = new Label();
            lblFecha = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxImagenSucursal).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(578, 0);
            lblSalirV.Margin = new Padding(4, 0, 4, 0);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(13, 154, 64);
            lblTitulo.Location = new Point(0, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 26);
            lblTitulo.TabIndex = 31;
            lblTitulo.Text = "Información de la sucursal";
            // 
            // lblTEncargadoSucursal
            // 
            lblTEncargadoSucursal.AutoSize = true;
            lblTEncargadoSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTEncargadoSucursal.ForeColor = Color.Black;
            lblTEncargadoSucursal.Location = new Point(18, 540);
            lblTEncargadoSucursal.Margin = new Padding(4, 0, 4, 0);
            lblTEncargadoSucursal.Name = "lblTEncargadoSucursal";
            lblTEncargadoSucursal.Size = new Size(207, 23);
            lblTEncargadoSucursal.TabIndex = 52;
            lblTEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // lblTCorreo
            // 
            lblTCorreo.AutoSize = true;
            lblTCorreo.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTCorreo.ForeColor = Color.Black;
            lblTCorreo.Location = new Point(17, 495);
            lblTCorreo.Margin = new Padding(4, 0, 4, 0);
            lblTCorreo.Name = "lblTCorreo";
            lblTCorreo.Size = new Size(163, 23);
            lblTCorreo.TabIndex = 50;
            lblTCorreo.Text = "Correo electrónico:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefono.ForeColor = Color.Black;
            lbltelefono.Location = new Point(18, 449);
            lbltelefono.Margin = new Padding(4, 0, 4, 0);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(83, 23);
            lbltelefono.TabIndex = 48;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblTDireccion
            // 
            lblTDireccion.AutoSize = true;
            lblTDireccion.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTDireccion.ForeColor = Color.Black;
            lblTDireccion.Location = new Point(17, 403);
            lblTDireccion.Margin = new Padding(4, 0, 4, 0);
            lblTDireccion.Name = "lblTDireccion";
            lblTDireccion.Size = new Size(90, 23);
            lblTDireccion.TabIndex = 46;
            lblTDireccion.Text = "Dirección:";
            // 
            // lblTCiudad
            // 
            lblTCiudad.AutoSize = true;
            lblTCiudad.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTCiudad.ForeColor = Color.Black;
            lblTCiudad.Location = new Point(17, 364);
            lblTCiudad.Margin = new Padding(4, 0, 4, 0);
            lblTCiudad.Name = "lblTCiudad";
            lblTCiudad.Size = new Size(69, 23);
            lblTCiudad.TabIndex = 44;
            lblTCiudad.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.ForeColor = Color.Black;
            lblNombreSucursal.Location = new Point(4, 12);
            lblNombreSucursal.Margin = new Padding(4, 0, 4, 0);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(191, 23);
            lblNombreSucursal.TabIndex = 42;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // pbxImagenSucursal
            // 
            pbxImagenSucursal.Location = new Point(107, 40);
            pbxImagenSucursal.Margin = new Padding(4, 5, 4, 5);
            pbxImagenSucursal.Name = "pbxImagenSucursal";
            pbxImagenSucursal.Size = new Size(346, 247);
            pbxImagenSucursal.TabIndex = 53;
            pbxImagenSucursal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(384, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 54;
            label1.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(17, 325);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 56;
            label3.Text = "Fecha de registro:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(lblEncargado);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblTel);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblCiudad);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(lblTCiudad);
            panel1.Controls.Add(lblNombreSucursal);
            panel1.Controls.Add(pbxImagenSucursal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTEncargadoSucursal);
            panel1.Controls.Add(lbltelefono);
            panel1.Controls.Add(lblTCorreo);
            panel1.Controls.Add(lblTDireccion);
            panel1.Location = new Point(13, 58);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 577);
            panel1.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(293, 325);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 66;
            label2.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(368, 325);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(14, 23);
            lblEstado.TabIndex = 65;
            lblEstado.Text = "l";
            // 
            // lblEncargado
            // 
            lblEncargado.AutoSize = true;
            lblEncargado.Location = new Point(224, 540);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(0, 23);
            lblEncargado.TabIndex = 64;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(180, 495);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(0, 23);
            lblCorreo.TabIndex = 63;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(100, 449);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(0, 23);
            lblTel.TabIndex = 62;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(107, 407);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 19);
            lblDireccion.TabIndex = 61;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(86, 364);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(0, 23);
            lblCiudad.TabIndex = 60;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(169, 325);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 23);
            lblFecha.TabIndex = 59;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(214, 377);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 23);
            lblNombre.TabIndex = 58;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(453, 12);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(0, 23);
            lblCodigo.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 14);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // frmVerSucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(600, 640);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Controls.Add(lblSalirV);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmVerSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVerSucursales";
            Load += frmVerSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagenSucursal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalirV;
        private Label lblTitulo;
        private Label lblTEncargadoSucursal;
        private Label lblTCorreo;
        private Label lbltelefono;
        private Label lblTDireccion;
        private Label lblTCiudad;
        private Label lblNombreSucursal;
        private PictureBox pbxImagenSucursal;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label lblCiudad;
        private Label lblFecha;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblDireccion;
        private Label lblEstado;
        private Label lblEncargado;
        private Label lblCorreo;
        private Label lblTel;
        private Label label2;
        private PictureBox pictureBox1;
    }
}