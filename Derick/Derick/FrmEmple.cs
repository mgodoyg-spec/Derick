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
            //diseño del datagridview
            dgvEmpleados.EnableHeadersVisualStyles = false;
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
            //encabezado
            dgvEmpleados.ColumnHeadersHeight = 50;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //filas
            dgvEmpleados.RowTemplate.Height = 45;
            dgvEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvEmpleados.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvEmpleados.DefaultCellStyle.BackColor = Color.White;
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvEmpleados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvEmpleados.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvEmpleados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.DefaultCellStyle.Padding = new Padding(5);
            //columnas
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvEmpleados.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvEmpleados.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn ver = (DataGridViewImageColumn)dgvEmpleados.Columns["clVer"];
            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn imagen = (DataGridViewImageColumn)dgvEmpleados.Columns["clImagen"];
            imagen.Image = Properties.Resources.person_icon_31846;
            imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //columnas centradas
            string[] columnasCentro = { "clCodigo", "clEmpleado", "clCargo", "clDepartamento", "clTelefono", "clCorreo", "clEstado", "clEditar", "clEliminar", "clVer", "clImagen" };
            foreach (string columna in columnasCentro)
            {
                dgvEmpleados.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // cargar datos
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

        // cargar departamentos en el combo
        private void CargarComboDepartamento()
        {
            csConectaSQL oConexion = new csConectaSQL();
            string query = "SELECT DISTINCT Departamento FROM Empleados WHERE Departamento IS NOT NULL AND Departamento <> ''";
            DataTable dt = oConexion.RetornaRegistros(query);

            cbxDepa.DataSource = dt;
            cbxDepa.DisplayMember = "Departamento";
            cbxDepa.ValueMember = "Departamento";
            cbxDepa.Text = "";
        }

        private void CargarComboEstado()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            cbxEstado.Text = "";
        }

        // cargar sucursales en el combo
        private void CargarComboSucursal()
        {
            csConectaSQL oConexion = new csConectaSQL();
            string query = "SELECT NombreSucursal FROM Sucursales";
            DataTable dt = oConexion.RetornaRegistros(query);

            cbxSucursal.DataSource = dt;
            cbxSucursal.DisplayMember = "NombreSucursal";
            cbxSucursal.ValueMember = "NombreSucursal";
            cbxSucursal.Text = "";
        }

        // mostrar empleados en el datagridview
        private void CargarEmpleados(string filtroBusqueda = "", string departamento = "", string estadoFiltro = "", string sucursal = "")
        {
            csConectaSQL oConexion = new csConectaSQL();

            // escapamos comillas simples para que nombres con apostrofe no rompen la consulta
            string filtroEsc = filtroBusqueda.Replace("'", "''");
            string deptoEsc = departamento.Replace("'", "''");
            string sucursalEsc = sucursal.Replace("'", "''");
            int estadoBit = estadoFiltro == "Activo" ? 1 : 0;

            string query = @"SELECT Codigo,
                             Nombres + ' ' + Apellidos AS Empleado,
                             Cargo,
                             Departamento,
                             Telefono,
                             Correo,
                             CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                      FROM Empleados
                      WHERE Nombres LIKE '%" + filtroEsc + @"%'
                      AND ('" + deptoEsc + @"' = '' OR Departamento = '" + deptoEsc + @"')
                      AND ('" + estadoFiltro + @"' = '' OR Estado = " + estadoBit + @")
                      AND ('" + sucursalEsc + @"' = '' OR IdSucursal = (SELECT IdSucursal FROM Sucursales WHERE NombreSucursal = '" + sucursalEsc + @"'))";

            DataTable dt = oConexion.RetornaRegistros(query);

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