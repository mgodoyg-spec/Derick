namespace Derick
{
    partial class FrmVentasE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasE));
            pnlNV = new Panel();
            pnlNVRV = new Panel();
            lblNVIVAE = new Label();
            lblIVA = new Label();
            cbNVMPE = new ComboBox();
            lblNVMP = new Label();
            lblNVTotalPagarE = new Label();
            lblNVTotal = new Label();
            nudNVDE = new NumericUpDown();
            lblNVDE = new Label();
            lblR9 = new Label();
            lblNVDescuento = new Label();
            lblNVSubtotal = new Label();
            lblNVResumenVenta = new Label();
            picNVRV = new PictureBox();
            pnlNVProductosAgregados = new Panel();
            btnNVGuardarE = new Button();
            btnNVCancelarE = new Button();
            btnNVLimpiarE = new Button();
            dgvNVPAE = new DataGridView();
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
            cbNVColorE = new ComboBox();
            cbNVTallaE = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNVColor = new Label();
            lblNVTalla = new Label();
            btnNVAgregarE = new Button();
            lblNVCantidad = new Label();
            picNVBPE = new PictureBox();
            txtNVBuscarProductoE = new TextBox();
            nudNVCantidadE = new NumericUpDown();
            lblR7 = new Label();
            lblNVAgregarProductos = new Label();
            lblR6 = new Label();
            picNVA = new PictureBox();
            lblNVBuscarProducto = new Label();
            pnlNVinfo = new Panel();
            txtSE = new TextBox();
            txtVE = new TextBox();
            picNVBE = new PictureBox();
            txtCE = new TextBox();
            lblNVSucursal = new Label();
            lblR4 = new Label();
            lblR3 = new Label();
            lblNVVen = new Label();
            dtpNVEH = new DateTimePicker();
            dtpNVF = new DateTimePicker();
            lblR5 = new Label();
            lblNVCliente = new Label();
            lblR2 = new Label();
            lblR1 = new Label();
            lblNVHora = new Label();
            lblNVfecha = new Label();
            lblNVI = new Label();
            picNVI = new PictureBox();
            pnlNVR = new Panel();
            lblSalirVE = new Label();
            lblNVR = new Label();
            lblVN = new Label();
            picNVR = new PictureBox();
            pnlNV.SuspendLayout();
            pnlNVRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNVDE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVRV).BeginInit();
            pnlNVProductosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVP).BeginInit();
            pnlNVAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBPE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNVCantidadE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVA).BeginInit();
            pnlNVinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBE).BeginInit();
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
            pnlNV.Location = new Point(-1, 5);
            pnlNV.Name = "pnlNV";
            pnlNV.Size = new Size(1186, 651);
            pnlNV.TabIndex = 10;
            // 
            // pnlNVRV
            // 
            pnlNVRV.BackColor = Color.White;
            pnlNVRV.BorderStyle = BorderStyle.FixedSingle;
            pnlNVRV.Controls.Add(lblNVIVAE);
            pnlNVRV.Controls.Add(lblIVA);
            pnlNVRV.Controls.Add(cbNVMPE);
            pnlNVRV.Controls.Add(lblNVMP);
            pnlNVRV.Controls.Add(lblNVTotalPagarE);
            pnlNVRV.Controls.Add(lblNVTotal);
            pnlNVRV.Controls.Add(nudNVDE);
            pnlNVRV.Controls.Add(lblNVDE);
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
            // lblNVIVAE
            // 
            lblNVIVAE.AutoSize = true;
            lblNVIVAE.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVIVAE.Location = new Point(17, 150);
            lblNVIVAE.Name = "lblNVIVAE";
            lblNVIVAE.Size = new Size(49, 18);
            lblNVIVAE.TabIndex = 46;
            lblNVIVAE.Text = "$0.00";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIVA.Location = new Point(17, 128);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(29, 18);
            lblIVA.TabIndex = 45;
            lblIVA.Text = "IVA";
            // 
            // cbNVMPE
            // 
            cbNVMPE.FormattingEnabled = true;
            cbNVMPE.Location = new Point(149, 102);
            cbNVMPE.Margin = new Padding(3, 2, 3, 2);
            cbNVMPE.Name = "cbNVMPE";
            cbNVMPE.Size = new Size(142, 23);
            cbNVMPE.TabIndex = 44;
            // 
            // lblNVMP
            // 
            lblNVMP.AutoSize = true;
            lblNVMP.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVMP.Location = new Point(17, 105);
            lblNVMP.Name = "lblNVMP";
            lblNVMP.Size = new Size(116, 18);
            lblNVMP.TabIndex = 43;
            lblNVMP.Text = "Método de pago";
            // 
            // lblNVTotalPagarE
            // 
            lblNVTotalPagarE.AutoSize = true;
            lblNVTotalPagarE.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVTotalPagarE.Location = new Point(242, 150);
            lblNVTotalPagarE.Name = "lblNVTotalPagarE";
            lblNVTotalPagarE.Size = new Size(49, 18);
            lblNVTotalPagarE.TabIndex = 42;
            lblNVTotalPagarE.Text = "$0.00";
            // 
            // lblNVTotal
            // 
            lblNVTotal.AutoSize = true;
            lblNVTotal.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVTotal.Location = new Point(197, 128);
            lblNVTotal.Name = "lblNVTotal";
            lblNVTotal.Size = new Size(94, 18);
            lblNVTotal.TabIndex = 40;
            lblNVTotal.Text = "Total a pagar";
            // 
            // nudNVDE
            // 
            nudNVDE.DecimalPlaces = 2;
            nudNVDE.Location = new Point(160, 74);
            nudNVDE.Margin = new Padding(3, 2, 3, 2);
            nudNVDE.Name = "nudNVDE";
            nudNVDE.Size = new Size(131, 23);
            nudNVDE.TabIndex = 39;
            nudNVDE.ValueChanged += nudNVDE_ValueChanged;
            // 
            // lblNVDE
            // 
            lblNVDE.AutoSize = true;
            lblNVDE.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNVDE.Location = new Point(242, 52);
            lblNVDE.Name = "lblNVDE";
            lblNVDE.Size = new Size(49, 18);
            lblNVDE.TabIndex = 38;
            lblNVDE.Text = "$0.00";
            // 
            // lblR9
            // 
            lblR9.AutoSize = true;
            lblR9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR9.ForeColor = Color.Red;
            lblR9.Location = new Point(127, 103);
            lblR9.Name = "lblR9";
            lblR9.Size = new Size(16, 20);
            lblR9.TabIndex = 37;
            lblR9.Text = "*";
            // 
            // lblNVDescuento
            // 
            lblNVDescuento.AutoSize = true;
            lblNVDescuento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVDescuento.Location = new Point(17, 77);
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
            pnlNVProductosAgregados.Controls.Add(btnNVGuardarE);
            pnlNVProductosAgregados.Controls.Add(btnNVCancelarE);
            pnlNVProductosAgregados.Controls.Add(btnNVLimpiarE);
            pnlNVProductosAgregados.Controls.Add(dgvNVPAE);
            pnlNVProductosAgregados.Controls.Add(lblNVProductosA);
            pnlNVProductosAgregados.Controls.Add(picNVP);
            pnlNVProductosAgregados.Location = new Point(12, 248);
            pnlNVProductosAgregados.Margin = new Padding(3, 2, 3, 2);
            pnlNVProductosAgregados.Name = "pnlNVProductosAgregados";
            pnlNVProductosAgregados.Size = new Size(1139, 394);
            pnlNVProductosAgregados.TabIndex = 6;
            // 
            // btnNVGuardarE
            // 
            btnNVGuardarE.BackColor = Color.FromArgb(112, 34, 246);
            btnNVGuardarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVGuardarE.ForeColor = Color.White;
            btnNVGuardarE.Location = new Point(995, 6);
            btnNVGuardarE.Margin = new Padding(3, 2, 3, 2);
            btnNVGuardarE.Name = "btnNVGuardarE";
            btnNVGuardarE.Size = new Size(127, 34);
            btnNVGuardarE.TabIndex = 18;
            btnNVGuardarE.Text = "Guardar venta";
            btnNVGuardarE.UseVisualStyleBackColor = false;
            btnNVGuardarE.Click += btnNVGuardarE_Click;
            // 
            // btnNVCancelarE
            // 
            btnNVCancelarE.BackColor = Color.FromArgb(13, 154, 64);
            btnNVCancelarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVCancelarE.ForeColor = Color.White;
            btnNVCancelarE.Location = new Point(866, 6);
            btnNVCancelarE.Margin = new Padding(3, 2, 3, 2);
            btnNVCancelarE.Name = "btnNVCancelarE";
            btnNVCancelarE.Size = new Size(127, 34);
            btnNVCancelarE.TabIndex = 17;
            btnNVCancelarE.Text = "Cancelar";
            btnNVCancelarE.UseVisualStyleBackColor = false;
            btnNVCancelarE.Click += btnNVCancelarE_Click;
            // 
            // btnNVLimpiarE
            // 
            btnNVLimpiarE.BackColor = Color.FromArgb(4, 59, 186);
            btnNVLimpiarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVLimpiarE.ForeColor = Color.White;
            btnNVLimpiarE.Location = new Point(734, 6);
            btnNVLimpiarE.Margin = new Padding(3, 2, 3, 2);
            btnNVLimpiarE.Name = "btnNVLimpiarE";
            btnNVLimpiarE.Size = new Size(127, 34);
            btnNVLimpiarE.TabIndex = 16;
            btnNVLimpiarE.Text = "Limpiar";
            btnNVLimpiarE.UseVisualStyleBackColor = false;
            btnNVLimpiarE.ClientSizeChanged += btnNVLimpiarE_Click;
            // 
            // dgvNVPAE
            // 
            dgvNVPAE.AllowUserToAddRows = false;
            dgvNVPAE.AllowUserToDeleteRows = false;
            dgvNVPAE.AllowUserToResizeColumns = false;
            dgvNVPAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNVPAE.BackgroundColor = Color.White;
            dgvNVPAE.BorderStyle = BorderStyle.None;
            dgvNVPAE.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPAE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNVPAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNVPAE.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colTalla, colColor, colCantidad, colPrecio, colSubtotal, colEditar, colEliminar });
            dgvNVPAE.Location = new Point(17, 44);
            dgvNVPAE.Margin = new Padding(3, 2, 3, 2);
            dgvNVPAE.MultiSelect = false;
            dgvNVPAE.Name = "dgvNVPAE";
            dgvNVPAE.ReadOnly = true;
            dgvNVPAE.RowHeadersVisible = false;
            dgvNVPAE.RowHeadersWidth = 51;
            dgvNVPAE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPAE.Size = new Size(1105, 347);
            dgvNVPAE.TabIndex = 15;
            dgvNVPAE.CellClick += dgvNVPAE_CellClick;
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
            pnlNVAP.Controls.Add(cbNVColorE);
            pnlNVAP.Controls.Add(cbNVTallaE);
            pnlNVAP.Controls.Add(label2);
            pnlNVAP.Controls.Add(label1);
            pnlNVAP.Controls.Add(lblNVColor);
            pnlNVAP.Controls.Add(lblNVTalla);
            pnlNVAP.Controls.Add(btnNVAgregarE);
            pnlNVAP.Controls.Add(lblNVCantidad);
            pnlNVAP.Controls.Add(picNVBPE);
            pnlNVAP.Controls.Add(txtNVBuscarProductoE);
            pnlNVAP.Controls.Add(nudNVCantidadE);
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
            // cbNVColorE
            // 
            cbNVColorE.FormattingEnabled = true;
            cbNVColorE.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVColorE.Location = new Point(111, 136);
            cbNVColorE.Margin = new Padding(3, 2, 3, 2);
            cbNVColorE.Name = "cbNVColorE";
            cbNVColorE.Size = new Size(128, 23);
            cbNVColorE.TabIndex = 45;
            // 
            // cbNVTallaE
            // 
            cbNVTallaE.FormattingEnabled = true;
            cbNVTallaE.Items.AddRange(new object[] { "Dilan Suarez", "Carla Ponce" });
            cbNVTallaE.Location = new Point(16, 136);
            cbNVTallaE.Margin = new Padding(3, 2, 3, 2);
            cbNVTallaE.Name = "cbNVTallaE";
            cbNVTallaE.Size = new Size(89, 23);
            cbNVTallaE.TabIndex = 44;
            cbNVTallaE.SelectedIndexChanged += cbNVTallaE_SelectedIndexChanged;
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
            // btnNVAgregarE
            // 
            btnNVAgregarE.BackColor = Color.FromArgb(13, 154, 64);
            btnNVAgregarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVAgregarE.ForeColor = Color.White;
            btnNVAgregarE.Location = new Point(245, 131);
            btnNVAgregarE.Margin = new Padding(3, 2, 3, 2);
            btnNVAgregarE.Name = "btnNVAgregarE";
            btnNVAgregarE.Size = new Size(88, 29);
            btnNVAgregarE.TabIndex = 39;
            btnNVAgregarE.Text = "+ Agregar";
            btnNVAgregarE.UseVisualStyleBackColor = false;
            btnNVAgregarE.Click += btnNVAgregarE_Click;
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
            // picNVBPE
            // 
            picNVBPE.Image = (Image)resources.GetObject("picNVBPE.Image");
            picNVBPE.Location = new Point(292, 49);
            picNVBPE.Margin = new Padding(3, 2, 3, 2);
            picNVBPE.Name = "picNVBPE";
            picNVBPE.Size = new Size(30, 22);
            picNVBPE.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBPE.TabIndex = 37;
            picNVBPE.TabStop = false;
            picNVBPE.Click += picNVBPE_Click;
            // 
            // txtNVBuscarProductoE
            // 
            txtNVBuscarProductoE.AcceptsReturn = true;
            txtNVBuscarProductoE.BorderStyle = BorderStyle.FixedSingle;
            txtNVBuscarProductoE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVBuscarProductoE.ForeColor = Color.Gray;
            txtNVBuscarProductoE.Location = new Point(154, 46);
            txtNVBuscarProductoE.Margin = new Padding(3, 2, 3, 2);
            txtNVBuscarProductoE.Name = "txtNVBuscarProductoE";
            txtNVBuscarProductoE.Size = new Size(132, 25);
            txtNVBuscarProductoE.TabIndex = 36;
            // 
            // nudNVCantidadE
            // 
            nudNVCantidadE.Location = new Point(154, 76);
            nudNVCantidadE.Margin = new Padding(3, 2, 3, 2);
            nudNVCantidadE.Name = "nudNVCantidadE";
            nudNVCantidadE.Size = new Size(132, 23);
            nudNVCantidadE.TabIndex = 8;
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
            pnlNVinfo.Controls.Add(txtSE);
            pnlNVinfo.Controls.Add(txtVE);
            pnlNVinfo.Controls.Add(picNVBE);
            pnlNVinfo.Controls.Add(txtCE);
            pnlNVinfo.Controls.Add(lblNVSucursal);
            pnlNVinfo.Controls.Add(lblR4);
            pnlNVinfo.Controls.Add(lblR3);
            pnlNVinfo.Controls.Add(lblNVVen);
            pnlNVinfo.Controls.Add(dtpNVEH);
            pnlNVinfo.Controls.Add(dtpNVF);
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
            // 
            // txtSE
            // 
            txtSE.AcceptsReturn = true;
            txtSE.BorderStyle = BorderStyle.FixedSingle;
            txtSE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSE.ForeColor = Color.Gray;
            txtSE.Location = new Point(10, 125);
            txtSE.Margin = new Padding(3, 2, 3, 2);
            txtSE.Name = "txtSE";
            txtSE.Size = new Size(172, 25);
            txtSE.TabIndex = 38;
            // 
            // txtVE
            // 
            txtVE.AcceptsReturn = true;
            txtVE.BorderStyle = BorderStyle.FixedSingle;
            txtVE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVE.ForeColor = Color.Gray;
            txtVE.Location = new Point(261, 71);
            txtVE.Margin = new Padding(3, 2, 3, 2);
            txtVE.Name = "txtVE";
            txtVE.Size = new Size(172, 25);
            txtVE.TabIndex = 37;
            // 
            // picNVBE
            // 
            picNVBE.Image = (Image)resources.GetObject("picNVBE.Image");
            picNVBE.Location = new Point(412, 124);
            picNVBE.Margin = new Padding(3, 2, 3, 2);
            picNVBE.Name = "picNVBE";
            picNVBE.Size = new Size(30, 26);
            picNVBE.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBE.TabIndex = 36;
            picNVBE.TabStop = false;
            picNVBE.Click += picNVBE_Click;
            // 
            // txtCE
            // 
            txtCE.AcceptsReturn = true;
            txtCE.BorderStyle = BorderStyle.FixedSingle;
            txtCE.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCE.ForeColor = Color.Gray;
            txtCE.Location = new Point(234, 125);
            txtCE.Margin = new Padding(3, 2, 3, 2);
            txtCE.Name = "txtCE";
            txtCE.Size = new Size(172, 25);
            txtCE.TabIndex = 35;
            txtCE.Text = "Buscar cliente";
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
            // dtpNVEH
            // 
            dtpNVEH.CustomFormat = "HH : mm";
            dtpNVEH.Format = DateTimePickerFormat.Custom;
            dtpNVEH.Location = new Point(153, 73);
            dtpNVEH.Margin = new Padding(3, 2, 3, 2);
            dtpNVEH.Name = "dtpNVEH";
            dtpNVEH.ShowUpDown = true;
            dtpNVEH.Size = new Size(88, 23);
            dtpNVEH.TabIndex = 28;
            // 
            // dtpNVF
            // 
            dtpNVF.CustomFormat = "dd/MM/yyyy";
            dtpNVF.Format = DateTimePickerFormat.Custom;
            dtpNVF.Location = new Point(16, 73);
            dtpNVF.Margin = new Padding(3, 2, 3, 2);
            dtpNVF.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpNVF.Name = "dtpNVF";
            dtpNVF.Size = new Size(112, 23);
            dtpNVF.TabIndex = 27;
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
            pnlNVR.Controls.Add(lblSalirVE);
            pnlNVR.Controls.Add(lblNVR);
            pnlNVR.Controls.Add(lblVN);
            pnlNVR.Controls.Add(picNVR);
            pnlNVR.Location = new Point(12, 12);
            pnlNVR.Name = "pnlNVR";
            pnlNVR.Size = new Size(1137, 51);
            pnlNVR.TabIndex = 22;
            // 
            // lblSalirVE
            // 
            lblSalirVE.AutoSize = true;
            lblSalirVE.BackColor = Color.White;
            lblSalirVE.Cursor = Cursors.Hand;
            lblSalirVE.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirVE.ForeColor = Color.Red;
            lblSalirVE.Location = new Point(1101, 11);
            lblSalirVE.Name = "lblSalirVE";
            lblSalirVE.Size = new Size(25, 24);
            lblSalirVE.TabIndex = 21;
            lblSalirVE.Text = "X";
            lblSalirVE.Click += lblSalirVE_Click;
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
            // FrmVentasE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlNV);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVentasE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentasE";
            Load += FrmVentasE_Load;
            pnlNV.ResumeLayout(false);
            pnlNVRV.ResumeLayout(false);
            pnlNVRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNVDE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVRV).EndInit();
            pnlNVProductosAgregados.ResumeLayout(false);
            pnlNVProductosAgregados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVP).EndInit();
            pnlNVAP.ResumeLayout(false);
            pnlNVAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBPE).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNVCantidadE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVA).EndInit();
            pnlNVinfo.ResumeLayout(false);
            pnlNVinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVBE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVI).EndInit();
            pnlNVR.ResumeLayout(false);
            pnlNVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNVR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNV;
        private Panel pnlNVRV;
        private Label lblNVIVAE;
        private Label lblIVA;
        private ComboBox cbNVMPE;
        private Label lblNVMP;
        private Label lblNVTotalPagarE;
        private Label lblNVTotal;
        private NumericUpDown nudNVDE;
        private Label lblNVDE;
        private Label lblR9;
        private Label lblNVDescuento;
        private Label lblNVSubtotal;
        private Label lblNVResumenVenta;
        private PictureBox picNVRV;
        private Panel pnlNVProductosAgregados;
        private Button btnNVGuardarE;
        private Button btnNVCancelarE;
        private Button btnNVLimpiarE;
        private DataGridView dgvNVPAE;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colTalla;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewImageColumn colEditar;
        private DataGridViewImageColumn colEliminar;
        private Label lblNVProductosA;
        private PictureBox picNVP;
        private Panel pnlNVAP;
        private ComboBox cbNVColorE;
        private ComboBox cbNVTallaE;
        private Label label2;
        private Label label1;
        private Label lblNVColor;
        private Label lblNVTalla;
        private Button btnNVAgregarE;
        private Label lblNVCantidad;
        private PictureBox picNVBPE;
        private TextBox txtNVBuscarProductoE;
        private NumericUpDown nudNVCantidadE;
        private Label lblR7;
        private Label lblNVAgregarProductos;
        private Label lblR6;
        private PictureBox picNVA;
        private Label lblNVBuscarProducto;
        private Panel pnlNVinfo;
        private PictureBox picNVBE;
        private TextBox txtCE;
        private Label lblNVSucursal;
        private Label lblR4;
        private Label lblR3;
        private Label lblNVVen;
        private DateTimePicker dtpNVEH;
        private DateTimePicker dtpNVF;
        private Label lblR5;
        private Label lblNVCliente;
        private Label lblR2;
        private Label lblR1;
        private Label lblNVHora;
        private Label lblNVfecha;
        private Label lblNVI;
        private PictureBox picNVI;
        private Panel pnlNVR;
        private Label lblSalirVE;
        private Label lblNVR;
        private Label lblVN;
        private PictureBox picNVR;
        private TextBox txtSE;
        private TextBox txtVE;
    }
}