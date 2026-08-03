namespace Derick
{
    partial class FrmListaEmpleados
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
            pnlListaEmpleados = new Panel();
            btnVolver = new Button();
            pnl_borde_p3 = new Panel();
            pnlBuscar = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            txtBuscar = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnNuevoEmpleado = new Button();
            cmbDepartamento = new ComboBox();
            lblListaEmple = new Label();
            dgvEmpleados = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColImagen = new DataGridViewImageColumn();
            ColEmpleado = new DataGridViewTextBoxColumn();
            ColCargo = new DataGridViewTextBoxColumn();
            ColDepartamento = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewImageColumn();
            ColEliminar = new DataGridViewImageColumn();
            ColVer = new DataGridViewButtonColumn();
            pnlListaEmpleados.SuspendLayout();
            pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // pnlListaEmpleados
            // 
            pnlListaEmpleados.BackColor = Color.White;
            pnlListaEmpleados.Controls.Add(btnVolver);
            pnlListaEmpleados.Controls.Add(pnl_borde_p3);
            pnlListaEmpleados.Controls.Add(pnlBuscar);
            pnlListaEmpleados.Controls.Add(lblEstado);
            pnlListaEmpleados.Controls.Add(cmbEstado);
            pnlListaEmpleados.Controls.Add(btnNuevoEmpleado);
            pnlListaEmpleados.Controls.Add(cmbDepartamento);
            pnlListaEmpleados.Controls.Add(lblListaEmple);
            pnlListaEmpleados.Controls.Add(dgvEmpleados);
            pnlListaEmpleados.Dock = DockStyle.Fill;
            pnlListaEmpleados.Location = new Point(0, 0);
            pnlListaEmpleados.Name = "pnlListaEmpleados";
            pnlListaEmpleados.Size = new Size(1335, 774);
            pnlListaEmpleados.TabIndex = 0;
            pnlListaEmpleados.Paint += pnlListEmpleados_Paint;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(1143, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 43);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnl_borde_p3
            // 
            pnl_borde_p3.BackColor = Color.FromArgb(112, 34, 246);
            pnl_borde_p3.Location = new Point(12, 82);
            pnl_borde_p3.Name = "pnl_borde_p3";
            pnl_borde_p3.Size = new Size(145, 10);
            pnl_borde_p3.TabIndex = 26;
            // 
            // pnlBuscar
            // 
            pnlBuscar.BackColor = Color.White;
            pnlBuscar.BorderStyle = BorderStyle.FixedSingle;
            pnlBuscar.Controls.Add(pictureBox1);
            pnlBuscar.Controls.Add(txtBuscar);
            pnlBuscar.Location = new Point(33, 168);
            pnlBuscar.Name = "pnlBuscar";
            pnlBuscar.Size = new Size(280, 40);
            pnlBuscar.TabIndex = 25;
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
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(646, 186);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 22);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
            cmbEstado.Location = new Point(740, 180);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(250, 28);
            cmbEstado.TabIndex = 23;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.Purple;
            btnNuevoEmpleado.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoEmpleado.ForeColor = Color.White;
            btnNuevoEmpleado.Location = new Point(1047, 166);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(213, 53);
            btnNuevoEmpleado.TabIndex = 20;
            btnNuevoEmpleado.Text = "+ Nuevo empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Todos los departamentos", "Gerencia", "Ventas", "Administración", "Sistemas", "Logística", "Recursos Humanos" });
            cmbDepartamento.Location = new Point(364, 180);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(250, 28);
            cmbDepartamento.TabIndex = 19;
            // 
            // lblListaEmple
            // 
            lblListaEmple.AutoSize = true;
            lblListaEmple.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaEmple.Location = new Point(12, 50);
            lblListaEmple.Name = "lblListaEmple";
            lblListaEmple.Size = new Size(244, 29);
            lblListaEmple.TabIndex = 1;
            lblListaEmple.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { ColID, ColImagen, ColEmpleado, ColCargo, ColDepartamento, ColTelefono, ColCorreo, ColEstado, ColEditar, ColEliminar, ColVer });
            dgvEmpleados.Location = new Point(12, 244);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1248, 329);
            dgvEmpleados.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
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
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            // 
            // ColEditar
            // 
            ColEditar.HeaderText = "Editar";
            ColEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColEditar.MinimumWidth = 6;
            ColEditar.Name = "ColEditar";
            ColEditar.Resizable = DataGridViewTriState.True;
            ColEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColEliminar
            // 
            ColEliminar.HeaderText = "Eliminar";
            ColEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColEliminar.MinimumWidth = 6;
            ColEliminar.Name = "ColEliminar";
            ColEliminar.Resizable = DataGridViewTriState.True;
            ColEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColVer
            // 
            ColVer.HeaderText = "Ver";
            ColVer.MinimumWidth = 6;
            ColVer.Name = "ColVer";
            ColVer.Resizable = DataGridViewTriState.True;
            ColVer.SortMode = DataGridViewColumnSortMode.Automatic;
            ColVer.UseColumnTextForButtonValue = true;
            // 
            // FrmListaEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 774);
            Controls.Add(pnlListaEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaEmpleados";
            Text = "FrmListaEmpleados";
            Load += FrmListaEmpleados_Load;
            pnlListaEmpleados.ResumeLayout(false);
            pnlListaEmpleados.PerformLayout();
            pnlBuscar.ResumeLayout(false);
            pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlListaEmpleados;
        private DataGridView dgvEmpleados;
        private Label lblListaEmple;
        private ComboBox cmbDepartamento;
        private Button btnNuevoEmpleado;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private FlowLayoutPanel pnlBuscar;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Panel pnl_borde_p3;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewImageColumn ColImagen;
        private DataGridViewTextBoxColumn ColEmpleado;
        private DataGridViewTextBoxColumn ColCargo;
        private DataGridViewTextBoxColumn ColDepartamento;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColEstado;
        private DataGridViewImageColumn ColEditar;
        private DataGridViewImageColumn ColEliminar;
        private DataGridViewButtonColumn ColVer;
    }
}