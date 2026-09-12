using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class FrmInicioE : Form
    {
        private FlowLayoutPanel pnlActividadDinamica;

        public FrmInicioE(string codigoSucursal)
        {
            InitializeComponent();
        }

        private void FrmInicioE_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            CargarResumen();
            CargarActividadReciente();
        }

        private int ObtenerIdSucursal()
        {
            int idEmpleado = csSesion.ObtenerIdEmpleadoActual();
            if (idEmpleado <= 0) return 0;

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select IdSucursal from Empleados where IdEmpleado = " + idEmpleado);

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["IdSucursal"] != DBNull.Value)
                return Convert.ToInt32(dt.Rows[0]["IdSucursal"]);

            return 0;
        }

        private void CargarResumen()
        {
            int idSucursal = ObtenerIdSucursal();

            if (idSucursal <= 0)
            {
                NumProductos.Text = "0";
                lblStockBajo.Text = "0";
                lblPromociones.Text = "0";
                lblVentas.Text = "0";
                return;
            }

            csConectaSQL conexion = new csConectaSQL();

            DataTable dtProductos = conexion.RetornaRegistros("select count(distinct I.IdProducto) as Total from Inventario I inner join Productos P on I.IdProducto = P.IdProductos where I.IdSucursal = " + idSucursal + " and I.Stock > 0 and P.Estado = 1");
            NumProductos.Text = dtProductos != null && dtProductos.Rows.Count > 0 ? dtProductos.Rows[0]["Total"].ToString() : "0";

            DataTable dtStock = conexion.RetornaRegistros("select count(distinct IdProducto) as Total from Inventario where IdSucursal = " + idSucursal + " and Stock > 0 and Stock <= 5");
            lblStockBajo.Text = dtStock != null && dtStock.Rows.Count > 0 ? dtStock.Rows[0]["Total"].ToString() : "0";

            DataTable dtPromociones = conexion.RetornaRegistros("select count(*) as Total from Promociones where Estado = 1 and cast(getdate() as date) between cast(FechaInicio as date) and cast(FechaFin as date) and (IdSucursal is null or IdSucursal = " + idSucursal + ")");
            lblPromociones.Text = dtPromociones != null && dtPromociones.Rows.Count > 0 ? dtPromociones.Rows[0]["Total"].ToString() : "0";

            DataTable dtVentas = conexion.RetornaRegistros("select count(*) as Total from Ventas where IdSucursal = " + idSucursal + " and cast(Fecha as date) = cast(getdate() as date)");
            lblVentas.Text = dtVentas != null && dtVentas.Rows.Count > 0 ? dtVentas.Rows[0]["Total"].ToString() : "0";
        }

        private void CargarActividadReciente()
        {
            int idSucursal = ObtenerIdSucursal();
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = new DataTable();

            if (idSucursal > 0)
                dt = conexion.RetornaRegistros(
                    "select top 5 'Se registró la venta ' + V.Codigo + ' por $' + cast(V.Total as varchar(20)) as Descripcion, " +
                    "cast(V.Fecha as datetime) + cast(V.Hora as datetime) as Fecha from Ventas V " +
                    "where V.IdSucursal = " + idSucursal + " order by V.Fecha desc, V.Hora desc");

            if (pnlActividadDinamica == null)
            {
                pnlActividadDinamica = new FlowLayoutPanel
                {
                    Location = new Point(350, 330),
                    Size = new Size(770, 285),
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    AutoScroll = false,
                    BackColor = Color.White,
                    Padding = new Padding(0)
                };

                Controls.Add(pnlActividadDinamica);
                pnlActividadDinamica.BringToFront();
            }

            pnlActividadDinamica.Controls.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                Label lblVacio = new Label
                {
                    Text = "No hay actividades recientes.",
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(10, 15, 0, 0)
                };

                pnlActividadDinamica.Controls.Add(lblVacio);
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                string descripcion = fila["Descripcion"].ToString();
                DateTime fecha = Convert.ToDateTime(fila["Fecha"]);

                Panel pnlActividad = new Panel
                {
                    Width = 750,
                    Height = 47,
                    BackColor = Color.FromArgb(248, 249, 251),
                    Margin = new Padding(5, 3, 5, 3)
                };

                Label lblDescripcion = new Label
                {
                    Text = descripcion,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.FromArgb(45, 45, 45),
                    Location = new Point(12, 7),
                    AutoSize = true
                };

                Label lblFechaActividad = new Label
                {
                    Text = ObtenerTiempoTranscurrido(fecha),
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(12, 26),
                    AutoSize = true
                };

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
                return minutos == 1 ? "Hace 1 minuto" : "Hace " + minutos + " minutos";
            }

            if (diferencia.TotalHours < 24)
            {
                int horas = (int)diferencia.TotalHours;
                return horas == 1 ? "Hace 1 hora" : "Hace " + horas + " horas";
            }

            if (diferencia.TotalDays < 7)
            {
                int dias = (int)diferencia.TotalDays;
                return dias == 1 ? "Hace 1 día" : "Hace " + dias + " días";
            }

            return fecha.ToString("dd/MM/yyyy HH:mm");
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            Control contenedor = Parent;

            if (contenedor == null)
            {
                formulario.ShowDialog();
                return;
            }

            Hide();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.BringToFront();

            formulario.FormClosed += (s, e) =>
            {
                contenedor.Controls.Remove(formulario);
                Show();
                BringToFront();
                CargarResumen();
                CargarActividadReciente();
            };

            formulario.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgg_Product frm = new FormAgg_Product();
            frm.ShowDialog();

            CargarResumen();
            CargarActividadReciente();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmVentasN());
        }

        private void btnTransferirProductos_Click(object sender, EventArgs e)
        {
            int idSucursal = ObtenerIdSucursal();

            if (idSucursal <= 0)
            {
                MessageBox.Show("No se pudo identificar la sucursal del empleado.", "Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormTransferir_Productos frm = new FormTransferir_Productos(idSucursal);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarResumen();
                CargarActividadReciente();
            }
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            PresionarBotonMenu("btnreportes");
        }

        private void PresionarBotonMenu(string nombreBoton)
        {
            Control actual = Parent;

            while (actual != null && !(actual is FrmMenuEmpleados))
                actual = actual.Parent;

            if (actual is FrmMenuEmpleados menu)
            {
                Control[] encontrados = menu.Controls.Find(nombreBoton, true);

                if (encontrados.Length > 0 && encontrados[0] is IButtonControl boton)
                    boton.PerformClick();
                else
                    MessageBox.Show("No se encontró el botón de Reportes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            int idSucursal = ObtenerIdSucursal();

            if (idSucursal <= 0)
            {
                MessageBox.Show("No se pudo identificar la sucursal actual.", "Actividad reciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmActividadReciente frm = new FrmActividadReciente();

            frm.Shown += (s, args) =>
            {
                CargarHistorialSucursal(frm, idSucursal, null);

                Control[] botones = frm.Controls.Find("btnFiltrar", true);

                if (botones.Length > 0 && botones[0] is Button btn)
                {
                    btn.Click += (s2, e2) =>
                    {
                        Control[] fechas = frm.Controls.Find("dtpFecha", true);

                        if (fechas.Length > 0 && fechas[0] is DateTimePicker dtp)
                            CargarHistorialSucursal(frm, idSucursal, dtp.Value.Date);
                    };
                }
            };

            frm.ShowDialog();
            CargarActividadReciente();
        }

        private void CargarHistorialSucursal(FrmActividadReciente formulario, int idSucursal, DateTime? fecha)
        {
            csConectaSQL conexion = new csConectaSQL();

            string sql =
                "select 'Se registró la venta ' + V.Codigo + ' por $' + cast(V.Total as varchar(20)) as Descripcion, " +
                "cast(V.Fecha as datetime) + cast(V.Hora as datetime) as Fecha from Ventas V where V.IdSucursal = " + idSucursal + " ";

            if (fecha.HasValue)
            {
                string inicio = fecha.Value.ToString("yyyyMMdd");
                string fin = fecha.Value.AddDays(1).ToString("yyyyMMdd");
                sql += "and V.Fecha >= '" + inicio + "' and V.Fecha < '" + fin + "' ";
            }

            sql += "order by V.Fecha desc, V.Hora desc";

            DataTable datos = conexion.RetornaRegistros(sql);
            Control[] controles = formulario.Controls.Find("dgvActividad", true);

            if (controles.Length > 0 && controles[0] is DataGridView dgv)
            {
                dgv.DataSource = datos;

                if (dgv.Columns["Descripcion"] != null)
                {
                    dgv.Columns["Descripcion"].HeaderText = "ACTIVIDAD";
                    dgv.Columns["Descripcion"].FillWeight = 75;
                    dgv.Columns["Descripcion"].MinimumWidth = 400;
                    dgv.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }

                if (dgv.Columns["Fecha"] != null)
                {
                    dgv.Columns["Fecha"].HeaderText = "FECHA Y HORA";
                    dgv.Columns["Fecha"].FillWeight = 25;
                    dgv.Columns["Fecha"].MinimumWidth = 160;
                    dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
            }
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMM yyyy").ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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
    }
}