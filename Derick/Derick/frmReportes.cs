using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Derick.rptProductosMasVendidos.rdlc";
            string fechaInicio = dtpFechaInicio.Value.ToString("yyyyMMdd");
            string fechaFin = dtpFechaFin.Value.AddDays(1).ToString("yyyyMMdd");
            int idSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
            string cadena =
                "select P.Codigo as CodProducto, P.Nombre as NomProducto, " +
                "sum(D.Cantidad) as Cantidad " +
                "from DetalleVenta D inner join Productos P on D.IdProducto = P.IdProductos " +
                "inner join Ventas V on D.IdVenta = V.IdVentas " +
                "where V.Fecha >= '" + fechaInicio + "' " +
                "and V.Fecha < '" + fechaFin + "' " +
                "and V.IdSucursal = " + idSucursal + " " +
                "group by P.Codigo, P.Nombre " +
                "order by Cantidad desc";
            dt = oconSQL.RetornaRegistros(cadena);
            dataset = new ReportDataSource("dsProductosMasVendidos", dt);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.RefreshReport();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }
    }
}
