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
    public partial class FrmNuevoDepa : Form
    {
        private string codigoEditar = null;
        public FrmNuevoDepa()
        {
            InitializeComponent();
        }
        public FrmNuevoDepa(string codigo)
        {
            InitializeComponent();
            codigoEditar = codigo;
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GenerarCodigo()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string query = "SELECT MAX(IdDepartamento) AS UltimoId FROM Departamentos";

            DataTable dt = oConexion.RetornaRegistros(query);

            int siguiente = 1;

            if (dt != null &&
                dt.Rows.Count > 0 &&
                dt.Rows[0]["UltimoId"] != DBNull.Value)
            {
                siguiente = Convert.ToInt32(dt.Rows[0]["UltimoId"]) + 1;
            }

            txtCodigo.Text = "DEP" + siguiente.ToString("D3");
        }
        private void CargarEmpleados()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string query = @"
        SELECT 
            IdEmpleado,
            Nombres + ' ' + Apellidos AS Empleado
        FROM Empleados
        WHERE Estado = 1
        ORDER BY Nombres, Apellidos";

            DataTable dt = oConexion.RetornaRegistros(query);

            cbxEmpleado.DataSource = dt;
            cbxEmpleado.DisplayMember = "Empleado";
            cbxEmpleado.ValueMember = "IdEmpleado";
            cbxEmpleado.SelectedIndex = -1;
        }
        private void CargarEstados()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");

            cbxEstado.SelectedIndex = 0;
        }

        private void FrmNuevoDepa_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarEstados();

            if (codigoEditar == null)
            {
                GenerarCodigo();
            }
            else
            {
                CargarDepartamento(codigoEditar);
            }
        }
        private void CargarDepartamento(string codigo)
        {
            csConectaSQL oConexion = new csConectaSQL();

            string codigoEsc = codigo.Replace("'", "''");

            string query = @"
        SELECT
            Codigo,
            Departamento,
            Descripcion,
            IdEmpleado,
            Estado
        FROM Departamentos
        WHERE Codigo = '" + codigoEsc + "'";

            DataTable dt = oConexion.RetornaRegistros(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                txtCodigo.Text = dr["Codigo"].ToString();
                txtDepartamento.Text = dr["Departamento"].ToString();
                txtDescripcion.Text = dr["Descripcion"].ToString();

                if (dr["IdEmpleado"] != DBNull.Value)
                    cbxEmpleado.SelectedValue = Convert.ToInt32(dr["IdEmpleado"]);

                cbxEstado.Text = Convert.ToBoolean(dr["Estado"])
                    ? "Activo"
                    : "Inactivo";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del departamento.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (cbxEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un estado.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (SqlConnection con = csConexionRemota.ObtenerConexion())
                {
                    con.Open();

                    string query;

                    if (codigoEditar == null)
                    {
                        // NUEVO
                        query = @"
                    INSERT INTO Departamentos
                    (Codigo, Departamento, Descripcion, IdEmpleado, Estado)
                    VALUES
                    (@codigo, @departamento, @descripcion, @idEmpleado, @estado)";
                    }
                    else
                    {
                        // EDITAR
                        query = @"
                    UPDATE Departamentos
                    SET
                        Departamento = @departamento,
                        Descripcion = @descripcion,
                        IdEmpleado = @idEmpleado,
                        Estado = @estado
                    WHERE Codigo = @codigo";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@codigo",
                        txtCodigo.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@departamento",
                        txtDepartamento.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@descripcion",
                        string.IsNullOrWhiteSpace(txtDescripcion.Text)
                            ? (object)DBNull.Value
                            : txtDescripcion.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@idEmpleado",
                        Convert.ToInt32(cbxEmpleado.SelectedValue)
                    );

                    cmd.Parameters.AddWithValue(
                        "@estado",
                        cbxEstado.Text == "Activo" ? 1 : 0
                    );

                    // AQUÍ realmente se ejecuta el INSERT o UPDATE
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        codigoEditar == null
                            ? "Departamento registrado correctamente."
                            : "Departamento actualizado correctamente.",
                        "Departamento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el departamento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
