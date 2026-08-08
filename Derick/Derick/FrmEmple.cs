using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class FrmEmple : Form
    {
        public FrmEmple()
        {
            InitializeComponent();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDepa_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frm = new FrmDepartamentos();
            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmInfoEmple frm = new FrmInfoEmple();
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmple_Load(object sender, EventArgs e)
        {
            //====================== DISEÑO DEL DATAGRIDVIEW ======================

            dgvEmpleados.EnableHeadersVisualStyles = false;

            // General
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.GridColor = Color.FromArgb(235, 235, 235);

            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;

            dgvEmpleados.RowHeadersVisible = false;


            //====================== ENCABEZADO ======================

            dgvEmpleados.ColumnHeadersHeight = 50;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 57, 75); // #2E394B

            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            //====================== FILAS ======================

            dgvEmpleados.RowTemplate.Height = 45;

            dgvEmpleados.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvEmpleados.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);

            dgvEmpleados.DefaultCellStyle.BackColor =
                Color.White;

            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);

            // Selección elegante
            dgvEmpleados.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 250);

            dgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // Alineación general
            dgvEmpleados.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Espaciado interno
            dgvEmpleados.DefaultCellStyle.Padding =
                new Padding(5);


            //====================== AJUSTE DE COLUMNAS ======================

            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Distribución equilibrada
            dgvEmpleados.Columns["clCodigo"].FillWeight = 8;
            dgvEmpleados.Columns["clEmpleado"].FillWeight = 20;
            dgvEmpleados.Columns["clCargo"].FillWeight = 12;
            dgvEmpleados.Columns["clDepartamento"].FillWeight = 20;
            dgvEmpleados.Columns["clTelefono"].FillWeight = 13;
            dgvEmpleados.Columns["clCorreo"].FillWeight = 18;
            dgvEmpleados.Columns["clEstado"].FillWeight = 10;

            dgvEmpleados.Columns["clEditar"].FillWeight = 8;
            dgvEmpleados.Columns["clEliminar"].FillWeight = 8;
            dgvEmpleados.Columns["clVer"].FillWeight = 8;
            dgvEmpleados.Columns["clImagen"].FillWeight = 8;

            // Icono editar
            DataGridViewImageColumn editar =
            (DataGridViewImageColumn)dgvEmpleados.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Icono eliminar
            DataGridViewImageColumn eliminar =
            (DataGridViewImageColumn)dgvEmpleados.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Icono ver
            DataGridViewImageColumn ver =
            (DataGridViewImageColumn)dgvEmpleados.Columns["clVer"];
            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Icono imagen
            DataGridViewImageColumn imagen =
            (DataGridViewImageColumn)dgvEmpleados.Columns["clImagen"];
            imagen.Image = Properties.Resources.person_icon_31846;
            imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;


            //====================== COLUMNAS CENTRADAS ======================

            string[] columnasCentro =
            {
                "clCodigo",
                "clEmpleado",
                "clCargo",
                "clDepartamento",
                "clTelefono",
                "clCorreo",
                "clEstado",
                "clEditar",
                "clEliminar",
                "clVer",
                "clImagen",
            };

            foreach (string columna in columnasCentro)
            {
                dgvEmpleados.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }


            //====================== CARGA DE DATOS ======================

            CargarComboDepartamento();
            CargarComboEstado();
            CargarComboSucursal();
            CargarEmpleados();
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
          "¿Está seguro de salir?",
          "Confirmar salida",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNuevoEmple_Click(object sender, EventArgs e)
        {
            FrmInfoEmple frm = new FrmInfoEmple();
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void CargarComboDepartamento()
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                string query = "SELECT DISTINCT Departamento FROM Empleados WHERE Departamento IS NOT NULL AND Departamento <> ''";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxDepa.DataSource = dt;
                cbxDepa.DisplayMember = "Departamento";
                cbxDepa.ValueMember = "Departamento";
            }
            cbxDepa.Text = "";
        }

        private void CargarComboEstado()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            cbxEstado.Text = "";
        }

        private void CargarComboSucursal()
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                string query = "SELECT NombreSucursal FROM Sucursales";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxSucursal.DataSource = dt;
                cbxSucursal.DisplayMember = "NombreSucursal";
                cbxSucursal.ValueMember = "NombreSucursal";
            }
            cbxSucursal.Text = "";
        }

        private void CargarEmpleados(string filtroBusqueda = "", string departamento = "", string estadoFiltro = "", string sucursal = "")
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                string query = @"SELECT Codigo, 
                                 Nombres + ' ' + Apellidos AS Empleado,
                                 Cargo, 
                                 Departamento, 
                                 Telefono, 
                                 Correo, 
                                 CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                          FROM Empleados
                          WHERE Nombres LIKE @filtro
                          AND (@depto = '' OR Departamento = @depto)
                          AND (@estado = '' OR Estado = @estadoBit)
                          AND (@sucursal = '' OR IdSucursal = (SELECT IdSucursal FROM Sucursales WHERE NombreSucursal = @sucursal))";

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtroBusqueda + "%");
                da.SelectCommand.Parameters.AddWithValue("@depto", departamento ?? "");
                da.SelectCommand.Parameters.AddWithValue("@estado", estadoFiltro ?? "");
                da.SelectCommand.Parameters.AddWithValue("@estadoBit", estadoFiltro == "Activo" ? 1 : 0);
                da.SelectCommand.Parameters.AddWithValue("@sucursal", sucursal ?? "");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.AutoGenerateColumns = false;

                dgvEmpleados.Columns["clCodigo"].DataPropertyName = "Codigo";
                dgvEmpleados.Columns["clEmpleado"].DataPropertyName = "Empleado";
                dgvEmpleados.Columns["clCargo"].DataPropertyName = "Cargo";
                dgvEmpleados.Columns["clDepartamento"].DataPropertyName = "Departamento";
                dgvEmpleados.Columns["clTelefono"].DataPropertyName = "Telefono";
                dgvEmpleados.Columns["clCorreo"].DataPropertyName = "Correo";
                dgvEmpleados.Columns["clEstado"].DataPropertyName = "Estado";

                dgvEmpleados.DataSource = dt;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text, cbxDepa.Text, cbxEstado.Text, cbxSucursal.Text);
        }

        private void cbxDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text, cbxDepa.Text, cbxEstado.Text, cbxSucursal.Text);
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text, cbxDepa.Text, cbxEstado.Text, cbxSucursal.Text);
        }

        private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text, cbxDepa.Text, cbxEstado.Text, cbxSucursal.Text);
        }
    }
}