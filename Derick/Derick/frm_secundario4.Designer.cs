namespace Derick
{
    partial class frm_secundario4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_secundario4));
            pnl_sec1 = new Panel();
            btn_aceptar = new Button();
            btn_cerra = new Button();
            dgv_prm = new DataGridView();
            clSeleccionar = new DataGridViewCheckBoxColumn();
            clCodigo = new DataGridViewTextBoxColumn();
            clProducto = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            btn_bus1 = new Button();
            pnl_ctg2 = new Panel();
            pic_ctg2 = new PictureBox();
            txt_busqctg = new TextBox();
            pnl_sec2 = new Panel();
            lbl_sc = new Label();
            pic_ntll = new PictureBox();
            lbl_ry = new Label();
            pnl_sec1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_prm).BeginInit();
            pnl_ctg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ctg2).BeginInit();
            pnl_sec2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).BeginInit();
            SuspendLayout();
            // 
            // pnl_sec1
            // 
            pnl_sec1.BackColor = Color.FromArgb(244, 246, 249);
            pnl_sec1.Controls.Add(btn_aceptar);
            pnl_sec1.Controls.Add(btn_cerra);
            pnl_sec1.Controls.Add(dgv_prm);
            pnl_sec1.Controls.Add(btn_bus1);
            pnl_sec1.Controls.Add(pnl_ctg2);
            pnl_sec1.Controls.Add(pnl_sec2);
            pnl_sec1.Dock = DockStyle.Fill;
            pnl_sec1.Location = new Point(0, 0);
            pnl_sec1.Name = "pnl_sec1";
            pnl_sec1.Size = new Size(548, 571);
            pnl_sec1.TabIndex = 0;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.FromArgb(0, 102, 255);
            btn_aceptar.FlatStyle = FlatStyle.Flat;
            btn_aceptar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Image = (Image)resources.GetObject("btn_aceptar.Image");
            btn_aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_aceptar.Location = new Point(393, 505);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(143, 45);
            btn_aceptar.TabIndex = 29;
            btn_aceptar.Text = "     Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cerra
            // 
            btn_cerra.BackColor = Color.White;
            btn_cerra.Cursor = Cursors.Hand;
            btn_cerra.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btn_cerra.FlatAppearance.BorderSize = 2;
            btn_cerra.FlatStyle = FlatStyle.Flat;
            btn_cerra.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerra.ForeColor = Color.FromArgb(0, 102, 255);
            btn_cerra.Image = (Image)resources.GetObject("btn_cerra.Image");
            btn_cerra.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerra.Location = new Point(244, 505);
            btn_cerra.Name = "btn_cerra";
            btn_cerra.Size = new Size(143, 45);
            btn_cerra.TabIndex = 28;
            btn_cerra.Text = "     Cancelar";
            btn_cerra.UseVisualStyleBackColor = false;
            btn_cerra.Click += btn_cerra_Click;
            // 
            // dgv_prm
            // 
            dgv_prm.BackgroundColor = Color.White;
            dgv_prm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prm.Columns.AddRange(new DataGridViewColumn[] { clSeleccionar, clCodigo, clProducto, clPrecio });
            dgv_prm.Location = new Point(11, 163);
            dgv_prm.Name = "dgv_prm";
            dgv_prm.RowHeadersWidth = 51;
            dgv_prm.Size = new Size(525, 314);
            dgv_prm.TabIndex = 27;
            // 
            // clSeleccionar
            // 
            clSeleccionar.HeaderText = "Seleccionar";
            clSeleccionar.MinimumWidth = 6;
            clSeleccionar.Name = "clSeleccionar";
            clSeleccionar.Width = 125;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.MinimumWidth = 6;
            clCodigo.Name = "clCodigo";
            clCodigo.Width = 125;
            // 
            // clProducto
            // 
            clProducto.HeaderText = "Nombre del producto";
            clProducto.MinimumWidth = 6;
            clProducto.Name = "clProducto";
            clProducto.Width = 125;
            // 
            // clPrecio
            // 
            clPrecio.HeaderText = "Precio";
            clPrecio.MinimumWidth = 6;
            clPrecio.Name = "clPrecio";
            clPrecio.Width = 125;
            // 
            // btn_bus1
            // 
            btn_bus1.BackColor = Color.FromArgb(0, 176, 80);
            btn_bus1.Cursor = Cursors.Hand;
            btn_bus1.FlatAppearance.BorderColor = Color.FromArgb(0, 176, 80);
            btn_bus1.FlatStyle = FlatStyle.Flat;
            btn_bus1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bus1.ForeColor = Color.White;
            btn_bus1.Image = (Image)resources.GetObject("btn_bus1.Image");
            btn_bus1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bus1.Location = new Point(319, 98);
            btn_bus1.Name = "btn_bus1";
            btn_bus1.Size = new Size(176, 47);
            btn_bus1.TabIndex = 26;
            btn_bus1.Text = "Buscar";
            btn_bus1.UseVisualStyleBackColor = false;
            // 
            // pnl_ctg2
            // 
            pnl_ctg2.BackColor = Color.White;
            pnl_ctg2.BorderStyle = BorderStyle.FixedSingle;
            pnl_ctg2.Controls.Add(pic_ctg2);
            pnl_ctg2.Controls.Add(txt_busqctg);
            pnl_ctg2.Location = new Point(12, 98);
            pnl_ctg2.Name = "pnl_ctg2";
            pnl_ctg2.Padding = new Padding(10);
            pnl_ctg2.Size = new Size(290, 45);
            pnl_ctg2.TabIndex = 25;
            // 
            // pic_ctg2
            // 
            pic_ctg2.BackColor = Color.White;
            pic_ctg2.Image = (Image)resources.GetObject("pic_ctg2.Image");
            pic_ctg2.Location = new Point(-2, -1);
            pic_ctg2.Name = "pic_ctg2";
            pic_ctg2.Size = new Size(50, 45);
            pic_ctg2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ctg2.TabIndex = 23;
            pic_ctg2.TabStop = false;
            // 
            // txt_busqctg
            // 
            txt_busqctg.BorderStyle = BorderStyle.None;
            txt_busqctg.Font = new Font("Segoe UI", 10.8F);
            txt_busqctg.ForeColor = Color.Gray;
            txt_busqctg.Location = new Point(5, 9);
            txt_busqctg.Name = "txt_busqctg";
            txt_busqctg.PlaceholderText = "          Buscar producto";
            txt_busqctg.Size = new Size(270, 24);
            txt_busqctg.TabIndex = 7;
            // 
            // pnl_sec2
            // 
            pnl_sec2.BackColor = Color.FromArgb(232, 240, 254);
            pnl_sec2.BorderStyle = BorderStyle.Fixed3D;
            pnl_sec2.Controls.Add(lbl_sc);
            pnl_sec2.Controls.Add(pic_ntll);
            pnl_sec2.Controls.Add(lbl_ry);
            pnl_sec2.Dock = DockStyle.Top;
            pnl_sec2.Location = new Point(0, 0);
            pnl_sec2.Name = "pnl_sec2";
            pnl_sec2.Size = new Size(548, 92);
            pnl_sec2.TabIndex = 0;
            // 
            // lbl_sc
            // 
            lbl_sc.AutoSize = true;
            lbl_sc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sc.Location = new Point(85, 30);
            lbl_sc.Name = "lbl_sc";
            lbl_sc.Size = new Size(227, 25);
            lbl_sc.TabIndex = 6;
            lbl_sc.Text = "Seleccionar productos";
            // 
            // pic_ntll
            // 
            pic_ntll.Image = (Image)resources.GetObject("pic_ntll.Image");
            pic_ntll.Location = new Point(14, 14);
            pic_ntll.Name = "pic_ntll";
            pic_ntll.Size = new Size(65, 58);
            pic_ntll.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ntll.TabIndex = 5;
            pic_ntll.TabStop = false;
            // 
            // lbl_ry
            // 
            lbl_ry.BackColor = Color.FromArgb(0, 102, 255);
            lbl_ry.Location = new Point(-7, 86);
            lbl_ry.Name = "lbl_ry";
            lbl_ry.Size = new Size(554, 2);
            lbl_ry.TabIndex = 2;
            // 
            // frm_secundario4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 571);
            Controls.Add(pnl_sec1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_secundario4";
            Text = "frm_secundario4";
            Load += frm_secundario4_Load;
            pnl_sec1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_prm).EndInit();
            pnl_ctg2.ResumeLayout(false);
            pnl_ctg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ctg2).EndInit();
            pnl_sec2.ResumeLayout(false);
            pnl_sec2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_sec1;
        private Panel pnl_sec2;
        private Label lbl_ry;
        private Label lbl_sc;
        private PictureBox pic_ntll;
        private Panel pnl_ctg2;
        private PictureBox pic_ctg2;
        private TextBox txt_busqctg;
        private Button btn_bus1;
        private DataGridView dgv_prm;
        private Button btn_aceptar;
        private Button btn_cerra;
        private DataGridViewCheckBoxColumn clSeleccionar;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clProducto;
        private DataGridViewTextBoxColumn clPrecio;
    }
}