namespace Derick
{
    partial class frmBuscarSucursal
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
            pbxBuscarSucursal = new PictureBox();
            pnlBusqueda = new Panel();
            lblBuscarSucursal = new Label();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            gmapSeleccionarUbi = new GMap.NET.WindowsForms.GMapControl();
            lblCoordenadas = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).BeginInit();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // pbxBuscarSucursal
            // 
            pbxBuscarSucursal.BackgroundImage = Properties.Resources.iconoBuscar;
            pbxBuscarSucursal.BackgroundImageLayout = ImageLayout.Zoom;
            pbxBuscarSucursal.Location = new Point(3, 3);
            pbxBuscarSucursal.Name = "pbxBuscarSucursal";
            pbxBuscarSucursal.Size = new Size(43, 39);
            pbxBuscarSucursal.TabIndex = 24;
            pbxBuscarSucursal.TabStop = false;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.Controls.Add(lblBuscarSucursal);
            pnlBusqueda.Controls.Add(pbxBuscarSucursal);
            pnlBusqueda.Location = new Point(12, 1);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(418, 51);
            pnlBusqueda.TabIndex = 5;
            // 
            // lblBuscarSucursal
            // 
            lblBuscarSucursal.AutoSize = true;
            lblBuscarSucursal.BackColor = Color.White;
            lblBuscarSucursal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarSucursal.ForeColor = Color.FromArgb(0, 176, 80);
            lblBuscarSucursal.Location = new Point(46, 9);
            lblBuscarSucursal.Name = "lblBuscarSucursal";
            lblBuscarSucursal.Size = new Size(369, 29);
            lblBuscarSucursal.TabIndex = 27;
            lblBuscarSucursal.Text = "Seleccionar ubicación de la sucursal";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(0, 176, 80);
            btnSeleccionar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(113, 401);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(169, 34);
            btnSeleccionar.TabIndex = 7;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(299, 401);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 34);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gmapSeleccionarUbi
            // 
            gmapSeleccionarUbi.Bearing = 0F;
            gmapSeleccionarUbi.CanDragMap = true;
            gmapSeleccionarUbi.EmptyTileColor = Color.Navy;
            gmapSeleccionarUbi.GrayScaleMode = false;
            gmapSeleccionarUbi.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmapSeleccionarUbi.LevelsKeepInMemory = 5;
            gmapSeleccionarUbi.Location = new Point(15, 58);
            gmapSeleccionarUbi.MarkersEnabled = true;
            gmapSeleccionarUbi.MaxZoom = 2;
            gmapSeleccionarUbi.MinZoom = 2;
            gmapSeleccionarUbi.MouseWheelZoomEnabled = true;
            gmapSeleccionarUbi.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmapSeleccionarUbi.Name = "gmapSeleccionarUbi";
            gmapSeleccionarUbi.NegativeMode = false;
            gmapSeleccionarUbi.PolygonsEnabled = true;
            gmapSeleccionarUbi.RetryLoadTile = 0;
            gmapSeleccionarUbi.RoutesEnabled = true;
            gmapSeleccionarUbi.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmapSeleccionarUbi.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmapSeleccionarUbi.ShowTileGridLines = false;
            gmapSeleccionarUbi.Size = new Size(554, 313);
            gmapSeleccionarUbi.TabIndex = 9;
            gmapSeleccionarUbi.Zoom = 0D;
            gmapSeleccionarUbi.MouseClick += gmapSeleccionarUbi_MouseClick;
            // 
            // lblCoordenadas
            // 
            lblCoordenadas.AutoSize = true;
            lblCoordenadas.Location = new Point(25, 374);
            lblCoordenadas.Name = "lblCoordenadas";
            lblCoordenadas.Size = new Size(14, 20);
            lblCoordenadas.TabIndex = 10;
            lblCoordenadas.Text = "-";
            // 
            // frmBuscarSucursal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(581, 447);
            Controls.Add(lblCoordenadas);
            Controls.Add(gmapSeleccionarUbi);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(pnlBusqueda);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmBuscarSucursal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarSucursal";
            Load += frmBuscarSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)pbxBuscarSucursal).EndInit();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label lblCoordenadas;
        private Label label3;
        private PictureBox pbxBuscarSucursal;
        private Panel pnlBusqueda;
        private Label lblBuscarSucursal;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private GMap.NET.WindowsForms.GMapControl gmapSeleccionarUbi;
    }
}