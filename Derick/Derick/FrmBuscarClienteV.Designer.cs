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
            dgvNVPA = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            picNVBP = new PictureBox();
            txtNVBuscarProducto = new TextBox();
            lblR6 = new Label();
            lblNVBuscarCliente = new Label();
            pnlNVBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNVBP).BeginInit();
            SuspendLayout();
            // 
            // pnlNVBC
            // 
            pnlNVBC.BackColor = Color.White;
            pnlNVBC.BorderStyle = BorderStyle.FixedSingle;
            pnlNVBC.Controls.Add(btnBCC);
            pnlNVBC.Controls.Add(btnNVBC);
            pnlNVBC.Controls.Add(dgvNVPA);
            pnlNVBC.Controls.Add(picNVBP);
            pnlNVBC.Controls.Add(txtNVBuscarProducto);
            pnlNVBC.Controls.Add(lblR6);
            pnlNVBC.Controls.Add(lblNVBuscarCliente);
            pnlNVBC.Location = new Point(12, 12);
            pnlNVBC.Name = "pnlNVBC";
            pnlNVBC.Size = new Size(519, 440);
            pnlNVBC.TabIndex = 5;
            // 
            // btnBCC
            // 
            btnBCC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBCC.ForeColor = Color.Black;
            btnBCC.Location = new Point(368, 388);
            btnBCC.Name = "btnBCC";
            btnBCC.Size = new Size(145, 45);
            btnBCC.TabIndex = 40;
            btnBCC.Text = "Cerrar";
            btnBCC.UseVisualStyleBackColor = false;
            // 
            // btnNVBC
            // 
            btnNVBC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNVBC.ForeColor = Color.FromArgb(255, 136, 0);
            btnNVBC.Location = new Point(217, 388);
            btnNVBC.Name = "btnNVBC";
            btnNVBC.Size = new Size(145, 45);
            btnNVBC.TabIndex = 39;
            btnNVBC.Text = "Nuevo cliente";
            btnNVBC.UseVisualStyleBackColor = false;
            // 
            // dgvNVPA
            // 
            dgvNVPA.AllowUserToAddRows = false;
            dgvNVPA.AllowUserToDeleteRows = false;
            dgvNVPA.AllowUserToResizeColumns = false;
            dgvNVPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNVPA.BackgroundColor = Color.White;
            dgvNVPA.BorderStyle = BorderStyle.None;
            dgvNVPA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNVPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNVPA.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTel, colAcciones });
            dgvNVPA.Location = new Point(19, 62);
            dgvNVPA.MultiSelect = false;
            dgvNVPA.Name = "dgvNVPA";
            dgvNVPA.ReadOnly = true;
            dgvNVPA.RowHeadersVisible = false;
            dgvNVPA.RowHeadersWidth = 51;
            dgvNVPA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPA.Size = new Size(484, 304);
            dgvNVPA.TabIndex = 38;
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
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // picNVBP
            // 
            picNVBP.Image = (Image)resources.GetObject("picNVBP.Image");
            picNVBP.Location = new Point(469, 14);
            picNVBP.Name = "picNVBP";
            picNVBP.Size = new Size(34, 29);
            picNVBP.SizeMode = PictureBoxSizeMode.StretchImage;
            picNVBP.TabIndex = 37;
            picNVBP.TabStop = false;
            // 
            // txtNVBuscarProducto
            // 
            txtNVBuscarProducto.AcceptsReturn = true;
            txtNVBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNVBuscarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNVBuscarProducto.ForeColor = Color.Gray;
            txtNVBuscarProducto.Location = new Point(111, 14);
            txtNVBuscarProducto.Name = "txtNVBuscarProducto";
            txtNVBuscarProducto.Size = new Size(352, 29);
            txtNVBuscarProducto.TabIndex = 36;
            // 
            // lblR6
            // 
            lblR6.AutoSize = true;
            lblR6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR6.ForeColor = Color.Red;
            lblR6.Location = new Point(84, 12);
            lblR6.Name = "lblR6";
            lblR6.Size = new Size(21, 25);
            lblR6.TabIndex = 10;
            lblR6.Text = "*";
            // 
            // lblNVBuscarCliente
            // 
            lblNVBuscarCliente.AutoSize = true;
            lblNVBuscarCliente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNVBuscarCliente.Location = new Point(19, 14);
            lblNVBuscarCliente.Name = "lblNVBuscarCliente";
            lblNVBuscarCliente.Size = new Size(71, 22);
            lblNVBuscarCliente.TabIndex = 9;
            lblNVBuscarCliente.Text = "Buscar ";
            // 
            // FrmBuscarClienteV
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 458);
            Controls.Add(pnlNVBC);
            Font = new Font("Microsoft Sans Serif", 10.8F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBuscarClienteV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar Cliente";
            pnlNVBC.ResumeLayout(false);
            pnlNVBC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNVPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNVBP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNVBC;
        private PictureBox picNVBP;
        private TextBox txtNVBuscarProducto;
        private Label lblR6;
        private Label lblNVBuscarCliente;
        private DataGridView dgvNVPA;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn colAcciones;
        private Button btnNVBC;
        private Button btnBCC;
    }
}