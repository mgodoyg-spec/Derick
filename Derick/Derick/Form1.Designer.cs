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
            pnlLogin = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTitulo = new Label();
            pnlImagen.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlImagen
            // 
            pnlImagen.BackColor = Color.FromArgb(17, 17, 17);
            pnlImagen.Controls.Add(pictureBox1);
            pnlImagen.Dock = DockStyle.Left;
            pnlImagen.Location = new Point(0, 0);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(470, 700);
            pnlImagen.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblTitulo);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlLogin.Location = new Point(470, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(730, 700);
            pnlLogin.TabIndex = 1;
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
            // pictureBox2
            // 
            pictureBox2.Location = new Point(300, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(102, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "DERICK";
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
            MinimumSize = new Size(1200, 700);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            pnlImagen.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlImagen;
        private Panel pnlLogin;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private PictureBox pictureBox2;
    }
}
