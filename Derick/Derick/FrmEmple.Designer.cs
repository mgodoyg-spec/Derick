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
            pnlBuscarSucursal = new Panel();
            lblSalirV = new Label();
            btnDepa = new Button();
            imlIcons = new ImageList(components);
            pnlBuscarEmple = new Panel();
            btnNuevoEmpleado = new Button();
            lblBuscarEmple = new Label();
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
            pictureBox3 = new PictureBox();
            pnlBusqueda = new Panel();
            label1 = new Label();
            cbxSucursal = new ComboBox();
            btnBuscarEmpleado = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            cbxDepa = new ComboBox();
            label6 = new Label();
            cbxEstado = new ComboBox();
            pbxBuscaremple = new PictureBox();
            lblSalirV = new Label();
            pnlBuscarEmple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaremple).BeginInit();
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
            pnlBuscarSucursal.Margin = new Padding(4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1235, 700);
            pnlBuscarSucursal.TabIndex = 7;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1070, 18);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
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
            btnDepa.Location = new Point(829, 0);
            btnDepa.Margin = new Padding(3, 4, 3, 4);
            btnDepa.Name = "btnDepa";
            btnDepa.Size = new Size(164, 52);
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
            imlIcons.Images.SetKeyName(3, "7bb243ea-43e2-408e-8686-3e555c8b6433.jpg");
            imlIcons.Images.SetKeyName(4, "Gemini_Generated_Image_8cexku8cexku8cex.jpg");
            // 
            // pnlBuscarEmple
            // 
            pnlBuscarEmple.Anchor = AnchorStyles.Left;
            pnlBuscarEmple.BackColor = Color.White;
            pnlBuscarEmple.Controls.Add(btnNuevoEmpleado);
            pnlBuscarEmple.Controls.Add(lblBuscarEmple);
            pnlBuscarEmple.Controls.Add(dgvEmpleados);
            pnlBuscarEmple.Controls.Add(pictureBox3);
            pnlBuscarEmple.Controls.Add(pnlBusqueda);
            pnlBuscarEmple.Controls.Add(pbxBuscaremple);
            pnlBuscarEmple.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBuscarEmple.Location = new Point(5, 14);
            pnlBuscarEmple.Margin = new Padding(5);
            pnlBuscarEmple.Name = "pnlBuscarEmple";
            pnlBuscarEmple.Size = new Size(1150, 630);
            pnlBuscarEmple.TabIndex = 16;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.FromArgb(4, 59, 186);
            btnNuevoEmpleado.Cursor = Cursors.Hand;
            btnNuevoEmpleado.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNuevoEmpleado.ForeColor = Color.White;
            btnNuevoEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEmpleado.ImageIndex = 4;
            btnNuevoEmpleado.ImageList = imlIcons;
            btnNuevoEmpleado.Location = new Point(919, 5);
            btnNuevoEmpleado.Margin = new Padding(3, 5, 3, 5);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(223, 39);
            btnNuevoEmpleado.TabIndex = 30;
            btnNuevoEmpleado.Text = "Nuevo empleado";
            btnNuevoEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnDepa_Click_1;
            // 
            // lblBuscarEmple
            // 
            lblBuscarEmple.AutoSize = true;
            lblBuscarEmple.BackColor = Color.White;
            lblBuscarEmple.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarEmple.ForeColor = Color.FromArgb(13, 154, 64);
            lblBuscarEmple.Location = new Point(62, 0);
            lblBuscarEmple.Name = "lblBuscarEmple";
            lblBuscarEmple.Size = new Size(230, 33);
            lblBuscarEmple.TabIndex = 29;
            lblBuscarEmple.Text = "Lista de empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clEmpleado, clCargo, clDepartamento, clTelefono, clCorreo, clEstado, clEditar, clEliminar, clVer, ClImagen });
            dgvEmpleados.Cursor = Cursors.Hand;
            dgvEmpleados.Location = new Point(7, 98);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1142, 510);
            dgvEmpleados.TabIndex = 28;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick_1;
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
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(62, 29);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 19);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(label1);
            pnlBusqueda.Controls.Add(cbxSucursal);
            pnlBusqueda.Controls.Add(btnBuscarEmpleado);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(label4);
            pnlBusqueda.Controls.Add(cbxDepa);
            pnlBusqueda.Controls.Add(label6);
            pnlBusqueda.Controls.Add(cbxEstado);
            pnlBusqueda.Location = new Point(9, 47);
            pnlBusqueda.Margin = new Padding(3, 4, 3, 4);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1142, 43);
            pnlBusqueda.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(427, 10);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 25;
            label1.Text = "Sucursal:";
            // 
            // cbxSucursal
            // 
            cbxSucursal.Font = new Font("Calibri", 11F);
            cbxSucursal.FormattingEnabled = true;
            cbxSucursal.Items.AddRange(new object[] { "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cbxSucursal.Location = new Point(503, 6);
            cbxSucursal.Name = "cbxSucursal";
            cbxSucursal.Size = new Size(121, 30);
            cbxSucursal.TabIndex = 24;
            // 
            // btnBuscarEmpleado
            // 
            btnNuevoEmple.BackColor = Color.FromArgb(13, 154, 64);
            btnNuevoEmple.Cursor = Cursors.Hand;
            btnNuevoEmple.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNuevoEmple.ForeColor = Color.White;
            btnNuevoEmple.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEmple.ImageIndex = 2;
            btnNuevoEmple.ImageList = imlIcons;
            btnNuevoEmple.Location = new Point(822, 2);
            btnNuevoEmple.Margin = new Padding(3, 4, 3, 4);
            btnNuevoEmple.Name = "btnNuevoEmple";
            btnNuevoEmple.Size = new Size(164, 44);
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
            btnLimpiar.Location = new Point(992, 2);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 28);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Calibri", 12F);
            txtBuscar.ForeColor = Color.DimGray;
            txtBuscar.Location = new Point(4, 6);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(179, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // label4
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(190, 9);
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
            cbxDepa.Location = new Point(300, 7);
            cbxDepa.Name = "cbxDepa";
            cbxDepa.Size = new Size(121, 30);
            cbxDepa.TabIndex = 1;
            // 
            // label6
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(630, 9);
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
            cbxEstado.Location = new Point(695, 8);
            cbxEstado.Margin = new Padding(3, 4, 3, 4);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 30);
            cbxEstado.TabIndex = 2;
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged_1;
            // 
            // pbxBuscaremple
            // 
            pbxBuscaremple.BackgroundImage = Properties.Resources.icoPrinBusqueda3;
            pbxBuscaremple.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscaremple.Location = new Point(13, 0);
            pbxBuscaremple.Margin = new Padding(3, 4, 3, 4);
            pbxBuscaremple.Name = "pbxBuscaremple";
            pbxBuscaremple.Size = new Size(43, 39);
            pbxBuscaremple.TabIndex = 24;
            pbxBuscaremple.TabStop = false;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1143, 9);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(31, 29);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click_1;
            // 
            // FrmEmple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1186, 651);
            Controls.Add(lblSalirV);
            Controls.Add(pnlBuscarEmple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmple";
            Text = "FrmEmple";
            Load += FrmEmple_Load;
            pnlBuscarEmple.ResumeLayout(false);
            pnlBuscarEmple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaremple).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imlIcons;
        private Panel pnlBuscarEmple;
        private Label lblSalirV;
        private Button btnNuevoEmpleado;
        private Label lblBuscarEmple;
        private DataGridView dgvEmpleados;
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
        private PictureBox pictureBox3;
        private Panel pnlBusqueda;
        private Label label1;
        private ComboBox cbxSucursal;
        private Button btnBuscarEmpleado;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label4;
        private ComboBox cbxDepa;
        private Label label6;
        private ComboBox cbxEstado;
        private PictureBox pbxBuscaremple;
    }
}