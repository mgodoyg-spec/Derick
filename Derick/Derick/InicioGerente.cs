using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Derick
{
    public partial class InicioGerente : Form
    {
        FrmMenuPrincipal menu;
        private FlowLayoutPanel pnlActividadDinamica;

        public InicioGerente(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            menu = menuPrincipal;
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }

        private void InicioGerente_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            CargarResumen();
            CargarActividadReciente();
        }

        private void CargarResumen()
        {
            csConectaSQL oConexion = new csConectaSQL();

            //Sucursales
            DataTable dtSucursales = oConexion.RetornaRegistros(
                "select count(*) as Total from Sucursales");

            label2.Text = dtSucursales.Rows[0]["Total"].ToString();

            //Empleados activos
            DataTable dtEmpleados = oConexion.RetornaRegistros(
                "select count(*) as Total from Empleados where Estado = 1");

            label5.Text = dtEmpleados.Rows[0]["Total"].ToString();

            //Productos activos
            DataTable dtProductos = oConexion.RetornaRegistros(
                "select count(*) as Total from Productos where Estado = 1");

            NumProductos.Text = dtProductos.Rows[0]["Total"].ToString();

            //Ventas realizadas hoy
            DataTable dtVentas = oConexion.RetornaRegistros(
                "select count(*) as Total from Ventas " +
                "where cast(Fecha as date) = cast(getdate() as date)");

            label8.Text = dtVentas.Rows[0]["Total"].ToString();
        }

        private void CargarActividadReciente()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "select top 5 Descripcion, Fecha " +
                "from ActividadReciente order by Fecha desc");

            if (pnlActividadDinamica == null)
            {
                pnlActividadDinamica = new FlowLayoutPanel();
                pnlActividadDinamica.Location = new Point(320, 325);
                pnlActividadDinamica.Size = new Size(770, 260);
                pnlActividadDinamica.FlowDirection = FlowDirection.TopDown;
                pnlActividadDinamica.WrapContents = false;
                pnlActividadDinamica.AutoScroll = false;
                pnlActividadDinamica.BackColor = Color.White;

                this.Controls.Add(pnlActividadDinamica);
                pnlActividadDinamica.BringToFront();
            }

            pnlActividadDinamica.Controls.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                Label lblVacio = new Label();
                lblVacio.Text = "No hay actividades recientes.";
                lblVacio.Font = new Font("Segoe UI", 10);
                lblVacio.ForeColor = Color.Gray;
                lblVacio.AutoSize = true;
                lblVacio.Margin = new Padding(10, 15, 0, 0);

                pnlActividadDinamica.Controls.Add(lblVacio);
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                string descripcion = fila["Descripcion"].ToString();
                DateTime fecha = Convert.ToDateTime(fila["Fecha"]);

                Panel pnlActividad = new Panel();
                pnlActividad.Width = 730;
                pnlActividad.Height = 47;
                pnlActividad.BackColor = Color.FromArgb(248, 249, 251);
                pnlActividad.Margin = new Padding(5, 3, 5, 3);

                Label lblDescripcion = new Label();
                lblDescripcion.Text = descripcion;
                lblDescripcion.Font = new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold);

                lblDescripcion.ForeColor =
                    Color.FromArgb(45, 45, 45);

                lblDescripcion.Location = new Point(12, 7);
                lblDescripcion.AutoSize = true;

                Label lblFechaActividad = new Label();
                lblFechaActividad.Text =
                    ObtenerTiempoTranscurrido(fecha);

                lblFechaActividad.Font =
                    new Font("Segoe UI", 8);

                lblFechaActividad.ForeColor = Color.Gray;
                lblFechaActividad.Location = new Point(12, 26);
                lblFechaActividad.AutoSize = true;

                pnlActividad.Controls.Add(lblDescripcion);
                pnlActividad.Controls.Add(lblFechaActividad);

                pnlActividadDinamica.Controls.Add(pnlActividad);
            }
        }

        private string ObtenerTiempoTranscurrido(DateTime fecha)
        {
            TimeSpan diferencia = DateTime.Now - fecha;

            if (diferencia.TotalMinutes < 1)
                return "Hace unos segundos";

            if (diferencia.TotalMinutes < 60)
            {
                int minutos = (int)diferencia.TotalMinutes;

                return minutos == 1
                    ? "Hace 1 minuto"
                    : "Hace " + minutos + " minutos";
            }

            if (diferencia.TotalHours < 24)
            {
                int horas = (int)diferencia.TotalHours;

                return horas == 1
                    ? "Hace 1 hora"
                    : "Hace " + horas + " horas";
            }

            if (diferencia.TotalDays < 7)
            {
                int dias = (int)diferencia.TotalDays;

                return dias == 1
                    ? "Hace 1 día"
                    : "Hace " + dias + " días";
            }

            return fecha.ToString("dd/MM/yyyy HH:mm");
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text =
                DateTime.Now.ToString("dd MMM yyyy").ToUpper();

            lblHora.Text =
                DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgg_Product frm = new FormAgg_Product();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarActividadReciente();
                CargarResumen();
            }
        }

        private void btnVerSucursales_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario(new frmSucursales());
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario(new FrmEmple());
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario(new FrmVentasN());
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            FrmActividadReciente frm = new FrmActividadReciente();
            frm.ShowDialog();
        }
    }
}