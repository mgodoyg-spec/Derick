namespace Derick
{
    partial class FrmConsultarVentas
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
            pnlConsultarVenta = new Panel();
            pnlListadoVentas = new Panel();
            lblAgregarProducto = new Label();
            dgvListado = new DataGridView();
            colCodigoVenta = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colVendedor = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlFiltrosBúsqueda = new Panel();
            btnBuscarC = new Button();
            textBox1 = new TextBox();
            dtpFechaHasta = new DateTimePicker();
            lblFechaHasta = new Label();
            cbSucursalC = new ComboBox();
            lblSucursalC = new Label();
            lblFechaDesde = new Label();
            cbVendedorC = new ComboBox();
            dtpFechaDesde = new DateTimePicker();
            lblVendedorC = new Label();
            lblCodigoVentaC = new Label();
            btnCerrar = new Button();
            btnImprimir = new Button();
            pnlBV = new Panel();
            lblConsultarVenta = new Label();
            btnRegresarC = new Button();
            pnlConsultarVenta.SuspendLayout();
            pnlListadoVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            pnlFiltrosBúsqueda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConsultarVenta
            // 
            pnlConsultarVenta.BackColor = Color.White;
            pnlConsultarVenta.Controls.Add(btnRegresarC);
            pnlConsultarVenta.Controls.Add(pnlListadoVentas);
            pnlConsultarVenta.Controls.Add(pnlFiltrosBúsqueda);
            pnlConsultarVenta.Controls.Add(btnCerrar);
            pnlConsultarVenta.Controls.Add(btnImprimir);
            pnlConsultarVenta.Controls.Add(pnlBV);
            pnlConsultarVenta.Controls.Add(lblConsultarVenta);
            pnlConsultarVenta.Location = new Point(5, 14);
            pnlConsultarVenta.Margin = new Padding(3, 2, 3, 2);
            pnlConsultarVenta.Name = "pnlConsultarVenta";
            pnlConsultarVenta.Size = new Size(1184, 579);
            pnlConsultarVenta.TabIndex = 2;
            // 
            // pnlListadoVentas
            // 
            pnlListadoVentas.BackColor = Color.White;
            pnlListadoVentas.Controls.Add(lblAgregarProducto);
            pnlListadoVentas.Controls.Add(dgvListado);
            pnlListadoVentas.Location = new Point(5, 218);
            pnlListadoVentas.Name = "pnlListadoVentas";
            pnlListadoVentas.Size = new Size(1177, 228);
            pnlListadoVentas.TabIndex = 26;
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
            // dgvListado
            // 
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Columns.AddRange(new DataGridViewColumn[] { colCodigoVenta, colFecha, colHora, colVendedor, colSucursal, colSubtotal, colDescuento, colTotal, colEstado });
            dgvListado.Location = new Point(3, 49);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(1170, 176);
            dgvListado.TabIndex = 27;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // colCodigoVenta
            // 
            colCodigoVenta.HeaderText = "Código venta";
            colCodigoVenta.Name = "colCodigoVenta";
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            // 
            // colVendedor
            // 
            colVendedor.HeaderText = "Vendedor";
            colVendedor.Name = "colVendedor";
            // 
            // colSucursal
            // 
            colSucursal.HeaderText = "Sucursal";
            colSucursal.Name = "colSucursal";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            // 
            // colDescuento
            // 
            colDescuento.HeaderText = "Descuento";
            colDescuento.Name = "colDescuento";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // pnlFiltrosBúsqueda
            // 
            pnlFiltrosBúsqueda.BackColor = Color.White;
            pnlFiltrosBúsqueda.Controls.Add(btnBuscarC);
            pnlFiltrosBúsqueda.Controls.Add(textBox1);
            pnlFiltrosBúsqueda.Controls.Add(dtpFechaHasta);
            pnlFiltrosBúsqueda.Controls.Add(lblFechaHasta);
            pnlFiltrosBúsqueda.Controls.Add(cbSucursalC);
            pnlFiltrosBúsqueda.Controls.Add(lblSucursalC);
            pnlFiltrosBúsqueda.Controls.Add(lblFechaDesde);
            pnlFiltrosBúsqueda.Controls.Add(cbVendedorC);
            pnlFiltrosBúsqueda.Controls.Add(dtpFechaDesde);
            pnlFiltrosBúsqueda.Controls.Add(lblVendedorC);
            pnlFiltrosBúsqueda.Controls.Add(lblCodigoVentaC);
            pnlFiltrosBúsqueda.Location = new Point(5, 81);
            pnlFiltrosBúsqueda.Name = "pnlFiltrosBúsqueda";
            pnlFiltrosBúsqueda.Size = new Size(1177, 90);
            pnlFiltrosBúsqueda.TabIndex = 25;
            // 
            // btnBuscarC
            // 
            btnBuscarC.BackColor = Color.Purple;
            btnBuscarC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarC.ForeColor = SystemColors.ControlLightLight;
            btnBuscarC.Location = new Point(1087, 27);
            btnBuscarC.Name = "btnBuscarC";
            btnBuscarC.Size = new Size(86, 35);
            btnBuscarC.TabIndex = 28;
            btnBuscarC.Text = "Buscar";
            btnBuscarC.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 27;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.Location = new Point(167, 39);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(140, 23);
            dtpFechaHasta.TabIndex = 26;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHasta.Location = new Point(167, 15);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(105, 18);
            lblFechaHasta.TabIndex = 25;
            lblFechaHasta.Text = "Fecha hasta:";
            // 
            // cbSucursalC
            // 
            cbSucursalC.FormattingEnabled = true;
            cbSucursalC.Items.AddRange(new object[] { "Quevedo" });
            cbSucursalC.Location = new Point(864, 39);
            cbSucursalC.Name = "cbSucursalC";
            cbSucursalC.Size = new Size(206, 23);
            cbSucursalC.TabIndex = 24;
            // 
            // lblSucursalC
            // 
            lblSucursalC.AutoSize = true;
            lblSucursalC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursalC.Location = new Point(864, 15);
            lblSucursalC.Name = "lblSucursalC";
            lblSucursalC.Size = new Size(79, 18);
            lblSucursalC.TabIndex = 23;
            lblSucursalC.Text = "Sucursal:";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDesde.Location = new Point(8, 15);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(109, 18);
            lblFechaDesde.TabIndex = 17;
            lblFechaDesde.Text = "Fecha desde:";
            // 
            // cbVendedorC
            // 
            cbVendedorC.FormattingEnabled = true;
            cbVendedorC.Items.AddRange(new object[] { "Juan Pérez", "María Gómez", "Carlos Ruiz" });
            cbVendedorC.Location = new Point(594, 39);
            cbVendedorC.Name = "cbVendedorC";
            cbVendedorC.Size = new Size(236, 23);
            cbVendedorC.TabIndex = 22;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.Location = new Point(8, 39);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(140, 23);
            dtpFechaDesde.TabIndex = 18;
            // 
            // lblVendedorC
            // 
            lblVendedorC.AutoSize = true;
            lblVendedorC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendedorC.Location = new Point(594, 15);
            lblVendedorC.Name = "lblVendedorC";
            lblVendedorC.Size = new Size(84, 18);
            lblVendedorC.TabIndex = 21;
            lblVendedorC.Text = "Vendedor:";
            // 
            // lblCodigoVentaC
            // 
            lblCodigoVentaC.AutoSize = true;
            lblCodigoVentaC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoVentaC.Location = new Point(342, 15);
            lblCodigoVentaC.Name = "lblCodigoVentaC";
            lblCodigoVentaC.Size = new Size(137, 18);
            lblCodigoVentaC.TabIndex = 19;
            lblCodigoVentaC.Text = "Código de Venta:";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(398, 502);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(186, 40);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Purple;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(632, 502);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(186, 40);
            btnImprimir.TabIndex = 13;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // pnlBV
            // 
            pnlBV.BackColor = Color.Purple;
            pnlBV.Location = new Point(3, 32);
            pnlBV.Name = "pnlBV";
            pnlBV.Size = new Size(110, 8);
            pnlBV.TabIndex = 9;
            // 
            // lblConsultarVenta
            // 
            lblConsultarVenta.AutoSize = true;
            lblConsultarVenta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultarVenta.Location = new Point(0, 7);
            lblConsultarVenta.Name = "lblConsultarVenta";
            lblConsultarVenta.Size = new Size(168, 24);
            lblConsultarVenta.TabIndex = 0;
            lblConsultarVenta.Text = "Consultar Ventas";
            // 
            // btnRegresarC
            // 
            btnRegresarC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresarC.Location = new Point(1071, 7);
            btnRegresarC.Name = "btnRegresarC";
            btnRegresarC.Size = new Size(106, 43);
            btnRegresarC.TabIndex = 27;
            btnRegresarC.Text = "Volver";
            btnRegresarC.UseVisualStyleBackColor = true;
            btnRegresarC.Click += btnRegresarC_Click;
            // 
            // FrmConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 604);
            Controls.Add(pnlConsultarVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarVentas";
            Text = "FrmConsultarVentas";
            pnlConsultarVenta.ResumeLayout(false);
            pnlConsultarVenta.PerformLayout();
            pnlListadoVentas.ResumeLayout(false);
            pnlListadoVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            pnlFiltrosBúsqueda.ResumeLayout(false);
            pnlFiltrosBúsqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConsultarVenta;
        private DataGridView dgvListado;
        private Panel pnlListadoVentas;
        private Label lblAgregarProducto;
        private Panel pnlFiltrosBúsqueda;
        private Label lblCodigoVenta;
        private ComboBox cbSucursalC;
        private TextBox txtCodigoVenta;
        private Label lblSucursalC;
        private Label lblFechaDesde;
        private ComboBox cbVendedorC;
        private DateTimePicker dtpFechaDesde;
        private Label lblVendedorC;
        private Label lblCodigoVentaC;
        private Button btnCerrar;
        private Button btnImprimir;
        private Panel pnlBV;
        private Label lblConsultarVenta;
        private DateTimePicker dtpFechaHasta;
        private Label lblFechaHasta;
        private TextBox textBox1;
        private Button btnBuscarC;
        private DataGridViewTextBoxColumn colCodigoVenta;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colVendedor;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colEstado;
        private Button btnRegresarC;
    }
}