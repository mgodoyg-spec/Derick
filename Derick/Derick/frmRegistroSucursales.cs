using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmRegistroSucursales : Form
    {

        public frmRegistroSucursales()
        {
            InitializeComponent();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImagenSucursal.Image = Image.FromFile(ofd.FileName);
                pbxImagenSucursal.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r2 = MessageBox.Show("¿Esta seguro de eliminar la imagen?", "Eliminar imagen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r2 == DialogResult.Yes)
            {
                pbxImagenSucursal.Image.Dispose();
                pbxImagenSucursal.Image = null;
                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroSucursales_Load(object sender, EventArgs e)
        {
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
