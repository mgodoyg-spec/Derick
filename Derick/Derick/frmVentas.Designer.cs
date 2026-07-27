namespace Derick
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            pnlMostrarFrmV = new Panel();
            dataGridView1 = new DataGridView();
            colFac = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colVendedor = new DataGridViewTextBoxColumn();
            lblUltVenta = new Label();
            pnlActividadRecienteV = new Panel();
            btnVerTodoVentas = new Button();
            lblActividadRecV = new Label();
            pnlAccesoRapidoV = new Panel();
            lblAceesosRa = new Label();
            pnlBuscarVenta = new Panel();
            btnBuscarVenta = new Button();
            lblConsultarVenta = new Label();
            lblBuscarVenta = new Label();
            picBuscarVenta = new PictureBox();
            pnlClientes = new Panel();
            btnClientesV = new Button();
            lblConsultarClientes = new Label();
            lblClientesV = new Label();
            picClientesV = new PictureBox();
            pnlNuevaVenta = new Panel();
            btnNuevaVenta = new Button();
            lblPermitirVenta = new Label();
            lblNuevaV = new Label();
            picNuevaVenta = new PictureBox();
            pnlHistorial = new Panel();
            btnHistorialV = new Button();
            lblVerVentas = new Label();
            lblHistorialV = new Label();
            picHistorialV = new PictureBox();
            pnlPromedio = new Panel();
            pnlPro = new Panel();
            lblPromedioV = new Label();
            lblNumVentas = new Label();
            lblVentasP = new Label();
            picPromedio = new PictureBox();
            pnlBordeVentaP = new Panel();
            pnlFacturas = new Panel();
            pnlBordeFacturas = new Panel();
            pnlFac = new Panel();
            lblFacturasG = new Label();
            lblNumFac = new Label();
            LblFacturasE = new Label();
            picFacturas = new PictureBox();
            pnlTotal = new Panel();
            pnlTot = new Panel();
            lblTotaling = new Label();
            lblNumIngresos = new Label();
            lblIngresos = new Label();
            picIngresos = new PictureBox();
            pnlBordeIngresos = new Panel();
            pnlVregistrada = new Panel();
            pnlBordeVentasH = new Panel();
            pnlCtnRegis = new Panel();
            lblVentasReg = new Label();
            NumVentasH = new Label();
            lblVentasH = new Label();
            picVentasHoy = new PictureBox();
            pnlVenta = new Panel();
            lblResumenVentas = new Label();
            lblVentas = new Label();
            pnlMostrarFrmV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlActividadRecienteV.SuspendLayout();
            pnlAccesoRapidoV.SuspendLayout();
            pnlBuscarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBuscarVenta).BeginInit();
            pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientesV).BeginInit();
            pnlNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNuevaVenta).BeginInit();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistorialV).BeginInit();
            pnlPromedio.SuspendLayout();
            pnlPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPromedio).BeginInit();
            pnlFacturas.SuspendLayout();
            pnlFac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFacturas).BeginInit();
            pnlTotal.SuspendLayout();
            pnlTot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIngresos).BeginInit();
            pnlVregistrada.SuspendLayout();
            pnlCtnRegis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVentasHoy).BeginInit();
            pnlVenta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMostrarFrmV
            // 
            pnlMostrarFrmV.BackColor = Color.FromArgb(244, 246, 249);
            pnlMostrarFrmV.Controls.Add(dataGridView1);
            pnlMostrarFrmV.Controls.Add(lblUltVenta);
            pnlMostrarFrmV.Controls.Add(pnlActividadRecienteV);
            pnlMostrarFrmV.Controls.Add(pnlAccesoRapidoV);
            pnlMostrarFrmV.Controls.Add(pnlPromedio);
            pnlMostrarFrmV.Controls.Add(pnlFacturas);
            pnlMostrarFrmV.Controls.Add(pnlTotal);
            pnlMostrarFrmV.Controls.Add(pnlVregistrada);
            pnlMostrarFrmV.Controls.Add(pnlVenta);
            pnlMostrarFrmV.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlMostrarFrmV.Location = new Point(0, 0);
            pnlMostrarFrmV.Name = "pnlMostrarFrmV";
            pnlMostrarFrmV.Size = new Size(1200, 651);
            pnlMostrarFrmV.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFac, colCliente, colFecha, colSucursal, colTotal, colEstado, colVendedor });
            dataGridView1.Location = new Point(20, 566);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1160, 83);
            dataGridView1.TabIndex = 14;
            // 
            // colFac
            // 
            colFac.HeaderText = "Facturas";
            colFac.MinimumWidth = 6;
            colFac.Name = "colFac";
            colFac.Width = 175;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.Width = 175;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.Width = 175;
            // 
            // colSucursal
            // 
            colSucursal.HeaderText = "Sucursal";
            colSucursal.MinimumWidth = 6;
            colSucursal.Name = "colSucursal";
            colSucursal.Width = 175;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 175;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 175;
            // 
            // colVendedor
            // 
            colVendedor.HeaderText = "Vendedor";
            colVendedor.MinimumWidth = 6;
            colVendedor.Name = "colVendedor";
            colVendedor.Width = 175;
            // 
            // lblUltVenta
            // 
            lblUltVenta.AutoSize = true;
            lblUltVenta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltVenta.ForeColor = Color.Black;
            lblUltVenta.Location = new Point(20, 541);
            lblUltVenta.Name = "lblUltVenta";
            lblUltVenta.Size = new Size(220, 23);
            lblUltVenta.TabIndex = 13;
            lblUltVenta.Text = "Últimas ventas registradas";
            // 
            // pnlActividadRecienteV
            // 
            pnlActividadRecienteV.BackColor = Color.White;
            pnlActividadRecienteV.Controls.Add(btnVerTodoVentas);
            pnlActividadRecienteV.Controls.Add(lblActividadRecV);
            pnlActividadRecienteV.Location = new Point(610, 288);
            pnlActividadRecienteV.Name = "pnlActividadRecienteV";
            pnlActividadRecienteV.Size = new Size(570, 250);
            pnlActividadRecienteV.TabIndex = 6;
            // 
            // btnVerTodoVentas
            // 
            btnVerTodoVentas.Cursor = Cursors.Hand;
            btnVerTodoVentas.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerTodoVentas.Location = new Point(466, 30);
            btnVerTodoVentas.Name = "btnVerTodoVentas";
            btnVerTodoVentas.Size = new Size(86, 30);
            btnVerTodoVentas.TabIndex = 14;
            btnVerTodoVentas.Text = "Ver todo";
            btnVerTodoVentas.UseVisualStyleBackColor = true;
            // 
            // lblActividadRecV
            // 
            lblActividadRecV.AutoSize = true;
            lblActividadRecV.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividadRecV.ForeColor = Color.Black;
            lblActividadRecV.Location = new Point(17, 19);
            lblActividadRecV.Name = "lblActividadRecV";
            lblActividadRecV.Size = new Size(175, 26);
            lblActividadRecV.TabIndex = 13;
            lblActividadRecV.Text = "Actividad Reciente";
            // 
            // pnlAccesoRapidoV
            // 
            pnlAccesoRapidoV.BackColor = Color.White;
            pnlAccesoRapidoV.Controls.Add(lblAceesosRa);
            pnlAccesoRapidoV.Controls.Add(pnlBuscarVenta);
            pnlAccesoRapidoV.Controls.Add(pnlClientes);
            pnlAccesoRapidoV.Controls.Add(pnlNuevaVenta);
            pnlAccesoRapidoV.Controls.Add(pnlHistorial);
            pnlAccesoRapidoV.Location = new Point(20, 288);
            pnlAccesoRapidoV.Name = "pnlAccesoRapidoV";
            pnlAccesoRapidoV.Size = new Size(570, 250);
            pnlAccesoRapidoV.TabIndex = 3;
            // 
            // lblAceesosRa
            // 
            lblAceesosRa.AutoSize = true;
            lblAceesosRa.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAceesosRa.ForeColor = Color.Black;
            lblAceesosRa.Location = new Point(21, 8);
            lblAceesosRa.Name = "lblAceesosRa";
            lblAceesosRa.Size = new Size(149, 26);
            lblAceesosRa.TabIndex = 12;
            lblAceesosRa.Text = "Accesos rápidos";
            // 
            // pnlBuscarVenta
            // 
            pnlBuscarVenta.BackColor = Color.FromArgb(244, 246, 249);
            pnlBuscarVenta.Controls.Add(btnBuscarVenta);
            pnlBuscarVenta.Controls.Add(lblConsultarVenta);
            pnlBuscarVenta.Controls.Add(lblBuscarVenta);
            pnlBuscarVenta.Controls.Add(picBuscarVenta);
            pnlBuscarVenta.Location = new Point(153, 35);
            pnlBuscarVenta.Name = "pnlBuscarVenta";
            pnlBuscarVenta.Size = new Size(125, 198);
            pnlBuscarVenta.TabIndex = 5;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.BackColor = Color.FromArgb(0, 176, 80);
            btnBuscarVenta.Cursor = Cursors.Hand;
            btnBuscarVenta.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarVenta.ForeColor = Color.White;
            btnBuscarVenta.Location = new Point(0, 158);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(125, 30);
            btnBuscarVenta.TabIndex = 0;
            btnBuscarVenta.Text = "Ir ahora ->";
            btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // lblConsultarVenta
            // 
            lblConsultarVenta.AutoSize = true;
            lblConsultarVenta.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultarVenta.Location = new Point(0, 111);
            lblConsultarVenta.Name = "lblConsultarVenta";
            lblConsultarVenta.Size = new Size(117, 36);
            lblConsultarVenta.TabIndex = 0;
            lblConsultarVenta.Text = " Consultar una\r\nfactura existente.";
            lblConsultarVenta.Click += lblConsultarVenta_Click;
            // 
            // lblBuscarVenta
            // 
            lblBuscarVenta.AutoSize = true;
            lblBuscarVenta.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarVenta.Location = new Point(14, 78);
            lblBuscarVenta.Name = "lblBuscarVenta";
            lblBuscarVenta.Size = new Size(87, 18);
            lblBuscarVenta.TabIndex = 12;
            lblBuscarVenta.Text = "Buscar Venta";
            // 
            // picBuscarVenta
            // 
            picBuscarVenta.Image = (Image)resources.GetObject("picBuscarVenta.Image");
            picBuscarVenta.Location = new Point(27, 16);
            picBuscarVenta.Name = "picBuscarVenta";
            picBuscarVenta.Size = new Size(61, 59);
            picBuscarVenta.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuscarVenta.TabIndex = 1;
            picBuscarVenta.TabStop = false;
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.FromArgb(244, 246, 249);
            pnlClientes.Controls.Add(btnClientesV);
            pnlClientes.Controls.Add(lblConsultarClientes);
            pnlClientes.Controls.Add(lblClientesV);
            pnlClientes.Controls.Add(picClientesV);
            pnlClientes.Location = new Point(284, 35);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(125, 198);
            pnlClientes.TabIndex = 4;
            // 
            // btnClientesV
            // 
            btnClientesV.BackColor = Color.FromArgb(112, 34, 246);
            btnClientesV.Cursor = Cursors.Hand;
            btnClientesV.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientesV.ForeColor = Color.White;
            btnClientesV.Location = new Point(0, 158);
            btnClientesV.Name = "btnClientesV";
            btnClientesV.Size = new Size(125, 30);
            btnClientesV.TabIndex = 0;
            btnClientesV.Text = "Ir ahora ->";
            btnClientesV.UseVisualStyleBackColor = false;
            // 
            // lblConsultarClientes
            // 
            lblConsultarClientes.AutoSize = true;
            lblConsultarClientes.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultarClientes.Location = new Point(14, 104);
            lblConsultarClientes.Name = "lblConsultarClientes";
            lblConsultarClientes.Size = new Size(83, 54);
            lblConsultarClientes.TabIndex = 0;
            lblConsultarClientes.Text = " Consultar \r\ninformación\r\n de clientes.";
            // 
            // lblClientesV
            // 
            lblClientesV.AutoSize = true;
            lblClientesV.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientesV.Location = new Point(14, 78);
            lblClientesV.Name = "lblClientesV";
            lblClientesV.Size = new Size(71, 18);
            lblClientesV.TabIndex = 12;
            lblClientesV.Text = "    Clientes";
            // 
            // picClientesV
            // 
            picClientesV.Image = (Image)resources.GetObject("picClientesV.Image");
            picClientesV.Location = new Point(27, 16);
            picClientesV.Name = "picClientesV";
            picClientesV.Size = new Size(61, 59);
            picClientesV.SizeMode = PictureBoxSizeMode.StretchImage;
            picClientesV.TabIndex = 1;
            picClientesV.TabStop = false;
            // 
            // pnlNuevaVenta
            // 
            pnlNuevaVenta.BackColor = Color.FromArgb(244, 246, 249);
            pnlNuevaVenta.Controls.Add(btnNuevaVenta);
            pnlNuevaVenta.Controls.Add(lblPermitirVenta);
            pnlNuevaVenta.Controls.Add(lblNuevaV);
            pnlNuevaVenta.Controls.Add(picNuevaVenta);
            pnlNuevaVenta.Location = new Point(21, 35);
            pnlNuevaVenta.Name = "pnlNuevaVenta";
            pnlNuevaVenta.Size = new Size(125, 198);
            pnlNuevaVenta.TabIndex = 1;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.BackColor = Color.FromArgb(0, 102, 255);
            btnNuevaVenta.Cursor = Cursors.Hand;
            btnNuevaVenta.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaVenta.ForeColor = Color.White;
            btnNuevaVenta.Location = new Point(2, 158);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(125, 30);
            btnNuevaVenta.TabIndex = 0;
            btnNuevaVenta.Text = "Ir ahora ->";
            btnNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // lblPermitirVenta
            // 
            lblPermitirVenta.AutoSize = true;
            lblPermitirVenta.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermitirVenta.Location = new Point(18, 104);
            lblPermitirVenta.Name = "lblPermitirVenta";
            lblPermitirVenta.Size = new Size(88, 54);
            lblPermitirVenta.TabIndex = 0;
            lblPermitirVenta.Text = "   Permitir \r\nregistrar una\r\nnueva venta.";
            // 
            // lblNuevaV
            // 
            lblNuevaV.AutoSize = true;
            lblNuevaV.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevaV.Location = new Point(3, 78);
            lblNuevaV.Name = "lblNuevaV";
            lblNuevaV.Size = new Size(99, 18);
            lblNuevaV.TabIndex = 12;
            lblNuevaV.Text = "    Nueva Venta";
            // 
            // picNuevaVenta
            // 
            picNuevaVenta.Image = (Image)resources.GetObject("picNuevaVenta.Image");
            picNuevaVenta.Location = new Point(29, 16);
            picNuevaVenta.Name = "picNuevaVenta";
            picNuevaVenta.Size = new Size(57, 59);
            picNuevaVenta.SizeMode = PictureBoxSizeMode.StretchImage;
            picNuevaVenta.TabIndex = 1;
            picNuevaVenta.TabStop = false;
            // 
            // pnlHistorial
            // 
            pnlHistorial.BackColor = Color.FromArgb(244, 246, 249);
            pnlHistorial.Controls.Add(btnHistorialV);
            pnlHistorial.Controls.Add(lblVerVentas);
            pnlHistorial.Controls.Add(lblHistorialV);
            pnlHistorial.Controls.Add(picHistorialV);
            pnlHistorial.Location = new Point(414, 35);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(125, 198);
            pnlHistorial.TabIndex = 0;
            // 
            // btnHistorialV
            // 
            btnHistorialV.BackColor = Color.FromArgb(255, 136, 0);
            btnHistorialV.Cursor = Cursors.Hand;
            btnHistorialV.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorialV.ForeColor = Color.White;
            btnHistorialV.Location = new Point(0, 158);
            btnHistorialV.Name = "btnHistorialV";
            btnHistorialV.Size = new Size(125, 30);
            btnHistorialV.TabIndex = 0;
            btnHistorialV.Text = "Ir ahora ->";
            btnHistorialV.UseVisualStyleBackColor = false;
            // 
            // lblVerVentas
            // 
            lblVerVentas.AutoSize = true;
            lblVerVentas.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVerVentas.Location = new Point(21, 104);
            lblVerVentas.Name = "lblVerVentas";
            lblVerVentas.Size = new Size(77, 54);
            lblVerVentas.TabIndex = 0;
            lblVerVentas.Text = " Ver todas  \r\n las ventas\r\n realizadas.";
            // 
            // lblHistorialV
            // 
            lblHistorialV.AutoSize = true;
            lblHistorialV.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialV.Location = new Point(14, 78);
            lblHistorialV.Name = "lblHistorialV";
            lblHistorialV.Size = new Size(74, 19);
            lblHistorialV.TabIndex = 12;
            lblHistorialV.Text = "  Historial";
            // 
            // picHistorialV
            // 
            picHistorialV.Image = (Image)resources.GetObject("picHistorialV.Image");
            picHistorialV.Location = new Point(29, 16);
            picHistorialV.Name = "picHistorialV";
            picHistorialV.Size = new Size(57, 59);
            picHistorialV.SizeMode = PictureBoxSizeMode.StretchImage;
            picHistorialV.TabIndex = 1;
            picHistorialV.TabStop = false;
            // 
            // pnlPromedio
            // 
            pnlPromedio.BackColor = Color.White;
            pnlPromedio.Controls.Add(pnlPro);
            pnlPromedio.Controls.Add(pnlBordeVentaP);
            pnlPromedio.Location = new Point(902, 158);
            pnlPromedio.Name = "pnlPromedio";
            pnlPromedio.Size = new Size(278, 110);
            pnlPromedio.TabIndex = 5;
            // 
            // pnlPro
            // 
            pnlPro.BackColor = Color.White;
            pnlPro.Controls.Add(lblPromedioV);
            pnlPro.Controls.Add(lblNumVentas);
            pnlPro.Controls.Add(lblVentasP);
            pnlPro.Controls.Add(picPromedio);
            pnlPro.Location = new Point(19, 0);
            pnlPro.Name = "pnlPro";
            pnlPro.Size = new Size(241, 110);
            pnlPro.TabIndex = 9;
            // 
            // lblPromedioV
            // 
            lblPromedioV.AutoSize = true;
            lblPromedioV.ForeColor = Color.FromArgb(255, 136, 0);
            lblPromedioV.Location = new Point(0, 75);
            lblPromedioV.Name = "lblPromedioV";
            lblPromedioV.Size = new Size(156, 18);
            lblPromedioV.TabIndex = 11;
            lblPromedioV.Text = "Promedio por venta";
            // 
            // lblNumVentas
            // 
            lblNumVentas.AutoSize = true;
            lblNumVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumVentas.Location = new Point(68, 35);
            lblNumVentas.Name = "lblNumVentas";
            lblNumVentas.Size = new Size(25, 25);
            lblNumVentas.TabIndex = 10;
            lblNumVentas.Text = "0";
            // 
            // lblVentasP
            // 
            lblVentasP.AutoSize = true;
            lblVentasP.Location = new Point(68, 13);
            lblVentasP.Name = "lblVentasP";
            lblVentasP.Size = new Size(135, 18);
            lblVentasP.TabIndex = 9;
            lblVentasP.Text = "Ventas promedio";
            // 
            // picPromedio
            // 
            picPromedio.Image = (Image)resources.GetObject("picPromedio.Image");
            picPromedio.Location = new Point(3, 13);
            picPromedio.Name = "picPromedio";
            picPromedio.Size = new Size(60, 59);
            picPromedio.SizeMode = PictureBoxSizeMode.StretchImage;
            picPromedio.TabIndex = 0;
            picPromedio.TabStop = false;
            // 
            // pnlBordeVentaP
            // 
            pnlBordeVentaP.BackColor = Color.FromArgb(255, 136, 0);
            pnlBordeVentaP.Location = new Point(0, 0);
            pnlBordeVentaP.Name = "pnlBordeVentaP";
            pnlBordeVentaP.Size = new Size(4, 124);
            pnlBordeVentaP.TabIndex = 8;
            // 
            // pnlFacturas
            // 
            pnlFacturas.BackColor = Color.White;
            pnlFacturas.Controls.Add(pnlBordeFacturas);
            pnlFacturas.Controls.Add(pnlFac);
            pnlFacturas.Location = new Point(610, 158);
            pnlFacturas.Name = "pnlFacturas";
            pnlFacturas.Size = new Size(278, 110);
            pnlFacturas.TabIndex = 4;
            // 
            // pnlBordeFacturas
            // 
            pnlBordeFacturas.BackColor = Color.FromArgb(112, 34, 246);
            pnlBordeFacturas.Location = new Point(0, 0);
            pnlBordeFacturas.Name = "pnlBordeFacturas";
            pnlBordeFacturas.Size = new Size(4, 124);
            pnlBordeFacturas.TabIndex = 8;
            // 
            // pnlFac
            // 
            pnlFac.BackColor = Color.White;
            pnlFac.Controls.Add(lblFacturasG);
            pnlFac.Controls.Add(lblNumFac);
            pnlFac.Controls.Add(LblFacturasE);
            pnlFac.Controls.Add(picFacturas);
            pnlFac.Location = new Point(19, 0);
            pnlFac.Name = "pnlFac";
            pnlFac.Size = new Size(241, 110);
            pnlFac.TabIndex = 1;
            // 
            // lblFacturasG
            // 
            lblFacturasG.AutoSize = true;
            lblFacturasG.ForeColor = Color.FromArgb(112, 34, 246);
            lblFacturasG.Location = new Point(0, 75);
            lblFacturasG.Name = "lblFacturasG";
            lblFacturasG.Size = new Size(157, 18);
            lblFacturasG.TabIndex = 11;
            lblFacturasG.Text = "Facturas generadas";
            // 
            // lblNumFac
            // 
            lblNumFac.AutoSize = true;
            lblNumFac.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumFac.Location = new Point(69, 35);
            lblNumFac.Name = "lblNumFac";
            lblNumFac.Size = new Size(25, 25);
            lblNumFac.TabIndex = 10;
            lblNumFac.Text = "0";
            // 
            // LblFacturasE
            // 
            LblFacturasE.AutoSize = true;
            LblFacturasE.Location = new Point(69, 13);
            LblFacturasE.Name = "LblFacturasE";
            LblFacturasE.Size = new Size(142, 18);
            LblFacturasE.TabIndex = 9;
            LblFacturasE.Text = "Facturas emitidas";
            // 
            // picFacturas
            // 
            picFacturas.Image = (Image)resources.GetObject("picFacturas.Image");
            picFacturas.Location = new Point(4, 13);
            picFacturas.Name = "picFacturas";
            picFacturas.Size = new Size(60, 59);
            picFacturas.SizeMode = PictureBoxSizeMode.StretchImage;
            picFacturas.TabIndex = 0;
            picFacturas.TabStop = false;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.Controls.Add(pnlTot);
            pnlTotal.Controls.Add(pnlBordeIngresos);
            pnlTotal.Location = new Point(312, 158);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(278, 110);
            pnlTotal.TabIndex = 3;
            // 
            // pnlTot
            // 
            pnlTot.BackColor = Color.White;
            pnlTot.Controls.Add(lblTotaling);
            pnlTot.Controls.Add(lblNumIngresos);
            pnlTot.Controls.Add(lblIngresos);
            pnlTot.Controls.Add(picIngresos);
            pnlTot.Location = new Point(19, 0);
            pnlTot.Name = "pnlTot";
            pnlTot.Size = new Size(241, 110);
            pnlTot.TabIndex = 9;
            // 
            // lblTotaling
            // 
            lblTotaling.AutoSize = true;
            lblTotaling.ForeColor = Color.FromArgb(0, 176, 80);
            lblTotaling.Location = new Point(0, 75);
            lblTotaling.Name = "lblTotaling";
            lblTotaling.Size = new Size(116, 18);
            lblTotaling.TabIndex = 11;
            lblTotaling.Text = "Total ingresos";
            // 
            // lblNumIngresos
            // 
            lblNumIngresos.AutoSize = true;
            lblNumIngresos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumIngresos.Location = new Point(69, 35);
            lblNumIngresos.Name = "lblNumIngresos";
            lblNumIngresos.Size = new Size(25, 25);
            lblNumIngresos.TabIndex = 10;
            lblNumIngresos.Text = "0";
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(69, 13);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(127, 18);
            lblIngresos.TabIndex = 9;
            lblIngresos.Text = "Ingresos del día";
            // 
            // picIngresos
            // 
            picIngresos.Image = (Image)resources.GetObject("picIngresos.Image");
            picIngresos.Location = new Point(3, 13);
            picIngresos.Name = "picIngresos";
            picIngresos.Size = new Size(60, 59);
            picIngresos.SizeMode = PictureBoxSizeMode.StretchImage;
            picIngresos.TabIndex = 0;
            picIngresos.TabStop = false;
            // 
            // pnlBordeIngresos
            // 
            pnlBordeIngresos.BackColor = Color.FromArgb(0, 176, 80);
            pnlBordeIngresos.Location = new Point(0, 0);
            pnlBordeIngresos.Name = "pnlBordeIngresos";
            pnlBordeIngresos.Size = new Size(4, 124);
            pnlBordeIngresos.TabIndex = 8;
            // 
            // pnlVregistrada
            // 
            pnlVregistrada.BackColor = Color.White;
            pnlVregistrada.Controls.Add(pnlBordeVentasH);
            pnlVregistrada.Controls.Add(pnlCtnRegis);
            pnlVregistrada.Location = new Point(20, 158);
            pnlVregistrada.Name = "pnlVregistrada";
            pnlVregistrada.Size = new Size(278, 110);
            pnlVregistrada.TabIndex = 2;
            // 
            // pnlBordeVentasH
            // 
            pnlBordeVentasH.BackColor = Color.FromArgb(0, 102, 255);
            pnlBordeVentasH.Location = new Point(0, 0);
            pnlBordeVentasH.Name = "pnlBordeVentasH";
            pnlBordeVentasH.Size = new Size(4, 124);
            pnlBordeVentasH.TabIndex = 7;
            // 
            // pnlCtnRegis
            // 
            pnlCtnRegis.BackColor = Color.White;
            pnlCtnRegis.Controls.Add(lblVentasReg);
            pnlCtnRegis.Controls.Add(NumVentasH);
            pnlCtnRegis.Controls.Add(lblVentasH);
            pnlCtnRegis.Controls.Add(picVentasHoy);
            pnlCtnRegis.Location = new Point(18, 0);
            pnlCtnRegis.Name = "pnlCtnRegis";
            pnlCtnRegis.Size = new Size(241, 110);
            pnlCtnRegis.TabIndex = 0;
            // 
            // lblVentasReg
            // 
            lblVentasReg.AutoSize = true;
            lblVentasReg.ForeColor = Color.FromArgb(0, 102, 255);
            lblVentasReg.Location = new Point(0, 75);
            lblVentasReg.Name = "lblVentasReg";
            lblVentasReg.Size = new Size(154, 18);
            lblVentasReg.TabIndex = 11;
            lblVentasReg.Text = "Ventas Registradas";
            // 
            // NumVentasH
            // 
            NumVentasH.AutoSize = true;
            NumVentasH.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumVentasH.Location = new Point(69, 35);
            NumVentasH.Name = "NumVentasH";
            NumVentasH.Size = new Size(25, 25);
            NumVentasH.TabIndex = 10;
            NumVentasH.Text = "0";
            // 
            // lblVentasH
            // 
            lblVentasH.AutoSize = true;
            lblVentasH.Location = new Point(69, 10);
            lblVentasH.Name = "lblVentasH";
            lblVentasH.Size = new Size(114, 18);
            lblVentasH.TabIndex = 9;
            lblVentasH.Text = "Ventas de hoy";
            // 
            // picVentasHoy
            // 
            picVentasHoy.Image = (Image)resources.GetObject("picVentasHoy.Image");
            picVentasHoy.Location = new Point(3, 13);
            picVentasHoy.Name = "picVentasHoy";
            picVentasHoy.Size = new Size(60, 59);
            picVentasHoy.SizeMode = PictureBoxSizeMode.StretchImage;
            picVentasHoy.TabIndex = 0;
            picVentasHoy.TabStop = false;
            // 
            // pnlVenta
            // 
            pnlVenta.BackColor = Color.Transparent;
            pnlVenta.BackgroundImage = (Image)resources.GetObject("pnlVenta.BackgroundImage");
            pnlVenta.BackgroundImageLayout = ImageLayout.Stretch;
            pnlVenta.Controls.Add(lblResumenVentas);
            pnlVenta.Controls.Add(lblVentas);
            pnlVenta.Location = new Point(20, 17);
            pnlVenta.Name = "pnlVenta";
            pnlVenta.Size = new Size(1160, 122);
            pnlVenta.TabIndex = 1;
            // 
            // lblResumenVentas
            // 
            lblResumenVentas.AutoSize = true;
            lblResumenVentas.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResumenVentas.ForeColor = Color.White;
            lblResumenVentas.Location = new Point(33, 66);
            lblResumenVentas.Name = "lblResumenVentas";
            lblResumenVentas.Size = new Size(280, 19);
            lblResumenVentas.TabIndex = 13;
            lblResumenVentas.Text = "Gestiona y registra las ventas del sistema.";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.White;
            lblVentas.Location = new Point(33, 28);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(92, 29);
            lblVentas.TabIndex = 11;
            lblVentas.Text = "Ventas";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlMostrarFrmV);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVentas";
            Text = "frmVentas";
            pnlMostrarFrmV.ResumeLayout(false);
            pnlMostrarFrmV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlActividadRecienteV.ResumeLayout(false);
            pnlActividadRecienteV.PerformLayout();
            pnlAccesoRapidoV.ResumeLayout(false);
            pnlAccesoRapidoV.PerformLayout();
            pnlBuscarVenta.ResumeLayout(false);
            pnlBuscarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBuscarVenta).EndInit();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClientesV).EndInit();
            pnlNuevaVenta.ResumeLayout(false);
            pnlNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNuevaVenta).EndInit();
            pnlHistorial.ResumeLayout(false);
            pnlHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHistorialV).EndInit();
            pnlPromedio.ResumeLayout(false);
            pnlPro.ResumeLayout(false);
            pnlPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPromedio).EndInit();
            pnlFacturas.ResumeLayout(false);
            pnlFac.ResumeLayout(false);
            pnlFac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFacturas).EndInit();
            pnlTotal.ResumeLayout(false);
            pnlTot.ResumeLayout(false);
            pnlTot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIngresos).EndInit();
            pnlVregistrada.ResumeLayout(false);
            pnlCtnRegis.ResumeLayout(false);
            pnlCtnRegis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVentasHoy).EndInit();
            pnlVenta.ResumeLayout(false);
            pnlVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMostrarFrmV;
        private Panel pnlBordeFacturas;
        private Panel pnlActividadRecienteV;
        private Button btnVerTodoVentas;
        private Label lblActividadRecV;
        private Panel pnlAccesoRapidoV;
        private Label lblAceesosRa;
        private Panel pnlBuscarVenta;
        private Button btnBuscarVenta;
        private Label lblConsultarVenta;
        private Label lblBuscarVenta;
        private PictureBox picBuscarVenta;
        private Panel pnlClientes;
        private Button btnClientesV;
        private Label lblConsultarClientes;
        private Label lblClientesV;
        private PictureBox picClientesV;
        private Panel pnlNuevaVenta;
        private Button btnNuevaVenta;
        private Label lblPermitirVenta;
        private Label lblNuevaV;
        private PictureBox picNuevaVenta;
        private Panel pnlHistorial;
        private Button btnHistorialV;
        private Label lblVerVentas;
        private Label lblHistorialV;
        private PictureBox picHistorialV;
        private Panel pnlPromedio;
        private Panel pnlPro;
        private Label lblPromedioV;
        private Label lblNumVentas;
        private Label lblVentasP;
        private PictureBox picPromedio;
        private Panel pnlBordeVentaP;
        private Panel pnlFacturas;
        private Panel pnlFac;
        private Label lblFacturasG;
        private Label lblNumFac;
        private Label LblFacturasE;
        private PictureBox picFacturas;
        private Panel pnlTotal;
        private Panel pnlTot;
        private Label lblTotaling;
        private Label lblNumIngresos;
        private Label lblIngresos;
        private PictureBox picIngresos;
        private Panel pnlBordeIngresos;
        private Panel pnlVregistrada;
        private Panel pnlBordeVentasH;
        private Panel pnlCtnRegis;
        private Label lblVentasReg;
        private Label NumVentasH;
        private Label lblVentasH;
        private PictureBox picVentasHoy;
        private Panel pnlVenta;
        private Label lblResumenVentas;
        private Label lblVentas;
        private Label lblUltVenta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFac;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colVendedor;
    }
}