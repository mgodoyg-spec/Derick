using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmDepartamentos : Form
    {
        private DataTable dtDepartamentos;
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Desea regresar? Se perderán los cambios realizados.",
        "Regresar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FrmEmpleados frm = this.Parent.Parent as FrmEmpleados;

                if (frm != null)
                {
                    frm.MostrarFrm();
                }
            }
        }
        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvDepa.EnableHeadersVisualStyles = false;
            dgvDepa.BorderStyle = BorderStyle.None;
            dgvDepa.BackgroundColor = Color.White;
            dgvDepa.GridColor = Color.FromArgb(235, 235, 235);
            dgvDepa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDepa.ReadOnly = true;
            dgvDepa.MultiSelect = false;
            dgvDepa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepa.AllowUserToAddRows = false;
            dgvDepa.AllowUserToDeleteRows = false;
            dgvDepa.AllowUserToResizeRows = false;
            dgvDepa.AllowUserToResizeColumns = false;
            dgvDepa.RowHeadersVisible = false;
            //encabezado
            dgvDepa.ColumnHeadersHeight = 50;
            dgvDepa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDepa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvDepa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDepa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDepa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //filas
            dgvDepa.RowTemplate.Height = 45;
            dgvDepa.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDepa.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvDepa.DefaultCellStyle.BackColor = Color.White;
            dgvDepa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvDepa.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvDepa.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDepa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDepa.DefaultCellStyle.Padding = new Padding(5);
            //columnas
            dgvDepa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepa.Columns["clCodigo"].FillWeight = 8;
            dgvDepa.Columns["clDepartamento"].FillWeight = 20;
            dgvDepa.Columns["clDescripcion"].FillWeight = 12;
            dgvDepa.Columns["clEmpleados"].FillWeight = 20;
            dgvDepa.Columns["clEstado"].FillWeight = 13;
            dgvDepa.Columns["clEditar"].FillWeight = 8;
            dgvDepa.Columns["clEliminar"].FillWeight = 8;
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvDepa.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvDepa.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //columnas centradas
            string[] columnasCentro = { "clCodigo", "clDepartamento", "clDescripcion", "clEmpleados", "clEstado", "clEditar", "clEliminar" };
            foreach (string columna in columnasCentro)
            {
                dgvDepa.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            CargarDepartamentos();
        }
        private void CargarDepartamentos()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string query = @"
        SELECT
            d.Codigo,
            d.Departamento,
            d.Descripcion,
            ISNULL(e.Nombres + ' ' + e.Apellidos, '') AS Empleado,
            CASE
                WHEN d.Estado = 1 THEN 'Activo'
                ELSE 'Inactivo'
            END AS Estado
        FROM Departamentos d
        LEFT JOIN Empleados e
            ON d.IdEmpleado = e.IdEmpleado
        ORDER BY d.IdDepartamento";

            dtDepartamentos = oConexion.RetornaRegistros(query);

            if (dtDepartamentos != null)
            {
                dgvDepa.AutoGenerateColumns = false;

                dgvDepa.Columns["clCodigo"].DataPropertyName = "Codigo";
                dgvDepa.Columns["clDepartamento"].DataPropertyName = "Departamento";
                dgvDepa.Columns["clDescripcion"].DataPropertyName = "Descripcion";
                dgvDepa.Columns["clEmpleados"].DataPropertyName = "Empleado";
                dgvDepa.Columns["clEstado"].DataPropertyName = "Estado";

                dgvDepa.DataSource = dtDepartamentos;
            }
        }
        private void EliminarDepartamento(string codigo)
        {
            try
            {
                using (SqlConnection con = csConexionRemota.ObtenerConexion())
                {
                    con.Open();

                    string query = @"
                DELETE FROM Departamentos
                WHERE Codigo = @codigo";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show(
                            "Departamento eliminado correctamente.",
                            "Eliminar departamento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarDepartamentos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró el departamento.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el departamento.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoDepa_Click(object sender, EventArgs e)
        {
            FrmNuevoDepa frm = new FrmNuevoDepa();
            frm.ShowDialog();

            CargarDepartamentos();
        }

        private void dgvDepa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // EDITAR
            if (dgvDepa.Columns[e.ColumnIndex].Name == "clEditar")
            {
                string codigo = dgvDepa.Rows[e.RowIndex]
                    .Cells["clCodigo"].Value.ToString();

                FrmNuevoDepa frm = new FrmNuevoDepa(codigo);
                frm.ShowDialog();

                CargarDepartamentos();
            }

            // ELIMINAR
            else if (dgvDepa.Columns[e.ColumnIndex].Name == "clEliminar")
            {
                string codigo = dgvDepa.Rows[e.RowIndex]
                    .Cells["clCodigo"].Value.ToString();

                string departamento = dgvDepa.Rows[e.RowIndex]
                    .Cells["clDepartamento"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el departamento " + departamento + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    EliminarDepartamento(codigo);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dtDepartamentos == null)
                return;

            string buscar = txtBuscar.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(buscar))
            {
                dtDepartamentos.DefaultView.RowFilter = "";
                return;
            }

            dtDepartamentos.DefaultView.RowFilter =
                $"Codigo LIKE '%{buscar}%' OR " +
                $"Departamento LIKE '%{buscar}%' OR " +
                $"Descripcion LIKE '%{buscar}%' OR " +
                $"Empleado LIKE '%{buscar}%' OR " +
                $"Estado LIKE '%{buscar}%'";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            if (dtDepartamentos != null)
            {
                dtDepartamentos.DefaultView.RowFilter = "";
            }
        }
    }

}

