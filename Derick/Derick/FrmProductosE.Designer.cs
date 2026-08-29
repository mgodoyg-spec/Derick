namespace Derick
{
    partial class FrmProductosE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosE));
            pnl_conagg = new Panel();
            pnl_agg2 = new Panel();
            btn_transferir = new Button();
            lblSalirV = new Label();
            pnlBusqueda = new Panel();
            cmb_sucursal = new ComboBox();
            lbl2 = new Label();
            cmb_agg2 = new ComboBox();
            cmb_agg1 = new ComboBox();
            txt1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_limpiar = new Button();
            lbl_agg2 = new Label();
            lbl_agg3 = new Label();
            btn_agregarProducto = new Button();
            pictureBox2 = new PictureBox();
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
            pnl_conagg.TabIndex = 2;
            // 
            // pnl_agg2
            // 
            pnl_agg2.BackColor = Color.White;
            pnl_agg2.Controls.Add(btn_transferir);
            pnl_agg2.Controls.Add(lblSalirV);
            pnl_agg2.Controls.Add(pnlBusqueda);
            pnl_agg2.Controls.Add(btn_agregarProducto);
            pnl_agg2.Controls.Add(pictureBox2);
            pnl_agg2.Controls.Add(pic_agg1);
            pnl_agg2.Controls.Add(lbl_agg1);
            pnl_agg2.Controls.Add(dvg_agg);
            pnl_agg2.Location = new Point(13, 13);
            pnl_agg2.Margin = new Padding(3, 2, 3, 2);
            pnl_agg2.Name = "pnl_agg2";
            pnl_agg2.Size = new Size(1150, 630);
            pnl_agg2.TabIndex = 6;
            // 
            // btn_transferir
            // 
            btn_transferir.BackColor = Color.FromArgb(4, 59, 186);
            btn_transferir.Cursor = Cursors.Hand;
            btn_transferir.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_transferir.ForeColor = Color.White;
            btn_transferir.Image = (Image)resources.GetObject("btn_transferir.Image");
            btn_transferir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_transferir.Location = new Point(657, 2);
            btn_transferir.Margin = new Padding(3, 2, 3, 2);
            btn_transferir.Name = "btn_transferir";
            btn_transferir.Size = new Size(223, 39);
            btn_transferir.TabIndex = 33;
            btn_transferir.Text = "Transferir producto";
            btn_transferir.UseVisualStyleBackColor = false;
            btn_transferir.Click += btn_transferir_Click;
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
            pnlBusqueda.Controls.Add(cmb_sucursal);
            pnlBusqueda.Controls.Add(lbl2);
            pnlBusqueda.Controls.Add(cmb_agg2);
            pnlBusqueda.Controls.Add(cmb_agg1);
            pnlBusqueda.Controls.Add(txt1);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(btn_limpiar);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Controls.Add(lbl_agg3);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 27;
            // 
            // cmb_sucursal
            // 
            cmb_sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sucursal.Font = new Font("Calibri", 14.25F);
            cmb_sucursal.FormattingEnabled = true;
            cmb_sucursal.Location = new Point(436, 6);
            cmb_sucursal.Margin = new Padding(3, 2, 3, 2);
            cmb_sucursal.Name = "cmb_sucursal";
            cmb_sucursal.Size = new Size(168, 31);
            cmb_sucursal.TabIndex = 33;
            cmb_sucursal.SelectedIndexChanged += cmb_sucursal_SelectedIndexChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl2.ForeColor = Color.Black;
            lbl2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl2.Location = new Point(371, 12);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 19);
            lbl2.TabIndex = 34;
            lbl2.Text = "Sucursal:";
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_agg2
            // 
            cmb_agg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg2.Font = new Font("Calibri", 14.25F);
            cmb_agg2.FormattingEnabled = true;
            cmb_agg2.Location = new Point(869, 5);
            cmb_agg2.Margin = new Padding(3, 2, 3, 2);
            cmb_agg2.Name = "cmb_agg2";
            cmb_agg2.Size = new Size(121, 31);
            cmb_agg2.TabIndex = 14;
            cmb_agg2.SelectedIndexChanged += cmb_agg2_SelectedIndexChanged;
            // 
            // cmb_agg1
            // 
            cmb_agg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_agg1.Font = new Font("Calibri", 14.25F);
            cmb_agg1.FormattingEnabled = true;
            cmb_agg1.Location = new Point(684, 6);
            cmb_agg1.Margin = new Padding(3, 2, 3, 2);
            cmb_agg1.Name = "cmb_agg1";
            cmb_agg1.Size = new Size(121, 31);
            cmb_agg1.TabIndex = 14;
            cmb_agg1.SelectedIndexChanged += cmb_agg1_SelectedIndexChanged;
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
            txt1.TextChanged += txt1_TextChanged;
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
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.White;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.Black;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(1011, 6);
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
            lbl_agg2.Location = new Point(610, 11);
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
            lbl_agg3.Location = new Point(814, 11);
            lbl_agg3.Name = "lbl_agg3";
            lbl_agg3.Size = new Size(59, 19);
            lbl_agg3.TabIndex = 17;
            lbl_agg3.Text = "Estado:";
            lbl_agg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_agregarProducto
            // 
            btn_agregarProducto.BackColor = Color.FromArgb(4, 59, 186);
            btn_agregarProducto.Cursor = Cursors.Hand;
            btn_agregarProducto.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_agregarProducto.ForeColor = Color.White;
            btn_agregarProducto.Image = (Image)resources.GetObject("btn_agregarProducto.Image");
            btn_agregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregarProducto.Location = new Point(893, 2);
            btn_agregarProducto.Margin = new Padding(3, 2, 3, 2);
            btn_agregarProducto.Name = "btn_agregarProducto";
            btn_agregarProducto.Size = new Size(223, 39);
            btn_agregarProducto.TabIndex = 9;
            btn_agregarProducto.Text = "Agregar producto";
            btn_agregarProducto.UseVisualStyleBackColor = false;
            btn_agregarProducto.Click += btn_agregarProducto_Click;
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
            dvg_agg.Location = new Point(10, 93);
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
            // FrmProductosE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_conagg);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProductosE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProductosE";
            Load += FrmProductosE_Load;
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
        private Button btn_transferir;
        private Label lblSalirV;
        private Panel pnlBusqueda;
        private ComboBox cmb_sucursal;
        private Label lbl2;
        private ComboBox cmb_agg2;
        private ComboBox cmb_agg1;
        private TextBox txt1;
        private PictureBox pictureBox1;
        private Button btn_limpiar;
        private Label lbl_agg2;
        private Label lbl_agg3;
        private Button btn_agregarProducto;
        private PictureBox pictureBox2;
        private PictureBox pic_agg1;
        private Label lbl_agg1;
        private DataGridView dvg_agg;
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