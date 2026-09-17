using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Globalization;
using System.Threading.Tasks;

namespace Derick
{
    public partial class frmBuscarSucursal : Form
    {
        private string direccion;
        private string ciudad;
        private double latitud;
        private double longitud;

        private GMapOverlay marcador = new GMapOverlay("marcador");

        public double Latitud
        {
            get { return latitud; }
        }

        public double Longitud
        {
            get { return longitud; }
        }

        public frmBuscarSucursal(string direccion, string ciudad)
        {
            InitializeComponent();

            this.direccion = direccion;
            this.ciudad = ciudad;
        }

        private async void frmBuscarSucursal_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gmapSeleccionarUbi.MapProvider =GoogleMapProvider.Instance;

            gmapSeleccionarUbi.MinZoom = 2;
            gmapSeleccionarUbi.MaxZoom = 20;
            gmapSeleccionarUbi.Zoom = 17;

            gmapSeleccionarUbi.ShowCenter = false;

            gmapSeleccionarUbi.CanDragMap = true;
            gmapSeleccionarUbi.DragButton = MouseButtons.Left;
            gmapSeleccionarUbi.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;

            gmapSeleccionarUbi.Overlays.Add(marcador);

            await BuscarDireccion();
        }
        private async Task BuscarDireccion()
        {
            try
            {
                string ubicacion = direccion + ", " + ciudad + ", Ecuador";

                using (WebClient cliente = new WebClient())
                {
                    cliente.Headers.Add(
                        "User-Agent",
                        "Derick/1.0");

                    string url =
                        "https://nominatim.openstreetmap.org/search" +
                        "?format=jsonv2" +
                        "&limit=1" +
                        "&countrycodes=ec" +
                        "&q=" +
                        Uri.EscapeDataString(ubicacion);

                    string respuesta = await cliente.DownloadStringTaskAsync(url);

                    JArray resultados =JArray.Parse(respuesta);

                    if (resultados.Count > 0)
                    {
                        double latitudEncontrada =double.Parse(resultados[0]["lat"].ToString(),CultureInfo.InvariantCulture);

                        double longitudEncontrada =double.Parse(resultados[0]["lon"].ToString(),CultureInfo.InvariantCulture);

                        gmapSeleccionarUbi.Position =new PointLatLng(latitudEncontrada,longitudEncontrada);

                        gmapSeleccionarUbi.Zoom = 18;

                        lblCoordenadas.Text ="Ubicación aproximada encontrada. " +
                            "Seleccione el punto exacto.";

                        return;
                    }

                    await BuscarReferencia(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar la dirección.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task BuscarReferencia()
        {
            try
            {
                string referencia = direccion;

                if (referencia.Contains("-"))
                    referencia = referencia.Split('-')[0].Trim();

                string ubicacion =referencia + ", " + ciudad + ", Ecuador";

                using (WebClient cliente = new WebClient())
                {
                    cliente.Headers.Add(
                        "User-Agent",
                        "Derick/1.0");

                    string url =
                        "https://nominatim.openstreetmap.org/search" +
                        "?format=jsonv2" +
                        "&limit=1" +
                        "&countrycodes=ec" +
                        "&q=" +
                        Uri.EscapeDataString(ubicacion);

                    string respuesta = await cliente.DownloadStringTaskAsync(url);

                    JArray resultados = JArray.Parse(respuesta);

                    if (resultados.Count > 0)
                    {
                        double latitudEncontrada =double.Parse(resultados[0]["lat"].ToString(),CultureInfo.InvariantCulture);

                        double longitudEncontrada = double.Parse(resultados[0]["lon"].ToString(),CultureInfo.InvariantCulture);

                        gmapSeleccionarUbi.Position = new PointLatLng(latitudEncontrada, longitudEncontrada);

                        gmapSeleccionarUbi.Zoom = 17;

                        lblCoordenadas.Text ="Zona aproximada encontrada. " +"Seleccione el punto exacto.";

                        return;
                    }

                    await BuscarCiudad();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar la zona de la dirección.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task BuscarCiudad()
        {
            try
            {
                string ubicacion =ciudad + ", Ecuador";

                using (WebClient cliente = new WebClient())
                {
                    cliente.Headers.Add(
                        "User-Agent",
                        "Derick/1.0");

                    string url =
                        "https://nominatim.openstreetmap.org/search" +
                        "?format=jsonv2" +
                        "&limit=1" +
                        "&countrycodes=ec" +
                        "&q=" +
                        Uri.EscapeDataString(ubicacion);

                    string respuesta = await cliente.DownloadStringTaskAsync(url);

                    JArray resultados =JArray.Parse(respuesta);

                    if (resultados.Count == 0)
                    {
                        lblCoordenadas.Text =
                            "No se encontró la ciudad.";
                        return;
                    }

                    double latitudEncontrada =
                        double.Parse(resultados[0]["lat"].ToString(),CultureInfo.InvariantCulture);

                    double longitudEncontrada =
                        double.Parse(resultados[0]["lon"].ToString(),CultureInfo.InvariantCulture);

                    gmapSeleccionarUbi.Position =
                        new PointLatLng(latitudEncontrada,longitudEncontrada);

                    gmapSeleccionarUbi.Zoom = 14;

                    lblCoordenadas.Text =
                        "No se encontró la dirección. " +
                        "Seleccione el punto de la sucursal.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar la ciudad.\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void gmapSeleccionarUbi_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            PointLatLng punto =
                gmapSeleccionarUbi.FromLocalToLatLng(
                    e.X,
                    e.Y);

            latitud = punto.Lat;
            longitud = punto.Lng;

            marcador.Markers.Clear();

            GMarkerGoogle marcadorNuevo =
                new GMarkerGoogle(
                    punto,
                    GMarkerGoogleType.red_dot);

            marcador.Markers.Add(marcadorNuevo);

            lblCoordenadas.Text =
                "Latitud: " + latitud.ToString("0.0000000") +
                "    Longitud: " + longitud.ToString("0.0000000");
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (latitud == 0 && longitud == 0)
            {
                MessageBox.Show(
                    "Seleccione un punto en el mapa.",
                    "Ubicación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
