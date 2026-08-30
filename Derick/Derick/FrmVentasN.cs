using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmVentasN : Form
    {
        public FrmVentasN()
        {
            InitializeComponent();
        }


        private void btnNVAgregar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void lblSalirV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVentasN_Load_1(object sender, EventArgs e)
        {
            //diseño del datagridview
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

            //encabezado
            dgvNVPA.ColumnHeadersHeight = 50;
            dgvNVPA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVPA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVPA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVPA.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVPA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvNVPA.RowTemplate.Height = 45;
            dgvNVPA.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVPA.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVPA.DefaultCellStyle.BackColor = Color.White;
            dgvNVPA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVPA.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVPA.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVPA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVPA.DefaultCellStyle.Padding = new Padding(5);

            //columnas
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

            DataGridViewImageColumn Editar = (DataGridViewImageColumn)dgvNVPA.Columns["colEditar"];
            Editar.Image = Properties.Resources.editarrbtn;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn Eliminar = (DataGridViewImageColumn)dgvNVPA.Columns["colEliminar"];
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


            foreach (string columna in columnasCentro)
            {
                dgvNVPA.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }


            dtpNV.Value = DateTime.Now;
            dtpNV.Enabled = false;

            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.Enabled = false;

            CargarVendedores();
            CargarSucursales();

            cbNVMP.Items.Add("Efectivo");
            cbNVMP.Items.Add("Tarjeta");
            cbNVMP.Items.Add("Transferencia");
            cbNVMP.SelectedIndex = 0;
        }



        private csConectaSQL conexion = new csConectaSQL();
        private int idClienteSeleccionado;
        private DataTable variantesEncontradas;

        private void CargarVendedores()
        {
            DataTable tabla = conexion.RetornaRegistros(
                "SELECT IdEmpleado, Nombres + ' ' + Apellidos AS Nombre FROM Empleados WHERE Estado = 1");

            cbNVVendedor.DataSource = tabla;
            cbNVVendedor.DisplayMember = "Nombre";
            cbNVVendedor.ValueMember = "IdEmpleado";
            cbNVVendedor.SelectedIndex = -1;
        }

        private void CargarSucursales()
        {
            DataTable tabla = conexion.RetornaRegistros(
                "SELECT IdSucursal, NombreSucursal FROM Sucursales WHERE NombreSucursal IS NOT NULL");

            comboBox3.DataSource = tabla;
            comboBox3.DisplayMember = "NombreSucursal";
            comboBox3.ValueMember = "IdSucursal";
            comboBox3.SelectedIndex = -1;
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
        private void BuscarProducto()
        {
            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Busque un producto primero.");
                return;
            }

            if (cbNVTalla.SelectedIndex == -1 || cbNVColor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione talla y color.");
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
                MessageBox.Show("Combinación no encontrada.");
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

            decimal precio = Convert.ToDecimal(filaElegida["Precio"]);
            int idProducto = Convert.ToInt32(filaElegida["IdProductos"]);

            DataRowView filaSucursalActual = (DataRowView)comboBox3.SelectedItem;
            int idSucursalActual = Convert.ToInt32(filaSucursalActual["IdSucursal"]);

            string consultaPromo = @"
    SELECT TOP 1 TipoDescuento, ValorDescuento
    FROM Promociones P
    WHERE P.Estado = 1
    AND CAST(GETDATE() AS DATE) BETWEEN P.FechaInicio AND P.FechaFin
    AND (P.IdSucursal IS NULL OR P.IdSucursal = " + idSucursalActual + @")
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

            int posicion = dgvNVPA.Rows.Add();
            DataGridViewRow row = dgvNVPA.Rows[posicion];

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

            txtNVBuscarProducto.Clear();
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
                {
                    subtotalGeneral += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
                }
            }

            decimal descuento = nudNVD.Value;
            decimal baseImponible = subtotalGeneral - descuento;

            if (baseImponible < 0)
            {
                baseImponible = 0;
            }

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
            cbNVVendedor.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            txtNVCliente.Text = "";
            idClienteSeleccionado = 0;

            txtNVBuscarProducto.Clear();
            nudNVCantidad.Value = 0;
            nudNVD.Value = 0;

            ActualizarTotales();

            txtNVBuscarProducto.Focus();
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
                {
                    return;
                }
            }

            this.Close();
        }

        private void dgvNVPA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

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
                    "Nueva cantidad:", "Editar producto", cantidadActual.ToString());

                if (int.TryParse(input, out int nuevaCantidad) && nuevaCantidad > 0)
                {
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

        private void picNVBP_Click(object sender, EventArgs e)
        {
            BuscarVariantes();
        }

        private void BuscarVariantes()
        {
            string texto = txtNVBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese el código o nombre del producto.");
                return;
            }

            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione primero una sucursal.");
                return;
            }

            DataRowView filaSucursal = (DataRowView)comboBox3.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            string textoEsc = texto.Replace("'", "''");

            string consulta = @"select I.IdInventario, P.IdProductos, P.Codigo, P.Nombre, I.Talla, I.Color, P.Precio, I.Stock
                         from Inventario I inner join Productos P on I.IdProducto = P.IdProductos
                         where I.IdSucursal = " + idSucursal + @"
                         and (P.Codigo = '" + textoEsc + @"' or P.Nombre LIKE '%" + textoEsc + @"%')
                         and I.Estado = 1";

            variantesEncontradas = conexion.RetornaRegistros(consulta);

            cbNVTalla.Items.Clear();
            cbNVColor.Items.Clear();

            if (variantesEncontradas == null || variantesEncontradas.Rows.Count == 0)
            {
                MessageBox.Show("Producto no encontrado en esta sucursal.");
                return;
            }

            // Verificar si hay más de un PRODUCTO distinto (no solo variantes)
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

            // Solo un producto: continúa igual que antes
            List<string> tallasUnicas = new List<string>();
            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                string talla = fila["Talla"].ToString();
                if (!tallasUnicas.Contains(talla))
                {
                    tallasUnicas.Add(talla);
                    cbNVTalla.Items.Add(talla);
                }
            }

            if (cbNVTalla.Items.Count == 1)
            {
                cbNVTalla.SelectedIndex = 0;
            }
            else
            {
                cbNVTalla.SelectedIndex = -1;
            }
        }

        private void cbNVTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variantesEncontradas == null || cbNVTalla.SelectedIndex == -1) return;

            string tallaElegida = cbNVTalla.SelectedItem.ToString();

            cbNVColor.Items.Clear();
            foreach (DataRow fila in variantesEncontradas.Rows)
            {
                if (fila["Talla"].ToString() == tallaElegida)
                {
                    string color = fila["Color"].ToString();
                    if (!cbNVColor.Items.Contains(color))
                    {
                        cbNVColor.Items.Add(color);
                    }
                }
            }

            if (cbNVColor.Items.Count == 1)
            {
                cbNVColor.SelectedIndex = 0;
            }
        }

        private void lblNVMP_Click(object sender, EventArgs e)
        {

        }

        private csVenta venta = new csVenta();

        private void btnNVGuardar_Click(object sender, EventArgs e)
        {
            if (cbNVVendedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un vendedor.");
                return;
            }

            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            if (idClienteSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (dgvNVPA.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
                return;
            }

            DataRowView filaVendedor = (DataRowView)cbNVVendedor.SelectedItem;
            int idEmpleado = Convert.ToInt32(filaVendedor["IdEmpleado"]);

            DataRowView filaSucursal = (DataRowView)comboBox3.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);

            decimal subtotal = 0;
            foreach (DataGridViewRow fila in dgvNVPA.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["colSubtotal"].Value);
            }

            decimal descuento = nudNVD.Value;
            decimal baseImponible = subtotal - descuento;
            if (baseImponible < 0) baseImponible = 0;

            decimal iva = baseImponible * 0.15m;
            decimal total = baseImponible + iva;

            string codigo = venta.GenerarCodigo();
            string metodoPago = cbNVMP.SelectedItem.ToString();

            bool guardado = venta.Registrar(
                codigo,
                dtpNV.Value,
                dateTimePicker2.Value.TimeOfDay,
                idEmpleado,
                idSucursal,
                idClienteSeleccionado,
                subtotal,
                descuento,
                iva,
                total,
                metodoPago,
                dgvNVPA
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

        private void pnlNVinfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
