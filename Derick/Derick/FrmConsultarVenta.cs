using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Derick
{
    public partial class FrmConsultarVenta : Form
    {
        public FrmConsultarVenta()
        {
            InitializeComponent();
        }

        private void lblSalirCV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
           "¿Está seguro de salir?",
           "Confirmar salida",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentasN frm = new FrmVentasN();
            frm.ShowDialog();
        }

        private csConectaSQL conexion = new csConectaSQL();
        private int idVentaImprimir;
        private void FrmConsultarVenta_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvCVF.EnableHeadersVisualStyles = false;
            dgvCVF.BorderStyle = BorderStyle.None;
            dgvCVF.BackgroundColor = Color.White;
            dgvCVF.GridColor = Color.FromArgb(235, 235, 235);
            dgvCVF.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCVF.ReadOnly = true;
            dgvCVF.MultiSelect = false;
            dgvCVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCVF.AllowUserToAddRows = false;
            dgvCVF.AllowUserToDeleteRows = false;
            dgvCVF.AllowUserToResizeRows = false;
            dgvCVF.AllowUserToResizeColumns = false;
            dgvCVF.RowHeadersVisible = false;

            //encabezado
            dgvCVF.ColumnHeadersHeight = 50;
            dgvCVF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCVF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvCVF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCVF.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCVF.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvCVF.RowTemplate.Height = 45;
            dgvCVF.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCVF.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvCVF.DefaultCellStyle.BackColor = Color.White;
            dgvCVF.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvCVF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvCVF.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCVF.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCVF.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvCVF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCVF.Columns["colCodigo"].FillWeight = 10;
            dgvCVF.Columns["colFecha"].FillWeight = 12;
            dgvCVF.Columns["colHora"].FillWeight = 10;
            dgvCVF.Columns["colVendedor"].FillWeight = 16;
            dgvCVF.Columns["colSucursal"].FillWeight = 14;
            dgvCVF.Columns["colCliente"].FillWeight = 16;
            dgvCVF.Columns["colSubtotal"].FillWeight = 12;
            dgvCVF.Columns["colDescuento"].FillWeight = 12;
            dgvCVF.Columns["colTotal"].FillWeight = 12;
            dgvCVF.Columns["colEstado"].FillWeight = 10;
            dgvCVF.Columns["colEditar"].FillWeight = 8;
            dgvCVF.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn VerDetalle = (DataGridViewImageColumn)dgvCVF.Columns["colEditar"];
            VerDetalle.Image = Properties.Resources.ojo; 
            VerDetalle.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvCVF.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dtpCVDesde.MinDate = new DateTime(2026, 1, 1); // fecha razonable de inicio
            dtpCVFechaHasta.MaxDate = DateTime.Today;            // siempre "hoy", se recalcula cada vez que se abre el form
            dtpCVFechaHasta.MinDate = dtpCVDesde.MinDate;
            dtpCVDesde.MaxDate = DateTime.Today;

            dtpCVDesde.Value = DateTime.Today;
            dtpCVFechaHasta.Value = DateTime.Today;

            dtpCVDesde.MaxDate = DateTime.Today;
            dtpCVFechaHasta.MaxDate = DateTime.Today;

            cbCVEstado.Items.Clear();
            cbCVEstado.Items.Add("Todos");
            cbCVEstado.Items.Add("Activo");
            cbCVEstado.Items.Add("Anulado");
            cbCVEstado.SelectedIndex = 0;

            Buscar();

            //columnas centradas
            string[] columnasCentro =
            {
    "colCodigo",
    "colFecha",
    "colHora",
    "colVendedor",
    "colSucursal",
    "colCliente",
    "colSubtotal",
    "colDescuento",
    "colTotal",
    "colEstado",
    "colEditar",
    "colEliminar"
};

            foreach (string columna in columnasCentro)
            {
                dgvCVF.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Buscar()
        {
            DateTime fechaDesde = dtpCVDesde.Value.Date;
            DateTime fechaHasta = dtpCVFechaHasta.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'desde' no puede ser mayor que la fecha 'hasta'.");
                return;
            }

            string consulta = @"
    SELECT V.IdVentas, V.Codigo, V.Fecha, V.Hora,
           E.Nombres + ' ' + E.Apellidos AS Vendedor,
           S.NombreSucursal AS Sucursal,
           C.Nombres + ' ' + C.Apellidos AS Cliente,
           V.Subtotal, V.Descuento, V.Total, V.Estado
    FROM Ventas V
    INNER JOIN Empleados E ON V.IdEmpleado = E.IdEmpleado
    INNER JOIN Sucursales S ON V.IdSucursal = S.IdSucursal
    INNER JOIN Clientes C ON V.IdCliente = C.IdCliente
    WHERE V.Fecha BETWEEN '" + fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + "'";

            if (cbCVEstado.SelectedItem != null)
            {
                string estado = cbCVEstado.SelectedItem.ToString();

                if (estado == "Activo")
                {
                    consulta += " AND V.Estado = 1";
                }

                if (estado == "Anulado")
                {
                    consulta += " AND V.Estado = 0";
                }
            }

            consulta += " ORDER BY V.Fecha DESC, V.Hora DESC";

            DataTable dt = conexion.RetornaRegistros(consulta);

            dgvCVF.Rows.Clear();

            if (dt == null) return;

            foreach (DataRow fila in dt.Rows)
            {
                int posicion = dgvCVF.Rows.Add();
                DataGridViewRow row = dgvCVF.Rows[posicion];

                row.Tag = Convert.ToInt32(fila["IdVentas"]);
                row.Cells["colCodigo"].Value = fila["Codigo"].ToString();
                row.Cells["colFecha"].Value = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM/yyyy");
                row.Cells["colHora"].Value = fila["Hora"].ToString();
                row.Cells["colVendedor"].Value = fila["Vendedor"].ToString();
                row.Cells["colSucursal"].Value = fila["Sucursal"].ToString();
                row.Cells["colCliente"].Value = fila["Cliente"].ToString();
                row.Cells["colSubtotal"].Value = Convert.ToDecimal(fila["Subtotal"]).ToString("0.00");
                row.Cells["colDescuento"].Value = Convert.ToDecimal(fila["Descuento"]).ToString("0.00");
                row.Cells["colTotal"].Value = Convert.ToDecimal(fila["Total"]).ToString("0.00");

                bool estado = Convert.ToBoolean(fila["Estado"]);
                row.Cells["colEstado"].Value = estado ? "Activo" : "Anulado";
            }
        }
        private void btnCVBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnCVLimpiar_Click(object sender, EventArgs e)
        {
            dtpCVDesde.Value = DateTime.Today;
            dtpCVFechaHasta.Value = DateTime.Today;
            cbCVEstado.SelectedIndex = 0;
            Buscar();
        }
        private void dgvCVF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string columna = dgvCVF.Columns[e.ColumnIndex].Name;
            int idVenta = Convert.ToInt32(dgvCVF.Rows[e.RowIndex].Tag);

            if (columna == "colEliminar")
            {
                string estadoActual = dgvCVF.Rows[e.RowIndex].Cells["colEstado"].Value.ToString();

                if (estadoActual == "Anulado")
                {
                    MessageBox.Show("Esta venta ya está anulada.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Anular esta venta? Se devolverá el stock de los productos al inventario.",
                    "Anular venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    bool anulado = AnularVenta(idVenta);

                    if (anulado)
                    {
                        MessageBox.Show("Venta anulada correctamente.");
                        Buscar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la venta.");
                    }
                }
            }

            if (columna == "colEditar")
            {
                VerDetalleVenta(idVenta);
            }
        }
        private bool AnularVenta(int idVenta)
        {
            string sqlAnular = "UPDATE Ventas SET Estado = 0 WHERE IdVentas = @IdVenta";

            return conexion.ejecutarComando(sqlAnular,
                new SqlParameter("@IdVenta", idVenta)
            );
        }
        private void VerDetalleVenta(int idVenta)
        {
            string consultaProductos = @"
        SELECT P.Nombre, D.Cantidad, D.PrecioUnitario, D.Subtotal
        FROM DetalleVenta D
        INNER JOIN Productos P ON D.IdProducto = P.IdProductos
        WHERE D.IdVenta = " + idVenta;

            DataTable dtProductos = conexion.RetornaRegistros(consultaProductos);

            string consultaVenta = "SELECT IVA FROM Ventas WHERE IdVentas = " + idVenta;
            DataTable dtVenta = conexion.RetornaRegistros(consultaVenta);

            if (dtProductos == null || dtProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron productos para esta venta.");
                return;
            }

            string detalle = "PRODUCTOS:\n";
            detalle += "----------------------------------------\n";

            foreach (DataRow fila in dtProductos.Rows)
            {
                string nombre = fila["Nombre"].ToString();
                int cantidad = Convert.ToInt32(fila["Cantidad"]);
                decimal subtotalLinea = Convert.ToDecimal(fila["Subtotal"]);

                detalle += nombre + "\n";
                detalle += "   Cantidad: " + cantidad + "    Subtotal: $" + subtotalLinea.ToString("0.00") + "\n\n";
            }

            if (dtVenta != null && dtVenta.Rows.Count > 0)
            {
                decimal iva = Convert.ToDecimal(dtVenta.Rows[0]["IVA"]);
                detalle += "----------------------------------------\n";
                detalle += "IVA (15%): $" + iva.ToString("0.00");
            }

            MessageBox.Show(detalle, "Detalle de venta - Productos e IVA");
        }
        private void btnCVImprimir_Click(object sender, EventArgs e)
        {
            if (dgvCVF.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para imprimir.");
                return;
            }

            idVentaImprimir = Convert.ToInt32(dgvCVF.SelectedRows[0].Tag);

            PrintDocument documento = new PrintDocument();
            documento.PrintPage += Documento_PrintPage;

            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = documento;
            vistaPrevia.Width = 800;
            vistaPrevia.Height = 600;
            vistaPrevia.ShowDialog();
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 10);
            Font fuenteNegrita = new Font("Arial", 10, FontStyle.Bold);

            int y = 40;

            // Datos de la venta (encabezado)
            string consultaVenta = @"
        SELECT V.Codigo, V.Fecha, V.Hora,
               E.Nombres + ' ' + E.Apellidos AS Vendedor,
               S.NombreSucursal, C.Nombres + ' ' + C.Apellidos AS Cliente,
               V.Subtotal, V.Descuento, V.IVA, V.Total, V.MetodoPago
        FROM Ventas V
        INNER JOIN Empleados E ON V.IdEmpleado = E.IdEmpleado
        INNER JOIN Sucursales S ON V.IdSucursal = S.IdSucursal
        INNER JOIN Clientes C ON V.IdCliente = C.IdCliente
        WHERE V.IdVentas = " + idVentaImprimir;

            DataTable dtVenta = conexion.RetornaRegistros(consultaVenta);

            if (dtVenta == null || dtVenta.Rows.Count == 0) return;

            DataRow venta = dtVenta.Rows[0];

            g.DrawString("FACTURA DE VENTA", fuenteTitulo, Brushes.Black, 40, y);
            y += 40;

            g.DrawString("Código: " + venta["Codigo"], fuenteNormal, Brushes.Black, 40, y);
            y += 20;
            g.DrawString("Fecha: " + Convert.ToDateTime(venta["Fecha"]).ToString("dd/MM/yyyy") + "   Hora: " + venta["Hora"], fuenteNormal, Brushes.Black, 40, y);
            y += 20;
            g.DrawString("Vendedor: " + venta["Vendedor"], fuenteNormal, Brushes.Black, 40, y);
            y += 20;
            g.DrawString("Sucursal: " + venta["NombreSucursal"], fuenteNormal, Brushes.Black, 40, y);
            y += 20;
            g.DrawString("Cliente: " + venta["Cliente"], fuenteNormal, Brushes.Black, 40, y);
            y += 20;
            g.DrawString("Método de pago: " + venta["MetodoPago"], fuenteNormal, Brushes.Black, 40, y);
            y += 40;

            // Encabezado de la tabla de productos
            g.DrawString("Producto", fuenteNegrita, Brushes.Black, 40, y);
            g.DrawString("Cant.", fuenteNegrita, Brushes.Black, 280, y);
            g.DrawString("Precio", fuenteNegrita, Brushes.Black, 350, y);
            g.DrawString("Subtotal", fuenteNegrita, Brushes.Black, 430, y);
            y += 20;
            g.DrawLine(Pens.Black, 40, y, 520, y);
            y += 10;

            string consultaDetalle = @"
        SELECT P.Nombre, D.Cantidad, D.PrecioUnitario, D.Subtotal
        FROM DetalleVenta D
        INNER JOIN Productos P ON D.IdProducto = P.IdProductos
        WHERE D.IdVenta = " + idVentaImprimir;

            DataTable dtDetalle = conexion.RetornaRegistros(consultaDetalle);

            if (dtDetalle != null)
            {
                foreach (DataRow fila in dtDetalle.Rows)
                {
                    g.DrawString(fila["Nombre"].ToString(), fuenteNormal, Brushes.Black, 40, y);
                    g.DrawString(fila["Cantidad"].ToString(), fuenteNormal, Brushes.Black, 280, y);
                    g.DrawString(Convert.ToDecimal(fila["PrecioUnitario"]).ToString("0.00"), fuenteNormal, Brushes.Black, 350, y);
                    g.DrawString(Convert.ToDecimal(fila["Subtotal"]).ToString("0.00"), fuenteNormal, Brushes.Black, 430, y);
                    y += 20;
                }
            }

            y += 20;
            g.DrawLine(Pens.Black, 40, y, 520, y);
            y += 20;

            g.DrawString("Subtotal: $" + Convert.ToDecimal(venta["Subtotal"]).ToString("0.00"), fuenteNormal, Brushes.Black, 350, y);
            y += 20;
            g.DrawString("Descuento: $" + Convert.ToDecimal(venta["Descuento"]).ToString("0.00"), fuenteNormal, Brushes.Black, 350, y);
            y += 20;
            g.DrawString("IVA: $" + Convert.ToDecimal(venta["IVA"]).ToString("0.00"), fuenteNormal, Brushes.Black, 350, y);
            y += 20;
            g.DrawString("Total: $" + Convert.ToDecimal(venta["Total"]).ToString("0.00"), fuenteNegrita, Brushes.Black, 350, y);
        }
    }
}
