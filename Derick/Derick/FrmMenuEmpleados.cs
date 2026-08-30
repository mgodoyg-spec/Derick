using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmMenuEmpleados : Form
    {
        private string codigoSucursalActual;
        private int idSucursalActual;

        public string usuarioActual;
        public int idEmpleadoActual;

        private Form? formularioActivo;

        public FrmMenuEmpleados(string usuarioActual, string codigoSucursal)
        {
            InitializeComponent();

            this.usuarioActual = usuarioActual;
            this.codigoSucursalActual = codigoSucursal;
        }

        private void FrmMenuEmpleados_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual;

            csConectaSQL conexion = new csConectaSQL();

            string consultaSucursal =
                "select IdSucursal " +
                "from Sucursales " +
                "where Codigo = '" + codigoSucursalActual + "'";

            DataTable dtSucursal =
                conexion.RetornaRegistros(consultaSucursal);

            if (dtSucursal != null && dtSucursal.Rows.Count > 0)
            {
                idSucursalActual =
                    Convert.ToInt32(dtSucursal.Rows[0]["IdSucursal"]);
            }

            this.PerformLayout();
            this.Refresh();

            csNavegacion.AbrirFormulario(
                pnlMostrarForm,
                ref formularioActivo,
                new FrmInicioE(codigoSucursalActual)
            );
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

        private void pnlPerfil_Click(object sender, EventArgs e)
        {
            lblFlecha.Text = "▲";

            cmsMenuPerfil.Show(
                pnlPerfil,
                0,
                pnlPerfil.Height
            );
        }

        private void cmsMenuPerfil_Closed(
            object sender,
            ToolStripDropDownClosedEventArgs e)
        {
            lblFlecha.Text = "▼";
        }

        private void cerrarSesiónToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
                "¿Estás seguro que deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();

                login.Show();
                this.Close();
            }
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(
                pnlIndicador,
                btninicio
            );

            csNavegacion.AbrirFormulario(
                pnlMostrarForm,
                ref formularioActivo,
                new FrmInicioE(codigoSucursalActual)
            );
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(
                pnlIndicador,
                btnproductos
            );

            csNavegacion.AbrirFormulario(
                pnlMostrarForm,
                ref formularioActivo,
                new FrmProductosE(idEmpleadoActual)
            );
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(
                pnlIndicador,
                btnventas
            );

            FrmConsultarVE frmConsulta =
                new FrmConsultarVE();

            frmConsulta.idEmpleadoSesion =
                idEmpleadoActual;

            frmConsulta.idSucursalSesion =
                idSucursalActual;

            csConectaSQL conexion =
                new csConectaSQL();

            string consultaEmpleado =
                "select Nombres + ' ' + Apellidos as NombreCompleto " +
                "from Empleados " +
                "where IdEmpleado = " + idEmpleadoActual;

            DataTable dtEmpleado =
                conexion.RetornaRegistros(consultaEmpleado);

            if (dtEmpleado != null &&
                dtEmpleado.Rows.Count > 0)
            {
                frmConsulta.nombreVendedorSesion =
                    dtEmpleado.Rows[0]["NombreCompleto"].ToString();
            }

            string consultaSucursal =
                "select NombreSucursal " +
                "from Sucursales " +
                "where IdSucursal = " + idSucursalActual;

            DataTable dtSucursal =
                conexion.RetornaRegistros(consultaSucursal);

            if (dtSucursal != null &&
                dtSucursal.Rows.Count > 0)
            {
                frmConsulta.nombreSucursalSesion =
                    dtSucursal.Rows[0]["NombreSucursal"].ToString();
            }

            csNavegacion.AbrirFormulario(
                pnlMostrarForm,
                ref formularioActivo,
                frmConsulta
            );
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(
                pnlIndicador,
                btnreportes
            );

            csNavegacion.AbrirFormulario(
                pnlMostrarForm,
                ref formularioActivo,
                new frmReportesE(codigoSucursalActual)
            );
        }

        private void miPerfilToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {

        }
    }
}