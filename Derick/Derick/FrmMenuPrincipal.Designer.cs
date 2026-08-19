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
            imlBotones = new ImageList(components);
            cmsMenuPerfil = new ContextMenuStrip(components);
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            pnlMostrar = new Panel();
            pnlMostrarForm = new Panel();
            pnlcontenido = new Panel();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            pnlPerfil = new Panel();
            lblFlecha = new Label();
            lblusuario = new Label();
            pbusuario = new PictureBox();
            pnlIndicador = new Panel();
            btnreportes = new Button();
            btninicio = new Button();
            btnproductos = new Button();
            btnventas = new Button();
            btnsucursales = new Button();
            btnempleados = new Button();
            cmsPromProv = new ContextMenuStrip(components);
            promocionesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            cmsMenuPerfil.SuspendLayout();
            pnlMostrar.SuspendLayout();
            pnlcontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbusuario).BeginInit();
            cmsPromProv.SuspendLayout();
            SuspendLayout();
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
            pnlMostrar.Size = new Size(1370, 700);
            pnlMostrar.TabIndex = 1;
            // 
            // pnlMostrarForm
            // 
            pnlMostrarForm.Location = new Point(173, 0);
            pnlMostrarForm.Name = "pnlMostrarForm";
            pnlMostrarForm.Size = new Size(1186, 700);
            pnlMostrarForm.TabIndex = 21;
            // 
            // pnlcontenido
            // 
            pnlcontenido.BackColor = Color.Black;
            pnlcontenido.Controls.Add(lblTitulo);
            pnlcontenido.Controls.Add(pictureBox2);
            pnlcontenido.Controls.Add(pnlPerfil);
            pnlcontenido.Controls.Add(pnlIndicador);
            pnlcontenido.Controls.Add(btnreportes);
            pnlcontenido.Controls.Add(btninicio);
            pnlcontenido.Controls.Add(btnproductos);
            pnlcontenido.Controls.Add(btnventas);
            pnlcontenido.Controls.Add(btnsucursales);
            pnlcontenido.Controls.Add(btnempleados);
            pnlcontenido.Location = new Point(0, 0);
            pnlcontenido.Name = "pnlcontenido";
            pnlcontenido.Size = new Size(170, 700);
            pnlcontenido.TabIndex = 20;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(57, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "DERICK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.DerickRecortado;
            pictureBox2.Location = new Point(12, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pnlPerfil
            // 
            pnlPerfil.Controls.Add(lblFlecha);
            pnlPerfil.Controls.Add(lblusuario);
            pnlPerfil.Controls.Add(pbusuario);
            pnlPerfil.Location = new Point(0, 593);
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
            lblFlecha.Click += pnlPerfil_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Cursor = Cursors.Hand;
            lblusuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(45, 15);
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
            pbusuario.Location = new Point(3, 8);
            pbusuario.Name = "pbusuario";
            pbusuario.Size = new Size(40, 38);
            pbusuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbusuario.TabIndex = 0;
            pbusuario.TabStop = false;
            // 
            // pnlIndicador
            // 
            pnlIndicador.BackColor = Color.Blue;
            pnlIndicador.Location = new Point(12, 106);
            pnlIndicador.Name = "pnlIndicador";
            pnlIndicador.Size = new Size(91, 3);
            pnlIndicador.TabIndex = 18;
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
            btnreportes.Location = new Point(12, 287);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(113, 37);
            btnreportes.TabIndex = 16;
            btnreportes.Text = "Reportes";
            btnreportes.TextAlign = ContentAlignment.MiddleRight;
            btnreportes.UseVisualStyleBackColor = false;
            btnreportes.Click += btnreportes_Click;
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
            btninicio.Location = new Point(12, 63);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(91, 37);
            btninicio.TabIndex = 11;
            btninicio.Text = "Inicio";
            btninicio.TextAlign = ContentAlignment.MiddleRight;
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click;
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
            btnproductos.Location = new Point(12, 115);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(123, 37);
            btnproductos.TabIndex = 12;
            btnproductos.Text = "Productos";
            btnproductos.TextAlign = ContentAlignment.MiddleRight;
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click;
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
            btnventas.Location = new Point(12, 244);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(96, 37);
            btnventas.TabIndex = 15;
            btnventas.Text = "Ventas";
            btnventas.TextAlign = ContentAlignment.MiddleRight;
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
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
            btnsucursales.Location = new Point(12, 158);
            btnsucursales.Name = "btnsucursales";
            btnsucursales.Size = new Size(127, 37);
            btnsucursales.TabIndex = 13;
            btnsucursales.Text = "Sucursales";
            btnsucursales.TextAlign = ContentAlignment.MiddleRight;
            btnsucursales.UseVisualStyleBackColor = false;
            btnsucursales.Click += btnsucursales_Click;
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
            btnempleados.Location = new Point(12, 201);
            btnempleados.Name = "btnempleados";
            btnempleados.Size = new Size(127, 37);
            btnempleados.TabIndex = 14;
            btnempleados.Text = "Empleados\r\n";
            btnempleados.TextAlign = ContentAlignment.MiddleRight;
            btnempleados.UseVisualStyleBackColor = false;
            btnempleados.Click += btnempleados_Click;
            // 
            // cmsPromProv
            // 
            cmsPromProv.Items.AddRange(new ToolStripItem[] { promocionesToolStripMenuItem, proveedoresToolStripMenuItem, categoríasToolStripMenuItem });
            cmsPromProv.Name = "contextMenuStrip1";
            cmsPromProv.Size = new Size(181, 92);
            // 
            // promocionesToolStripMenuItem
            // 
            promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            promocionesToolStripMenuItem.Size = new Size(180, 22);
            promocionesToolStripMenuItem.Text = "Promociones";
            promocionesToolStripMenuItem.Click += promocionesToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // categoríasToolStripMenuItem
            // 
            categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            categoríasToolStripMenuItem.Size = new Size(180, 22);
            categoríasToolStripMenuItem.Text = "Categorías";
            categoríasToolStripMenuItem.Click += categoríasToolStripMenuItem_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1370, 700);
            Controls.Add(pnlMostrar);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1450, 700);
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMenuPrincipal_Load;
            cmsMenuPerfil.ResumeLayout(false);
            pnlMostrar.ResumeLayout(false);
            pnlcontenido.ResumeLayout(false);
            pnlcontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlPerfil.ResumeLayout(false);
            pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbusuario).EndInit();
            cmsPromProv.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMostrar;
        private ImageList imlBotones;
        private ContextMenuStrip cmsMenuPerfil;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private Panel pnlMostrarForm;
        private Panel pnlcontenido;
        private Panel pnlPerfil;
        private Label lblFlecha;
        private Label lblusuario;
        private PictureBox pbusuario;
        private Panel pnlIndicador;
        private PictureBox pictureBox2;
        private Label lblTitulo;
        private Button btnreportes;
        private Button btninicio;
        private Button btnproductos;
        private Button btnventas;
        private Button btnsucursales;
        private Button btnempleados;
        private ContextMenuStrip cmsPromProv;
        private ToolStripMenuItem promocionesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem categoríasToolStripMenuItem;
    }
}