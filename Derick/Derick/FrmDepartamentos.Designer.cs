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
            pnlDepartamentos = new Panel();
            btnVolver = new Button();
            btnDepa = new Button();
            panel3 = new Panel();
            dgvDepartamentos = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColDepa = new DataGridViewTextBoxColumn();
            ColDes = new DataGridViewTextBoxColumn();
            ColEmple = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            ColEditar = new DataGridViewImageColumn();
            ColEliminar = new DataGridViewImageColumn();
            lblDepa = new Label();
            pnlDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // pnlDepartamentos
            // 
            pnlDepartamentos.BackColor = Color.White;
            pnlDepartamentos.Controls.Add(btnVolver);
            pnlDepartamentos.Controls.Add(btnDepa);
            pnlDepartamentos.Controls.Add(panel3);
            pnlDepartamentos.Controls.Add(dgvDepartamentos);
            pnlDepartamentos.Controls.Add(lblDepa);
            pnlDepartamentos.Dock = DockStyle.Fill;
            pnlDepartamentos.Location = new Point(0, 0);
            pnlDepartamentos.Name = "pnlDepartamentos";
            pnlDepartamentos.Size = new Size(1317, 727);
            pnlDepartamentos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(1143, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 43);
            btnVolver.TabIndex = 29;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDepa
            // 
            btnDepa.BackColor = Color.Purple;
            btnDepa.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepa.ForeColor = Color.White;
            btnDepa.Location = new Point(1012, 115);
            btnDepa.Name = "btnDepa";
            btnDepa.Size = new Size(248, 53);
            btnDepa.TabIndex = 14;
            btnDepa.Text = "+ Nuevo Departamento";
            btnDepa.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.Location = new Point(12, 59);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 10);
            panel3.TabIndex = 10;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Columns.AddRange(new DataGridViewColumn[] { ColID, ColDepa, ColDes, ColEmple, ColEstado, ColEditar, ColEliminar });
            dgvDepartamentos.Location = new Point(12, 201);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.RowHeadersVisible = false;
            dgvDepartamentos.RowHeadersWidth = 51;
            dgvDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartamentos.Size = new Size(1248, 329);
            dgvDepartamentos.TabIndex = 2;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            // 
            // ColDepa
            // 
            ColDepa.HeaderText = "Departamento";
            ColDepa.MinimumWidth = 6;
            ColDepa.Name = "ColDepa";
            // 
            // ColDes
            // 
            ColDes.HeaderText = "Descripción";
            ColDes.MinimumWidth = 6;
            ColDes.Name = "ColDes";
            // 
            // ColEmple
            // 
            ColEmple.HeaderText = "Empleados";
            ColEmple.MinimumWidth = 6;
            ColEmple.Name = "ColEmple";
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
            // lblDepa
            // 
            lblDepa.AutoSize = true;
            lblDepa.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepa.Location = new Point(12, 26);
            lblDepa.Name = "lblDepa";
            lblDepa.Size = new Size(190, 29);
            lblDepa.TabIndex = 1;
            lblDepa.Text = "Departamentos";
            // 
            // FrmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 727);
            Controls.Add(pnlDepartamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDepartamentos";
            Text = "FrmDepartamentos";
            pnlDepartamentos.ResumeLayout(false);
            pnlDepartamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDepartamentos;
        private Label lblDepa;
        private DataGridView dgvDepartamentos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColDepa;
        private DataGridViewTextBoxColumn ColDes;
        private DataGridViewTextBoxColumn ColEmple;
        private DataGridViewTextBoxColumn ColEstado;
        private DataGridViewImageColumn ColEditar;
        private DataGridViewImageColumn ColEliminar;
        private Panel panel3;
        private Button btnDepa;
        private Button btnVolver;
    }
}