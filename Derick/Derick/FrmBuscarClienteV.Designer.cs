namespace Derick
{
    partial class FrmBuscarClienteV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarClienteV));
            pnlNVBC = new Panel();
            btnBCC = new Button();
            btnNVBC = new Button();
            dgvNVBC = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewImageColumn();
            colEliminar = new DataGridViewImageColumn();
            picNVBC = new PictureBox();
            txtNVBuscarCliente = new TextBox();
            lblNVBuscarCliente = new Label();
            pnlNVBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVBC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVBC).BeginInit();
            SuspendLayout();
            // 
            // pnlNVBC
            // 
            pnlNVBC.BackColor = Color.White;
            pnlNVBC.BorderStyle = BorderStyle.FixedSingle;
            pnlNVBC.Controls.Add(btnBCC);
            pnlNVBC.Controls.Add(btnNVBC);
            pnlNVBC.Controls.Add(dgvNVBC);
            pnlNVBC.Controls.Add(picNVBC);
            pnlNVBC.Controls.Add(txtNVBuscarCliente);
            pnlNVBC.Controls.Add(lblNVBuscarCliente);
            pnlNVBC.Location = new Point(12, 12);
            pnlNVBC.Name = "pnlNVBC";
            pnlNVBC.Size = new Size(610, 522);
            pnlNVBC.TabIndex = 5;
            // 
            // btnBCC
            // 
            btnBCC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBCC.ForeColor = Color.Black;
            btnBCC.Location = new Point(511, 8);
            btnBCC.Name = "btnBCC";
            btnBCC.Size = new Size(84, 45);
            btnBCC.TabIndex = 40;
            btnBCC.Text = "Cerrar";
            btnBCC.UseVisualStyleBackColor = false;
            // 
            // btnNVBC
            // 
            btnNVBC.BackColor = Color.FromArgb(13, 154, 64);
            btnNVBC.FlatAppearance.BorderColor = Color.FromArgb(13, 154, 64);
            btnNVBC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVBC.ForeColor = Color.White;
            btnNVBC.Location = new Point(376, 8);
            btnNVBC.Name = "btnNVBC";
            btnNVBC.Size = new Size(129, 45);
            btnNVBC.TabIndex = 39;
            btnNVBC.Text = "Nuevo cliente";
            btnNVBC.UseVisualStyleBackColor = false;
            btnNVBC.Click += btnNVBC_Click;
            // 
            // dgvNVBC
            // 
            dgvNVBC.AllowUserToAddRows = false;
            dgvNVBC.AllowUserToDeleteRows = false;
            dgvNVBC.AllowUserToResizeColumns = false;
            dgvNVBC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNVBC.BackgroundColor = Color.White;
            dgvNVBC.BorderStyle = BorderStyle.None;
            dgvNVBC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVBC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNVBC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNVBC.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTel, colEditar, colEliminar });
            dgvNVBC.Location = new Point(7, 68);
            dgvNVBC.MultiSelect = false;
            dgvNVBC.Name = "dgvNVBC";
            dgvNVBC.ReadOnly = true;
            dgvNVBC.RowHeadersVisible = false;
            dgvNVBC.RowHeadersWidth = 51;
            dgvNVBC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVBC.Size = new Size(572, 449);
            dgvNVBC.TabIndex = 38;
            dgvNVBC.CellDoubleClick += dgvNVBC_CellDoubleClick_1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTel
            // 
            colTel.HeaderText = "Teléfono";
            colTel.MinimumWidth = 6;
            colTel.Name = "colTel";
            colTel.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.HeaderText = "Editar";
            colEditar.MinimumWidth = 6;
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Resizable = DataGridViewTriState.True;
            colEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // picNVBC
            // 
            picNVBC.Image = (Image)resources.GetObject("picNVBC.Image");
            picNVBC.Location = new Point(326, 13);
            picNVBC.Name = "picNVBC";
            picNVBC.Size = new Size(34, 29);
            picNVBC.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBC.TabIndex = 37;
            picNVBC.TabStop = false;
            picNVBC.Click += picNVBC_Click;
            // 
            // txtNVBuscarCliente
            // 
            txtNVBuscarCliente.AcceptsReturn = true;
            txtNVBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNVBuscarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVBuscarCliente.ForeColor = Color.Gray;
            txtNVBuscarCliente.Location = new Point(74, 13);
            txtNVBuscarCliente.Name = "txtNVBuscarCliente";
            txtNVBuscarCliente.Size = new Size(246, 25);
            txtNVBuscarCliente.TabIndex = 36;
            txtNVBuscarCliente.TextChanged += txtNVBuscarCliente_TextChanged;
            // 
            // lblNVBuscarCliente
            // 
            lblNVBuscarCliente.AutoSize = true;
            lblNVBuscarCliente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVBuscarCliente.Location = new Point(7, 14);
            lblNVBuscarCliente.Name = "lblNVBuscarCliente";
            lblNVBuscarCliente.Size = new Size(59, 18);
            lblNVBuscarCliente.TabIndex = 9;
            lblNVBuscarCliente.Text = "Buscar ";
            // 
            // FrmBuscarClienteV
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 546);
            Controls.Add(pnlNVBC);
            Font = new Font("Microsoft Sans Serif", 10.8F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBuscarClienteV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar Cliente";
            Load += FrmBuscarClienteV_Load;
            pnlNVBC.ResumeLayout(false);
            pnlNVBC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVBC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVBC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNVBC;
        private PictureBox picNVBC;
        private TextBox txtNVBuscarCliente;
        private Label lblNVBuscarCliente;
        private DataGridView dgvNVBC;
        private Button btnNVBC;
        private Button btnBCC;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewImageColumn colEditar;
        private DataGridViewImageColumn colEliminar;
    }
}