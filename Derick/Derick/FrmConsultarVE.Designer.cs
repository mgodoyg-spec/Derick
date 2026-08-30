namespace Derick
{
    partial class FrmConsultarVE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVE));
            pnlCV = new Panel();
            pnlCVF = new Panel();
            btnCVImprimirE = new Button();
            dgvCVFE = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colVendedor = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewImageColumn();
            colEliminar = new DataGridViewImageColumn();
            lblCVR = new Label();
            pic_agg1 = new PictureBox();
            lblCV = new Label();
            pnlCVinfo = new Panel();
            btnCVLimpiarE = new Button();
            btnCVBuscarE = new Button();
            dtpCVFechaHastaE = new DateTimePicker();
            lblCVfechaHasta = new Label();
            cbCVEstadoE = new ComboBox();
            lblC3 = new Label();
            lblCVEstado = new Label();
            dtpCVDesdeE = new DateTimePicker();
            lblC2 = new Label();
            lblC1 = new Label();
            lblCVfechaDesde = new Label();
            pnlCVR = new Panel();
            btnCE = new Button();
            lblSalirCV = new Label();
            pnlCV.SuspendLayout();
            pnlCVF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCVFE).BeginInit();
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
            pnlCV.Location = new Point(9, -2);
            pnlCV.Margin = new Padding(3, 2, 3, 2);
            pnlCV.Name = "pnlCV";
            pnlCV.Size = new Size(1150, 630);
            pnlCV.TabIndex = 4;
            // 
            // pnlCVF
            // 
            pnlCVF.BackColor = Color.FromArgb(244, 246, 249);
            pnlCVF.Controls.Add(btnCVImprimirE);
            pnlCVF.Controls.Add(dgvCVFE);
            pnlCVF.Location = new Point(10, 144);
            pnlCVF.Margin = new Padding(3, 2, 3, 2);
            pnlCVF.Name = "pnlCVF";
            pnlCVF.Size = new Size(1133, 460);
            pnlCVF.TabIndex = 6;
            // 
            // btnCVImprimirE
            // 
            btnCVImprimirE.BackColor = Color.FromArgb(13, 154, 64);
            btnCVImprimirE.FlatAppearance.BorderColor = Color.FromArgb(4, 59, 186);
            btnCVImprimirE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVImprimirE.ForeColor = Color.White;
            btnCVImprimirE.Location = new Point(945, 9);
            btnCVImprimirE.Margin = new Padding(3, 2, 3, 2);
            btnCVImprimirE.Name = "btnCVImprimirE";
            btnCVImprimirE.Size = new Size(154, 34);
            btnCVImprimirE.TabIndex = 16;
            btnCVImprimirE.Text = "Imprimir factura";
            btnCVImprimirE.UseVisualStyleBackColor = false;
            btnCVImprimirE.Click += btnCVImprimir_Click;
            // 
            // dgvCVFE
            // 
            dgvCVFE.AllowUserToAddRows = false;
            dgvCVFE.AllowUserToDeleteRows = false;
            dgvCVFE.AllowUserToResizeColumns = false;
            dgvCVFE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCVFE.BackgroundColor = Color.White;
            dgvCVFE.BorderStyle = BorderStyle.None;
            dgvCVFE.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCVFE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCVFE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCVFE.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colFecha, colHora, colVendedor, colSucursal, colCliente, colSubtotal, colDescuento, colTotal, colEstado, colEditar, colEliminar });
            dgvCVFE.Location = new Point(17, 47);
            dgvCVFE.Margin = new Padding(3, 2, 3, 2);
            dgvCVFE.MultiSelect = false;
            dgvCVFE.Name = "dgvCVFE";
            dgvCVFE.ReadOnly = true;
            dgvCVFE.RowHeadersVisible = false;
            dgvCVFE.RowHeadersWidth = 51;
            dgvCVFE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCVFE.Size = new Size(1082, 391);
            dgvCVFE.TabIndex = 15;
            dgvCVFE.CellClick += dgvCVF_CellClick;
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
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
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
            // colEditar
            // 
            colEditar.HeaderText = "Ver más";
            colEditar.MinimumWidth = 6;
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Resizable = DataGridViewTriState.True;
            colEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Anular";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
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
            lblCV.ForeColor = Color.FromArgb(13, 154, 64);
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
            pnlCVinfo.BackColor = Color.FromArgb(244, 246, 249);
            pnlCVinfo.BorderStyle = BorderStyle.FixedSingle;
            pnlCVinfo.Controls.Add(btnCVLimpiarE);
            pnlCVinfo.Controls.Add(btnCVBuscarE);
            pnlCVinfo.Controls.Add(dtpCVFechaHastaE);
            pnlCVinfo.Controls.Add(lblCVfechaHasta);
            pnlCVinfo.Controls.Add(cbCVEstadoE);
            pnlCVinfo.Controls.Add(lblC3);
            pnlCVinfo.Controls.Add(lblCVEstado);
            pnlCVinfo.Controls.Add(dtpCVDesdeE);
            pnlCVinfo.Controls.Add(lblC2);
            pnlCVinfo.Controls.Add(lblC1);
            pnlCVinfo.Controls.Add(lblCVfechaDesde);
            pnlCVinfo.Location = new Point(10, 62);
            pnlCVinfo.Margin = new Padding(3, 2, 3, 2);
            pnlCVinfo.Name = "pnlCVinfo";
            pnlCVinfo.Size = new Size(1133, 78);
            pnlCVinfo.TabIndex = 0;
            // 
            // btnCVLimpiarE
            // 
            btnCVLimpiarE.FlatAppearance.BorderColor = Color.FromArgb(4, 59, 186);
            btnCVLimpiarE.FlatStyle = FlatStyle.Flat;
            btnCVLimpiarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVLimpiarE.Location = new Point(974, 24);
            btnCVLimpiarE.Margin = new Padding(3, 2, 3, 2);
            btnCVLimpiarE.Name = "btnCVLimpiarE";
            btnCVLimpiarE.Size = new Size(127, 34);
            btnCVLimpiarE.TabIndex = 40;
            btnCVLimpiarE.Text = "Limpiar";
            btnCVLimpiarE.UseVisualStyleBackColor = false;
            btnCVLimpiarE.Click += btnCVLimpiar_Click;
            // 
            // btnCVBuscarE
            // 
            btnCVBuscarE.BackColor = Color.FromArgb(4, 59, 186);
            btnCVBuscarE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCVBuscarE.ForeColor = Color.Transparent;
            btnCVBuscarE.Location = new Point(788, 24);
            btnCVBuscarE.Margin = new Padding(3, 2, 3, 2);
            btnCVBuscarE.Name = "btnCVBuscarE";
            btnCVBuscarE.Size = new Size(127, 34);
            btnCVBuscarE.TabIndex = 39;
            btnCVBuscarE.Text = "Buscar";
            btnCVBuscarE.UseVisualStyleBackColor = false;
            btnCVBuscarE.Click += btnCVBuscar_Click;
            // 
            // dtpCVFechaHastaE
            // 
            dtpCVFechaHastaE.CustomFormat = "dd/MM/yyyy";
            dtpCVFechaHastaE.Format = DateTimePickerFormat.Custom;
            dtpCVFechaHastaE.Location = new Point(234, 35);
            dtpCVFechaHastaE.Margin = new Padding(3, 2, 3, 2);
            dtpCVFechaHastaE.Name = "dtpCVFechaHastaE";
            dtpCVFechaHastaE.Size = new Size(145, 23);
            dtpCVFechaHastaE.TabIndex = 38;
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
            // cbCVEstadoE
            // 
            cbCVEstadoE.FormattingEnabled = true;
            cbCVEstadoE.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbCVEstadoE.Location = new Point(477, 37);
            cbCVEstadoE.Margin = new Padding(3, 2, 3, 2);
            cbCVEstadoE.Name = "cbCVEstadoE";
            cbCVEstadoE.Size = new Size(215, 23);
            cbCVEstadoE.TabIndex = 31;
            // 
            // lblC3
            // 
            lblC3.AutoSize = true;
            lblC3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC3.ForeColor = Color.Red;
            lblC3.Location = new Point(532, 16);
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
            // dtpCVDesdeE
            // 
            dtpCVDesdeE.CustomFormat = "dd/MM/yyyy";
            dtpCVDesdeE.Format = DateTimePickerFormat.Custom;
            dtpCVDesdeE.Location = new Point(16, 35);
            dtpCVDesdeE.Margin = new Padding(3, 2, 3, 2);
            dtpCVDesdeE.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpCVDesdeE.Name = "dtpCVDesdeE";
            dtpCVDesdeE.Size = new Size(145, 23);
            dtpCVDesdeE.TabIndex = 27;
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
            pnlCVR.Controls.Add(btnCE);
            pnlCVR.Controls.Add(lblSalirCV);
            pnlCVR.Location = new Point(10, 9);
            pnlCVR.Name = "pnlCVR";
            pnlCVR.Size = new Size(1131, 47);
            pnlCVR.TabIndex = 22;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(13, 154, 64);
            btnCE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.ForeColor = Color.Transparent;
            btnCE.Location = new Point(870, 8);
            btnCE.Margin = new Padding(3, 2, 3, 2);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(127, 34);
            btnCE.TabIndex = 40;
            btnCE.Text = "Nueva Venta";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
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
            // 
            // FrmConsultarVE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 627);
            Controls.Add(pnlCV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarVE";
            Text = "FrmConsultarVE";
            Load += FrmConsultarVE_Load;
            pnlCV.ResumeLayout(false);
            pnlCV.PerformLayout();
            pnlCVF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCVFE).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_agg1).EndInit();
            pnlCVinfo.ResumeLayout(false);
            pnlCVinfo.PerformLayout();
            pnlCVR.ResumeLayout(false);
            pnlCVR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCV;
        private Panel pnlCVF;
        private Button btnCVImprimirE;
        private DataGridView dgvCVFE;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colVendedor;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewImageColumn colEditar;
        private DataGridViewImageColumn colEliminar;
        private Label lblCVR;
        private PictureBox pic_agg1;
        private Label lblCV;
        private Panel pnlCVinfo;
        private Button btnCVLimpiarE;
        private Button btnCVBuscarE;
        private DateTimePicker dtpCVFechaHastaE;
        private Label lblCVfechaHasta;
        private ComboBox cbCVEstadoE;
        private Label lblC3;
        private Label lblCVEstado;
        private DateTimePicker dtpCVDesdeE;
        private Label lblC2;
        private Label lblC1;
        private Label lblCVfechaDesde;
        private Panel pnlCVR;
        private Button btnCE;
        private Label lblSalirCV;
    }
}