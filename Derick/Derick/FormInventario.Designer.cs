namespace Derick
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            panel1 = new Panel();
            pnl_agg2 = new Panel();
            lblSalirV = new Label();
            pnlBusqueda = new Panel();
            cmb_sucursal = new ComboBox();
            lbl2 = new Label();
            cmb_estado = new ComboBox();
            cmb_categoria = new ComboBox();
            txt_buscar = new TextBox();
            pic1 = new PictureBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lbl3 = new Label();
            lbl4 = new Label();
            pictureBox2 = new PictureBox();
            btn_transferir = new Button();
            pic_agg1 = new PictureBox();
            lbl1 = new Label();
            dvgInventario = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clImagen = new DataGridViewImageColumn();
            clNombreProducto = new DataGridViewTextBoxColumn();
            clCategoria = new DataGridViewTextBoxColumn();
            clTallas = new DataGridViewTextBoxColumn();
            clColores = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            clStock = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            pnl_agg2.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 246, 249);
            panel1.Controls.Add(pnl_agg2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 651);
            panel1.TabIndex = 0;
            // 
            // pnl_agg2
            // 
            pnl_agg2.BackColor = Color.White;
            pnl_agg2.Controls.Add(lblSalirV);
            pnl_agg2.Controls.Add(pnlBusqueda);
            pnl_agg2.Controls.Add(pictureBox2);
            pnl_agg2.Controls.Add(btn_transferir);
            pnl_agg2.Controls.Add(pic_agg1);
            pnl_agg2.Controls.Add(lbl1);
            pnl_agg2.Controls.Add(dvgInventario);
            pnl_agg2.Location = new Point(18, 10);
            pnl_agg2.Margin = new Padding(3, 2, 3, 2);
            pnl_agg2.Name = "pnl_agg2";
            pnl_agg2.Size = new Size(1150, 630);
            pnl_agg2.TabIndex = 7;
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
            pnlBusqueda.Controls.Add(cmb_estado);
            pnlBusqueda.Controls.Add(cmb_categoria);
            pnlBusqueda.Controls.Add(txt_buscar);
            pnlBusqueda.Controls.Add(pic1);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(lbl3);
            pnlBusqueda.Controls.Add(lbl4);
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
            cmb_sucursal.Location = new Point(346, 7);
            cmb_sucursal.Margin = new Padding(3, 2, 3, 2);
            cmb_sucursal.Name = "cmb_sucursal";
            cmb_sucursal.Size = new Size(168, 31);
            cmb_sucursal.TabIndex = 32;
            cmb_sucursal.SelectedIndexChanged += cmb_sucursal_SelectedIndexChanged;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl2.ForeColor = Color.Black;
            lbl2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl2.Location = new Point(281, 13);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 19);
            lbl2.TabIndex = 32;
            lbl2.Text = "Sucursal:";
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_estado
            // 
            cmb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado.Font = new Font("Calibri", 14.25F);
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Location = new Point(779, 6);
            cmb_estado.Margin = new Padding(3, 2, 3, 2);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(121, 31);
            cmb_estado.TabIndex = 14;
            cmb_estado.SelectedIndexChanged += cmb_estado_SelectedIndexChanged;
            // 
            // cmb_categoria
            // 
            cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_categoria.Font = new Font("Calibri", 14.25F);
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(594, 7);
            cmb_categoria.Margin = new Padding(3, 2, 3, 2);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(121, 31);
            cmb_categoria.TabIndex = 14;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Calibri", 12F);
            txt_buscar.ForeColor = Color.Gray;
            txt_buscar.Location = new Point(49, 9);
            txt_buscar.Margin = new Padding(3, 2, 3, 2);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.PlaceholderText = " Buscar producto";
            txt_buscar.Size = new Size(226, 27);
            txt_buscar.TabIndex = 7;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // pic1
            // 
            pic1.BackColor = Color.White;
            pic1.Image = (Image)resources.GetObject("pic1.Image");
            pic1.Location = new Point(3, 6);
            pic1.Margin = new Padding(3, 2, 3, 2);
            pic1.Name = "pic1";
            pic1.Size = new Size(44, 34);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 23;
            pic1.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(13, 154, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(906, 4);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 33);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "     Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1011, 6);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 30);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl3.ForeColor = Color.Black;
            lbl3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl3.Location = new Point(520, 12);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(78, 19);
            lbl3.TabIndex = 15;
            lbl3.Text = "Categoría:";
            lbl3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl4.ForeColor = Color.Black;
            lbl4.ImageAlign = ContentAlignment.MiddleLeft;
            lbl4.Location = new Point(724, 12);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(59, 19);
            lbl4.TabIndex = 17;
            lbl4.Text = "Estado:";
            lbl4.TextAlign = ContentAlignment.MiddleLeft;
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
            // btn_transferir
            // 
            btn_transferir.BackColor = Color.FromArgb(4, 59, 186);
            btn_transferir.Cursor = Cursors.Hand;
            btn_transferir.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_transferir.ForeColor = Color.White;
            btn_transferir.Image = (Image)resources.GetObject("btn_transferir.Image");
            btn_transferir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_transferir.Location = new Point(893, 6);
            btn_transferir.Margin = new Padding(3, 2, 3, 2);
            btn_transferir.Name = "btn_transferir";
            btn_transferir.Size = new Size(223, 39);
            btn_transferir.TabIndex = 9;
            btn_transferir.Text = "Transferir producto";
            btn_transferir.UseVisualStyleBackColor = false;
            btn_transferir.Click += btn_transferir_Click;
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl1.Location = new Point(56, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(198, 26);
            lbl1.TabIndex = 1;
            lbl1.Text = "Gestión de inventario";
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dvgInventario
            // 
            dvgInventario.AllowUserToResizeColumns = false;
            dvgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgInventario.BackgroundColor = Color.White;
            dvgInventario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventario.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clImagen, clNombreProducto, clCategoria, clTallas, clColores, clPrecio, clStock, clEstado });
            dvgInventario.Cursor = Cursors.Hand;
            dvgInventario.Location = new Point(7, 93);
            dvgInventario.Margin = new Padding(3, 2, 3, 2);
            dvgInventario.MultiSelect = false;
            dvgInventario.Name = "dvgInventario";
            dvgInventario.RowHeadersVisible = false;
            dvgInventario.RowHeadersWidth = 51;
            dvgInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgInventario.Size = new Size(1129, 527);
            dvgInventario.TabIndex = 15;
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
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormInventario_Load;
            panel1.ResumeLayout(false);
            pnl_agg2.ResumeLayout(false);
            pnl_agg2.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnl_agg2;
        private Label lblSalirV;
        private Panel pnlBusqueda;
        private ComboBox cmb_estado;
        private ComboBox cmb_categoria;
        private TextBox txt_buscar;
        private PictureBox pic1;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lbl3;
        private Label lbl4;
        private PictureBox pictureBox2;
        private Button btn_transferir;
        private PictureBox pic_agg1;
        private Label lbl1;
        private DataGridView dvgInventario;
        private ComboBox cmb_sucursal;
        private Label lbl2;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewImageColumn clImagen;
        private DataGridViewTextBoxColumn clNombreProducto;
        private DataGridViewTextBoxColumn clCategoria;
        private DataGridViewTextBoxColumn clTallas;
        private DataGridViewTextBoxColumn clColores;
        private DataGridViewTextBoxColumn clPrecio;
        private DataGridViewTextBoxColumn clStock;
        private DataGridViewTextBoxColumn clEstado;
    }
}