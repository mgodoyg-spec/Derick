using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmMenuPrincipal : Form
    {
        public string usuarioActual;
        private Form? formularioActivo;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            // MENÚ IZQUIERDO
            pnlcontenido.Location = new Point(0, 0);
            pnlcontenido.Size = new Size(200, this.ClientSize.Height);

            pnlcontenido.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            // PANEL DE CONTENIDO
            pnlMostrarForm.Location = new Point(200, 0);

            pnlMostrarForm.Size = new Size(
                this.ClientSize.Width - 200,
                this.ClientSize.Height
            );

            pnlMostrarForm.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //label de la parte superior
            lblusuario.Text = usuarioActual;
            this.PerformLayout();
            this.Refresh(); 
            csNavegacion.AbrirFormulario(pnlMostrarForm, ref formularioActivo, new InicioGerente());
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
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new InicioGerente());
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnproductos);
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new FormProductos());
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnempleados);
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new FrmEmple());
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnventas);
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new FrmConsultarVenta());
        }

        private void btnsucursales_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnsucursales);
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new frmSucursales());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            csBotonActivo.MarcarBotonActivo(pnlIndicador, btnreportes);
            csNavegacion.AbrirFormulario( pnlMostrarForm, ref formularioActivo,new frmReportes());
        }
    }
}
