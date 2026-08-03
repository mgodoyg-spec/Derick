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
            pnlTituloBuscarSucursales = new Panel();
            lblDescripcionSuc = new Label();
            pbxIconoDerick = new PictureBox();
            lblBuscarSucursal = new Label();
            pnlBuscarSucursal = new Panel();
            pbxBuscarSucursal = new PictureBox();
            pnlInformacion = new Panel();
            btnEditar = new Button();
            lblCodigo = new Label();
            lblEncargadoSucursal = new Label();
            lblCorreo = new Label();
            lbltelefono = new Label();
            lblDireccion = new Label();
            lblCiudadSucursal = new Label();
            lblNombreSucursal = new Label();
            lbEstadoSucursal = new Label();
            lblInformacion = new Label();
            dgvSucursales = new DataGridView();
            clCodigo = new DataGridViewTextBoxColumn();
            clNombreSucursal = new DataGridViewTextBoxColumn();
            clCiudad = new DataGridViewTextBoxColumn();
            clDireccion = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clAcciones = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            lblestado = new Label();
            lblCiudad = new Label();
            cbxEstado = new ComboBox();
            cbxCiudad = new ComboBox();
            txtBuscar = new TextBox();
            pnlTituloBuscarSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).BeginInit();
            pnlBuscarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            SuspendLayout();
            // 
            // pnlTituloBuscarSucursales
            // 
            pnlTituloBuscarSucursales.BackColor = Color.Black;
            pnlTituloBuscarSucursales.Controls.Add(lblDescripcionSuc);
            pnlTituloBuscarSucursales.Controls.Add(pbxIconoDerick);
            pnlTituloBuscarSucursales.Controls.Add(lblBuscarSucursal);
            pnlTituloBuscarSucursales.Location = new Point(306, 13);
            pnlTituloBuscarSucursales.Margin = new Padding(4);
            pnlTituloBuscarSucursales.Name = "pnlTituloBuscarSucursales";
            pnlTituloBuscarSucursales.Size = new Size(626, 100);
            pnlTituloBuscarSucursales.TabIndex = 1;
            // 
            // lblDescripcionSuc
            // 
            lblDescripcionSuc.AutoSize = true;
            lblDescripcionSuc.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcionSuc.ForeColor = Color.White;
            lblDescripcionSuc.Location = new Point(158, 61);
            lblDescripcionSuc.Margin = new Padding(4, 0, 4, 0);
            lblDescripcionSuc.Name = "lblDescripcionSuc";
            lblDescripcionSuc.Size = new Size(349, 19);
            lblDescripcionSuc.TabIndex = 2;
            lblDescripcionSuc.Text = "Consulta la información de las sucursales registradas";
            // 
            // pbxIconoDerick
            // 
            pbxIconoDerick.BackgroundImage = Properties.Resources.DerickRecortado;
            pbxIconoDerick.BackgroundImageLayout = ImageLayout.Zoom;
            pbxIconoDerick.Location = new Point(15, 4);
            pbxIconoDerick.Margin = new Padding(4);
            pbxIconoDerick.Name = "pbxIconoDerick";
            pbxIconoDerick.Size = new Size(105, 89);
            pbxIconoDerick.TabIndex = 1;
            pbxIconoDerick.TabStop = false;
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.WhiteSmoke;
            lblBuscarSucursal.Location = new Point(197, 15);
            lblBuscarSucursal.Margin = new Padding(4, 0, 4, 0);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(261, 37);
            lblBuscarSucursal.TabIndex = 0;
            lblBuscarSucursal.Text = "Buscar sucursal";
            // 
            // pnlBuscarSucursal
            // 
            pnlBuscarSucursal.BackColor = Color.White;
            pnlBuscarSucursal.Controls.Add(pbxBuscarSucursal);
            pnlBuscarSucursal.Controls.Add(pnlInformacion);
            pnlBuscarSucursal.Controls.Add(dgvSucursales);
            pnlBuscarSucursal.Controls.Add(btnBuscar);
            pnlBuscarSucursal.Controls.Add(lblestado);
            pnlBuscarSucursal.Controls.Add(lblCiudad);
            pnlBuscarSucursal.Controls.Add(cbxEstado);
            pnlBuscarSucursal.Controls.Add(cbxCiudad);
            pnlBuscarSucursal.Controls.Add(txtBuscar);
            pnlBuscarSucursal.Location = new Point(62, 139);
            pnlBuscarSucursal.Margin = new Padding(4);
            pnlBuscarSucursal.Name = "pnlBuscarSucursal";
            pnlBuscarSucursal.Size = new Size(1097, 482);
            pnlBuscarSucursal.TabIndex = 2;
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = Properties.Resources.iconoBuscar;
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(15, 13);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(39, 48);
            pbxBuscarSucursal.TabIndex = 24;
            pbxBuscarSucursal.TabStop = false;
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.FromArgb(244, 246, 249);
            pnlInformacion.Controls.Add(btnEditar);
            pnlInformacion.Controls.Add(lblCodigo);
            pnlInformacion.Controls.Add(lblEncargadoSucursal);
            pnlInformacion.Controls.Add(lblCorreo);
            pnlInformacion.Controls.Add(lbltelefono);
            pnlInformacion.Controls.Add(lblDireccion);
            pnlInformacion.Controls.Add(lblCiudadSucursal);
            pnlInformacion.Controls.Add(lblNombreSucursal);
            pnlInformacion.Controls.Add(lbEstadoSucursal);
            pnlInformacion.Controls.Add(lblInformacion);
            pnlInformacion.Location = new Point(786, 79);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(298, 377);
            pnlInformacion.TabIndex = 23;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 176, 80);
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(94, 319);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 34);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(14, 48);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(142, 20);
            lblCodigo.TabIndex = 31;
            lblCodigo.Text = "Código sucursal:";
            // 
            // lblEncargadoSucursal
            // 
            lblEncargadoSucursal.AutoSize = true;
            lblEncargadoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncargadoSucursal.Location = new Point(14, 249);
            lblEncargadoSucursal.Name = "lblEncargadoSucursal";
            lblEncargadoSucursal.Size = new Size(217, 20);
            lblEncargadoSucursal.TabIndex = 30;
            lblEncargadoSucursal.Text = "Encargado de la sucursal:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(14, 217);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(161, 20);
            lblCorreo.TabIndex = 29;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefono.Location = new Point(14, 182);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(84, 20);
            lbltelefono.TabIndex = 28;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(14, 151);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 20);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección:";
            // 
            // lblCiudadSucursal
            // 
            lblCiudadSucursal.AutoSize = true;
            lblCiudadSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudadSucursal.Location = new Point(14, 118);
            lblCiudadSucursal.Name = "lblCiudadSucursal";
            lblCiudadSucursal.Size = new Size(70, 20);
            lblCiudadSucursal.TabIndex = 26;
            lblCiudadSucursal.Text = "Ciudad:";
            // 
            // lblNombreSucursal
            // 
            lblNombreSucursal.AutoSize = true;
            lblNombreSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSucursal.Location = new Point(14, 84);
            lblNombreSucursal.Name = "lblNombreSucursal";
            lblNombreSucursal.Size = new Size(192, 20);
            lblNombreSucursal.TabIndex = 25;
            lblNombreSucursal.Text = "Nombre de la sucursal:";
            // 
            // lbEstadoSucursal
            // 
            lbEstadoSucursal.AutoSize = true;
            lbEstadoSucursal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstadoSucursal.Location = new Point(14, 282);
            lbEstadoSucursal.Name = "lbEstadoSucursal";
            lbEstadoSucursal.Size = new Size(187, 20);
            lbEstadoSucursal.TabIndex = 32;
            lbEstadoSucursal.Text = "Estado de la sucursal:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.FromArgb(0, 176, 80);
            lblInformacion.Location = new Point(47, 14);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(207, 20);
            lblInformacion.TabIndex = 24;
            lblInformacion.Text = "Información por sucursal";
            // 
            // dgvSucursales
            // 
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Columns.AddRange(new DataGridViewColumn[] { clCodigo, clNombreSucursal, clCiudad, clDireccion, clTelefono, clEstado, clAcciones });
            dgvSucursales.Location = new Point(36, 78);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.Size = new Size(737, 378);
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
            // clAcciones
            // 
            clAcciones.HeaderText = "Acciones";
            clAcciones.Name = "clAcciones";
            clAcciones.ReadOnly = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 176, 80);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(890, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 29);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblestado.Location = new Point(662, 24);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(71, 20);
            lblestado.TabIndex = 20;
            lblestado.Text = "Estado:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCiudad.Location = new Point(441, 24);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(70, 20);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(739, 21);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 28);
            cbxEstado.TabIndex = 2;
            // 
            // cbxCiudad
            // 
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(517, 21);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(121, 28);
            cbxCiudad.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(59, 23);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(364, 26);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar por nombre...";
            // 
            // frmBuscarSucursal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1200, 650);
            Controls.Add(pnlBuscarSucursal);
            Controls.Add(pnlTituloBuscarSucursales);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmBuscarSucursal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarSucursal";
            pnlTituloBuscarSucursales.ResumeLayout(false);
            pnlTituloBuscarSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIconoDerick).EndInit();
            pnlBuscarSucursal.ResumeLayout(false);
            pnlBuscarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTituloBuscarSucursales;
        private Label lblDescripcionSuc;
        private PictureBox pbxIconoDerick;
        private Label lblBuscarSucursal;
        private Panel pnlBuscarSucursal;
        private TextBox txtBuscar;
        private ComboBox cbxEstado;
        private ComboBox cbxCiudad;
        private Label lblCiudad;
        private Label lblestado;
        private Button btnBuscar;
        private DataGridView dgvSucursales;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clNombreSucursal;
        private DataGridViewTextBoxColumn clCiudad;
        private DataGridViewTextBoxColumn clDireccion;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewTextBoxColumn clAcciones;
        private Panel pnlInformacion;
        private Label lblInformacion;
        private Label label4;
        private Label lblCodigo;
        private Label lblEncargadoSucursal;
        private Label lblCorreo;
        private Label lbltelefono;
        private Label lblDireccion;
        private Label label1;
        private Label lblNombreSucursal;
        private Label label3;
        private Label lbEstadoSucursal;
        private Button btnEditar;
        private PictureBox pbxBuscarSucursal;
        private Label lblCiudadSucursal;
    }
}