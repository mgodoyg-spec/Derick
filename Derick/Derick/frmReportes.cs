using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Linq;

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

        private void CargarSucursales()
        {
            csConectaSQL oconSQL = new csConectaSQL();

            string cadena =
                "select IdSucursal, NombreSucursal " +
                "from Sucursales " +
                "where Estado = 'Activa' " +
                "order by NombreSucursal";

            DataTable dt = oconSQL.RetornaRegistros(cadena);

            DataRow fila = dt.NewRow();
            fila["IdSucursal"] = 0;
            fila["NombreSucursal"] = "Todas las sucursales";

            dt.Rows.InsertAt(fila, 0);

            cmbSucursal.DataSource = dt;
            cmbSucursal.DisplayMember = "NombreSucursal";
            cmbSucursal.ValueMember = "IdSucursal";
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

            int idSucursal =
                Convert.ToInt32(cmbSucursal.SelectedValue);

            string cadena = "";

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

                if (cmbSucursal.Text != "Todas las sucursales")
                {
                    cadena +=
                        "and V.IdSucursal = " +
                        cmbSucursal.SelectedValue + " ";
                }

                cadena +=
                    "group by P.Codigo, P.Nombre, C.Nombre, D.PrecioUnitario " +
                    "order by Cantidad desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsProductosMasVendidos",
                    dt
                );
            }
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

                if (cmbSucursal.Text != "Todas las sucursales")
                {
                    cadena +=
                        "and V.IdSucursal = " +
                        cmbSucursal.SelectedValue + " ";
                }

                cadena +=
                    "group by C.IdCategoria, C.Nombre " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsVentasPorCategoria",
                    dt
                );
            }
            else if (cmbTipoReporte.Text == "Ventas por empleado")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorEmpleado.rdlc";

                cadena =
                    "select E.Codigo, " +
                    "E.Nombres + ' ' + E.Apellidos as Empleado, " +
                    "S.NombreSucursal as Sucursal, " +
                    "sum(D.Cantidad) as CantidadVendida, " +
                    "count(distinct V.IdVentas) as VentasRealizadas, " +
                    "sum(D.Subtotal) as Total " +
                    "from Ventas V " +
                    "inner join Empleados E on V.IdEmpleado = E.IdEmpleado " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' ";

                if (cmbSucursal.Text != "Todas las sucursales")
                {
                    cadena +=
                        "and V.IdSucursal = " +
                        cmbSucursal.SelectedValue + " ";
                }

                cadena +=
                    "group by E.Codigo, E.Nombres, E.Apellidos, S.NombreSucursal " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsVentasPorEmpleado",
                    dt
                );
            }
            else if (cmbTipoReporte.Text == "Ventas por sucursal")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorSucursal.rdlc";

                cadena =
                    "select S.Codigo, " +
                    "S.NombreSucursal as Sucursal, " +
                    "S.Ciudad, " +
                    "sum(D.Cantidad) as CantidadVendida, " +
                    "count(distinct V.IdVentas) as VentasRealizadas, " +
                    "sum(D.Subtotal) as Total " +
                    "from Ventas V " +
                    "inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "group by S.Codigo, S.NombreSucursal, S.Ciudad " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dtVentasPorSucursal",
                    dt
                );
            }
            else if (cmbTipoReporte.Text == "Detalle de ventas")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptDetalleVentas.rdlc";

                cadena =
                    "select V.Codigo, " +
                    "V.Fecha, " +
                    "C.Nombres + ' ' + C.Apellidos as Cliente, " +
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

                if (cmbSucursal.Text != "Todas las sucursales")
                {
                    cadena +=
                        "and V.IdSucursal = " +
                        cmbSucursal.SelectedValue + " ";
                }

                cadena +=
                    "group by V.Codigo, V.Fecha, C.Nombres, C.Apellidos, " +
                    "E.Nombres, E.Apellidos, S.NombreSucursal, V.MetodoPago, " +
                    "V.Descuento, V.IVA, V.Total " +
                    "order by V.Fecha desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource(
                    "dsDetalleVentas",
                    dt
                );
            }

            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.RefreshReport();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void cmbTipoReporte_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbTipoReporte.Text == "Ventas por empleado" ||
                cmbTipoReporte.Text == "Ventas por sucursal")
            {
                cmbSucursal.SelectedIndex = -1;
                cmbSucursal.Enabled = false;
            }
            else
            {
                cmbSucursal.Enabled = true;

                if (cmbSucursal.Items.Count > 0)
                {
                    cmbSucursal.SelectedIndex = 0;
                }
            }
        }

        private void lblLimpiarF_Click(object sender, EventArgs e)
        {
            cmbTipoReporte.SelectedIndex = -1;

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            if (cmbSucursal.Items.Count > 0)
            {
                cmbSucursal.SelectedIndex = 0;
            }

            reportViewer1.Clear();
        }
    }
}