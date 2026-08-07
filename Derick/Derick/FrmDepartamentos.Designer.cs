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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentos));
            panel2 = new Panel();
            label3 = new Label();
            lblDepa = new Label();
            btnDepa = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            dgvDepartamentos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColDepa = new DataGridViewTextBoxColumn();
            ColDes = new DataGridViewTextBoxColumn();
            ColEmple = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblDepa);
            panel2.Controls.Add(btnDepa);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(dgvDepartamentos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 700);
            panel2.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(72, 42);
            label3.Name = "label3";
            label3.Size = new Size(364, 22);
            label3.TabIndex = 33;
            label3.Text = "Administra los departamentos de la empresa";
            // 
            // lblDepa
            // 
            lblDepa.AutoSize = true;
            lblDepa.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepa.Location = new Point(72, 13);
            lblDepa.Name = "lblDepa";
            lblDepa.Size = new Size(190, 29);
            lblDepa.TabIndex = 29;
            lblDepa.Text = "Departamentos";
            // 
            // btnDepa
            // 
            btnDepa.BackColor = Color.Purple;
            btnDepa.FlatStyle = FlatStyle.Flat;
            btnDepa.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepa.ForeColor = Color.White;
            btnDepa.Location = new Point(904, 111);
            btnDepa.Name = "btnDepa";
            btnDepa.Size = new Size(248, 53);
            btnDepa.TabIndex = 28;
            btnDepa.Text = "+ Nuevo Departamento";
            btnDepa.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Location = new Point(17, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 40);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngtree_cartoon_blue_magnifying_glass_illustration_png_image_4505525;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar departamento.....";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 26;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ColDepa, ColDes, ColEmple, dataGridViewTextBoxColumn2, dataGridViewImageColumn1, dataGridViewImageColumn2 });
            dgvDepartamentos.Location = new Point(5, 190);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.RowHeadersVisible = false;
            dgvDepartamentos.RowHeadersWidth = 51;
            dgvDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartamentos.Size = new Size(1152, 329);
            dgvDepartamentos.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Estado";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Editar";
            dataGridViewImageColumn1.Image = Properties.Resources.download__2_1;
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "Eliminar";
            dataGridViewImageColumn2.Image = Properties.Resources.download__1_1;
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 51);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // FrmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 700);
            Controls.Add(panel2);
            Name = "FrmDepartamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDepartamentos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private Label lblDepa;
        private Button btnDepa;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private DataGridView dgvDepartamentos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColDepa;
        private DataGridViewTextBoxColumn ColDes;
        private DataGridViewTextBoxColumn ColEmple;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private PictureBox pictureBox1;
    }
}