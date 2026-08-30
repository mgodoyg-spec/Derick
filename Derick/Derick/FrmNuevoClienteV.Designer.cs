namespace Derick
{
    partial class FrmNuevoClienteV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoClienteV));
            pnlNVinfoNC = new Panel();
            txtApe = new TextBox();
            label1 = new Label();
            lblNCApe = new Label();
            btnNVC = new Button();
            btnNCG = new Button();
            txtDI = new TextBox();
            txtCOE = new TextBox();
            txtTE = new TextBox();
            txtCI = new TextBox();
            txtNC = new TextBox();
            lblNVCOE = new Label();
            lblR3 = new Label();
            lblNVTE = new Label();
            lblNVDI = new Label();
            lblR2 = new Label();
            lblR1 = new Label();
            lblNVCI = new Label();
            lblNVNCO = new Label();
            lblNVNC = new Label();
            picNVI = new PictureBox();
            pnlNVinfoNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVI).BeginInit();
            SuspendLayout();
            // 
            // pnlNVinfoNC
            // 
            pnlNVinfoNC.BackColor = Color.White;
            pnlNVinfoNC.BorderStyle = BorderStyle.FixedSingle;
            pnlNVinfoNC.Controls.Add(txtApe);
            pnlNVinfoNC.Controls.Add(label1);
            pnlNVinfoNC.Controls.Add(lblNCApe);
            pnlNVinfoNC.Controls.Add(btnNVC);
            pnlNVinfoNC.Controls.Add(btnNCG);
            pnlNVinfoNC.Controls.Add(txtDI);
            pnlNVinfoNC.Controls.Add(txtCOE);
            pnlNVinfoNC.Controls.Add(txtTE);
            pnlNVinfoNC.Controls.Add(txtCI);
            pnlNVinfoNC.Controls.Add(txtNC);
            pnlNVinfoNC.Controls.Add(lblNVCOE);
            pnlNVinfoNC.Controls.Add(lblR3);
            pnlNVinfoNC.Controls.Add(lblNVTE);
            pnlNVinfoNC.Controls.Add(lblNVDI);
            pnlNVinfoNC.Controls.Add(lblR2);
            pnlNVinfoNC.Controls.Add(lblR1);
            pnlNVinfoNC.Controls.Add(lblNVCI);
            pnlNVinfoNC.Controls.Add(lblNVNCO);
            pnlNVinfoNC.Controls.Add(lblNVNC);
            pnlNVinfoNC.Controls.Add(picNVI);
            pnlNVinfoNC.Location = new Point(10, 9);
            pnlNVinfoNC.Margin = new Padding(3, 2, 3, 2);
            pnlNVinfoNC.Name = "pnlNVinfoNC";
            pnlNVinfoNC.Size = new Size(539, 389);
            pnlNVinfoNC.TabIndex = 1;
            // 
            // txtApe
            // 
            txtApe.AcceptsReturn = true;
            txtApe.BorderStyle = BorderStyle.FixedSingle;
            txtApe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApe.ForeColor = Color.Gray;
            txtApe.Location = new Point(12, 163);
            txtApe.Margin = new Padding(3, 2, 3, 2);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(222, 25);
            txtApe.TabIndex = 46;
            txtApe.KeyPress += SoloLetras_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(74, 134);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 45;
            label1.Text = "*";
            // 
            // lblNCApe
            // 
            lblNCApe.AutoSize = true;
            lblNCApe.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNCApe.Location = new Point(12, 134);
            lblNCApe.Name = "lblNCApe";
            lblNCApe.Size = new Size(67, 18);
            lblNCApe.TabIndex = 44;
            lblNCApe.Text = "Apellidos";
            // 
            // btnNVC
            // 
            btnNVC.FlatAppearance.BorderColor = Color.FromArgb(4, 59, 186);
            btnNVC.FlatStyle = FlatStyle.Flat;
            btnNVC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVC.Location = new Point(416, 248);
            btnNVC.Margin = new Padding(3, 2, 3, 2);
            btnNVC.Name = "btnNVC";
            btnNVC.Size = new Size(89, 54);
            btnNVC.TabIndex = 43;
            btnNVC.Text = "Cancelar";
            btnNVC.UseVisualStyleBackColor = false;
            btnNVC.Click += btnNVC_Click;
            // 
            // btnNCG
            // 
            btnNCG.BackColor = Color.FromArgb(4, 59, 186);
            btnNCG.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNCG.ForeColor = Color.Transparent;
            btnNCG.Location = new Point(283, 248);
            btnNCG.Margin = new Padding(3, 2, 3, 2);
            btnNCG.Name = "btnNCG";
            btnNCG.Size = new Size(127, 54);
            btnNCG.TabIndex = 42;
            btnNCG.Text = "Guardar cliente";
            btnNCG.UseVisualStyleBackColor = false;
            btnNCG.Click += btnNCG_Click;
            // 
            // txtDI
            // 
            txtDI.AcceptsReturn = true;
            txtDI.BorderStyle = BorderStyle.FixedSingle;
            txtDI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDI.ForeColor = Color.Gray;
            txtDI.Location = new Point(284, 163);
            txtDI.Margin = new Padding(3, 2, 3, 2);
            txtDI.Multiline = true;
            txtDI.Name = "txtDI";
            txtDI.Size = new Size(222, 55);
            txtDI.TabIndex = 41;
            txtDI.LocationChanged += FrmNuevoClienteV_Load;
            // 
            // txtCOE
            // 
            txtCOE.AcceptsReturn = true;
            txtCOE.BorderStyle = BorderStyle.FixedSingle;
            txtCOE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCOE.ForeColor = Color.Gray;
            txtCOE.Location = new Point(284, 88);
            txtCOE.Margin = new Padding(3, 2, 3, 2);
            txtCOE.Name = "txtCOE";
            txtCOE.Size = new Size(222, 25);
            txtCOE.TabIndex = 40;
            // 
            // txtTE
            // 
            txtTE.AcceptsReturn = true;
            txtTE.BorderStyle = BorderStyle.FixedSingle;
            txtTE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTE.ForeColor = Color.Gray;
            txtTE.Location = new Point(12, 313);
            txtTE.Margin = new Padding(3, 2, 3, 2);
            txtTE.MaxLength = 10;
            txtTE.Name = "txtTE";
            txtTE.Size = new Size(222, 25);
            txtTE.TabIndex = 39;
            txtTE.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtCI
            // 
            txtCI.AcceptsReturn = true;
            txtCI.BorderStyle = BorderStyle.FixedSingle;
            txtCI.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCI.ForeColor = Color.Gray;
            txtCI.Location = new Point(12, 243);
            txtCI.Margin = new Padding(3, 2, 3, 2);
            txtCI.MaxLength = 10;
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(222, 25);
            txtCI.TabIndex = 38;
            txtCI.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtNC
            // 
            txtNC.AcceptsReturn = true;
            txtNC.BorderStyle = BorderStyle.FixedSingle;
            txtNC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNC.ForeColor = Color.Gray;
            txtNC.Location = new Point(10, 88);
            txtNC.Margin = new Padding(3, 2, 3, 2);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(222, 25);
            txtNC.TabIndex = 37;
            txtNC.KeyPress += SoloLetras_KeyPress;
            // 
            // lblNVCOE
            // 
            lblNVCOE.AutoSize = true;
            lblNVCOE.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCOE.Location = new Point(284, 54);
            lblNVCOE.Name = "lblNVCOE";
            lblNVCOE.Size = new Size(132, 18);
            lblNVCOE.TabIndex = 33;
            lblNVCOE.Text = "Correo electrónico";
            // 
            // lblR3
            // 
            lblR3.AutoSize = true;
            lblR3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR3.ForeColor = Color.Red;
            lblR3.Location = new Point(74, 282);
            lblR3.Name = "lblR3";
            lblR3.Size = new Size(16, 20);
            lblR3.TabIndex = 30;
            lblR3.Text = "*";
            // 
            // lblNVTE
            // 
            lblNVTE.AutoSize = true;
            lblNVTE.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVTE.Location = new Point(11, 282);
            lblNVTE.Name = "lblNVTE";
            lblNVTE.Size = new Size(66, 18);
            lblNVTE.TabIndex = 29;
            lblNVTE.Text = "Teléfono";
            // 
            // lblNVDI
            // 
            lblNVDI.AutoSize = true;
            lblNVDI.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVDI.Location = new Point(284, 134);
            lblNVDI.Name = "lblNVDI";
            lblNVDI.Size = new Size(71, 18);
            lblNVDI.TabIndex = 12;
            lblNVDI.Text = "Dirección";
            // 
            // lblR2
            // 
            lblR2.AutoSize = true;
            lblR2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR2.ForeColor = Color.Red;
            lblR2.Location = new Point(61, 209);
            lblR2.Name = "lblR2";
            lblR2.Size = new Size(16, 20);
            lblR2.TabIndex = 10;
            lblR2.Text = "*";
            // 
            // lblR1
            // 
            lblR1.AutoSize = true;
            lblR1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR1.ForeColor = Color.Red;
            lblR1.Location = new Point(74, 52);
            lblR1.Name = "lblR1";
            lblR1.Size = new Size(16, 20);
            lblR1.TabIndex = 6;
            lblR1.Text = "*";
            // 
            // lblNVCI
            // 
            lblNVCI.AutoSize = true;
            lblNVCI.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCI.Location = new Point(12, 209);
            lblNVCI.Name = "lblNVCI";
            lblNVCI.Size = new Size(54, 18);
            lblNVCI.TabIndex = 9;
            lblNVCI.Text = "Cédula";
            // 
            // lblNVNCO
            // 
            lblNVNCO.AutoSize = true;
            lblNVNCO.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVNCO.Location = new Point(10, 54);
            lblNVNCO.Name = "lblNVNCO";
            lblNVNCO.Size = new Size(70, 18);
            lblNVNCO.TabIndex = 5;
            lblNVNCO.Text = "Nombres";
            // 
            // lblNVNC
            // 
            lblNVNC.AutoSize = true;
            lblNVNC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVNC.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVNC.Location = new Point(56, 17);
            lblNVNC.Name = "lblNVNC";
            lblNVNC.Size = new Size(178, 18);
            lblNVNC.TabIndex = 4;
            lblNVNC.Text = "Información del cliente";
            // 
            // picNVI
            // 
            picNVI.Image = (Image)resources.GetObject("picNVI.Image");
            picNVI.Location = new Point(20, 10);
            picNVI.Margin = new Padding(3, 2, 3, 2);
            picNVI.Name = "picNVI";
            picNVI.Size = new Size(32, 25);
            picNVI.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVI.TabIndex = 3;
            picNVI.TabStop = false;
            // 
            // FrmNuevoClienteV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 409);
            Controls.Add(pnlNVinfoNC);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmNuevoClienteV";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Cliente";
            Load += FrmNuevoClienteV_Load;
            pnlNVinfoNC.ResumeLayout(false);
            pnlNVinfoNC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNVinfoNC;
        private Label lblNVCOE;
        private Label lblR3;
        private Label lblNVTE;
        private Label lblNVDI;
        private Label lblR2;
        private Label lblR1;
        private Label lblNVCI;
        private Label lblNVNCO;
        private Label lblNVNC;
        private PictureBox picNVI;
        private TextBox txtTE;
        private TextBox txtCI;
        private TextBox txtNC;
        private TextBox txtCOE;
        private TextBox txtDI;
        private Button btnNCG;
        private Button btnNVC;
        private Label lblNCApe;
        private TextBox txtApe;
        private Label label1;
    }
}