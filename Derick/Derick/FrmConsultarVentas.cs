using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmConsultarVentas : Form
    {
        public FrmConsultarVentas()
        {
            InitializeComponent();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresarC_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cancelar? Se perderán los cambios realizados.", "Cancelar",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                frmVentas frm = this.Parent.Parent as frmVentas;
                if (r != null)
                {
                    frm.MostrarFrm();
                }
            }
        }
    }
}
