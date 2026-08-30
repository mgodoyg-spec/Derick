namespace Derick
{
    partial class FrmActividadRecienteE
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
            panel1 = new Panel();
            panel3 = new Panel();
            dgvActividad = new DataGridView();
            panel2 = new Panel();
            btnFiltrar = new Button();
            lblSalir = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividad).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 246, 249);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 690);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvActividad);
            panel3.Location = new Point(14, 157);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 564);
            panel3.TabIndex = 1;
            // 
            // dgvActividad
            // 
            dgvActividad.AllowUserToAddRows = false;
            dgvActividad.AllowUserToDeleteRows = false;
            dgvActividad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividad.Dock = DockStyle.Fill;
            dgvActividad.Location = new Point(0, 0);
            dgvActividad.Margin = new Padding(3, 4, 3, 4);
            dgvActividad.Name = "dgvActividad";
            dgvActividad.ReadOnly = true;
            dgvActividad.RowHeadersVisible = false;
            dgvActividad.RowHeadersWidth = 51;
            dgvActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividad.Size = new Size(887, 564);
            dgvActividad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(lblSalir);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFecha);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 133);
            panel2.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(255, 128, 0);
            btnFiltrar.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(256, 79);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(110, 33);
            btnFiltrar.TabIndex = 17;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.White;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = Color.Red;
            lblSalir.Location = new Point(855, 0);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(31, 29);
            lblSalir.TabIndex = 16;
            lblSalir.Text = "X";
            lblSalir.Click += lblSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(101, 81);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(109, 27);
            dtpFecha.TabIndex = 1;
            dtpFecha.Value = new DateTime(2026, 8, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(321, 31);
            label1.TabIndex = 0;
            label1.Text = "Historial de Actividades";
            // 
            // FrmActividadRecienteE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 690);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmActividadRecienteE";
            Text = "FrmActividadRecienteE";
            Load += FrmActividadRecienteE_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActividad).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvActividad;
        private Panel panel2;
        private Button btnFiltrar;
        private Label lblSalir;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
    }
}