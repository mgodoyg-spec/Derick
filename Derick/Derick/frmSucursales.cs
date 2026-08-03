using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmSucursales : Form
    {
        private Form? formularioActivo;
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void btnNuevaSucursal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistroSucursales());
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
            pnlSucursales.Controls.Clear();
            pnlSucursales.Controls.Add(formularioHijo);
            pnlSucursales.Tag = formularioHijo;
            // 5. Lo mostramos en pantalla
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnBuscarSucursal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmBuscarSucursal());
        }

        private void btnVerMapa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUbicacionSucursales());
        }
    }
}