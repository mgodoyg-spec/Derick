using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Derick
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();

            reportViewer1.Dock = DockStyle.Fill;
            panel2.Controls.Add(reportViewer1);

            PageSettings pagina = new PageSettings();
            pagina.Landscape = true;
            pagina.PaperSize = new PaperSize("A4", 1169, 827);
            pagina.Margins = new Margins(20, 20, 20, 20);

            reportViewer1.SetPageSettings(pagina);
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }

        private void CargarSucursales()
        {
            csConectaSQL oconSQL = new csConectaSQL();

            string cadena = "select IdSucursal, NombreSucursal from Sucursales order by NombreSucursal";
            DataTable dt = oconSQL.RetornaRegistros(cadena);

            if (dt == null) return;

            DataRow fila = dt.NewRow();
            fila["IdSucursal"] = 0;
            fila["NombreSucursal"] = "Todas las sucursales";

            dt.Rows.InsertAt(fila, 0);

            cmbSucursal.DataSource = dt;
            cmbSucursal.DisplayMember = "NombreSucursal";
            cmbSucursal.ValueMember = "IdSucursal";
            cmbSucursal.SelectedIndex = 0;
        }

        private int ObtenerIdSucursalSeleccionada()
        {
            if (cmbSucursal.SelectedItem == null)
                return 0;

            DataRowView filaSucursal = cmbSucursal.SelectedItem as DataRowView;

            if (filaSucursal == null)
                return 0;

            return Convert.ToInt32(filaSucursal["IdSucursal"]);
        }

        private void btnGenerarR_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de reporte.");
                return;
            }

            if (cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                return;
            }

            csConectaSQL oconSQL = new csConectaSQL();
            DataTable dt = new DataTable();
            ReportDataSource dataset = new ReportDataSource();

            reportViewer1.LocalReport.DataSources.Clear();

            string fechaInicio = dtpFechaInicio.Value.ToString("yyyyMMdd");
            string fechaFin = dtpFechaFin.Value.AddDays(1).ToString("yyyyMMdd");

            int idSucursal = ObtenerIdSucursalSeleccionada();
            string cadena = "";

            // PRODUCTOS MÁS VENDIDOS
            if (cmbTipoReporte.Text == "Productos más vendidos")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptProductosMasVendidos.rdlc";

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
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' ";

                if (idSucursal != 0)
                    cadena += "and V.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "group by P.Codigo, P.Nombre, C.Nombre, D.PrecioUnitario " +
                    "order by Cantidad desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsProductosMasVendidos",
                    dt);
            }

            // VENTAS POR CATEGORÍA
            else if (cmbTipoReporte.Text == "Ventas por categoría")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorCategoria.rdlc";

                cadena =
                    "select C.IdCategoria, " +
                    "C.Nombre as Categoria, " +
                    "sum(D.Cantidad) as Cantidad, " +
                    "sum(D.PrecioUnitario * D.Cantidad) as Subtotal, " +
                    "sum(D.Descuento) as Descuento, " +
                    "sum(D.Subtotal) as Total " +
                    "from Ventas V " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "inner join Productos P on D.IdProducto = P.IdProductos " +
                    "inner join Categorias C on P.IdCategoria = C.IdCategoria " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' ";

                if (idSucursal != 0)
                    cadena += "and V.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "group by C.IdCategoria, C.Nombre " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsVentasPorCategoria",
                    dt);
            }

            // VENTAS POR EMPLEADO
            else if (cmbTipoReporte.Text == "Ventas por empleado")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorEmpleado.rdlc";

                cadena =
                    "select E.Codigo, " +
                    "E.Nombres + ' ' + E.Apellidos as Empleado, " +
                    "isnull(S.NombreSucursal, 'Sin sucursal') as Sucursal, " +
                    "isnull(sum(D.Cantidad), 0) as CantidadVendida, " +
                    "count(distinct V.IdVentas) as VentasRealizadas, " +
                    "isnull(sum(D.Subtotal), 0) as Total " +

                    "from Empleados E " +

                    "left join Sucursales S " +
                    "on E.IdSucursal = S.IdSucursal " +

                    "left join Ventas V " +
                    "on E.IdEmpleado = V.IdEmpleado " +
                    "and V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' ";

                if (idSucursal != 0)
                    cadena += "and V.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "left join DetalleVenta D " +
                    "on V.IdVentas = D.IdVenta " +

                    "where E.Estado = 1 ";

                if (idSucursal != 0)
                    cadena += "and E.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "group by E.IdEmpleado, E.Codigo, E.Nombres, E.Apellidos, S.NombreSucursal " +
                    "order by Total desc, E.Nombres, E.Apellidos";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsVentasPorEmpleado",
                    dt);
            }

            // VENTAS POR SUCURSAL
            else if (cmbTipoReporte.Text == "Ventas por sucursal")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorSucursal.rdlc";

                cadena =
                    "select S.Codigo, " +
                    "S.NombreSucursal as Sucursal, " +
                    "S.Ciudad, " +
                    "isnull(sum(D.Cantidad), 0) as CantidadVendida, " +
                    "count(distinct V.IdVentas) as VentasRealizadas, " +
                    "isnull(sum(D.Subtotal), 0) as Total " +
                    "from Sucursales S " +

                    "left join Ventas V " +
                    "on S.IdSucursal = V.IdSucursal " +
                    "and V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +

                    "left join DetalleVenta D " +
                    "on V.IdVentas = D.IdVenta ";

                if (idSucursal != 0)
                    cadena += "where S.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "group by S.IdSucursal, S.Codigo, S.NombreSucursal, S.Ciudad " +
                    "order by S.NombreSucursal";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dtVentasPorSucursal",
                    dt);
            }

            // DETALLE DE VENTAS
            else if (cmbTipoReporte.Text == "Detalle de ventas")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptDetalleVentas.rdlc";

                cadena =
                    "select V.Codigo, " +
                    "cast(V.Fecha as date) as Fecha, " +

                    "case " +
                    "when C.Nombres = 'Consumidor Final' then 'Consumidor Final' " +
                    "else C.Nombres + ' ' + C.Apellidos " +
                    "end as Cliente, " +

                    "E.Nombres + ' ' + E.Apellidos as Empleado, " +
                    "S.NombreSucursal as Sucursal, " +
                    "V.MetodoPago as MetodoPgo, " +
                    "sum(D.PrecioUnitario * D.Cantidad) as Subtotal, " +
                    "V.Descuento, " +
                    "V.IVA, " +
                    "V.Total " +

                    "from Ventas V " +
                    "inner join Clientes C on V.IdCliente = C.IdCliente " +
                    "inner join Empleados E on V.IdEmpleado = E.IdEmpleado " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +

                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' ";

                if (idSucursal != 0)
                    cadena += "and V.IdSucursal = " + idSucursal + " ";

                cadena +=
                    "group by V.Codigo, V.Fecha, " +
                    "C.Nombres, C.Apellidos, " +
                    "E.Nombres, E.Apellidos, " +
                    "S.NombreSucursal, " +
                    "V.MetodoPago, " +
                    "V.Descuento, V.IVA, V.Total " +
                    "order by V.Fecha desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsDetalleVentas",
                    dt);
            }

            if (dt == null)
            {
                MessageBox.Show(
                    "No se pudo obtener la información del reporte.",
                    "Reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No existen datos para generar este reporte con los filtros seleccionados.",
                    "Reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                reportViewer1.Clear();
                return;
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSucursal.Enabled = true;

            if (cmbSucursal.Items.Count > 0 &&
                cmbSucursal.SelectedIndex == -1)
            {
                cmbSucursal.SelectedIndex = 0;
            }
        }

        private void lblLimpiarF_Click(object sender, EventArgs e)
        {
            cmbTipoReporte.SelectedIndex = -1;

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            if (cmbSucursal.Items.Count > 0)
                cmbSucursal.SelectedIndex = 0;

            cmbSucursal.Enabled = true;
            reportViewer1.Clear();
        }
    }
}