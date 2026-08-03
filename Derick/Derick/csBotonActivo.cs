using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    internal class csBotonActivo
    {
        public static void MarcarBotonActivo(Panel pnlIndicador, Button botonSeleccionado)
        {
            pnlIndicador.Width = botonSeleccionado.Width;
            pnlIndicador.Left = botonSeleccionado.Left;
            pnlIndicador.Top = botonSeleccionado.Bottom - pnlIndicador.Height;

            pnlIndicador.BringToFront();
        }
    }
}
