namespace Derick
{
    partial class FrmMiPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiPerfil));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblMiPerfil = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            btnCambiarFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 246, 249);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblMiPerfil);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 100);
            panel1.TabIndex = 44;
            // 
            // lblMiPerfil
            // 
            lblMiPerfil.AutoSize = true;
            lblMiPerfil.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblMiPerfil.Location = new Point(103, 20);
            lblMiPerfil.Name = "lblMiPerfil";
            lblMiPerfil.Size = new Size(97, 30);
            lblMiPerfil.TabIndex = 44;
            lblMiPerfil.Text = "Mi Perfil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 50);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 45;
            label1.Text = "Consulta tu información personal y  de tu cuenta";
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 233);
            panel2.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.Location = new Point(617, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 233);
            panel3.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCambiarFoto);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(617, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 100);
            panel4.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.Location = new Point(129, 60);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(110, 23);
            btnCambiarFoto.TabIndex = 0;
            btnCambiarFoto.Text = "Cambiar Foto";
            btnCambiarFoto.UseVisualStyleBackColor = true;
            // 
            // FrmMiPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1000, 650);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMiPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMiPerfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblMiPerfil;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnCambiarFoto;
        private PictureBox pictureBox1;
    }
}