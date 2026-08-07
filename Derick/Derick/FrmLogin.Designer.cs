namespace Derick
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlImagen = new Panel();
            pbImageninicio = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlLogin = new Panel();
            pictureBox3 = new PictureBox();
            lblSalir = new Label();
            lblfinal = new Label();
            btnInisesion = new Button();
            pbojo = new PictureBox();
            txtcontrasena = new TextBox();
            pictureBox4 = new PictureBox();
            lblcontraseña = new Label();
            pbcontraseña = new PictureBox();
            txtusuario = new TextBox();
            lblusuario = new Label();
            pbusuario = new PictureBox();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageninicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcontraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbusuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlImagen
            // 
            pnlImagen.BackColor = Color.FromArgb(17, 17, 17);
            pnlImagen.Controls.Add(pbImageninicio);
            pnlImagen.Controls.Add(pictureBox1);
            pnlImagen.Dock = DockStyle.Left;
            pnlImagen.Location = new Point(0, 0);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(470, 700);
            pnlImagen.TabIndex = 0;
            // 
            // pbImageninicio
            // 
            pbImageninicio.Image = Properties.Resources.Logiin;
            pbImageninicio.Location = new Point(0, 0);
            pbImageninicio.Name = "pbImageninicio";
            pbImageninicio.Size = new Size(470, 700);
            pbImageninicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImageninicio.TabIndex = 1;
            pbImageninicio.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(pictureBox3);
            pnlLogin.Controls.Add(lblSalir);
            pnlLogin.Controls.Add(lblfinal);
            pnlLogin.Controls.Add(btnInisesion);
            pnlLogin.Controls.Add(pbojo);
            pnlLogin.Controls.Add(txtcontrasena);
            pnlLogin.Controls.Add(pictureBox4);
            pnlLogin.Controls.Add(lblcontraseña);
            pnlLogin.Controls.Add(pbcontraseña);
            pnlLogin.Controls.Add(txtusuario);
            pnlLogin.Controls.Add(lblusuario);
            pnlLogin.Controls.Add(pbusuario);
            pnlLogin.Controls.Add(lblTitulo);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlLogin.Location = new Point(470, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(730, 700);
            pnlLogin.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.usuarioooo;
            pictureBox3.Location = new Point(205, 284);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = Color.Red;
            lblSalir.Location = new Point(693, 9);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(25, 24);
            lblSalir.TabIndex = 14;
            lblSalir.Text = "X";
            lblSalir.Click += lblSalir_Click;
            // 
            // lblfinal
            // 
            lblfinal.AutoSize = true;
            lblfinal.ForeColor = SystemColors.AppWorkspace;
            lblfinal.Location = new Point(274, 559);
            lblfinal.Name = "lblfinal";
            lblfinal.Size = new Size(212, 36);
            lblfinal.TabIndex = 13;
            lblfinal.Text = "      DERICK © 2026 · v1.0\r\nSistema de Gestión Interna";
            // 
            // btnInisesion
            // 
            btnInisesion.BackColor = Color.Black;
            btnInisesion.Cursor = Cursors.Hand;
            btnInisesion.ForeColor = SystemColors.Control;
            btnInisesion.Location = new Point(254, 461);
            btnInisesion.Name = "btnInisesion";
            btnInisesion.Size = new Size(261, 37);
            btnInisesion.TabIndex = 11;
            btnInisesion.Text = "Iniciar sesión";
            btnInisesion.UseVisualStyleBackColor = false;
            btnInisesion.Click += btnInisesion_Click;
            // 
            // pbojo
            // 
            pbojo.Cursor = Cursors.Hand;
            pbojo.Image = Properties.Resources.esconder;
            pbojo.Location = new Point(564, 400);
            pbojo.Name = "pbojo";
            pbojo.Size = new Size(25, 24);
            pbojo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbojo.TabIndex = 10;
            pbojo.TabStop = false;
            pbojo.Click += pbojo_Click;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(236, 398);
            txtcontrasena.MaxLength = 15;
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(353, 24);
            txtcontrasena.TabIndex = 9;
            txtcontrasena.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(205, 400);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Location = new Point(236, 357);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(121, 18);
            lblcontraseña.TabIndex = 7;
            lblcontraseña.Text = "CONTRASEÑA";
            // 
            // pbcontraseña
            // 
            pbcontraseña.BackColor = Color.Transparent;
            pbcontraseña.Image = (Image)resources.GetObject("pbcontraseña.Image");
            pbcontraseña.Location = new Point(205, 357);
            pbcontraseña.Name = "pbcontraseña";
            pbcontraseña.Size = new Size(25, 24);
            pbcontraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcontraseña.TabIndex = 6;
            pbcontraseña.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(236, 284);
            txtusuario.MaxLength = 15;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(353, 24);
            txtusuario.TabIndex = 4;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(236, 247);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(82, 18);
            lblusuario.TabIndex = 3;
            lblusuario.Text = "USUARIO";
            // 
            // pbusuario
            // 
            pbusuario.BackColor = Color.Transparent;
            pbusuario.Image = Properties.Resources.usuario;
            pbusuario.Location = new Point(205, 247);
            pbusuario.Name = "pbusuario";
            pbusuario.Size = new Size(25, 24);
            pbusuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbusuario.TabIndex = 2;
            pbusuario.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(274, 155);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "DERICK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2026_07_12_141335;
            pictureBox2.Location = new Point(321, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlLogin);
            Controls.Add(pnlImagen);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1194, 538);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImageninicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcontraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbusuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlImagen;
        private Panel pnlLogin;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private PictureBox pictureBox2;
        private PictureBox pbusuario;
        private Label lblusuario;
        private TextBox txtusuario;
        private PictureBox pictureBox4;
        private Label lblcontraseña;
        private PictureBox pbcontraseña;
        private PictureBox pbojo;
        private TextBox txtcontrasena;
        private Button btnInisesion;
        private PictureBox pbImageninicio;
        private Label lblfinal;
        private Label lblSalir;
        private PictureBox pictureBox3;
    }
}
