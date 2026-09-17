using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmUbicacionSucursales : Form
    {
        private csSucursal sucursal;

        private GMapOverlay marcador =
            new GMapOverlay("marcador");

        public frmUbicacionSucursales(csSucursal sucursal)
        {
            InitializeComponent();

            this.sucursal = sucursal;
        }

        private void frmUbicacionSucursales_Load(object sender, EventArgs e)
        {
            lblSucursal.Text = sucursal.NombreSucursal;
            lblEstado.Text = sucursal.Estado;
            lblDireccion.Text = sucursal.Direccion;
            lblCiudad.Text = sucursal.Ciudad;

            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gmapUbicacion.MapProvider =
                GoogleMapProvider.Instance;

            gmapUbicacion.MinZoom = 2;
            gmapUbicacion.MaxZoom = 20;
            gmapUbicacion.Zoom = 18;

            gmapUbicacion.ShowCenter = false;

            gmapUbicacion.CanDragMap = true;
            gmapUbicacion.DragButton = MouseButtons.Left;

            gmapUbicacion.Overlays.Add(marcador);

            if (sucursal.Latitud == null ||
                sucursal.Longitud == null)
            {
                MessageBox.Show(
                    "Esta sucursal no tiene una ubicación registrada.",
                    "Ubicación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            PointLatLng punto =
                new PointLatLng(
                    Convert.ToDouble(sucursal.Latitud),
                    Convert.ToDouble(sucursal.Longitud));

            gmapUbicacion.Position = punto;

            GMarkerGoogle marcadorNuevo =
                new GMarkerGoogle(
                    punto,
                    GMarkerGoogleType.red_dot);

            marcador.Markers.Add(marcadorNuevo);
        }

        private void btnAbrirMapa_Click(object sender, EventArgs e)
        {
            if (sucursal.Latitud == null ||
                sucursal.Longitud == null)
            {
                MessageBox.Show(
                    "Esta sucursal no tiene una ubicación registrada.",
                    "Ubicación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string url =
                "https://www.google.com/maps/search/?api=1&query=" +
                sucursal.Latitud.ToString().Replace(",", ".") +
                "," +
                sucursal.Longitud.ToString().Replace(",", ".");

            Process.Start(
                new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}