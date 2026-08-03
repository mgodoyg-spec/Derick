using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    internal class csNavegacion
    {
        public static void AbrirFormulario(
            Panel panel,
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

            panel.Controls.Clear();
            panel.Controls.Add(formularioNuevo);
            panel.Tag = formularioNuevo;

            formularioNuevo.BringToFront();
            formularioNuevo.Show();
        }
    }
}
