namespace Derick
{
    partial class FrmVentasN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasN));
            pnlNV = new Panel();
            pnlNVRV = new Panel();
            lblNVTotalPagar = new Label();
            lblR10 = new Label();
            lblNVTotal = new Label();
            nudNVD = new NumericUpDown();
            lblNVD = new Label();
            lblR9 = new Label();
            lblNVDescuento = new Label();
            lblR8 = new Label();
            lblNVSubtotal = new Label();
            lblNVResumenVenta = new Label();
            picNVRV = new PictureBox();
            pnlNVProductosAgregados = new Panel();
            btnNVGuardar = new Button();
            btnNVCancelar = new Button();
            btnNVLimpiar = new Button();
            dgvNVPA = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colTalla = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewImageColumn();
            colEliminar = new DataGridViewImageColumn();
            lblNVProductosA = new Label();
            picNVP = new PictureBox();
            pnlNVAP = new Panel();
            btnNVAgregar = new Button();
            lblNVCantidad = new Label();
            picNVBP = new PictureBox();
            txtNVBuscarProducto = new TextBox();
            nudNVCantidad = new NumericUpDown();
            lblR7 = new Label();
            lblNVAgregarProductos = new Label();
            lblR6 = new Label();
            picNVA = new PictureBox();
            lblNVBuscarProducto = new Label();
            pnlNVinfo = new Panel();
            picNVB = new PictureBox();
            txtNVCliente = new TextBox();
            comboBox3 = new ComboBox();
            lblNVSucursal = new Label();
            lblR4 = new Label();
            cbNVVendedor = new ComboBox();
            lblR3 = new Label();
            lblNVVen = new Label();
            dateTimePicker2 = new DateTimePicker();
            dtpNV = new DateTimePicker();
            lblR5 = new Label();
            lblNVCliente = new Label();
            lblR2 = new Label();
            lblR1 = new Label();
            lblNVHora = new Label();
            lblNVfecha = new Label();
            lblNVI = new Label();
            picNVI = new PictureBox();
            pnlNVR = new Panel();
            lblSalirV = new Label();
            lblNVR = new Label();
            lblVN = new Label();
            picNVR = new PictureBox();
            pnlNV.SuspendLayout();
            pnlNVRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNVD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVRV).BeginInit();
            pnlNVProductosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVP).BeginInit();
            pnlNVAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNVCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVA).BeginInit();
            pnlNVinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVI).BeginInit();
            pnlNVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVR).BeginInit();
            SuspendLayout();
            // 
            // pnlNV
            // 
            pnlNV.Anchor = AnchorStyles.None;
            pnlNV.BackColor = Color.FromArgb(244, 246, 249);
            pnlNV.Controls.Add(pnlNVRV);
            pnlNV.Controls.Add(pnlNVProductosAgregados);
            pnlNV.Controls.Add(pnlNVAP);
            pnlNV.Controls.Add(pnlNVinfo);
            pnlNV.Controls.Add(pnlNVR);
            pnlNV.Location = new Point(0, 0);
            pnlNV.Margin = new Padding(3, 4, 3, 4);
            pnlNV.Name = "pnlNV";
            pnlNV.Size = new Size(1355, 868);
            pnlNV.TabIndex = 9;
            // 
            // pnlNVRV
            // 
            pnlNVRV.BackColor = Color.White;
            pnlNVRV.BorderStyle = BorderStyle.FixedSingle;
            pnlNVRV.Controls.Add(lblNVTotalPagar);
            pnlNVRV.Controls.Add(lblR10);
            pnlNVRV.Controls.Add(lblNVTotal);
            pnlNVRV.Controls.Add(nudNVD);
            pnlNVRV.Controls.Add(lblNVD);
            pnlNVRV.Controls.Add(lblR9);
            pnlNVRV.Controls.Add(lblNVDescuento);
            pnlNVRV.Controls.Add(lblR8);
            pnlNVRV.Controls.Add(lblNVSubtotal);
            pnlNVRV.Controls.Add(lblNVResumenVenta);
            pnlNVRV.Controls.Add(picNVRV);
            pnlNVRV.Location = new Point(938, 91);
            pnlNVRV.Name = "pnlNVRV";
            pnlNVRV.Size = new Size(375, 234);
            pnlNVRV.TabIndex = 5;
            // 
            // lblNVTotalPagar
            // 
            lblNVTotalPagar.AutoSize = true;
            lblNVTotalPagar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVTotalPagar.Location = new Point(277, 173);
            lblNVTotalPagar.Name = "lblNVTotalPagar";
            lblNVTotalPagar.Size = new Size(60, 22);
            lblNVTotalPagar.TabIndex = 42;
            lblNVTotalPagar.Text = "$0.00";
            // 
            // lblR10
            // 
            lblR10.AutoSize = true;
            lblR10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR10.ForeColor = Color.Red;
            lblR10.Location = new Point(133, 167);
            lblR10.Name = "lblR10";
            lblR10.Size = new Size(21, 25);
            lblR10.TabIndex = 41;
            lblR10.Text = "*";
            // 
            // lblNVTotal
            // 
            lblNVTotal.AutoSize = true;
            lblNVTotal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVTotal.Location = new Point(19, 173);
            lblNVTotal.Name = "lblNVTotal";
            lblNVTotal.Size = new Size(117, 22);
            lblNVTotal.TabIndex = 40;
            lblNVTotal.Text = "Total a pagar";
            // 
            // nudNVD
            // 
            nudNVD.DecimalPlaces = 2;
            nudNVD.Location = new Point(187, 115);
            nudNVD.Name = "nudNVD";
            nudNVD.Size = new Size(150, 27);
            nudNVD.TabIndex = 39;
            // 
            // lblNVD
            // 
            lblNVD.AutoSize = true;
            lblNVD.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVD.Location = new Point(277, 69);
            lblNVD.Name = "lblNVD";
            lblNVD.Size = new Size(60, 22);
            lblNVD.TabIndex = 38;
            lblNVD.Text = "$0.00";
            // 
            // lblR9
            // 
            lblR9.AutoSize = true;
            lblR9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR9.ForeColor = Color.Red;
            lblR9.Location = new Point(111, 120);
            lblR9.Name = "lblR9";
            lblR9.Size = new Size(21, 25);
            lblR9.TabIndex = 37;
            lblR9.Text = "*";
            // 
            // lblNVDescuento
            // 
            lblNVDescuento.AutoSize = true;
            lblNVDescuento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVDescuento.Location = new Point(19, 120);
            lblNVDescuento.Name = "lblNVDescuento";
            lblNVDescuento.Size = new Size(96, 22);
            lblNVDescuento.TabIndex = 36;
            lblNVDescuento.Text = "Descuento";
            // 
            // lblR8
            // 
            lblR8.AutoSize = true;
            lblR8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR8.ForeColor = Color.Red;
            lblR8.Location = new Point(90, 67);
            lblR8.Name = "lblR8";
            lblR8.Size = new Size(21, 25);
            lblR8.TabIndex = 35;
            lblR8.Text = "*";
            // 
            // lblNVSubtotal
            // 
            lblNVSubtotal.AutoSize = true;
            lblNVSubtotal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVSubtotal.Location = new Point(19, 71);
            lblNVSubtotal.Name = "lblNVSubtotal";
            lblNVSubtotal.Size = new Size(76, 22);
            lblNVSubtotal.TabIndex = 34;
            lblNVSubtotal.Text = "Subtotal";
            // 
            // lblNVResumenVenta
            // 
            lblNVResumenVenta.AutoSize = true;
            lblNVResumenVenta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVResumenVenta.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVResumenVenta.Location = new Point(65, 21);
            lblNVResumenVenta.Name = "lblNVResumenVenta";
            lblNVResumenVenta.Size = new Size(198, 22);
            lblNVResumenVenta.TabIndex = 9;
            lblNVResumenVenta.Text = "Resumen de la venta";
            // 
            // picNVRV
            // 
            picNVRV.Image = (Image)resources.GetObject("picNVRV.Image");
            picNVRV.Location = new Point(19, 11);
            picNVRV.Name = "picNVRV";
            picNVRV.Size = new Size(40, 43);
            picNVRV.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVRV.TabIndex = 8;
            picNVRV.TabStop = false;
            // 
            // pnlNVProductosAgregados
            // 
            pnlNVProductosAgregados.BackColor = Color.White;
            pnlNVProductosAgregados.Controls.Add(btnNVGuardar);
            pnlNVProductosAgregados.Controls.Add(btnNVCancelar);
            pnlNVProductosAgregados.Controls.Add(btnNVLimpiar);
            pnlNVProductosAgregados.Controls.Add(dgvNVPA);
            pnlNVProductosAgregados.Controls.Add(lblNVProductosA);
            pnlNVProductosAgregados.Controls.Add(picNVP);
            pnlNVProductosAgregados.Location = new Point(14, 331);
            pnlNVProductosAgregados.Name = "pnlNVProductosAgregados";
            pnlNVProductosAgregados.Size = new Size(1302, 525);
            pnlNVProductosAgregados.TabIndex = 6;
            // 
            // btnNVGuardar
            // 
            btnNVGuardar.BackColor = Color.FromArgb(112, 34, 246);
            btnNVGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVGuardar.ForeColor = Color.White;
            btnNVGuardar.Location = new Point(1137, 8);
            btnNVGuardar.Name = "btnNVGuardar";
            btnNVGuardar.Size = new Size(145, 45);
            btnNVGuardar.TabIndex = 18;
            btnNVGuardar.Text = "Guardar venta";
            btnNVGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNVCancelar
            // 
            btnNVCancelar.BackColor = Color.FromArgb(13, 154, 64);
            btnNVCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVCancelar.ForeColor = Color.White;
            btnNVCancelar.Location = new Point(990, 8);
            btnNVCancelar.Name = "btnNVCancelar";
            btnNVCancelar.Size = new Size(145, 45);
            btnNVCancelar.TabIndex = 17;
            btnNVCancelar.Text = "Cancelar";
            btnNVCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNVLimpiar
            // 
            btnNVLimpiar.BackColor = Color.FromArgb(4, 59, 186);
            btnNVLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVLimpiar.ForeColor = Color.White;
            btnNVLimpiar.Location = new Point(839, 8);
            btnNVLimpiar.Name = "btnNVLimpiar";
            btnNVLimpiar.Size = new Size(145, 45);
            btnNVLimpiar.TabIndex = 16;
            btnNVLimpiar.Text = "Limpiar";
            btnNVLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvNVPA
            // 
            dgvNVPA.AllowUserToAddRows = false;
            dgvNVPA.AllowUserToDeleteRows = false;
            dgvNVPA.AllowUserToResizeColumns = false;
            dgvNVPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNVPA.BackgroundColor = Color.White;
            dgvNVPA.BorderStyle = BorderStyle.None;
            dgvNVPA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNVPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNVPA.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colTalla, colColor, colCantidad, colPrecio, colSubtotal, colAcciones, colEditar, colEliminar });
            dgvNVPA.Location = new Point(19, 59);
            dgvNVPA.MultiSelect = false;
            dgvNVPA.Name = "dgvNVPA";
            dgvNVPA.ReadOnly = true;
            dgvNVPA.RowHeadersVisible = false;
            dgvNVPA.RowHeadersWidth = 51;
            dgvNVPA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPA.Size = new Size(1263, 463);
            dgvNVPA.TabIndex = 15;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colTalla
            // 
            colTalla.HeaderText = "Talla";
            colTalla.MinimumWidth = 6;
            colTalla.Name = "colTalla";
            colTalla.ReadOnly = true;
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.HeaderText = "Editar";
            colEditar.MinimumWidth = 6;
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Resizable = DataGridViewTriState.True;
            colEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // lblNVProductosA
            // 
            lblNVProductosA.AutoSize = true;
            lblNVProductosA.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVProductosA.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVProductosA.Location = new Point(66, 19);
            lblNVProductosA.Name = "lblNVProductosA";
            lblNVProductosA.Size = new Size(200, 22);
            lblNVProductosA.TabIndex = 8;
            lblNVProductosA.Text = "Productos agregados";
            // 
            // picNVP
            // 
            picNVP.Image = (Image)resources.GetObject("picNVP.Image");
            picNVP.Location = new Point(24, 12);
            picNVP.Name = "picNVP";
            picNVP.Size = new Size(37, 31);
            picNVP.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVP.TabIndex = 7;
            picNVP.TabStop = false;
            // 
            // pnlNVAP
            // 
            pnlNVAP.BackColor = Color.White;
            pnlNVAP.BorderStyle = BorderStyle.FixedSingle;
            pnlNVAP.Controls.Add(btnNVAgregar);
            pnlNVAP.Controls.Add(lblNVCantidad);
            pnlNVAP.Controls.Add(picNVBP);
            pnlNVAP.Controls.Add(txtNVBuscarProducto);
            pnlNVAP.Controls.Add(nudNVCantidad);
            pnlNVAP.Controls.Add(lblR7);
            pnlNVAP.Controls.Add(lblNVAgregarProductos);
            pnlNVAP.Controls.Add(lblR6);
            pnlNVAP.Controls.Add(picNVA);
            pnlNVAP.Controls.Add(lblNVBuscarProducto);
            pnlNVAP.Location = new Point(596, 91);
            pnlNVAP.Name = "pnlNVAP";
            pnlNVAP.Size = new Size(331, 233);
            pnlNVAP.TabIndex = 4;
            // 
            // btnNVAgregar
            // 
            btnNVAgregar.BackColor = Color.FromArgb(13, 154, 64);
            btnNVAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVAgregar.ForeColor = Color.White;
            btnNVAgregar.Location = new Point(199, 156);
            btnNVAgregar.Name = "btnNVAgregar";
            btnNVAgregar.Size = new Size(114, 39);
            btnNVAgregar.TabIndex = 39;
            btnNVAgregar.Text = "+ Agregar";
            btnNVAgregar.UseVisualStyleBackColor = false;
            btnNVAgregar.Click += btnNVAgregar_Click;
            // 
            // lblNVCantidad
            // 
            lblNVCantidad.AutoSize = true;
            lblNVCantidad.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCantidad.Location = new Point(19, 132);
            lblNVCantidad.Name = "lblNVCantidad";
            lblNVCantidad.Size = new Size(82, 22);
            lblNVCantidad.TabIndex = 38;
            lblNVCantidad.Text = "Cantidad";
            // 
            // picNVBP
            // 
            picNVBP.Image = (Image)resources.GetObject("picNVBP.Image");
            picNVBP.Location = new Point(279, 92);
            picNVBP.Name = "picNVBP";
            picNVBP.Size = new Size(34, 29);
            picNVBP.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBP.TabIndex = 37;
            picNVBP.TabStop = false;
            // 
            // txtNVBuscarProducto
            // 
            txtNVBuscarProducto.AcceptsReturn = true;
            txtNVBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNVBuscarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVBuscarProducto.ForeColor = Color.Gray;
            txtNVBuscarProducto.Location = new Point(19, 92);
            txtNVBuscarProducto.Name = "txtNVBuscarProducto";
            txtNVBuscarProducto.Size = new Size(253, 29);
            txtNVBuscarProducto.TabIndex = 36;
            // 
            // nudNVCantidad
            // 
            nudNVCantidad.Location = new Point(18, 167);
            nudNVCantidad.Name = "nudNVCantidad";
            nudNVCantidad.Size = new Size(144, 27);
            nudNVCantidad.TabIndex = 8;
            // 
            // lblR7
            // 
            lblR7.AutoSize = true;
            lblR7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR7.ForeColor = Color.Red;
            lblR7.Location = new Point(96, 132);
            lblR7.Name = "lblR7";
            lblR7.Size = new Size(21, 25);
            lblR7.TabIndex = 13;
            lblR7.Text = "*";
            // 
            // lblNVAgregarProductos
            // 
            lblNVAgregarProductos.AutoSize = true;
            lblNVAgregarProductos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVAgregarProductos.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVAgregarProductos.Location = new Point(66, 23);
            lblNVAgregarProductos.Name = "lblNVAgregarProductos";
            lblNVAgregarProductos.Size = new Size(175, 22);
            lblNVAgregarProductos.TabIndex = 7;
            lblNVAgregarProductos.Text = "Agregar productos";
            // 
            // lblR6
            // 
            lblR6.AutoSize = true;
            lblR6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR6.ForeColor = Color.Red;
            lblR6.Location = new Point(168, 64);
            lblR6.Name = "lblR6";
            lblR6.Size = new Size(21, 25);
            lblR6.TabIndex = 10;
            lblR6.Text = "*";
            // 
            // picNVA
            // 
            picNVA.Image = (Image)resources.GetObject("picNVA.Image");
            picNVA.Location = new Point(19, 13);
            picNVA.Name = "picNVA";
            picNVA.Size = new Size(40, 43);
            picNVA.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVA.TabIndex = 6;
            picNVA.TabStop = false;
            // 
            // lblNVBuscarProducto
            // 
            lblNVBuscarProducto.AutoSize = true;
            lblNVBuscarProducto.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVBuscarProducto.Location = new Point(19, 65);
            lblNVBuscarProducto.Name = "lblNVBuscarProducto";
            lblNVBuscarProducto.Size = new Size(143, 22);
            lblNVBuscarProducto.TabIndex = 9;
            lblNVBuscarProducto.Text = "Buscar Producto";
            // 
            // pnlNVinfo
            // 
            pnlNVinfo.BackColor = Color.White;
            pnlNVinfo.BorderStyle = BorderStyle.FixedSingle;
            pnlNVinfo.Controls.Add(picNVB);
            pnlNVinfo.Controls.Add(txtNVCliente);
            pnlNVinfo.Controls.Add(comboBox3);
            pnlNVinfo.Controls.Add(lblNVSucursal);
            pnlNVinfo.Controls.Add(lblR4);
            pnlNVinfo.Controls.Add(cbNVVendedor);
            pnlNVinfo.Controls.Add(lblR3);
            pnlNVinfo.Controls.Add(lblNVVen);
            pnlNVinfo.Controls.Add(dateTimePicker2);
            pnlNVinfo.Controls.Add(dtpNV);
            pnlNVinfo.Controls.Add(lblR5);
            pnlNVinfo.Controls.Add(lblNVCliente);
            pnlNVinfo.Controls.Add(lblR2);
            pnlNVinfo.Controls.Add(lblR1);
            pnlNVinfo.Controls.Add(lblNVHora);
            pnlNVinfo.Controls.Add(lblNVfecha);
            pnlNVinfo.Controls.Add(lblNVI);
            pnlNVinfo.Controls.Add(picNVI);
            pnlNVinfo.Location = new Point(14, 91);
            pnlNVinfo.Name = "pnlNVinfo";
            pnlNVinfo.Size = new Size(575, 234);
            pnlNVinfo.TabIndex = 0;
            // 
            // picNVB
            // 
            picNVB.Image = (Image)resources.GetObject("picNVB.Image");
            picNVB.Location = new Point(526, 167);
            picNVB.Name = "picNVB";
            picNVB.Size = new Size(34, 29);
            picNVB.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVB.TabIndex = 36;
            picNVB.TabStop = false;
            picNVB.Click += picNVB_Click_1;
            // 
            // txtNVCliente
            // 
            txtNVCliente.AcceptsReturn = true;
            txtNVCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNVCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVCliente.ForeColor = Color.Gray;
            txtNVCliente.Location = new Point(267, 167);
            txtNVCliente.Name = "txtNVCliente";
            txtNVCliente.Size = new Size(253, 29);
            txtNVCliente.TabIndex = 35;
            txtNVCliente.Text = "Buscar cliente";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(11, 167);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(221, 28);
            comboBox3.TabIndex = 34;
            // 
            // lblNVSucursal
            // 
            lblNVSucursal.AutoSize = true;
            lblNVSucursal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVSucursal.Location = new Point(11, 141);
            lblNVSucursal.Name = "lblNVSucursal";
            lblNVSucursal.Size = new Size(80, 22);
            lblNVSucursal.TabIndex = 33;
            lblNVSucursal.Text = "Sucursal";
            // 
            // lblR4
            // 
            lblR4.AutoSize = true;
            lblR4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR4.ForeColor = Color.Red;
            lblR4.Location = new Point(88, 141);
            lblR4.Name = "lblR4";
            lblR4.Size = new Size(21, 25);
            lblR4.TabIndex = 32;
            lblR4.Text = "*";
            // 
            // cbNVVendedor
            // 
            cbNVVendedor.FormattingEnabled = true;
            cbNVVendedor.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVVendedor.Location = new Point(315, 96);
            cbNVVendedor.Name = "cbNVVendedor";
            cbNVVendedor.Size = new Size(245, 28);
            cbNVVendedor.TabIndex = 31;
            // 
            // lblR3
            // 
            lblR3.AutoSize = true;
            lblR3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR3.ForeColor = Color.Red;
            lblR3.Location = new Point(400, 68);
            lblR3.Name = "lblR3";
            lblR3.Size = new Size(21, 25);
            lblR3.TabIndex = 30;
            lblR3.Text = "*";
            // 
            // lblNVVen
            // 
            lblNVVen.AutoSize = true;
            lblNVVen.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVVen.Location = new Point(315, 68);
            lblNVVen.Name = "lblNVVen";
            lblNVVen.Size = new Size(88, 22);
            lblNVVen.TabIndex = 29;
            lblNVVen.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH : mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(175, 97);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(100, 27);
            dateTimePicker2.TabIndex = 28;
            // 
            // dtpNV
            // 
            dtpNV.CustomFormat = "dd/MM/yyyy";
            dtpNV.Format = DateTimePickerFormat.Custom;
            dtpNV.Location = new Point(18, 97);
            dtpNV.Name = "dtpNV";
            dtpNV.Size = new Size(127, 27);
            dtpNV.TabIndex = 27;
            // 
            // lblR5
            // 
            lblR5.AutoSize = true;
            lblR5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR5.ForeColor = Color.Red;
            lblR5.Location = new Point(330, 140);
            lblR5.Name = "lblR5";
            lblR5.Size = new Size(21, 25);
            lblR5.TabIndex = 13;
            lblR5.Text = "*";
            // 
            // lblNVCliente
            // 
            lblNVCliente.AutoSize = true;
            lblNVCliente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCliente.Location = new Point(267, 140);
            lblNVCliente.Name = "lblNVCliente";
            lblNVCliente.Size = new Size(66, 22);
            lblNVCliente.TabIndex = 12;
            lblNVCliente.Text = "Cliente";
            // 
            // lblR2
            // 
            lblR2.AutoSize = true;
            lblR2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR2.ForeColor = Color.Red;
            lblR2.Location = new Point(224, 68);
            lblR2.Name = "lblR2";
            lblR2.Size = new Size(21, 25);
            lblR2.TabIndex = 10;
            lblR2.Text = "*";
            // 
            // lblR1
            // 
            lblR1.AutoSize = true;
            lblR1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR1.ForeColor = Color.Red;
            lblR1.Location = new Point(64, 67);
            lblR1.Name = "lblR1";
            lblR1.Size = new Size(21, 25);
            lblR1.TabIndex = 6;
            lblR1.Text = "*";
            // 
            // lblNVHora
            // 
            lblNVHora.AutoSize = true;
            lblNVHora.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVHora.Location = new Point(175, 69);
            lblNVHora.Name = "lblNVHora";
            lblNVHora.Size = new Size(49, 22);
            lblNVHora.TabIndex = 9;
            lblNVHora.Text = "Hora";
            // 
            // lblNVfecha
            // 
            lblNVfecha.AutoSize = true;
            lblNVfecha.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVfecha.Location = new Point(11, 65);
            lblNVfecha.Name = "lblNVfecha";
            lblNVfecha.Size = new Size(60, 22);
            lblNVfecha.TabIndex = 5;
            lblNVfecha.Text = "Fecha";
            // 
            // lblNVI
            // 
            lblNVI.AutoSize = true;
            lblNVI.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVI.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVI.Location = new Point(64, 23);
            lblNVI.Name = "lblNVI";
            lblNVI.Size = new Size(218, 22);
            lblNVI.TabIndex = 4;
            lblNVI.Text = "Información de la venta";
            // 
            // picNVI
            // 
            picNVI.Image = (Image)resources.GetObject("picNVI.Image");
            picNVI.Location = new Point(23, 13);
            picNVI.Name = "picNVI";
            picNVI.Size = new Size(37, 33);
            picNVI.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVI.TabIndex = 3;
            picNVI.TabStop = false;
            // 
            // pnlNVR
            // 
            pnlNVR.BackColor = Color.White;
            pnlNVR.Controls.Add(lblSalirV);
            pnlNVR.Controls.Add(lblNVR);
            pnlNVR.Controls.Add(lblVN);
            pnlNVR.Controls.Add(picNVR);
            pnlNVR.Location = new Point(14, 16);
            pnlNVR.Margin = new Padding(3, 4, 3, 4);
            pnlNVR.Name = "pnlNVR";
            pnlNVR.Size = new Size(1299, 68);
            pnlNVR.TabIndex = 22;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.White;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1258, 15);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(31, 29);
            lblSalirV.TabIndex = 21;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click_1;
            // 
            // lblNVR
            // 
            lblNVR.AutoSize = true;
            lblNVR.BackColor = Color.White;
            lblNVR.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNVR.Location = new Point(66, 36);
            lblNVR.Name = "lblNVR";
            lblNVR.Size = new Size(307, 23);
            lblNVR.TabIndex = 3;
            lblNVR.Text = "Registra una nueva venta en el sistema";
            // 
            // lblVN
            // 
            lblVN.AutoSize = true;
            lblVN.BackColor = Color.White;
            lblVN.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVN.ForeColor = Color.FromArgb(4, 59, 186);
            lblVN.ImageAlign = ContentAlignment.MiddleLeft;
            lblVN.Location = new Point(67, 4);
            lblVN.Name = "lblVN";
            lblVN.Size = new Size(160, 29);
            lblVN.TabIndex = 1;
            lblVN.Text = "Nueva Venta";
            lblVN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picNVR
            // 
            picNVR.BackColor = Color.White;
            picNVR.Image = (Image)resources.GetObject("picNVR.Image");
            picNVR.Location = new Point(13, 16);
            picNVR.Name = "picNVR";
            picNVR.Size = new Size(48, 31);
            picNVR.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVR.TabIndex = 2;
            picNVR.TabStop = false;
            // 
            // FrmVentasN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 868);
            Controls.Add(pnlNV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVentasN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentasN";
            Load += FrmVentasN_Load_1;
            pnlNV.ResumeLayout(false);
            pnlNVRV.ResumeLayout(false);
            pnlNVRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNVD).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVRV).EndInit();
            pnlNVProductosAgregados.ResumeLayout(false);
            pnlNVProductosAgregados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVP).EndInit();
            pnlNVAP.ResumeLayout(false);
            pnlNVAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNVCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVA).EndInit();
            pnlNVinfo.ResumeLayout(false);
            pnlNVinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVI).EndInit();
            pnlNVR.ResumeLayout(false);
            pnlNVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVR).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button btn_agg2;
        private ComboBox cmb_agg2;
        private TextBox txt_agg1;
        private ComboBox cmb_agg1;
        private Label lbl1_agg1;
        private Button btn_gg1;
        private Panel pnlNV;
        private Panel pnlNVRV;
        private Label lblNVTotalPagar;
        private Label lblR10;
        private Label lblNVTotal;
        private NumericUpDown nudNVD;
        private Label lblNVD;
        private Label lblR9;
        private Label lblNVDescuento;
        private Label lblR8;
        private Label lblNVSubtotal;
        private Label lblNVResumenVenta;
        private PictureBox picNVRV;
        private Panel pnlNVProductosAgregados;
        private Button btnNVGuardar;
        private Button btnNVCancelar;
        private Button btnNVLimpiar;
        private DataGridView dgvNVPA;
        private Label lblNVProductosA;
        private PictureBox picNVP;
        private Panel pnlNVAP;
        private Button btnNVAgregar;
        private Label lblNVCantidad;
        private PictureBox picNVBP;
        private TextBox txtNVBuscarProducto;
        private NumericUpDown nudNVCantidad;
        private Label lblR7;
        private Label lblNVAgregarProductos;
        private Label lblR6;
        private PictureBox picNVA;
        private Label lblNVBuscarProducto;
        private Panel pnlNVinfo;
        private PictureBox picNVB;
        private TextBox txtNVCliente;
        private ComboBox comboBox3;
        private Label lblNVSucursal;
        private Label lblR4;
        private ComboBox cbNVVendedor;
        private Label lblR3;
        private Label lblNVVen;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtpNV;
        private Label lblR5;
        private Label lblNVCliente;
        private Label lblR2;
        private Label lblR1;
        private Label lblNVHora;
        private Label lblNVfecha;
        private Label lblNVI;
        private PictureBox picNVI;
        private Panel pnlNVR;
        private Label lblSalirV;
        private Label lblNVR;
        private Label lblVN;
        private PictureBox picNVR;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colTalla;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colAcciones;
        private DataGridViewImageColumn colEditar;
        private DataGridViewImageColumn colEliminar;
    }
}