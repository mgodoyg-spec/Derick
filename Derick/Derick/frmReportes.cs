using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
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

            string fechaInicio = dtpFechaInicio.Value.ToString("yyyyMMdd");
            string fechaFin = dtpFechaFin.Value.AddDays(1).ToString("yyyyMMdd");
            int idSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);

            string cadena = "";

            if (cmbTipoReporte.Text == "Productos más vendidos")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptProductosMasVendidos.rdlc";

                cadena = "select P.Codigo as CodProducto, " +
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
                "and V.Fecha < '" + fechaFin + "' " +
                "and V.IdSucursal = " + idSucursal + " " +
                "group by P.Codigo, P.Nombre, C.Nombre, D.PrecioUnitario " +
                "order by Cantidad desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource("dsProductosMasVendidos", dt);
            }
            else if (cmbTipoReporte.Text == "Ventas por categoría")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorCategoria.rdlc";

                cadena = "select C.IdCategoria, C.Nombre as Categoria, " +
                "sum(D.Cantidad) as Cantidad, " +
                "sum(D.PrecioUnitario * D.Cantidad) as Subtotal, " +
                "sum(D.Descuento) as Descuento, " +
                "sum(D.Subtotal) as Total " +
                "from Ventas V inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                "inner join Productos P on D.IdProducto = P.IdProductos " +
                "inner join Categorias C on P.IdCategoria = C.IdCategoria " +
                "where V.Fecha >= '" + fechaInicio + "' " +
                "and V.Fecha < '" + fechaFin + "' " +
                "and V.IdSucursal = " + idSucursal + " " +
                "group by C.IdCategoria, C.Nombre " +
                "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource("dsVentasPorCategoria", dt);
            }
            else if (cmbTipoReporte.Text == "Ventas por empleado")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorEmpleado.rdlc";

                cadena =
                    "select E.IdEmpleado, " +
                    "E.Nombres + ' ' + E.Apellidos as Empleado, " +
                    "sum(D.Cantidad) as CantidadVendida, " +
                    "sum(D.Subtotal) as Total " +
                    "from Ventas V inner join Empleados E on V.IdEmpleado = E.IdEmpleado " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "and V.IdSucursal = " + idSucursal + " " +
                    "group by E.IdEmpleado, E.Nombres, E.Apellidos " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource("dsVentasPorEmpleado", dt);
            }
            else if (cmbTipoReporte.Text == "Ventas por sucursal")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "Derick.rptVentasPorSucursal.rdlc";

                cadena =
                    "select S.IdSucursal, S.NombreSucursal as Sucursal, " +
                    "sum(D.Cantidad) as CantidadVendida, " +
                    "sum(D.Subtotal) as Total " +
                    "from Ventas V inner join Sucursales S on V.IdSucursal = S.IdSucursal " +
                    "inner join DetalleVenta D on V.IdVentas = D.IdVenta " +
                    "where V.Fecha >= '" + fechaInicio + "' " +
                    "and V.Fecha < '" + fechaFin + "' " +
                    "and V.IdSucursal = " + idSucursal + " " +
                    "group by S.IdSucursal, S.NombreSucursal " +
                    "order by Total desc";

                dt = oconSQL.RetornaRegistros(cadena);

                dataset = new ReportDataSource("dtVentasPorSucursal", dt);
            }

            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.RefreshReport();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }
    }
}
