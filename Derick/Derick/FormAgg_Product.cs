using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormAgg_Product : Form
    {
        public FormAgg_Product()
        {
            InitializeComponent();

        }


        private void gbtn_agg4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cancelar? Se perderán los cambios realizados.", "Cancelar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FormProductos frm = this.Parent.Parent as FormProductos;
                if (r != null)
                {
                    frm.MostrarFrm();
                }
            }
        }

        private void gbtn_agg1_Click(object sender, EventArgs e)
        {
            pic_agg2.Visible = false;
            lbl_msj1.Visible = false;

            OpenFileDialog abr_image = new OpenFileDialog();
            abr_image.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (abr_image.ShowDialog() == DialogResult.OK)
            {
                pic_agg1.Image = Image.FromFile(abr_image.FileName);
            }
        }

        private void gbtn_agg2_Click(object sender, EventArgs e)
        {
            DialogResult r2 = MessageBox.Show("¿Esta seguro de eliminar la imagen?", "Eliminar imagen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r2 == DialogResult.Yes)
            {
                pic_agg1.Image.Dispose();
                pic_agg1.Image = null;
                pic_agg2.Visible = true;
                lbl_msj1.Visible = true;
            }
        }
    }
}
