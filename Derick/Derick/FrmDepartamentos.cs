using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Desea regresar? Se perderán los cambios realizados.",
        "Regresar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FrmEmpleados frm = this.Parent.Parent as FrmEmpleados;

                if (frm != null)
                {
                    frm.MostrarFrm();
                }
            }
        }
    }
}
