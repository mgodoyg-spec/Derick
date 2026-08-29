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
        public string usuarioActual;
        public int idEmpleadoActual;
        private Form? formularioActivo;
        public FrmMenuEmpleados(string usuarioActual, string codigoSucursal)
        {
            InitializeComponent();

            this.usuarioActual = usuarioActual;
            this.codigoSucursalActual = codigoSucursal;
        }

        private void lblSalir_Click(object sender, EventArgs e)
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

        private void FrmMenuEmpleados_Load(object sender, EventArgs e)
        {
            //label de la parte superior
            lblusuario.Text = usuarioActual;

            this.PerformLayout();
            this.Refresh();

            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new FrmInicioE(codigoSucursalActual));
        }

        private void pnlPerfil_Click(object sender, EventArgs e)
        {
            lblFlecha.Text = "▲";
            cmsMenuPerfil.Show(pnlPerfil, 0, pnlPerfil.Height);
        }

        private void cmsMenuPerfil_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            lblFlecha.Text = "▼";
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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
                this.Close(); // cierra el menú principal
            }
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btninicio);
            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new FrmInicioE(codigoSucursalActual));
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnproductos);
            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new FrmProductosE(idEmpleadoActual));
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnventas);
            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new FrmVentasE());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnreportes);
            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new frmReportesE());
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
