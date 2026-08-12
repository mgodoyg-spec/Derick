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
            btn_buscar = new Button();
            pnl_cmb2 = new Panel();
            cmb_agg2 = new ComboBox();
            lbl_agg3 = new Label();
            pnl_cmb1 = new Panel();
            cmb_agg1 = new ComboBox();
            btn_limpiar = new Button();
            lbl_agg2 = new Label();
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
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            txt1 = new TextBox();
            pic_agg1 = new PictureBox();
            lbl_agg1 = new Label();
            img_icons = new ImageList(components);
            pnl_conagg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_raya1).BeginInit();
            pnl_agg2.SuspendLayout();
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
            pnl_conagg.Margin = new Padding(3, 2, 3, 2);
            pnl_conagg.Name = "pnl_conagg";
            pnl_conagg.Size = new Size(1186, 651);
            pnl_conagg.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 102, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(946, 13);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(217, 38);
            button1.TabIndex = 9;
            button1.Text = "Agregar producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pic_raya1
            // 
            pic_raya1.BackColor = Color.FromArgb(0, 176, 80);
            pic_raya1.Location = new Point(66, 41);
            pic_raya1.Margin = new Padding(3, 2, 3, 2);
            pic_raya1.Name = "pic_raya1";
            pic_raya1.Size = new Size(225, 3);
            pic_raya1.TabIndex = 7;
            pic_raya1.TabStop = false;
            // 
            // pnl_agg2
            // 
            pnl_agg2.BackColor = Color.White;
            pnl_agg2.Controls.Add(btn_buscar);
            pnl_agg2.Controls.Add(pnl_cmb2);
            pnl_agg2.Controls.Add(lbl_agg3);
            pnl_agg2.Controls.Add(pnl_cmb1);
            pnl_agg2.Controls.Add(btn_limpiar);
            pnl_agg2.Controls.Add(lbl_agg2);
            pnl_agg2.Controls.Add(dvg_agg);
            pnl_agg2.Controls.Add(panel9);
            pnl_agg2.Location = new Point(9, 57);
            pnl_agg2.Margin = new Padding(3, 2, 3, 2);
            pnl_agg2.Name = "pnl_agg2";
            pnl_agg2.Size = new Size(1165, 583);
            pnl_agg2.TabIndex = 6;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 176, 80);
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buscar.Location = new Point(880, 12);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(128, 37);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pnl_cmb2
            // 
            pnl_cmb2.BackColor = Color.White;
            pnl_cmb2.BorderStyle = BorderStyle.FixedSingle;
            pnl_cmb2.Controls.Add(cmb_agg2);
            pnl_cmb2.Location = new Point(584, 15);
            pnl_cmb2.Margin = new Padding(3, 2, 3, 2);
            pnl_cmb2.Name = "pnl_cmb2";
            pnl_cmb2.Padding = new Padding(9, 8, 9, 8);
            pnl_cmb2.Size = new Size(140, 34);
            pnl_cmb2.TabIndex = 16;
            // 
            // cmb_agg2
            // 
            cmb_agg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg2.FlatStyle = FlatStyle.Flat;
            cmb_agg2.FormattingEnabled = true;
            cmb_agg2.Location = new Point(11, 7);
            cmb_agg2.Margin = new Padding(3, 2, 3, 2);
            cmb_agg2.Name = "cmb_agg2";
            cmb_agg2.Size = new Size(119, 23);
            cmb_agg2.TabIndex = 14;
            // 
            // lbl_agg3
            // 
            lbl_agg3.AutoSize = true;
            lbl_agg3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg3.ForeColor = Color.Black;
            lbl_agg3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg3.Location = new Point(521, 24);
            lbl_agg3.Name = "lbl_agg3";
            lbl_agg3.Size = new Size(66, 18);
            lbl_agg3.TabIndex = 17;
            lbl_agg3.Text = "Estado:";
            lbl_agg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_cmb1
            // 
            pnl_cmb1.BackColor = Color.White;
            pnl_cmb1.BorderStyle = BorderStyle.FixedSingle;
            pnl_cmb1.Controls.Add(cmb_agg1);
            pnl_cmb1.Location = new Point(355, 15);
            pnl_cmb1.Margin = new Padding(3, 2, 3, 2);
            pnl_cmb1.Name = "pnl_cmb1";
            pnl_cmb1.Padding = new Padding(9, 8, 9, 8);
            pnl_cmb1.Size = new Size(151, 34);
            pnl_cmb1.TabIndex = 15;
            // 
            // cmb_agg1
            // 
            cmb_agg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg1.FlatStyle = FlatStyle.Flat;
            cmb_agg1.FormattingEnabled = true;
            cmb_agg1.Location = new Point(11, 7);
            cmb_agg1.Margin = new Padding(3, 2, 3, 2);
            cmb_agg1.Name = "cmb_agg1";
            cmb_agg1.Size = new Size(126, 23);
            cmb_agg1.TabIndex = 14;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.White;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(1026, 12);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(128, 38);
            btn_limpiar.TabIndex = 21;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lbl_agg2
            // 
            lbl_agg2.AutoSize = true;
            lbl_agg2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg2.ForeColor = Color.Black;
            lbl_agg2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg2.Location = new Point(269, 25);
            lbl_agg2.Name = "lbl_agg2";
            lbl_agg2.Size = new Size(86, 18);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Categoría:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dvg_agg
            // 
            dvg_agg.AllowUserToResizeColumns = false;
            dvg_agg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg_agg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_agg.BackgroundColor = Color.White;
            dvg_agg.BorderStyle = BorderStyle.None;
            dvg_agg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg_agg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvg_agg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_agg.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clImagen, clNombreProducto, clCategoria, clTallas, clColores, clPrecio, clStock, clEstado, clEditar, clEliminar, clVerTodo });
            dvg_agg.Location = new Point(10, 81);
            dvg_agg.Margin = new Padding(3, 2, 3, 2);
            dvg_agg.MultiSelect = false;
            dvg_agg.Name = "dvg_agg";
            dvg_agg.RowHeadersVisible = false;
            dvg_agg.RowHeadersWidth = 51;
            dvg_agg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_agg.Size = new Size(1144, 493);
            dvg_agg.TabIndex = 15;
            dvg_agg.CellClick += dvg_agg_CellClick;
            // 
            // clCodigo
            // 
            clCodigo.FillWeight = 147.593521F;
            clCodigo.HeaderText = "Código";
            clCodigo.Name = "clCodigo";
            // 
            // clImagen
            // 
            clImagen.FillWeight = 95.67327F;
            clImagen.HeaderText = "Imagen";
            clImagen.Name = "clImagen";
            // 
            // clNombreProducto
            // 
            clNombreProducto.FillWeight = 95.67327F;
            clNombreProducto.HeaderText = "Nombre del producto";
            clNombreProducto.Name = "clNombreProducto";
            // 
            // clCategoria
            // 
            clCategoria.FillWeight = 95.67327F;
            clCategoria.HeaderText = "Categoría";
            clCategoria.Name = "clCategoria";
            // 
            // clTallas
            // 
            clTallas.FillWeight = 95.67327F;
            clTallas.HeaderText = "Talla(s)";
            clTallas.Name = "clTallas";
            // 
            // clColores
            // 
            clColores.FillWeight = 95.67327F;
            clColores.HeaderText = "Color(es)";
            clColores.Name = "clColores";
            // 
            // clPrecio
            // 
            clPrecio.FillWeight = 95.67327F;
            clPrecio.HeaderText = "Precio";
            clPrecio.Name = "clPrecio";
            // 
            // clStock
            // 
            clStock.FillWeight = 95.67327F;
            clStock.HeaderText = "Stock";
            clStock.Name = "clStock";
            // 
            // clEstado
            // 
            clEstado.FillWeight = 95.67327F;
            clEstado.HeaderText = "Estado";
            clEstado.Name = "clEstado";
            // 
            // clEditar
            // 
            clEditar.FillWeight = 95.67327F;
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 55;
            clEditar.Name = "clEditar";
            // 
            // clEliminar
            // 
            clEliminar.FillWeight = 95.67327F;
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 55;
            clEliminar.Name = "clEliminar";
            // 
            // clVerTodo
            // 
            clVerTodo.FillWeight = 95.67327F;
            clVerTodo.HeaderText = "Ver Todo";
            clVerTodo.MinimumWidth = 55;
            clVerTodo.Name = "clVerTodo";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(txt1);
            panel9.Location = new Point(10, 15);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(9, 8, 9, 8);
            panel9.Size = new Size(254, 34);
            panel9.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txt1
            // 
            txt1.BorderStyle = BorderStyle.None;
            txt1.Font = new Font("Segoe UI", 10.8F);
            txt1.ForeColor = Color.Gray;
            txt1.Location = new Point(48, 7);
            txt1.Margin = new Padding(3, 2, 3, 2);
            txt1.Name = "txt1";
            txt1.PlaceholderText = "          Buscar producto";
            txt1.Size = new Size(192, 20);
            txt1.TabIndex = 7;
            // 
            // pic_agg1
            // 
            pic_agg1.Image = (Image)resources.GetObject("pic_agg1.Image");
            pic_agg1.Location = new Point(9, 9);
            pic_agg1.Margin = new Padding(3, 2, 3, 2);
            pic_agg1.Name = "pic_agg1";
            pic_agg1.Size = new Size(52, 38);
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
            lbl_agg1.Location = new Point(61, 17);
            lbl_agg1.Name = "lbl_agg1";
            lbl_agg1.Size = new Size(210, 24);
            lbl_agg1.TabIndex = 1;
            lbl_agg1.Text = "Gestión de productos";
            lbl_agg1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // img_icons
            // 
            img_icons.ColorDepth = ColorDepth.Depth32Bit;
            img_icons.ImageStream = (ImageListStreamer)resources.GetObject("img_icons.ImageStream");
            img_icons.TransparentColor = Color.Transparent;
            img_icons.Images.SetKeyName(0, "editar (1).png");
            img_icons.Images.SetKeyName(1, "contenedor-de-basura.png");
            img_icons.Images.SetKeyName(2, "ojo2.png");
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_conagg);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load_1;
            pnl_conagg.ResumeLayout(false);
            pnl_conagg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_raya1).EndInit();
            pnl_agg2.ResumeLayout(false);
            pnl_agg2.PerformLayout();
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
        private TextBox txt1;
        private PictureBox pic_agg1;
        private Label lbl_agg1;
        private PictureBox pic_raya1;
        private Label lbl_agg2;
        private Button btn_buscar;
        private Panel pnl_cmb2;
        private ComboBox cmb_agg2;
        private Label lbl_agg3;
        private Panel pnl_cmb1;
        private Button btn_limpiar;
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