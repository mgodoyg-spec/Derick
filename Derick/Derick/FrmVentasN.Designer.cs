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
            cbNVMP = new ComboBox();
            lblNVMP = new Label();
            lblNVTotalPagar = new Label();
            lblNVTotal = new Label();
            nudNVD = new NumericUpDown();
            lblNVD = new Label();
            lblR9 = new Label();
            lblNVDescuento = new Label();
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
            colEditar = new DataGridViewImageColumn();
            colEliminar = new DataGridViewImageColumn();
            lblNVProductosA = new Label();
            picNVP = new PictureBox();
            pnlNVAP = new Panel();
            cbNVColor = new ComboBox();
            cbNVTalla = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNVColor = new Label();
            lblNVTalla = new Label();
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
            pnlNV.Name = "pnlNV";
            pnlNV.Size = new Size(1186, 651);
            pnlNV.TabIndex = 9;
            // 
            // pnlNVRV
            // 
            pnlNVRV.BackColor = Color.White;
            pnlNVRV.BorderStyle = BorderStyle.FixedSingle;
            pnlNVRV.Controls.Add(cbNVMP);
            pnlNVRV.Controls.Add(lblNVMP);
            pnlNVRV.Controls.Add(lblNVTotalPagar);
            pnlNVRV.Controls.Add(lblNVTotal);
            pnlNVRV.Controls.Add(nudNVD);
            pnlNVRV.Controls.Add(lblNVD);
            pnlNVRV.Controls.Add(lblR9);
            pnlNVRV.Controls.Add(lblNVDescuento);
            pnlNVRV.Controls.Add(lblNVSubtotal);
            pnlNVRV.Controls.Add(lblNVResumenVenta);
            pnlNVRV.Controls.Add(picNVRV);
            pnlNVRV.Location = new Point(821, 68);
            pnlNVRV.Margin = new Padding(3, 2, 3, 2);
            pnlNVRV.Name = "pnlNVRV";
            pnlNVRV.Size = new Size(328, 176);
            pnlNVRV.TabIndex = 5;
            // 
            // cbNVMP
            // 
            cbNVMP.FormattingEnabled = true;
            cbNVMP.Location = new Point(149, 112);
            cbNVMP.Margin = new Padding(3, 2, 3, 2);
            cbNVMP.Name = "cbNVMP";
            cbNVMP.Size = new Size(142, 23);
            cbNVMP.TabIndex = 44;
            // 
            // lblNVMP
            // 
            lblNVMP.AutoSize = true;
            lblNVMP.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVMP.Location = new Point(17, 112);
            lblNVMP.Name = "lblNVMP";
            lblNVMP.Size = new Size(116, 18);
            lblNVMP.TabIndex = 43;
            lblNVMP.Text = "Método de pago";
            lblNVMP.Click += lblNVMP_Click;
            // 
            // lblNVTotalPagar
            // 
            lblNVTotalPagar.AutoSize = true;
            lblNVTotalPagar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVTotalPagar.Location = new Point(242, 142);
            lblNVTotalPagar.Name = "lblNVTotalPagar";
            lblNVTotalPagar.Size = new Size(49, 18);
            lblNVTotalPagar.TabIndex = 42;
            lblNVTotalPagar.Text = "$0.00";
            // 
            // lblNVTotal
            // 
            lblNVTotal.AutoSize = true;
            lblNVTotal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVTotal.Location = new Point(17, 142);
            lblNVTotal.Name = "lblNVTotal";
            lblNVTotal.Size = new Size(94, 18);
            lblNVTotal.TabIndex = 40;
            lblNVTotal.Text = "Total a pagar";
            // 
            // nudNVD
            // 
            nudNVD.DecimalPlaces = 2;
            nudNVD.Location = new Point(160, 83);
            nudNVD.Margin = new Padding(3, 2, 3, 2);
            nudNVD.Name = "nudNVD";
            nudNVD.Size = new Size(131, 23);
            nudNVD.TabIndex = 39;
            nudNVD.ValueChanged += nudNVD_ValueChanged;
            // 
            // lblNVD
            // 
            lblNVD.AutoSize = true;
            lblNVD.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVD.Location = new Point(242, 52);
            lblNVD.Name = "lblNVD";
            lblNVD.Size = new Size(49, 18);
            lblNVD.TabIndex = 38;
            lblNVD.Text = "$0.00";
            // 
            // lblR9
            // 
            lblR9.AutoSize = true;
            lblR9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR9.ForeColor = Color.Red;
            lblR9.Location = new Point(127, 115);
            lblR9.Name = "lblR9";
            lblR9.Size = new Size(16, 20);
            lblR9.TabIndex = 37;
            lblR9.Text = "*";
            // 
            // lblNVDescuento
            // 
            lblNVDescuento.AutoSize = true;
            lblNVDescuento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVDescuento.Location = new Point(17, 83);
            lblNVDescuento.Name = "lblNVDescuento";
            lblNVDescuento.Size = new Size(80, 18);
            lblNVDescuento.TabIndex = 36;
            lblNVDescuento.Text = "Descuento";
            // 
            // lblNVSubtotal
            // 
            lblNVSubtotal.AutoSize = true;
            lblNVSubtotal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVSubtotal.Location = new Point(17, 53);
            lblNVSubtotal.Name = "lblNVSubtotal";
            lblNVSubtotal.Size = new Size(62, 18);
            lblNVSubtotal.TabIndex = 34;
            lblNVSubtotal.Text = "Subtotal";
            // 
            // lblNVResumenVenta
            // 
            lblNVResumenVenta.AutoSize = true;
            lblNVResumenVenta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVResumenVenta.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVResumenVenta.Location = new Point(57, 16);
            lblNVResumenVenta.Name = "lblNVResumenVenta";
            lblNVResumenVenta.Size = new Size(165, 18);
            lblNVResumenVenta.TabIndex = 9;
            lblNVResumenVenta.Text = "Resumen de la venta";
            // 
            // picNVRV
            // 
            picNVRV.Image = (Image)resources.GetObject("picNVRV.Image");
            picNVRV.Location = new Point(17, 8);
            picNVRV.Margin = new Padding(3, 2, 3, 2);
            picNVRV.Name = "picNVRV";
            picNVRV.Size = new Size(35, 32);
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
            pnlNVProductosAgregados.Location = new Point(12, 248);
            pnlNVProductosAgregados.Margin = new Padding(3, 2, 3, 2);
            pnlNVProductosAgregados.Name = "pnlNVProductosAgregados";
            pnlNVProductosAgregados.Size = new Size(1139, 394);
            pnlNVProductosAgregados.TabIndex = 6;
            // 
            // btnNVGuardar
            // 
            btnNVGuardar.BackColor = Color.FromArgb(112, 34, 246);
            btnNVGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVGuardar.ForeColor = Color.White;
            btnNVGuardar.Location = new Point(995, 6);
            btnNVGuardar.Margin = new Padding(3, 2, 3, 2);
            btnNVGuardar.Name = "btnNVGuardar";
            btnNVGuardar.Size = new Size(127, 34);
            btnNVGuardar.TabIndex = 18;
            btnNVGuardar.Text = "Guardar venta";
            btnNVGuardar.UseVisualStyleBackColor = false;
            btnNVGuardar.Click += btnNVGuardar_Click;
            // 
            // btnNVCancelar
            // 
            btnNVCancelar.BackColor = Color.FromArgb(13, 154, 64);
            btnNVCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVCancelar.ForeColor = Color.White;
            btnNVCancelar.Location = new Point(866, 6);
            btnNVCancelar.Margin = new Padding(3, 2, 3, 2);
            btnNVCancelar.Name = "btnNVCancelar";
            btnNVCancelar.Size = new Size(127, 34);
            btnNVCancelar.TabIndex = 17;
            btnNVCancelar.Text = "Cancelar";
            btnNVCancelar.UseVisualStyleBackColor = false;
            btnNVCancelar.Click += btnNVCancelar_Click;
            // 
            // btnNVLimpiar
            // 
            btnNVLimpiar.BackColor = Color.FromArgb(4, 59, 186);
            btnNVLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVLimpiar.ForeColor = Color.White;
            btnNVLimpiar.Location = new Point(734, 6);
            btnNVLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnNVLimpiar.Name = "btnNVLimpiar";
            btnNVLimpiar.Size = new Size(127, 34);
            btnNVLimpiar.TabIndex = 16;
            btnNVLimpiar.Text = "Limpiar";
            btnNVLimpiar.UseVisualStyleBackColor = false;
            btnNVLimpiar.Click += btnNVLimpiar_Click;
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
            dgvNVPA.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colTalla, colColor, colCantidad, colPrecio, colSubtotal, colEditar, colEliminar });
            dgvNVPA.Location = new Point(17, 44);
            dgvNVPA.Margin = new Padding(3, 2, 3, 2);
            dgvNVPA.MultiSelect = false;
            dgvNVPA.Name = "dgvNVPA";
            dgvNVPA.ReadOnly = true;
            dgvNVPA.RowHeadersVisible = false;
            dgvNVPA.RowHeadersWidth = 51;
            dgvNVPA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPA.Size = new Size(1105, 347);
            dgvNVPA.TabIndex = 15;
            dgvNVPA.CellClick += dgvNVPA_CellClick;
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
            lblNVProductosA.Location = new Point(58, 14);
            lblNVProductosA.Name = "lblNVProductosA";
            lblNVProductosA.Size = new Size(170, 18);
            lblNVProductosA.TabIndex = 8;
            lblNVProductosA.Text = "Productos agregados";
            // 
            // picNVP
            // 
            picNVP.Image = (Image)resources.GetObject("picNVP.Image");
            picNVP.Location = new Point(21, 9);
            picNVP.Margin = new Padding(3, 2, 3, 2);
            picNVP.Name = "picNVP";
            picNVP.Size = new Size(32, 23);
            picNVP.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVP.TabIndex = 7;
            picNVP.TabStop = false;
            // 
            // pnlNVAP
            // 
            pnlNVAP.BackColor = Color.White;
            pnlNVAP.BorderStyle = BorderStyle.FixedSingle;
            pnlNVAP.Controls.Add(cbNVColor);
            pnlNVAP.Controls.Add(cbNVTalla);
            pnlNVAP.Controls.Add(label2);
            pnlNVAP.Controls.Add(label1);
            pnlNVAP.Controls.Add(lblNVColor);
            pnlNVAP.Controls.Add(lblNVTalla);
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
            pnlNVAP.Location = new Point(473, 68);
            pnlNVAP.Margin = new Padding(3, 2, 3, 2);
            pnlNVAP.Name = "pnlNVAP";
            pnlNVAP.Size = new Size(339, 175);
            pnlNVAP.TabIndex = 4;
            // 
            // cbNVColor
            // 
            cbNVColor.FormattingEnabled = true;
            cbNVColor.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVColor.Location = new Point(111, 136);
            cbNVColor.Margin = new Padding(3, 2, 3, 2);
            cbNVColor.Name = "cbNVColor";
            cbNVColor.Size = new Size(128, 23);
            cbNVColor.TabIndex = 45;
            // 
            // cbNVTalla
            // 
            cbNVTalla.FormattingEnabled = true;
            cbNVTalla.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVTalla.Location = new Point(16, 136);
            cbNVTalla.Margin = new Padding(3, 2, 3, 2);
            cbNVTalla.Name = "cbNVTalla";
            cbNVTalla.Size = new Size(89, 23);
            cbNVTalla.TabIndex = 44;
            cbNVTalla.SelectedIndexChanged += cbNVTalla_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(154, 108);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 43;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(58, 108);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 42;
            label1.Text = "*";
            // 
            // lblNVColor
            // 
            lblNVColor.AutoSize = true;
            lblNVColor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVColor.Location = new Point(111, 108);
            lblNVColor.Name = "lblNVColor";
            lblNVColor.Size = new Size(45, 18);
            lblNVColor.TabIndex = 41;
            lblNVColor.Text = "Color";
            // 
            // lblNVTalla
            // 
            lblNVTalla.AutoSize = true;
            lblNVTalla.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVTalla.Location = new Point(17, 108);
            lblNVTalla.Name = "lblNVTalla";
            lblNVTalla.Size = new Size(39, 18);
            lblNVTalla.TabIndex = 40;
            lblNVTalla.Text = "Talla";
            // 
            // btnNVAgregar
            // 
            btnNVAgregar.BackColor = Color.FromArgb(13, 154, 64);
            btnNVAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVAgregar.ForeColor = Color.White;
            btnNVAgregar.Location = new Point(245, 131);
            btnNVAgregar.Margin = new Padding(3, 2, 3, 2);
            btnNVAgregar.Name = "btnNVAgregar";
            btnNVAgregar.Size = new Size(88, 29);
            btnNVAgregar.TabIndex = 39;
            btnNVAgregar.Text = "+ Agregar";
            btnNVAgregar.UseVisualStyleBackColor = false;
            btnNVAgregar.Click += btnNVAgregar_Click;
            // 
            // lblNVCantidad
            // 
            lblNVCantidad.AutoSize = true;
            lblNVCantidad.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCantidad.Location = new Point(17, 77);
            lblNVCantidad.Name = "lblNVCantidad";
            lblNVCantidad.Size = new Size(66, 18);
            lblNVCantidad.TabIndex = 38;
            lblNVCantidad.Text = "Cantidad";
            // 
            // picNVBP
            // 
            picNVBP.Image = (Image)resources.GetObject("picNVBP.Image");
            picNVBP.Location = new Point(292, 49);
            picNVBP.Margin = new Padding(3, 2, 3, 2);
            picNVBP.Name = "picNVBP";
            picNVBP.Size = new Size(30, 22);
            picNVBP.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBP.TabIndex = 37;
            picNVBP.TabStop = false;
            picNVBP.Click += picNVBP_Click;
            // 
            // txtNVBuscarProducto
            // 
            txtNVBuscarProducto.AcceptsReturn = true;
            txtNVBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNVBuscarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVBuscarProducto.ForeColor = Color.Gray;
            txtNVBuscarProducto.Location = new Point(154, 46);
            txtNVBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            txtNVBuscarProducto.Name = "txtNVBuscarProducto";
            txtNVBuscarProducto.Size = new Size(132, 25);
            txtNVBuscarProducto.TabIndex = 36;
            // 
            // nudNVCantidad
            // 
            nudNVCantidad.Location = new Point(154, 76);
            nudNVCantidad.Margin = new Padding(3, 2, 3, 2);
            nudNVCantidad.Name = "nudNVCantidad";
            nudNVCantidad.Size = new Size(132, 23);
            nudNVCantidad.TabIndex = 8;
            // 
            // lblR7
            // 
            lblR7.AutoSize = true;
            lblR7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR7.ForeColor = Color.Red;
            lblR7.Location = new Point(132, 48);
            lblR7.Name = "lblR7";
            lblR7.Size = new Size(16, 20);
            lblR7.TabIndex = 13;
            lblR7.Text = "*";
            // 
            // lblNVAgregarProductos
            // 
            lblNVAgregarProductos.AutoSize = true;
            lblNVAgregarProductos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVAgregarProductos.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVAgregarProductos.Location = new Point(58, 17);
            lblNVAgregarProductos.Name = "lblNVAgregarProductos";
            lblNVAgregarProductos.Size = new Size(147, 18);
            lblNVAgregarProductos.TabIndex = 7;
            lblNVAgregarProductos.Text = "Agregar productos";
            // 
            // lblR6
            // 
            lblR6.AutoSize = true;
            lblR6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR6.ForeColor = Color.Red;
            lblR6.Location = new Point(89, 76);
            lblR6.Name = "lblR6";
            lblR6.Size = new Size(16, 20);
            lblR6.TabIndex = 10;
            lblR6.Text = "*";
            // 
            // picNVA
            // 
            picNVA.Image = (Image)resources.GetObject("picNVA.Image");
            picNVA.Location = new Point(17, 10);
            picNVA.Margin = new Padding(3, 2, 3, 2);
            picNVA.Name = "picNVA";
            picNVA.Size = new Size(35, 32);
            picNVA.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVA.TabIndex = 6;
            picNVA.TabStop = false;
            // 
            // lblNVBuscarProducto
            // 
            lblNVBuscarProducto.AutoSize = true;
            lblNVBuscarProducto.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVBuscarProducto.Location = new Point(16, 49);
            lblNVBuscarProducto.Name = "lblNVBuscarProducto";
            lblNVBuscarProducto.Size = new Size(120, 18);
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
            pnlNVinfo.Location = new Point(12, 68);
            pnlNVinfo.Margin = new Padding(3, 2, 3, 2);
            pnlNVinfo.Name = "pnlNVinfo";
            pnlNVinfo.Size = new Size(455, 176);
            pnlNVinfo.TabIndex = 0;
            pnlNVinfo.Paint += pnlNVinfo_Paint;
            // 
            // picNVB
            // 
            picNVB.Image = (Image)resources.GetObject("picNVB.Image");
            picNVB.Location = new Point(412, 124);
            picNVB.Margin = new Padding(3, 2, 3, 2);
            picNVB.Name = "picNVB";
            picNVB.Size = new Size(30, 22);
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
            txtNVCliente.Location = new Point(234, 125);
            txtNVCliente.Margin = new Padding(3, 2, 3, 2);
            txtNVCliente.Name = "txtNVCliente";
            txtNVCliente.Size = new Size(172, 25);
            txtNVCliente.TabIndex = 35;
            txtNVCliente.Text = "Buscar cliente";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(10, 125);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 23);
            comboBox3.TabIndex = 34;
            // 
            // lblNVSucursal
            // 
            lblNVSucursal.AutoSize = true;
            lblNVSucursal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVSucursal.Location = new Point(10, 106);
            lblNVSucursal.Name = "lblNVSucursal";
            lblNVSucursal.Size = new Size(66, 18);
            lblNVSucursal.TabIndex = 33;
            lblNVSucursal.Text = "Sucursal";
            // 
            // lblR4
            // 
            lblR4.AutoSize = true;
            lblR4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR4.ForeColor = Color.Red;
            lblR4.Location = new Point(77, 106);
            lblR4.Name = "lblR4";
            lblR4.Size = new Size(16, 20);
            lblR4.TabIndex = 32;
            lblR4.Text = "*";
            // 
            // cbNVVendedor
            // 
            cbNVVendedor.FormattingEnabled = true;
            cbNVVendedor.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVVendedor.Location = new Point(261, 73);
            cbNVVendedor.Margin = new Padding(3, 2, 3, 2);
            cbNVVendedor.Name = "cbNVVendedor";
            cbNVVendedor.Size = new Size(175, 23);
            cbNVVendedor.TabIndex = 31;
            // 
            // lblR3
            // 
            lblR3.AutoSize = true;
            lblR3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR3.ForeColor = Color.Red;
            lblR3.Location = new Point(338, 53);
            lblR3.Name = "lblR3";
            lblR3.Size = new Size(16, 20);
            lblR3.TabIndex = 30;
            lblR3.Text = "*";
            // 
            // lblNVVen
            // 
            lblNVVen.AutoSize = true;
            lblNVVen.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVVen.Location = new Point(261, 50);
            lblNVVen.Name = "lblNVVen";
            lblNVVen.Size = new Size(71, 18);
            lblNVVen.TabIndex = 29;
            lblNVVen.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH : mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(153, 73);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(88, 23);
            dateTimePicker2.TabIndex = 28;
            // 
            // dtpNV
            // 
            dtpNV.CustomFormat = "dd/MM/yyyy";
            dtpNV.Format = DateTimePickerFormat.Custom;
            dtpNV.Location = new Point(16, 73);
            dtpNV.Margin = new Padding(3, 2, 3, 2);
            dtpNV.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpNV.Name = "dtpNV";
            dtpNV.Size = new Size(112, 23);
            dtpNV.TabIndex = 27;
            // 
            // lblR5
            // 
            lblR5.AutoSize = true;
            lblR5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR5.ForeColor = Color.Red;
            lblR5.Location = new Point(289, 105);
            lblR5.Name = "lblR5";
            lblR5.Size = new Size(16, 20);
            lblR5.TabIndex = 13;
            lblR5.Text = "*";
            // 
            // lblNVCliente
            // 
            lblNVCliente.AutoSize = true;
            lblNVCliente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVCliente.Location = new Point(234, 105);
            lblNVCliente.Name = "lblNVCliente";
            lblNVCliente.Size = new Size(53, 18);
            lblNVCliente.TabIndex = 12;
            lblNVCliente.Text = "Cliente";
            // 
            // lblR2
            // 
            lblR2.AutoSize = true;
            lblR2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR2.ForeColor = Color.Red;
            lblR2.Location = new Point(196, 51);
            lblR2.Name = "lblR2";
            lblR2.Size = new Size(16, 20);
            lblR2.TabIndex = 10;
            lblR2.Text = "*";
            // 
            // lblR1
            // 
            lblR1.AutoSize = true;
            lblR1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR1.ForeColor = Color.Red;
            lblR1.Location = new Point(56, 50);
            lblR1.Name = "lblR1";
            lblR1.Size = new Size(16, 20);
            lblR1.TabIndex = 6;
            lblR1.Text = "*";
            // 
            // lblNVHora
            // 
            lblNVHora.AutoSize = true;
            lblNVHora.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVHora.Location = new Point(153, 52);
            lblNVHora.Name = "lblNVHora";
            lblNVHora.Size = new Size(41, 18);
            lblNVHora.TabIndex = 9;
            lblNVHora.Text = "Hora";
            // 
            // lblNVfecha
            // 
            lblNVfecha.AutoSize = true;
            lblNVfecha.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVfecha.Location = new Point(10, 49);
            lblNVfecha.Name = "lblNVfecha";
            lblNVfecha.Size = new Size(49, 18);
            lblNVfecha.TabIndex = 5;
            lblNVfecha.Text = "Fecha";
            // 
            // lblNVI
            // 
            lblNVI.AutoSize = true;
            lblNVI.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVI.ForeColor = Color.FromArgb(4, 59, 186);
            lblNVI.Location = new Point(56, 17);
            lblNVI.Name = "lblNVI";
            lblNVI.Size = new Size(183, 18);
            lblNVI.TabIndex = 4;
            lblNVI.Text = "Información de la venta";
            // 
            // picNVI
            // 
            picNVI.Image = (Image)resources.GetObject("picNVI.Image");
            picNVI.Location = new Point(20, 10);
            picNVI.Margin = new Padding(3, 2, 3, 2);
            picNVI.Name = "picNVI";
            picNVI.Size = new Size(32, 25);
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
            pnlNVR.Location = new Point(12, 12);
            pnlNVR.Name = "pnlNVR";
            pnlNVR.Size = new Size(1137, 51);
            pnlNVR.TabIndex = 22;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.White;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1101, 11);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 21;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click_1;
            // 
            // lblNVR
            // 
            lblNVR.AutoSize = true;
            lblNVR.BackColor = Color.White;
            lblNVR.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNVR.Location = new Point(58, 27);
            lblNVR.Name = "lblNVR";
            lblNVR.Size = new Size(245, 18);
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
            lblVN.Location = new Point(59, 3);
            lblVN.Name = "lblVN";
            lblVN.Size = new Size(130, 24);
            lblVN.TabIndex = 1;
            lblVN.Text = "Nueva Venta";
            lblVN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picNVR
            // 
            picNVR.BackColor = Color.White;
            picNVR.Image = (Image)resources.GetObject("picNVR.Image");
            picNVR.Location = new Point(11, 12);
            picNVR.Margin = new Padding(3, 2, 3, 2);
            picNVR.Name = "picNVR";
            picNVR.Size = new Size(42, 23);
            picNVR.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVR.TabIndex = 2;
            picNVR.TabStop = false;
            // 
            // FrmVentasN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnlNV);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox cbNVColor;
        private ComboBox cbNVMP;
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
        private Label lblNVTotal;
        private NumericUpDown nudNVD;
        private Label lblNVD;
        private Label lblNVDescuento;
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
        private DataGridViewImageColumn colEditar;
        private DataGridViewImageColumn colEliminar;
        private Label lblNVMP;
        private Label lblR9;
        private Label label2;
        private Label label1;
        private Label lblNVColor;
        private Label lblNVTalla;
        private ComboBox cbNVTalla;
    }
}