using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmInicioE : Form
    {
        private string codigoSucursal;

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
        private int ObtenerIdSucursal()
        {
            if (int.TryParse(
                codigoSucursal,
                out int idSucursal))
            {
                return idSucursal;
            }

            return 0;
        }
        private void CargarResumen()
        {
            int idSucursal =
                ObtenerIdSucursal();

            csConectaSQL oConexion =
                new csConectaSQL();
            DataTable dtProductos =
                oConexion.RetornaRegistros(
                    "SELECT COUNT(DISTINCT I.IdProducto) AS Total " +
                    "FROM Inventario I " +
                    "INNER JOIN Productos P " +
                    "ON I.IdProducto = P.IdProductos " +
                    "WHERE I.IdSucursal = " + idSucursal + " " +
                    "AND I.Stock > 0 " +
                    "AND P.Estado = 1"
                );

            if (dtProductos != null &&
                dtProductos.Rows.Count > 0)
            {
                NumProductos.Text =
                    dtProductos.Rows[0]["Total"]
                    .ToString();
            }
            else
            {
                NumProductos.Text = "0";
            }


            // =====================================================
            // STOCK BAJO DE ESTA SUCURSAL
            // Se considera stock bajo de 1 a 5 unidades.
            // =====================================================
            DataTable dtStockBajo =
                oConexion.RetornaRegistros(
                    "SELECT COUNT(DISTINCT IdProducto) AS Total " +
                    "FROM Inventario " +
                    "WHERE IdSucursal = " + idSucursal + " " +
                    "AND Stock > 0 " +
                    "AND Stock <= 5"
                );

            if (dtStockBajo != null &&
                dtStockBajo.Rows.Count > 0)
            {
                lblStockBajo.Text =
                    dtStockBajo.Rows[0]["Total"]
                    .ToString();
            }
            else
            {
                lblStockBajo.Text = "0";
            }


            // =====================================================
            // PROMOCIONES ACTIVAS DE ESTA SUCURSAL
            // =====================================================
            DataTable dtPromociones =
                oConexion.RetornaRegistros(
                    "SELECT COUNT(*) AS Total " +
                    "FROM Promociones " +
                    "WHERE Estado = 1 " +
                    "AND CAST(GETDATE() AS DATE) " +
                    "BETWEEN CAST(FechaInicio AS DATE) " +
                    "AND CAST(FechaFin AS DATE) " +
                    "AND (" +
                    "IdSucursal IS NULL " +
                    "OR IdSucursal = " + idSucursal +
                    ")"
                );

            if (dtPromociones != null &&
                dtPromociones.Rows.Count > 0)
            {
                lblPromociones.Text =
                    dtPromociones.Rows[0]["Total"]
                    .ToString();
            }
            else
            {
                lblPromociones.Text = "0";
            }


            // =====================================================
            // VENTAS DE HOY DE ESTA SUCURSAL
            // =====================================================
            DataTable dtVentas =
                oConexion.RetornaRegistros(
                    "SELECT COUNT(*) AS Total " +
                    "FROM Ventas " +
                    "WHERE CAST(Fecha AS DATE) = " +
                    "CAST(GETDATE() AS DATE) " +
                    "AND IdSucursal = " + idSucursal
                );

            if (dtVentas != null &&
                dtVentas.Rows.Count > 0)
            {
                lblVentas.Text =
                    dtVentas.Rows[0]["Total"]
                    .ToString();
            }
            else
            {
                lblVentas.Text = "0";
            }
        }

        private void CargarActividadReciente()
        {
            int idEmpleado =
                csSesion.ObtenerIdEmpleadoActual();

            csConectaSQL conexion =
                new csConectaSQL();

            DataTable dt;


            // Si encontramos al empleado, mostrar SOLO lo suyo
            if (idEmpleado > 0)
            {
                dt = conexion.RetornaRegistros(
                    "SELECT TOP 5 Descripcion, Fecha " +
                    "FROM ActividadReciente " +
                    "WHERE IdEmpleado = " + idEmpleado + " " +
                    "ORDER BY Fecha DESC"
                );
            }
            else
            {
                // No mostrar actividades generales accidentalmente
                dt = new DataTable();

                dt.Columns.Add(
                    "Descripcion",
                    typeof(string)
                );

                dt.Columns.Add(
                    "Fecha",
                    typeof(DateTime)
                );
            }

            if (pnlActividadDinamica == null)
            {
                pnlActividadDinamica =
                    new FlowLayoutPanel();

                pnlActividadDinamica.Location =
                    new Point(350, 425);

                pnlActividadDinamica.Size =
                    new Size(770, 260);

                pnlActividadDinamica.FlowDirection =
                    FlowDirection.TopDown;

                pnlActividadDinamica.WrapContents =
                    false;

                pnlActividadDinamica.AutoScroll =
                    false;

                pnlActividadDinamica.BackColor =
                    Color.White;

                this.Controls.Add(
                    pnlActividadDinamica
                );

                pnlActividadDinamica
                    .BringToFront();
            }


            pnlActividadDinamica
                .Controls.Clear();
            if (dt == null ||
                dt.Rows.Count == 0)
            {
                Label lblVacio =
                    new Label();

                if (idEmpleado <= 0)
                {
                    lblVacio.Text =
                        "No se pudo identificar al empleado.";
                }
                else
                {
                    lblVacio.Text =
                        "No hay actividades recientes.";
                }

                lblVacio.Font =
                    new Font(
                        "Segoe UI",
                        10
                    );

                lblVacio.ForeColor =
                    Color.Gray;

                lblVacio.AutoSize =
                    true;

                lblVacio.Margin =
                    new Padding(
                        10,
                        15,
                        0,
                        0
                    );

                pnlActividadDinamica
                    .Controls.Add(lblVacio);

                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                string descripcion =
                    fila["Descripcion"]
                    .ToString();

                DateTime fecha =
                    Convert.ToDateTime(
                        fila["Fecha"]
                    );


                Panel pnlActividad =
                    new Panel();

                pnlActividad.Width = 730;
                pnlActividad.Height = 47;

                pnlActividad.BackColor =
                    Color.FromArgb(
                        248,
                        249,
                        251
                    );

                pnlActividad.Margin =
                    new Padding(
                        5,
                        3,
                        5,
                        3
                    );


                // Descripción
                Label lblDescripcion =
                    new Label();

                lblDescripcion.Text =
                    descripcion;

                lblDescripcion.Font =
                    new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Bold
                    );

                lblDescripcion.ForeColor =
                    Color.FromArgb(
                        45,
                        45,
                        45
                    );

                lblDescripcion.Location =
                    new Point(12, 7);

                lblDescripcion.AutoSize =
                    true;


                // Fecha
                Label lblFechaActividad =
                    new Label();

                lblFechaActividad.Text =
                    ObtenerTiempoTranscurrido(
                        fecha
                    );

                lblFechaActividad.Font =
                    new Font(
                        "Segoe UI",
                        8
                    );

                lblFechaActividad.ForeColor =
                    Color.Gray;

                lblFechaActividad.Location =
                    new Point(12, 26);

                lblFechaActividad.AutoSize =
                    true;


                pnlActividad.Controls.Add(
                    lblDescripcion
                );

                pnlActividad.Controls.Add(
                    lblFechaActividad
                );

                pnlActividadDinamica
                    .Controls.Add(
                        pnlActividad
                    );
            }
        }
        private string ObtenerTiempoTranscurrido(
            DateTime fecha)
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


            return fecha.ToString(
                "dd/MM/yyyy HH:mm"
            );
        }
        private void AbrirFormularioEnPanel(
            Form formulario)
        {
            Control contenedor =
                this.Parent;


            if (contenedor == null)
            {
                formulario.ShowDialog();

                return;
            }


            this.Hide();


            formulario.TopLevel =
                false;

            formulario.FormBorderStyle =
                FormBorderStyle.None;

            formulario.Dock =
                DockStyle.Fill;


            contenedor.Controls.Add(
                formulario
            );

            formulario.BringToFront();


            formulario.FormClosed +=
                (s, e) =>
                {
                    if (formulario is FrmVentasN &&
    formulario.DialogResult == DialogResult.OK)
                    {
                        AsignarUltimaActividadAlEmpleado(
                            "Se registró la venta"
                        );
                    }
                    contenedor.Controls.Remove(
                        formulario
                    );

                    this.Show();

                    this.BringToFront();

                    CargarResumen();

                    CargarActividadReciente();
                };


            formulario.Show();
        }
        private void btnAgregarProducto_Click(
            object sender,
            EventArgs e)
        {
            FormAgg_Product frm =
                new FormAgg_Product();


            frm.ShowDialog();


            CargarResumen();

            CargarActividadReciente();
        }
        private void btnAgregarVenta_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormularioEnPanel(
                new FrmVentasN()
            );
        }
        private void btnTransferirProductos_Click(
            object sender,
            EventArgs e)
        {
            int idSucursal = ObtenerIdSucursal();

            FormTransferir_Productos frm =
                new FormTransferir_Productos(idSucursal);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AsignarUltimaActividadAlEmpleado(
                    "Se transfirió"
                );

                CargarResumen();
                CargarActividadReciente();
            }
        }
        private void btnVerReportes_Click(
            object sender,
            EventArgs e)
        {
            PresionarBotonMenu(
                "btnreportes"
            );
        }


        private void PresionarBotonMenu(
            string nombreBoton)
        {
            Control actual =
                this.Parent;


            while (actual != null &&
                   !(actual is FrmMenuEmpleados))
            {
                actual =
                    actual.Parent;
            }


            if (actual is FrmMenuEmpleados menu)
            {
                Control[] encontrados =
                    menu.Controls.Find(
                        nombreBoton,
                        true
                    );


                if (encontrados.Length > 0 &&
                    encontrados[0]
                    is IButtonControl boton)
                {
                    boton.PerformClick();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el botón de Reportes.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
        private void btnVerTodo_Click(
            object sender,
            EventArgs e)
        {
            int idEmpleado =
                csSesion.ObtenerIdEmpleadoActual();


            if (idEmpleado <= 0)
            {
                MessageBox.Show(
                    "No se pudo identificar al empleado actual.",
                    "Actividad reciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            FrmActividadReciente frm =
                new FrmActividadReciente();

            frm.Shown +=
                (s, args) =>
                {
                    CargarHistorialEmpleado(
                        frm,
                        idEmpleado,
                        null
                    );


                    // Buscar el botón Filtrar del formulario
                    Control[] botones =
                        frm.Controls.Find(
                            "btnFiltrar",
                            true
                        );


                    if (botones.Length > 0 &&
                        botones[0] is Button btn)
                    {
                        btn.Click +=
                            (s2, e2) =>
                            {
                                Control[] fechas =
                                    frm.Controls.Find(
                                        "dtpFecha",
                                        true
                                    );


                                if (fechas.Length > 0 &&
                                    fechas[0]
                                    is DateTimePicker dtp)
                                {
                                    CargarHistorialEmpleado(
                                        frm,
                                        idEmpleado,
                                        dtp.Value.Date
                                    );
                                }
                            };
                    }
                };


            frm.ShowDialog();


            CargarActividadReciente();
        }

        private void CargarHistorialEmpleado(
            FrmActividadReciente formulario,
            int idEmpleado,
            DateTime? fecha)
        {
            csConectaSQL conexion =
                new csConectaSQL();


            string sql =
                "SELECT Descripcion, Fecha " +
                "FROM ActividadReciente " +
                "WHERE IdEmpleado = " +
                idEmpleado + " ";


            if (fecha.HasValue)
            {
                string fechaInicio =
                    fecha.Value
                    .ToString("yyyyMMdd");

                string fechaFin =
                    fecha.Value
                    .AddDays(1)
                    .ToString("yyyyMMdd");


                sql +=
                    "AND Fecha >= '" +
                    fechaInicio +
                    "' " +
                    "AND Fecha < '" +
                    fechaFin +
                    "' ";
            }


            sql +=
                "ORDER BY Fecha DESC";


            DataTable datos =
                conexion.RetornaRegistros(
                    sql
                );


            Control[] controles =
                formulario.Controls.Find(
                    "dgvActividad",
                    true
                );


            if (controles.Length > 0 &&
                controles[0]
                is DataGridView dgv)
            {
                dgv.DataSource =
                    datos;


                if (dgv.Columns["Descripcion"] != null)
                {
                    dgv.Columns["Descripcion"]
                        .HeaderText =
                        "ACTIVIDAD";

                    dgv.Columns["Descripcion"]
                        .FillWeight =
                        75;

                    dgv.Columns["Descripcion"]
                        .MinimumWidth =
                        400;

                    dgv.Columns["Descripcion"]
                        .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment
                        .MiddleLeft;
                }


                if (dgv.Columns["Fecha"] != null)
                {
                    dgv.Columns["Fecha"]
                        .HeaderText =
                        "FECHA Y HORA";

                    dgv.Columns["Fecha"]
                        .FillWeight =
                        25;

                    dgv.Columns["Fecha"]
                        .MinimumWidth =
                        160;

                    dgv.Columns["Fecha"]
                        .DefaultCellStyle.Format =
                        "dd/MM/yyyy HH:mm";
                }
            }
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

        private void lblSalir_Click(
            object sender,
            EventArgs e)
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
        private void AsignarUltimaActividadAlEmpleado(string comienzaCon)
        {
            int idEmpleado = csSesion.ObtenerIdEmpleadoActual();

            if (idEmpleado <= 0)
                return;

            csConectaSQL conexion = new csConectaSQL();

            string sql = @"
        WITH UltimaActividad AS
        (
            SELECT TOP 1 IdActividad
            FROM ActividadReciente
            WHERE IdEmpleado IS NULL
            AND Descripcion LIKE @Descripcion
            ORDER BY Fecha DESC, IdActividad DESC
        )

        UPDATE A
        SET IdEmpleado = @IdEmpleado
        FROM ActividadReciente A
        INNER JOIN UltimaActividad U
            ON A.IdActividad = U.IdActividad";

            conexion.ejecutarComando(
                sql,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@Descripcion",
                    comienzaCon + "%"
                ),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@IdEmpleado",
                    idEmpleado
                )
            );
        }
    }
}