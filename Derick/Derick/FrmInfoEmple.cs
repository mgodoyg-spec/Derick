using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmInfoEmple : Form
    {
        public FrmInfoEmple()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImagenEmple.Image = Image.FromFile(ofd.FileName);
                pbxImagenEmple.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r2 = MessageBox.Show("¿Esta seguro de eliminar la imagen?", "Eliminar imagen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r2 == DialogResult.Yes)
            {
                pbxImagenEmple.Image.Dispose();
                pbxImagenEmple.Image = null;
                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
