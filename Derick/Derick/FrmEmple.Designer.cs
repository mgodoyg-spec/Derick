namespace Derick
{
    partial class FrmEmple
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
            pnlEmple = new Panel();
            pnlSucursales = new Panel();
            lblSalirV = new Label();
            pnlBuscarSucursal = new Panel();
            button1 = new Button();
            lblBuscarSucursal = new Label();
            dgvEmpleados = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clEmpleado = new DataGridViewTextBoxColumn();
            clCargo = new DataGridViewTextBoxColumn();
            clDepartamento = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clCorreo = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            clVer = new DataGridViewImageColumn();
            ClImagen = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            pnlBusqueda = new Panel();
            label1 = new Label();
            cbxSucursal = new ComboBox();
            btnNuevoEmple = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            cbxDepa = new ComboBox();
            label7 = new Label();
            cbxEstado = new ComboBox();
            pbxBuscarSucursal = new PictureBox();
            pnlEmple.SuspendLayout();
            pnlSucursales.SuspendLayout();
            pnlBuscarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            SuspendLayout();
            // 
            // pnlEmple
            // 
            pnlEmple.BackColor = Color.White;
            pnlEmple.Controls.Add(pnlSucursales);
            pnlEmple.Dock = DockStyle.Fill;
            pnlEmple.Location = new Point(0, 0);
            pnlEmple.Margin = new Padding(3, 2, 3, 2);
            pnlEmple.Name = "pnlEmple";
            pnlEmple.Size = new Size(1186, 700);
            pnlEmple.TabIndex = 0;
            // 
            // pnlSucursales
            // 
            pnlSucursales.BackColor = Color.FromArgb(244, 246, 249);
            pnlSucursales.Controls.Add(lblSalirV);
            pnlSucursales.Controls.Add(pnlBuscarSucursal);
            pnlSucursales.Dock = DockStyle.Fill;
            pnlSucursales.Location = new Point(0, 0);
            pnlSucursales.Name = "pnlSucursales";
            pnlSucursales.Size = new Size(1186, 700);
            pnlSucursales.TabIndex = 10;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1138, 9);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pnlBuscarSucursal
            // 
            pnlBuscarSucursal.Anchor = AnchorStyles.Left;
            pnlBuscarSucursal.BackColor = Color.White;
            pnlBuscarSucursal.Controls.Add(button1);
            pnlBuscarSucursal.Controls.Add(lblBuscarSucursal);
            pnlBuscarSucursal.Controls.Add(dgvEmpleados);
            pnlBuscarSucursal.Controls.Add(pictureBox1);
            pnlBuscarSucursal.Controls.Add(pnlBusqueda);
            pnlBuscarSucursal.Controls.Add(pbxBuscarSucursal);
            pnlBuscarSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBuscarSucursal.Location = new Point(13, 37);
            pnlBuscarSucursal.Margin = new Padding(4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1186, 700);
            pnlBuscarSucursal.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 59, 186);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 4;
            button1.Location = new Point(903, 5);
            button1.Name = "button1";
            button1.Size = new Size(145, 39);
            button1.TabIndex = 30;
            button1.Text = "Departamentos";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.BackColor = Color.White;
            lblBuscarSucursal.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.FromArgb(13, 154, 64);
            lblBuscarSucursal.Location = new Point(56, 0);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(178, 26);
            lblBuscarSucursal.TabIndex = 29;
            lblBuscarSucursal.Text = "Lista de empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clEmpleado, clCargo, clDepartamento, clTelefono, clCorreo, clEstado, clEditar, clEliminar, clVer, ClImagen });
            dgvEmpleados.Cursor = Cursors.Hand;
            dgvEmpleados.Location = new Point(7, 94);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(1129, 510);
            dgvEmpleados.TabIndex = 28;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.Name = "clCodigo";
            clCodigo.ReadOnly = true;
            // 
            // clEmpleado
            // 
            clEmpleado.HeaderText = "Empleado";
            clEmpleado.Name = "clEmpleado";
            clEmpleado.ReadOnly = true;
            // 
            // clCargo
            // 
            clCargo.HeaderText = "Cargo";
            clCargo.Name = "clCargo";
            clCargo.ReadOnly = true;
            // 
            // clDepartamento
            // 
            clDepartamento.HeaderText = "Departamento";
            clDepartamento.Name = "clDepartamento";
            clDepartamento.ReadOnly = true;
            // 
            // clTelefono
            // 
            clTelefono.HeaderText = "Teléfono";
            clTelefono.Name = "clTelefono";
            clTelefono.ReadOnly = true;
            // 
            // clCorreo
            // 
            clCorreo.HeaderText = "Correo";
            clCorreo.Name = "clCorreo";
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
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.Name = "clEliminar";
            clEliminar.Resizable = DataGridViewTriState.True;
            clEliminar.ToolTipText = "📍";
            // 
            // clVer
            // 
            clVer.HeaderText = "Ver más";
            clVer.Name = "clVer";
            clVer.Resizable = DataGridViewTriState.True;
            // 
            // ClImagen
            // 
            ClImagen.HeaderText = "Imagen";
            ClImagen.Name = "ClImagen";
            ClImagen.Resizable = DataGridViewTriState.True;
            ClImagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(56, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 14);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(label1);
            pnlBusqueda.Controls.Add(cbxSucursal);
            pnlBusqueda.Controls.Add(btnNuevoEmple);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(label8);
            pnlBusqueda.Controls.Add(cbxDepa);
            pnlBusqueda.Controls.Add(label7);
            pnlBusqueda.Controls.Add(cbxEstado);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(487, 13);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 25;
            label1.Text = "Sucursal:";
            // 
            // cbxSucursal
            // 
            cbxSucursal.Font = new Font("Calibri", 11F);
            cbxSucursal.FormattingEnabled = true;
            cbxSucursal.Items.AddRange(new object[] { "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cbxSucursal.Location = new Point(563, 8);
            cbxSucursal.Name = "cbxSucursal";
            cbxSucursal.Size = new Size(121, 26);
            cbxSucursal.TabIndex = 24;
            cbxSucursal.SelectedIndexChanged += cbxSucursal_SelectedIndexChanged;
            // 
            // btnNuevoEmple
            // 
            btnNuevoEmple.BackColor = Color.FromArgb(13, 154, 64);
            btnNuevoEmple.Cursor = Cursors.Hand;
            btnNuevoEmple.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNuevoEmple.ForeColor = Color.White;
            btnNuevoEmple.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEmple.ImageIndex = 5;
            btnNuevoEmple.Location = new Point(914, 6);
            btnNuevoEmple.Name = "btnNuevoEmple";
            btnNuevoEmple.Size = new Size(135, 33);
            btnNuevoEmple.TabIndex = 23;
            btnNuevoEmple.Text = "Nuevo empleado";
            btnNuevoEmple.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoEmple.UseVisualStyleBackColor = false;
            btnNuevoEmple.Click += btnNuevoEmple_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.ImageIndex = 2;
            btnLimpiar.Location = new Point(1055, 7);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(71, 28);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Calibri", 12F);
            txtBuscar.ForeColor = Color.DimGray;
            txtBuscar.Location = new Point(4, 8);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(230, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(241, 12);
            label8.Name = "label8";
            label8.Size = new Size(113, 19);
            label8.TabIndex = 4;
            label8.Text = "Departamento:";
            // 
            // cbxDepa
            // 
            cbxDepa.Font = new Font("Calibri", 11F);
            cbxDepa.FormattingEnabled = true;
            cbxDepa.Items.AddRange(new object[] { "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cbxDepa.Location = new Point(360, 8);
            cbxDepa.Name = "cbxDepa";
            cbxDepa.Size = new Size(121, 26);
            cbxDepa.TabIndex = 1;
            cbxDepa.SelectedIndexChanged += cbxDepa_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(691, 13);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 20;
            label7.Text = "Estado:";
            // 
            // cbxEstado
            // 
            cbxEstado.Font = new Font("Calibri", 11F);
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxEstado.Location = new Point(772, 9);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 26);
            cbxEstado.TabIndex = 2;
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged;
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = Properties.Resources.icoPrinBusqueda3;
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(7, 0);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(43, 39);
            pbxBuscarSucursal.TabIndex = 24;
            pbxBuscarSucursal.TabStop = false;
            // 
            // FrmEmple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 700);
            Controls.Add(pnlEmple);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEmple";
            Text = "FrmEmple";
            Load += FrmEmple_Load;
            pnlEmple.ResumeLayout(false);
            pnlSucursales.ResumeLayout(false);
            pnlSucursales.PerformLayout();
            pnlBuscarSucursal.ResumeLayout(false);
            pnlBuscarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEmple;
        private Panel pnlSucursales;
        private Label lblSalirV;
        private Panel pnlBuscarSucursal;
        private PictureBox pictureBox1;
        private Panel pnlBusqueda;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label8;
        private ComboBox cbxDepa;
        private Label label7;
        private ComboBox cbxEstado;
        private PictureBox pbxBuscarSucursal;
        private DataGridView dgvEmpleados;
        private Label lblBuscarSucursal;
        private Button btnNuevoEmple;
        private Button button1;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clEmpleado;
        private DataGridViewTextBoxColumn clCargo;
        private DataGridViewTextBoxColumn clDepartamento;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clCorreo;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
        private DataGridViewImageColumn clVer;
        private DataGridViewImageColumn ClImagen;
        private Label label1;
        private ComboBox cbxSucursal;
    }
}