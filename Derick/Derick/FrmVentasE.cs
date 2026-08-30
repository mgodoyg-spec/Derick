using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmVentasE : Form
    {
        public int idEmpleadoSesion;
        public int idSucursalSesion;
        public string nombreVendedorSesion;
        public string nombreSucursalSesion;

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
            //diseño del datagridview
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

            //encabezado
            dgvNVPAE.ColumnHeadersHeight = 50;
            dgvNVPAE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVPAE.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVPAE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVPAE.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVPAE.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvNVPAE.RowTemplate.Height = 45;
            dgvNVPAE.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVPAE.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVPAE.DefaultCellStyle.BackColor = Color.White;
            dgvNVPAE.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVPAE.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVPAE.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVPAE.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVPAE.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvNVPAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNVPAE.Columns["colCodigo"].FillWeight = 10;
            dgvNVPAE.Columns["colProducto"].FillWeight = 20;
            dgvNVPAE.Columns["colTalla"].FillWeight = 10;
            dgvNVPAE.Columns["colColor"].FillWeight = 12;
            dgvNVPAE.Columns["colCantidad"].FillWeight = 12;
            dgvNVPAE.Columns["colPrecio"].FillWeight = 12;
            dgvNVPAE.Columns["colSubtotal"].FillWeight = 14;
            dgvNVPAE.Columns["colEditar"].FillWeight = 8;
            dgvNVPAE.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn Editar = (DataGridViewImageColumn)dgvNVPAE.Columns["colEditar"];
            Editar.Image = Properties.Resources.editarrbtn;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn Eliminar = (DataGridViewImageColumn)dgvNVPAE.Columns["colEliminar"];
            Eliminar.Image = Properties.Resources.picEliminar;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //columnas centradas
            string[] columnasCentro =
                {
    "colCodigo",
    "colProducto",
    "colTalla",
    "colColor",
    "colCantidad",
    "colPrecio",
    "colSubtotal",
    "colEditar",
    "colEliminar"
};
            dtpNVF.Value = DateTime.Now;
            dtpNVF.Enabled = false;

            dtpNVEH.Value = DateTime.Now;
            dtpNVEH.Enabled = false;

            txtVE.Text = nombreVendedorSesion;
            txtVE.Enabled = false;

            txtSE.Text = nombreSucursalSesion;
            txtSE.Enabled = false;

            cbNVMPE.Items.Clear();
            cbNVMPE.Items.Add("Efectivo");
            cbNVMPE.Items.Add("Tarjeta");
            cbNVMPE.Items.Add("Transferencia");
            cbNVMPE.SelectedIndex = 0;
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

        private void picNVBPE_Click(object sender, EventArgs e)
        {
            BuscarVariantes();
        }

        private void BuscarVariantes()
        {
            string texto = txtNVBuscarProductoE.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese el código o nombre del producto.");
                return;
            }

            string textoEsc = texto.Replace("'", "''");

            string consulta = @"select I.IdInventario, P.IdProductos, P.Codigo, P.Nombre, I.Talla, I.Color, P.Precio, I.Stock
                         from Inventario I inner join Productos P on I.IdProducto = P.IdProductos
                         where I.IdSucursal = " + idSucursalSesion + @"
                         and (P.Codigo = '" + textoEsc + @"' or P.Nombre LIKE '%" + textoEsc + @"%')
                         and I.Estado = 1";

            variantesEncontradas = conexion.RetornaRegistros(consulta);

            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();

            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Producto no encontrado en su sucursal.");
                return;
            }

            List<int> idsProductosUnicos = new List<int>();
            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                int idProd = Convert.ToInt32(fila["IdProductos"]);
                if (!idsProductosUnicos.Contains(idProd))
                {
                    idsProductosUnicos.Add(idProd);
                }
            }

            if (idsProductosUnicos.Count > 1)
            {
                string nombresEncontrados = "Se encontraron varios productos, sea más específico:\n\n";
                List<string> nombresUnicos = new List<string>();
                foreach (DataRow fila in variantesEncontradas.Rows)
                {
                    string nombre = fila["Nombre"].ToString();
                    if (!nombresUnicos.Contains(nombre))
                    {
                        nombresUnicos.Add(nombre);
                        nombresEncontrados += "- " + nombre + "\n";
                    }
                }

                MessageBox.Show(nombresEncontrados);
                variantesEncontradas = null;
                return;
            }

            List<string> tallasUnicas = new List<string>();
            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                string talla = fila["Talla"].ToString();
                if (!tallasUnicas.Contains(talla))
                {
                    tallasUnicas.Add(talla);
                    cbNVTallaE.Items.Add(talla);
                }
            }

            if (cbNVTallaE.Items.Count == 1)
            {
                cbNVTallaE.SelectedIndex = 0;
            }
            else
            {
                cbNVTallaE.SelectedIndex = -1;
            }
        }

        private void cbNVTallaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variantesEncontradas == null || cbNVTallaE.SelectedIndex == -1) return;

            string tallaElegida = cbNVTallaE.SelectedItem.ToString();

            cbNVColorE.Items.Clear();
            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() == tallaElegida)
                {
                    string color = fila["Color"].ToString();
                    if (!cbNVColorE.Items.Contains(color))
                    {
                        cbNVColorE.Items.Add(color);
                    }
                }
            }

            if (cbNVColorE.Items.Count == 1)
            {
                cbNVColorE.SelectedIndex = 0;
            }
        }

        private void btnNVAgregarE_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Busque un producto primero.");
                return;
            }

            if (cbNVTallaE.SelectedIndex == -1 || cbNVColorE.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione talla y color.");
                return;
            }

            string tallaElegida = cbNVTallaE.SelectedItem.ToString();
            string colorElegido = cbNVColorE.SelectedItem.ToString();

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
                MessageBox.Show("Combinación no encontrada.");
                return;
            }

            int stockDisponible = Convert.ToInt32(filaElegida["Stock"]);
            int cantidad = (int)nudNVCantidadE.Value;

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

            decimal precio = Convert.ToDecimal(filaElegida["Precio"]);
            int idProducto = Convert.ToInt32(filaElegida["IdProductos"]);

            string consultaPromo = @"
                SELECT TOP 1 TipoDescuento, ValorDescuento
                FROM Promociones P
                WHERE P.Estado = 1
                AND CAST(GETDATE() AS DATE) BETWEEN P.FechaInicio AND P.FechaFin
                AND (P.IdSucursal IS NULL OR P.IdSucursal = " + idSucursalSesion + @")
                AND (
                    P.AplicaTodos = 1
                    OR EXISTS (SELECT 1 FROM PromocionProducto PP WHERE PP.IdPromocion = P.IdPromocion AND PP.IdProducto = " + idProducto + @")
                )
                ORDER BY P.ValorDescuento DESC";

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
                    if (precio < 0) precio = 0;
                }

                tienePromocion = true;
            }

            decimal subtotalLinea = precio * cantidad;

            int posicion = dgvNVPAE.Rows.Add();
            DataGridViewRow row = dgvNVPAE.Rows[posicion];

            row.Tag = Convert.ToInt32(filaElegida["IdInventario"]);
            row.Cells["colCodigo"].Value = filaElegida["Codigo"].ToString();
            row.Cells["colProducto"].Value = filaElegida["Nombre"].ToString();
            row.Cells["colTalla"].Value = filaElegida["Talla"].ToString();
            row.Cells["colColor"].Value = filaElegida["Color"].ToString();
            row.Cells["colCantidad"].Value = cantidad;
            row.Cells["colPrecio"].Value = precio.ToString("0.00");
            row.Cells["colSubtotal"].Value = subtotalLinea.ToString("0.00");

            if (tienePromocion)
            {
                MessageBox.Show("¡Este producto tiene una promoción aplicada! Precio original: $" +
                    precioOriginal.ToString("0.00") + " → Precio con descuento: $" + precio.ToString("0.00"));
            }

            ActualizarTotales();

            txtNVBuscarProductoE.Clear();
            cbNVTallaE.Items.Clear();
            cbNVColorE.Items.Clear();
            nudNVCantidadE.Value = 0;
            variantesEncontradas = null;
        }

        private void dgvNVPAE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columna = dgvNVPAE.Columns[e.ColumnIndex].Name;

            if (columna == "colEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Eliminar este producto de la venta?",
                    "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dgvNVPAE.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotales();
                }
            }

            if (columna == "colEditar")
            {
                int cantidadActual = Convert.ToInt32(dgvNVPAE.Rows[e.RowIndex].Cells["colCantidad"].Value);

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nueva cantidad:", "Editar producto", cantidadActual.ToString());

                if (int.TryParse(input, out int nuevaCantidad) && nuevaCantidad > 0)
                {
                    decimal precio = Convert.ToDecimal(dgvNVPAE.Rows[e.RowIndex].Cells["colPrecio"].Value);
                    decimal nuevoSubtotal = precio * nuevaCantidad;

                    dgvNVPAE.Rows[e.RowIndex].Cells["colCantidad"].Value = nuevaCantidad;
                    dgvNVPAE.Rows[e.RowIndex].Cells["colSubtotal"].Value = nuevoSubtotal.ToString("0.00");

                    ActualizarTotales();
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Cantidad inválida.");
                }
            }
        }

        private void ActualizarTotales()
        {
            decimal subtotalGeneral = 0;

            foreach (DataGridViewRow fila in dgvNVPAE.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                {
                    subtotalGeneral += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
                }
            }

            decimal descuento = nudNVDE.Value;
            decimal baseImponible = subtotalGeneral - descuento;

            if (baseImponible < 0)
            {
                baseImponible = 0;
            }

            decimal iva = baseImponible * 0.15m;
            decimal total = baseImponible + iva;

            lblNVDE.Text = "$" + subtotalGeneral.ToString("0.00");
            lblNVIVAE.Text = "$" + iva.ToString("0.00");
            lblNVTotalPagarE.Text = "$" + total.ToString("0.00");
        }

        private void nudNVDE_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void btnNVLimpiarE_Click(object sender, EventArgs e)
        {
            txtCE.Text = "";
            idClienteSeleccionado = 0;

            txtNVBuscarProductoE.Clear();
            nudNVCantidadE.Value = 0;
            nudNVDE.Value = 0;

            ActualizarTotales();

            txtNVBuscarProductoE.Focus();
        }

        private void btnNVCancelarE_Click(object sender, EventArgs e)
        {
            if (dgvNVPAE.Rows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Hay productos agregados a esta venta. ¿Está seguro de cancelar?",
                    "Cancelar venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }

        private void btnNVGuardarE_Click(object sender, EventArgs e)
        {
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
            foreach (DataGridViewRow fila in dgvNVPAE.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
            }

            decimal descuento = nudNVDE.Value;
            decimal baseImponible = subtotal - descuento;
            if (baseImponible < 0) baseImponible = 0;

            decimal iva = baseImponible * 0.15m;
            decimal total = baseImponible + iva;

            string codigo = venta.GenerarCodigo();
            string metodoPago = cbNVMPE.SelectedItem.ToString();

            bool guardado = venta.Registrar(
                codigo,
                dtpNVF.Value,
                dtpNVEH.Value.TimeOfDay,
                idEmpleadoSesion,
                idSucursalSesion,
                idClienteSeleccionado,
                subtotal,
                descuento,
                iva,
                total,
                metodoPago,
                dgvNVPAE
            );

            if (guardado)
            {
                MessageBox.Show("Venta registrada correctamente. Código: " + codigo);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta.");
            }
        }

        private void lblSalirVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
