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
            pnl04 = new Panel();
            lblSalirV = new Label();
            pnlBusqueda = new Panel();
            cmb02 = new ComboBox();
            cmb01 = new ComboBox();
            txt01 = new TextBox();
            btnLimpiar = new Button();
            pictureBox1 = new PictureBox();
            lbl_agg2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btn_ctg1 = new Button();
            pic01 = new PictureBox();
            lbl01 = new Label();
            dgvProveedor = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombreProveedor = new DataGridViewTextBoxColumn();
            clContacto = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clCorreo = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            imgProveedor = new ImageList(components);
            pnl_prov.SuspendLayout();
            pnl04.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // pnl_prov
            // 
            pnl_prov.BackColor = Color.FromArgb(244, 246, 249);
            pnl_prov.Controls.Add(pnl04);
            pnl_prov.Dock = DockStyle.Fill;
            pnl_prov.Location = new Point(0, 0);
            pnl_prov.Margin = new Padding(3, 2, 3, 2);
            pnl_prov.Name = "pnl_prov";
            pnl_prov.Size = new Size(1186, 651);
            pnl_prov.TabIndex = 0;
            // 
            // pnl04
            // 
            pnl04.BackColor = Color.White;
            pnl04.Controls.Add(lblSalirV);
            pnl04.Controls.Add(pnlBusqueda);
            pnl04.Controls.Add(pictureBox2);
            pnl04.Controls.Add(pic01);
            pnl04.Controls.Add(lbl01);
            pnl04.Controls.Add(dgvProveedor);
            pnl04.Location = new Point(13, 13);
            pnl04.Margin = new Padding(3, 2, 3, 2);
            pnl04.Name = "pnl04";
            pnl04.Size = new Size(1150, 630);
            pnl04.TabIndex = 35;
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1111, 8);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 36;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(cmb02);
            pnlBusqueda.Controls.Add(cmb01);
            pnlBusqueda.Controls.Add(txt01);
            pnlBusqueda.Controls.Add(btn_ctg1);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Controls.Add(label1);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 38;
            // 
            // cmb02
            // 
            cmb02.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb02.Font = new Font("Calibri", 14.25F);
            cmb02.FormattingEnabled = true;
            cmb02.Location = new Point(643, 6);
            cmb02.Margin = new Padding(3, 2, 3, 2);
            cmb02.Name = "cmb02";
            cmb02.Size = new Size(103, 31);
            cmb02.TabIndex = 14;
            cmb02.SelectedIndexChanged += cmb02_SelectedIndexChanged;
            // 
            // cmb01
            // 
            cmb01.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb01.Font = new Font("Calibri", 14.25F);
            cmb01.FormattingEnabled = true;
            cmb01.Location = new Point(421, 7);
            cmb01.Margin = new Padding(3, 2, 3, 2);
            cmb01.Name = "cmb01";
            cmb01.Size = new Size(121, 31);
            cmb01.TabIndex = 14;
            cmb01.SelectedIndexChanged += cmb01_SelectedIndexChanged;
            // 
            // txt01
            // 
            txt01.Font = new Font("Calibri", 12F);
            txt01.ForeColor = Color.Gray;
            txt01.Location = new Point(49, 9);
            txt01.Margin = new Padding(3, 2, 3, 2);
            txt01.Name = "txt01";
            txt01.PlaceholderText = "Buscar producto";
            txt01.Size = new Size(307, 27);
            txt01.TabIndex = 7;
            txt01.TextChanged += txt01_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(766, 9);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 27);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "   Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // lbl_agg2
            // 
            lbl_agg2.AutoSize = true;
            lbl_agg2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lbl_agg2.ForeColor = Color.Black;
            lbl_agg2.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg2.Location = new Point(366, 12);
            lbl_agg2.Name = "lbl_agg2";
            lbl_agg2.Size = new Size(59, 19);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Estado:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(548, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 17;
            label1.Text = "Ordenar por:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 14);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // btn_ctg1
            // 
            btn_ctg1.BackColor = Color.FromArgb(4, 59, 186);
            btn_ctg1.Cursor = Cursors.Hand;
            btn_ctg1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_ctg1.ForeColor = Color.White;
            btn_ctg1.Image = (Image)resources.GetObject("btn_ctg1.Image");
            btn_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ctg1.Location = new Point(881, 2);
            btn_ctg1.Margin = new Padding(3, 2, 3, 2);
            btn_ctg1.Name = "btn_ctg1";
            btn_ctg1.Size = new Size(223, 39);
            btn_ctg1.TabIndex = 34;
            btn_ctg1.Text = "Agregar proveedor";
            btn_ctg1.UseVisualStyleBackColor = false;
            btn_ctg1.Click += btn_ctg1_Click;
            // 
            // pic01
            // 
            pic01.Image = (Image)resources.GetObject("pic01.Image");
            pic01.Location = new Point(7, 0);
            pic01.Margin = new Padding(3, 2, 3, 2);
            pic01.Name = "pic01";
            pic01.Size = new Size(43, 38);
            pic01.SizeMode = PictureBoxSizeMode.Zoom;
            pic01.TabIndex = 33;
            pic01.TabStop = false;
            // 
            // lbl01
            // 
            lbl01.AutoSize = true;
            lbl01.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl01.ForeColor = Color.FromArgb(13, 154, 64);
            lbl01.ImageAlign = ContentAlignment.MiddleLeft;
            lbl01.Location = new Point(56, 0);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(219, 26);
            lbl01.TabIndex = 32;
            lbl01.Text = "Gestión de proveedores";
            lbl01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { clId, clNombreProveedor, clContacto, clTelefono, clCorreo, clEstado, clEditar, clEliminar });
            dgvProveedor.Location = new Point(7, 94);
            dgvProveedor.Margin = new Padding(3, 2, 3, 2);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(1126, 510);
            dgvProveedor.TabIndex = 15;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
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
            pnl04.ResumeLayout(false);
            pnl04.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic01).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_prov;
        private Button btn_ctg1;
        private PictureBox pic01;
        private Label lbl01;
        private Panel pnl04;
        private Button btnLimpiar;
        private ComboBox cmb02;
        private ComboBox cmb01;
        private DataGridView dgvProveedor;
        private TextBox txt01;
        private ImageList imgProveedor;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombreProveedor;
        private DataGridViewTextBoxColumn clContacto;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewTextBoxColumn clCorreo;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewImageColumn clEditar;
        private DataGridViewImageColumn clEliminar;
        private PictureBox pictureBox2;
        private Panel pnlBusqueda;
        private PictureBox pictureBox1;
        private Label lbl_agg2;
        private Label label1;
        private Label lblSalirV;
    }
}