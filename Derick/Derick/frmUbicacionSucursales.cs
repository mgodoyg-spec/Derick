using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Derick
{
    public partial class frmUbicacionSucursales : Form
    {
        private csSucursal sucursal;

        public frmUbicacionSucursales()
        {
            InitializeComponent();
        }
        public frmUbicacionSucursales(csSucursal sucursal)
        {
            InitializeComponent(); 
            this.sucursal = sucursal;
        }
        private void CargarDatos()
        {
            lblSucursal.Text = sucursal.NombreSucursal;
            lblCiudad.Text = sucursal.Ciudad;
            lblEstado.Text = sucursal.Estado;
            lblDireccion.Text = sucursal.Direccion;
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmUbicacionSucursales_Load(object sender, EventArgs e)
        {
            if (sucursal != null)
            {
                CargarDatos();
                await CargarMapa();
            }
        }

        private void btnAbrirGMaps_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sucursal.Direccion) || string.IsNullOrWhiteSpace(sucursal.Ciudad))
            {
                MessageBox.Show("La sucursal no tiene una dirección registrada.","Ubicación no disponible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string ubicacion = sucursal.Direccion + ", " + sucursal.Ciudad + ", Ecuador";
            string url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(ubicacion);

            Process.Start(
                new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
        }
        private async Task CargarMapa()
        {
            if (string.IsNullOrWhiteSpace(sucursal.Direccion) ||string.IsNullOrWhiteSpace(sucursal.Ciudad))
            {
                MessageBox.Show("La sucursal no tiene una dirección registrada.","Ubicación no disponible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string ubicacion =sucursal.Direccion + ", " + sucursal.Ciudad + ", Ecuador";

            string url ="https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(ubicacion);
            await webMapa.EnsureCoreWebView2Async();
            webMapa.CoreWebView2.Navigate(url);
        }
    }
}
