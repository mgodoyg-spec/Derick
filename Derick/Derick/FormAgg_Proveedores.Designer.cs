namespace Derick
{
    partial class FormAgg_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgg_Proveedores));
            pnlCont1 = new Panel();
            btnGuardarProv = new Button();
            cmb_Estado = new ComboBox();
            lbl06 = new Label();
            txt_DRC = new TextBox();
            lbl05 = new Label();
            txt_CE = new TextBox();
            lbl04 = new Label();
            txt_TL = new TextBox();
            lbl03 = new Label();
            txt_CNC = new TextBox();
            lbl02 = new Label();
            txt_NP = new TextBox();
            lbl01 = new Label();
            panel1 = new Panel();
            btn_cerrar = new PictureBox();
            lbl00 = new Label();
            pic01 = new PictureBox();
            pnlCont1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic01).BeginInit();
            SuspendLayout();
            // 
            // pnlCont1
            // 
            pnlCont1.BackColor = Color.FromArgb(244, 246, 249);
            pnlCont1.Controls.Add(btnGuardarProv);
            pnlCont1.Controls.Add(cmb_Estado);
            pnlCont1.Controls.Add(lbl06);
            pnlCont1.Controls.Add(txt_DRC);
            pnlCont1.Controls.Add(lbl05);
            pnlCont1.Controls.Add(txt_CE);
            pnlCont1.Controls.Add(lbl04);
            pnlCont1.Controls.Add(txt_TL);
            pnlCont1.Controls.Add(lbl03);
            pnlCont1.Controls.Add(txt_CNC);
            pnlCont1.Controls.Add(lbl02);
            pnlCont1.Controls.Add(txt_NP);
            pnlCont1.Controls.Add(lbl01);
            pnlCont1.Controls.Add(panel1);
            pnlCont1.Dock = DockStyle.Fill;
            pnlCont1.Location = new Point(0, 0);
            pnlCont1.Margin = new Padding(3, 2, 3, 2);
            pnlCont1.Name = "pnlCont1";
            pnlCont1.Size = new Size(340, 454);
            pnlCont1.TabIndex = 0;
            // 
            // btnGuardarProv
            // 
            btnGuardarProv.BackColor = Color.FromArgb(0, 102, 255);
            btnGuardarProv.Cursor = Cursors.Hand;
            btnGuardarProv.FlatAppearance.BorderSize = 0;
            btnGuardarProv.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarProv.ForeColor = Color.White;
            btnGuardarProv.Image = (Image)resources.GetObject("btnGuardarProv.Image");
            btnGuardarProv.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarProv.Location = new Point(150, 398);
            btnGuardarProv.Margin = new Padding(3, 2, 3, 2);
            btnGuardarProv.Name = "btnGuardarProv";
            btnGuardarProv.Size = new Size(178, 45);
            btnGuardarProv.TabIndex = 28;
            btnGuardarProv.Text = "    Guardar proveedor";
            btnGuardarProv.UseVisualStyleBackColor = false;
            btnGuardarProv.Click += btnGuardarProv_Click;
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Items.AddRange(new object[] { "Avtico", "Inactivo" });
            cmb_Estado.Location = new Point(10, 334);
            cmb_Estado.Margin = new Padding(3, 2, 3, 2);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(252, 23);
            cmb_Estado.TabIndex = 14;
            // 
            // lbl06
            // 
            lbl06.AutoSize = true;
            lbl06.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl06.Location = new Point(10, 315);
            lbl06.Name = "lbl06";
            lbl06.Size = new Size(55, 18);
            lbl06.TabIndex = 13;
            lbl06.Text = "Estado";
            // 
            // txt_DRC
            // 
            txt_DRC.Location = new Point(10, 281);
            txt_DRC.Margin = new Padding(3, 2, 3, 2);
            txt_DRC.MaxLength = 200;
            txt_DRC.Name = "txt_DRC";
            txt_DRC.PlaceholderText = "Ingrese la dirección";
            txt_DRC.Size = new Size(252, 23);
            txt_DRC.TabIndex = 12;
            // 
            // lbl05
            // 
            lbl05.AutoSize = true;
            lbl05.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl05.Location = new Point(10, 262);
            lbl05.Name = "lbl05";
            lbl05.Size = new Size(71, 18);
            lbl05.TabIndex = 11;
            lbl05.Text = "Dirección";
            // 
            // txt_CE
            // 
            txt_CE.Location = new Point(10, 230);
            txt_CE.Margin = new Padding(3, 2, 3, 2);
            txt_CE.MaxLength = 200;
            txt_CE.Name = "txt_CE";
            txt_CE.PlaceholderText = "Ingrese el correo electrónico";
            txt_CE.Size = new Size(252, 23);
            txt_CE.TabIndex = 10;
            // 
            // lbl04
            // 
            lbl04.AutoSize = true;
            lbl04.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl04.Location = new Point(10, 212);
            lbl04.Name = "lbl04";
            lbl04.Size = new Size(132, 18);
            lbl04.TabIndex = 9;
            lbl04.Text = "Correo electrónico";
            // 
            // txt_TL
            // 
            txt_TL.Location = new Point(10, 176);
            txt_TL.Margin = new Padding(3, 2, 3, 2);
            txt_TL.MaxLength = 10;
            txt_TL.Name = "txt_TL";
            txt_TL.PlaceholderText = "Ingrese el teléfono";
            txt_TL.Size = new Size(252, 23);
            txt_TL.TabIndex = 8;
            txt_TL.KeyPress += txt_TL_KeyPress;
            // 
            // lbl03
            // 
            lbl03.AutoSize = true;
            lbl03.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl03.Location = new Point(10, 158);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(66, 18);
            lbl03.TabIndex = 7;
            lbl03.Text = "Teléfono";
            // 
            // txt_CNC
            // 
            txt_CNC.Location = new Point(8, 128);
            txt_CNC.Margin = new Padding(3, 2, 3, 2);
            txt_CNC.MaxLength = 55;
            txt_CNC.Name = "txt_CNC";
            txt_CNC.PlaceholderText = "Ingrese el nombre del contacto";
            txt_CNC.Size = new Size(252, 23);
            txt_CNC.TabIndex = 6;
            txt_CNC.KeyPress += txt_CNC_KeyPress;
            // 
            // lbl02
            // 
            lbl02.AutoSize = true;
            lbl02.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl02.Location = new Point(8, 109);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(69, 18);
            lbl02.TabIndex = 5;
            lbl02.Text = "Contacto";
            // 
            // txt_NP
            // 
            txt_NP.Location = new Point(8, 78);
            txt_NP.Margin = new Padding(3, 2, 3, 2);
            txt_NP.MaxLength = 100;
            txt_NP.Name = "txt_NP";
            txt_NP.PlaceholderText = "Ingrese el nombre del proveedor";
            txt_NP.Size = new Size(252, 23);
            txt_NP.TabIndex = 4;
            txt_NP.KeyPress += txt_NP_KeyPress;
            // 
            // lbl01
            // 
            lbl01.AutoSize = true;
            lbl01.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl01.Location = new Point(8, 59);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(156, 18);
            lbl01.TabIndex = 3;
            lbl01.Text = "Nombre del proveedor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 22, 50);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(lbl00);
            panel1.Controls.Add(pic01);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 51);
            panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(294, 14);
            btn_cerrar.Margin = new Padding(3, 2, 3, 2);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(27, 23);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 2;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // lbl00
            // 
            lbl00.AutoSize = true;
            lbl00.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl00.ForeColor = Color.White;
            lbl00.Location = new Point(72, 14);
            lbl00.Name = "lbl00";
            lbl00.Size = new Size(170, 24);
            lbl00.TabIndex = 3;
            lbl00.Text = "Agregar proveedor";
            // 
            // pic01
            // 
            pic01.Image = (Image)resources.GetObject("pic01.Image");
            pic01.Location = new Point(6, 3);
            pic01.Margin = new Padding(3, 2, 3, 2);
            pic01.Name = "pic01";
            pic01.Size = new Size(60, 41);
            pic01.SizeMode = PictureBoxSizeMode.Zoom;
            pic01.TabIndex = 2;
            pic01.TabStop = false;
            // 
            // FormAgg_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 454);
            Controls.Add(pnlCont1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgg_Proveedores";
            Text = "FormAgg_Proveedores";
            pnlCont1.ResumeLayout(false);
            pnlCont1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic01).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCont1;
        private Panel panel1;
        private Label lbl00;
        private PictureBox pic01;
        private PictureBox btn_cerrar;
        private TextBox txt_DRC;
        private Label lbl05;
        private TextBox txt_CE;
        private Label lbl04;
        private TextBox txt_TL;
        private Label lbl03;
        private TextBox txt_CNC;
        private Label lbl02;
        private TextBox txt_NP;
        private Label lbl01;
        private ComboBox cmb_Estado;
        private Label lbl06;
        private Button btnGuardarProv;
    }
}