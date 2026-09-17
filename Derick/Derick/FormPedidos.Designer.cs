namespace Derick
{
    partial class FormPedidos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            pnlcont1 = new Panel();
            label5 = new Label();
            cmb_sucursal = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            btn_abr = new Button();
            lbl8 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_color1 = new Button();
            btn_color = new Button();
            lbl_color = new Label();
            btn_tallas1 = new Button();
            lbl_tallas = new Label();
            btn_tallas = new Button();
            lbl6 = new Label();
            lbl5 = new Label();
            txt_observacion = new TextBox();
            lbl10 = new Label();
            dtp_fechaFin = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            dtp_fechaInicio = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            label8 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pic1_e = new PictureBox();
            lbl1 = new Label();
            pic2_e = new PictureBox();
            btn_pedido = new Button();
            cmb_proveedor = new ComboBox();
            lbl9 = new Label();
            txt_producto = new TextBox();
            lbl3 = new Label();
            cmTallas = new ContextMenuStrip(components);
            cmColores = new ContextMenuStrip(components);
            pnlcont1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2_e).BeginInit();
            SuspendLayout();
            // 
            // pnlcont1
            // 
            pnlcont1.BackColor = Color.FromArgb(244, 246, 249);
            pnlcont1.Controls.Add(label5);
            pnlcont1.Controls.Add(cmb_sucursal);
            pnlcont1.Controls.Add(label9);
            pnlcont1.Controls.Add(label4);
            pnlcont1.Controls.Add(btn_abr);
            pnlcont1.Controls.Add(lbl8);
            pnlcont1.Controls.Add(label6);
            pnlcont1.Controls.Add(label7);
            pnlcont1.Controls.Add(btn_color1);
            pnlcont1.Controls.Add(btn_color);
            pnlcont1.Controls.Add(lbl_color);
            pnlcont1.Controls.Add(btn_tallas1);
            pnlcont1.Controls.Add(lbl_tallas);
            pnlcont1.Controls.Add(btn_tallas);
            pnlcont1.Controls.Add(lbl6);
            pnlcont1.Controls.Add(lbl5);
            pnlcont1.Controls.Add(txt_observacion);
            pnlcont1.Controls.Add(lbl10);
            pnlcont1.Controls.Add(dtp_fechaFin);
            pnlcont1.Controls.Add(label1);
            pnlcont1.Controls.Add(label3);
            pnlcont1.Controls.Add(dtp_fechaInicio);
            pnlcont1.Controls.Add(label11);
            pnlcont1.Controls.Add(label12);
            pnlcont1.Controls.Add(label8);
            pnlcont1.Controls.Add(label2);
            pnlcont1.Controls.Add(pictureBox1);
            pnlcont1.Controls.Add(pic1_e);
            pnlcont1.Controls.Add(lbl1);
            pnlcont1.Controls.Add(pic2_e);
            pnlcont1.Controls.Add(btn_pedido);
            pnlcont1.Controls.Add(cmb_proveedor);
            pnlcont1.Controls.Add(lbl9);
            pnlcont1.Controls.Add(txt_producto);
            pnlcont1.Controls.Add(lbl3);
            pnlcont1.Dock = DockStyle.Fill;
            pnlcont1.Location = new Point(0, 0);
            pnlcont1.Margin = new Padding(3, 2, 3, 2);
            pnlcont1.Name = "pnlcont1";
            pnlcont1.Size = new Size(392, 687);
            pnlcont1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(73, 449);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 84;
            label5.Text = "*";
            // 
            // cmb_sucursal
            // 
            cmb_sucursal.FormattingEnabled = true;
            cmb_sucursal.Location = new Point(7, 470);
            cmb_sucursal.Margin = new Padding(3, 2, 3, 2);
            cmb_sucursal.Name = "cmb_sucursal";
            cmb_sucursal.Size = new Size(252, 23);
            cmb_sucursal.TabIndex = 83;
            cmb_sucursal.SelectedIndexChanged += cmb_sucursal_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label9.Location = new Point(7, 452);
            label9.Name = "label9";
            label9.Size = new Size(66, 19);
            label9.TabIndex = 82;
            label9.Text = "Sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(46, 396);
            label4.Name = "label4";
            label4.Size = new Size(17, 19);
            label4.TabIndex = 81;
            label4.Text = "*";
            // 
            // btn_abr
            // 
            btn_abr.Cursor = Cursors.Hand;
            btn_abr.FlatAppearance.BorderSize = 0;
            btn_abr.ForeColor = Color.Gray;
            btn_abr.Location = new Point(4, 414);
            btn_abr.Margin = new Padding(3, 2, 3, 2);
            btn_abr.Name = "btn_abr";
            btn_abr.Size = new Size(252, 24);
            btn_abr.TabIndex = 80;
            btn_abr.Text = "Configurar stock";
            btn_abr.UseVisualStyleBackColor = true;
            btn_abr.Click += btn_abr_Click;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl8.Location = new Point(4, 396);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(47, 19);
            lbl8.TabIndex = 79;
            lbl8.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(70, 219);
            label6.Name = "label6";
            label6.Size = new Size(17, 19);
            label6.TabIndex = 78;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(56, 168);
            label7.Name = "label7";
            label7.Size = new Size(17, 19);
            label7.TabIndex = 77;
            label7.Text = "*";
            // 
            // btn_color1
            // 
            btn_color1.BackgroundImage = (Image)resources.GetObject("btn_color1.BackgroundImage");
            btn_color1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_color1.Cursor = Cursors.Hand;
            btn_color1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_color1.Location = new Point(232, 239);
            btn_color1.Margin = new Padding(3, 2, 3, 2);
            btn_color1.Name = "btn_color1";
            btn_color1.Size = new Size(24, 21);
            btn_color1.TabIndex = 76;
            btn_color1.UseVisualStyleBackColor = true;
            btn_color1.Visible = false;
            btn_color1.Click += btn_color1_Click;
            // 
            // btn_color
            // 
            btn_color.BackgroundImage = (Image)resources.GetObject("btn_color.BackgroundImage");
            btn_color.BackgroundImageLayout = ImageLayout.Zoom;
            btn_color.Cursor = Cursors.Hand;
            btn_color.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_color.Location = new Point(232, 239);
            btn_color.Margin = new Padding(3, 2, 3, 2);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(24, 21);
            btn_color.TabIndex = 75;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // lbl_color
            // 
            lbl_color.BackColor = Color.White;
            lbl_color.BorderStyle = BorderStyle.Fixed3D;
            lbl_color.FlatStyle = FlatStyle.Flat;
            lbl_color.ForeColor = Color.Gray;
            lbl_color.ImageAlign = ContentAlignment.MiddleRight;
            lbl_color.Location = new Point(4, 239);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(222, 21);
            lbl_color.TabIndex = 74;
            // 
            // btn_tallas1
            // 
            btn_tallas1.BackgroundImage = (Image)resources.GetObject("btn_tallas1.BackgroundImage");
            btn_tallas1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_tallas1.Cursor = Cursors.Hand;
            btn_tallas1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tallas1.Location = new Point(232, 187);
            btn_tallas1.Margin = new Padding(3, 2, 3, 2);
            btn_tallas1.Name = "btn_tallas1";
            btn_tallas1.Size = new Size(24, 21);
            btn_tallas1.TabIndex = 73;
            btn_tallas1.UseVisualStyleBackColor = true;
            btn_tallas1.Visible = false;
            btn_tallas1.Click += btn_tallas1_Click_1;
            // 
            // lbl_tallas
            // 
            lbl_tallas.BackColor = Color.White;
            lbl_tallas.BorderStyle = BorderStyle.Fixed3D;
            lbl_tallas.FlatStyle = FlatStyle.Flat;
            lbl_tallas.ForeColor = Color.Gray;
            lbl_tallas.ImageAlign = ContentAlignment.MiddleRight;
            lbl_tallas.Location = new Point(4, 187);
            lbl_tallas.Name = "lbl_tallas";
            lbl_tallas.Size = new Size(222, 21);
            lbl_tallas.TabIndex = 72;
            // 
            // btn_tallas
            // 
            btn_tallas.BackgroundImage = (Image)resources.GetObject("btn_tallas.BackgroundImage");
            btn_tallas.BackgroundImageLayout = ImageLayout.Zoom;
            btn_tallas.Cursor = Cursors.Hand;
            btn_tallas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tallas.Location = new Point(232, 187);
            btn_tallas.Margin = new Padding(3, 2, 3, 2);
            btn_tallas.Name = "btn_tallas";
            btn_tallas.Size = new Size(24, 21);
            btn_tallas.TabIndex = 71;
            btn_tallas.UseVisualStyleBackColor = true;
            btn_tallas.Click += btn_tallas_Click_1;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl6.Location = new Point(4, 219);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(69, 19);
            lbl6.TabIndex = 70;
            lbl6.Text = "Color(es)";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl5.Location = new Point(4, 167);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(56, 19);
            lbl5.TabIndex = 69;
            lbl5.Text = "Talla(s)";
            // 
            // txt_observacion
            // 
            txt_observacion.Location = new Point(7, 535);
            txt_observacion.Margin = new Padding(3, 2, 3, 2);
            txt_observacion.MaxLength = 250;
            txt_observacion.Multiline = true;
            txt_observacion.Name = "txt_observacion";
            txt_observacion.PlaceholderText = "Ej: Camisa Negra de algodón, de corte clásico...";
            txt_observacion.Size = new Size(252, 77);
            txt_observacion.TabIndex = 68;
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl10.Location = new Point(7, 508);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(94, 19);
            lbl10.TabIndex = 67;
            lbl10.Text = "Observación";
            // 
            // dtp_fechaFin
            // 
            dtp_fechaFin.Format = DateTimePickerFormat.Short;
            dtp_fechaFin.Location = new Point(4, 359);
            dtp_fechaFin.Name = "dtp_fechaFin";
            dtp_fechaFin.Size = new Size(252, 23);
            dtp_fechaFin.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(191, 350);
            label1.Name = "label1";
            label1.Size = new Size(17, 19);
            label1.TabIndex = 62;
            label1.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(4, 337);
            label3.Name = "label3";
            label3.Size = new Size(188, 19);
            label3.TabIndex = 61;
            label3.Text = "Fecha esperada de llegada";
            // 
            // dtp_fechaInicio
            // 
            dtp_fechaInicio.Format = DateTimePickerFormat.Short;
            dtp_fechaInicio.Location = new Point(4, 297);
            dtp_fechaInicio.Name = "dtp_fechaInicio";
            dtp_fechaInicio.Size = new Size(252, 23);
            dtp_fechaInicio.TabIndex = 60;
            dtp_fechaInicio.ValueChanged += dtp_fechaInicio_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(126, 275);
            label11.Name = "label11";
            label11.Size = new Size(17, 19);
            label11.TabIndex = 59;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label12.Location = new Point(4, 275);
            label12.Name = "label12";
            label12.Size = new Size(125, 19);
            label12.TabIndex = 57;
            label12.Text = "Fecha del pedido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(83, 114);
            label8.Name = "label8";
            label8.Size = new Size(17, 19);
            label8.TabIndex = 55;
            label8.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(159, 63);
            label2.Name = "label2";
            label2.Size = new Size(17, 19);
            label2.TabIndex = 49;
            label2.Text = "*";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detalleazul;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(43, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 14);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pic1_e
            // 
            pic1_e.Image = (Image)resources.GetObject("pic1_e.Image");
            pic1_e.Location = new Point(0, 0);
            pic1_e.Margin = new Padding(3, 2, 3, 2);
            pic1_e.Name = "pic1_e";
            pic1_e.Size = new Size(42, 42);
            pic1_e.SizeMode = PictureBoxSizeMode.Zoom;
            pic1_e.TabIndex = 0;
            pic1_e.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(4, 59, 186);
            lbl1.Location = new Point(42, 3);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(160, 24);
            lbl1.TabIndex = 1;
            lbl1.Text = "Ordenar producto";
            // 
            // pic2_e
            // 
            pic2_e.Cursor = Cursors.Hand;
            pic2_e.Image = (Image)resources.GetObject("pic2_e.Image");
            pic2_e.Location = new Point(362, 4);
            pic2_e.Margin = new Padding(3, 2, 3, 2);
            pic2_e.Name = "pic2_e";
            pic2_e.Size = new Size(27, 23);
            pic2_e.SizeMode = PictureBoxSizeMode.Zoom;
            pic2_e.TabIndex = 1;
            pic2_e.TabStop = false;
            pic2_e.Click += pic2_e_Click;
            // 
            // btn_pedido
            // 
            btn_pedido.BackColor = Color.FromArgb(4, 59, 186);
            btn_pedido.Cursor = Cursors.Hand;
            btn_pedido.FlatAppearance.BorderSize = 0;
            btn_pedido.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_pedido.ForeColor = Color.White;
            btn_pedido.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pedido.Location = new Point(191, 629);
            btn_pedido.Margin = new Padding(3, 2, 3, 2);
            btn_pedido.Name = "btn_pedido";
            btn_pedido.Size = new Size(193, 47);
            btn_pedido.TabIndex = 27;
            btn_pedido.Text = "Pedir producto";
            btn_pedido.UseVisualStyleBackColor = false;
            btn_pedido.Click += btn_pedido_Click;
            // 
            // cmb_proveedor
            // 
            cmb_proveedor.FormattingEnabled = true;
            cmb_proveedor.Location = new Point(4, 133);
            cmb_proveedor.Margin = new Padding(3, 2, 3, 2);
            cmb_proveedor.Name = "cmb_proveedor";
            cmb_proveedor.Size = new Size(252, 23);
            cmb_proveedor.TabIndex = 14;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl9.Location = new Point(4, 115);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(81, 19);
            lbl9.TabIndex = 13;
            lbl9.Text = "Proveedor";
            // 
            // txt_producto
            // 
            txt_producto.Location = new Point(4, 81);
            txt_producto.Margin = new Padding(3, 2, 3, 2);
            txt_producto.MaxLength = 100;
            txt_producto.Name = "txt_producto";
            txt_producto.PlaceholderText = "Ej: Camisa Negra";
            txt_producto.Size = new Size(252, 23);
            txt_producto.TabIndex = 4;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl3.Location = new Point(4, 63);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(158, 19);
            lbl3.TabIndex = 3;
            lbl3.Text = "Nombre del producto";
            // 
            // cmTallas
            // 
            cmTallas.AutoClose = false;
            cmTallas.ImageScalingSize = new Size(20, 20);
            cmTallas.Name = "cmTallas";
            cmTallas.Size = new Size(61, 4);
            cmTallas.Closed += cmTallas_Closed;
            // 
            // cmColores
            // 
            cmColores.AutoClose = false;
            cmColores.ImageScalingSize = new Size(20, 20);
            cmColores.Name = "cmColores";
            cmColores.Size = new Size(61, 4);
            cmColores.Closed += cmColores_Closed;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 687);
            Controls.Add(pnlcont1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            pnlcont1.ResumeLayout(false);
            pnlcont1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic1_e).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2_e).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlcont1;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pic1_e;
        private Label lbl1;
        private PictureBox pic2_e;
        private Button btn_pedido;
        private ComboBox cmb_proveedor;
        private Label lbl9;
        private TextBox txt_producto;
        private Label lbl3;
        private DateTimePicker dtp_fechaFin;
        private Label label1;
        private Label label3;
        private DateTimePicker dtp_fechaInicio;
        private TextBox txt_observacion;
        private Label lbl10;
        private Label label6;
        private Label label7;
        private Button btn_color1;
        private Button btn_color;
        private Label lbl_color;
        private Button btn_tallas1;
        private Label lbl_tallas;
        private Button btn_tallas;
        private Label lbl6;
        private Label lbl5;
        private ContextMenuStrip cmTallas;
        private ContextMenuStrip cmColores;
        private Label label4;
        private Button btn_abr;
        private Label lbl8;
        private Label label5;
        private ComboBox cmb_sucursal;
        private Label label9;
    }
}