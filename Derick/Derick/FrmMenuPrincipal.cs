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
            pnlMostrar.PerformLayout();
            this.AutoScaleMode = AutoScaleMode.None;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //label de la parte superior
            lblusuario.Text = usuarioActual;
            this.PerformLayout();
            this.Refresh();
            AbrirFormulario(new InicioGerente());
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
            MarcarBotonActivo(btninicio);
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

        private void AbrirFormulario(Form formularioHijo)
        {
            // 1. Si ya hay un formulario abierto en el panel, lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            // 2. Guardamos la referencia del nuevo formulario
            formularioActivo = formularioHijo;
            // 3. Lo preparamos para incrustarse dentro del panel
            formularioHijo.TopLevel = false;                  // Evita que sea una ventana independiente
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita la barra de título del hijo (X, minimizar, etc.)
            formularioHijo.Dock = DockStyle.Fill;            // Obliga a expandirse EXACTAMENTE al tamaño del área blanca
            // 4. Limpiamos el área blanca e insertamos el nuevo formulario
            pnlMostrarForm.Controls.Clear();
            pnlMostrarForm.Controls.Add(formularioHijo);
            pnlMostrarForm.Tag = formularioHijo;
            // 5. Lo mostramos en pantalla
            formularioHijo.BringToFront();
            formularioHijo.Show();
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
        private void MarcarBotonActivo(Button botonSeleccionado)
        {
            // Mueve la barrita azul justo debajo del botón seleccionado
            pnlIndicador.Width = botonSeleccionado.Width;
            pnlIndicador.Left = botonSeleccionado.Left;
            pnlIndicador.Top = botonSeleccionado.Bottom - pnlIndicador.Height;

            // Opcional: Si quieres traer la barrita al frente para que no quede oculta
            pnlIndicador.BringToFront();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnproductos);
            AbrirFormulario(new FormProductos());

        }
    }
}
