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
            btn_ctg1 = new Button();
            pnl_cont1 = new Panel();
            dgv_catg = new DataGridView();
            clID = new DataGridViewTextBoxColumn();
            clIcono = new DataGridViewImageColumn();
            clCategoria = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clDescripcion = new DataGridViewTextBoxColumn();
            clEditar = new DataGridViewImageColumn();
            clEliminar = new DataGridViewImageColumn();
            lbl_ctg3 = new Label();
            btn_limp1 = new Button();
            pnl_ctg2 = new Panel();
            pic_ctg2 = new PictureBox();
            txt_busqctg = new TextBox();
            pnl_ctg3 = new Panel();
            cmb_ctg1 = new ComboBox();
            pnl_ctg4 = new Panel();
            cmb_ctg2 = new ComboBox();
            btn_bus1 = new Button();
            lbl_agg3 = new Label();
            lbl_ry = new PictureBox();
            pic_ctg1 = new PictureBox();
            lbl_ctg1 = new Label();
            img_ctg = new ImageList(components);
            pnl_ctg1.SuspendLayout();
            pnl_cont1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_catg).BeginInit();
            pnl_ctg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ctg2).BeginInit();
            pnl_ctg3.SuspendLayout();
            pnl_ctg4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbl_ry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_ctg1).BeginInit();
            SuspendLayout();
            // 
            // pnl_ctg1
            // 
            pnl_ctg1.BackColor = Color.FromArgb(244, 246, 249);
            pnl_ctg1.Controls.Add(btn_ctg1);
            pnl_ctg1.Controls.Add(pnl_cont1);
            pnl_ctg1.Controls.Add(lbl_ry);
            pnl_ctg1.Controls.Add(pic_ctg1);
            pnl_ctg1.Controls.Add(lbl_ctg1);
            pnl_ctg1.Dock = DockStyle.Fill;
            pnl_ctg1.Location = new Point(0, 0);
            pnl_ctg1.Margin = new Padding(3, 2, 3, 2);
            pnl_ctg1.Name = "pnl_ctg1";
            pnl_ctg1.Size = new Size(1186, 651);
            pnl_ctg1.TabIndex = 0;
            // 
            // btn_ctg1
            // 
            btn_ctg1.BackColor = Color.FromArgb(0, 102, 255);
            btn_ctg1.Cursor = Cursors.Hand;
            btn_ctg1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ctg1.ForeColor = Color.White;
            btn_ctg1.Image = (Image)resources.GetObject("btn_ctg1.Image");
            btn_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ctg1.Location = new Point(957, 9);
            btn_ctg1.Margin = new Padding(3, 2, 3, 2);
            btn_ctg1.Name = "btn_ctg1";
            btn_ctg1.Size = new Size(217, 38);
            btn_ctg1.TabIndex = 31;
            btn_ctg1.Text = "Agregar categoría";
            btn_ctg1.UseVisualStyleBackColor = false;
            btn_ctg1.Click += btn_ctg1_Click;
            // 
            // pnl_cont1
            // 
            pnl_cont1.BackColor = Color.White;
            pnl_cont1.Controls.Add(dgv_catg);
            pnl_cont1.Controls.Add(lbl_ctg3);
            pnl_cont1.Controls.Add(btn_limp1);
            pnl_cont1.Controls.Add(pnl_ctg2);
            pnl_cont1.Controls.Add(pnl_ctg3);
            pnl_cont1.Controls.Add(pnl_ctg4);
            pnl_cont1.Controls.Add(btn_bus1);
            pnl_cont1.Controls.Add(lbl_agg3);
            pnl_cont1.Location = new Point(10, 58);
            pnl_cont1.Margin = new Padding(3, 2, 3, 2);
            pnl_cont1.Name = "pnl_cont1";
            pnl_cont1.Size = new Size(1164, 582);
            pnl_cont1.TabIndex = 11;
            // 
            // dgv_catg
            // 
            dgv_catg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_catg.BackgroundColor = Color.White;
            dgv_catg.BorderStyle = BorderStyle.None;
            dgv_catg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_catg.Columns.AddRange(new DataGridViewColumn[] { clID, clIcono, clCategoria, clEstado, clDescripcion, clEditar, clEliminar });
            dgv_catg.Location = new Point(10, 81);
            dgv_catg.Margin = new Padding(3, 2, 3, 2);
            dgv_catg.Name = "dgv_catg";
            dgv_catg.RowHeadersWidth = 51;
            dgv_catg.Size = new Size(1143, 488);
            dgv_catg.TabIndex = 31;
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
            // lbl_ctg3
            // 
            lbl_ctg3.AutoSize = true;
            lbl_ctg3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ctg3.ForeColor = Color.Black;
            lbl_ctg3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_ctg3.Location = new Point(270, 24);
            lbl_ctg3.Name = "lbl_ctg3";
            lbl_ctg3.Size = new Size(86, 18);
            lbl_ctg3.TabIndex = 26;
            lbl_ctg3.Text = "Categoría:";
            lbl_ctg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_limp1
            // 
            btn_limp1.BackColor = Color.White;
            btn_limp1.Cursor = Cursors.Hand;
            btn_limp1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_limp1.ForeColor = Color.Black;
            btn_limp1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limp1.Location = new Point(1025, 12);
            btn_limp1.Margin = new Padding(3, 2, 3, 2);
            btn_limp1.Name = "btn_limp1";
            btn_limp1.Size = new Size(128, 37);
            btn_limp1.TabIndex = 29;
            btn_limp1.Text = "Limpiar";
            btn_limp1.UseVisualStyleBackColor = false;
            btn_limp1.Click += btn_limp1_Click;
            // 
            // pnl_ctg2
            // 
            pnl_ctg2.BackColor = Color.White;
            pnl_ctg2.BorderStyle = BorderStyle.FixedSingle;
            pnl_ctg2.Controls.Add(pic_ctg2);
            pnl_ctg2.Controls.Add(txt_busqctg);
            pnl_ctg2.Location = new Point(10, 15);
            pnl_ctg2.Margin = new Padding(3, 2, 3, 2);
            pnl_ctg2.Name = "pnl_ctg2";
            pnl_ctg2.Padding = new Padding(9, 8, 9, 8);
            pnl_ctg2.Size = new Size(254, 34);
            pnl_ctg2.TabIndex = 24;
            // 
            // pic_ctg2
            // 
            pic_ctg2.BackColor = Color.White;
            pic_ctg2.Image = (Image)resources.GetObject("pic_ctg2.Image");
            pic_ctg2.Location = new Point(-2, -1);
            pic_ctg2.Margin = new Padding(3, 2, 3, 2);
            pic_ctg2.Name = "pic_ctg2";
            pic_ctg2.Size = new Size(44, 34);
            pic_ctg2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ctg2.TabIndex = 23;
            pic_ctg2.TabStop = false;
            // 
            // txt_busqctg
            // 
            txt_busqctg.BorderStyle = BorderStyle.None;
            txt_busqctg.Font = new Font("Segoe UI", 10.8F);
            txt_busqctg.ForeColor = Color.Gray;
            txt_busqctg.Location = new Point(48, 7);
            txt_busqctg.Margin = new Padding(3, 2, 3, 2);
            txt_busqctg.Name = "txt_busqctg";
            txt_busqctg.PlaceholderText = "          Buscar producto";
            txt_busqctg.Size = new Size(192, 20);
            txt_busqctg.TabIndex = 7;
            // 
            // pnl_ctg3
            // 
            pnl_ctg3.BackColor = Color.White;
            pnl_ctg3.BorderStyle = BorderStyle.FixedSingle;
            pnl_ctg3.Controls.Add(cmb_ctg1);
            pnl_ctg3.Location = new Point(365, 15);
            pnl_ctg3.Margin = new Padding(3, 2, 3, 2);
            pnl_ctg3.Name = "pnl_ctg3";
            pnl_ctg3.Padding = new Padding(9, 8, 9, 8);
            pnl_ctg3.Size = new Size(135, 34);
            pnl_ctg3.TabIndex = 25;
            // 
            // cmb_ctg1
            // 
            cmb_ctg1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ctg1.FlatStyle = FlatStyle.Flat;
            cmb_ctg1.FormattingEnabled = true;
            cmb_ctg1.Location = new Point(11, 7);
            cmb_ctg1.Margin = new Padding(3, 2, 3, 2);
            cmb_ctg1.Name = "cmb_ctg1";
            cmb_ctg1.Size = new Size(111, 23);
            cmb_ctg1.TabIndex = 14;
            // 
            // pnl_ctg4
            // 
            pnl_ctg4.BackColor = Color.White;
            pnl_ctg4.BorderStyle = BorderStyle.FixedSingle;
            pnl_ctg4.Controls.Add(cmb_ctg2);
            pnl_ctg4.Location = new Point(589, 15);
            pnl_ctg4.Margin = new Padding(3, 2, 3, 2);
            pnl_ctg4.Name = "pnl_ctg4";
            pnl_ctg4.Padding = new Padding(9, 8, 9, 8);
            pnl_ctg4.Size = new Size(130, 34);
            pnl_ctg4.TabIndex = 27;
            // 
            // cmb_ctg2
            // 
            cmb_ctg2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ctg2.FlatStyle = FlatStyle.Flat;
            cmb_ctg2.FormattingEnabled = true;
            cmb_ctg2.Location = new Point(11, 7);
            cmb_ctg2.Margin = new Padding(3, 2, 3, 2);
            cmb_ctg2.Name = "cmb_ctg2";
            cmb_ctg2.Size = new Size(107, 23);
            cmb_ctg2.TabIndex = 14;
            // 
            // btn_bus1
            // 
            btn_bus1.BackColor = Color.FromArgb(13, 154, 64);
            btn_bus1.Cursor = Cursors.Hand;
            btn_bus1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bus1.ForeColor = Color.White;
            btn_bus1.Image = (Image)resources.GetObject("btn_bus1.Image");
            btn_bus1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bus1.Location = new Point(878, 12);
            btn_bus1.Margin = new Padding(3, 2, 3, 2);
            btn_bus1.Name = "btn_bus1";
            btn_bus1.Size = new Size(128, 37);
            btn_bus1.TabIndex = 23;
            btn_bus1.Text = "Buscar";
            btn_bus1.UseVisualStyleBackColor = false;
            btn_bus1.Click += btn_bus1_Click;
            // 
            // lbl_agg3
            // 
            lbl_agg3.AutoSize = true;
            lbl_agg3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agg3.ForeColor = Color.Black;
            lbl_agg3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_agg3.Location = new Point(515, 27);
            lbl_agg3.Name = "lbl_agg3";
            lbl_agg3.Size = new Size(66, 18);
            lbl_agg3.TabIndex = 28;
            lbl_agg3.Text = "Estado:";
            lbl_agg3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_ry
            // 
            lbl_ry.BackColor = Color.FromArgb(13, 154, 64);
            lbl_ry.Location = new Point(68, 41);
            lbl_ry.Margin = new Padding(3, 2, 3, 2);
            lbl_ry.Name = "lbl_ry";
            lbl_ry.Size = new Size(225, 3);
            lbl_ry.TabIndex = 10;
            lbl_ry.TabStop = false;
            // 
            // pic_ctg1
            // 
            pic_ctg1.Image = (Image)resources.GetObject("pic_ctg1.Image");
            pic_ctg1.Location = new Point(10, 9);
            pic_ctg1.Margin = new Padding(3, 2, 3, 2);
            pic_ctg1.Name = "pic_ctg1";
            pic_ctg1.Size = new Size(52, 38);
            pic_ctg1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ctg1.TabIndex = 9;
            pic_ctg1.TabStop = false;
            // 
            // lbl_ctg1
            // 
            lbl_ctg1.AutoSize = true;
            lbl_ctg1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ctg1.ForeColor = Color.FromArgb(13, 154, 64);
            lbl_ctg1.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_ctg1.Location = new Point(63, 17);
            lbl_ctg1.Name = "lbl_ctg1";
            lbl_ctg1.Size = new Size(213, 24);
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
            pnl_ctg1.PerformLayout();
            pnl_cont1.ResumeLayout(false);
            pnl_cont1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_catg).EndInit();
            pnl_ctg2.ResumeLayout(false);
            pnl_ctg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ctg2).EndInit();
            pnl_ctg3.ResumeLayout(false);
            pnl_ctg4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lbl_ry).EndInit();
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
        private PictureBox lbl_ry;
        private PictureBox pic_ctg1;
        private Label lbl_ctg1;
        private Panel pnl_cont1;
        private Label lbl_ctg3;
        private Button btn_limp1;
        private Panel pnl_ctg2;
        private PictureBox pic_ctg2;
        private TextBox txt_busqctg;
        private Button btn_bus1;
        private Panel pnl_ctg3;
        private ComboBox cmb_ctg1;
        private Panel pnl_ctg4;
        private ComboBox cmb_ctg2;
        private Label lbl_agg3;
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
    }
}