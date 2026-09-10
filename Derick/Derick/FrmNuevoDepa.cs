using Microsoft.Data.SqlClient;
using System;
using System.Data;
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

            string query =
                "select max(IdDepartamento) as UltimoId from Departamentos";

            DataTable dt = oConexion.RetornaRegistros(query);

            int siguiente = 1;

            if (dt != null &&
                dt.Rows.Count > 0 &&
                dt.Rows[0]["UltimoId"] != DBNull.Value)
            {
                siguiente =
                    Convert.ToInt32(dt.Rows[0]["UltimoId"]) + 1;
            }

            txtCodigo.Text =
                "DEP" + siguiente.ToString("D3");
        }

        private void CargarEmpleados()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string query = @"
                select
                    IdEmpleado,
                    Nombres + ' ' + Apellidos as Empleado
                from Empleados
                where Estado = 1
                order by Nombres, Apellidos";

            DataTable dt =
                oConexion.RetornaRegistros(query);

            if (dt != null)
            {
                cbxEmpleado.DataSource = dt;
                cbxEmpleado.DisplayMember = "Empleado";
                cbxEmpleado.ValueMember = "IdEmpleado";
                cbxEmpleado.SelectedIndex = -1;
            }
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

            string codigoEsc =
                codigo.Replace("'", "''");

            string query = @"
                select
                    Codigo,
                    Departamento,
                    Descripcion,
                    IdEmpleado,
                    Estado
                from Departamentos
                where Codigo = '" + codigoEsc + "'";

            DataTable dt =
                oConexion.RetornaRegistros(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                txtCodigo.Text =
                    dr["Codigo"].ToString();

                txtDepartamento.Text =
                    dr["Departamento"].ToString();

                txtDescripcion.Text =
                    dr["Descripcion"].ToString();

                if (dr["IdEmpleado"] != DBNull.Value)
                {
                    cbxEmpleado.SelectedValue =
                        Convert.ToInt32(dr["IdEmpleado"]);
                }

                cbxEstado.Text =
                    Convert.ToBoolean(dr["Estado"])
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

                txtDepartamento.Focus();
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

                cbxEmpleado.Focus();
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

                cbxEstado.Focus();
                return;
            }

            csConectaSQL oConexion =
                new csConectaSQL();

            string query;

            if (codigoEditar == null)
            {
                query = @"
                    insert into Departamentos
                    (
                        Codigo,
                        Departamento,
                        Descripcion,
                        IdEmpleado,
                        Estado
                    )
                    values
                    (
                        @codigo,
                        @departamento,
                        @descripcion,
                        @idEmpleado,
                        @estado
                    )";
            }
            else
            {
                query = @"
                    update Departamentos
                    set
                        Departamento = @departamento,
                        Descripcion = @descripcion,
                        IdEmpleado = @idEmpleado,
                        Estado = @estado
                    where Codigo = @codigo";
            }

            SqlParameter[] parametros =
            {
                new SqlParameter(
                    "@codigo",
                    txtCodigo.Text.Trim()
                ),

                new SqlParameter(
                    "@departamento",
                    txtDepartamento.Text.Trim()
                ),

                new SqlParameter(
                    "@descripcion",
                    string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? DBNull.Value
                    : txtDescripcion.Text.Trim()
                ),

                new SqlParameter(
                    "@idEmpleado",
                    Convert.ToInt32(cbxEmpleado.SelectedValue)
                ),

                new SqlParameter(
                    "@estado",
                    cbxEstado.Text == "Activo" ? 1 : 0
                )
            };

            bool guardado =
                oConexion.ejecutarComando(
                    query,
                    parametros
                );

            if (guardado)
            {
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
            else
            {
                MessageBox.Show(
                    "No se pudo guardar el departamento.",
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