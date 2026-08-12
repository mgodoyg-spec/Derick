namespace Derick
{
    partial class frmEditar_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar_stock));
            pnl_stock = new Panel();
            btn_aceptar = new Button();
            btn_cerra = new Button();
            pnl_stock2 = new Panel();
            lbl_n3 = new Label();
            lbl_total = new Label();
            lbl_n1 = new Label();
            dgv_stock = new DataGridView();
            clTalla = new DataGridViewTextBoxColumn();
            clColor = new DataGridViewTextBoxColumn();
            clStock = new DataGridViewTextBoxColumn();
            lbl_ry = new Label();
            panel1 = new Panel();
            lbl_sc = new Label();
            pic_ntll = new PictureBox();
            pnl_stock.SuspendLayout();
            pnl_stock2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).BeginInit();
            SuspendLayout();
            // 
            // pnl_stock
            // 
            pnl_stock.BackColor = Color.FromArgb(244, 246, 249);
            pnl_stock.Controls.Add(btn_aceptar);
            pnl_stock.Controls.Add(btn_cerra);
            pnl_stock.Controls.Add(pnl_stock2);
            pnl_stock.Controls.Add(dgv_stock);
            pnl_stock.Controls.Add(lbl_ry);
            pnl_stock.Controls.Add(panel1);
            pnl_stock.Dock = DockStyle.Fill;
            pnl_stock.Location = new Point(0, 0);
            pnl_stock.Name = "pnl_stock";
            pnl_stock.Size = new Size(521, 571);
            pnl_stock.TabIndex = 0;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.FromArgb(0, 102, 255);
            btn_aceptar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_aceptar.ForeColor = Color.White;
            btn_aceptar.Image = (Image)resources.GetObject("btn_aceptar.Image");
            btn_aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_aceptar.Location = new Point(366, 508);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(143, 45);
            btn_aceptar.TabIndex = 5;
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
            btn_cerra.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerra.ForeColor = Color.FromArgb(0, 102, 255);
            btn_cerra.Image = (Image)resources.GetObject("btn_cerra.Image");
            btn_cerra.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerra.Location = new Point(217, 508);
            btn_cerra.Name = "btn_cerra";
            btn_cerra.Size = new Size(143, 45);
            btn_cerra.TabIndex = 4;
            btn_cerra.Text = "     Cancelar";
            btn_cerra.UseVisualStyleBackColor = false;
            btn_cerra.Click += button1_Click;
            // 
            // pnl_stock2
            // 
            pnl_stock2.BackColor = Color.White;
            pnl_stock2.BorderStyle = BorderStyle.FixedSingle;
            pnl_stock2.Controls.Add(lbl_n3);
            pnl_stock2.Controls.Add(lbl_total);
            pnl_stock2.Controls.Add(lbl_n1);
            pnl_stock2.Location = new Point(14, 471);
            pnl_stock2.Name = "pnl_stock2";
            pnl_stock2.Size = new Size(155, 88);
            pnl_stock2.TabIndex = 3;
            // 
            // lbl_n3
            // 
            lbl_n3.AutoSize = true;
            lbl_n3.ForeColor = Color.Gray;
            lbl_n3.Location = new Point(66, 50);
            lbl_n3.Name = "lbl_n3";
            lbl_n3.Size = new Size(69, 20);
            lbl_n3.TabIndex = 4;
            lbl_n3.Text = "unidades";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.BackColor = Color.White;
            lbl_total.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_total.ForeColor = Color.FromArgb(0, 102, 255);
            lbl_total.Location = new Point(16, 45);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(25, 26);
            lbl_total.TabIndex = 4;
            lbl_total.Text = "0";
            // 
            // lbl_n1
            // 
            lbl_n1.AutoSize = true;
            lbl_n1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_n1.Location = new Point(16, 11);
            lbl_n1.Name = "lbl_n1";
            lbl_n1.Size = new Size(119, 24);
            lbl_n1.TabIndex = 4;
            lbl_n1.Text = "Stock total:";
            // 
            // dgv_stock
            // 
            dgv_stock.BackgroundColor = Color.White;
            dgv_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_stock.Columns.AddRange(new DataGridViewColumn[] { clTalla, clColor, clStock });
            dgv_stock.Location = new Point(14, 107);
            dgv_stock.Name = "dgv_stock";
            dgv_stock.RowHeadersWidth = 51;
            dgv_stock.Size = new Size(495, 335);
            dgv_stock.TabIndex = 2;
            dgv_stock.CellEndEdit += dgv_stock_CellEndEdit;
            // 
            // clTalla
            // 
            clTalla.HeaderText = "Talla";
            clTalla.MinimumWidth = 6;
            clTalla.Name = "clTalla";
            clTalla.Width = 125;
            // 
            // clColor
            // 
            clColor.HeaderText = "Color";
            clColor.MinimumWidth = 6;
            clColor.Name = "clColor";
            clColor.Width = 125;
            // 
            // clStock
            // 
            clStock.HeaderText = "Stock";
            clStock.MinimumWidth = 6;
            clStock.Name = "clStock";
            clStock.Width = 125;
            // 
            // lbl_ry
            // 
            lbl_ry.BackColor = Color.FromArgb(0, 102, 255);
            lbl_ry.Location = new Point(0, 90);
            lbl_ry.Name = "lbl_ry";
            lbl_ry.Size = new Size(523, 2);
            lbl_ry.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 240, 254);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_sc);
            panel1.Controls.Add(pic_ntll);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 92);
            panel1.TabIndex = 0;
            // 
            // lbl_sc
            // 
            lbl_sc.AutoSize = true;
            lbl_sc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sc.Location = new Point(83, 29);
            lbl_sc.Name = "lbl_sc";
            lbl_sc.Size = new Size(335, 25);
            lbl_sc.TabIndex = 4;
            lbl_sc.Text = "Configurar stock de los productos";
            // 
            // pic_ntll
            // 
            pic_ntll.Image = (Image)resources.GetObject("pic_ntll.Image");
            pic_ntll.Location = new Point(12, 13);
            pic_ntll.Name = "pic_ntll";
            pic_ntll.Size = new Size(65, 58);
            pic_ntll.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ntll.TabIndex = 3;
            pic_ntll.TabStop = false;
            // 
            // frmEditar_stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 571);
            Controls.Add(pnl_stock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditar_stock";
            Text = "frmEditar_stock";
            Load += frmEditar_stock_Load;
            pnl_stock.ResumeLayout(false);
            pnl_stock2.ResumeLayout(false);
            pnl_stock2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_stock;
        private Panel panel1;
        private Label lbl_sc;
        private PictureBox pic_ntll;
        private Label lbl_ry;
        private DataGridView dgv_stock;
        private DataGridViewTextBoxColumn clTalla;
        private DataGridViewTextBoxColumn clColor;
        private DataGridViewTextBoxColumn clStock;
        private Label lbl_total;
        private Panel pnl_stock2;
        private Label lbl_n1;
        private Button btn_aceptar;
        private Button btn_cerra;
        private Label lbl_n3;
    }
}