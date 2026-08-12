using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmVerSucursales : Form
    {
        private csSucursal sucursal;
        public frmVerSucursales(csSucursal sucursal)
        {
            InitializeComponent();

            this.sucursal = sucursal;

            CargarDatos();
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmVerSucursal_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblCodigo.Text = sucursal.Codigo;
            lblNombreSucursal.Text = sucursal.NombreSucursal;

            lblFecha.Text = sucursal.FechaRegistro.ToString("dd/MM/yyyy");

            lblCiudad.Text = sucursal.Ciudad;
            lblDireccion.Text = sucursal.Direccion;
            lblTel.Text = sucursal.Telefono;
            lblCorreo.Text = sucursal.Correo;
            lblEncargado.Text = sucursal.EncargadoSucursal;
            lblEstado.Text = sucursal.Estado;

            CargarImagen();
        }

        private void CargarImagen()
        {
            if (sucursal.Imagen != null &&
                 sucursal.Imagen.Length > 0)
            {
                using (MemoryStream ms =
                    new MemoryStream(sucursal.Imagen))
                {
                    using (Image imagenTemporal =
                        Image.FromStream(ms))
                    {
                        pbxImagenSucursal.Image =
                            new Bitmap(imagenTemporal);
                    }
                }

                pbxImagenSucursal.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbxImagenSucursal.Image = null;
            }
        }
    }
}
