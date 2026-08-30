using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmInicioE : Form
    {
        private string codigoSucursal;

        // Panel para mostrar las actividades recientes
        private FlowLayoutPanel pnlActividadDinamica;
        public FrmInicioE(string codigoSucursal)
        {
            InitializeComponent();

            this.codigoSucursal = codigoSucursal;
        }

        private void FrmInicioE_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            CargarResumen();
            CargarActividadReciente();
        }

        private void CargarResumen()
        {
            csConectaSQL oConexion = new csConectaSQL();

            DataTable dtProductos = oConexion.RetornaRegistros(
     "SELECT COUNT(DISTINCT I.IdProducto) AS Total " +
     "FROM Inventario I " +
     "INNER JOIN Productos P ON I.IdProducto = P.IdProductos " +
     "WHERE I.IdSucursal = " + codigoSucursal + " " +
     "AND I.Stock > 0 " +
     "AND P.Estado = 1"
 );

            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                NumProductos.Text =
                    dtProductos.Rows[0]["Total"].ToString();
            }
            else
            {
                NumProductos.Text = "0";
            }
            if (dtProductos != null &&
                dtProductos.Rows.Count > 0)
            {
                NumProductos.Text =
                    dtProductos.Rows[0]["Total"].ToString();
            }
            else
            {
                NumProductos.Text = "0";
            }

            lblStockBajo.Text = "0";


            DataTable dtPromociones = oConexion.RetornaRegistros(
                "SELECT COUNT(*) AS Total " +
                "FROM Promociones " +
                "WHERE Estado = 1 " +
                "AND GETDATE() BETWEEN FechaInicio AND FechaFin " +
                "AND (AplicaTodos = 1 OR IdSucursal = " + codigoSucursal + ")"
            );

            if (dtPromociones != null &&
                dtPromociones.Rows.Count > 0)
            {
                lblPromociones.Text =
                    dtPromociones.Rows[0]["Total"].ToString();
            }
            else
            {
                lblPromociones.Text = "0";
            }

            // VENTAS DE HOY DE LA SUCURSAL
            DataTable dtVentas = oConexion.RetornaRegistros(
                "SELECT COUNT(*) AS Total " +
                "FROM Ventas " +
                "WHERE CAST(Fecha AS DATE) = CAST(GETDATE() AS DATE) " +
                "AND IdSucursal = " + codigoSucursal
            );

            if (dtVentas != null && dtVentas.Rows.Count > 0)
            {
                lblVentas.Text =
                    dtVentas.Rows[0]["Total"].ToString();
            }
            else
            {
                lblVentas.Text = "0";
            }

            if (dtVentas != null && dtVentas.Rows.Count > 0)
            {
                lblVentas.Text =
                    dtVentas.Rows[0]["Total"].ToString();
            }
            else
            {
                lblVentas.Text = "0";
            }
        }

        private void CargarActividadReciente()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT TOP 5 Descripcion, Fecha " +
                "FROM ActividadReciente " +
                "ORDER BY Fecha DESC"
            );


            // Crear el panel una sola vez
            if (pnlActividadDinamica == null)
            {
                pnlActividadDinamica = new FlowLayoutPanel();

              
                pnlActividadDinamica.Location = new Point(350, 425);

                pnlActividadDinamica.Size =
                    new Size(770, 260);

                pnlActividadDinamica.FlowDirection =
                    FlowDirection.TopDown;

                pnlActividadDinamica.WrapContents = false;

                pnlActividadDinamica.AutoScroll = false;

                pnlActividadDinamica.BackColor =
                    Color.White;

                this.Controls.Add(pnlActividadDinamica);

                pnlActividadDinamica.BringToFront();
            }


            pnlActividadDinamica.Controls.Clear();


            // Si no existen actividades
            if (dt == null || dt.Rows.Count == 0)
            {
                Label lblVacio = new Label();

                lblVacio.Text =
                    "No hay actividades recientes.";

                lblVacio.Font =
                    new Font("Segoe UI", 10);

                lblVacio.ForeColor =
                    Color.Gray;

                lblVacio.AutoSize = true;

                lblVacio.Margin =
                    new Padding(10, 15, 0, 0);

                pnlActividadDinamica.Controls.Add(lblVacio);

                return;
            }


            // Mostrar cada actividad
            foreach (DataRow fila in dt.Rows)
            {
                string descripcion =
                    fila["Descripcion"].ToString();

                DateTime fecha =
                    Convert.ToDateTime(fila["Fecha"]);


                // Panel de la actividad
                Panel pnlActividad = new Panel();

                pnlActividad.Width = 730;
                pnlActividad.Height = 47;

                pnlActividad.BackColor =
                    Color.FromArgb(248, 249, 251);

                pnlActividad.Margin =
                    new Padding(5, 3, 5, 3);


                // Descripción
                Label lblDescripcion = new Label();

                lblDescripcion.Text = descripcion;

                lblDescripcion.Font =
                    new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Bold
                    );

                lblDescripcion.ForeColor =
                    Color.FromArgb(45, 45, 45);

                lblDescripcion.Location =
                    new Point(12, 7);

                lblDescripcion.AutoSize = true;


                // Tiempo transcurrido
                Label lblFechaActividad = new Label();

                lblFechaActividad.Text =
                    ObtenerTiempoTranscurrido(fecha);

                lblFechaActividad.Font =
                    new Font("Segoe UI", 8);

                lblFechaActividad.ForeColor =
                    Color.Gray;

                lblFechaActividad.Location =
                    new Point(12, 26);

                lblFechaActividad.AutoSize = true;


                pnlActividad.Controls.Add(lblDescripcion);
                pnlActividad.Controls.Add(lblFechaActividad);

                pnlActividadDinamica.Controls.Add(pnlActividad);
            }
        }
        private string ObtenerTiempoTranscurrido(DateTime fecha)
        {
            TimeSpan diferencia =
                DateTime.Now - fecha;


            if (diferencia.TotalMinutes < 1)
            {
                return "Hace unos segundos";
            }


            if (diferencia.TotalMinutes < 60)
            {
                int minutos =
                    (int)diferencia.TotalMinutes;

                if (minutos == 1)
                {
                    return "Hace 1 minuto";
                }

                return "Hace " +
                       minutos +
                       " minutos";
            }


            if (diferencia.TotalHours < 24)
            {
                int horas =
                    (int)diferencia.TotalHours;

                if (horas == 1)
                {
                    return "Hace 1 hora";
                }

                return "Hace " +
                       horas +
                       " horas";
            }


            if (diferencia.TotalDays < 7)
            {
                int dias =
                    (int)diferencia.TotalDays;

                if (dias == 1)
                {
                    return "Hace 1 día";
                }

                return "Hace " +
                       dias +
                       " días";
            }


            return fecha.ToString("dd/MM/yyyy HH:mm");
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            Control contenedor = this.Parent;

            if (contenedor == null)
            {
                formulario.ShowDialog();
                return;
            }


            // Ocultar Inicio mientras se muestra el otro formulario
            this.Hide();


            formulario.TopLevel = false;

            formulario.FormBorderStyle =
                FormBorderStyle.None;

            formulario.Dock =
                DockStyle.Fill;


            contenedor.Controls.Add(formulario);

            formulario.BringToFront();


            // Cuando se cierre el formulario, mostrar nuevamente Inicio
            formulario.FormClosed += (s, e) =>
            {
                contenedor.Controls.Remove(formulario);

                this.Show();

                this.BringToFront();

                CargarResumen();

                CargarActividadReciente();
            };


            formulario.Show();
        }
        private void PresionarBotonMenu(string nombreBoton)
        {
            Control controlActual = this.Parent;


            // Subir hasta encontrar FrmMenuEmpleados
            while (controlActual != null &&
                   !(controlActual is FrmMenuEmpleados))
            {
                controlActual =
                    controlActual.Parent;
            }


            FrmMenuEmpleados menuEmpleados =
                controlActual as FrmMenuEmpleados;


            if (menuEmpleados == null)
            {
                MessageBox.Show(
                    "No se pudo encontrar el menú principal.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            Control[] controles =
                menuEmpleados.Controls.Find(
                    nombreBoton,
                    true
                );


            if (controles.Length > 0 &&
                controles[0] is IButtonControl boton)
            {
                boton.PerformClick();
            }
            else
            {
                MessageBox.Show(
                    "No se encontró el botón " +
                    nombreBoton +
                    ".",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnAgregarProducto_Click(object sender,EventArgs e)
        {
            FormAgg_Product frm =
                new FormAgg_Product();


            if (frm.ShowDialog() ==
                DialogResult.OK)
            {
                CargarResumen();

                CargarActividadReciente();
            }
        }
        private void btnAgregarVenta_Click(object sender,EventArgs e)
        {
            AbrirFormularioEnPanel(
                new FrmVentasN()
            );
        }
        private void btnTransferirProductos_Click(object sender,EventArgs e)
        {
            int idSucursal = Convert.ToInt32(codigoSucursal);

            FormTransferir_Productos frm =
                new FormTransferir_Productos(idSucursal);

            frm.ShowDialog();

            CargarResumen();
            CargarActividadReciente();
            
        }

        private void btnVerReportes_Click( object sender, EventArgs e)
        {
            PresionarBotonMenu(
                "btnreportes"
            );
        }
        private void btnVerTodo_Click( object sender, EventArgs e)
        {
            FrmActividadReciente frm =
                new FrmActividadReciente();

            frm.ShowDialog();

            CargarActividadReciente();
        }
        private void timerReloj_Tick(
            object sender,
            EventArgs e)
        {
            lblFecha.Text =
                DateTime.Now
                .ToString("dd MMM yyyy")
                .ToUpper();

            lblHora.Text =
                DateTime.Now
                .ToString("HH:mm:ss");
        }
        private void lblSalir_Click(object sender,EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro de salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


            if (respuesta ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}