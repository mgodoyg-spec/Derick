namespace Derick
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            pnl_ctg1 = new Panel();
            pnl_cont1 = new Panel();
            pnlBusqueda = new Panel();
            cmb_ctg1 = new ComboBox();
            cmb_ctg2 = new ComboBox();
            txt_busqctg = new TextBox();
            pictureBox1 = new PictureBox();
            lbl_agg2 = new Label();
            label1 = new Label();
            btn_bus1 = new Button();
            btn_limp1 = new Button();
            pictureBox2 = new PictureBox();
            btn_ctg1 = new Button();
            dgv_catg = new DataGridView();
            clID = new DataGridViewTextBoxColumn();
            clIcono = new DataGridViewImageColumn();
            clCategoria = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clDescripcion = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            pic_ctg1 = new PictureBox();
            lbl_ctg1 = new Label();
            img_ctg = new ImageList(components);
            lblSalirV = new Label();
            pnl_ctg1.SuspendLayout();
            pnl_cont1.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_catg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_ctg1).BeginInit();
            SuspendLayout();
            // 
            // pnl_ctg1
            // 
            pnl_ctg1.BackColor = Color.FromArgb(244, 246, 249);
            pnl_ctg1.Controls.Add(pnl_cont1);
            pnl_ctg1.Dock = DockStyle.Fill;
            pnl_ctg1.Location = new Point(0, 0);
            pnl_ctg1.Margin = new Padding(3, 2, 3, 2);
            pnl_ctg1.Name = "pnl_ctg1";
            pnl_ctg1.Size = new Size(1186, 651);
            pnl_ctg1.TabIndex = 0;
            // 
            // pnl_cont1
            // 
            pnl_cont1.BackColor = Color.White;
            pnl_cont1.Controls.Add(lblSalirV);
            pnl_cont1.Controls.Add(pnlBusqueda);
            pnl_cont1.Controls.Add(pictureBox2);
            pnl_cont1.Controls.Add(btn_ctg1);
            pnl_cont1.Controls.Add(dgv_catg);
            pnl_cont1.Controls.Add(pic_ctg1);
            pnl_cont1.Controls.Add(lbl_ctg1);
            pnl_cont1.Location = new Point(13, 13);
            pnl_cont1.Margin = new Padding(3, 2, 3, 2);
            pnl_cont1.Name = "pnl_cont1";
            pnl_cont1.Size = new Size(1150, 630);
            pnl_cont1.TabIndex = 11;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(244, 246, 249);
            pnlBusqueda.Controls.Add(cmb_ctg1);
            pnlBusqueda.Controls.Add(cmb_ctg2);
            pnlBusqueda.Controls.Add(txt_busqctg);
            pnlBusqueda.Controls.Add(pictureBox1);
            pnlBusqueda.Controls.Add(lbl_agg2);
            pnlBusqueda.Controls.Add(label1);
            pnlBusqueda.Controls.Add(btn_bus1);
            pnlBusqueda.Controls.Add(btn_limp1);
            pnlBusqueda.Location = new Point(7, 45);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1129, 43);
            pnlBusqueda.TabIndex = 33;
            // 
            // cmb_ctg1
            // 
            cmb_ctg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ctg1.Font = new Font("Calibri", 14.25F);
            cmb_ctg1.FormattingEnabled = true;
            cmb_ctg1.Location = new Point(440, 7);
            cmb_ctg1.Margin = new Padding(3, 2, 3, 2);
            cmb_ctg1.Name = "cmb_ctg1";
            cmb_ctg1.Size = new Size(121, 31);
            cmb_ctg1.TabIndex = 14;
            // 
            // cmb_ctg2
            // 
            cmb_ctg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ctg2.Font = new Font("Calibri", 14.25F);
            cmb_ctg2.FormattingEnabled = true;
            cmb_ctg2.Location = new Point(625, 6);
            cmb_ctg2.Margin = new Padding(3, 2, 3, 2);
            cmb_ctg2.Name = "cmb_ctg2";
            cmb_ctg2.Size = new Size(121, 31);
            cmb_ctg2.TabIndex = 14;
            // 
            // txt_busqctg
            // 
            txt_busqctg.Font = new Font("Calibri", 12F);
            txt_busqctg.ForeColor = Color.Gray;
            txt_busqctg.Location = new Point(49, 9);
            txt_busqctg.Margin = new Padding(3, 2, 3, 2);
            txt_busqctg.Name = "txt_busqctg";
            txt_busqctg.PlaceholderText = "Buscar producto";
            txt_busqctg.Size = new Size(307, 27);
            txt_busqctg.TabIndex = 7;
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
            // btn_bus1
            // 
            btn_bus1.BackColor = Color.FromArgb(13, 154, 64);
            btn_bus1.Cursor = Cursors.Hand;
            btn_bus1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_bus1.ForeColor = Color.White;
            btn_bus1.Image = (Image)resources.GetObject("btn_bus1.Image");
            btn_bus1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bus1.Location = new Point(771, 4);
            btn_bus1.Margin = new Padding(3, 2, 3, 2);
            btn_bus1.Name = "btn_bus1";
            btn_bus1.Size = new Size(99, 33);
            btn_bus1.TabIndex = 23;
            btn_bus1.Text = "     Buscar";
            btn_bus1.UseVisualStyleBackColor = false;
            btn_bus1.Click += btn_bus1_Click;
            // 
            // btn_limp1
            // 
            btn_limp1.BackColor = Color.White;
            btn_limp1.Cursor = Cursors.Hand;
            btn_limp1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_limp1.ForeColor = Color.Black;
            btn_limp1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limp1.Location = new Point(889, 7);
            btn_limp1.Margin = new Padding(3, 2, 3, 2);
            btn_limp1.Name = "btn_limp1";
            btn_limp1.Size = new Size(98, 28);
            btn_limp1.TabIndex = 29;
            btn_limp1.Text = "Limpiar";
            btn_limp1.UseVisualStyleBackColor = false;
            btn_limp1.Click += btn_limp1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.detalleverde;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 14);
            pictureBox2.TabIndex = 32;
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
            btn_ctg1.Location = new Point(884, 2);
            btn_ctg1.Margin = new Padding(3, 2, 3, 2);
            btn_ctg1.Name = "btn_ctg1";
            btn_ctg1.Size = new Size(223, 39);
            btn_ctg1.TabIndex = 31;
            btn_ctg1.Text = "Agregar categoría";
            btn_ctg1.UseVisualStyleBackColor = false;
            btn_ctg1.Click += btn_ctg1_Click;
            // 
            // dgv_catg
            // 
            dgv_catg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_catg.BackgroundColor = Color.White;
            dgv_catg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_catg.Columns.AddRange(new DataGridViewColumn[] { clID, clIcono, clCategoria, clEstado, clDescripcion, clEditar, clEliminar });
            dgv_catg.Location = new Point(7, 94);
            dgv_catg.Margin = new Padding(3, 2, 3, 2);
            dgv_catg.Name = "dgv_catg";
            dgv_catg.RowHeadersWidth = 51;
            dgv_catg.Size = new Size(1126, 510);
            dgv_catg.TabIndex = 31;
            dgv_catg.CellClick += dgv_catg_CellClick;
            // 
            // clID
            // 
            clID.HeaderText = "ID";
            clID.MinimumWidth = 6;
            clID.Name = "clID";
            clID.Width = 125;
            // 
            // clIcono
            // 
            clIcono.HeaderText = "Ícono";
            clIcono.MinimumWidth = 6;
            clIcono.Name = "clIcono";
            clIcono.Resizable = DataGridViewTriState.True;
            clIcono.SortMode = DataGridViewColumnSortMode.Automatic;
            clIcono.Width = 125;
            // 
            // clCategoria
            // 
            clCategoria.HeaderText = "Categoría";
            clCategoria.MinimumWidth = 6;
            clCategoria.Name = "clCategoria";
            clCategoria.Width = 125;
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
            // pic_ctg1
            // 
            pic_ctg1.Image = (Image)resources.GetObject("pic_ctg1.Image");
            pic_ctg1.Location = new Point(7, 0);
            pic_ctg1.Margin = new Padding(3, 2, 3, 2);
            pic_ctg1.Name = "pic_ctg1";
            pic_ctg1.Size = new Size(43, 38);
            pic_ctg1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ctg1.TabIndex = 9;
            pic_ctg1.TabStop = false;
            // 
            // lbl_ctg1
            // 
            lbl_ctg1.AutoSize = true;
            lbl_ctg1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            lbl_ctg1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_ctg1.Location = new Point(56, 0);
            lbl_ctg1.Name = "lbl_ctg1";
            lbl_ctg1.Size = new Size(198, 26);
            lbl_ctg1.TabIndex = 8;
            lbl_ctg1.Text = "Gestión de categorías";
            lbl_ctg1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // img_ctg
            // 
            img_ctg.ColorDepth = ColorDepth.Depth32Bit;
            img_ctg.ImageStream = (ImageListStreamer)resources.GetObject("img_ctg.ImageStream");
            img_ctg.TransparentColor = Color.Transparent;
            img_ctg.Images.SetKeyName(0, "eliminar1.png");
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
            lblSalirV.TabIndex = 34;
            lblSalirV.Text = "X";
            lblSalirV.Click += lblSalirV_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 651);
            Controls.Add(pnl_ctg1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCategoria";
            Text = "FormBusc_Product";
            Load += FormCategoria_Load;
            pnl_ctg1.ResumeLayout(false);
            pnl_cont1.ResumeLayout(false);
            pnl_cont1.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_catg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_ctg1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_ctg1;
        private ComboBox cmb_agg5;
        private Button btn5_agg5;
        private Button btn4_agg4;
        private Button btn3_agg3;
        private Button btn2_agg2;
        private PictureBox pic_ctg1;
        private Label lbl_ctg1;
        private Panel pnl_cont1;
        private Button btn_limp1;
        private TextBox txt_busqctg;
        private Button btn_bus1;
        private ComboBox cmb_ctg1;
        private ComboBox cmb_ctg2;
        private Button btn_ctg1;
        private DataGridView dgv_catg;
        private ImageList img_ctg;
        private DataGridViewTextBoxColumn clID;
        private DataGridViewImageColumn clIcono;
        private DataGridViewTextBoxColumn clCategoria;
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