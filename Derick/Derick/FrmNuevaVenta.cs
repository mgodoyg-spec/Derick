using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmNuevaVenta : Form
    {
        public FrmNuevaVenta()
        {
            InitializeComponent();
        }

        private void txtCodigoVenta_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta se ha guardado correctamente.",
                   "Registro de ventas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void btnCancelarV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta ha sido cancelada.",
                    "Cancelar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnRegresarN_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Desea cancelar? Se perderán los cambios realizados.", "Cancelar",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                frmVentas frm = this.Parent.Parent as frmVentas;
                if (frm != null)
                {
                    frm.MostrarFrm();
                }
            }
        }
    }
}
