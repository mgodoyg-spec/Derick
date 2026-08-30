using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Derick
{
    public partial class frmReportesE : Form
    {
        private string codigoSucursalActual;

        public frmReportesE(string codigoSucursal)
        {
            InitializeComponent();

            codigoSucursalActual = codigoSucursal;

            reportViewer1.Dock = DockStyle.Fill;
            panel2.Controls.Add(reportViewer1);
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGenerarR_Click(object sender, EventArgs e)
        {
            csConectaSQL oconSQL = new csConectaSQL();
            DataTable dt = new DataTable();
            ReportDataSource dataset = new ReportDataSource();

            reportViewer1.LocalReport.DataSources.Clear();

            string fechaInicio =
                dtpFechaInicio.Value.ToString("yyyyMMdd");

            string fechaFin =
                dtpFechaFin.Value.AddDays(1).ToString("yyyyMMdd");

            string codigoSucursal =
                codigoSucursalActual.Replace("'", "''");

            string cadena = "";

            if (cmbTipoReporte.Text == "Productos más vendidos")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptProductosMasVendidosE.rdlc";

                cadena =
                    "select P.Codigo as CodProducto, " +
                    "P.Nombre as NomProducto, " +
                    "C.Nombre as Categoria, " +
                    "sum(D.Cantidad) as Cantidad, " +
                    "D.PrecioUnitario as PrecioUnitario, " +
                    "sum(D.Descuento) as Descuento, " +
                    "sum(D.Subtotal) as TotalVendido " +
                    "from DetalleVenta D " +
                    "inner join Productos P on D.IdProducto = P.IdProductos " +
                    "inner join Ventas V on D.IdVenta = V.IdVentas " +
                    "inner join Categorias C on P.IdCategoria = C.IdCategoria " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "and S.Codigo = '" + codigoSucursal + "' " +
                    "group by P.Codigo, P.Nombre, C.Nombre, D.PrecioUnitario " +
                    "order by Cantidad desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsProductosMasVendidosE",
                    dt
                );

                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else if (cmbTipoReporte.Text == "Ventas por categoría")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorCategoriaE.rdlc";

                cadena =
                    "select C.IdCategoria, " +
                    "C.Nombre as Categoria, " +
                    "sum(D.Cantidad) as Cantidad, " +
                    "sum(D.PrecioUnitario * D.Cantidad) as Subtotal, " +
                    "sum(D.Descuento) as Descuento, " +
                    "sum(D.Subtotal) as Total " +
                    "from DetalleVenta D " +
                    "inner join Productos P on D.IdProducto = P.IdProductos " +
                    "inner join Categorias C on P.IdCategoria = C.IdCategoria " +
                    "inner join Ventas V on D.IdVenta = V.IdVentas " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "and S.Codigo = '" + codigoSucursal + "' " +
                    "group by C.IdCategoria, C.Nombre " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsVentasPorCategoriaE",
                    dt
                );

                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else if (cmbTipoReporte.Text == "Detalle de ventas")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptDetalleVentasE.rdlc";

                cadena =
                    "select V.Codigo, " +
                    "V.Fecha, " +
                    "C.Nombres + ' ' + C.Apellidos as Cliente, " +
                    "E.Nombres + ' ' + E.Apellidos as Empleado, " +
                    "V.MetodoPago as MetodoPgo, " +
                    "sum(D.PrecioUnitario * D.Cantidad) as Subtotal, " +
                    "sum(D.Descuento) as Descuento, " +
                    "V.IVA, " +
                    "V.Total " +
                    "from Ventas V " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "inner join Clientes C on V.IdCliente = C.IdCliente " +
                    "inner join Empleados E on V.IdEmpleado = E.IdEmpleado " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "and S.Codigo = '" + codigoSucursal + "' " +
                    "group by V.Codigo, V.Fecha, C.Nombres, C.Apellidos, " +
                    "E.Nombres, E.Apellidos, V.MetodoPago, V.IVA, V.Total " +
                    "order by V.Fecha desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsDetalleVentasE",
                    dt
                );

                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else if (cmbTipoReporte.Text == "Stock bajo")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptStockBajoE.rdlc";

                cadena =
                    "select P.Codigo, " +
                    "P.Nombre as Producto, " +
                    "T.Nombre as Talla, " +
                    "C.Nombre as Color, " +
                    "I.Stock " +
                    "from Inventario I " +
                    "inner join Productos P on I.IdProducto = P.IdProductos " +
                    "inner join Tallas T on I.IdTalla = T.IdTalla " +
                    "inner join Colores C on I.IdColor = C.IdColor " +
                    "inner join Sucursales S on I.IdSucursal = S.IdSucursal " +
                    "where S.Codigo = '" + codigoSucursal + "' " +
                    "and I.Stock <= 5 " +
                    "order by I.Stock asc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsStockBajoE",
                    dt
                );

                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }
    }
}