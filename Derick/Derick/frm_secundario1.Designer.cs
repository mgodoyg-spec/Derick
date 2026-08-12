namespace Derick
{
    partial class frm_secundario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_secundario1));
            pnl_sc1 = new Panel();
            pnl_cd1 = new Panel();
            pnl_cd2 = new Panel();
            btnguardar = new Button();
            btncerrar = new Button();
            lbl2 = new Label();
            txt_cd = new TextBox();
            pnl_enc1 = new Panel();
            lbl_sc = new Label();
            pic_ntll = new PictureBox();
            pnl_sc1.SuspendLayout();
            pnl_cd1.SuspendLayout();
            pnl_cd2.SuspendLayout();
            pnl_enc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).BeginInit();
            SuspendLayout();
            // 
            // pnl_sc1
            // 
            pnl_sc1.BackColor = Color.FromArgb(244, 246, 249);
            pnl_sc1.Controls.Add(pnl_cd1);
            pnl_sc1.Controls.Add(pnl_enc1);
            pnl_sc1.Dock = DockStyle.Fill;
            pnl_sc1.Location = new Point(0, 0);
            pnl_sc1.Name = "pnl_sc1";
            pnl_sc1.Size = new Size(448, 298);
            pnl_sc1.TabIndex = 0;
            // 
            // pnl_cd1
            // 
            pnl_cd1.Controls.Add(pnl_cd2);
            pnl_cd1.Controls.Add(lbl2);
            pnl_cd1.Controls.Add(txt_cd);
            pnl_cd1.Dock = DockStyle.Fill;
            pnl_cd1.Location = new Point(0, 81);
            pnl_cd1.Name = "pnl_cd1";
            pnl_cd1.Size = new Size(448, 217);
            pnl_cd1.TabIndex = 4;
            // 
            // pnl_cd2
            // 
            pnl_cd2.BackColor = Color.FromArgb(232, 240, 254);
            pnl_cd2.BorderStyle = BorderStyle.Fixed3D;
            pnl_cd2.Controls.Add(btnguardar);
            pnl_cd2.Controls.Add(btncerrar);
            pnl_cd2.Dock = DockStyle.Bottom;
            pnl_cd2.Location = new Point(0, 122);
            pnl_cd2.Name = "pnl_cd2";
            pnl_cd2.Size = new Size(448, 95);
            pnl_cd2.TabIndex = 4;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 102, 255);
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnguardar.ForeColor = Color.White;
            btnguardar.Image = (Image)resources.GetObject("btnguardar.Image");
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(234, 21);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(176, 47);
            btnguardar.TabIndex = 1;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += button2_Click;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.White;
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncerrar.ForeColor = Color.FromArgb(0, 102, 255);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btncerrar.Location = new Point(20, 21);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(176, 47);
            btncerrar.TabIndex = 0;
            btncerrar.Text = "Cancelar";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += button1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(12, 24);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(155, 22);
            lbl2.TabIndex = 2;
            lbl2.Text = "Nombre de la talla";
            // 
            // txt_cd
            // 
            txt_cd.CharacterCasing = CharacterCasing.Upper;
            txt_cd.Location = new Point(12, 49);
            txt_cd.MaxLength = 10;
            txt_cd.Name = "txt_cd";
            txt_cd.PlaceholderText = "Ej: XXL, XXXL";
            txt_cd.Size = new Size(209, 27);
            txt_cd.TabIndex = 3;
            // 
            // pnl_enc1
            // 
            pnl_enc1.BackColor = Color.FromArgb(232, 240, 254);
            pnl_enc1.BorderStyle = BorderStyle.Fixed3D;
            pnl_enc1.Controls.Add(lbl_sc);
            pnl_enc1.Controls.Add(pic_ntll);
            pnl_enc1.Dock = DockStyle.Top;
            pnl_enc1.Location = new Point(0, 0);
            pnl_enc1.Name = "pnl_enc1";
            pnl_enc1.Size = new Size(448, 81);
            pnl_enc1.TabIndex = 0;
            // 
            // lbl_sc
            // 
            lbl_sc.AutoSize = true;
            lbl_sc.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sc.Location = new Point(82, 27);
            lbl_sc.Name = "lbl_sc";
            lbl_sc.Size = new Size(185, 22);
            lbl_sc.TabIndex = 2;
            lbl_sc.Text = "Agregar nueva talla";
            // 
            // pic_ntll
            // 
            pic_ntll.Image = (Image)resources.GetObject("pic_ntll.Image");
            pic_ntll.Location = new Point(11, 11);
            pic_ntll.Name = "pic_ntll";
            pic_ntll.Size = new Size(65, 58);
            pic_ntll.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ntll.TabIndex = 1;
            pic_ntll.TabStop = false;
            // 
            // frm_secundario1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(448, 298);
            Controls.Add(pnl_sc1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_secundario1";
            Text = "frm_secundario1";
            Load += frm_secundario1_Load;
            pnl_sc1.ResumeLayout(false);
            pnl_cd1.ResumeLayout(false);
            pnl_cd1.PerformLayout();
            pnl_cd2.ResumeLayout(false);
            pnl_enc1.ResumeLayout(false);
            pnl_enc1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ntll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_sc1;
        private Panel pnl_enc1;
        private Label lbl_sc;
        private PictureBox pic_ntll;
        private Label lbl2;
        private TextBox txt_cd;
        private Panel pnl_cd1;
        private Panel pnl_cd2;
        private Button btncerrar;
        private Button btnguardar;
    }
}