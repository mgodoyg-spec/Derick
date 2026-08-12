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
            lbl_prm3 = new Label();
            pn1 = new Panel();
            pic_prm2 = new PictureBox();
            txt_busqPrm = new TextBox();
            pn3 = new Panel();
            cmbP2 = new ComboBox();
            btn_limpP = new Button();
            lbl_prm4 = new Label();
            pn2 = new Panel();
            cmbP = new ComboBox();
            btn_busP = new Button();
            btn_aggP = new Button();
            lblry = new PictureBox();
            pic_prm = new PictureBox();
            lbl_prm1 = new Label();
            img_promociones = new ImageList(components);
            pnl_prm.SuspendLayout();
            pnl_prm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_prm2).BeginInit();
            pn3.SuspendLayout();
            pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_prm).BeginInit();
            SuspendLayout();
            // 
            // pnl_prm
            // 
            pnl_prm.BackColor = Color.FromArgb(244, 246, 249);
            pnl_prm.Controls.Add(pnl_prm2);
            pnl_prm.Controls.Add(btn_aggP);
            pnl_prm.Controls.Add(lblry);
            pnl_prm.Controls.Add(pic_prm);
            pnl_prm.Controls.Add(lbl_prm1);
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
            pnl_prm2.Controls.Add(dgvPromociones);
            pnl_prm2.Controls.Add(lbl_prm3);
            pnl_prm2.Controls.Add(pn1);
            pnl_prm2.Controls.Add(pn3);
            pnl_prm2.Controls.Add(btn_limpP);
            pnl_prm2.Controls.Add(lbl_prm4);
            pnl_prm2.Controls.Add(pn2);
            pnl_prm2.Controls.Add(btn_busP);
            pnl_prm2.Location = new Point(10, 50);
            pnl_prm2.Margin = new Padding(3, 2, 3, 2);
            pnl_prm2.Name = "pnl_prm2";
            pnl_prm2.Size = new Size(1164, 599);
            pnl_prm2.TabIndex = 36;
            // 
            // dgvPromociones
            // 
            dgvPromociones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPromociones.BackgroundColor = Color.White;
            dgvPromociones.BorderStyle = BorderStyle.None;
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Columns.AddRange(new DataGridViewColumn[] { clId, clNombrePromocion, clTipo, clDescuento, clFechaInicio, clFechaFin, clEstado, clDescripcion, clEditar, clEliminar });
            dgvPromociones.Location = new Point(10, 81);
            dgvPromociones.Margin = new Padding(3, 2, 3, 2);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.RowHeadersWidth = 51;
            dgvPromociones.Size = new Size(1140, 500);
            dgvPromociones.TabIndex = 31;
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
            // lbl_prm3
            // 
            lbl_prm3.AutoSize = true;
            lbl_prm3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_prm3.ForeColor = Color.Black;
            lbl_prm3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prm3.Location = new Point(235, 23);
            lbl_prm3.Name = "lbl_prm3";
            lbl_prm3.Size = new Size(155, 18);
            lbl_prm3.TabIndex = 26;
            lbl_prm3.Text = "Tipo de promoción:";
            lbl_prm3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pn1
            // 
            pn1.BackColor = Color.White;
            pn1.BorderStyle = BorderStyle.FixedSingle;
            pn1.Controls.Add(pic_prm2);
            pn1.Controls.Add(txt_busqPrm);
            pn1.Location = new Point(10, 15);
            pn1.Margin = new Padding(3, 2, 3, 2);
            pn1.Name = "pn1";
            pn1.Padding = new Padding(9, 8, 9, 8);
            pn1.Size = new Size(219, 34);
            pn1.TabIndex = 24;
            // 
            // pic_prm2
            // 
            pic_prm2.BackColor = Color.White;
            pic_prm2.Image = (Image)resources.GetObject("pic_prm2.Image");
            pic_prm2.Location = new Point(-2, -1);
            pic_prm2.Margin = new Padding(3, 2, 3, 2);
            pic_prm2.Name = "pic_prm2";
            pic_prm2.Size = new Size(44, 34);
            pic_prm2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_prm2.TabIndex = 23;
            pic_prm2.TabStop = false;
            // 
            // txt_busqPrm
            // 
            txt_busqPrm.BorderStyle = BorderStyle.None;
            txt_busqPrm.Font = new Font("Segoe UI", 10.8F);
            txt_busqPrm.ForeColor = Color.Gray;
            txt_busqPrm.Location = new Point(39, 7);
            txt_busqPrm.Margin = new Padding(3, 2, 3, 2);
            txt_busqPrm.Name = "txt_busqPrm";
            txt_busqPrm.PlaceholderText = "          Buscar producto";
            txt_busqPrm.Size = new Size(176, 20);
            txt_busqPrm.TabIndex = 7;
            // 
            // pn3
            // 
            pn3.BackColor = Color.White;
            pn3.BorderStyle = BorderStyle.FixedSingle;
            pn3.Controls.Add(cmbP2);
            pn3.Location = new Point(620, 16);
            pn3.Margin = new Padding(3, 2, 3, 2);
            pn3.Name = "pn3";
            pn3.Padding = new Padding(9, 8, 9, 8);
            pn3.Size = new Size(137, 34);
            pn3.TabIndex = 27;
            // 
            // cmbP2
            // 
            cmbP2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP2.FlatStyle = FlatStyle.Flat;
            cmbP2.FormattingEnabled = true;
            cmbP2.Location = new Point(11, 7);
            cmbP2.Margin = new Padding(3, 2, 3, 2);
            cmbP2.Name = "cmbP2";
            cmbP2.Size = new Size(114, 23);
            cmbP2.TabIndex = 14;
            // 
            // btn_limpP
            // 
            btn_limpP.BackColor = Color.White;
            btn_limpP.Cursor = Cursors.Hand;
            btn_limpP.FlatStyle = FlatStyle.Flat;
            btn_limpP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_limpP.ForeColor = Color.Black;
            btn_limpP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpP.Location = new Point(1022, 16);
            btn_limpP.Margin = new Padding(3, 2, 3, 2);
            btn_limpP.Name = "btn_limpP";
            btn_limpP.Size = new Size(128, 37);
            btn_limpP.TabIndex = 29;
            btn_limpP.Text = "Limpiar";
            btn_limpP.UseVisualStyleBackColor = false;
            btn_limpP.Click += btn_limpP_Click;
            // 
            // lbl_prm4
            // 
            lbl_prm4.AutoSize = true;
            lbl_prm4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_prm4.ForeColor = Color.Black;
            lbl_prm4.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prm4.Location = new Point(548, 25);
            lbl_prm4.Name = "lbl_prm4";
            lbl_prm4.Size = new Size(66, 18);
            lbl_prm4.TabIndex = 28;
            lbl_prm4.Text = "Estado:";
            lbl_prm4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pn2
            // 
            pn2.BackColor = Color.White;
            pn2.BorderStyle = BorderStyle.FixedSingle;
            pn2.Controls.Add(cmbP);
            pn2.Location = new Point(396, 13);
            pn2.Margin = new Padding(3, 2, 3, 2);
            pn2.Name = "pn2";
            pn2.Padding = new Padding(9, 8, 9, 8);
            pn2.Size = new Size(146, 34);
            pn2.TabIndex = 25;
            // 
            // cmbP
            // 
            cmbP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP.FlatStyle = FlatStyle.Flat;
            cmbP.FormattingEnabled = true;
            cmbP.Location = new Point(11, 7);
            cmbP.Margin = new Padding(3, 2, 3, 2);
            cmbP.Name = "cmbP";
            cmbP.Size = new Size(121, 23);
            cmbP.TabIndex = 14;
            // 
            // btn_busP
            // 
            btn_busP.BackColor = Color.FromArgb(0, 176, 80);
            btn_busP.Cursor = Cursors.Hand;
            btn_busP.FlatStyle = FlatStyle.Flat;
            btn_busP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_busP.ForeColor = Color.White;
            btn_busP.Image = (Image)resources.GetObject("btn_busP.Image");
            btn_busP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_busP.Location = new Point(879, 15);
            btn_busP.Margin = new Padding(3, 2, 3, 2);
            btn_busP.Name = "btn_busP";
            btn_busP.Size = new Size(128, 37);
            btn_busP.TabIndex = 23;
            btn_busP.Text = "     Buscar";
            btn_busP.UseVisualStyleBackColor = false;
            btn_busP.Click += btn_busP_Click;
            // 
            // btn_aggP
            // 
            btn_aggP.BackColor = Color.FromArgb(0, 102, 255);
            btn_aggP.Cursor = Cursors.Hand;
            btn_aggP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_aggP.ForeColor = Color.White;
            btn_aggP.Image = (Image)resources.GetObject("btn_aggP.Image");
            btn_aggP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_aggP.Location = new Point(957, 8);
            btn_aggP.Margin = new Padding(3, 2, 3, 2);
            btn_aggP.Name = "btn_aggP";
            btn_aggP.Size = new Size(217, 38);
            btn_aggP.TabIndex = 35;
            btn_aggP.Text = "      Agregar promoción";
            btn_aggP.UseVisualStyleBackColor = false;
            btn_aggP.Click += btn_aggP_Click;
            // 
            // lblry
            // 
            lblry.BackColor = Color.FromArgb(0, 176, 80);
            lblry.Location = new Point(66, 40);
            lblry.Margin = new Padding(3, 2, 3, 2);
            lblry.Name = "lblry";
            lblry.Size = new Size(248, 3);
            lblry.TabIndex = 34;
            lblry.TabStop = false;
            // 
            // pic_prm
            // 
            pic_prm.Image = (Image)resources.GetObject("pic_prm.Image");
            pic_prm.Location = new Point(8, 8);
            pic_prm.Margin = new Padding(3, 2, 3, 2);
            pic_prm.Name = "pic_prm";
            pic_prm.Size = new Size(52, 38);
            pic_prm.SizeMode = PictureBoxSizeMode.Zoom;
            pic_prm.TabIndex = 33;
            pic_prm.TabStop = false;
            // 
            // lbl_prm1
            // 
            lbl_prm1.AutoSize = true;
            lbl_prm1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_prm1.ForeColor = Color.FromArgb(0, 176, 80);
            lbl_prm1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prm1.Location = new Point(60, 16);
            lbl_prm1.Name = "lbl_prm1";
            lbl_prm1.Size = new Size(239, 24);
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
            pnl_prm.PerformLayout();
            pnl_prm2.ResumeLayout(false);
            pnl_prm2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            pn1.ResumeLayout(false);
            pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_prm2).EndInit();
            pn3.ResumeLayout(false);
            pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lblry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_prm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_prm;
        private Button btn_aggP;
        private PictureBox lblry;
        private PictureBox pic_prm;
        private Label lbl_prm1;
        private Panel pnl_prm2;
        private DataGridView dgvPromociones;
        private Label lbl_prm3;
        private Button btn_limpP;
        private Panel pn1;
        private PictureBox pic_prm2;
        private TextBox txt_busqPrm;
        private Button btn_busP;
        private Panel pn2;
        private ComboBox cmbP;
        private Panel pn3;
        private ComboBox cmbP2;
        private Label lbl_prm4;
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
    }
}