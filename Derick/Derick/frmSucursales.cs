using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }
        private void frmSucursales_Load(object sender, EventArgs e)
        {

            //====================== DISEÑO DEL DATAGRIDVIEW ======================

            dgvSucursales.EnableHeadersVisualStyles = false;

            dgvSucursales.BorderStyle = BorderStyle.None;
            dgvSucursales.BackgroundColor = Color.White;
            dgvSucursales.GridColor = Color.FromArgb(235, 235, 235);

            dgvSucursales.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvSucursales.ReadOnly = true;
            dgvSucursales.MultiSelect = false;
            dgvSucursales.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;

            dgvSucursales.RowHeadersVisible = false;



            //====================== ENCABEZADO ======================

            dgvSucursales.ColumnHeadersHeight = 50;
            dgvSucursales.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;
            dgvSucursales.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 57, 75);
            dgvSucursales.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;
            dgvSucursales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSucursales.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //====================== FILAS ======================
            dgvSucursales.RowTemplate.Height = 45;
            dgvSucursales.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
            dgvSucursales.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);
            dgvSucursales.DefaultCellStyle.BackColor =
                Color.White;
            dgvSucursales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);
            dgvSucursales.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 250);
            dgvSucursales.DefaultCellStyle.SelectionForeColor =
                Color.Black;
            dgvSucursales.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvSucursales.DefaultCellStyle.Padding =
                new Padding(5);
            //====================== COLUMNAS ======================

            dgvSucursales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.Columns["clCodigo"].FillWeight = 8;
            dgvSucursales.Columns["clFechaRegistro"].FillWeight = 12;
            dgvSucursales.Columns["clNombreSucursal"].FillWeight = 20;
            dgvSucursales.Columns["clCiudad"].FillWeight = 12;
            dgvSucursales.Columns["clDireccion"].FillWeight = 20;
            dgvSucursales.Columns["clTelefono"].FillWeight = 13;
            dgvSucursales.Columns["clEncargado"].FillWeight = 18;
            dgvSucursales.Columns["clEstado"].FillWeight = 10;
            dgvSucursales.Columns["clEditar"].FillWeight = 8;
            dgvSucursales.Columns["clUbicacion"].FillWeight = 8;
            dgvSucursales.Columns["clVer"].FillWeight = 8;
            DataGridViewImageColumn editar =
            (DataGridViewImageColumn)dgvSucursales.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout =
                DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn ubicacion =
            (DataGridViewImageColumn)dgvSucursales.Columns["clUbicacion"];

            ubicacion.Image =
                Properties.Resources.ubicacionnnnbtn;

            ubicacion.ImageLayout =
                DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn ver =
            (DataGridViewImageColumn)dgvSucursales.Columns["clVer"];
            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout =
                DataGridViewImageCellLayout.Zoom;
            // CARGAR DATOS
            CargarComboCiudad();
            CargarComboEstado();
            CargarSucursales();

        }
        //====================================================
        // CARGAR CIUDADES
        //====================================================

        private void CargarComboCiudad()
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                con.Open();
                string query ="SELECT DISTINCT Ciudad FROM Sucursales";
                SqlDataAdapter da =new SqlDataAdapter(query, con);
                DataTable dt =new DataTable();
                da.Fill(dt);
                cbxCiudad.DataSource = dt;
                cbxCiudad.DisplayMember =
                    "Ciudad";
                cbxCiudad.ValueMember =
                    "Ciudad";
                cbxCiudad.Text = "";

            }
        }
        //====================================================
        // ESTADO
        //====================================================
        private void CargarComboEstado()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activa");
            cbxEstado.Items.Add("Inactiva");
            cbxEstado.Items.Add("Remodelación");
            cbxEstado.Text = "";
        }
        //====================================================
        // MOSTRAR SUCURSALES
        //====================================================
        private void CargarSucursales(
        string buscar = "",
        string ciudad = "",
        string estado = "")
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                con.Open();
                string query = @"
                SELECT
                Codigo,
                GETDATE() AS FechaRegistro,
                NombreSucursal,
                Ciudad,
                Direccion,
                Telefono,
                EncargadoSucursal,
                Estado
                FROM Sucursales
                WHERE
                (Codigo LIKE @buscar
                OR NombreSucursal LIKE @buscar)
                AND (@ciudad = '' OR Ciudad = @ciudad)
                AND (@estado = '' OR Estado = @estado)
                ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue(
                    "@buscar",
                    "%" + buscar.Trim() + "%"
                );
                da.SelectCommand.Parameters.AddWithValue(
                    "@ciudad",
                    ciudad
                );
                da.SelectCommand.Parameters.AddWithValue(
                    "@estado",
                    estado
                );
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSucursales.AutoGenerateColumns = false;
                dgvSucursales.Columns["clCodigo"].DataPropertyName = "Codigo";
                dgvSucursales.Columns["clFechaRegistro"].DataPropertyName = "FechaRegistro";
                dgvSucursales.Columns["clNombreSucursal"].DataPropertyName = "NombreSucursal";
                dgvSucursales.Columns["clCiudad"].DataPropertyName = "Ciudad";
                dgvSucursales.Columns["clDireccion"].DataPropertyName = "Direccion";
                dgvSucursales.Columns["clTelefono"].DataPropertyName = "Telefono";
                dgvSucursales.Columns["clEncargado"].DataPropertyName = "EncargadoSucursal";
                dgvSucursales.Columns["clEstado"].DataPropertyName = "Estado";
                dgvSucursales.DataSource = dt;
            }
        }
        //====================================================
        // REGISTRAR
        //====================================================
        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            frmRegistroSucursales frm =new frmRegistroSucursales();
            frm.ShowDialog();
            CargarSucursales();
            CargarComboCiudad();

        }
        //====================================================
        // BUSCAR
        //====================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarSucursales(
                txtBuscar.Text,
                cbxCiudad.Text,
                cbxEstado.Text);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarSucursales(
                txtBuscar.Text,
                cbxCiudad.Text,
                cbxEstado.Text);
        }
        private void cbxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSucursales(
                txtBuscar.Text,
                cbxCiudad.Text,
                cbxEstado.Text);
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSucursales(
                txtBuscar.Text,
                cbxCiudad.Text,
                cbxEstado.Text);

        }
        //====================================================
        // LIMPIAR
        //====================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cbxCiudad.Text = "";
            cbxEstado.Text = "";
            CargarSucursales();

        }
        //====================================================
        // CLICK TABLA
        //====================================================
        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            string columna =dgvSucursales.Columns[e.ColumnIndex].Name;
            if (columna == "clEditar")
            {
                MessageBox.Show("Editar sucursal");
            }
            if (columna == "clUbicacion")
            {

                frmUbicacionSucursales frm =
                    new frmUbicacionSucursales();

                frm.Show();

            }
            if (columna == "clVer")
            {
                MessageBox.Show("Ver información");
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

    }
}