namespace Derick
{
    partial class FormPromociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromociones));
            pnl_prm = new Panel();
            pnl_prm2 = new Panel();
            pnlBusqueda = new Panel();
            cmbP2 = new ComboBox();
            txt_busqPrm = new TextBox();
            cmbP = new ComboBox();
            pictureBox1 = new PictureBox();
            lbl_agg2 = new Label();
            label1 = new Label();
            btn_busP = new Button();
            btn_limpP = new Button();
            pictureBox2 = new PictureBox();
            dgvPromociones = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombrePromocion = new DataGridViewTextBoxColumn();
            clTipo = new DataGridViewTextBoxColumn();
            clDescuento = new DataGridViewTextBoxColumn();
            clFechaInicio = new DataGridViewTextBoxColumn();
            clFechaFin = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clDescripcion = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            btn_aggP = new Button();
            pic_prm = new PictureBox();
            lbl_prm1 = new Label();
            img_promociones = new ImageList(components);
            lblSalirV = new Label();
            pnl_prm.SuspendLayout();
            pnl_prm2.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_prm).BeginInit();
            SuspendLayout();
            // 
            // pnl_prm
            // 
            pnl_prm.BackColor = Color.FromArgb(244, 246, 249);
            pnl_prm.Controls.Add(pnl_prm2);
            pnl_prm.Dock = DockStyle.Fill;
            pnl_prm.Location = new Point(0, 0);
            pnl_prm.Margin = new Padding(3, 2, 3, 2);
            pnl_prm.Name = "pnl_prm";
            pnl_prm.Size = new Size(1186, 651);
            pnl_prm.TabIndex = 0;
            // 
            // pnl_prm2
            // 
            pnl_prm2.BackColor = Color.White;
            pnl_prm2.Controls.Add(lblSalirV);
            pnl_prm2.Controls.Add(pnlBusqueda);
            pnl_prm2.Controls.Add(pictureBox2);
            pnl_prm2.Controls.Add(dgvPromociones);
            pnl_prm2.Controls.Add(btn_aggP);
            pnl_prm2.Controls.Add(pic_prm);
            pnl_prm2.Controls.Add(lbl_prm1);
            pnl_prm2.Location = new Point(13, 13);
            pnl_prm2.Margin = new Padding(3, 2, 3, 2);
            pnl_prm2.Name = "pnl_prm2";
            pnl_prm2.Size = new Size(1150, 630);
            pnl_prm2.TabIndex = 36;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(cmbP2);
            pnlBusqueda.Controls.Add(txt_busqPrm);
            pnlBusqueda.Controls.Add(cmbP);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Controls.Add(label1);
            pnlBusqueda.Controls.Add(btn_busP);
            pnlBusqueda.Controls.Add(btn_limpP);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 37;
            // 
            // cmbP2
            // 
            cmbP2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP2.Font = new Font("Calibri", 14.25F);
            cmbP2.FormattingEnabled = true;
            cmbP2.Location = new Point(625, 6);
            cmbP2.Margin = new Padding(3, 2, 3, 2);
            cmbP2.Name = "cmbP2";
            cmbP2.Size = new Size(114, 31);
            cmbP2.TabIndex = 14;
            // 
            // txt_busqPrm
            // 
            txt_busqPrm.Font = new Font("Calibri", 12F);
            txt_busqPrm.ForeColor = Color.Gray;
            txt_busqPrm.Location = new Point(49, 9);
            txt_busqPrm.Margin = new Padding(3, 2, 3, 2);
            txt_busqPrm.Name = "txt_busqPrm";
            txt_busqPrm.PlaceholderText = "Buscar producto";
            txt_busqPrm.Size = new Size(307, 27);
            txt_busqPrm.TabIndex = 7;
            // 
            // cmbP
            // 
            cmbP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP.Font = new Font("Calibri", 14.25F);
            cmbP.FormattingEnabled = true;
            cmbP.Location = new Point(440, 7);
            cmbP.Margin = new Padding(3, 2, 3, 2);
            cmbP.Name = "cmbP";
            cmbP.Size = new Size(121, 31);
            cmbP.TabIndex = 14;
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
            lbl_agg2.Size = new Size(78, 19);
            lbl_agg2.TabIndex = 15;
            lbl_agg2.Text = "Categoría:";
            lbl_agg2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(570, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 17;
            label1.Text = "Estado:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_busP
            // 
            btn_busP.BackColor = Color.FromArgb(13, 154, 64);
            btn_busP.Cursor = Cursors.Hand;
            btn_busP.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_busP.ForeColor = Color.White;
            btn_busP.Image = (Image)resources.GetObject("btn_busP.Image");
            btn_busP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_busP.Location = new Point(771, 4);
            btn_busP.Margin = new Padding(3, 2, 3, 2);
            btn_busP.Name = "btn_busP";
            btn_busP.Size = new Size(99, 33);
            btn_busP.TabIndex = 23;
            btn_busP.Text = "     Buscar";
            btn_busP.UseVisualStyleBackColor = false;
            btn_busP.Click += btn_busP_Click;
            // 
            // btn_limpP
            // 
            btn_limpP.BackColor = Color.White;
            btn_limpP.Cursor = Cursors.Hand;
            btn_limpP.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_limpP.ForeColor = Color.Black;
            btn_limpP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpP.Location = new Point(889, 7);
            btn_limpP.Margin = new Padding(3, 2, 3, 2);
            btn_limpP.Name = "btn_limpP";
            btn_limpP.Size = new Size(98, 27);
            btn_limpP.TabIndex = 29;
            btn_limpP.Text = "Limpiar";
            btn_limpP.UseVisualStyleBackColor = false;
            btn_limpP.Click += btn_limpP_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 14);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // dgvPromociones
            // 
            dgvPromociones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPromociones.BackgroundColor = Color.White;
            dgvPromociones.BorderStyle = BorderStyle.None;
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Columns.AddRange(new DataGridViewColumn[] { clId, clNombrePromocion, clTipo, clDescuento, clFechaInicio, clFechaFin, clEstado, clDescripcion, clEditar, clEliminar });
            dgvPromociones.Location = new Point(7, 94);
            dgvPromociones.Margin = new Padding(3, 2, 3, 2);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.RowHeadersWidth = 51;
            dgvPromociones.Size = new Size(1126, 510);
            dgvPromociones.TabIndex = 31;
            dgvPromociones.CellClick += dgvPromociones_CellClick;
            // 
            // clId
            // 
            clId.HeaderText = "ID";
            clId.MinimumWidth = 6;
            clId.Name = "clId";
            clId.Width = 125;
            // 
            // clNombrePromocion
            // 
            clNombrePromocion.HeaderText = "Promoción";
            clNombrePromocion.MinimumWidth = 6;
            clNombrePromocion.Name = "clNombrePromocion";
            clNombrePromocion.Width = 125;
            // 
            // clTipo
            // 
            clTipo.HeaderText = "Tipo";
            clTipo.MinimumWidth = 6;
            clTipo.Name = "clTipo";
            clTipo.Width = 125;
            // 
            // clDescuento
            // 
            clDescuento.HeaderText = "Descuento";
            clDescuento.MinimumWidth = 6;
            clDescuento.Name = "clDescuento";
            clDescuento.Width = 125;
            // 
            // clFechaInicio
            // 
            clFechaInicio.HeaderText = "Fecha inicio";
            clFechaInicio.MinimumWidth = 6;
            clFechaInicio.Name = "clFechaInicio";
            clFechaInicio.Width = 125;
            // 
            // clFechaFin
            // 
            clFechaFin.HeaderText = "Fecha fin";
            clFechaFin.MinimumWidth = 6;
            clFechaFin.Name = "clFechaFin";
            clFechaFin.Width = 125;
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            clEstado.Width = 125;
            // 
            // clDescripcion
            // 
            clDescripcion.HeaderText = "Descripción";
            clDescripcion.MinimumWidth = 6;
            clDescripcion.Name = "clDescripcion";
            clDescripcion.Width = 125;
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 6;
            clEditar.Name = "clEditar";
            clEditar.Width = 125;
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            clEliminar.Width = 125;
            // 
            // btn_aggP
            // 
            btn_aggP.BackColor = Color.FromArgb(4, 59, 186);
            btn_aggP.Cursor = Cursors.Hand;
            btn_aggP.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_aggP.ForeColor = Color.White;
            btn_aggP.Image = (Image)resources.GetObject("btn_aggP.Image");
            btn_aggP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_aggP.Location = new Point(893, 2);
            btn_aggP.Margin = new Padding(3, 2, 3, 2);
            btn_aggP.Name = "btn_aggP";
            btn_aggP.Size = new Size(223, 39);
            btn_aggP.TabIndex = 35;
            btn_aggP.Text = "      Agregar promoción";
            btn_aggP.UseVisualStyleBackColor = false;
            btn_aggP.Click += btn_aggP_Click;
            // 
            // pic_prm
            // 
            pic_prm.Image = (Image)resources.GetObject("pic_prm.Image");
            pic_prm.Location = new Point(7, 0);
            pic_prm.Margin = new Padding(3, 2, 3, 2);
            pic_prm.Name = "pic_prm";
            pic_prm.Size = new Size(43, 38);
            pic_prm.SizeMode = PictureBoxSizeMode.Zoom;
            pic_prm.TabIndex = 33;
            pic_prm.TabStop = false;
            // 
            // lbl_prm1
            // 
            lbl_prm1.AutoSize = true;
            lbl_prm1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl_prm1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl_prm1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prm1.Location = new Point(56, 0);
            lbl_prm1.Name = "lbl_prm1";
            lbl_prm1.Size = new Size(222, 26);
            lbl_prm1.TabIndex = 32;
            lbl_prm1.Text = "Gestión de promociones";
            lbl_prm1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // img_promociones
            // 
            img_promociones.ColorDepth = ColorDepth.Depth32Bit;
            img_promociones.ImageStream = (ImageListStreamer)resources.GetObject("img_promociones.ImageStream");
            img_promociones.TransparentColor = Color.Transparent;
            img_promociones.Images.SetKeyName(0, "eliminar1.png");
            // 
            // lblSalirV
            // 
            lblSalirV.AutoSize = true;
            lblSalirV.BackColor = Color.Transparent;
            lblSalirV.Cursor = Cursors.Hand;
            lblSalirV.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalirV.ForeColor = Color.Red;
            lblSalirV.Location = new Point(1122, 2);
            lblSalirV.Name = "lblSalirV";
            lblSalirV.Size = new Size(25, 24);
            lblSalirV.TabIndex = 38;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // FormPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_prm);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPromociones";
            Text = "FormPromociones";
            Load += FormPromociones_Load;
            pnl_prm.ResumeLayout(false);
            pnl_prm2.ResumeLayout(false);
            pnl_prm2.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_prm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_prm;
        private Button btn_aggP;
        private PictureBox pic_prm;
        private Label lbl_prm1;
        private Panel pnl_prm2;
        private DataGridView dgvPromociones;
        private Button btn_limpP;
        private TextBox txt_busqPrm;
        private Button btn_busP;
        private ComboBox cmbP;
        private ComboBox cmbP2;
        private ImageList img_promociones;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombrePromocion;
        private DataGridViewTextBoxColumn clTipo;
        private DataGridViewTextBoxColumn clDescuento;
        private DataGridViewTextBoxColumn clFechaInicio;
        private DataGridViewTextBoxColumn clFechaFin;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewTextBoxColumn clDescripcion;
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