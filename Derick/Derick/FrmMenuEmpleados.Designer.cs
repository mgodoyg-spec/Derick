namespace Derick
{
    partial class FrmMenuEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpleados));
            imlBotones = new ImageList(components);
            cmsMenuPerfil = new ContextMenuStrip(components);
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            pnlMostrar = new Panel();
            pnlMostrarForm = new Panel();
            pnlContenido = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlPerfil = new Panel();
            lblFlecha = new Label();
            lblusuario = new Label();
            pictureBox3 = new PictureBox();
            pnlIndicador = new Panel();
            btnreportes = new Button();
            btninicio = new Button();
            btnproductos = new Button();
            btnventas = new Button();
            cmsMenuPerfil.SuspendLayout();
            pnlMostrar.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            miPerfilToolStripMenuItem.Click += miPerfilToolStripMenuItem_Click;
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
            pnlMostrar.Controls.Add(pnlMostrarForm);
            pnlMostrar.Controls.Add(pnlContenido);
            pnlMostrar.Dock = DockStyle.Fill;
            pnlMostrar.Location = new Point(0, 0);
            pnlMostrar.Name = "pnlMostrar";
            pnlMostrar.Size = new Size(1370, 700);
            pnlMostrar.TabIndex = 1;
            // 
            // pnlMostrarForm
            // 
            pnlMostrarForm.BackColor = Color.White;
            pnlMostrarForm.Dock = DockStyle.Fill;
            pnlMostrarForm.Location = new Point(170, 0);
            pnlMostrarForm.Name = "pnlMostrarForm";
            pnlMostrarForm.Size = new Size(1200, 700);
            pnlMostrarForm.TabIndex = 22;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.Black;
            pnlContenido.Controls.Add(label1);
            pnlContenido.Controls.Add(pictureBox1);
            pnlContenido.Controls.Add(pnlPerfil);
            pnlContenido.Controls.Add(pnlIndicador);
            pnlContenido.Controls.Add(btnreportes);
            pnlContenido.Controls.Add(btninicio);
            pnlContenido.Controls.Add(btnproductos);
            pnlContenido.Controls.Add(btnventas);
            pnlContenido.Dock = DockStyle.Left;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(170, 700);
            pnlContenido.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "DERICK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DerickRecortado;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlPerfil
            // 
            pnlPerfil.Controls.Add(lblFlecha);
            pnlPerfil.Controls.Add(lblusuario);
            pnlPerfil.Controls.Add(pictureBox3);
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
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.UsuarioNegro;
            pictureBox3.Location = new Point(3, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pnlPerfil_Click;
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
            btnreportes.Location = new Point(12, 201);
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
            btnventas.Location = new Point(12, 158);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(96, 37);
            btnventas.TabIndex = 15;
            btnventas.Text = "Ventas";
            btnventas.TextAlign = ContentAlignment.MiddleRight;
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // FrmMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 700);
            Controls.Add(pnlMostrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1370, 700);
            MinimumSize = new Size(1200, 700);
            Name = "FrmMenuEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuEmpleados";
            Load += FrmMenuEmpleados_Load;
            cmsMenuPerfil.ResumeLayout(false);
            pnlMostrar.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlPerfil.ResumeLayout(false);
            pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imlBotones;
        private ContextMenuStrip cmsMenuPerfil;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private Panel pnlMostrar;
        private Panel pnlMostrarForm;
        private Panel pnlContenido;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlPerfil;
        private Label lblFlecha;
        private Label lblusuario;
        private PictureBox pictureBox3;
        private Panel pnlIndicador;
        private Button btnreportes;
        private Button btninicio;
        private Button btnproductos;
        private Button btnventas;
    }
}