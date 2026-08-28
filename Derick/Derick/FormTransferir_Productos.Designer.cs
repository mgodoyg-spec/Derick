namespace Derick
{
    partial class FormTransferir_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferir_Productos));
            panel1 = new Panel();
            btnCancelar = new Button();
            btnTransferir = new Button();
            nud_cantidad = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            lbl_texto = new Label();
            label9 = new Label();
            label7 = new Label();
            cmb_colores = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            cmb_tallas = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            cmb_productos = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            cmb_sucursalDestino = new ComboBox();
            label2 = new Label();
            label11 = new Label();
            cmb_sucursalOrigen = new ComboBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            pic1_e = new PictureBox();
            lbl1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 246, 249);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnTransferir);
            panel1.Controls.Add(nud_cantidad);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lbl_texto);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmb_colores);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmb_tallas);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmb_productos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmb_sucursalDestino);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cmb_sucursalOrigen);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pic1_e);
            panel1.Controls.Add(lbl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 429);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(133, 368);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 46);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.FromArgb(4, 59, 186);
            btnTransferir.Cursor = Cursors.Hand;
            btnTransferir.FlatAppearance.BorderSize = 0;
            btnTransferir.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btnTransferir.ForeColor = Color.White;
            btnTransferir.Image = (Image)resources.GetObject("btnTransferir.Image");
            btnTransferir.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransferir.Location = new Point(351, 368);
            btnTransferir.Margin = new Padding(3, 2, 3, 2);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(193, 46);
            btnTransferir.TabIndex = 80;
            btnTransferir.Text = "      Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(302, 159);
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(242, 23);
            nud_cantidad.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(448, 137);
            label13.Name = "label13";
            label13.Size = new Size(17, 19);
            label13.TabIndex = 78;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label14.Location = new Point(302, 137);
            label14.Name = "label14";
            label14.Size = new Size(149, 19);
            label14.TabIndex = 77;
            label14.Text = "Cantidad a transferir";
            // 
            // lbl_texto
            // 
            lbl_texto.BackColor = Color.White;
            lbl_texto.BorderStyle = BorderStyle.Fixed3D;
            lbl_texto.Location = new Point(302, 97);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(242, 23);
            lbl_texto.TabIndex = 76;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label9.Location = new Point(302, 74);
            label9.Name = "label9";
            label9.Size = new Size(191, 19);
            label9.TabIndex = 75;
            label9.Text = "Stock disponible en origen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(158, 267);
            label7.Name = "label7";
            label7.Size = new Size(17, 19);
            label7.TabIndex = 74;
            label7.Text = "*";
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(116, 288);
            cmb_colores.Margin = new Padding(3, 2, 3, 2);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(141, 23);
            cmb_colores.TabIndex = 73;
            cmb_colores.SelectedIndexChanged += cmb_colores_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.Location = new Point(116, 267);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 72;
            label8.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(47, 267);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 71;
            label5.Text = "*";
            // 
            // cmb_tallas
            // 
            cmb_tallas.FormattingEnabled = true;
            cmb_tallas.Location = new Point(5, 288);
            cmb_tallas.Margin = new Padding(3, 2, 3, 2);
            cmb_tallas.Name = "cmb_tallas";
            cmb_tallas.Size = new Size(79, 23);
            cmb_tallas.TabIndex = 70;
            cmb_tallas.SelectedIndexChanged += cmb_tallas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(5, 267);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 69;
            label6.Text = "Talla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(80, 201);
            label3.Name = "label3";
            label3.Size = new Size(17, 19);
            label3.TabIndex = 68;
            label3.Text = "*";
            // 
            // cmb_productos
            // 
            cmb_productos.FormattingEnabled = true;
            cmb_productos.Location = new Point(5, 222);
            cmb_productos.Margin = new Padding(3, 2, 3, 2);
            cmb_productos.Name = "cmb_productos";
            cmb_productos.Size = new Size(252, 23);
            cmb_productos.TabIndex = 67;
            cmb_productos.SelectedIndexChanged += cmb_productos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(5, 201);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 66;
            label4.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(120, 137);
            label1.Name = "label1";
            label1.Size = new Size(17, 19);
            label1.TabIndex = 65;
            label1.Text = "*";
            // 
            // cmb_sucursalDestino
            // 
            cmb_sucursalDestino.FormattingEnabled = true;
            cmb_sucursalDestino.Location = new Point(5, 158);
            cmb_sucursalDestino.Margin = new Padding(3, 2, 3, 2);
            cmb_sucursalDestino.Name = "cmb_sucursalDestino";
            cmb_sucursalDestino.Size = new Size(252, 23);
            cmb_sucursalDestino.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 137);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 63;
            label2.Text = "Sucursal destino";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(116, 74);
            label11.Name = "label11";
            label11.Size = new Size(17, 19);
            label11.TabIndex = 62;
            label11.Text = "*";
            // 
            // cmb_sucursalOrigen
            // 
            cmb_sucursalOrigen.FormattingEnabled = true;
            cmb_sucursalOrigen.Location = new Point(5, 95);
            cmb_sucursalOrigen.Margin = new Padding(3, 2, 3, 2);
            cmb_sucursalOrigen.Name = "cmb_sucursalOrigen";
            cmb_sucursalOrigen.Size = new Size(252, 23);
            cmb_sucursalOrigen.TabIndex = 61;
            cmb_sucursalOrigen.SelectedIndexChanged += cmb_sucursalOrigen_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label12.Location = new Point(5, 74);
            label12.Name = "label12";
            label12.Size = new Size(114, 19);
            label12.TabIndex = 60;
            label12.Text = "Sucursal origen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detalleazul;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(48, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 14);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // pic1_e
            // 
            pic1_e.Image = (Image)resources.GetObject("pic1_e.Image");
            pic1_e.Location = new Point(5, 6);
            pic1_e.Margin = new Padding(3, 2, 3, 2);
            pic1_e.Name = "pic1_e";
            pic1_e.Size = new Size(42, 42);
            pic1_e.SizeMode = PictureBoxSizeMode.Zoom;
            pic1_e.TabIndex = 48;
            pic1_e.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(4, 59, 186);
            lbl1.Location = new Point(47, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(178, 24);
            lbl1.TabIndex = 49;
            lbl1.Text = "Transferir productos";
            // 
            // FormTransferir_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 429);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransferir_Productos";
            Text = "FormTransferir_Productos";
            Load += FormTransferir_Productos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pic1_e;
        private Label lbl1;
        private Label label5;
        private ComboBox cmb_tallas;
        private Label label6;
        private Label label3;
        private ComboBox cmb_productos;
        private Label label4;
        private Label label1;
        private ComboBox cmb_sucursalDestino;
        private Label label2;
        private Label label11;
        private ComboBox cmb_sucursalOrigen;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lbl_texto;
        private Label label9;
        private Label label7;
        private ComboBox cmb_colores;
        private Label label8;
        private NumericUpDown nud_cantidad;
        private Button btnTransferir;
        private Button btnCancelar;
    }
}