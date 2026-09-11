using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmVentasN : Form
    {
        private csConectaSQL conexion = new csConectaSQL();
        private csVenta venta = new csVenta();
        private int idClienteSeleccionado;
        private DataTable variantesEncontradas;

        public FrmVentasN()
        {
            InitializeComponent();
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            cbNVProducto.SelectedIndexChanged += cbNVProducto_SelectedIndexChanged;
        }

        private void btnNVAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void lblSalirV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVentasN_Load_1(object sender, EventArgs e)
        {
            // Diseño del DataGridView
            dgvNVPA.EnableHeadersVisualStyles = false;
            dgvNVPA.BorderStyle = BorderStyle.None;
            dgvNVPA.BackgroundColor = Color.White;
            dgvNVPA.GridColor = Color.FromArgb(235, 235, 235);
            dgvNVPA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPA.ReadOnly = true;
            dgvNVPA.MultiSelect = false;
            dgvNVPA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPA.AllowUserToAddRows = false;
            dgvNVPA.AllowUserToDeleteRows = false;
            dgvNVPA.AllowUserToResizeRows = false;
            dgvNVPA.AllowUserToResizeColumns = false;
            dgvNVPA.RowHeadersVisible = false;

            // Encabezado
            dgvNVPA.ColumnHeadersHeight = 50;
            dgvNVPA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVPA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVPA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVPA.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVPA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dgvNVPA.RowTemplate.Height = 45;
            dgvNVPA.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVPA.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVPA.DefaultCellStyle.BackColor = Color.White;
            dgvNVPA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVPA.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVPA.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVPA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVPA.DefaultCellStyle.Padding = new Padding(5);

            // Columnas
            dgvNVPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNVPA.Columns["colCodigo"].FillWeight = 10;
            dgvNVPA.Columns["colProducto"].FillWeight = 20;
            dgvNVPA.Columns["colTalla"].FillWeight = 10;
            dgvNVPA.Columns["colColor"].FillWeight = 12;
            dgvNVPA.Columns["colCantidad"].FillWeight = 12;
            dgvNVPA.Columns["colPrecio"].FillWeight = 12;
            dgvNVPA.Columns["colSubtotal"].FillWeight = 14;
            dgvNVPA.Columns["colEditar"].FillWeight = 8;
            dgvNVPA.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvNVPA.Columns["colEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvNVPA.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            string[] columnasCentro = { "colCodigo", "colProducto", "colTalla", "colColor", "colCantidad", "colPrecio", "colSubtotal", "colEditar", "colEliminar" };

            foreach (string columna in columnasCentro)
                dgvNVPA.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtpNV.Value = DateTime.Now;
            dtpNV.Enabled = false;

            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.Enabled = false;

            CargarSucursales();

            cbNVVendedor.DataSource = null;
            cbNVVendedor.SelectedIndex = -1;

            cbNVProducto.DataSource = null;
            cbNVProducto.SelectedIndex = -1;

            cbNVMP.Items.Clear();
            cbNVMP.Items.Add("Efectivo");
            cbNVMP.Items.Add("Tarjeta");
            cbNVMP.Items.Add("Transferencia");
            cbNVMP.SelectedIndex = 0;
        }

        private void CargarSucursales()
        {
            string consulta = "select IdSucursal, NombreSucursal from Sucursales where NombreSucursal is not null order by NombreSucursal";
            DataTable tabla = conexion.RetornaRegistros(consulta);

            comboBox3.DataSource = tabla;
            comboBox3.DisplayMember = "NombreSucursal";
            comboBox3.ValueMember = "IdSucursal";
            comboBox3.SelectedIndex = -1;
        }

        private void CargarVendedores(int idSucursal)
        {
            string consulta = "select IdEmpleado, Nombres + ' ' + Apellidos as Nombre from Empleados where Estado = 1 and IdSucursal = " + idSucursal + " order by Nombres, Apellidos";
            DataTable tabla = conexion.RetornaRegistros(consulta);

            cbNVVendedor.DataSource = tabla;
            cbNVVendedor.DisplayMember = "Nombre";
            cbNVVendedor.ValueMember = "IdEmpleado";
            cbNVVendedor.SelectedIndex = -1;
        }

        private void CargarProductos(int idSucursal)
        {
            string consulta = @"select distinct P.IdProductos, P.Codigo + ' - ' + P.Nombre as Producto
                                from Inventario I
                                inner join Productos P on I.IdProducto = P.IdProductos
                                where I.IdSucursal = " + idSucursal + @"
                                and I.Estado = 1
                                and I.Stock > 0
                                order by Producto";

            DataTable tabla = conexion.RetornaRegistros(consulta);

            cbNVProducto.DataSource = tabla;
            cbNVProducto.DisplayMember = "Producto";
            cbNVProducto.ValueMember = "IdProductos";
            cbNVProducto.SelectedIndex = -1;
        }

        private int ObtenerConsumidorFinal()
        {
            string consulta = "select top 1 IdCliente from Clientes where Nombres = 'Consumidor Final' and Estado = 1";
            DataTable tabla = conexion.RetornaRegistros(consulta);

            if (tabla != null && tabla.Rows.Count > 0)
                return Convert.ToInt32(tabla.Rows[0]["IdCliente"]);

            return 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1 || comboBox3.SelectedItem == null)
            {
                cbNVVendedor.DataSource = null;
                cbNVProducto.DataSource = null;
                cbNVTalla.Items.Clear();
                cbNVColor.Items.Clear();
                variantesEncontradas = null;
                return;
            }

            DataRowView filaSucursal = comboBox3.SelectedItem as DataRowView;
            if (filaSucursal == null) return;

            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);

            CargarVendedores(idSucursal);
            CargarProductos(idSucursal);

            cbNVTalla.Items.Clear();
            cbNVColor.Items.Clear();
            nudNVCantidad.Value = 0;
            variantesEncontradas = null;
        }

        private void cbNVProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNVTalla.Items.Clear();
            cbNVColor.Items.Clear();
            variantesEncontradas = null;

            if (cbNVProducto.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || cbNVProducto.SelectedValue == null)
                return;

            int idProducto;

            if (!int.TryParse(cbNVProducto.SelectedValue.ToString(), out idProducto))
                return;

            DataRowView filaSucursal = comboBox3.SelectedItem as DataRowView;

            if (filaSucursal == null)
                return;

            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);

            string consulta = @"select I.IdInventario, P.IdProductos, P.Codigo, P.Nombre, I.Talla, I.Color, P.Precio, I.Stock
                                from Inventario I
                                inner join Productos P on I.IdProducto = P.IdProductos
                                where I.IdSucursal = " + idSucursal + @"
                                and I.IdProducto = " + idProducto + @"
                                and I.Estado = 1
                                and I.Stock > 0
                                order by I.Talla, I.Color";

            variantesEncontradas = conexion.RetornaRegistros(consulta);

            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
                return;

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                string talla = fila["Talla"].ToString();

                if (!cbNVTalla.Items.Contains(talla))
                    cbNVTalla.Items.Add(talla);
            }

            if (cbNVTalla.Items.Count == 1)
                cbNVTalla.SelectedIndex = 0;
        }

        private void cbNVTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNVColor.Items.Clear();

            if (variantesEncontradas == null || cbNVTalla.SelectedIndex == -1)
                return;

            string tallaElegida = cbNVTalla.SelectedItem.ToString();

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() == tallaElegida)
                {
                    string color = fila["Color"].ToString();

                    if (!cbNVColor.Items.Contains(color))
                        cbNVColor.Items.Add(color);
                }
            }

            if (cbNVColor.Items.Count == 1)
                cbNVColor.SelectedIndex = 0;
        }

        private void picNVB_Click_1(object sender, EventArgs e)
        {
            FrmBuscarClienteV ventana = new FrmBuscarClienteV();

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                txtNVCliente.Text = ventana.NombreClienteSeleccionado;
                idClienteSeleccionado = ventana.IdClienteSeleccionado;
            }
        }

        private void AgregarProducto()
        {
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione primero una sucursal.");
                return;
            }

            if (cbNVProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron variantes disponibles para este producto.");
                return;
            }

            if (cbNVTalla.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una talla.");
                return;
            }

            if (cbNVColor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un color.");
                return;
            }

            string tallaElegida = cbNVTalla.SelectedItem.ToString();
            string colorElegido = cbNVColor.SelectedItem.ToString();

            DataRow filaElegida = null;

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() == tallaElegida && fila["Color"].ToString() == colorElegido)
                {
                    filaElegida = fila;
                    break;
                }
            }

            if (filaElegida == null)
            {
                MessageBox.Show("La combinación de talla y color seleccionada no está disponible.");
                return;
            }

            int stockDisponible = Convert.ToInt32(filaElegida["Stock"]);
            int cantidad = (int)nudNVCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("Stock insuficiente. Disponible: " + stockDisponible);
                return;
            }

            int idInventario = Convert.ToInt32(filaElegida["IdInventario"]);

            foreach (DataGridViewRow filaGrid in dgvNVPA.Rows)
            {
                if (filaGrid.Tag != null && Convert.ToInt32(filaGrid.Tag) == idInventario)
                {
                    MessageBox.Show("Esta combinación de producto, talla y color ya fue agregada.");
                    return;
                }
            }

            decimal precio = Convert.ToDecimal(filaElegida["Precio"]);
            int idProducto = Convert.ToInt32(filaElegida["IdProductos"]);

            DataRowView filaSucursalActual = (DataRowView)comboBox3.SelectedItem;
            int idSucursalActual = Convert.ToInt32(filaSucursalActual["IdSucursal"]);

            string consultaPromo = @"
                select top 1 TipoDescuento, ValorDescuento
                from Promociones P
                where P.Estado = 1
                and cast(getdate() as date) between P.FechaInicio and P.FechaFin
                and (P.IdSucursal is null or P.IdSucursal = " + idSucursalActual + @")
                and (
                    P.AplicaTodos = 1
                    or exists (
                        select 1
                        from PromocionProducto PP
                        where PP.IdPromocion = P.IdPromocion
                        and PP.IdProducto = " + idProducto + @"
                    )
                )
                order by P.ValorDescuento desc";

            DataTable dtPromo = conexion.RetornaRegistros(consultaPromo);

            decimal precioOriginal = precio;
            bool tienePromocion = false;

            if (dtPromo != null && dtPromo.Rows.Count > 0)
            {
                string tipoDescuento = dtPromo.Rows[0]["TipoDescuento"].ToString();
                decimal valorDescuento = Convert.ToDecimal(dtPromo.Rows[0]["ValorDescuento"]);

                if (tipoDescuento.ToLower().Contains("porcentual"))
                {
                    precio = precio - (precio * valorDescuento / 100);
                }
                else
                {
                    precio = precio - valorDescuento;

                    if (precio < 0)
                        precio = 0;
                }

                tienePromocion = true;
            }

            decimal subtotalLinea = precio * cantidad;
            int posicion = dgvNVPA.Rows.Add();
            DataGridViewRow row = dgvNVPA.Rows[posicion];

            row.Tag = idInventario;
            row.Cells["colCodigo"].Value = filaElegida["Codigo"].ToString();
            row.Cells["colProducto"].Value = filaElegida["Nombre"].ToString();
            row.Cells["colTalla"].Value = filaElegida["Talla"].ToString();
            row.Cells["colColor"].Value = filaElegida["Color"].ToString();
            row.Cells["colCantidad"].Value = cantidad;
            row.Cells["colPrecio"].Value = precio.ToString("0.00");
            row.Cells["colSubtotal"].Value = subtotalLinea.ToString("0.00");

            if (tienePromocion)
            {
                MessageBox.Show(
                    "¡Este producto tiene una promoción aplicada! Precio original: $" +
                    precioOriginal.ToString("0.00") +
                    " → Precio con descuento: $" +
                    precio.ToString("0.00"));
            }

            ActualizarTotales();

            cbNVProducto.SelectedIndex = -1;
            cbNVTalla.Items.Clear();
            cbNVColor.Items.Clear();
            nudNVCantidad.Value = 0;
            variantesEncontradas = null;
        }

        private void ActualizarTotales()
        {
            decimal subtotalGeneral = 0;

            foreach (DataGridViewRow fila in dgvNVPA.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                    subtotalGeneral += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
            }

            decimal descuento = nudNVD.Value;
            decimal baseImponible = subtotalGeneral - descuento;

            if (baseImponible < 0)
                baseImponible = 0;

            decimal iva = baseImponible * 0.15m;
            decimal total = baseImponible + iva;

            lblNVD.Text = "$" + subtotalGeneral.ToString("0.00");
            lblNVIVA.Text = "$" + iva.ToString("0.00");
            lblNVTotalPagar.Text = "$" + total.ToString("0.00");
        }

        private void nudNVD_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void btnNVLimpiar_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;

            cbNVVendedor.DataSource = null;
            cbNVVendedor.SelectedIndex = -1;

            cbNVProducto.DataSource = null;
            cbNVProducto.SelectedIndex = -1;

            txtNVCliente.Clear();
            idClienteSeleccionado = 0;

            cbNVTalla.Items.Clear();
            cbNVColor.Items.Clear();

            nudNVCantidad.Value = 0;
            nudNVD.Value = 0;

            dgvNVPA.Rows.Clear();

            variantesEncontradas = null;

            ActualizarTotales();
        }

        private void btnNVCancelar_Click(object sender, EventArgs e)
        {
            if (dgvNVPA.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Hay productos agregados a esta venta. ¿Está seguro de cancelar?",
                    "Cancelar venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.No)
                    return;
            }

            this.Close();
        }

        private void dgvNVPA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columna = dgvNVPA.Columns[e.ColumnIndex].Name;

            if (columna == "colEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Eliminar este producto de la venta?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dgvNVPA.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotales();
                }
            }

            if (columna == "colEditar")
            {
                int cantidadActual = Convert.ToInt32(dgvNVPA.Rows[e.RowIndex].Cells["colCantidad"].Value);

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nueva cantidad:",
                    "Editar producto",
                    cantidadActual.ToString());

                if (int.TryParse(input, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    int idInventario = Convert.ToInt32(dgvNVPA.Rows[e.RowIndex].Tag);

                    DataTable dtStock = conexion.RetornaRegistros(
                        "select Stock from Inventario where IdInventario = " + idInventario);

                    if (dtStock == null || dtStock.Rows.Count == 0)
                    {
                        MessageBox.Show("No se pudo consultar el stock.");
                        return;
                    }

                    int stockDisponible = Convert.ToInt32(dtStock.Rows[0]["Stock"]);

                    if (nuevaCantidad > stockDisponible)
                    {
                        MessageBox.Show("Stock insuficiente. Disponible: " + stockDisponible);
                        return;
                    }

                    decimal precio = Convert.ToDecimal(dgvNVPA.Rows[e.RowIndex].Cells["colPrecio"].Value);
                    decimal nuevoSubtotal = precio * nuevaCantidad;

                    dgvNVPA.Rows[e.RowIndex].Cells["colCantidad"].Value = nuevaCantidad;
                    dgvNVPA.Rows[e.RowIndex].Cells["colSubtotal"].Value = nuevoSubtotal.ToString("0.00");

                    ActualizarTotales();
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Cantidad inválida.");
                }
            }
        }

        private void lblNVMP_Click(object sender, EventArgs e)
        {
        }

        private void btnNVGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            if (cbNVVendedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un vendedor.");
                return;
            }

            // Si no se seleccionó cliente, usar Consumidor Final
            if (idClienteSeleccionado <= 0)
            {
                idClienteSeleccionado = ObtenerConsumidorFinal();

                if (idClienteSeleccionado == 0)
                {
                    MessageBox.Show(
                        "No se encontró el cliente Consumidor Final.",
                        "Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                txtNVCliente.Text = "Consumidor Final";
            }

            if (dgvNVPA.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
                return;
            }

            DataRowView filaSucursal = (DataRowView)comboBox3.SelectedItem;
            DataRowView filaVendedor = (DataRowView)cbNVVendedor.SelectedItem;

            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            int idEmpleado = Convert.ToInt32(filaVendedor["IdEmpleado"]);

            string consultaValidar =
                "select count(*) from Empleados where IdEmpleado = " +
                idEmpleado +
                " and IdSucursal = " +
                idSucursal +
                " and Estado = 1";

            DataTable dtValidar = conexion.RetornaRegistros(consultaValidar);

            if (dtValidar == null || dtValidar.Rows.Count == 0 || Convert.ToInt32(dtValidar.Rows[0][0]) == 0)
            {
                MessageBox.Show(
                    "El vendedor seleccionado no pertenece a la sucursal seleccionada.",
                    "Vendedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvNVPA.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                    subtotal += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
            }

            decimal descuento = nudNVD.Value;
            decimal baseImponible = subtotal - descuento;

            if (baseImponible < 0)
                baseImponible = 0;

            decimal iva = baseImponible * 0.15m;
            decimal total = baseImponible + iva;

            string codigo = venta.GenerarCodigo();
            string metodoPago = cbNVMP.SelectedItem.ToString();

            bool guardado = venta.Registrar(
                codigo, dtpNV.Value, dateTimePicker2.Value.TimeOfDay,
                idEmpleado, idSucursal, idClienteSeleccionado,
                subtotal, descuento, iva, total, metodoPago, dgvNVPA);

            if (guardado)
            {
                csConectaSQL conexionActividad = new csConectaSQL();

                conexionActividad.RegistrarActividad(
                    "Se registró la venta " +
                    codigo +
                    " por $" +
                    total.ToString("0.00"));

                MessageBox.Show(
                    "Venta registrada correctamente. Código: " + codigo,
                    "Venta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo registrar la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnlNVinfo_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}