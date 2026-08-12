namespace Derick
{
    partial class FrmConsultarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVenta));
            pnlCV = new Panel();
            pnlCVF = new Panel();
            btnCVCerrar = new Button();
            btnCVExportar = new Button();
            btnCVImprimir = new Button();
            dgvCVF = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colVendedor = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            lblCVR = new Label();
            pic_agg1 = new PictureBox();
            lblCV = new Label();
            pnlCVinfo = new Panel();
            btnCVLimpiar = new Button();
            btnCVBuscar = new Button();
            dtpCVFechaHasta = new DateTimePicker();
            lblCVfechaHasta = new Label();
            cbCVEstado = new ComboBox();
            lblC3 = new Label();
            lblCVEstado = new Label();
            dtpCVDesde = new DateTimePicker();
            lblC2 = new Label();
            lblC1 = new Label();
            lblCVfechaDesde = new Label();
            pnlCVR = new Panel();
            lblSalirCV = new Label();
            button1 = new Button();
            pnlCV.SuspendLayout();
            pnlCVF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCVF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).BeginInit();
            pnlCVinfo.SuspendLayout();
            pnlCVR.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCV
            // 
            pnlCV.BackColor = Color.FromArgb(244, 246, 249);
            pnlCV.Controls.Add(pnlCVF);
            pnlCV.Controls.Add(lblCVR);
            pnlCV.Controls.Add(pic_agg1);
            pnlCV.Controls.Add(lblCV);
            pnlCV.Controls.Add(pnlCVinfo);
            pnlCV.Controls.Add(pnlCVR);
            pnlCV.Location = new Point(1, 31);
            pnlCV.Margin = new Padding(3, 2, 3, 2);
            pnlCV.Name = "pnlCV";
            pnlCV.Size = new Size(1150, 630);
            pnlCV.TabIndex = 3;
            // 
            // pnlCVF
            // 
            pnlCVF.BackColor = Color.White;
            pnlCVF.Controls.Add(btnCVCerrar);
            pnlCVF.Controls.Add(btnCVExportar);
            pnlCVF.Controls.Add(btnCVImprimir);
            pnlCVF.Controls.Add(dgvCVF);
            pnlCVF.Location = new Point(12, 180);
            pnlCVF.Margin = new Padding(3, 2, 3, 2);
            pnlCVF.Name = "pnlCVF";
            pnlCVF.Size = new Size(1131, 374);
            pnlCVF.TabIndex = 6;
            // 
            // btnCVCerrar
            // 
            btnCVCerrar.FlatAppearance.BorderColor = Color.FromArgb(112, 34, 246);
            btnCVCerrar.FlatStyle = FlatStyle.Flat;
            btnCVCerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVCerrar.Location = new Point(972, 328);
            btnCVCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCVCerrar.Name = "btnCVCerrar";
            btnCVCerrar.Size = new Size(127, 34);
            btnCVCerrar.TabIndex = 18;
            btnCVCerrar.Text = "Cerrar";
            btnCVCerrar.UseVisualStyleBackColor = false;
            // 
            // btnCVExportar
            // 
            btnCVExportar.FlatAppearance.BorderColor = Color.FromArgb(0, 176, 80);
            btnCVExportar.FlatStyle = FlatStyle.Flat;
            btnCVExportar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVExportar.Location = new Point(828, 328);
            btnCVExportar.Margin = new Padding(3, 2, 3, 2);
            btnCVExportar.Name = "btnCVExportar";
            btnCVExportar.Size = new Size(127, 34);
            btnCVExportar.TabIndex = 17;
            btnCVExportar.Text = "Exportar";
            btnCVExportar.UseVisualStyleBackColor = false;
            // 
            // btnCVImprimir
            // 
            btnCVImprimir.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 255);
            btnCVImprimir.FlatStyle = FlatStyle.Flat;
            btnCVImprimir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVImprimir.Location = new Point(635, 328);
            btnCVImprimir.Margin = new Padding(3, 2, 3, 2);
            btnCVImprimir.Name = "btnCVImprimir";
            btnCVImprimir.Size = new Size(154, 34);
            btnCVImprimir.TabIndex = 16;
            btnCVImprimir.Text = "Imprimir factura";
            btnCVImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvCVF
            // 
            dgvCVF.AllowUserToAddRows = false;
            dgvCVF.AllowUserToDeleteRows = false;
            dgvCVF.AllowUserToResizeColumns = false;
            dgvCVF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCVF.BackgroundColor = Color.White;
            dgvCVF.BorderStyle = BorderStyle.None;
            dgvCVF.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCVF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCVF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCVF.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colFecha, colHora, colVendedor, colSucursal, colSubtotal, colDescuento, colTotal, colEstado, colAcciones });
            dgvCVF.Location = new Point(17, 13);
            dgvCVF.Margin = new Padding(3, 2, 3, 2);
            dgvCVF.MultiSelect = false;
            dgvCVF.Name = "dgvCVF";
            dgvCVF.ReadOnly = true;
            dgvCVF.RowHeadersVisible = false;
            dgvCVF.RowHeadersWidth = 51;
            dgvCVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCVF.Size = new Size(1082, 302);
            dgvCVF.TabIndex = 15;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.MinimumWidth = 6;
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colVendedor
            // 
            colVendedor.HeaderText = "Vendedor";
            colVendedor.MinimumWidth = 6;
            colVendedor.Name = "colVendedor";
            colVendedor.ReadOnly = true;
            // 
            // colSucursal
            // 
            colSucursal.HeaderText = "Sucursal";
            colSucursal.MinimumWidth = 6;
            colSucursal.Name = "colSucursal";
            colSucursal.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colDescuento
            // 
            colDescuento.HeaderText = "Descuento";
            colDescuento.MinimumWidth = 6;
            colDescuento.Name = "colDescuento";
            colDescuento.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // lblCVR
            // 
            lblCVR.AutoSize = true;
            lblCVR.BackColor = Color.White;
            lblCVR.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCVR.Location = new Point(69, 33);
            lblCVR.Name = "lblCVR";
            lblCVR.Size = new Size(326, 18);
            lblCVR.TabIndex = 3;
            lblCVR.Text = "Busca y consulta las ventas registradas en el sistema";
            // 
            // pic_agg1
            // 
            pic_agg1.BackColor = Color.White;
            pic_agg1.Image = (Image)resources.GetObject("pic_agg1.Image");
            pic_agg1.Location = new Point(23, 15);
            pic_agg1.Margin = new Padding(3, 2, 3, 2);
            pic_agg1.Name = "pic_agg1";
            pic_agg1.Size = new Size(42, 23);
            pic_agg1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_agg1.TabIndex = 2;
            pic_agg1.TabStop = false;
            // 
            // lblCV
            // 
            lblCV.AutoSize = true;
            lblCV.BackColor = Color.White;
            lblCV.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCV.ImageAlign = ContentAlignment.MiddleLeft;
            lblCV.Location = new Point(69, 9);
            lblCV.Name = "lblCV";
            lblCV.Size = new Size(290, 24);
            lblCV.TabIndex = 1;
            lblCV.Text = "Consulta e Historial de Ventas";
            lblCV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCVinfo
            // 
            pnlCVinfo.BackColor = Color.White;
            pnlCVinfo.BorderStyle = BorderStyle.FixedSingle;
            pnlCVinfo.Controls.Add(btnCVLimpiar);
            pnlCVinfo.Controls.Add(btnCVBuscar);
            pnlCVinfo.Controls.Add(dtpCVFechaHasta);
            pnlCVinfo.Controls.Add(lblCVfechaHasta);
            pnlCVinfo.Controls.Add(cbCVEstado);
            pnlCVinfo.Controls.Add(lblC3);
            pnlCVinfo.Controls.Add(lblCVEstado);
            pnlCVinfo.Controls.Add(dtpCVDesde);
            pnlCVinfo.Controls.Add(lblC2);
            pnlCVinfo.Controls.Add(lblC1);
            pnlCVinfo.Controls.Add(lblCVfechaDesde);
            pnlCVinfo.Location = new Point(10, 70);
            pnlCVinfo.Margin = new Padding(3, 2, 3, 2);
            pnlCVinfo.Name = "pnlCVinfo";
            pnlCVinfo.Size = new Size(1133, 90);
            pnlCVinfo.TabIndex = 0;
            // 
            // btnCVLimpiar
            // 
            btnCVLimpiar.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 0);
            btnCVLimpiar.FlatStyle = FlatStyle.Flat;
            btnCVLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVLimpiar.Location = new Point(973, 29);
            btnCVLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnCVLimpiar.Name = "btnCVLimpiar";
            btnCVLimpiar.Size = new Size(127, 34);
            btnCVLimpiar.TabIndex = 40;
            btnCVLimpiar.Text = "Limpiar";
            btnCVLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCVBuscar
            // 
            btnCVBuscar.BackColor = Color.FromArgb(255, 136, 0);
            btnCVBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVBuscar.Location = new Point(788, 29);
            btnCVBuscar.Margin = new Padding(3, 2, 3, 2);
            btnCVBuscar.Name = "btnCVBuscar";
            btnCVBuscar.Size = new Size(127, 34);
            btnCVBuscar.TabIndex = 39;
            btnCVBuscar.Text = "Buscar";
            btnCVBuscar.UseVisualStyleBackColor = false;
            // 
            // dtpCVFechaHasta
            // 
            dtpCVFechaHasta.CustomFormat = "dd/MM/yyyy";
            dtpCVFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpCVFechaHasta.Location = new Point(234, 35);
            dtpCVFechaHasta.Margin = new Padding(3, 2, 3, 2);
            dtpCVFechaHasta.Name = "dtpCVFechaHasta";
            dtpCVFechaHasta.Size = new Size(145, 23);
            dtpCVFechaHasta.TabIndex = 38;
            // 
            // lblCVfechaHasta
            // 
            lblCVfechaHasta.AutoSize = true;
            lblCVfechaHasta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVfechaHasta.Location = new Point(234, 16);
            lblCVfechaHasta.Name = "lblCVfechaHasta";
            lblCVfechaHasta.Size = new Size(89, 18);
            lblCVfechaHasta.TabIndex = 37;
            lblCVfechaHasta.Text = "Fecha hasta";
            // 
            // cbCVEstado
            // 
            cbCVEstado.FormattingEnabled = true;
            cbCVEstado.Location = new Point(477, 37);
            cbCVEstado.Margin = new Padding(3, 2, 3, 2);
            cbCVEstado.Name = "cbCVEstado";
            cbCVEstado.Size = new Size(215, 23);
            cbCVEstado.TabIndex = 31;
            // 
            // lblC3
            // 
            lblC3.AutoSize = true;
            lblC3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC3.ForeColor = Color.Red;
            lblC3.Location = new Point(528, 16);
            lblC3.Name = "lblC3";
            lblC3.Size = new Size(16, 20);
            lblC3.TabIndex = 30;
            lblC3.Text = "*";
            // 
            // lblCVEstado
            // 
            lblCVEstado.AutoSize = true;
            lblCVEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVEstado.Location = new Point(477, 16);
            lblCVEstado.Name = "lblCVEstado";
            lblCVEstado.Size = new Size(55, 18);
            lblCVEstado.TabIndex = 29;
            lblCVEstado.Text = "Estado";
            // 
            // dtpCVDesde
            // 
            dtpCVDesde.CustomFormat = "dd/MM/yyyy";
            dtpCVDesde.Format = DateTimePickerFormat.Custom;
            dtpCVDesde.Location = new Point(16, 35);
            dtpCVDesde.Margin = new Padding(3, 2, 3, 2);
            dtpCVDesde.Name = "dtpCVDesde";
            dtpCVDesde.Size = new Size(145, 23);
            dtpCVDesde.TabIndex = 27;
            // 
            // lblC2
            // 
            lblC2.AutoSize = true;
            lblC2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC2.ForeColor = Color.Red;
            lblC2.Location = new Point(324, 14);
            lblC2.Name = "lblC2";
            lblC2.Size = new Size(16, 20);
            lblC2.TabIndex = 10;
            lblC2.Text = "*";
            // 
            // lblC1
            // 
            lblC1.AutoSize = true;
            lblC1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC1.ForeColor = Color.Red;
            lblC1.Location = new Point(109, 14);
            lblC1.Name = "lblC1";
            lblC1.Size = new Size(16, 20);
            lblC1.TabIndex = 6;
            lblC1.Text = "*";
            // 
            // lblCVfechaDesde
            // 
            lblCVfechaDesde.AutoSize = true;
            lblCVfechaDesde.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVfechaDesde.Location = new Point(16, 16);
            lblCVfechaDesde.Name = "lblCVfechaDesde";
            lblCVfechaDesde.Size = new Size(93, 18);
            lblCVfechaDesde.TabIndex = 5;
            lblCVfechaDesde.Text = "Fecha desde";
            // 
            // pnlCVR
            // 
            pnlCVR.BackColor = Color.White;
            pnlCVR.Controls.Add(button1);
            pnlCVR.Controls.Add(lblSalirCV);
            pnlCVR.Location = new Point(12, 3);
            pnlCVR.Name = "pnlCVR";
            pnlCVR.Size = new Size(1131, 54);
            pnlCVR.TabIndex = 22;
            // 
            // lblSalirCV
            // 
            lblSalirCV.AutoSize = true;
            lblSalirCV.BackColor = Color.White;
            lblSalirCV.Cursor = Cursors.Hand;
            lblSalirCV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirCV.ForeColor = Color.Red;
            lblSalirCV.Location = new Point(1106, 12);
            lblSalirCV.Name = "lblSalirCV";
            lblSalirCV.Size = new Size(25, 24);
            lblSalirCV.TabIndex = 21;
            lblSalirCV.Text = "X";
            lblSalirCV.Click += lblSalirCV_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 136, 0);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(870, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 40;
            button1.Text = "Nueva Venta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmConsultarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1181, 563);
            Controls.Add(pnlCV);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmConsultarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarVenta";
            pnlCV.ResumeLayout(false);
            pnlCV.PerformLayout();
            pnlCVF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCVF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            pnlCVinfo.ResumeLayout(false);
            pnlCVinfo.PerformLayout();
            pnlCVR.ResumeLayout(false);
            pnlCVR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCV;
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
        private PictureBox pictureBox3;
        private Panel pnlCVF;
        private Button btnCVCerrar;
        private Button btnCVExportar;
        private Button btnCVImprimir;
        private DataGridView dgvCVF;
        private Panel pnlNVAP;
        private Button btnNVAgregar;
        private Label lblNVCantidad;
        private PictureBox picNVBP;
        private TextBox txtNVBuscarProducto;
        private NumericUpDown nudNVCantidad;
        private Label lblR7;
        private Label lblNVAgregarProductos;
        private Label lblR6;
        private PictureBox pictureBox1;
        private Label lblNVBuscarProducto;
        private Label lblCVR;
        private PictureBox pic_agg1;
        private Label lblCV;
        private Panel pnlNVinfo;
        private Panel pnlCVinfo;
        private ComboBox cbCVEstado;
        private Label lblC3;
        private Label lblCVEstado;
        private Label lblR3;
        private Label lblNVVen;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtpCVDesde;
        private Label lblC2;
        private Label lblR2;
        private Label lblC1;
        private Label lblNVHora;
        private Label lblCVfechaDesde;
        private Label lblNVI;
        private PictureBox pic_agg2;
        private Panel pnlCVR;
        private Label lblSalirCV;
        private DateTimePicker dtpCVFechaHasta;
        private Label lblCVfechaHasta;
        private Button btnCVLimpiar;
        private Button btnCVBuscar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colVendedor;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colAcciones;
        private Button button1;
    }
}