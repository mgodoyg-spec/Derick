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
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //label de la parte superior
            lblusuario.Text = usuarioActual;
        }
        private void btncerrarsesion_Click(object sender, EventArgs e)
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
            AbrirFormulario(new InicioGerente());
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

        private void picMenu_Click_1(object sender, EventArgs e)
        {

            if (pnlMenuu.Width == 270)
            {
                pnlMenuu.Width = 70;

                // Centrar iconos
                picinicio.Left = 20;
                picproductos.Left = 20;
                picsucursales.Left = 20;
                picempleados.Left = 20;
                picventas.Left = 20;
                picreportes.Left = 20;
                piccerrarsesion.Left = 20;
                // Ocultar botones
                btninicio.Visible = false;
                btnproductos.Visible = false;
                btnsucursales.Visible = false;
                btnempleados.Visible = false;
                btnventas.Visible = false;
                btnreportes.Visible = false;
                btncerrarsesion.Visible = false;

                // Mover el panel del contenido
                pnlMostrar.Left = 70;
                pnlMostrar.Width = this.ClientSize.Width - 70;
            }
            else
            {
                pnlMenuu.Width = 270;
                // Mostrar botones
                btninicio.Visible = true;
                btnproductos.Visible = true;
                btnsucursales.Visible = true;
                btnempleados.Visible = true;
                btnventas.Visible = true;
                btnreportes.Visible = true;
                btncerrarsesion.Visible = true;

                // Regresar iconos a su posición
                picinicio.Left = 53;
                picproductos.Left = 53;
                picsucursales.Left = 53;
                picempleados.Left = 53;
                picventas.Left = 53;
                picreportes.Left = 53;
                piccerrarsesion.Left = 53;

                // Regresar el panel del contenido
                pnlMostrar.Left = 270;
                pnlMostrar.Width = this.ClientSize.Width - 270;
            }
        }
        private void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            pnlMostrarForm.Controls.Clear();
            pnlMostrarForm.Controls.Add(formularioHijo);
            pnlMostrarForm.Tag = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
