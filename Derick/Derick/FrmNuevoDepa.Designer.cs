namespace Derick
{
    partial class FrmNuevoDepa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoDepa));
            pbxBuscarSucursal = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblInformacion = new Label();
            lblSalirV = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblDepartamento = new Label();
            txtDescripcion = new TextBox();
            lblEstado = new Label();
            cbxEstado = new ComboBox();
            lblEmpleado = new Label();
            cbxEmpleado = new ComboBox();
            txtDepartamento = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = (Image)resources.GetObject("pbxBuscarSucursal.BackgroundImage");
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(3, 3);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(101, 99);
            pbxBuscarSucursal.TabIndex = 25;
            pbxBuscarSucursal.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pbxBuscarSucursal);
            flowLayoutPanel1.Controls.Add(lblInformacion);
            flowLayoutPanel1.Location = new Point(1, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(871, 90);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.White;
            lblInformacion.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = Color.FromArgb(0, 102, 255);
            lblInformacion.Location = new Point(110, 0);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(256, 33);
            lblInformacion.TabIndex = 44;
            lblInformacion.Text = "Nuevo departamento";
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(880, 9);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(31, 29);
            lblSalirV.TabIndex = 45;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.DimGray;
            lblCodigo.Location = new Point(34, 139);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(72, 22);
            lblCodigo.TabIndex = 46;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(186, 139);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(228, 27);
            txtCodigo.TabIndex = 47;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.DimGray;
            lblDepartamento.Location = new Point(34, 206);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(128, 22);
            lblDepartamento.TabIndex = 48;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(658, 139);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 49);
            txtDescripcion.TabIndex = 51;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(522, 293);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 22);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado:";
            // 
            // cbxEstado
            // 
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxEstado.Location = new Point(658, 287);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(228, 28);
            cbxEstado.TabIndex = 53;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.ForeColor = Color.DimGray;
            lblEmpleado.Location = new Point(34, 293);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(95, 22);
            lblEmpleado.TabIndex = 54;
            lblEmpleado.Text = "Empleado:";
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Location = new Point(186, 293);
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(228, 28);
            cbxEmpleado.TabIndex = 55;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(186, 206);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(228, 27);
            txtDepartamento.TabIndex = 56;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 102, 255);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(498, 436);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 53);
            btnGuardar.TabIndex = 57;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(201, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(213, 53);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(522, 156);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(109, 22);
            lblDescripcion.TabIndex = 59;
            lblDescripcion.Text = "Descripción:";
            // 
            // FrmNuevoDepa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 561);
            Controls.Add(lblDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDepartamento);
            Controls.Add(cbxEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(cbxEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDepartamento);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblSalirV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoDepa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevoDepa";
            Load += FrmNuevoDepa_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBuscarSucursal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblInformacion;
        private Label lblSalirV;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDepartamento;
        private ComboBox cmbDepartamento;
        private Label lblDes;
        private TextBox txtDescripcion;
        private Label lblEstado;
        private ComboBox cbxEstado;
        private Label lblEmpleado;
        private ComboBox cbxEmpleado;
        private TextBox txtDepartamento;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblDescripcion;
    }
}