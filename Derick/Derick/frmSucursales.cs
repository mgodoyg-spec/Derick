using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class frmSucursales : Form
    {
        private bool cargandoFiltros = false;
        public frmSucursales()
        {
            InitializeComponent();
        }
        private void frmSucursales_Load(object sender, EventArgs e)
        {
            // diseño del datagridview
            dgvSucursales.EnableHeadersVisualStyles = false;
            dgvSucursales.BorderStyle = BorderStyle.None;
            dgvSucursales.BackgroundColor = Color.White;
            dgvSucursales.GridColor = Color.FromArgb(235, 235, 235);
            dgvSucursales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvSucursales.ReadOnly = true;
            dgvSucursales.MultiSelect = false;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.RowHeadersVisible = false;

            // encabezado
            dgvSucursales.ColumnHeadersHeight = 55;
            dgvSucursales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSucursales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvSucursales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSucursales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSucursales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // filas
            dgvSucursales.RowTemplate.Height = 45;
            dgvSucursales.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSucursales.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvSucursales.DefaultCellStyle.BackColor = Color.White;
            dgvSucursales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvSucursales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvSucursales.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSucursales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSucursales.DefaultCellStyle.Padding = new Padding(5);

            // columnas
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSucursales.Columns["clDireccion"].Visible = false;
            dgvSucursales.Columns["clTelefono"].Visible = false;

            dgvSucursales.Columns["clCodigo"].FillWeight = 12;
            dgvSucursales.Columns["clCodigo"].MinimumWidth = 80;

            dgvSucursales.Columns["clFechaRegistro"].Visible = true;
            dgvSucursales.Columns["clFechaRegistro"].FillWeight = 12;
            dgvSucursales.Columns["clFechaRegistro"].MinimumWidth = 100;
            dgvSucursales.Columns["clFechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvSucursales.Columns["clNombreSucursal"].FillWeight = 30;
            dgvSucursales.Columns["clNombreSucursal"].MinimumWidth = 200;

            dgvSucursales.Columns["clCiudad"].FillWeight = 16;
            dgvSucursales.Columns["clCiudad"].MinimumWidth = 110;

            dgvSucursales.Columns["clEncargado"].FillWeight = 20;
            dgvSucursales.Columns["clEncargado"].MinimumWidth = 150;

            dgvSucursales.Columns["clEstado"].FillWeight = 12;
            dgvSucursales.Columns["clEstado"].MinimumWidth = 90;

            dgvSucursales.Columns["clEditar"].FillWeight = 8;
            dgvSucursales.Columns["clEditar"].MinimumWidth = 70;

            dgvSucursales.Columns["clUbicacion"].FillWeight = 9;
            dgvSucursales.Columns["clUbicacion"].MinimumWidth = 80;

            dgvSucursales.Columns["clVer"].FillWeight = 8;
            dgvSucursales.Columns["clVer"].MinimumWidth = 70;

            // iconos de acciones
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvSucursales.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn ubicacion = (DataGridViewImageColumn)dgvSucursales.Columns["clUbicacion"];
            ubicacion.Image = Properties.Resources.ubicacionnnnbtn;
            ubicacion.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn ver = (DataGridViewImageColumn)dgvSucursales.Columns["clVer"];
            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;

            CargarComboCiudad();
            CargarComboEstado();
            CargarSucursales();

        }
        // cargar ciudades en el combo box
        private void CargarComboCiudad()
        {
            cargandoFiltros = true;

            csConectaSQL oConexion = new csConectaSQL();

            string sql = "select distinct Ciudad from Sucursales order by Ciudad";

            DataTable datos = oConexion.RetornaRegistros(sql);

            cbxCiudad.DataSource = datos;
            cbxCiudad.DisplayMember = "Ciudad";
            cbxCiudad.ValueMember = "Ciudad";
            cbxCiudad.SelectedIndex = -1;
            cbxCiudad.Text = "";

            cargandoFiltros = false;
        }
        // estados en el combo box
        private void CargarComboEstado()
        {
            cargandoFiltros = true;

            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activa");
            cbxEstado.Items.Add("Inactiva");
            cbxEstado.Items.Add("Remodelación");

            cbxEstado.SelectedIndex = -1;
            cbxEstado.Text = "";

            cargandoFiltros = false;
        }
        // mostrar sucursales en el datagridview
        private void CargarSucursales(string buscar = "", string ciudad = "", string estado = "")
        {
            csSucursal sucursal = new csSucursal();
            DataTable datos = sucursal.Listar(buscar, ciudad, estado);

            dgvSucursales.AutoGenerateColumns = false;

            dgvSucursales.Columns["clCodigo"].DataPropertyName = "Codigo";
            dgvSucursales.Columns["clFechaRegistro"].DataPropertyName = "FechaRegistro";
            dgvSucursales.Columns["clNombreSucursal"].DataPropertyName = "NombreSucursal";
            dgvSucursales.Columns["clCiudad"].DataPropertyName = "Ciudad";
            dgvSucursales.Columns["clDireccion"].DataPropertyName = "Direccion";
            dgvSucursales.Columns["clTelefono"].DataPropertyName = "Telefono";
            dgvSucursales.Columns["clEncargado"].DataPropertyName = "EncargadoSucursal";
            dgvSucursales.Columns["clEstado"].DataPropertyName = "Estado";

            dgvSucursales.DataSource = datos;
        }
        //registrar sucursal
        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            frmRegistroSucursales frm = new frmRegistroSucursales();
            frm.ShowDialog();
            CargarSucursales();
            CargarComboCiudad();

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            string buscar = txtBuscar.Text;

            if (buscar == "Buscar")
                buscar = "";

            CargarSucursales(buscar,cbxCiudad.Text,cbxEstado.Text);
        }
        private void cbxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            AplicarFiltros();
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            AplicarFiltros();

        }
        // limpiar filtros
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargandoFiltros = true;

            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.Gray;

            cbxCiudad.SelectedIndex = -1;
            cbxCiudad.Text = "";

            cbxEstado.SelectedIndex = -1;
            cbxEstado.Text = "";

            cargandoFiltros = false;

            CargarSucursales();

        }
        //click en el datagridview
        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columna = dgvSucursales.Columns[e.ColumnIndex].Name;
            string codigo = dgvSucursales.Rows[e.RowIndex].Cells["clCodigo"].Value.ToString();

            csSucursal sucursal = new csSucursal();
            csSucursal encontrada = sucursal.BuscarPorCodigo(codigo);

            if (encontrada == null)
            {
                MessageBox.Show(
                    "No se encontró la sucursal.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (columna == "clEditar")
            {
                frmRegistroSucursales frm = new frmRegistroSucursales(encontrada);
                frm.ShowDialog();

                CargarSucursales();
                CargarComboCiudad();
            }

            if (columna == "clUbicacion")
            {
                frmUbicacionSucursales frm = new frmUbicacionSucursales(encontrada);
                frm.ShowDialog();
            }

            if (columna == "clVer")
            {
                frmVerSucursales frm = new frmVerSucursales(encontrada);
                frm.ShowDialog();

                CargarSucursales();
                CargarComboCiudad();
            }

        }
        private void lblSalirV_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void AplicarFiltros()
        {
            string buscar = txtBuscar.Text;

            if (buscar == "Buscar")
                buscar = "";

            CargarSucursales(buscar,cbxCiudad.Text,cbxEstado.Text);
        }
    }
}