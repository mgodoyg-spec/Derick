namespace Derick
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            pnl_prov = new Panel();
            lbl02 = new PictureBox();
            pnl04 = new Panel();
            btnBuscar = new Button();
            pnl03 = new Panel();
            cmb02 = new ComboBox();
            btnLimpiar = new Button();
            lbl04 = new Label();
            pnl02 = new Panel();
            cmb01 = new ComboBox();
            lbl03 = new Label();
            dgvProveedor = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombreProveedor = new DataGridViewTextBoxColumn();
            clContacto = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clCorreo = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            pnl01 = new Panel();
            pic02 = new PictureBox();
            txt01 = new TextBox();
            btn_ctg1 = new Button();
            pic01 = new PictureBox();
            lbl01 = new Label();
            imgProveedor = new ImageList(components);
            pnl_prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl02).BeginInit();
            pnl04.SuspendLayout();
            pnl03.SuspendLayout();
            pnl02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            pnl01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic01).BeginInit();
            SuspendLayout();
            // 
            // pnl_prov
            // 
            pnl_prov.BackColor = Color.FromArgb(244, 246, 249);
            pnl_prov.Controls.Add(lbl02);
            pnl_prov.Controls.Add(pnl04);
            pnl_prov.Controls.Add(btn_ctg1);
            pnl_prov.Controls.Add(pic01);
            pnl_prov.Controls.Add(lbl01);
            pnl_prov.Dock = DockStyle.Fill;
            pnl_prov.Location = new Point(0, 0);
            pnl_prov.Margin = new Padding(3, 2, 3, 2);
            pnl_prov.Name = "pnl_prov";
            pnl_prov.Size = new Size(1186, 651);
            pnl_prov.TabIndex = 0;
            // 
            // lbl02
            // 
            lbl02.BackColor = Color.FromArgb(0, 176, 80);
            lbl02.Location = new Point(66, 39);
            lbl02.Margin = new Padding(3, 2, 3, 2);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(244, 3);
            lbl02.TabIndex = 23;
            lbl02.TabStop = false;
            // 
            // pnl04
            // 
            pnl04.BackColor = Color.White;
            pnl04.Controls.Add(btnBuscar);
            pnl04.Controls.Add(pnl03);
            pnl04.Controls.Add(btnLimpiar);
            pnl04.Controls.Add(lbl04);
            pnl04.Controls.Add(pnl02);
            pnl04.Controls.Add(lbl03);
            pnl04.Controls.Add(dgvProveedor);
            pnl04.Controls.Add(pnl01);
            pnl04.Location = new Point(10, 55);
            pnl04.Margin = new Padding(3, 2, 3, 2);
            pnl04.Name = "pnl04";
            pnl04.Size = new Size(1164, 585);
            pnl04.TabIndex = 35;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 176, 80);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(889, 12);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 37);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnl03
            // 
            pnl03.BackColor = Color.White;
            pnl03.BorderStyle = BorderStyle.FixedSingle;
            pnl03.Controls.Add(cmb02);
            pnl03.Location = new Point(619, 15);
            pnl03.Margin = new Padding(3, 2, 3, 2);
            pnl03.Name = "pnl03";
            pnl03.Padding = new Padding(9, 8, 9, 8);
            pnl03.Size = new Size(138, 34);
            pnl03.TabIndex = 16;
            // 
            // cmb02
            // 
            cmb02.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb02.FlatStyle = FlatStyle.Flat;
            cmb02.FormattingEnabled = true;
            cmb02.Location = new Point(11, 7);
            cmb02.Margin = new Padding(3, 2, 3, 2);
            cmb02.Name = "cmb02";
            cmb02.Size = new Size(113, 23);
            cmb02.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1025, 15);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 37);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "   Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbl04
            // 
            lbl04.AutoSize = true;
            lbl04.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl04.ForeColor = Color.Black;
            lbl04.ImageAlign = ContentAlignment.MiddleLeft;
            lbl04.Location = new Point(509, 23);
            lbl04.Name = "lbl04";
            lbl04.Size = new Size(104, 18);
            lbl04.TabIndex = 17;
            lbl04.Text = "Ordenar por:";
            lbl04.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl02
            // 
            pnl02.BackColor = Color.White;
            pnl02.BorderStyle = BorderStyle.FixedSingle;
            pnl02.Controls.Add(cmb01);
            pnl02.Location = new Point(362, 15);
            pnl02.Margin = new Padding(3, 2, 3, 2);
            pnl02.Name = "pnl02";
            pnl02.Padding = new Padding(9, 8, 9, 8);
            pnl02.Size = new Size(141, 34);
            pnl02.TabIndex = 15;
            // 
            // cmb01
            // 
            cmb01.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb01.FlatStyle = FlatStyle.Flat;
            cmb01.FormattingEnabled = true;
            cmb01.Location = new Point(11, 7);
            cmb01.Margin = new Padding(3, 2, 3, 2);
            cmb01.Name = "cmb01";
            cmb01.Size = new Size(116, 23);
            cmb01.TabIndex = 14;
            // 
            // lbl03
            // 
            lbl03.AutoSize = true;
            lbl03.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl03.ForeColor = Color.Black;
            lbl03.ImageAlign = ContentAlignment.MiddleLeft;
            lbl03.Location = new Point(290, 23);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(66, 18);
            lbl03.TabIndex = 15;
            lbl03.Text = "Estado:";
            lbl03.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { clId, clNombreProveedor, clContacto, clTelefono, clCorreo, clEstado, clEditar, clEliminar });
            dgvProveedor.Location = new Point(10, 81);
            dgvProveedor.Margin = new Padding(3, 2, 3, 2);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(1143, 489);
            dgvProveedor.TabIndex = 15;
            // 
            // clId
            // 
            clId.HeaderText = "ID";
            clId.MinimumWidth = 6;
            clId.Name = "clId";
            // 
            // clNombreProveedor
            // 
            clNombreProveedor.HeaderText = "Nombre del proveedor";
            clNombreProveedor.MinimumWidth = 6;
            clNombreProveedor.Name = "clNombreProveedor";
            // 
            // clContacto
            // 
            clContacto.HeaderText = "Contacto";
            clContacto.MinimumWidth = 6;
            clContacto.Name = "clContacto";
            // 
            // clTelefono
            // 
            clTelefono.HeaderText = "Teléfono";
            clTelefono.MinimumWidth = 6;
            clTelefono.Name = "clTelefono";
            // 
            // clCorreo
            // 
            clCorreo.HeaderText = "Correo electrónico";
            clCorreo.MinimumWidth = 6;
            clCorreo.Name = "clCorreo";
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 6;
            clEditar.Name = "clEditar";
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            // 
            // pnl01
            // 
            pnl01.BackColor = Color.White;
            pnl01.BorderStyle = BorderStyle.FixedSingle;
            pnl01.Controls.Add(pic02);
            pnl01.Controls.Add(txt01);
            pnl01.Location = new Point(10, 15);
            pnl01.Margin = new Padding(3, 2, 3, 2);
            pnl01.Name = "pnl01";
            pnl01.Padding = new Padding(9, 8, 9, 8);
            pnl01.Size = new Size(259, 34);
            pnl01.TabIndex = 9;
            // 
            // pic02
            // 
            pic02.BackColor = Color.White;
            pic02.Image = (Image)resources.GetObject("pic02.Image");
            pic02.Location = new Point(-2, -1);
            pic02.Margin = new Padding(3, 2, 3, 2);
            pic02.Name = "pic02";
            pic02.Size = new Size(44, 34);
            pic02.SizeMode = PictureBoxSizeMode.Zoom;
            pic02.TabIndex = 23;
            pic02.TabStop = false;
            // 
            // txt01
            // 
            txt01.BorderStyle = BorderStyle.None;
            txt01.Font = new Font("Segoe UI", 10.8F);
            txt01.ForeColor = Color.Gray;
            txt01.Location = new Point(48, 5);
            txt01.Margin = new Padding(3, 2, 3, 2);
            txt01.Name = "txt01";
            txt01.PlaceholderText = "          Buscar producto";
            txt01.Size = new Size(197, 20);
            txt01.TabIndex = 7;
            // 
            // btn_ctg1
            // 
            btn_ctg1.BackColor = Color.FromArgb(0, 102, 255);
            btn_ctg1.Cursor = Cursors.Hand;
            btn_ctg1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ctg1.ForeColor = Color.White;
            btn_ctg1.Image = (Image)resources.GetObject("btn_ctg1.Image");
            btn_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ctg1.Location = new Point(957, 7);
            btn_ctg1.Margin = new Padding(3, 2, 3, 2);
            btn_ctg1.Name = "btn_ctg1";
            btn_ctg1.Size = new Size(217, 38);
            btn_ctg1.TabIndex = 34;
            btn_ctg1.Text = "Agregar proveedor";
            btn_ctg1.UseVisualStyleBackColor = false;
            btn_ctg1.Click += btn_ctg1_Click;
            // 
            // pic01
            // 
            pic01.Image = (Image)resources.GetObject("pic01.Image");
            pic01.Location = new Point(8, 7);
            pic01.Margin = new Padding(3, 2, 3, 2);
            pic01.Name = "pic01";
            pic01.Size = new Size(52, 38);
            pic01.SizeMode = PictureBoxSizeMode.Zoom;
            pic01.TabIndex = 33;
            pic01.TabStop = false;
            // 
            // lbl01
            // 
            lbl01.AutoSize = true;
            lbl01.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl01.ForeColor = Color.FromArgb(0, 176, 80);
            lbl01.ImageAlign = ContentAlignment.MiddleLeft;
            lbl01.Location = new Point(60, 15);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(235, 24);
            lbl01.TabIndex = 32;
            lbl01.Text = "Gestión de proveedores";
            lbl01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgProveedor
            // 
            imgProveedor.ColorDepth = ColorDepth.Depth32Bit;
            imgProveedor.ImageStream = (ImageListStreamer)resources.GetObject("imgProveedor.ImageStream");
            imgProveedor.TransparentColor = Color.Transparent;
            imgProveedor.Images.SetKeyName(0, "eliminar1.png");
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_prov);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            pnl_prov.ResumeLayout(false);
            pnl_prov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl02).EndInit();
            pnl04.ResumeLayout(false);
            pnl04.PerformLayout();
            pnl03.ResumeLayout(false);
            pnl02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            pnl01.ResumeLayout(false);
            pnl01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic02).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic01).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_prov;
        private Button btn_ctg1;
        private PictureBox pic01;
        private Label lbl01;
        private Panel pnl04;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Panel pnl03;
        private ComboBox cmb02;
        private Label lbl04;
        private Panel pnl02;
        private ComboBox cmb01;
        private Label lbl03;
        private DataGridView dgvProveedor;
        private Panel pnl01;
        private PictureBox pic02;
        private TextBox txt01;
        private PictureBox lbl02;
        private ImageList imgProveedor;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombreProveedor;
        private DataGridViewTextBoxColumn clContacto;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clCorreo;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
    }
}