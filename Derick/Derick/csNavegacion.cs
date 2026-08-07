using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    internal class csNavegacion
    {
        public static void AbrirFormulario(
            Panel panelContenido,
            ref Form formularioActivo,
            Form formularioNuevo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioNuevo;

            formularioNuevo.TopLevel = false;
            formularioNuevo.FormBorderStyle = FormBorderStyle.None;
            formularioNuevo.Dock = DockStyle.Fill;

            panelContenido.Controls.Clear();
            panelContenido.Controls.Add(formularioNuevo);

            panelContenido.Tag = formularioNuevo;

            formularioNuevo.BringToFront();
            formularioNuevo.Show();
        }
    }
}
