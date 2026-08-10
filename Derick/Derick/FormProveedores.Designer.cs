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
            pic03 = new PictureBox();
            btnBuscar = new Button();
            pnl03 = new Panel();
            cmb02 = new ComboBox();
            btnLimpiar = new Button();
            lbl04 = new Label();
            pnl02 = new Panel();
            cmb01 = new ComboBox();
            btn5 = new Button();
            btn1 = new Button();
            lbl03 = new Label();
            btn4 = new Button();
            dgvProveedor = new DataGridView();
            btn2 = new Button();
            pnl01 = new Panel();
            pic02 = new PictureBox();
            txt01 = new TextBox();
            btn3 = new Button();
            btn_ctg1 = new Button();
            pic01 = new PictureBox();
            lbl01 = new Label();
            imgProveedor = new ImageList(components);
            clId = new DataGridViewTextBoxColumn();
            clNombreProveedor = new DataGridViewTextBoxColumn();
            clContacto = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clCorreo = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            pnl_prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl02).BeginInit();
            pnl04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic03).BeginInit();
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
            pnl_prov.Name = "pnl_prov";
            pnl_prov.Size = new Size(1394, 889);
            pnl_prov.TabIndex = 0;
            // 
            // lbl02
            // 
            lbl02.BackColor = Color.FromArgb(0, 176, 80);
            lbl02.Location = new Point(75, 52);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(279, 4);
            lbl02.TabIndex = 23;
            lbl02.TabStop = false;
            // 
            // pnl04
            // 
            pnl04.BackColor = Color.White;
            pnl04.Controls.Add(pic03);
            pnl04.Controls.Add(btnBuscar);
            pnl04.Controls.Add(pnl03);
            pnl04.Controls.Add(btnLimpiar);
            pnl04.Controls.Add(lbl04);
            pnl04.Controls.Add(pnl02);
            pnl04.Controls.Add(btn5);
            pnl04.Controls.Add(btn1);
            pnl04.Controls.Add(lbl03);
            pnl04.Controls.Add(btn4);
            pnl04.Controls.Add(dgvProveedor);
            pnl04.Controls.Add(btn2);
            pnl04.Controls.Add(pnl01);
            pnl04.Controls.Add(btn3);
            pnl04.Location = new Point(12, 88);
            pnl04.Name = "pnl04";
            pnl04.Size = new Size(1370, 746);
            pnl04.TabIndex = 35;
            // 
            // pic03
            // 
            pic03.BackColor = Color.White;
            pic03.Image = (Image)resources.GetObject("pic03.Image");
            pic03.Location = new Point(1206, 18);
            pic03.Name = "pic03";
            pic03.Size = new Size(46, 46);
            pic03.SizeMode = PictureBoxSizeMode.Zoom;
            pic03.TabIndex = 22;
            pic03.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 176, 80);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1028, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(157, 47);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pnl03
            // 
            pnl03.BackColor = Color.White;
            pnl03.BorderStyle = BorderStyle.FixedSingle;
            pnl03.Controls.Add(cmb02);
            pnl03.Location = new Point(780, 20);
            pnl03.Name = "pnl03";
            pnl03.Padding = new Padding(10);
            pnl03.Size = new Size(218, 45);
            pnl03.TabIndex = 16;
            // 
            // cmb02
            // 
            cmb02.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb02.FlatStyle = FlatStyle.Flat;
            cmb02.FormattingEnabled = true;
            cmb02.Location = new Point(13, 9);
            cmb02.Name = "cmb02";
            cmb02.Size = new Size(190, 28);
            cmb02.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1206, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 47);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "   Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lbl04
            // 
            lbl04.AutoSize = true;
            lbl04.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl04.ForeColor = Color.Black;
            lbl04.ImageAlign = ContentAlignment.MiddleLeft;
            lbl04.Location = new Point(650, 30);
            lbl04.Name = "lbl04";
            lbl04.Size = new Size(124, 22);
            lbl04.TabIndex = 17;
            lbl04.Text = "Ordenar por:";
            lbl04.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl02
            // 
            pnl02.BackColor = Color.White;
            pnl02.BorderStyle = BorderStyle.FixedSingle;
            pnl02.Controls.Add(cmb01);
            pnl02.Location = new Point(414, 20);
            pnl02.Name = "pnl02";
            pnl02.Padding = new Padding(10);
            pnl02.Size = new Size(218, 45);
            pnl02.TabIndex = 15;
            // 
            // cmb01
            // 
            cmb01.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb01.FlatStyle = FlatStyle.Flat;
            cmb01.FormattingEnabled = true;
            cmb01.Location = new Point(13, 9);
            cmb01.Name = "cmb01";
            cmb01.Size = new Size(190, 28);
            cmb01.TabIndex = 14;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderColor = Color.LightGray;
            btn5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn5.Location = new Point(1262, 666);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 35);
            btn5.TabIndex = 20;
            btn5.Text = ">>";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderColor = Color.LightGray;
            btn1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn1.Location = new Point(1061, 666);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 35);
            btn1.TabIndex = 16;
            btn1.Text = "<<";
            btn1.UseVisualStyleBackColor = true;
            // 
            // lbl03
            // 
            lbl03.AutoSize = true;
            lbl03.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl03.ForeColor = Color.Black;
            lbl03.ImageAlign = ContentAlignment.MiddleLeft;
            lbl03.Location = new Point(330, 32);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(78, 22);
            lbl03.TabIndex = 15;
            lbl03.Text = "Estado:";
            lbl03.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderColor = Color.LightGray;
            btn4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn4.Location = new Point(1221, 666);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 35);
            btn4.TabIndex = 19;
            btn4.Text = ">";
            btn4.UseVisualStyleBackColor = true;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { clId, clNombreProveedor, clContacto, clTelefono, clCorreo, clEstado, clEditar, clEliminar });
            dgvProveedor.Location = new Point(11, 108);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(1352, 536);
            dgvProveedor.TabIndex = 15;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderColor = Color.LightGray;
            btn2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn2.Location = new Point(1102, 666);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 35);
            btn2.TabIndex = 17;
            btn2.Text = "<";
            btn2.UseVisualStyleBackColor = true;
            // 
            // pnl01
            // 
            pnl01.BackColor = Color.White;
            pnl01.BorderStyle = BorderStyle.FixedSingle;
            pnl01.Controls.Add(pic02);
            pnl01.Controls.Add(txt01);
            pnl01.Location = new Point(11, 20);
            pnl01.Name = "pnl01";
            pnl01.Padding = new Padding(10);
            pnl01.Size = new Size(290, 45);
            pnl01.TabIndex = 9;
            // 
            // pic02
            // 
            pic02.BackColor = Color.White;
            pic02.Image = (Image)resources.GetObject("pic02.Image");
            pic02.Location = new Point(-2, -1);
            pic02.Name = "pic02";
            pic02.Size = new Size(50, 45);
            pic02.SizeMode = PictureBoxSizeMode.Zoom;
            pic02.TabIndex = 23;
            pic02.TabStop = false;
            // 
            // txt01
            // 
            txt01.BorderStyle = BorderStyle.None;
            txt01.Font = new Font("Segoe UI", 10.8F);
            txt01.ForeColor = Color.Gray;
            txt01.Location = new Point(5, 9);
            txt01.Name = "txt01";
            txt01.PlaceholderText = "          Buscar producto";
            txt01.Size = new Size(270, 24);
            txt01.TabIndex = 7;
            // 
            // btn3
            // 
            btn3.BackColor = Color.RoyalBlue;
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(1161, 666);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 35);
            btn3.TabIndex = 18;
            btn3.Text = "1";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn_ctg1
            // 
            btn_ctg1.BackColor = Color.FromArgb(0, 102, 255);
            btn_ctg1.Cursor = Cursors.Hand;
            btn_ctg1.FlatStyle = FlatStyle.Flat;
            btn_ctg1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ctg1.ForeColor = Color.White;
            btn_ctg1.Image = (Image)resources.GetObject("btn_ctg1.Image");
            btn_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ctg1.Location = new Point(1129, 12);
            btn_ctg1.Name = "btn_ctg1";
            btn_ctg1.Size = new Size(248, 47);
            btn_ctg1.TabIndex = 34;
            btn_ctg1.Text = "Agregar proveedor";
            btn_ctg1.UseVisualStyleBackColor = false;
            // 
            // pic01
            // 
            pic01.Image = (Image)resources.GetObject("pic01.Image");
            pic01.Location = new Point(9, 9);
            pic01.Name = "pic01";
            pic01.Size = new Size(60, 50);
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
            lbl01.Location = new Point(69, 20);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(295, 29);
            lbl01.TabIndex = 32;
            lbl01.Text = "Gestión de proveedores";
            lbl01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgProveedor
            // 
            imgProveedor.ColorDepth = ColorDepth.Depth32Bit;
            imgProveedor.ImageStream = (ImageListStreamer)resources.GetObject("imgProveedor.ImageStream");
            imgProveedor.TransparentColor = Color.Transparent;
            imgProveedor.Images.SetKeyName(0, "edit.png");
            imgProveedor.Images.SetKeyName(1, "contenedor-de-basura.png");
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
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 889);
            Controls.Add(pnl_prov);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            pnl_prov.ResumeLayout(false);
            pnl_prov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbl02).EndInit();
            pnl04.ResumeLayout(false);
            pnl04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic03).EndInit();
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
        private PictureBox pic03;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Panel pnl03;
        private ComboBox cmb02;
        private Label lbl04;
        private Panel pnl02;
        private ComboBox cmb01;
        private Button btn5;
        private Button btn1;
        private Label lbl03;
        private Button btn4;
        private DataGridView dgvProveedor;
        private Button btn2;
        private Panel pnl01;
        private PictureBox pic02;
        private TextBox txt01;
        private Button btn3;
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