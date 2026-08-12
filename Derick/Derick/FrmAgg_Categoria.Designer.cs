namespace Derick
{
    partial class FrmAgg_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgg_Categoria));
            pnlagg_ctg = new Panel();
            btn_grd = new Button();
            txt1 = new TextBox();
            lble_5 = new Label();
            lbl_ry1 = new Label();
            cmb_ctg = new ComboBox();
            lble_4 = new Label();
            btn_abajo = new Button();
            btn_arriba = new Button();
            lbl_icono = new Label();
            lble_3 = new Label();
            txt_ctg1 = new TextBox();
            lble_2 = new Label();
            pnl1_ctg = new Panel();
            btn_cls = new PictureBox();
            lble_1 = new Label();
            pic1_e = new PictureBox();
            ctmCategoria = new ContextMenuStrip(components);
            imgCategoria = new ImageList(components);
            pnlagg_ctg.SuspendLayout();
            pnl1_ctg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).BeginInit();
            SuspendLayout();
            // 
            // pnlagg_ctg
            // 
            pnlagg_ctg.BackColor = Color.FromArgb(244, 246, 249);
            pnlagg_ctg.Controls.Add(btn_grd);
            pnlagg_ctg.Controls.Add(txt1);
            pnlagg_ctg.Controls.Add(lble_5);
            pnlagg_ctg.Controls.Add(lbl_ry1);
            pnlagg_ctg.Controls.Add(cmb_ctg);
            pnlagg_ctg.Controls.Add(lble_4);
            pnlagg_ctg.Controls.Add(btn_abajo);
            pnlagg_ctg.Controls.Add(btn_arriba);
            pnlagg_ctg.Controls.Add(lbl_icono);
            pnlagg_ctg.Controls.Add(lble_3);
            pnlagg_ctg.Controls.Add(txt_ctg1);
            pnlagg_ctg.Controls.Add(lble_2);
            pnlagg_ctg.Controls.Add(pnl1_ctg);
            pnlagg_ctg.Dock = DockStyle.Fill;
            pnlagg_ctg.Location = new Point(0, 0);
            pnlagg_ctg.Margin = new Padding(3, 2, 3, 2);
            pnlagg_ctg.Name = "pnlagg_ctg";
            pnlagg_ctg.Size = new Size(555, 307);
            pnlagg_ctg.TabIndex = 0;
            // 
            // btn_grd
            // 
            btn_grd.BackColor = Color.FromArgb(0, 102, 255);
            btn_grd.Cursor = Cursors.Hand;
            btn_grd.FlatAppearance.BorderSize = 0;
            btn_grd.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_grd.ForeColor = Color.White;
            btn_grd.Image = (Image)resources.GetObject("btn_grd.Image");
            btn_grd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_grd.Location = new Point(367, 256);
            btn_grd.Margin = new Padding(3, 2, 3, 2);
            btn_grd.Name = "btn_grd";
            btn_grd.Size = new Size(178, 42);
            btn_grd.TabIndex = 40;
            btn_grd.Text = "    Guardar categoría";
            btn_grd.UseVisualStyleBackColor = false;
            btn_grd.Click += btn_grd_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(294, 86);
            txt1.Margin = new Padding(3, 2, 3, 2);
            txt1.MaxLength = 250;
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.PlaceholderText = "Escriba una descripción de la categoria...";
            txt1.Size = new Size(252, 125);
            txt1.TabIndex = 39;
            // 
            // lble_5
            // 
            lble_5.AutoSize = true;
            lble_5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble_5.Location = new Point(294, 68);
            lble_5.Name = "lble_5";
            lble_5.Size = new Size(187, 18);
            lble_5.TabIndex = 38;
            lble_5.Text = "Descripción de la categoría";
            // 
            // lbl_ry1
            // 
            lbl_ry1.BackColor = Color.Gray;
            lbl_ry1.Location = new Point(271, 68);
            lbl_ry1.Name = "lbl_ry1";
            lbl_ry1.Size = new Size(1, 191);
            lbl_ry1.TabIndex = 37;
            // 
            // cmb_ctg
            // 
            cmb_ctg.FormattingEnabled = true;
            cmb_ctg.Items.AddRange(new object[] { "Activo", "Desabilitado" });
            cmb_ctg.Location = new Point(10, 189);
            cmb_ctg.Margin = new Padding(3, 2, 3, 2);
            cmb_ctg.Name = "cmb_ctg";
            cmb_ctg.Size = new Size(239, 23);
            cmb_ctg.TabIndex = 36;
            // 
            // lble_4
            // 
            lble_4.AutoSize = true;
            lble_4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble_4.Location = new Point(10, 170);
            lble_4.Name = "lble_4";
            lble_4.Size = new Size(55, 18);
            lble_4.TabIndex = 35;
            lble_4.Text = "Estado";
            // 
            // btn_abajo
            // 
            btn_abajo.BackgroundImage = (Image)resources.GetObject("btn_abajo.BackgroundImage");
            btn_abajo.BackgroundImageLayout = ImageLayout.Zoom;
            btn_abajo.Cursor = Cursors.Hand;
            btn_abajo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_abajo.Location = new Point(226, 139);
            btn_abajo.Margin = new Padding(3, 2, 3, 2);
            btn_abajo.Name = "btn_abajo";
            btn_abajo.Size = new Size(24, 20);
            btn_abajo.TabIndex = 34;
            btn_abajo.UseVisualStyleBackColor = true;
            btn_abajo.Click += btn_abajo_Click;
            // 
            // btn_arriba
            // 
            btn_arriba.BackgroundImage = (Image)resources.GetObject("btn_arriba.BackgroundImage");
            btn_arriba.BackgroundImageLayout = ImageLayout.Zoom;
            btn_arriba.Cursor = Cursors.Hand;
            btn_arriba.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_arriba.Location = new Point(226, 139);
            btn_arriba.Margin = new Padding(3, 2, 3, 2);
            btn_arriba.Name = "btn_arriba";
            btn_arriba.Size = new Size(24, 20);
            btn_arriba.TabIndex = 33;
            btn_arriba.UseVisualStyleBackColor = true;
            btn_arriba.Visible = false;
            btn_arriba.Click += btn_arriba_Click;
            // 
            // lbl_icono
            // 
            lbl_icono.BackColor = Color.White;
            lbl_icono.BorderStyle = BorderStyle.Fixed3D;
            lbl_icono.FlatStyle = FlatStyle.Flat;
            lbl_icono.ForeColor = Color.Gray;
            lbl_icono.ImageAlign = ContentAlignment.MiddleRight;
            lbl_icono.Location = new Point(10, 139);
            lbl_icono.Name = "lbl_icono";
            lbl_icono.Size = new Size(210, 20);
            lbl_icono.TabIndex = 32;
            // 
            // lble_3
            // 
            lble_3.AutoSize = true;
            lble_3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble_3.Location = new Point(10, 122);
            lble_3.Name = "lble_3";
            lble_3.Size = new Size(145, 18);
            lble_3.TabIndex = 4;
            lble_3.Text = "Ícono de la categoría";
            // 
            // txt_ctg1
            // 
            txt_ctg1.Location = new Point(10, 86);
            txt_ctg1.Margin = new Padding(3, 2, 3, 2);
            txt_ctg1.MaxLength = 30;
            txt_ctg1.Name = "txt_ctg1";
            txt_ctg1.PlaceholderText = "Ej: Busos";
            txt_ctg1.Size = new Size(239, 23);
            txt_ctg1.TabIndex = 3;
            txt_ctg1.KeyPress += txt_ctg1_KeyPress;
            // 
            // lble_2
            // 
            lble_2.AutoSize = true;
            lble_2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble_2.Location = new Point(10, 68);
            lble_2.Name = "lble_2";
            lble_2.Size = new Size(162, 18);
            lble_2.TabIndex = 2;
            lble_2.Text = "Nombre de la categoría";
            // 
            // pnl1_ctg
            // 
            pnl1_ctg.BackColor = Color.FromArgb(9, 22, 50);
            pnl1_ctg.BorderStyle = BorderStyle.Fixed3D;
            pnl1_ctg.Controls.Add(btn_cls);
            pnl1_ctg.Controls.Add(lble_1);
            pnl1_ctg.Controls.Add(pic1_e);
            pnl1_ctg.Dock = DockStyle.Top;
            pnl1_ctg.Location = new Point(0, 0);
            pnl1_ctg.Margin = new Padding(3, 2, 3, 2);
            pnl1_ctg.Name = "pnl1_ctg";
            pnl1_ctg.Size = new Size(555, 51);
            pnl1_ctg.TabIndex = 0;
            // 
            // btn_cls
            // 
            btn_cls.Cursor = Cursors.Hand;
            btn_cls.Image = (Image)resources.GetObject("btn_cls.Image");
            btn_cls.Location = new Point(515, 12);
            btn_cls.Margin = new Padding(3, 2, 3, 2);
            btn_cls.Name = "btn_cls";
            btn_cls.Size = new Size(27, 23);
            btn_cls.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cls.TabIndex = 41;
            btn_cls.TabStop = false;
            btn_cls.Click += btn_cls_Click;
            // 
            // lble_1
            // 
            lble_1.AutoSize = true;
            lble_1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lble_1.ForeColor = Color.White;
            lble_1.Location = new Point(68, 14);
            lble_1.Name = "lble_1";
            lble_1.Size = new Size(160, 24);
            lble_1.TabIndex = 2;
            lble_1.Text = "Agregar categoría";
            // 
            // pic1_e
            // 
            pic1_e.Image = (Image)resources.GetObject("pic1_e.Image");
            pic1_e.Location = new Point(3, 2);
            pic1_e.Margin = new Padding(3, 2, 3, 2);
            pic1_e.Name = "pic1_e";
            pic1_e.Size = new Size(60, 41);
            pic1_e.SizeMode = PictureBoxSizeMode.Zoom;
            pic1_e.TabIndex = 1;
            pic1_e.TabStop = false;
            // 
            // ctmCategoria
            // 
            ctmCategoria.AutoClose = false;
            ctmCategoria.ImageScalingSize = new Size(20, 20);
            ctmCategoria.Name = "ctmCategoria";
            ctmCategoria.Size = new Size(61, 4);
            ctmCategoria.Closed += ctmCategoria_Closed;
            // 
            // imgCategoria
            // 
            imgCategoria.ColorDepth = ColorDepth.Depth32Bit;
            imgCategoria.ImageSize = new Size(35, 35);
            imgCategoria.TransparentColor = Color.Transparent;
            // 
            // FrmAgg_Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 307);
            Controls.Add(pnlagg_ctg);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAgg_Categoria";
            Text = "FrmAgg_Categoria";
            Load += FrmAgg_Categoria_Load;
            pnlagg_ctg.ResumeLayout(false);
            pnlagg_ctg.PerformLayout();
            pnl1_ctg.ResumeLayout(false);
            pnl1_ctg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cls).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlagg_ctg;
        private Panel pnl1_ctg;
        private PictureBox pic1_e;
        private Label lble_1;
        private Label lble_2;
        private TextBox txt_ctg1;
        private Label lble_3;
        private ContextMenuStrip ctmCategoria;
        private Label lbl_icono;
        private Button btn_abajo;
        private Button btn_arriba;
        private ImageList imgCategoria;
        private Label lble_4;
        private ComboBox cmb_ctg;
        private Label lbl_ry1;
        private TextBox txt1;
        private Label lble_5;
        private Button btn_grd;
        private PictureBox btn_cls;
    }
}