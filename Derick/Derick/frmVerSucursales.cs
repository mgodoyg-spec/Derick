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
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmVerSucursal_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if (sucursal.Estado == "Inactiva")
            {
                btnDesactivar.Text = "Reactivar sucursal";
            }
            else
            {
                btnDesactivar.Text = "Desactivar sucursal";
            }
        }

        private void CargarDatos()
        {
            lblCodigo.Text = sucursal.Codigo;
            lblNombreSucursal.Text = sucursal.NombreSucursal;

            lblFecha.Text = sucursal.FechaRegistro.ToString("dd/MM/yyyy");

            lblCiudad.Text = sucursal.Ciudad;
            lblDireccion.Text = sucursal.Direccion;
            lblTel.Text = sucursal.Telefono;
            lblCorreo.Text = string.IsNullOrWhiteSpace(sucursal.Correo) ? "No registrado" : sucursal.Correo;
            lblEncargado.Text = sucursal.EncargadoSucursal;
            lblEstado.Text = sucursal.Estado;

            CargarImagen();
        }

        private void CargarImagen()
        {
            if (sucursal.Imagen != null && sucursal.Imagen.Length > 0)
            {
                using (MemoryStream ms =new MemoryStream(sucursal.Imagen))
                {
                    using (Image imagenTemporal =
                        Image.FromStream(ms))
                    {
                        pbxImagenSucursal.Image =new Bitmap(imagenTemporal);
                    }
                }
                pbxImagenSucursal.SizeMode =PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbxImagenSucursal.Image = null;
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (sucursal.Estado == "Inactiva")
            {
                if (sucursal.CambiarEstado("Activa"))
                {
                    MessageBox.Show("Sucursal reactivada correctamente.");
                    this.Close();
                }
            }
            else
            {
                DialogResult respuesta =MessageBox.Show("¿Está seguro de desactivar esta sucursal?", "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    if (sucursal.CambiarEstado("Inactiva"))
                    {
                        MessageBox.Show("Sucursal desactivada correctamente.");
                        this.Close();
                    }
                }
            }
        }

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                 "¿Está seguro de eliminar esta sucursal?\n\n" +
                  "Esta acción no se puede deshacer.",
                  "Eliminar sucursal",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No)
                return;

            if (sucursal.Eliminar())
            {
                MessageBox.Show(
                    "Sucursal eliminada correctamente.",
                    "Sucursal eliminada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
