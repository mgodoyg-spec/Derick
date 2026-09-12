using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmVentasE : Form
    {
        public int idEmpleadoSesion, idSucursalSesion;
        public string nombreVendedorSesion, nombreSucursalSesion;

        private csConectaSQL conexion = new csConectaSQL();
        private csVenta venta = new csVenta();
        private DataTable variantesEncontradas;
        private int idClienteSeleccionado;

        public FrmVentasE()
        {
            InitializeComponent();
        }

        private void FrmVentasE_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleadoSesion();
            CargarProductos();

            cbNVProductoE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNVTallaE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNVColorE.DropDownStyle = ComboBoxStyle.DropDownList;

            cbNVProductoE.SelectionChangeCommitted -= cbNVProductoE_SelectionChangeCommitted;
            cbNVProductoE.SelectionChangeCommitted += cbNVProductoE_SelectionChangeCommitted;
            cbNVTallaE.SelectedIndexChanged -= cbNVTallaE_SelectedIndexChanged;
            cbNVTallaE.SelectedIndexChanged += cbNVTallaE_SelectedIndexChanged;

            dgvNVPAE.EnableHeadersVisualStyles = false;
            dgvNVPAE.BorderStyle = BorderStyle.None;
            dgvNVPAE.BackgroundColor = Color.White;
            dgvNVPAE.GridColor = Color.FromArgb(235, 235, 235);
            dgvNVPAE.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPAE.ReadOnly = true;
            dgvNVPAE.MultiSelect = false;
            dgvNVPAE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPAE.AllowUserToAddRows = false;
            dgvNVPAE.AllowUserToDeleteRows = false;
            dgvNVPAE.AllowUserToResizeRows = false;
            dgvNVPAE.AllowUserToResizeColumns = false;
            dgvNVPAE.RowHeadersVisible = false;
            dgvNVPAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNVPAE.ColumnHeadersHeight = 50;
            dgvNVPAE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVPAE.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVPAE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVPAE.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVPAE.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNVPAE.RowTemplate.Height = 45;
            dgvNVPAE.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVPAE.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVPAE.DefaultCellStyle.BackColor = Color.White;
            dgvNVPAE.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVPAE.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVPAE.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVPAE.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVPAE.DefaultCellStyle.Padding = new Padding(5);

            dgvNVPAE.Columns["colCodigo"].FillWeight = 10;
            dgvNVPAE.Columns["colProducto"].FillWeight = 20;
            dgvNVPAE.Columns["colTalla"].FillWeight = 10;
            dgvNVPAE.Columns["colColor"].FillWeight = 12;
            dgvNVPAE.Columns["colCantidad"].FillWeight = 12;
            dgvNVPAE.Columns["colPrecio"].FillWeight = 12;
            dgvNVPAE.Columns["colSubtotal"].FillWeight = 14;
            dgvNVPAE.Columns["colEditar"].FillWeight = 8;
            dgvNVPAE.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvNVPAE.Columns["colEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvNVPAE.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dtpNVF.Value = DateTime.Now;
            dtpNVF.Enabled = false;
            dtpNVEH.Value = DateTime.Now;
            dtpNVEH.Enabled = false;

            cbNVMPE.Items.Clear();
            cbNVMPE.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cbNVMPE.SelectedIndex = 0;
        }

        private void CargarDatosEmpleadoSesion()
        {
            idEmpleadoSesion = csSesion.ObtenerIdEmpleadoActual();

            if (idEmpleadoSesion <= 0)
            {
                MessageBox.Show("No se pudo identificar al empleado que inició sesión.");
                return;
            }

            DataTable dt = conexion.RetornaRegistros("select E.IdEmpleado, E.Nombres + ' ' + E.Apellidos as Vendedor, E.IdSucursal, S.NombreSucursal from Empleados E inner join Sucursales S on E.IdSucursal = S.IdSucursal where E.IdEmpleado = " + idEmpleadoSesion);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron los datos del empleado.");
                return;
            }

            idSucursalSesion = Convert.ToInt32(dt.Rows[0]["IdSucursal"]);
            nombreVendedorSesion = dt.Rows[0]["Vendedor"].ToString();
            nombreSucursalSesion = dt.Rows[0]["NombreSucursal"].ToString();

            txtVE.Text = nombreVendedorSesion;
            txtSE.Text = nombreSucursalSesion;
            txtVE.Enabled = false;
            txtSE.Enabled = false;
        }

        private void CargarProductos()
        {
            if (idSucursalSesion <= 0) return;

            DataTable dt = conexion.RetornaRegistros("select distinct P.IdProductos, P.Codigo + ' - ' + P.Nombre as Producto from Inventario I inner join Productos P on I.IdProducto = P.IdProductos where I.IdSucursal = " + idSucursalSesion + " and I.Stock > 0 and I.Estado = 1 and P.Estado = 1 order by Producto");

            cbNVProductoE.DataSource = dt;
            cbNVProductoE.DisplayMember = "Producto";
            cbNVProductoE.ValueMember = "IdProductos";
            cbNVProductoE.SelectedIndex = -1;

            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();
        }

        private void cbNVProductoE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarVariantes();
        }

        private void BuscarVariantes()
        {
            if (cbNVProductoE.SelectedValue == null || cbNVProductoE.SelectedIndex == -1) return;

            int idProducto = Convert.ToInt32(cbNVProductoE.SelectedValue);

            variantesEncontradas = conexion.RetornaRegistros("select I.IdInventario, P.IdProductos, P.Codigo, P.Nombre, I.Talla, I.Color, P.Precio, I.Stock from Inventario I inner join Productos P on I.IdProducto = P.IdProductos where I.IdSucursal = " + idSucursalSesion + " and P.IdProductos = " + idProducto + " and I.Stock > 0 and I.Estado = 1");

            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();

            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Este producto no tiene stock disponible en esta sucursal.");
                return;
            }

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                string talla = fila["Talla"].ToString();
                if (!cbNVTallaE.Items.Contains(talla)) cbNVTallaE.Items.Add(talla);
            }

            if (cbNVTallaE.Items.Count > 0) cbNVTallaE.SelectedIndex = 0;
        }

        private void cbNVTallaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variantesEncontradas == null || cbNVTallaE.SelectedIndex == -1) return;

            string talla = cbNVTallaE.SelectedItem.ToString();
            cbNVColorE.Items.Clear();

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() != talla) continue;

                string color = fila["Color"].ToString();
                if (!cbNVColorE.Items.Contains(color)) cbNVColorE.Items.Add(color);
            }

            if (cbNVColorE.Items.Count > 0) cbNVColorE.SelectedIndex = 0;
        }

        private void picNVBPE_Click(object sender, EventArgs e)
        {
            BuscarVariantes();
        }

        private void picNVBE_Click(object sender, EventArgs e)
        {
            FrmBuscarClienteV ventana = new FrmBuscarClienteV();

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                txtCE.Text = ventana.NombreClienteSeleccionado;
                idClienteSeleccionado = ventana.IdClienteSeleccionado;
            }
        }

        private void btnNVAgregarE_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            if (cbNVProductoE.SelectedIndex == -1 || variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (cbNVTallaE.SelectedIndex == -1 || cbNVColorE.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione talla y color.");
                return;
            }

            string talla = cbNVTallaE.SelectedItem.ToString(), color = cbNVColorE.SelectedItem.ToString();
            DataRow filaElegida = null;

            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() == talla && fila["Color"].ToString() == color)
                {
                    filaElegida = fila;
                    break;
                }
            }

            if (filaElegida == null)
            {
                MessageBox.Show("Combinación no encontrada.");
                return;
            }

            int stock = Convert.ToInt32(filaElegida["Stock"]), cantidad = (int)nudNVCantidadE.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            if (cantidad > stock)
            {
                MessageBox.Show("Stock insuficiente. Disponible: " + stock);
                return;
            }

            decimal precio = Convert.ToDecimal(filaElegida["Precio"]);
            int idProducto = Convert.ToInt32(filaElegida["IdProductos"]);

            string consultaPromo = "select top 1 TipoDescuento, ValorDescuento from Promociones P where P.Estado = 1 and cast(getdate() as date) between cast(P.FechaInicio as date) and cast(P.FechaFin as date) and (P.IdSucursal is null or P.IdSucursal = " + idSucursalSesion + ") and (P.AplicaTodos = 1 or exists (select 1 from PromocionProducto PP where PP.IdPromocion = P.IdPromocion and PP.IdProducto = " + idProducto + ")) order by P.ValorDescuento desc";
            DataTable dtPromo = conexion.RetornaRegistros(consultaPromo);

            decimal precioOriginal = precio;
            bool tienePromocion = dtPromo != null && dtPromo.Rows.Count > 0;

            if (tienePromocion)
            {
                string tipo = dtPromo.Rows[0]["TipoDescuento"].ToString();
                decimal valor = Convert.ToDecimal(dtPromo.Rows[0]["ValorDescuento"]);

                precio = tipo.ToLower().Contains("porcentual") ? precio - (precio * valor / 100) : precio - valor;
                if (precio < 0) precio = 0;
            }

            decimal subtotal = precio * cantidad;
            int posicion = dgvNVPAE.Rows.Add();
            DataGridViewRow row = dgvNVPAE.Rows[posicion];

            row.Tag = Convert.ToInt32(filaElegida["IdInventario"]);
            row.Cells["colCodigo"].Value = filaElegida["Codigo"].ToString();
            row.Cells["colProducto"].Value = filaElegida["Nombre"].ToString();
            row.Cells["colTalla"].Value = filaElegida["Talla"].ToString();
            row.Cells["colColor"].Value = filaElegida["Color"].ToString();
            row.Cells["colCantidad"].Value = cantidad;
            row.Cells["colPrecio"].Value = precio.ToString("0.00");
            row.Cells["colSubtotal"].Value = subtotal.ToString("0.00");

            if (tienePromocion) MessageBox.Show("¡Promoción aplicada! $" + precioOriginal.ToString("0.00") + " → $" + precio.ToString("0.00"));

            ActualizarTotales();
            cbNVProductoE.SelectedIndex = -1;
            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();
            nudNVCantidadE.Value = 0;
            variantesEncontradas = null;
        }

        private void dgvNVPAE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columna = dgvNVPAE.Columns[e.ColumnIndex].Name;

            if (columna == "colEliminar" && MessageBox.Show("¿Eliminar este producto de la venta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvNVPAE.Rows.RemoveAt(e.RowIndex);
                ActualizarTotales();
            }

            if (columna == "colEditar")
            {
                int cantidadActual = Convert.ToInt32(dgvNVPAE.Rows[e.RowIndex].Cells["colCantidad"].Value);
                string input = Microsoft.VisualBasic.Interaction.InputBox("Nueva cantidad:", "Editar producto", cantidadActual.ToString());

                if (int.TryParse(input, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    decimal precio = Convert.ToDecimal(dgvNVPAE.Rows[e.RowIndex].Cells["colPrecio"].Value);
                    dgvNVPAE.Rows[e.RowIndex].Cells["colCantidad"].Value = nuevaCantidad;
                    dgvNVPAE.Rows[e.RowIndex].Cells["colSubtotal"].Value = (precio * nuevaCantidad).ToString("0.00");
                    ActualizarTotales();
                }
                else if (!string.IsNullOrEmpty(input)) MessageBox.Show("Cantidad inválida.");
            }
        }

        private void ActualizarTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvNVPAE.Rows)
                if (fila.Cells["colSubtotal"].Value != null) subtotal += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);

            decimal descuento = nudNVDE.Value, baseImponible = subtotal - descuento;
            if (baseImponible < 0) baseImponible = 0;

            decimal iva = baseImponible * 0.15m, total = baseImponible + iva;

            lblNVDE.Text = "$" + subtotal.ToString("0.00");
            lblNVIVAE.Text = "$" + iva.ToString("0.00");
            lblNVTotalPagarE.Text = "$" + total.ToString("0.00");
        }

        private void nudNVDE_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void btnNVLimpiarE_Click(object sender, EventArgs e)
        {
            txtCE.Clear();
            idClienteSeleccionado = 0;
            cbNVProductoE.SelectedIndex = -1;
            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();
            nudNVCantidadE.Value = 0;
            nudNVDE.Value = 0;
            dgvNVPAE.Rows.Clear();
            variantesEncontradas = null;
            ActualizarTotales();
        }

        private void btnNVCancelarE_Click(object sender, EventArgs e)
        {
            if (dgvNVPAE.Rows.Count > 0 && MessageBox.Show("Hay productos agregados. ¿Está seguro de cancelar?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            Close();
        }

        private void btnNVGuardarE_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSesion <= 0 || idSucursalSesion <= 0)
            {
                MessageBox.Show("No se pudo identificar al vendedor o su sucursal.");
                return;
            }

            if (idClienteSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (dgvNVPAE.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
                return;
            }

            decimal subtotal = 0;
            foreach (DataGridViewRow fila in dgvNVPAE.Rows) subtotal += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);

            decimal descuento = nudNVDE.Value, baseImponible = subtotal - descuento;
            if (baseImponible < 0) baseImponible = 0;

            decimal iva = baseImponible * 0.15m, total = baseImponible + iva;
            string codigo = venta.GenerarCodigo(), metodoPago = cbNVMPE.SelectedItem.ToString();

            bool guardado = venta.Registrar(codigo, dtpNVF.Value, dtpNVEH.Value.TimeOfDay, idEmpleadoSesion, 
                idSucursalSesion, idClienteSeleccionado, subtotal, descuento, iva, total, metodoPago, dgvNVPAE);

            if (!guardado)
            {
                MessageBox.Show("No se pudo registrar la venta.");
                return;
            }

            MessageBox.Show("Venta registrada correctamente. Código: " + codigo);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblSalirVE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}