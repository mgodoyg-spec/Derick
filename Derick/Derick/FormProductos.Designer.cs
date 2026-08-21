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
            pnl_agg2 = new Panel();
            lblSalirV = new Label();
            pnlBusqueda = new Panel();
            cmb_agg2 = new ComboBox();
            cmb_agg1 = new ComboBox();
            txt1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_buscar = new Button();
            btn_limpiar = new Button();
            lbl_agg2 = new Label();
            lbl_agg3 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pic_agg1 = new PictureBox();
            lbl_agg1 = new Label();
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
            img_icons = new ImageList(components);
            pnl_conagg.SuspendLayout();
            pnl_agg2.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_agg).BeginInit();
            SuspendLayout();
            // 
            // pnl_conagg
            // 
            pnl_conagg.BackColor = Color.FromArgb(244, 246, 249);
            pnl_conagg.Controls.Add(pnl_agg2);
            pnl_conagg.Dock = DockStyle.Fill;
            pnl_conagg.Location = new Point(0, 0);
            pnl_conagg.Margin = new Padding(3, 2, 3, 2);
            pnl_conagg.Name = "pnl_conagg";
            pnl_conagg.Size = new Size(1186, 651);
            pnl_conagg.TabIndex = 1;
            // 
            // pnl_agg2
            // 
            pnl_agg2.BackColor = Color.White;
            pnl_agg2.Controls.Add(lblSalirV);
            pnl_agg2.Controls.Add(pnlBusqueda);
            pnl_agg2.Controls.Add(pictureBox2);
            pnl_agg2.Controls.Add(button1);
            pnl_agg2.Controls.Add(pic_agg1);
            pnl_agg2.Controls.Add(lbl_agg1);
            pnl_agg2.Controls.Add(dvg_agg);
            pnl_agg2.Location = new Point(13, 13);
            pnl_agg2.Margin = new Padding(3, 2, 3, 2);
            pnl_agg2.Name = "pnl_agg2";
            pnl_agg2.Size = new Size(1150, 630);
            pnl_agg2.TabIndex = 6;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1122, 6);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 31;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(cmb_agg2);
            pnlBusqueda.Controls.Add(cmb_agg1);
            pnlBusqueda.Controls.Add(txt1);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(btn_buscar);
            pnlBusqueda.Controls.Add(btn_limpiar);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Controls.Add(lbl_agg3);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 27;
            // 
            // cmb_agg2
            // 
            cmb_agg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg2.Font = new Font("Calibri", 14.25F);
            cmb_agg2.FormattingEnabled = true;
            cmb_agg2.Location = new Point(625, 6);
            cmb_agg2.Margin = new Padding(3, 2, 3, 2);
            cmb_agg2.Name = "cmb_agg2";
            cmb_agg2.Size = new Size(121, 31);
            cmb_agg2.TabIndex = 14;
            // 
            // cmb_agg1
            // 
            cmb_agg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg1.Font = new Font("Calibri", 14.25F);
            cmb_agg1.FormattingEnabled = true;
            cmb_agg1.Location = new Point(440, 7);
            cmb_agg1.Margin = new Padding(3, 2, 3, 2);
            cmb_agg1.Name = "cmb_agg1";
            cmb_agg1.Size = new Size(121, 31);
            cmb_agg1.TabIndex = 14;
            // 
            // txt1
            // 
            txt1.Font = new Font("Calibri", 12F);
            txt1.ForeColor = Color.Gray;
            txt1.Location = new Point(49, 9);
            txt1.Margin = new Padding(3, 2, 3, 2);
            txt1.Name = "txt1";
            txt1.PlaceholderText = " Buscar producto";
            txt1.Size = new Size(307, 27);
            txt1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(13, 154, 64);
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buscar.Location = new Point(771, 4);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(99, 33);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "     Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.White;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(889, 7);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(98, 28);
            btn_limpiar.TabIndex = 21;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // lbl_agg2
            // 
            lbl_agg2.AutoSize = true;
            lbl_agg2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl_agg2.ForeColor = Color.Black;
            lbl_agg2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg2.Location = new Point(366, 12);
            lbl_agg2.Name = "lbl_agg2";
            lbl_agg2.Size = new Size(78, 19);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Categoría:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_agg3
            // 
            lbl_agg3.AutoSize = true;
            lbl_agg3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl_agg3.ForeColor = Color.Black;
            lbl_agg3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg3.Location = new Point(570, 12);
            lbl_agg3.Name = "lbl_agg3";
            lbl_agg3.Size = new Size(59, 19);
            lbl_agg3.TabIndex = 17;
            lbl_agg3.Text = "Estado:";
            lbl_agg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 14);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 59, 186);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(893, 6);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(223, 39);
            button1.TabIndex = 9;
            button1.Text = "Agregar producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pic_agg1
            // 
            pic_agg1.Image = (Image)resources.GetObject("pic_agg1.Image");
            pic_agg1.Location = new Point(7, 0);
            pic_agg1.Margin = new Padding(3, 2, 3, 2);
            pic_agg1.Name = "pic_agg1";
            pic_agg1.Size = new Size(43, 38);
            pic_agg1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_agg1.TabIndex = 2;
            pic_agg1.TabStop = false;
            // 
            // lbl_agg1
            // 
            lbl_agg1.AutoSize = true;
            lbl_agg1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl_agg1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl_agg1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg1.Location = new Point(56, 0);
            lbl_agg1.Name = "lbl_agg1";
            lbl_agg1.Size = new Size(196, 26);
            lbl_agg1.TabIndex = 1;
            lbl_agg1.Text = "Gestión de productos";
            lbl_agg1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dvg_agg
            // 
            dvg_agg.AllowUserToResizeColumns = false;
            dvg_agg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg_agg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_agg.BackgroundColor = Color.White;
            dvg_agg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg_agg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvg_agg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_agg.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clImagen, clNombreProducto, clCategoria, clTallas, clColores, clPrecio, clStock, clEstado, clEditar, clEliminar, clVerTodo });
            dvg_agg.Cursor = Cursors.Hand;
            dvg_agg.Location = new Point(7, 94);
            dvg_agg.Margin = new Padding(3, 2, 3, 2);
            dvg_agg.MultiSelect = false;
            dvg_agg.Name = "dvg_agg";
            dvg_agg.RowHeadersVisible = false;
            dvg_agg.RowHeadersWidth = 51;
            dvg_agg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_agg.Size = new Size(1126, 510);
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
            // img_icons
            // 
            img_icons.ColorDepth = ColorDepth.Depth32Bit;
            img_icons.ImageStream = (ImageListStreamer)resources.GetObject("img_icons.ImageStream");
            img_icons.TransparentColor = Color.Transparent;
            img_icons.Images.SetKeyName(0, "eliminar1.png");
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
            pnl_agg2.ResumeLayout(false);
            pnl_agg2.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_agg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_conagg;
        private Panel pnl_agg2;
        private DataGridView dvg_agg;
        private ComboBox cmb_agg1;
        private TextBox txt1;
        private PictureBox pic_agg1;
        private Label lbl_agg1;
        private Label lbl_agg2;
        private Button btn_buscar;
        private ComboBox cmb_agg2;
        private Label lbl_agg3;
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
        private PictureBox pictureBox2;
        private Panel pnlBusqueda;
        private Label lblSalirV;
    }
}