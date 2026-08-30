using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmConsultarVE : Form
    {
        public int idEmpleadoSesion;
        public int idSucursalSesion;
        public string nombreVendedorSesion;
        public string nombreSucursalSesion;

        private csConectaSQL conexion = new csConectaSQL();
        private int idVentaImprimir;
        public FrmConsultarVE()
        {
            InitializeComponent();
        }

        private void FrmConsultarVE_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvCVFE.EnableHeadersVisualStyles = false;
            dgvCVFE.BorderStyle = BorderStyle.None;
            dgvCVFE.BackgroundColor = Color.White;
            dgvCVFE.GridColor = Color.FromArgb(235, 235, 235);
            dgvCVFE.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCVFE.ReadOnly = true;
            dgvCVFE.MultiSelect = false;
            dgvCVFE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCVFE.AllowUserToAddRows = false;
            dgvCVFE.AllowUserToDeleteRows = false;
            dgvCVFE.AllowUserToResizeRows = false;
            dgvCVFE.AllowUserToResizeColumns = false;
            dgvCVFE.RowHeadersVisible = false;

            //encabezado
            dgvCVFE.ColumnHeadersHeight = 50;
            dgvCVFE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCVFE.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvCVFE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCVFE.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCVFE.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvCVFE.RowTemplate.Height = 45;
            dgvCVFE.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCVFE.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvCVFE.DefaultCellStyle.BackColor = Color.White;
            dgvCVFE.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvCVFE.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvCVFE.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCVFE.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCVFE.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvCVFE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCVFE.Columns["colCodigo"].FillWeight = 10;
            dgvCVFE.Columns["colFecha"].FillWeight = 12;
            dgvCVFE.Columns["colHora"].FillWeight = 10;
            dgvCVFE.Columns["colVendedor"].FillWeight = 16;
            dgvCVFE.Columns["colSucursal"].FillWeight = 14;
            dgvCVFE.Columns["colCliente"].FillWeight = 16;
            dgvCVFE.Columns["colSubtotal"].FillWeight = 12;
            dgvCVFE.Columns["colDescuento"].FillWeight = 12;
            dgvCVFE.Columns["colTotal"].FillWeight = 12;
            dgvCVFE.Columns["colEstado"].FillWeight = 10;
            dgvCVFE.Columns["colEditar"].FillWeight = 8;
            dgvCVFE.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn VerDetalle = (DataGridViewImageColumn)dgvCVFE.Columns["colEditar"];
            VerDetalle.Image = Properties.Resources.ojo;
            VerDetalle.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvCVFE.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dtpCVDesdeE.MinDate = new DateTime(2026, 1, 1); // fecha razonable de inicio
            dtpCVFechaHastaE.MaxDate = DateTime.Today;            // siempre "hoy", se recalcula cada vez que se abre el form
            dtpCVFechaHastaE.MinDate = dtpCVDesdeE.MinDate;
            dtpCVDesdeE.MaxDate = DateTime.Today;

            dtpCVDesdeE.Value = DateTime.Today;
            dtpCVFechaHastaE.Value = DateTime.Today;

            dtpCVDesdeE.MaxDate = DateTime.Today;
            dtpCVFechaHastaE.MaxDate = DateTime.Today;

            cbCVEstadoE.Items.Clear();
            cbCVEstadoE.Items.Add("Todos");
            cbCVEstadoE.Items.Add("Activo");
            cbCVEstadoE.Items.Add("Anulado");
            cbCVEstadoE.SelectedIndex = 0;

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
            dtpCVDesdeE.Value = DateTime.Today;
            dtpCVFechaHastaE.Value = DateTime.Today;

            dtpCVDesdeE.MaxDate = DateTime.Today;
            dtpCVFechaHastaE.MaxDate = DateTime.Today;

            cbCVEstadoE.Items.Clear();
            cbCVEstadoE.Items.Add("Todos");
            cbCVEstadoE.Items.Add("Activo");
            cbCVEstadoE.Items.Add("Anulado");
            cbCVEstadoE.SelectedIndex = 0;

            Buscar();
        }

        private void Buscar()
        {
            DateTime fechaDesde = dtpCVDesdeE.Value.Date;
            DateTime fechaHasta = dtpCVFechaHastaE.Value.Date;

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
                WHERE V.Fecha BETWEEN '" + fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + @"'
                AND V.IdSucursal = " + idSucursalSesion;

            if (cbCVEstadoE.SelectedItem != null)
            {
                string estado = cbCVEstadoE.SelectedItem.ToString();

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

            dgvCVFE.Rows.Clear();

            if (dt == null) return;

            foreach (DataRow fila in dt.Rows)
            {
                int posicion = dgvCVFE.Rows.Add();
                DataGridViewRow row = dgvCVFE.Rows[posicion];

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
            dtpCVDesdeE.Value = DateTime.Today;
            dtpCVFechaHastaE.Value = DateTime.Today;
            cbCVEstadoE.SelectedIndex = 0;
            Buscar();
        }

        private void dgvCVF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columna = dgvCVFE.Columns[e.ColumnIndex].Name;
            int idVenta = Convert.ToInt32(dgvCVFE.Rows[e.RowIndex].Tag);

            if (columna == "colEliminar")
            {
                string estadoActual = dgvCVFE.Rows[e.RowIndex].Cells["colEstado"].Value.ToString();

                if (estadoActual == "Anulado")
                {
                    MessageBox.Show("Esta venta ya está anulada.");
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Anular esta venta?",
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
            string consulta = @"
                SELECT P.Nombre, D.Cantidad, D.PrecioUnitario, D.Subtotal
                FROM DetalleVenta D
                INNER JOIN Productos P ON D.IdProducto = P.IdProductos
                WHERE D.IdVenta = " + idVenta;

            DataTable dt = conexion.RetornaRegistros(consulta);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron productos para esta venta.");
                return;
            }

            string detalle = "Productos de la venta:\n\n";
            foreach (DataRow fila in dt.Rows)
            {
                detalle += fila["Nombre"] + " x" + fila["Cantidad"] +
                           " - $" + Convert.ToDecimal(fila["Subtotal"]).ToString("0.00") + "\n";
            }

            MessageBox.Show(detalle, "Detalle de venta");
        }

        private void btnCVImprimir_Click(object sender, EventArgs e)
        {
            if (dgvCVFE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para imprimir.");
                return;
            }

            idVentaImprimir = Convert.ToInt32(dgvCVFE.SelectedRows[0].Tag);

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

        private void btnCE_Click(object sender, EventArgs e)
        {
            FrmVentasE frmVenta = new FrmVentasE();
            frmVenta.idEmpleadoSesion = idEmpleadoSesion;
            frmVenta.idSucursalSesion = idSucursalSesion;
            frmVenta.nombreVendedorSesion = nombreVendedorSesion;
            frmVenta.nombreSucursalSesion = nombreSucursalSesion;

            if (frmVenta.ShowDialog() == DialogResult.OK)
            {
                Buscar();
            }
        }
    }
}
