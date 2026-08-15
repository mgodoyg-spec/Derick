namespace Derick
{
    partial class frm_secundario3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_secundario3));
            pnl_icons = new Panel();
            pnl_icons2 = new Panel();
            btn_ccl = new Button();
            btn_acpt = new Button();
            pnl_icons4 = new Panel();
            lbl_icons2 = new Label();
            pic_icons2 = new PictureBox();
            flp_icons = new FlowLayoutPanel();
            pnl_icons3 = new Panel();
            lbl_icons1 = new Label();
            pic_icons1 = new PictureBox();
            lbl_ry = new Label();
            pnl_icons.SuspendLayout();
            pnl_icons2.SuspendLayout();
            pnl_icons4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_icons2).BeginInit();
            pnl_icons3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_icons1).BeginInit();
            SuspendLayout();
            // 
            // pnl_icons
            // 
            pnl_icons.BackColor = Color.FromArgb(244, 246, 249);
            pnl_icons.Controls.Add(pnl_icons2);
            pnl_icons.Controls.Add(pnl_icons3);
            pnl_icons.Dock = DockStyle.Fill;
            pnl_icons.Location = new Point(0, 0);
            pnl_icons.Margin = new Padding(3, 2, 3, 2);
            pnl_icons.Name = "pnl_icons";
            pnl_icons.Size = new Size(490, 300);
            pnl_icons.TabIndex = 0;
            // 
            // pnl_icons2
            // 
            pnl_icons2.Controls.Add(lbl_ry);
            pnl_icons2.Controls.Add(btn_ccl);
            pnl_icons2.Controls.Add(btn_acpt);
            pnl_icons2.Controls.Add(pnl_icons4);
            pnl_icons2.Controls.Add(flp_icons);
            pnl_icons2.Dock = DockStyle.Fill;
            pnl_icons2.Location = new Point(0, 54);
            pnl_icons2.Margin = new Padding(3, 2, 3, 2);
            pnl_icons2.Name = "pnl_icons2";
            pnl_icons2.Size = new Size(490, 246);
            pnl_icons2.TabIndex = 1;
            // 
            // btn_ccl
            // 
            btn_ccl.BackColor = Color.White;
            btn_ccl.Cursor = Cursors.Hand;
            btn_ccl.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btn_ccl.FlatAppearance.BorderSize = 2;
            btn_ccl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_ccl.ForeColor = Color.FromArgb(4, 59, 186);
            btn_ccl.Image = (Image)resources.GetObject("btn_ccl.Image");
            btn_ccl.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ccl.Location = new Point(125, 191);
            btn_ccl.Margin = new Padding(3, 2, 3, 2);
            btn_ccl.Name = "btn_ccl";
            btn_ccl.Size = new Size(178, 47);
            btn_ccl.TabIndex = 3;
            btn_ccl.Text = "Cancelar";
            btn_ccl.UseVisualStyleBackColor = false;
            btn_ccl.Click += btn_ccl_Click;
            // 
            // btn_acpt
            // 
            btn_acpt.BackColor = Color.FromArgb(4, 59, 186);
            btn_acpt.Cursor = Cursors.Hand;
            btn_acpt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_acpt.ForeColor = Color.White;
            btn_acpt.Image = (Image)resources.GetObject("btn_acpt.Image");
            btn_acpt.ImageAlign = ContentAlignment.MiddleLeft;
            btn_acpt.Location = new Point(309, 191);
            btn_acpt.Margin = new Padding(3, 2, 3, 2);
            btn_acpt.Name = "btn_acpt";
            btn_acpt.Size = new Size(178, 47);
            btn_acpt.TabIndex = 2;
            btn_acpt.Text = "Aceptar";
            btn_acpt.UseVisualStyleBackColor = false;
            btn_acpt.Click += btn_acpt_Click;
            // 
            // pnl_icons4
            // 
            pnl_icons4.BackColor = Color.White;
            pnl_icons4.BorderStyle = BorderStyle.FixedSingle;
            pnl_icons4.Controls.Add(lbl_icons2);
            pnl_icons4.Controls.Add(pic_icons2);
            pnl_icons4.Cursor = Cursors.Hand;
            pnl_icons4.Location = new Point(8, 4);
            pnl_icons4.Margin = new Padding(3, 2, 3, 2);
            pnl_icons4.Name = "pnl_icons4";
            pnl_icons4.Size = new Size(112, 94);
            pnl_icons4.TabIndex = 1;
            pnl_icons4.Click += pnl_icons4_Click;
            // 
            // lbl_icons2
            // 
            lbl_icons2.AutoSize = true;
            lbl_icons2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl_icons2.Location = new Point(6, 58);
            lbl_icons2.Name = "lbl_icons2";
            lbl_icons2.Size = new Size(105, 19);
            lbl_icons2.TabIndex = 2;
            lbl_icons2.Text = "Agregar ícono";
            // 
            // pic_icons2
            // 
            pic_icons2.Image = (Image)resources.GetObject("pic_icons2.Image");
            pic_icons2.Location = new Point(33, 13);
            pic_icons2.Margin = new Padding(3, 2, 3, 2);
            pic_icons2.Name = "pic_icons2";
            pic_icons2.Size = new Size(38, 28);
            pic_icons2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_icons2.TabIndex = 0;
            pic_icons2.TabStop = false;
            // 
            // flp_icons
            // 
            flp_icons.AutoScroll = true;
            flp_icons.BackColor = Color.White;
            flp_icons.Location = new Point(125, 4);
            flp_icons.Margin = new Padding(3, 2, 3, 2);
            flp_icons.Name = "flp_icons";
            flp_icons.Padding = new Padding(4);
            flp_icons.Size = new Size(362, 183);
            flp_icons.TabIndex = 0;
            // 
            // pnl_icons3
            // 
            pnl_icons3.BackColor = Color.FromArgb(232, 240, 254);
            pnl_icons3.BorderStyle = BorderStyle.Fixed3D;
            pnl_icons3.Controls.Add(lbl_icons1);
            pnl_icons3.Controls.Add(pic_icons1);
            pnl_icons3.Dock = DockStyle.Top;
            pnl_icons3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnl_icons3.Location = new Point(0, 0);
            pnl_icons3.Margin = new Padding(3, 2, 3, 2);
            pnl_icons3.Name = "pnl_icons3";
            pnl_icons3.Size = new Size(490, 54);
            pnl_icons3.TabIndex = 0;
            // 
            // lbl_icons1
            // 
            lbl_icons1.AutoSize = true;
            lbl_icons1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_icons1.ForeColor = Color.Black;
            lbl_icons1.Location = new Point(72, 14);
            lbl_icons1.Name = "lbl_icons1";
            lbl_icons1.Size = new Size(162, 24);
            lbl_icons1.TabIndex = 4;
            lbl_icons1.Text = "Seleccionar ícono";
            // 
            // pic_icons1
            // 
            pic_icons1.Image = (Image)resources.GetObject("pic_icons1.Image");
            pic_icons1.Location = new Point(6, 2);
            pic_icons1.Margin = new Padding(3, 2, 3, 2);
            pic_icons1.Name = "pic_icons1";
            pic_icons1.Size = new Size(60, 41);
            pic_icons1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_icons1.TabIndex = 3;
            pic_icons1.TabStop = false;
            // 
            // lbl_ry
            // 
            lbl_ry.BackColor = Color.FromArgb(4, 59, 186);
            lbl_ry.Location = new Point(3, 0);
            lbl_ry.Name = "lbl_ry";
            lbl_ry.Size = new Size(485, 2);
            lbl_ry.TabIndex = 4;
            // 
            // frm_secundario3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 300);
            Controls.Add(pnl_icons);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_secundario3";
            Text = "frm_secundario3";
            Load += frm_secundario3_Load;
            pnl_icons.ResumeLayout(false);
            pnl_icons2.ResumeLayout(false);
            pnl_icons4.ResumeLayout(false);
            pnl_icons4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_icons2).EndInit();
            pnl_icons3.ResumeLayout(false);
            pnl_icons3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_icons1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_icons;
        private Panel pnl_icons3;
        private Label lbl_icons1;
        private PictureBox pic_icons1;
        private Panel pnl_icons2;
        private FlowLayoutPanel flp_icons;
        private Panel pnl_icons4;
        private PictureBox pic_icons2;
        private Button btn_acpt;
        private Label lbl_icons2;
        private Button btn_ccl;
        private Label lbl_ry;
    }
}