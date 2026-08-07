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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlEmple = new Panel();
            panel1 = new Panel();
            btnReportes = new Button();
            btnDepa = new Button();
            button1 = new Button();
            gbtn_busc6 = new Guna.UI2.WinForms.Guna2Button();
            gbtn_busc4 = new Guna.UI2.WinForms.Guna2Button();
            lbl_busc4 = new Label();
            gbtn_busc3 = new Guna.UI2.WinForms.Guna2Button();
            gbtn_busc2 = new Guna.UI2.WinForms.Guna2Button();
            gbtn_busc1 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            lblEstado = new Label();
            btnNuevoEmpleado = new Button();
            cmbEstado = new ComboBox();
            cmbDepartamento = new ComboBox();
            pnlBuscar = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            txtBuscar = new TextBox();
            lblListaEmple = new Label();
            dgvEmpleados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColImagen = new DataGridViewImageColumn();
            ColEmpleado = new DataGridViewTextBoxColumn();
            ColCargo = new DataGridViewTextBoxColumn();
            ColDepartamento = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            ColVer = new DataGridViewImageColumn();
            pnlEmple.SuspendLayout();
            panel1.SuspendLayout();
            pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // pnlEmple
            // 
            pnlEmple.BackColor = Color.White;
            pnlEmple.Controls.Add(panel1);
            pnlEmple.Dock = DockStyle.Fill;
            pnlEmple.Location = new Point(0, 0);
            pnlEmple.Name = "pnlEmple";
            pnlEmple.Size = new Size(1186, 700);
            pnlEmple.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnDepa);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(gbtn_busc6);
            panel1.Controls.Add(gbtn_busc4);
            panel1.Controls.Add(lbl_busc4);
            panel1.Controls.Add(gbtn_busc3);
            panel1.Controls.Add(gbtn_busc2);
            panel1.Controls.Add(gbtn_busc1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(btnNuevoEmpleado);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(cmbDepartamento);
            panel1.Controls.Add(pnlBuscar);
            panel1.Controls.Add(lblListaEmple);
            panel1.Controls.Add(dgvEmpleados);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 700);
            panel1.TabIndex = 31;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(438, 12);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(208, 44);
            btnReportes.TabIndex = 41;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnDepa
            // 
            btnDepa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDepa.Location = new Point(224, 12);
            btnDepa.Name = "btnDepa";
            btnDepa.Size = new Size(208, 44);
            btnDepa.TabIndex = 40;
            btnDepa.Text = "Departamentos";
            btnDepa.UseVisualStyleBackColor = true;
            btnDepa.Click += btnDepa_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(208, 44);
            button1.TabIndex = 39;
            button1.Text = "Lista de empleados";
            button1.UseVisualStyleBackColor = true;
            // 
            // gbtn_busc6
            // 
            gbtn_busc6.BorderRadius = 12;
            gbtn_busc6.BorderThickness = 1;
            gbtn_busc6.Cursor = Cursors.Hand;
            gbtn_busc6.CustomizableEdges = customizableEdges1;
            gbtn_busc6.DisabledState.BorderColor = Color.DarkGray;
            gbtn_busc6.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtn_busc6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtn_busc6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtn_busc6.FillColor = Color.White;
            gbtn_busc6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbtn_busc6.ForeColor = Color.Black;
            gbtn_busc6.Location = new Point(1106, 588);
            gbtn_busc6.Name = "gbtn_busc6";
            gbtn_busc6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbtn_busc6.Size = new Size(44, 44);
            gbtn_busc6.TabIndex = 38;
            gbtn_busc6.Text = ">";
            // 
            // gbtn_busc4
            // 
            gbtn_busc4.BorderRadius = 12;
            gbtn_busc4.BorderThickness = 1;
            gbtn_busc4.Cursor = Cursors.Hand;
            gbtn_busc4.CustomizableEdges = customizableEdges3;
            gbtn_busc4.DisabledState.BorderColor = Color.DarkGray;
            gbtn_busc4.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtn_busc4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtn_busc4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtn_busc4.FillColor = Color.White;
            gbtn_busc4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbtn_busc4.ForeColor = Color.Black;
            gbtn_busc4.HoverState.FillColor = Color.FromArgb(112, 34, 246);
            gbtn_busc4.Location = new Point(1056, 588);
            gbtn_busc4.Name = "gbtn_busc4";
            gbtn_busc4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtn_busc4.Size = new Size(44, 44);
            gbtn_busc4.TabIndex = 37;
            gbtn_busc4.Text = "3";
            // 
            // lbl_busc4
            // 
            lbl_busc4.AutoSize = true;
            lbl_busc4.Cursor = Cursors.Hand;
            lbl_busc4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_busc4.Location = new Point(1014, 597);
            lbl_busc4.Name = "lbl_busc4";
            lbl_busc4.Size = new Size(36, 35);
            lbl_busc4.TabIndex = 36;
            lbl_busc4.Text = "...";
            // 
            // gbtn_busc3
            // 
            gbtn_busc3.BorderRadius = 12;
            gbtn_busc3.BorderThickness = 1;
            gbtn_busc3.Cursor = Cursors.Hand;
            gbtn_busc3.CustomizableEdges = customizableEdges5;
            gbtn_busc3.DisabledState.BorderColor = Color.DarkGray;
            gbtn_busc3.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtn_busc3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtn_busc3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtn_busc3.FillColor = Color.White;
            gbtn_busc3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbtn_busc3.ForeColor = Color.Black;
            gbtn_busc3.HoverState.FillColor = Color.FromArgb(112, 34, 246);
            gbtn_busc3.Location = new Point(964, 588);
            gbtn_busc3.Name = "gbtn_busc3";
            gbtn_busc3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbtn_busc3.Size = new Size(44, 44);
            gbtn_busc3.TabIndex = 35;
            gbtn_busc3.Text = "2";
            // 
            // gbtn_busc2
            // 
            gbtn_busc2.BorderRadius = 12;
            gbtn_busc2.BorderThickness = 1;
            gbtn_busc2.Cursor = Cursors.Hand;
            gbtn_busc2.CustomizableEdges = customizableEdges7;
            gbtn_busc2.DisabledState.BorderColor = Color.DarkGray;
            gbtn_busc2.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtn_busc2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtn_busc2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtn_busc2.FillColor = Color.White;
            gbtn_busc2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbtn_busc2.ForeColor = Color.Black;
            gbtn_busc2.HoverState.FillColor = Color.FromArgb(112, 34, 246);
            gbtn_busc2.Location = new Point(914, 588);
            gbtn_busc2.Name = "gbtn_busc2";
            gbtn_busc2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gbtn_busc2.Size = new Size(44, 44);
            gbtn_busc2.TabIndex = 34;
            gbtn_busc2.Text = "1";
            // 
            // gbtn_busc1
            // 
            gbtn_busc1.BorderRadius = 12;
            gbtn_busc1.BorderThickness = 1;
            gbtn_busc1.Cursor = Cursors.Hand;
            gbtn_busc1.CustomizableEdges = customizableEdges9;
            gbtn_busc1.DisabledState.BorderColor = Color.DarkGray;
            gbtn_busc1.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtn_busc1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtn_busc1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtn_busc1.FillColor = Color.White;
            gbtn_busc1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbtn_busc1.ForeColor = Color.Black;
            gbtn_busc1.Location = new Point(864, 588);
            gbtn_busc1.Name = "gbtn_busc1";
            gbtn_busc1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gbtn_busc1.Size = new Size(44, 44);
            gbtn_busc1.TabIndex = 33;
            gbtn_busc1.Text = "<";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(420, 22);
            label2.TabIndex = 32;
            label2.Text = "Consulta y administra los empleados de la empresa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(367, 156);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 31;
            label1.Text = "Departamentos:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = SystemColors.ActiveBorder;
            lblEstado.Location = new Point(658, 156);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 22);
            lblEstado.TabIndex = 30;
            lblEstado.Text = "Estado:";
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.Purple;
            btnNuevoEmpleado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoEmpleado.ForeColor = Color.White;
            btnNuevoEmpleado.Location = new Point(948, 168);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(213, 53);
            btnNuevoEmpleado.TabIndex = 29;
            btnNuevoEmpleado.Text = "+ Nuevo empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            cmbEstado.Location = new Point(658, 193);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(250, 28);
            cmbEstado.TabIndex = 28;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Todos los departamentos", "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cmbDepartamento.Location = new Point(367, 193);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(250, 28);
            cmbDepartamento.TabIndex = 27;
            // 
            // pnlBuscar
            // 
            pnlBuscar.BackColor = Color.White;
            pnlBuscar.BorderStyle = BorderStyle.FixedSingle;
            pnlBuscar.Controls.Add(pictureBox1);
            pnlBuscar.Controls.Add(txtBuscar);
            pnlBuscar.Location = new Point(12, 181);
            pnlBuscar.Name = "pnlBuscar";
            pnlBuscar.Size = new Size(280, 40);
            pnlBuscar.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_cartoon_blue_magnifying_glass_illustration_png_image_4505525;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(54, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar empleado......";
            txtBuscar.Size = new Size(212, 27);
            txtBuscar.TabIndex = 26;
            // 
            // lblListaEmple
            // 
            lblListaEmple.AutoSize = true;
            lblListaEmple.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaEmple.Location = new Point(12, 75);
            lblListaEmple.Name = "lblListaEmple";
            lblListaEmple.Size = new Size(244, 29);
            lblListaEmple.TabIndex = 2;
            lblListaEmple.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ColImagen, ColEmpleado, ColCargo, ColDepartamento, ColTelefono, ColCorreo, dataGridViewTextBoxColumn2, dataGridViewImageColumn1, dataGridViewImageColumn2, ColVer });
            dgvEmpleados.Location = new Point(12, 243);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1162, 329);
            dgvEmpleados.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColImagen
            // 
            ColImagen.HeaderText = "Imagen";
            ColImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColImagen.MinimumWidth = 6;
            ColImagen.Name = "ColImagen";
            ColImagen.Resizable = DataGridViewTriState.True;
            ColImagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColEmpleado
            // 
            ColEmpleado.HeaderText = "Empleado";
            ColEmpleado.MinimumWidth = 6;
            ColEmpleado.Name = "ColEmpleado";
            // 
            // ColCargo
            // 
            ColCargo.HeaderText = "Cargo";
            ColCargo.MinimumWidth = 6;
            ColCargo.Name = "ColCargo";
            // 
            // ColDepartamento
            // 
            ColDepartamento.HeaderText = "Departamento";
            ColDepartamento.MinimumWidth = 6;
            ColDepartamento.Name = "ColDepartamento";
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Teléfono";
            ColTelefono.MinimumWidth = 6;
            ColTelefono.Name = "ColTelefono";
            // 
            // ColCorreo
            // 
            ColCorreo.HeaderText = "Correo";
            ColCorreo.MinimumWidth = 6;
            ColCorreo.Name = "ColCorreo";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Estado";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Editar";
            dataGridViewImageColumn1.Image = Properties.Resources.download__2_;
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "Eliminar";
            dataGridViewImageColumn2.Image = Properties.Resources.download__1_;
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.Image = Properties.Resources.download__3_;
            ColVer.MinimumWidth = 6;
            ColVer.Name = "ColVer";
            ColVer.Resizable = DataGridViewTriState.True;
            ColVer.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FrmEmple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 700);
            Controls.Add(pnlEmple);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmple";
            Text = "FrmEmple";
            pnlEmple.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBuscar.ResumeLayout(false);
            pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEmple;
        private Panel panel1;
        private Button btnReportes;
        private Button btnDepa;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Button gbtn_busc6;
        private Guna.UI2.WinForms.Guna2Button gbtn_busc4;
        private Label lbl_busc4;
        private Guna.UI2.WinForms.Guna2Button gbtn_busc3;
        private Guna.UI2.WinForms.Guna2Button gbtn_busc2;
        private Guna.UI2.WinForms.Guna2Button gbtn_busc1;
        private Label label2;
        private Label label1;
        private Label lblEstado;
        private Button btnNuevoEmpleado;
        private ComboBox cmbEstado;
        private ComboBox cmbDepartamento;
        private FlowLayoutPanel pnlBuscar;
        private PictureBox pictureBox1;
        private TextBox txtBuscar;
        private Label lblListaEmple;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn ColImagen;
        private DataGridViewTextBoxColumn ColEmpleado;
        private DataGridViewTextBoxColumn ColCargo;
        private DataGridViewTextBoxColumn ColDepartamento;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewImageColumn ColVer;
    }
}