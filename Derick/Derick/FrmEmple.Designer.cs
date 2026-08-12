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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmple));
            pnlEmple = new Panel();
            pnlSucursales = new Panel();
            lblSalirV = new Label();
            pnlBuscarSucursal = new Panel();
            btnDepa = new Button();
            imlIcons = new ImageList(components);
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
            pnlEmple.Size = new Size(1186, 591);
            pnlEmple.TabIndex = 0;
            // 
            // pnlSucursales
            // 
            pnlSucursales.BackColor = Color.FromArgb(244, 246, 249);
            pnlSucursales.Controls.Add(pnlBuscarSucursal);
            pnlSucursales.Dock = DockStyle.Fill;
            pnlSucursales.Location = new Point(0, 0);
            pnlSucursales.Name = "pnlSucursales";
            pnlSucursales.Size = new Size(1186, 591);
            pnlSucursales.TabIndex = 10;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1070, 20);
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
            pnlBuscarSucursal.Controls.Add(lblSalirV);
            pnlBuscarSucursal.Controls.Add(btnDepa);
            pnlBuscarSucursal.Controls.Add(lblBuscarSucursal);
            pnlBuscarSucursal.Controls.Add(dgvEmpleados);
            pnlBuscarSucursal.Controls.Add(pictureBox1);
            pnlBuscarSucursal.Controls.Add(pnlBusqueda);
            pnlBuscarSucursal.Controls.Add(pbxBuscarSucursal);
            pnlBuscarSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBuscarSucursal.Location = new Point(13, -18);
            pnlBuscarSucursal.Margin = new Padding(4, 4, 4, 4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1235, 700);
            pnlBuscarSucursal.TabIndex = 7;
            // 
            // btnDepa
            // 
            btnDepa.BackColor = Color.FromArgb(4, 59, 186);
            btnDepa.Cursor = Cursors.Hand;
            btnDepa.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnDepa.ForeColor = Color.White;
            btnDepa.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepa.ImageIndex = 0;
            btnDepa.ImageList = imlIcons;
            btnDepa.Location = new Point(894, 4);
            btnDepa.Margin = new Padding(3, 4, 3, 4);
            btnDepa.Name = "btnDepa";
            btnDepa.Size = new Size(192, 52);
            btnDepa.TabIndex = 30;
            btnDepa.Text = "Departamentos";
            btnDepa.TextAlign = ContentAlignment.MiddleRight;
            btnDepa.UseVisualStyleBackColor = false;
            btnDepa.Click += btnDepa_Click_1;
            // 
            // imlIcons
            // 
            imlIcons.ColorDepth = ColorDepth.Depth32Bit;
            imlIcons.ImageStream = (ImageListStreamer)resources.GetObject("imlIcons.ImageStream");
            imlIcons.TransparentColor = Color.Transparent;
            imlIcons.Images.SetKeyName(0, "1d25cfbc-39f5-4edf-8684-e760e10ab95c.jpg");
            imlIcons.Images.SetKeyName(1, "Gemini_Generated_Image_c85q6c85q6c85q6c.png");
            imlIcons.Images.SetKeyName(2, "d53aae87-a2f6-4f2f-ba54-5b80ccce6a7d.jpg");
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
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1064, 510);
            dgvEmpleados.TabIndex = 28;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.MinimumWidth = 6;
            clCodigo.Name = "clCodigo";
            clCodigo.ReadOnly = true;
            clCodigo.Width = 125;
            // 
            // clEmpleado
            // 
            clEmpleado.HeaderText = "Empleado";
            clEmpleado.MinimumWidth = 6;
            clEmpleado.Name = "clEmpleado";
            clEmpleado.ReadOnly = true;
            clEmpleado.Width = 125;
            // 
            // clCargo
            // 
            clCargo.HeaderText = "Cargo";
            clCargo.MinimumWidth = 6;
            clCargo.Name = "clCargo";
            clCargo.ReadOnly = true;
            clCargo.Width = 125;
            // 
            // clDepartamento
            // 
            clDepartamento.HeaderText = "Departamento";
            clDepartamento.MinimumWidth = 6;
            clDepartamento.Name = "clDepartamento";
            clDepartamento.ReadOnly = true;
            clDepartamento.Width = 125;
            // 
            // clTelefono
            // 
            clTelefono.HeaderText = "Teléfono";
            clTelefono.MinimumWidth = 6;
            clTelefono.Name = "clTelefono";
            clTelefono.ReadOnly = true;
            clTelefono.Width = 125;
            // 
            // clCorreo
            // 
            clCorreo.HeaderText = "Correo";
            clCorreo.MinimumWidth = 6;
            clCorreo.Name = "clCorreo";
            clCorreo.Width = 125;
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            clEstado.ReadOnly = true;
            clEstado.Width = 125;
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 6;
            clEditar.Name = "clEditar";
            clEditar.ReadOnly = true;
            clEditar.Resizable = DataGridViewTriState.True;
            clEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            clEditar.Width = 125;
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            clEliminar.Resizable = DataGridViewTriState.True;
            clEliminar.ToolTipText = "📍";
            clEliminar.Width = 125;
            // 
            // clVer
            // 
            clVer.HeaderText = "Ver más";
            clVer.MinimumWidth = 6;
            clVer.Name = "clVer";
            clVer.Resizable = DataGridViewTriState.True;
            clVer.Width = 125;
            // 
            // ClImagen
            // 
            ClImagen.HeaderText = "Imagen";
            ClImagen.MinimumWidth = 6;
            ClImagen.Name = "ClImagen";
            ClImagen.Resizable = DataGridViewTriState.True;
            ClImagen.SortMode = DataGridViewColumnSortMode.Automatic;
            ClImagen.Width = 125;
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
            pnlBusqueda.Size = new Size(1078, 43);
            pnlBusqueda.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(370, 10);
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
            cbxSucursal.Location = new Point(441, 8);
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
            btnNuevoEmple.ImageIndex = 2;
            btnNuevoEmple.ImageList = imlIcons;
            btnNuevoEmple.Location = new Point(865, -1);
            btnNuevoEmple.Margin = new Padding(3, 4, 3, 4);
            btnNuevoEmple.Name = "btnNuevoEmple";
            btnNuevoEmple.Size = new Size(111, 44);
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
            btnLimpiar.ImageIndex = 1;
            btnLimpiar.ImageList = imlIcons;
            btnLimpiar.Location = new Point(982, 2);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 37);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Calibri", 12F);
            txtBuscar.ForeColor = Color.DimGray;
            txtBuscar.Location = new Point(4, 6);
            txtBuscar.Margin = new Padding(4, 4, 4, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(115, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(117, 10);
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
            cbxDepa.Location = new Point(244, 8);
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
            label7.Location = new Point(567, 10);
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
            cbxEstado.Location = new Point(704, 7);
            cbxEstado.Margin = new Padding(3, 4, 3, 4);
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
            ClientSize = new Size(1186, 591);
            Controls.Add(pnlEmple);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEmple";
            Text = "FrmEmple";
            Load += FrmEmple_Load;
            pnlEmple.ResumeLayout(false);
            pnlSucursales.ResumeLayout(false);
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
        private Button btnDepa;
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
        private ImageList imlIcons;
    }
}