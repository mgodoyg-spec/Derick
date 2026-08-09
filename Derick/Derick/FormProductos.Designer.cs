namespace Derick
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            pnl_conagg = new Panel();
            button1 = new Button();
            pic_raya1 = new PictureBox();
            pnl_agg2 = new Panel();
            pic_limpiar = new PictureBox();
            btn_limpiar = new Button();
            btn_buscar = new Button();
            pnl_cmb2 = new Panel();
            cmb_agg2 = new ComboBox();
            lbl_agg3 = new Label();
            pnl_cmb1 = new Panel();
            cmb_agg1 = new ComboBox();
            button6 = new Button();
            button2 = new Button();
            lbl_agg2 = new Label();
            button5 = new Button();
            dvg_agg = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clImagen = new DataGridViewImageColumn();
            clNombreProducto = new DataGridViewTextBoxColumn();
            clCategoria = new DataGridViewTextBoxColumn();
            clTallas = new DataGridViewTextBoxColumn();
            clColores = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            clStock = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            clVerTodo = new DataGridViewImageColumn();
            button3 = new Button();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button4 = new Button();
            pic_agg1 = new PictureBox();
            lbl_agg1 = new Label();
            img_icons = new ImageList(components);
            pnl_conagg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_raya1).BeginInit();
            pnl_agg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_limpiar).BeginInit();
            pnl_cmb2.SuspendLayout();
            pnl_cmb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg_agg).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).BeginInit();
            SuspendLayout();
            // 
            // pnl_conagg
            // 
            pnl_conagg.BackColor = Color.FromArgb(244, 246, 249);
            pnl_conagg.Controls.Add(button1);
            pnl_conagg.Controls.Add(pic_raya1);
            pnl_conagg.Controls.Add(pnl_agg2);
            pnl_conagg.Controls.Add(pic_agg1);
            pnl_conagg.Controls.Add(lbl_agg1);
            pnl_conagg.Dock = DockStyle.Fill;
            pnl_conagg.Location = new Point(0, 0);
            pnl_conagg.Name = "pnl_conagg";
            pnl_conagg.Size = new Size(1394, 889);
            pnl_conagg.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 102, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1125, 12);
            button1.Name = "button1";
            button1.Size = new Size(248, 47);
            button1.TabIndex = 9;
            button1.Text = "Agregar producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pic_raya1
            // 
            pic_raya1.BackColor = Color.FromArgb(0, 176, 80);
            pic_raya1.Location = new Point(76, 55);
            pic_raya1.Name = "pic_raya1";
            pic_raya1.Size = new Size(257, 4);
            pic_raya1.TabIndex = 7;
            pic_raya1.TabStop = false;
            // 
            // pnl_agg2
            // 
            pnl_agg2.BackColor = Color.White;
            pnl_agg2.Controls.Add(pic_limpiar);
            pnl_agg2.Controls.Add(btn_limpiar);
            pnl_agg2.Controls.Add(btn_buscar);
            pnl_agg2.Controls.Add(pnl_cmb2);
            pnl_agg2.Controls.Add(lbl_agg3);
            pnl_agg2.Controls.Add(pnl_cmb1);
            pnl_agg2.Controls.Add(button6);
            pnl_agg2.Controls.Add(button2);
            pnl_agg2.Controls.Add(lbl_agg2);
            pnl_agg2.Controls.Add(button5);
            pnl_agg2.Controls.Add(dvg_agg);
            pnl_agg2.Controls.Add(button3);
            pnl_agg2.Controls.Add(panel9);
            pnl_agg2.Controls.Add(button4);
            pnl_agg2.Location = new Point(10, 68);
            pnl_agg2.Name = "pnl_agg2";
            pnl_agg2.Size = new Size(1370, 713);
            pnl_agg2.TabIndex = 6;
            // 
            // pic_limpiar
            // 
            pic_limpiar.BackColor = Color.White;
            pic_limpiar.Image = (Image)resources.GetObject("pic_limpiar.Image");
            pic_limpiar.Location = new Point(1178, 20);
            pic_limpiar.Name = "pic_limpiar";
            pic_limpiar.Size = new Size(50, 47);
            pic_limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_limpiar.TabIndex = 22;
            pic_limpiar.TabStop = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.White;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(1178, 20);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(176, 47);
            btn_limpiar.TabIndex = 21;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 176, 80);
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buscar.Location = new Point(996, 20);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(176, 47);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            // 
            // pnl_cmb2
            // 
            pnl_cmb2.BackColor = Color.White;
            pnl_cmb2.BorderStyle = BorderStyle.FixedSingle;
            pnl_cmb2.Controls.Add(cmb_agg2);
            pnl_cmb2.Location = new Point(754, 20);
            pnl_cmb2.Name = "pnl_cmb2";
            pnl_cmb2.Padding = new Padding(10);
            pnl_cmb2.Size = new Size(218, 45);
            pnl_cmb2.TabIndex = 16;
            // 
            // cmb_agg2
            // 
            cmb_agg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg2.FlatStyle = FlatStyle.Flat;
            cmb_agg2.FormattingEnabled = true;
            cmb_agg2.Location = new Point(13, 9);
            cmb_agg2.Name = "cmb_agg2";
            cmb_agg2.Size = new Size(190, 28);
            cmb_agg2.TabIndex = 14;
            // 
            // lbl_agg3
            // 
            lbl_agg3.AutoSize = true;
            lbl_agg3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg3.ForeColor = Color.Black;
            lbl_agg3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg3.Location = new Point(670, 31);
            lbl_agg3.Name = "lbl_agg3";
            lbl_agg3.Size = new Size(78, 22);
            lbl_agg3.TabIndex = 17;
            lbl_agg3.Text = "Estado:";
            lbl_agg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_cmb1
            // 
            pnl_cmb1.BackColor = Color.White;
            pnl_cmb1.BorderStyle = BorderStyle.FixedSingle;
            pnl_cmb1.Controls.Add(cmb_agg1);
            pnl_cmb1.Location = new Point(437, 20);
            pnl_cmb1.Name = "pnl_cmb1";
            pnl_cmb1.Padding = new Padding(10);
            pnl_cmb1.Size = new Size(218, 45);
            pnl_cmb1.TabIndex = 15;
            // 
            // cmb_agg1
            // 
            cmb_agg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg1.FlatStyle = FlatStyle.Flat;
            cmb_agg1.FormattingEnabled = true;
            cmb_agg1.Location = new Point(13, 9);
            cmb_agg1.Name = "cmb_agg1";
            cmb_agg1.Size = new Size(190, 28);
            cmb_agg1.TabIndex = 14;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.LightGray;
            button6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            button6.Location = new Point(1262, 666);
            button6.Name = "button6";
            button6.Size = new Size(35, 35);
            button6.TabIndex = 20;
            button6.Text = ">>";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.LightGray;
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            button2.Location = new Point(1061, 666);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 16;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbl_agg2
            // 
            lbl_agg2.AutoSize = true;
            lbl_agg2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg2.ForeColor = Color.Black;
            lbl_agg2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg2.Location = new Point(330, 32);
            lbl_agg2.Name = "lbl_agg2";
            lbl_agg2.Size = new Size(103, 22);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Categoría:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.LightGray;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            button5.Location = new Point(1221, 666);
            button5.Name = "button5";
            button5.Size = new Size(35, 35);
            button5.TabIndex = 19;
            button5.Text = ">";
            button5.UseVisualStyleBackColor = true;
            // 
            // dvg_agg
            // 
            dvg_agg.AllowUserToResizeColumns = false;
            dvg_agg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_agg.BackgroundColor = Color.White;
            dvg_agg.BorderStyle = BorderStyle.None;
            dvg_agg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg_agg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvg_agg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_agg.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clImagen, clNombreProducto, clCategoria, clTallas, clColores, clPrecio, clStock, clEstado, clEditar, clEliminar, clVerTodo });
            dvg_agg.Location = new Point(11, 108);
            dvg_agg.MultiSelect = false;
            dvg_agg.Name = "dvg_agg";
            dvg_agg.RowHeadersVisible = false;
            dvg_agg.RowHeadersWidth = 51;
            dvg_agg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_agg.Size = new Size(1352, 536);
            dvg_agg.TabIndex = 15;
            dvg_agg.CellClick += dvg_agg_CellClick;
            // 
            // clCodigo
            // 
            clCodigo.FillWeight = 147.593521F;
            clCodigo.HeaderText = "Código";
            clCodigo.MinimumWidth = 6;
            clCodigo.Name = "clCodigo";
            // 
            // clImagen
            // 
            clImagen.FillWeight = 95.67327F;
            clImagen.HeaderText = "Imagen";
            clImagen.MinimumWidth = 6;
            clImagen.Name = "clImagen";
            // 
            // clNombreProducto
            // 
            clNombreProducto.FillWeight = 95.67327F;
            clNombreProducto.HeaderText = "Nombre del producto";
            clNombreProducto.MinimumWidth = 6;
            clNombreProducto.Name = "clNombreProducto";
            // 
            // clCategoria
            // 
            clCategoria.FillWeight = 95.67327F;
            clCategoria.HeaderText = "Categoría";
            clCategoria.MinimumWidth = 6;
            clCategoria.Name = "clCategoria";
            // 
            // clTallas
            // 
            clTallas.FillWeight = 95.67327F;
            clTallas.HeaderText = "Talla(s)";
            clTallas.MinimumWidth = 6;
            clTallas.Name = "clTallas";
            // 
            // clColores
            // 
            clColores.FillWeight = 95.67327F;
            clColores.HeaderText = "Color(es)";
            clColores.MinimumWidth = 6;
            clColores.Name = "clColores";
            // 
            // clPrecio
            // 
            clPrecio.FillWeight = 95.67327F;
            clPrecio.HeaderText = "Precio";
            clPrecio.MinimumWidth = 6;
            clPrecio.Name = "clPrecio";
            // 
            // clStock
            // 
            clStock.FillWeight = 95.67327F;
            clStock.HeaderText = "Stock";
            clStock.MinimumWidth = 6;
            clStock.Name = "clStock";
            // 
            // clEstado
            // 
            clEstado.FillWeight = 95.67327F;
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            // 
            // clEditar
            // 
            clEditar.FillWeight = 95.67327F;
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 6;
            clEditar.Name = "clEditar";
            // 
            // clEliminar
            // 
            clEliminar.FillWeight = 95.67327F;
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            // 
            // clVerTodo
            // 
            clVerTodo.FillWeight = 95.67327F;
            clVerTodo.HeaderText = "Ver Todo";
            clVerTodo.MinimumWidth = 6;
            clVerTodo.Name = "clVerTodo";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.LightGray;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            button3.Location = new Point(1102, 666);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 17;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(textBox2);
            panel9.Location = new Point(11, 20);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(10);
            panel9.Size = new Size(290, 45);
            panel9.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.8F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(5, 9);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "          Buscar producto";
            textBox2.Size = new Size(270, 24);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1161, 666);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 18;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = false;
            // 
            // pic_agg1
            // 
            pic_agg1.Image = (Image)resources.GetObject("pic_agg1.Image");
            pic_agg1.Location = new Point(10, 12);
            pic_agg1.Name = "pic_agg1";
            pic_agg1.Size = new Size(60, 50);
            pic_agg1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_agg1.TabIndex = 2;
            pic_agg1.TabStop = false;
            // 
            // lbl_agg1
            // 
            lbl_agg1.AutoSize = true;
            lbl_agg1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg1.ForeColor = Color.FromArgb(0, 176, 80);
            lbl_agg1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg1.Location = new Point(70, 23);
            lbl_agg1.Name = "lbl_agg1";
            lbl_agg1.Size = new Size(263, 29);
            lbl_agg1.TabIndex = 1;
            lbl_agg1.Text = "Gestión de productos";
            lbl_agg1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // img_icons
            // 
            img_icons.ColorDepth = ColorDepth.Depth32Bit;
            img_icons.ImageStream = (ImageListStreamer)resources.GetObject("img_icons.ImageStream");
            img_icons.TransparentColor = Color.Transparent;
            img_icons.Images.SetKeyName(0, "editar.png");
            img_icons.Images.SetKeyName(1, "eliminar.png");
            img_icons.Images.SetKeyName(2, "vertodo.png");
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1394, 889);
            Controls.Add(pnl_conagg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load_1;
            pnl_conagg.ResumeLayout(false);
            pnl_conagg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_raya1).EndInit();
            pnl_agg2.ResumeLayout(false);
            pnl_agg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_limpiar).EndInit();
            pnl_cmb2.ResumeLayout(false);
            pnl_cmb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg_agg).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_conagg;
        private Panel pnl_agg2;
        private DataGridView dvg_agg;
        private ComboBox cmb_agg1;
        private Panel panel9;
        private TextBox textBox2;
        private PictureBox pic_agg1;
        private Label lbl_agg1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pic_raya1;
        private Label lbl_agg2;
        private Button btn_buscar;
        private Panel pnl_cmb2;
        private ComboBox cmb_agg2;
        private Label lbl_agg3;
        private Panel pnl_cmb1;
        private Button btn_limpiar;
        private PictureBox pic_limpiar;
        private Button button1;
        private ImageList img_icons;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewImageColumn clImagen;
        private DataGridViewTextBoxColumn clNombreProducto;
        private DataGridViewTextBoxColumn clCategoria;
        private DataGridViewTextBoxColumn clTallas;
        private DataGridViewTextBoxColumn clColores;
        private DataGridViewTextBoxColumn clPrecio;
        private DataGridViewTextBoxColumn clStock;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
        private DataGridViewImageColumn clVerTodo;
    }
}