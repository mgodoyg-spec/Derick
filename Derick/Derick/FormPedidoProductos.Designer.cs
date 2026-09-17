namespace Derick
{
    partial class FormPedidoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidoProductos));
            pnl_conagg = new Panel();
            pnl_agg2 = new Panel();
            lblSalirV = new Label();
            pnlBusqueda = new Panel();
            cmb_proveedor = new ComboBox();
            txt1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_limpiar = new Button();
            lbl_agg2 = new Label();
            btn_orden = new Button();
            pictureBox2 = new PictureBox();
            pic_agg1 = new PictureBox();
            lbl1 = new Label();
            dvg_pedidoProducto = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clNombre = new DataGridViewTextBoxColumn();
            clProveedor = new DataGridViewTextBoxColumn();
            clTallas = new DataGridViewTextBoxColumn();
            clColores = new DataGridViewTextBoxColumn();
            clFechaInicio = new DataGridViewTextBoxColumn();
            clFechaFinal = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            pnl_conagg.SuspendLayout();
            pnl_agg2.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_pedidoProducto).BeginInit();
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
            pnl_agg2.Controls.Add(lblSalirV);
            pnl_agg2.Controls.Add(pnlBusqueda);
            pnl_agg2.Controls.Add(btn_orden);
            pnl_agg2.Controls.Add(pictureBox2);
            pnl_agg2.Controls.Add(pic_agg1);
            pnl_agg2.Controls.Add(lbl1);
            pnl_agg2.Controls.Add(dvg_pedidoProducto);
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
            pnlBusqueda.Controls.Add(cmb_proveedor);
            pnlBusqueda.Controls.Add(txt1);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(btn_limpiar);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 27;
            // 
            // cmb_proveedor
            // 
            cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_proveedor.Font = new Font("Calibri", 14.25F);
            cmb_proveedor.FormattingEnabled = true;
            cmb_proveedor.Location = new Point(452, 6);
            cmb_proveedor.Margin = new Padding(3, 2, 3, 2);
            cmb_proveedor.Name = "cmb_proveedor";
            cmb_proveedor.Size = new Size(170, 31);
            cmb_proveedor.TabIndex = 14;
            cmb_proveedor.SelectedIndexChanged += cmb_proveedor_SelectedIndexChanged;
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
            // 
            // lbl_agg2
            // 
            lbl_agg2.AutoSize = true;
            lbl_agg2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl_agg2.ForeColor = Color.Black;
            lbl_agg2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg2.Location = new Point(368, 11);
            lbl_agg2.Name = "lbl_agg2";
            lbl_agg2.Size = new Size(85, 19);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Proveedor:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_orden
            // 
            btn_orden.BackColor = Color.FromArgb(4, 59, 186);
            btn_orden.Cursor = Cursors.Hand;
            btn_orden.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_orden.ForeColor = Color.White;
            btn_orden.Image = (Image)resources.GetObject("btn_orden.Image");
            btn_orden.ImageAlign = ContentAlignment.MiddleLeft;
            btn_orden.Location = new Point(893, 2);
            btn_orden.Margin = new Padding(3, 2, 3, 2);
            btn_orden.Name = "btn_orden";
            btn_orden.Size = new Size(223, 39);
            btn_orden.TabIndex = 9;
            btn_orden.Text = "Nueva orden";
            btn_orden.UseVisualStyleBackColor = false;
            btn_orden.Click += btn_orden_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 13);
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl1.Location = new Point(56, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(271, 26);
            lbl1.TabIndex = 1;
            lbl1.Text = "Gestión de orden de prodcuto";
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dvg_pedidoProducto
            // 
            dvg_pedidoProducto.AllowUserToResizeColumns = false;
            dvg_pedidoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg_pedidoProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_pedidoProducto.BackgroundColor = Color.White;
            dvg_pedidoProducto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg_pedidoProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvg_pedidoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_pedidoProducto.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clNombre, clProveedor, clTallas, clColores, clFechaInicio, clFechaFinal, clEstado, clEditar, clEliminar });
            dvg_pedidoProducto.Cursor = Cursors.Hand;
            dvg_pedidoProducto.Location = new Point(7, 93);
            dvg_pedidoProducto.Margin = new Padding(3, 2, 3, 2);
            dvg_pedidoProducto.MultiSelect = false;
            dvg_pedidoProducto.Name = "dvg_pedidoProducto";
            dvg_pedidoProducto.RowHeadersVisible = false;
            dvg_pedidoProducto.RowHeadersWidth = 51;
            dvg_pedidoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_pedidoProducto.Size = new Size(1129, 534);
            dvg_pedidoProducto.TabIndex = 15;
            dvg_pedidoProducto.CellContentClick += dvg_pedidoProducto_CellContentClick;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.Name = "clCodigo";
            // 
            // clNombre
            // 
            clNombre.HeaderText = "Nombre del producto";
            clNombre.Name = "clNombre";
            // 
            // clProveedor
            // 
            clProveedor.HeaderText = "Proveedor";
            clProveedor.Name = "clProveedor";
            // 
            // clTallas
            // 
            clTallas.HeaderText = "Tallas";
            clTallas.Name = "clTallas";
            // 
            // clColores
            // 
            clColores.HeaderText = "Colores";
            clColores.Name = "clColores";
            // 
            // clFechaInicio
            // 
            clFechaInicio.HeaderText = "Fecha del pedido";
            clFechaInicio.Name = "clFechaInicio";
            // 
            // clFechaFinal
            // 
            clFechaFinal.HeaderText = "Fecha esperada";
            clFechaFinal.Name = "clFechaFinal";
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.Name = "clEstado";
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.Name = "clEditar";
            clEditar.Resizable = DataGridViewTriState.True;
            clEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.Name = "clEliminar";
            clEliminar.Resizable = DataGridViewTriState.True;
            clEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormPedidoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_conagg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPedidoProductos";
            Text = "FormPedidoProductos";
            Load += FormPedidoProductos_Load;
            pnl_conagg.ResumeLayout(false);
            pnl_agg2.ResumeLayout(false);
            pnl_agg2.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_pedidoProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_conagg;
        private Panel pnl_agg2;
        private Label lblSalirV;
        private Panel pnlBusqueda;
        private ComboBox cmb_proveedor;
        private TextBox txt1;
        private PictureBox pictureBox1;
        private Button btn_limpiar;
        private Label lbl_agg2;
        private Button btn_orden;
        private PictureBox pictureBox2;
        private PictureBox pic_agg1;
        private Label lbl1;
        private DataGridView dvg_pedidoProducto;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clNombre;
        private DataGridViewTextBoxColumn clProveedor;
        private DataGridViewTextBoxColumn clTallas;
        private DataGridViewTextBoxColumn clColores;
        private DataGridViewTextBoxColumn clFechaInicio;
        private DataGridViewTextBoxColumn clFechaFinal;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
    }
}