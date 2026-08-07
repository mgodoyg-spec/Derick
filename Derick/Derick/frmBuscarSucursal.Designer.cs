namespace Derick
{
    partial class frmBuscarSucursal
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
            pnlBuscarSucursal = new Panel();
            lblSucReg = new Label();
            pnlSucursalesRemodelacion = new Panel();
            pictureBox4 = new PictureBox();
            lblSucursalesRemodelacion = new Label();
            lblSucRemod = new Label();
            pnlSucursalesInactivas = new Panel();
            pictureBox3 = new PictureBox();
            lblSucursalesInactivas = new Label();
            lblSucInac = new Label();
            pnlSucursalesActivas = new Panel();
            pictureBox2 = new PictureBox();
            lblSucursalesActivas = new Label();
            lblSucAct = new Label();
            pnlTotalSucursales = new Panel();
            lblTotalSucursales = new Label();
            lbltotalsuc = new Label();
            pictureBox1 = new PictureBox();
            dgvSucursales = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clNombreSucursal = new DataGridViewTextBoxColumn();
            clCiudad = new DataGridViewTextBoxColumn();
            clDireccion = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewButtonColumn();
            clUbicacion = new DataGridViewButtonColumn();
            clVer = new DataGridViewButtonColumn();
            pbxBuscarSucursal = new PictureBox();
            btnBuscar = new Button();
            label7 = new Label();
            label8 = new Label();
            cbxEstado = new ComboBox();
            cbxCiudad = new ComboBox();
            txtBuscar = new TextBox();
            pnlBusqueda = new Panel();
            lblBuscarSucursal = new Label();
            pnlBuscarSucursal.SuspendLayout();
            pnlSucursalesRemodelacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlSucursalesInactivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSucursalesActivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTotalSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBuscarSucursal
            // 
            pnlBuscarSucursal.Anchor = AnchorStyles.Left;
            pnlBuscarSucursal.BackColor = Color.FromArgb(244, 246, 249);
            pnlBuscarSucursal.Controls.Add(lblSucReg);
            pnlBuscarSucursal.Controls.Add(pnlSucursalesRemodelacion);
            pnlBuscarSucursal.Controls.Add(pnlSucursalesInactivas);
            pnlBuscarSucursal.Controls.Add(pnlSucursalesActivas);
            pnlBuscarSucursal.Controls.Add(pnlTotalSucursales);
            pnlBuscarSucursal.Controls.Add(dgvSucursales);
            pnlBuscarSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBuscarSucursal.Location = new Point(24, 171);
            pnlBuscarSucursal.Margin = new Padding(4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1074, 578);
            pnlBuscarSucursal.TabIndex = 4;
            // 
            // lblSucReg
            // 
            lblSucReg.AutoSize = true;
            lblSucReg.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucReg.Location = new Point(448, 17);
            lblSucReg.Name = "lblSucReg";
            lblSucReg.Size = new Size(201, 26);
            lblSucReg.TabIndex = 27;
            lblSucReg.Text = "Sucursales registradas";
            // 
            // pnlSucursalesRemodelacion
            // 
            pnlSucursalesRemodelacion.BackColor = Color.White;
            pnlSucursalesRemodelacion.Controls.Add(pictureBox4);
            pnlSucursalesRemodelacion.Controls.Add(lblSucursalesRemodelacion);
            pnlSucursalesRemodelacion.Controls.Add(lblSucRemod);
            pnlSucursalesRemodelacion.Location = new Point(777, 351);
            pnlSucursalesRemodelacion.Name = "pnlSucursalesRemodelacion";
            pnlSucursalesRemodelacion.Size = new Size(238, 110);
            pnlSucursalesRemodelacion.TabIndex = 26;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.sucRemod;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(5, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 57);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lblSucursalesRemodelacion
            // 
            lblSucursalesRemodelacion.AutoSize = true;
            lblSucursalesRemodelacion.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursalesRemodelacion.Location = new Point(129, 49);
            lblSucursalesRemodelacion.Name = "lblSucursalesRemodelacion";
            lblSucursalesRemodelacion.Size = new Size(25, 29);
            lblSucursalesRemodelacion.TabIndex = 8;
            lblSucursalesRemodelacion.Text = "0";
            // 
            // lblSucRemod
            // 
            lblSucRemod.AutoSize = true;
            lblSucRemod.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucRemod.Location = new Point(3, 1);
            lblSucRemod.Name = "lblSucRemod";
            lblSucRemod.Size = new Size(235, 23);
            lblSucRemod.TabIndex = 7;
            lblSucRemod.Text = "Sucursales en remodelación ";
            // 
            // pnlSucursalesInactivas
            // 
            pnlSucursalesInactivas.BackColor = Color.White;
            pnlSucursalesInactivas.Controls.Add(pictureBox3);
            pnlSucursalesInactivas.Controls.Add(lblSucursalesInactivas);
            pnlSucursalesInactivas.Controls.Add(lblSucInac);
            pnlSucursalesInactivas.Location = new Point(533, 351);
            pnlSucursalesInactivas.Name = "pnlSucursalesInactivas";
            pnlSucursalesInactivas.Size = new Size(238, 110);
            pnlSucursalesInactivas.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.sucInact1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 57);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lblSucursalesInactivas
            // 
            lblSucursalesInactivas.AutoSize = true;
            lblSucursalesInactivas.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursalesInactivas.Location = new Point(127, 49);
            lblSucursalesInactivas.Name = "lblSucursalesInactivas";
            lblSucursalesInactivas.Size = new Size(25, 29);
            lblSucursalesInactivas.TabIndex = 6;
            lblSucursalesInactivas.Text = "0";
            // 
            // lblSucInac
            // 
            lblSucInac.AutoSize = true;
            lblSucInac.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucInac.Location = new Point(45, 3);
            lblSucInac.Name = "lblSucInac";
            lblSucInac.Size = new Size(167, 23);
            lblSucInac.TabIndex = 5;
            lblSucInac.Text = "Sucursales inactivas";
            // 
            // pnlSucursalesActivas
            // 
            pnlSucursalesActivas.BackColor = Color.White;
            pnlSucursalesActivas.Controls.Add(pictureBox2);
            pnlSucursalesActivas.Controls.Add(lblSucursalesActivas);
            pnlSucursalesActivas.Controls.Add(lblSucAct);
            pnlSucursalesActivas.Location = new Point(289, 351);
            pnlSucursalesActivas.Name = "pnlSucursalesActivas";
            pnlSucursalesActivas.Size = new Size(238, 110);
            pnlSucursalesActivas.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.sucAct;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(9, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 57);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblSucursalesActivas
            // 
            lblSucursalesActivas.AutoSize = true;
            lblSucursalesActivas.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursalesActivas.Location = new Point(124, 49);
            lblSucursalesActivas.Name = "lblSucursalesActivas";
            lblSucursalesActivas.Size = new Size(25, 29);
            lblSucursalesActivas.TabIndex = 4;
            lblSucursalesActivas.Text = "0";
            // 
            // lblSucAct
            // 
            lblSucAct.AutoSize = true;
            lblSucAct.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucAct.Location = new Point(70, 3);
            lblSucAct.Name = "lblSucAct";
            lblSucAct.Size = new Size(152, 23);
            lblSucAct.TabIndex = 3;
            lblSucAct.Text = "Sucursales activas";
            // 
            // pnlTotalSucursales
            // 
            pnlTotalSucursales.BackColor = Color.White;
            pnlTotalSucursales.Controls.Add(lblTotalSucursales);
            pnlTotalSucursales.Controls.Add(lbltotalsuc);
            pnlTotalSucursales.Controls.Add(pictureBox1);
            pnlTotalSucursales.Location = new Point(45, 351);
            pnlTotalSucursales.Name = "pnlTotalSucursales";
            pnlTotalSucursales.Size = new Size(238, 110);
            pnlTotalSucursales.TabIndex = 25;
            // 
            // lblTotalSucursales
            // 
            lblTotalSucursales.AutoSize = true;
            lblTotalSucursales.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSucursales.Location = new Point(122, 49);
            lblTotalSucursales.Name = "lblTotalSucursales";
            lblTotalSucursales.Size = new Size(25, 29);
            lblTotalSucursales.TabIndex = 2;
            lblTotalSucursales.Text = "0";
            // 
            // lbltotalsuc
            // 
            lbltotalsuc.AutoSize = true;
            lbltotalsuc.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalsuc.Location = new Point(69, 3);
            lbltotalsuc.Name = "lbltotalsuc";
            lbltotalsuc.Size = new Size(135, 23);
            lbltotalsuc.TabIndex = 1;
            lbltotalsuc.Text = "Total sucursales";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.totalSuc;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clNombreSucursal, clCiudad, clDireccion, clTelefono, clEstado, clEditar, clUbicacion, clVer });
            dgvSucursales.Location = new Point(48, 46);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.Size = new Size(936, 299);
            dgvSucursales.TabIndex = 22;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.Name = "clCodigo";
            clCodigo.ReadOnly = true;
            // 
            // clNombreSucursal
            // 
            clNombreSucursal.HeaderText = "Nombre de la sucursal";
            clNombreSucursal.Name = "clNombreSucursal";
            clNombreSucursal.ReadOnly = true;
            // 
            // clCiudad
            // 
            clCiudad.HeaderText = "Ciudad";
            clCiudad.Name = "clCiudad";
            clCiudad.ReadOnly = true;
            // 
            // clDireccion
            // 
            clDireccion.HeaderText = "Dirección";
            clDireccion.Name = "clDireccion";
            clDireccion.ReadOnly = true;
            // 
            // clTelefono
            // 
            clTelefono.HeaderText = "Teléfono";
            clTelefono.Name = "clTelefono";
            clTelefono.ReadOnly = true;
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.Name = "clEstado";
            clEstado.ReadOnly = true;
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.Name = "clEditar";
            clEditar.ReadOnly = true;
            clEditar.Resizable = DataGridViewTriState.True;
            clEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // clUbicacion
            // 
            clUbicacion.HeaderText = "Ubicación";
            clUbicacion.Name = "clUbicacion";
            // 
            // clVer
            // 
            clVer.HeaderText = "Ver más";
            clVer.Name = "clVer";
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = Properties.Resources.iconoBuscar;
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(3, 3);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(43, 39);
            pbxBuscarSucursal.TabIndex = 24;
            pbxBuscarSucursal.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 176, 80);
            btnBuscar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(836, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(149, 31);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(587, 52);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 20;
            label7.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(351, 52);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 4;
            label8.Text = "Ciudad:";
            // 
            // cbxEstado
            // 
            cbxEstado.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(661, 49);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 31);
            cbxEstado.TabIndex = 2;
            // 
            // cbxCiudad
            // 
            cbxCiudad.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(426, 49);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(121, 31);
            cbxCiudad.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.DimGray;
            txtBuscar.Location = new Point(12, 49);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(323, 31);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.Controls.Add(lblBuscarSucursal);
            pnlBusqueda.Controls.Add(pbxBuscarSucursal);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(label8);
            pnlBusqueda.Controls.Add(cbxCiudad);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(label7);
            pnlBusqueda.Controls.Add(cbxEstado);
            pnlBusqueda.Location = new Point(24, 27);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1024, 103);
            pnlBusqueda.TabIndex = 5;
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.BackColor = Color.White;
            lblBuscarSucursal.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.FromArgb(0, 176, 80);
            lblBuscarSucursal.Location = new Point(52, 3);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(143, 26);
            lblBuscarSucursal.TabIndex = 27;
            lblBuscarSucursal.Text = "Buscar sucursal";
            // 
            // frmBuscarSucursal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1200, 650);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlBuscarSucursal);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmBuscarSucursal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarSucursal";
            Load += frmBuscarSucursal_Load;
            pnlBuscarSucursal.ResumeLayout(false);
            pnlBuscarSucursal.PerformLayout();
            pnlSucursalesRemodelacion.ResumeLayout(false);
            pnlSucursalesRemodelacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlSucursalesInactivas.ResumeLayout(false);
            pnlSucursalesInactivas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSucursalesActivas.ResumeLayout(false);
            pnlSucursalesActivas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTotalSucursales.ResumeLayout(false);
            pnlTotalSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label1;
        private Label label3;
        private Panel pnlBuscarSucursal;
        private Panel pnlSucursalesRemodelacion;
        private PictureBox pictureBox4;
        private Label lblSucursalesRemodelacion;
        private Label lblSucRemod;
        private Panel pnlSucursalesInactivas;
        private PictureBox pictureBox3;
        private Label lblSucursalesInactivas;
        private Label lblSucInac;
        private Panel pnlSucursalesActivas;
        private PictureBox pictureBox2;
        private Label lblSucursalesActivas;
        private Label lblSucAct;
        private Panel pnlTotalSucursales;
        private Label lblTotalSucursales;
        private Label lbltotalsuc;
        private PictureBox pictureBox1;
        private PictureBox pbxBuscarSucursal;
        private DataGridView dgvSucursales;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clNombreSucursal;
        private DataGridViewTextBoxColumn clCiudad;
        private DataGridViewTextBoxColumn clDireccion;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewButtonColumn clEditar;
        private DataGridViewButtonColumn clUbicacion;
        private DataGridViewButtonColumn clVer;
        private Button btnBuscar;
        private Label label7;
        private Label label8;
        private ComboBox cbxEstado;
        private ComboBox cbxCiudad;
        private TextBox txtBuscar;
        private Panel pnlBusqueda;
        private Label lblBuscarSucursal;
        private Label lblSucReg;
    }
}