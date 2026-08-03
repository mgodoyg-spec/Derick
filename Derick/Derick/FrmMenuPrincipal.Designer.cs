namespace Derick
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            btnreportes = new Button();
            imlBotones = new ImageList(components);
            btnventas = new Button();
            btnproductos = new Button();
            btninicio = new Button();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            pnlcontenido = new Panel();
            pnlIndicador = new Panel();
            pnlPerfil = new Panel();
            lblFlecha = new Label();
            lblusuario = new Label();
            pbusuario = new PictureBox();
            btnempleados = new Button();
            btnsucursales = new Button();
            lblSalir = new Label();
            cmsMenuPerfil = new ContextMenuStrip(components);
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            pnlMostrar = new Panel();
            pnlMostrarForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlcontenido.SuspendLayout();
            pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbusuario).BeginInit();
            cmsMenuPerfil.SuspendLayout();
            pnlMostrar.SuspendLayout();
            SuspendLayout();
            // 
            // btnreportes
            // 
            btnreportes.BackColor = Color.Black;
            btnreportes.Cursor = Cursors.Hand;
            btnreportes.FlatAppearance.BorderSize = 0;
            btnreportes.FlatStyle = FlatStyle.Flat;
            btnreportes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreportes.ForeColor = Color.White;
            btnreportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnreportes.ImageIndex = 5;
            btnreportes.ImageList = imlBotones;
            btnreportes.Location = new Point(783, 7);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(113, 37);
            btnreportes.TabIndex = 16;
            btnreportes.Text = "Reportes";
            btnreportes.TextAlign = ContentAlignment.MiddleRight;
            btnreportes.UseVisualStyleBackColor = false;
            btnreportes.Click += btnreportes_Click;
            // 
            // imlBotones
            // 
            imlBotones.ColorDepth = ColorDepth.Depth32Bit;
            imlBotones.ImageStream = (ImageListStreamer)resources.GetObject("imlBotones.ImageStream");
            imlBotones.TransparentColor = Color.Transparent;
            imlBotones.Images.SetKeyName(0, "Captura de pantalla 2026-07-13 003501.png");
            imlBotones.Images.SetKeyName(1, "Captura de pantalla 2026-07-13 001608.png");
            imlBotones.Images.SetKeyName(2, "Captura de pantalla 2026-07-13 001756.png");
            imlBotones.Images.SetKeyName(3, "Captura de pantalla 2026-07-13 002233.png");
            imlBotones.Images.SetKeyName(4, "Captura de pantalla 2026-07-13 002707.png");
            imlBotones.Images.SetKeyName(5, "Captura de pantalla 2026-07-13 002933.png");
            imlBotones.Images.SetKeyName(6, "Captura de pantalla 2026-07-12 233737.png");
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.Black;
            btnventas.Cursor = Cursors.Hand;
            btnventas.FlatAppearance.BorderSize = 0;
            btnventas.FlatStyle = FlatStyle.Flat;
            btnventas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnventas.ForeColor = Color.White;
            btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnventas.ImageIndex = 4;
            btnventas.ImageList = imlBotones;
            btnventas.Location = new Point(681, 6);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(96, 37);
            btnventas.TabIndex = 15;
            btnventas.Text = "Ventas";
            btnventas.TextAlign = ContentAlignment.MiddleRight;
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.Black;
            btnproductos.Cursor = Cursors.Hand;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproductos.ForeColor = Color.White;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.ImageIndex = 1;
            btnproductos.ImageList = imlBotones;
            btnproductos.Location = new Point(286, 6);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(123, 37);
            btnproductos.TabIndex = 12;
            btnproductos.Text = "Productos";
            btnproductos.TextAlign = ContentAlignment.MiddleRight;
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click;
            // 
            // btninicio
            // 
            btninicio.BackColor = Color.Black;
            btninicio.Cursor = Cursors.Hand;
            btninicio.FlatAppearance.BorderSize = 0;
            btninicio.FlatStyle = FlatStyle.Flat;
            btninicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninicio.ForeColor = Color.White;
            btninicio.ImageAlign = ContentAlignment.MiddleLeft;
            btninicio.ImageIndex = 0;
            btninicio.ImageList = imlBotones;
            btninicio.Location = new Point(189, 5);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(91, 37);
            btninicio.TabIndex = 11;
            btninicio.Text = "Inicio";
            btninicio.TextAlign = ContentAlignment.MiddleRight;
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(71, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "DERICK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.DerickRecortado;
            pictureBox2.Location = new Point(26, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pnlcontenido
            // 
            pnlcontenido.BackColor = Color.Black;
            pnlcontenido.Controls.Add(pnlIndicador);
            pnlcontenido.Controls.Add(pnlPerfil);
            pnlcontenido.Controls.Add(btnreportes);
            pnlcontenido.Controls.Add(btnventas);
            pnlcontenido.Controls.Add(btnempleados);
            pnlcontenido.Controls.Add(lblTitulo);
            pnlcontenido.Controls.Add(btnsucursales);
            pnlcontenido.Controls.Add(lblSalir);
            pnlcontenido.Controls.Add(btnproductos);
            pnlcontenido.Controls.Add(pictureBox2);
            pnlcontenido.Controls.Add(btninicio);
            pnlcontenido.Dock = DockStyle.Top;
            pnlcontenido.Location = new Point(0, 0);
            pnlcontenido.Name = "pnlcontenido";
            pnlcontenido.Size = new Size(1200, 49);
            pnlcontenido.TabIndex = 1;
            // 
            // pnlIndicador
            // 
            pnlIndicador.BackColor = Color.Blue;
            pnlIndicador.Location = new Point(189, 45);
            pnlIndicador.Name = "pnlIndicador";
            pnlIndicador.Size = new Size(91, 3);
            pnlIndicador.TabIndex = 18;
            // 
            // pnlPerfil
            // 
            pnlPerfil.Controls.Add(lblFlecha);
            pnlPerfil.Controls.Add(lblusuario);
            pnlPerfil.Controls.Add(pbusuario);
            pnlPerfil.Location = new Point(971, 0);
            pnlPerfil.Name = "pnlPerfil";
            pnlPerfil.Size = new Size(172, 49);
            pnlPerfil.TabIndex = 17;
            pnlPerfil.Click += pnlPerfil_Click;
            // 
            // lblFlecha
            // 
            lblFlecha.AutoSize = true;
            lblFlecha.Cursor = Cursors.Hand;
            lblFlecha.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFlecha.ForeColor = SystemColors.ButtonHighlight;
            lblFlecha.Location = new Point(138, 20);
            lblFlecha.Name = "lblFlecha";
            lblFlecha.Size = new Size(17, 13);
            lblFlecha.TabIndex = 2;
            lblFlecha.Text = "▼";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Cursor = Cursors.Hand;
            lblusuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(57, 14);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(57, 20);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "admin";
            lblusuario.Click += pnlPerfil_Click;
            // 
            // pbusuario
            // 
            pbusuario.Cursor = Cursors.Hand;
            pbusuario.Image = Properties.Resources.UsuarioNegro;
            pbusuario.Location = new Point(5, 3);
            pbusuario.Name = "pbusuario";
            pbusuario.Size = new Size(46, 44);
            pbusuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbusuario.TabIndex = 0;
            pbusuario.TabStop = false;
            pbusuario.Click += pnlPerfil_Click;
            // 
            // btnempleados
            // 
            btnempleados.BackColor = Color.Black;
            btnempleados.Cursor = Cursors.Hand;
            btnempleados.FlatAppearance.BorderSize = 0;
            btnempleados.FlatStyle = FlatStyle.Flat;
            btnempleados.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnempleados.ForeColor = Color.White;
            btnempleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnempleados.ImageIndex = 3;
            btnempleados.ImageList = imlBotones;
            btnempleados.Location = new Point(548, 7);
            btnempleados.Name = "btnempleados";
            btnempleados.Size = new Size(127, 37);
            btnempleados.TabIndex = 14;
            btnempleados.Text = "Empleados\r\n";
            btnempleados.TextAlign = ContentAlignment.MiddleRight;
            btnempleados.UseVisualStyleBackColor = false;
            btnempleados.Click += btnempleados_Click;
            // 
            // btnsucursales
            // 
            btnsucursales.BackColor = Color.Black;
            btnsucursales.Cursor = Cursors.Hand;
            btnsucursales.FlatAppearance.BorderSize = 0;
            btnsucursales.FlatStyle = FlatStyle.Flat;
            btnsucursales.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsucursales.ForeColor = Color.White;
            btnsucursales.ImageAlign = ContentAlignment.MiddleLeft;
            btnsucursales.ImageIndex = 2;
            btnsucursales.ImageList = imlBotones;
            btnsucursales.Location = new Point(415, 8);
            btnsucursales.Name = "btnsucursales";
            btnsucursales.Size = new Size(127, 37);
            btnsucursales.TabIndex = 13;
            btnsucursales.Text = "Sucursales";
            btnsucursales.TextAlign = ContentAlignment.MiddleRight;
            btnsucursales.UseVisualStyleBackColor = false;
            btnsucursales.Click += btnsucursales_Click;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = Color.Red;
            lblSalir.Location = new Point(1172, 10);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(25, 24);
            lblSalir.TabIndex = 7;
            lblSalir.Text = "X";
            lblSalir.Click += lblSalir_Click;
            // 
            // cmsMenuPerfil
            // 
            cmsMenuPerfil.ImageScalingSize = new Size(20, 20);
            cmsMenuPerfil.Items.AddRange(new ToolStripItem[] { miPerfilToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            cmsMenuPerfil.Name = "contextMenuStrip1";
            cmsMenuPerfil.Size = new Size(148, 56);
            cmsMenuPerfil.Closed += cmsMenuPerfil_Closed;
            // 
            // miPerfilToolStripMenuItem
            // 
            miPerfilToolStripMenuItem.Image = Properties.Resources.person_icon_31846;
            miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            miPerfilToolStripMenuItem.Size = new Size(147, 26);
            miPerfilToolStripMenuItem.Text = "Mi Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Image = Properties.Resources.CerrarSesionn;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(147, 26);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // pnlMostrar
            // 
            pnlMostrar.BackColor = Color.White;
            pnlMostrar.Controls.Add(pnlMostrarForm);
            pnlMostrar.Controls.Add(pnlcontenido);
            pnlMostrar.Dock = DockStyle.Fill;
            pnlMostrar.Location = new Point(0, 0);
            pnlMostrar.Name = "pnlMostrar";
            pnlMostrar.Size = new Size(1200, 700);
            pnlMostrar.TabIndex = 1;
            // 
            // pnlMostrarForm
            // 
            pnlMostrarForm.Dock = DockStyle.Fill;
            pnlMostrarForm.Location = new Point(0, 49);
            pnlMostrarForm.Name = "pnlMostrarForm";
            pnlMostrarForm.Size = new Size(1200, 651);
            pnlMostrarForm.TabIndex = 2;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlMostrar);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1200, 700);
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlcontenido.ResumeLayout(false);
            pnlcontenido.PerformLayout();
            pnlPerfil.ResumeLayout(false);
            pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbusuario).EndInit();
            cmsMenuPerfil.ResumeLayout(false);
            pnlMostrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnreportes;
        private Button btnventas;
        private Button btnproductos;
        private Button btninicio;
        private Label lblTitulo;
        private PictureBox pictureBox2;
        private Panel pnlcontenido;
        private PictureBox pbusuario;
        private Panel pnlMostrar;
        private Label lblusuario;
        private Label lblSalir;
        private Panel pnlMostrarForm;
        private ImageList imlBotones;
        private Panel pnlPerfil;
        private ContextMenuStrip cmsMenuPerfil;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private Label lblFlecha;
        private Panel pnlIndicador;
        private Button btnempleados;
        private Button btnsucursales;
    }
}