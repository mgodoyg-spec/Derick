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

        private void btnDepa_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frm = new FrmDepartamentos();
            frm.ShowDialog();
        }
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmInfoEmple frm = new FrmInfoEmple();
            frm.ShowDialog();
            CargarEmpleados();
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
        private void CargarEmpleados(
    string filtroBusqueda = "",
    string departamento = "",
    string estadoFiltro = "",
    string sucursal = "")
        {
            csConectaSQL oConexion = new csConectaSQL();

            // Escapar comillas simples
            string filtroEsc = filtroBusqueda.Replace("'", "''");
            string deptoEsc = departamento.Replace("'", "''");
            string sucursalEsc = sucursal.Replace("'", "''");

            int estadoBit = estadoFiltro == "Activo" ? 1 : 0;

            string query = @"
        SELECT
            Codigo,
            Nombres + ' ' + Apellidos AS Empleado,
            Cargo,
            Departamento,
            Telefono,
            Correo,
            CASE 
                WHEN Estado = 1 THEN 'Activo'
                ELSE 'Inactivo'
            END AS Estado,
            RutaFoto
        FROM Empleados
        WHERE Nombres LIKE '%" + filtroEsc + @"%'
        AND ('" + deptoEsc + @"' = '' 
             OR Departamento = '" + deptoEsc + @"')
        AND ('" + estadoFiltro + @"' = '' 
             OR Estado = " + estadoBit + @")
        AND ('" + sucursalEsc + @"' = '' 
             OR IdSucursal = (
                 SELECT IdSucursal
                 FROM Sucursales
                 WHERE NombreSucursal = '" + sucursalEsc + @"'
             ))";

            DataTable dt = oConexion.RetornaRegistros(query);

            if (dt == null)
                return;

            // Crear columna temporal para guardar la imagen que verá el DataGridView
            dt.Columns.Add("ImagenEmpleado", typeof(Image));

            foreach (DataRow fila in dt.Rows)
            {
                string ruta = fila["RutaFoto"] == DBNull.Value
                    ? ""
                    : fila["RutaFoto"].ToString();

                if (!string.IsNullOrWhiteSpace(ruta) &&
                    System.IO.File.Exists(ruta))
                {
                    using (Image imgTemporal = Image.FromFile(ruta))
                    {
                        // Hacemos una copia para que el archivo no quede bloqueado
                        fila["ImagenEmpleado"] = new Bitmap(imgTemporal);
                    }
                }
                else
                {
                    fila["ImagenEmpleado"] =
                        Properties.Resources.person_icon_31846;
                }
            }

            dgvEmpleados.AutoGenerateColumns = false;

            dgvEmpleados.Columns["clCodigo"].DataPropertyName = "Codigo";
            dgvEmpleados.Columns["clEmpleado"].DataPropertyName = "Empleado";
            dgvEmpleados.Columns["clCargo"].DataPropertyName = "Cargo";
            dgvEmpleados.Columns["clDepartamento"].DataPropertyName = "Departamento";
            dgvEmpleados.Columns["clTelefono"].DataPropertyName = "Telefono";
            dgvEmpleados.Columns["clCorreo"].DataPropertyName = "Correo";
            dgvEmpleados.Columns["clEstado"].DataPropertyName = "Estado";

            // La foto queda enlazada al DataTable
            dgvEmpleados.Columns["clImagen"].DataPropertyName = "ImagenEmpleado";

            dgvEmpleados.DataSource = dt;
        }
        private void EliminarEmpleado(string codigo)
        {
            using (SqlConnection con = csConexionRemota.ObtenerConexion())
            {
                con.Open();

                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // Buscar el IdEmpleado a partir del código
                    string queryId = @"
                SELECT IdEmpleado
                FROM Empleados
                WHERE Codigo = @codigo";

                    SqlCommand cmdId = new SqlCommand(queryId, con, tran);
                    cmdId.Parameters.AddWithValue("@codigo", codigo);

                    object resultado = cmdId.ExecuteScalar();

                    if (resultado == null)
                    {
                        tran.Rollback();

                        MessageBox.Show(
                            "No se encontró el empleado.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    int idEmpleado = Convert.ToInt32(resultado);


                    // Eliminar usuario relacionado, si tiene uno
                    string queryUsuario = @"
                DELETE FROM Usuario
                WHERE IdEmpleado = @idEmpleado";

                    SqlCommand cmdUsuario = new SqlCommand(queryUsuario, con, tran);
                    cmdUsuario.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmdUsuario.ExecuteNonQuery();


                    // Eliminar empleado
                    string queryEmpleado = @"
                DELETE FROM Empleados
                WHERE IdEmpleado = @idEmpleado";

                    SqlCommand cmdEmpleado = new SqlCommand(queryEmpleado, con, tran);
                    cmdEmpleado.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                    int filasAfectadas = cmdEmpleado.ExecuteNonQuery();


                    if (filasAfectadas > 0)
                    {
                        tran.Commit();

                        MessageBox.Show(
                            "Empleado eliminado correctamente.",
                            "Eliminar empleado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarEmpleados(
                            txtBuscar.Text,
                            cbxDepa.Text,
                            cbxEstado.Text,
                            cbxSucursal.Text
                        );
                    }
                    else
                    {
                        tran.Rollback();

                        MessageBox.Show(
                            "No se pudo eliminar el empleado.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();

                    MessageBox.Show(
                        "No se pudo eliminar el empleado.\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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

        private void btnDepa_Click_1(object sender, EventArgs e)
        {
            FrmDepartamentos frm = new FrmDepartamentos();
            frm.ShowDialog();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // EDITAR
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "clEditar")
            {
                string codigo = dgvEmpleados.Rows[e.RowIndex]
                    .Cells["clCodigo"].Value.ToString();

                FrmInfoEmple frm = new FrmInfoEmple(codigo);
                frm.ShowDialog();

                CargarEmpleados();
            }

            // ELIMINAR
            else if (dgvEmpleados.Columns[e.ColumnIndex].Name == "clEliminar")
            {
                string codigo = dgvEmpleados.Rows[e.RowIndex]
                    .Cells["clCodigo"].Value.ToString();

                string empleado = dgvEmpleados.Rows[e.RowIndex]
                    .Cells["clEmpleado"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar al empleado " + empleado + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    EliminarEmpleado(codigo);
                }
            }

            // VER MÁS
            else if (dgvEmpleados.Columns[e.ColumnIndex].Name == "clVer")
            {
                string codigo = dgvEmpleados.Rows[e.RowIndex]
                    .Cells["clCodigo"].Value.ToString();

                FrmDetalleEmpleado frm = new FrmDetalleEmpleado(codigo);
                frm.ShowDialog();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cbxDepa.SelectedIndex = -1;
            cbxSucursal.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            CargarEmpleados();

        }
    }
}