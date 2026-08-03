namespace Derick
{
    partial class FrmNuevaVenta
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
            pnlNuevaVenta = new Panel();
            panel1 = new Panel();
            lblS = new Label();
            numericUpDown1 = new NumericUpDown();
            lblDescuento = new Label();
            lblResumenVenta = new Label();
            lblSubtotal = new Label();
            dataGridView1 = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colTalla = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewTextBoxColumn();
            pnlAgregarProductos = new Panel();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            btnBuscar = new Button();
            lblAgregarProducto = new Label();
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            pnlDatosNuevaVenta = new Panel();
            lblCodigoVenta = new Label();
            cbSucursal = new ComboBox();
            txtCodigoVenta = new TextBox();
            lblSucursal = new Label();
            lblFecha = new Label();
            cbVendedor = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblVendedor = new Label();
            lblHora = new Label();
            dtpHora = new DateTimePicker();
            btnCancelarV = new Button();
            btnGuardarV = new Button();
            pnlB = new Panel();
            lblNuevaVenta = new Label();
            btnRegresarN = new Button();
            pnlNuevaVenta.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlAgregarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlDatosNuevaVenta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevaVenta
            // 
            pnlNuevaVenta.BackColor = Color.White;
            pnlNuevaVenta.Controls.Add(btnRegresarN);
            pnlNuevaVenta.Controls.Add(panel1);
            pnlNuevaVenta.Controls.Add(dataGridView1);
            pnlNuevaVenta.Controls.Add(pnlAgregarProductos);
            pnlNuevaVenta.Controls.Add(pnlDatosNuevaVenta);
            pnlNuevaVenta.Controls.Add(btnCancelarV);
            pnlNuevaVenta.Controls.Add(btnGuardarV);
            pnlNuevaVenta.Controls.Add(pnlB);
            pnlNuevaVenta.Controls.Add(lblNuevaVenta);
            pnlNuevaVenta.Location = new Point(8, 8);
            pnlNuevaVenta.Margin = new Padding(3, 2, 3, 2);
            pnlNuevaVenta.Name = "pnlNuevaVenta";
            pnlNuevaVenta.Size = new Size(1184, 616);
            pnlNuevaVenta.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblS);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(lblDescuento);
            panel1.Controls.Add(lblResumenVenta);
            panel1.Controls.Add(lblSubtotal);
            panel1.Location = new Point(7, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 126);
            panel1.TabIndex = 28;
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblS.Location = new Point(509, 51);
            lblS.Name = "lblS";
            lblS.Size = new Size(49, 18);
            lblS.TabIndex = 20;
            lblS.Text = "$0.00";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(339, 89);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(3, 89);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(94, 18);
            lblDescuento.TabIndex = 18;
            lblDescuento.Text = "Descuento:";
            // 
            // lblResumenVenta
            // 
            lblResumenVenta.AutoSize = true;
            lblResumenVenta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenVenta.Location = new Point(3, 13);
            lblResumenVenta.Name = "lblResumenVenta";
            lblResumenVenta.Size = new Size(211, 24);
            lblResumenVenta.TabIndex = 17;
            lblResumenVenta.Text = "Resumen de la Venta";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(3, 51);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(75, 18);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "Subtotal:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colTalla, colColor, colCantidad, colPrecio, colSubtotal, colEliminar });
            dataGridView1.Location = new Point(7, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1170, 100);
            dataGridView1.TabIndex = 27;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            // 
            // colTalla
            // 
            colTalla.HeaderText = "Talla";
            colTalla.Name = "colTalla";
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Name = "colEliminar";
            // 
            // pnlAgregarProductos
            // 
            pnlAgregarProductos.BackColor = Color.White;
            pnlAgregarProductos.Controls.Add(btnAgregar);
            pnlAgregarProductos.Controls.Add(nudCantidad);
            pnlAgregarProductos.Controls.Add(lblCantidad);
            pnlAgregarProductos.Controls.Add(btnBuscar);
            pnlAgregarProductos.Controls.Add(lblAgregarProducto);
            pnlAgregarProductos.Controls.Add(lblBuscarProducto);
            pnlAgregarProductos.Controls.Add(txtBuscarProducto);
            pnlAgregarProductos.Location = new Point(4, 155);
            pnlAgregarProductos.Name = "pnlAgregarProductos";
            pnlAgregarProductos.Size = new Size(1177, 126);
            pnlAgregarProductos.TabIndex = 26;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Purple;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(940, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 35);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(721, 69);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(619, 68);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(79, 18);
            lblCantidad.TabIndex = 22;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Purple;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(475, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 35);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto.Location = new Point(3, 13);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(185, 24);
            lblAgregarProducto.TabIndex = 17;
            lblAgregarProducto.Text = "Agregar Productos";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarProducto.Location = new Point(3, 68);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(140, 18);
            lblBuscarProducto.TabIndex = 15;
            lblBuscarProducto.Text = "Buscar Producto:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(146, 68);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(323, 23);
            txtBuscarProducto.TabIndex = 16;
            // 
            // pnlDatosNuevaVenta
            // 
            pnlDatosNuevaVenta.BackColor = Color.White;
            pnlDatosNuevaVenta.Controls.Add(lblCodigoVenta);
            pnlDatosNuevaVenta.Controls.Add(cbSucursal);
            pnlDatosNuevaVenta.Controls.Add(txtCodigoVenta);
            pnlDatosNuevaVenta.Controls.Add(lblSucursal);
            pnlDatosNuevaVenta.Controls.Add(lblFecha);
            pnlDatosNuevaVenta.Controls.Add(cbVendedor);
            pnlDatosNuevaVenta.Controls.Add(dtpFecha);
            pnlDatosNuevaVenta.Controls.Add(lblVendedor);
            pnlDatosNuevaVenta.Controls.Add(lblHora);
            pnlDatosNuevaVenta.Controls.Add(dtpHora);
            pnlDatosNuevaVenta.Location = new Point(4, 46);
            pnlDatosNuevaVenta.Name = "pnlDatosNuevaVenta";
            pnlDatosNuevaVenta.Size = new Size(1177, 90);
            pnlDatosNuevaVenta.TabIndex = 25;
            // 
            // lblCodigoVenta
            // 
            lblCodigoVenta.AutoSize = true;
            lblCodigoVenta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoVenta.Location = new Point(3, 36);
            lblCodigoVenta.Name = "lblCodigoVenta";
            lblCodigoVenta.Size = new Size(137, 18);
            lblCodigoVenta.TabIndex = 15;
            lblCodigoVenta.Text = "Código de Venta:";
            // 
            // cbSucursal
            // 
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(958, 39);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(206, 23);
            cbSucursal.TabIndex = 24;
            // 
            // txtCodigoVenta
            // 
            txtCodigoVenta.Location = new Point(146, 36);
            txtCodigoVenta.Name = "txtCodigoVenta";
            txtCodigoVenta.Size = new Size(135, 23);
            txtCodigoVenta.TabIndex = 16;
            txtCodigoVenta.TextChanged += txtCodigoVenta_TextChanged;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(958, 15);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(79, 18);
            lblSucursal.TabIndex = 23;
            lblSucursal.Text = "Sucursal:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(293, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 18);
            lblFecha.TabIndex = 17;
            lblFecha.Text = "Fecha:";
            // 
            // cbVendedor
            // 
            cbVendedor.FormattingEnabled = true;
            cbVendedor.Items.AddRange(new object[] { "Juan Pérez", "María Gómez", "Carlos Ruiz" });
            cbVendedor.Location = new Point(682, 36);
            cbVendedor.Name = "cbVendedor";
            cbVendedor.Size = new Size(236, 23);
            cbVendedor.TabIndex = 22;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(293, 36);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 23);
            dtpFecha.TabIndex = 18;
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendedor.Location = new Point(682, 15);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(84, 18);
            lblVendedor.TabIndex = 21;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(471, 15);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 18);
            lblHora.TabIndex = 19;
            lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "HH : mm";
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.Location = new Point(471, 36);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(164, 23);
            dtpHora.TabIndex = 20;
            // 
            // btnCancelarV
            // 
            btnCancelarV.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarV.Location = new Point(695, 487);
            btnCancelarV.Margin = new Padding(3, 2, 3, 2);
            btnCancelarV.Name = "btnCancelarV";
            btnCancelarV.Size = new Size(186, 40);
            btnCancelarV.TabIndex = 14;
            btnCancelarV.Text = "Cancelar";
            btnCancelarV.UseVisualStyleBackColor = true;
            btnCancelarV.Click += btnCancelarV_Click;
            // 
            // btnGuardarV
            // 
            btnGuardarV.BackColor = Color.Purple;
            btnGuardarV.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarV.ForeColor = Color.White;
            btnGuardarV.Location = new Point(904, 487);
            btnGuardarV.Margin = new Padding(3, 2, 3, 2);
            btnGuardarV.Name = "btnGuardarV";
            btnGuardarV.Size = new Size(186, 40);
            btnGuardarV.TabIndex = 13;
            btnGuardarV.Text = "Guardar";
            btnGuardarV.UseVisualStyleBackColor = false;
            btnGuardarV.Click += btnGuardarV_Click;
            // 
            // pnlB
            // 
            pnlB.BackColor = Color.Purple;
            pnlB.Location = new Point(3, 32);
            pnlB.Name = "pnlB";
            pnlB.Size = new Size(110, 8);
            pnlB.TabIndex = 9;
            // 
            // lblNuevaVenta
            // 
            lblNuevaVenta.AutoSize = true;
            lblNuevaVenta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevaVenta.Location = new Point(0, 7);
            lblNuevaVenta.Name = "lblNuevaVenta";
            lblNuevaVenta.Size = new Size(130, 24);
            lblNuevaVenta.TabIndex = 0;
            lblNuevaVenta.Text = "Nueva Venta";
            // 
            // btnRegresarN
            // 
            btnRegresarN.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarN.Location = new Point(1070, 3);
            btnRegresarN.Name = "btnRegresarN";
            btnRegresarN.Size = new Size(107, 43);
            btnRegresarN.TabIndex = 29;
            btnRegresarN.Text = "Volver";
            btnRegresarN.UseVisualStyleBackColor = true;
            btnRegresarN.Click += btnRegresarN_Click;
            // 
            // FrmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 626);
            Controls.Add(pnlNuevaVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevaVenta";
            Text = "FrmNuevaVenta";
            pnlNuevaVenta.ResumeLayout(false);
            pnlNuevaVenta.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlAgregarProductos.ResumeLayout(false);
            pnlAgregarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlDatosNuevaVenta.ResumeLayout(false);
            pnlDatosNuevaVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevaVenta;
        private Button btnCancelarV;
        private Button btnGuardarV;
        private Panel pnlB;
        private Label lblNuevaVenta;
        private Label lblCodigoVenta;
        private Label lblFecha;
        private TextBox txtCodigoVenta;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Label lblHora;
        private Label lblSucursal;
        private ComboBox cbVendedor;
        private Label lblVendedor;
        private ComboBox cbSucursal;
        private Panel pnlDatosNuevaVenta;
        private Panel pnlAgregarProductos;
        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
        private Label lblAgregarProducto;
        private Button btnBuscar;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colTalla;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colEliminar;
        private Button btnAgregar;
        private Panel panel1;
        private Label lblResumenVenta;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblS;
        private NumericUpDown numericUpDown1;
        private Button btnRegresarN;
    }
}