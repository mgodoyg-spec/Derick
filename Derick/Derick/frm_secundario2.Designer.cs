namespace Derick
{
    partial class frm_secundario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_secundario2));
            pnl_clr = new Panel();
            pnl1 = new Panel();
            btn_elig = new Button();
            pnl_clr1 = new Panel();
            lcl_clr3 = new Label();
            lbl_clr2 = new Label();
            txt_clr = new TextBox();
            pnl3 = new Panel();
            btn_guardar = new Button();
            btn_cerrar = new Button();
            pnl2 = new Panel();
            lbl_clr1 = new Label();
            pic_ncl = new PictureBox();
            pnl_clr.SuspendLayout();
            pnl1.SuspendLayout();
            pnl3.SuspendLayout();
            pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ncl).BeginInit();
            SuspendLayout();
            // 
            // pnl_clr
            // 
            pnl_clr.BackColor = Color.FromArgb(244, 246, 249);
            pnl_clr.Controls.Add(pnl1);
            pnl_clr.Controls.Add(pnl2);
            pnl_clr.Dock = DockStyle.Fill;
            pnl_clr.Location = new Point(0, 0);
            pnl_clr.Name = "pnl_clr";
            pnl_clr.Size = new Size(430, 339);
            pnl_clr.TabIndex = 0;
            // 
            // pnl1
            // 
            pnl1.Controls.Add(btn_elig);
            pnl1.Controls.Add(pnl_clr1);
            pnl1.Controls.Add(lcl_clr3);
            pnl1.Controls.Add(lbl_clr2);
            pnl1.Controls.Add(txt_clr);
            pnl1.Controls.Add(pnl3);
            pnl1.Dock = DockStyle.Fill;
            pnl1.Location = new Point(0, 81);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(430, 258);
            pnl1.TabIndex = 1;
            // 
            // btn_elig
            // 
            btn_elig.Cursor = Cursors.Hand;
            btn_elig.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btn_elig.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_elig.ForeColor = Color.FromArgb(0, 102, 255);
            btn_elig.Image = (Image)resources.GetObject("btn_elig.Image");
            btn_elig.ImageAlign = ContentAlignment.MiddleLeft;
            btn_elig.Location = new Point(123, 112);
            btn_elig.Name = "btn_elig";
            btn_elig.Size = new Size(161, 42);
            btn_elig.TabIndex = 8;
            btn_elig.Text = "      Elegir color";
            btn_elig.UseVisualStyleBackColor = true;
            btn_elig.Click += btn_elig_Click;
            // 
            // pnl_clr1
            // 
            pnl_clr1.BorderStyle = BorderStyle.FixedSingle;
            pnl_clr1.Location = new Point(12, 100);
            pnl_clr1.Name = "pnl_clr1";
            pnl_clr1.Size = new Size(82, 66);
            pnl_clr1.TabIndex = 7;
            // 
            // lcl_clr3
            // 
            lcl_clr3.AutoSize = true;
            lcl_clr3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lcl_clr3.Location = new Point(12, 75);
            lcl_clr3.Name = "lcl_clr3";
            lcl_clr3.Size = new Size(98, 22);
            lcl_clr3.TabIndex = 6;
            lcl_clr3.Text = "Vista privia";
            // 
            // lbl_clr2
            // 
            lbl_clr2.AutoSize = true;
            lbl_clr2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_clr2.Location = new Point(12, 11);
            lbl_clr2.Name = "lbl_clr2";
            lbl_clr2.Size = new Size(146, 22);
            lbl_clr2.TabIndex = 4;
            lbl_clr2.Text = "Nombre del color";
            // 
            // txt_clr
            // 
            txt_clr.Location = new Point(12, 36);
            txt_clr.MaxLength = 10;
            txt_clr.Name = "txt_clr";
            txt_clr.PlaceholderText = "Ej: Azul marino";
            txt_clr.Size = new Size(209, 27);
            txt_clr.TabIndex = 5;
            txt_clr.KeyPress += txt_clr_KeyPress;
            // 
            // pnl3
            // 
            pnl3.BackColor = Color.FromArgb(232, 240, 254);
            pnl3.BorderStyle = BorderStyle.Fixed3D;
            pnl3.Controls.Add(btn_guardar);
            pnl3.Controls.Add(btn_cerrar);
            pnl3.Dock = DockStyle.Bottom;
            pnl3.Location = new Point(0, 172);
            pnl3.Name = "pnl3";
            pnl3.Size = new Size(430, 86);
            pnl3.TabIndex = 0;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(0, 102, 255);
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatAppearance.BorderColor = Color.Black;
            btn_guardar.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_guardar.Location = new Point(236, 17);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(176, 47);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.White;
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btn_cerrar.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.FromArgb(0, 102, 255);
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(22, 17);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(176, 47);
            btn_cerrar.TabIndex = 6;
            btn_cerrar.Text = "Cancelar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // pnl2
            // 
            pnl2.BackColor = Color.FromArgb(232, 240, 254);
            pnl2.BorderStyle = BorderStyle.Fixed3D;
            pnl2.Controls.Add(lbl_clr1);
            pnl2.Controls.Add(pic_ncl);
            pnl2.Dock = DockStyle.Top;
            pnl2.Location = new Point(0, 0);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(430, 81);
            pnl2.TabIndex = 0;
            // 
            // lbl_clr1
            // 
            lbl_clr1.AutoSize = true;
            lbl_clr1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_clr1.Location = new Point(83, 32);
            lbl_clr1.Name = "lbl_clr1";
            lbl_clr1.Size = new Size(219, 22);
            lbl_clr1.TabIndex = 3;
            lbl_clr1.Text = "Agregar un nuevo color";
            // 
            // pic_ncl
            // 
            pic_ncl.Image = (Image)resources.GetObject("pic_ncl.Image");
            pic_ncl.Location = new Point(12, 12);
            pic_ncl.Name = "pic_ncl";
            pic_ncl.Size = new Size(65, 58);
            pic_ncl.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ncl.TabIndex = 2;
            pic_ncl.TabStop = false;
            // 
            // frm_secundario2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 339);
            Controls.Add(pnl_clr);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_secundario2";
            Text = "frm_secundario2";
            pnl_clr.ResumeLayout(false);
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            pnl3.ResumeLayout(false);
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ncl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_clr;
        private Panel pnl2;
        private PictureBox pic_ncl;
        private Label lbl_clr1;
        private Panel pnl1;
        private Panel pnl3;
        private Label lbl_clr2;
        private TextBox txt_clr;
        private Button btn_guardar;
        private Button btn_cerrar;
        private Button btn_elig;
        private Panel pnl_clr1;
        private Label lcl_clr3;
    }
}