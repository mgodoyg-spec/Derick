using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmDetalleEmpleado : Form
    {
        private string codigoEmpleado;
        public FrmDetalleEmpleado(string codigo)
        {
            InitializeComponent();
            codigoEmpleado = codigo;
        }

        private void FrmDetalleEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
        }
        private void CargarEmpleado()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string codigoEsc = codigoEmpleado.Replace("'", "''");

            string query = @"SELECT Nombres, Apellidos, Cedula, FechaNacimiento,
                            Genero, Telefono, Correo, Direccion, Cargo,
                            Departamento, FechaIngreso, Salario,
                            TipoContrato, Estado, ContactoEmergencia,
                            TelefonoEmergencia
                     FROM Empleados
                     WHERE Codigo = '" + codigoEsc + "'";

            DataTable dt = oConexion.RetornaRegistros(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                lblCodigo.Text = codigoEmpleado;
                lblNombres.Text = dr["Nombres"].ToString();
                lblApellidos.Text = dr["Apellidos"].ToString();
                lblCedula.Text = dr["Cedula"].ToString();

                if (dr["FechaNacimiento"] != DBNull.Value)
                    lblFechaNacimiento.Text =
                        Convert.ToDateTime(dr["FechaNacimiento"]).ToString("dd/MM/yyyy");

                lblGenero.Text = dr["Genero"].ToString();
                lblTelefono.Text = dr["Telefono"].ToString();
                lblCorreo.Text = dr["Correo"].ToString();
                lblDireccion.Text = dr["Direccion"].ToString();
                lblCargo.Text = dr["Cargo"].ToString();
                lblDepartamento.Text = dr["Departamento"].ToString();

                if (dr["FechaIngreso"] != DBNull.Value)
                    lblFechaIngreso.Text =
                        Convert.ToDateTime(dr["FechaIngreso"]).ToString("dd/MM/yyyy");

                lblSalario.Text = dr["Salario"].ToString();
                lblTipoContrato.Text = dr["TipoContrato"].ToString();

                if (dr["Estado"] != DBNull.Value)
                {
                    lblEstado.Text = Convert.ToBoolean(dr["Estado"])
                        ? "Activo"
                        : "Inactivo";
                }

                lblEmergencia.Text =
                    dr["ContactoEmergencia"].ToString();

                lblTelEmergencia.Text =
                    dr["TelefonoEmergencia"].ToString();
            }
            else
            {
                MessageBox.Show(
                    "No se encontró la información del empleado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
