namespace Derick
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            pnlMostrarFrmR = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lblLimpiarF = new Button();
            label2 = new Label();
            btnGenerarR = new Button();
            lblTipoR = new Label();
            cmbSucursal = new ComboBox();
            dtpFechaFin = new DateTimePicker();
            lblSucursal = new Label();
            cmbTipoReporte = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            lblFechaIn = new Label();
            pnlReportes = new Panel();
            lblSalirV = new Label();
            pictureBox1 = new PictureBox();
            pbxBuscarSucursal = new PictureBox();
            lblReportes = new Label();
            lblResumenReportes = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            pnlMostrarFrmR.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            SuspendLayout();
            // 
            // pnlMostrarFrmR
            // 
            pnlMostrarFrmR.BackColor = Color.FromArgb(244, 246, 249);
            pnlMostrarFrmR.Controls.Add(panel2);
            pnlMostrarFrmR.Controls.Add(panel1);
            pnlMostrarFrmR.Controls.Add(pnlReportes);
            pnlMostrarFrmR.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlMostrarFrmR.Location = new Point(-8, 5);
            pnlMostrarFrmR.Name = "pnlMostrarFrmR";
            pnlMostrarFrmR.Size = new Size(1186, 700);
            pnlMostrarFrmR.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(248, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 592);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblLimpiarF);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGenerarR);
            panel1.Controls.Add(lblTipoR);
            panel1.Controls.Add(cmbSucursal);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(lblSucursal);
            panel1.Controls.Add(cmbTipoReporte);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Controls.Add(lblFechaFin);
            panel1.Controls.Add(lblFechaIn);
            panel1.Location = new Point(20, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 592);
            panel1.TabIndex = 8;
            // 
            // lblLimpiarF
            // 
            lblLimpiarF.BackColor = Color.FromArgb(224, 224, 224);
            lblLimpiarF.Cursor = Cursors.Hand;
            lblLimpiarF.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimpiarF.ForeColor = Color.Black;
            lblLimpiarF.ImageAlign = ContentAlignment.MiddleLeft;
            lblLimpiarF.Location = new Point(54, 358);
            lblLimpiarF.Name = "lblLimpiarF";
            lblLimpiarF.Size = new Size(113, 30);
            lblLimpiarF.TabIndex = 23;
            lblLimpiarF.Text = "Limpiar Filtros";
            lblLimpiarF.TextAlign = ContentAlignment.MiddleRight;
            lblLimpiarF.UseVisualStyleBackColor = false;
            lblLimpiarF.Click += lblLimpiarF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 13;
            // 
            // btnGenerarR
            // 
            btnGenerarR.BackColor = Color.FromArgb(0, 102, 255);
            btnGenerarR.Cursor = Cursors.Hand;
            btnGenerarR.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarR.ForeColor = Color.White;
            btnGenerarR.Location = new Point(33, 312);
            btnGenerarR.Name = "btnGenerarR";
            btnGenerarR.Size = new Size(154, 30);
            btnGenerarR.TabIndex = 22;
            btnGenerarR.Text = "Generar Reporte";
            btnGenerarR.UseVisualStyleBackColor = false;
            btnGenerarR.Click += btnGenerarR_Click;
            // 
            // lblTipoR
            // 
            lblTipoR.AutoSize = true;
            lblTipoR.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoR.Location = new Point(18, 12);
            lblTipoR.Name = "lblTipoR";
            lblTipoR.Size = new Size(113, 18);
            lblTipoR.TabIndex = 11;
            lblTipoR.Text = "Tipo de Reportes";
            // 
            // cmbSucursal
            // 
            cmbSucursal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSucursal.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSucursal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Items.AddRange(new object[] { "Buena Fé", "El Empalme", "Quevedo", "Todas las sucursales", "Valencia" });
            cmbSucursal.Location = new Point(15, 259);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(193, 26);
            cmbSucursal.Sorted = true;
            cmbSucursal.TabIndex = 18;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(18, 178);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(123, 26);
            dtpFechaFin.TabIndex = 21;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.Location = new Point(18, 238);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(59, 18);
            lblSucursal.TabIndex = 13;
            lblSucursal.Text = "Sucursal";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoReporte.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTipoReporte.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Detalle de ventas", "Productos más vendidos", "Ventas por categoría", "Ventas por empleado", "Ventas por sucursal" });
            cmbTipoReporte.Location = new Point(15, 31);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(193, 26);
            cmbTipoReporte.Sorted = true;
            cmbTipoReporte.TabIndex = 12;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(18, 100);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(123, 26);
            dtpFechaInicio.TabIndex = 20;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.Location = new Point(18, 157);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(85, 18);
            lblFechaFin.TabIndex = 15;
            lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblFechaIn
            // 
            lblFechaIn.AutoSize = true;
            lblFechaIn.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIn.Location = new Point(18, 79);
            lblFechaIn.Name = "lblFechaIn";
            lblFechaIn.Size = new Size(100, 18);
            lblFechaIn.TabIndex = 16;
            lblFechaIn.Text = "Fecha de inicio";
            // 
            // pnlReportes
            // 
            pnlReportes.BackColor = Color.White;
            pnlReportes.BackgroundImageLayout = ImageLayout.Stretch;
            pnlReportes.Controls.Add(lblSalirV);
            pnlReportes.Controls.Add(pictureBox1);
            pnlReportes.Controls.Add(pbxBuscarSucursal);
            pnlReportes.Controls.Add(lblReportes);
            pnlReportes.Controls.Add(lblResumenReportes);
            pnlReportes.Location = new Point(20, 12);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(1145, 68);
            pnlReportes.TabIndex = 1;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1117, 0);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 31;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(67, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 14);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = Properties.Resources.Reports;
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(18, 8);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(43, 39);
            pbxBuscarSucursal.TabIndex = 29;
            pbxBuscarSucursal.TabStop = false;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.BackColor = Color.White;
            lblReportes.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.FromArgb(13, 154, 64);
            lblReportes.Location = new Point(67, 8);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(90, 26);
            lblReportes.TabIndex = 28;
            lblReportes.Text = "Reportes";
            // 
            // lblResumenReportes
            // 
            lblResumenReportes.AutoSize = true;
            lblResumenReportes.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResumenReportes.ForeColor = Color.Black;
            lblResumenReportes.Location = new Point(33, 60);
            lblResumenReportes.Name = "lblResumenReportes";
            lblResumenReportes.Size = new Size(0, 19);
            lblResumenReportes.TabIndex = 13;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnlMostrarFrmR);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReportes";
            Load += frmReportes_Load;
            pnlMostrarFrmR.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlReportes.ResumeLayout(false);
            pnlReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMostrarFrmR;
        private Button btnVerTodoVentas;
        private Panel pnlReportes;
        private Label lblResumenReportes;
        private ComboBox cmbTipoReporte;
        private Label lblTipoR;
        private ComboBox cmbSucursal;
        private Label lblFechaIn;
        private Label lblFechaFin;
        private Label lblSucursal;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Button btnGenerarR;
        private Button lblLimpiarF;
        private Label lblReportes;
        private PictureBox pbxBuscarSucursal;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblSalirV;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}