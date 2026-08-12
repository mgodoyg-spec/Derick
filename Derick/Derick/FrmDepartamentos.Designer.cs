namespace Derick
{
    partial class FrmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentos));
            pnlDepa = new Panel();
            lblSalirV = new Label();
            pnlDepar = new Panel();
            dgvDepa = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clDepartamento = new DataGridViewTextBoxColumn();
            clDescripcion = new DataGridViewTextBoxColumn();
            clEmpleados = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            btnNuevoDepa = new Button();
            imlIcons = new ImageList(components);
            lblBuscarSucursal = new Label();
            pnlBusqueda = new Panel();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            pbxBuscarSucursal = new PictureBox();
            pnlDepa.SuspendLayout();
            pnlDepar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            SuspendLayout();
            // 
            // pnlDepa
            // 
            pnlDepa.Controls.Add(lblSalirV);
            pnlDepa.Controls.Add(pnlDepar);
            pnlDepa.Dock = DockStyle.Fill;
            pnlDepa.Location = new Point(0, 0);
            pnlDepa.Name = "pnlDepa";
            pnlDepa.Size = new Size(1168, 604);
            pnlDepa.TabIndex = 10;
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
            lblSalirV.Size = new Size(31, 29);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pnlDepar
            // 
            pnlDepar.Anchor = AnchorStyles.Left;
            pnlDepar.BackColor = Color.White;
            pnlDepar.Controls.Add(dgvDepa);
            pnlDepar.Controls.Add(pictureBox1);
            pnlDepar.Controls.Add(btnNuevoDepa);
            pnlDepar.Controls.Add(lblBuscarSucursal);
            pnlDepar.Controls.Add(pnlBusqueda);
            pnlDepar.Controls.Add(pbxBuscarSucursal);
            pnlDepar.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDepar.Location = new Point(4, 4);
            pnlDepar.Margin = new Padding(4);
            pnlDepar.Name = "pnlDepar";
            pnlDepar.Size = new Size(1150, 630);
            pnlDepar.TabIndex = 7;
            // 
            // dgvDepa
            // 
            dgvDepa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepa.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clDepartamento, clDescripcion, clEmpleados, clEstado, clEditar, clEliminar });
            dgvDepa.Cursor = Cursors.Hand;
            dgvDepa.Location = new Point(10, 88);
            dgvDepa.Name = "dgvDepa";
            dgvDepa.RowHeadersWidth = 51;
            dgvDepa.Size = new Size(1126, 510);
            dgvDepa.TabIndex = 28;
            dgvDepa.CellContentClick += dgvDepa_CellContentClick;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.MinimumWidth = 6;
            clCodigo.Name = "clCodigo";
            clCodigo.ReadOnly = true;
            clCodigo.Width = 125;
            // 
            // clDepartamento
            // 
            clDepartamento.HeaderText = "Departamento";
            clDepartamento.MinimumWidth = 6;
            clDepartamento.Name = "clDepartamento";
            clDepartamento.Width = 125;
            // 
            // clDescripcion
            // 
            clDescripcion.HeaderText = "Descripción";
            clDescripcion.MinimumWidth = 6;
            clDescripcion.Name = "clDescripcion";
            clDescripcion.ReadOnly = true;
            clDescripcion.Width = 125;
            // 
            // clEmpleados
            // 
            clEmpleados.HeaderText = "Empleados";
            clEmpleados.MinimumWidth = 6;
            clEmpleados.Name = "clEmpleados";
            clEmpleados.ReadOnly = true;
            clEmpleados.Width = 125;
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
            clEliminar.Width = 125;
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
            // btnNuevoDepa
            // 
            btnNuevoDepa.BackColor = Color.FromArgb(4, 59, 186);
            btnNuevoDepa.Cursor = Cursors.Hand;
            btnNuevoDepa.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnNuevoDepa.ForeColor = Color.White;
            btnNuevoDepa.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoDepa.ImageIndex = 1;
            btnNuevoDepa.ImageList = imlIcons;
            btnNuevoDepa.Location = new Point(849, -4);
            btnNuevoDepa.Name = "btnNuevoDepa";
            btnNuevoDepa.Size = new Size(262, 48);
            btnNuevoDepa.TabIndex = 16;
            btnNuevoDepa.Text = "Nuevo Departamento";
            btnNuevoDepa.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoDepa.UseVisualStyleBackColor = false;
            btnNuevoDepa.Click += btnNuevoDepa_Click;
            // 
            // imlIcons
            // 
            imlIcons.ColorDepth = ColorDepth.Depth32Bit;
            imlIcons.ImageStream = (ImageListStreamer)resources.GetObject("imlIcons.ImageStream");
            imlIcons.TransparentColor = Color.Transparent;
            imlIcons.Images.SetKeyName(0, "Gemini_Generated_Image_c85q6c85q6c85q6c.png");
            imlIcons.Images.SetKeyName(1, "1d25cfbc-39f5-4edf-8684-e760e10ab95c.jpg");
            imlIcons.Images.SetKeyName(2, "7bb243ea-43e2-408e-8686-3e555c8b6433.jpg");
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.BackColor = Color.White;
            lblBuscarSucursal.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.FromArgb(13, 154, 64);
            lblBuscarSucursal.Location = new Point(56, 0);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(190, 33);
            lblBuscarSucursal.TabIndex = 27;
            lblBuscarSucursal.Text = "Departamentos";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.ImageIndex = 0;
            btnLimpiar.ImageList = imlIcons;
            btnLimpiar.Location = new Point(970, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 40);
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
            txtBuscar.Location = new Point(29, 8);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(330, 32);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = (Image)resources.GetObject("pbxBuscarSucursal.BackgroundImage");
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(7, 0);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(43, 39);
            pbxBuscarSucursal.TabIndex = 24;
            pbxBuscarSucursal.TabStop = false;
            // 
            // FrmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 604);
            Controls.Add(pnlDepa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDepartamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDepartamentos";
            Load += FrmDepartamentos_Load;
            pnlDepa.ResumeLayout(false);
            pnlDepa.PerformLayout();
            pnlDepar.ResumeLayout(false);
            pnlDepar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDepa;
        private Label lblSalirV;
        private Panel pnlDepar;
        private PictureBox pictureBox1;
        private Button btnNuevoDepa;
        private Label lblBuscarSucursal;
        private Panel pnlBusqueda;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private PictureBox pbxBuscarSucursal;
        private DataGridView dgvDepa;
        private ImageList imlIcons;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clDepartamento;
        private DataGridViewTextBoxColumn clDescripcion;
        private DataGridViewTextBoxColumn clEmpleados;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
    }
}