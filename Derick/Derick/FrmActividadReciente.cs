using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmActividadReciente : Form
    {
        public FrmActividadReciente()
        {
            InitializeComponent();
        }

        private void FrmActividadReciente_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvActividad.EnableHeadersVisualStyles = false;
            dgvActividad.BorderStyle = BorderStyle.None;
            dgvActividad.BackgroundColor = Color.White;
            dgvActividad.GridColor = Color.FromArgb(235, 235, 235);
            dgvActividad.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvActividad.ReadOnly = true;
            dgvActividad.MultiSelect = false;
            dgvActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividad.AllowUserToAddRows = false;
            dgvActividad.AllowUserToDeleteRows = false;
            dgvActividad.AllowUserToResizeRows = false;
            dgvActividad.AllowUserToResizeColumns = false;
            dgvActividad.RowHeadersVisible = false;

            //encabezado
            dgvActividad.ColumnHeadersHeight = 55;
            dgvActividad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvActividad.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvActividad.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvActividad.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvActividad.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvActividad.RowTemplate.Height = 45;
            dgvActividad.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
            dgvActividad.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);
            dgvActividad.DefaultCellStyle.BackColor = Color.White;
            dgvActividad.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);
            dgvActividad.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 250);
            dgvActividad.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvActividad.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvActividad.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvActividad.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            //fecha
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Value = DateTime.Now;

            CargarActividades();
        }

        private void CargarActividades()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable datos = conexion.RetornaRegistros(
                "select Descripcion, Fecha " +
                "from ActividadReciente " +
                "order by Fecha desc");

            dgvActividad.DataSource = datos;

            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
            if (dgvActividad.Columns["Descripcion"] != null)
            {
                dgvActividad.Columns["Descripcion"].HeaderText = "ACTIVIDAD";
                dgvActividad.Columns["Descripcion"].FillWeight = 75;
                dgvActividad.Columns["Descripcion"].MinimumWidth = 400;
                dgvActividad.Columns["Descripcion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            if (dgvActividad.Columns["Fecha"] != null)
            {
                dgvActividad.Columns["Fecha"].HeaderText = "FECHA Y HORA";
                dgvActividad.Columns["Fecha"].FillWeight = 25;
                dgvActividad.Columns["Fecha"].MinimumWidth = 160;
                dgvActividad.Columns["Fecha"].DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string fechaInicio =
                dtpFecha.Value.Date.ToString("yyyyMMdd");

            string fechaFin =
                dtpFecha.Value.Date.AddDays(1).ToString("yyyyMMdd");

            csConectaSQL conexion = new csConectaSQL();

            string sql =
                "select Descripcion, Fecha " +
                "from ActividadReciente " +
                "where Fecha >= '" + fechaInicio + "' " +
                "and Fecha < '" + fechaFin + "' " +
                "order by Fecha desc";

            DataTable datos = conexion.RetornaRegistros(sql);

            dgvActividad.DataSource = datos;

            ConfigurarColumnas();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}