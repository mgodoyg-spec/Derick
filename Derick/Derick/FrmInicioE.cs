using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmInicioE : Form
    {
        private string codigoSucursal;

        public FrmInicioE(string codigoSucursal)
        {
            InitializeComponent();

            this.codigoSucursal = codigoSucursal;
        }

        private void FrmInicioE_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            CargarResumen();
        }

        // Cargar los conteos del resumen de la sucursal
        private void CargarResumen()
        {
            csConectaSQL oConexion = new csConectaSQL();

            // productos
            DataTable dtProductos = oConexion.RetornaRegistros(
                "SELECT COUNT(*) AS Total " +
                "FROM Productos " +
                "WHERE Estado = 1"
            );

            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                NumProductos.Text = dtProductos.Rows[0]["Total"].ToString();
            }
            else
            {
                NumProductos.Text = "0";
            }

            //stock bajo
            lblStockBajo.Text = "0";

            // promos activas
            DataTable dtPromociones = oConexion.RetornaRegistros(
                "SELECT COUNT(*) AS Total " +
                "FROM Promociones " +
                "WHERE Estado = 1 " +
                "AND GETDATE() BETWEEN FechaInicio AND FechaFin " +
                "AND (AplicaTodos = 1 OR IdSucursal = " + codigoSucursal + ")"
            );

            if (dtPromociones != null && dtPromociones.Rows.Count > 0)
            {
                lblPromociones.Text =
                    dtPromociones.Rows[0]["Total"].ToString();
            }
            else
            {
                lblPromociones.Text = "0";
            }
            //ventas de hoy
            lblVentas.Text = "0";
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
