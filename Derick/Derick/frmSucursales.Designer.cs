namespace Derick
{
    partial class frmSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucursales));
            pnlSucursales = new Panel();
            lblSalirV = new Label();
            pnlBuscarSucursal = new Panel();
            pictureBox1 = new PictureBox();
            btnRegistrarSucursal = new Button();
            imlIcons = new ImageList(components);
            lblBuscarSucursal = new Label();
            pnlBusqueda = new Panel();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            cbxCiudad = new ComboBox();
            btnBuscar = new Button();
            label7 = new Label();
            cbxEstado = new ComboBox();
            pbxBuscarSucursal = new PictureBox();
            dgvSucursales = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clFechaRegistro = new DataGridViewTextBoxColumn();
            clNombreSucursal = new DataGridViewTextBoxColumn();
            clCiudad = new DataGridViewTextBoxColumn();
            clDireccion = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clEncargado = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clUbicacion = new DataGridViewImageColumn();
            clVer = new DataGridViewImageColumn();
            pnlSucursales.SuspendLayout();
            pnlBuscarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            SuspendLayout();
            // 
            // pnlSucursales
            // 
            pnlSucursales.Controls.Add(lblSalirV);
            pnlSucursales.Controls.Add(pnlBuscarSucursal);
            pnlSucursales.Dock = DockStyle.Fill;
            pnlSucursales.Location = new Point(0, 0);
            pnlSucursales.Name = "pnlSucursales";
            pnlSucursales.Size = new Size(1186, 651);
            pnlSucursales.TabIndex = 9;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1149, 0);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 30;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click_1;
            // 
            // pnlBuscarSucursal
            // 
            pnlBuscarSucursal.Anchor = AnchorStyles.Left;
            pnlBuscarSucursal.BackColor = Color.White;
            pnlBuscarSucursal.Controls.Add(pictureBox1);
            pnlBuscarSucursal.Controls.Add(btnRegistrarSucursal);
            pnlBuscarSucursal.Controls.Add(lblBuscarSucursal);
            pnlBuscarSucursal.Controls.Add(pnlBusqueda);
            pnlBuscarSucursal.Controls.Add(pbxBuscarSucursal);
            pnlBuscarSucursal.Controls.Add(dgvSucursales);
            pnlBuscarSucursal.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBuscarSucursal.Location = new Point(13, 13);
            pnlBuscarSucursal.Margin = new Padding(4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1150, 630);
            pnlBuscarSucursal.TabIndex = 7;
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
            // btnRegistrarSucursal
            // 
            btnRegistrarSucursal.BackColor = Color.FromArgb(4, 59, 186);
            btnRegistrarSucursal.Cursor = Cursors.Hand;
            btnRegistrarSucursal.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnRegistrarSucursal.ForeColor = Color.White;
            btnRegistrarSucursal.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarSucursal.ImageIndex = 4;
            btnRegistrarSucursal.ImageList = imlIcons;
            btnRegistrarSucursal.Location = new Point(913, 3);
            btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            btnRegistrarSucursal.Size = new Size(223, 39);
            btnRegistrarSucursal.TabIndex = 16;
            btnRegistrarSucursal.Text = "Registrar nueva sucursal";
            btnRegistrarSucursal.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarSucursal.UseVisualStyleBackColor = false;
            btnRegistrarSucursal.Click += btnRegistrarSucursal_Click;
            // 
            // imlIcons
            // 
            imlIcons.ColorDepth = ColorDepth.Depth32Bit;
            imlIcons.ImageStream = (ImageListStreamer)resources.GetObject("imlIcons.ImageStream");
            imlIcons.TransparentColor = Color.Transparent;
            imlIcons.Images.SetKeyName(0, "Captura de pantalla 2026-08-07 015842.png");
            imlIcons.Images.SetKeyName(1, "Captura de pantalla 2026-08-07 015847.png");
            imlIcons.Images.SetKeyName(2, "Captura de pantalla 2026-08-07 015908.png");
            imlIcons.Images.SetKeyName(3, "Captura de pantalla 2026-08-07 015915.png");
            imlIcons.Images.SetKeyName(4, "Captura de pantalla 2026-08-07 015820.png");
            imlIcons.Images.SetKeyName(5, "Captura de pantalla 2026-08-07 013929.png");
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.BackColor = Color.White;
            lblBuscarSucursal.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.FromArgb(13, 154, 64);
            lblBuscarSucursal.Location = new Point(56, 0);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(143, 26);
            lblBuscarSucursal.TabIndex = 27;
            lblBuscarSucursal.Text = "Buscar sucursal";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(label8);
            pnlBusqueda.Controls.Add(cbxCiudad);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(label7);
            pnlBusqueda.Controls.Add(cbxEstado);
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
            btnLimpiar.ImageIndex = 2;
            btnLimpiar.ImageList = imlIcons;
            btnLimpiar.Location = new Point(889, 7);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 28);
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
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(330, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(366, 12);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 4;
            label8.Text = "Ciudad:";
            // 
            // cbxCiudad
            // 
            cbxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCiudad.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(432, 6);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(121, 31);
            cbxCiudad.TabIndex = 1;
            cbxCiudad.SelectedIndexChanged += cbxCiudad_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(13, 154, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.ImageIndex = 5;
            btnBuscar.ImageList = imlIcons;
            btnBuscar.Location = new Point(771, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 33);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(570, 12);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 20;
            label7.Text = "Estado:";
            // 
            // cbxEstado
            // 
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(635, 4);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 31);
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
            // dgvSucursales
            // 
            dgvSucursales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clFechaRegistro, clNombreSucursal, clCiudad, clDireccion, clTelefono, clEncargado, clEstado, clEditar, clUbicacion, clVer });
            dgvSucursales.Cursor = Cursors.Hand;
            dgvSucursales.Location = new Point(7, 94);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.Size = new Size(1126, 510);
            dgvSucursales.TabIndex = 22;
            dgvSucursales.CellClick += dgvSucursales_CellClick;
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Código";
            clCodigo.Name = "clCodigo";
            clCodigo.ReadOnly = true;
            // 
            // clFechaRegistro
            // 
            clFechaRegistro.HeaderText = "Fecha de registro";
            clFechaRegistro.Name = "clFechaRegistro";
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
            // clEncargado
            // 
            clEncargado.HeaderText = "Encargado";
            clEncargado.Name = "clEncargado";
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
            clUbicacion.Resizable = DataGridViewTriState.True;
            clUbicacion.ToolTipText = "📍";
            // 
            // clVer
            // 
            clVer.HeaderText = "Ver más";
            clVer.Name = "clVer";
            clVer.Resizable = DataGridViewTriState.True;
            // 
            // frmSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1186, 651);
            Controls.Add(pnlSucursales);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSucursales";
            Load += frmSucursales_Load;
            pnlSucursales.ResumeLayout(false);
            pnlSucursales.PerformLayout();
            pnlBuscarSucursal.ResumeLayout(false);
            pnlBuscarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSucursales;
        private Panel pnlBusqueda;
        private Label lblBuscarSucursal;
        private PictureBox pbxBuscarSucursal;
        private TextBox txtBuscar;
        private Label label8;
        private ComboBox cbxCiudad;
        private Button btnBuscar;
        private Label label7;
        private ComboBox cbxEstado;
        private Panel pnlBuscarSucursal;
        private DataGridView dgvSucursales;
        private Button btnRegistrarSucursal;
        private Button btnLimpiar;
        private PictureBox pictureBox1;
        private ImageList imlIcons;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clFechaRegistro;
        private DataGridViewTextBoxColumn clNombreSucursal;
        private DataGridViewTextBoxColumn clCiudad;
        private DataGridViewTextBoxColumn clDireccion;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clEncargado;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clUbicacion;
        private DataGridViewImageColumn clVer;
        private Label lblSalirV;
    }
}