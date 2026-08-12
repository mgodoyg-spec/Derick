using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class FrmInfoEmple : Form
    {
        private string codigoEditar = null;
        private string rutaFoto = "";

        public FrmInfoEmple()
        {
            InitializeComponent();
        }

        public FrmInfoEmple(string codigo)
        {
            InitializeComponent();
            codigoEditar = codigo;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = ofd.FileName;
                pbxImagenEmple.Image = Image.FromFile(rutaFoto);
                pbxImagenEmple.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r2 = MessageBox.Show(
                "¿Está seguro de eliminar la imagen?",
                "Eliminar imagen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r2 == DialogResult.Yes)
            {
                if (pbxImagenEmple.Image != null)
                {
                    pbxImagenEmple.Image.Dispose();
                    pbxImagenEmple.Image = null;
                }

                rutaFoto = "";

                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInfoEmple_Load(object sender, EventArgs e)
        {
            if (codigoEditar == null)
            {
                GenerarCodigo();
            }
            else
            {
                CargarEmpleado(codigoEditar);
            }
        }
        private void GenerarCodigo()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string query = "SELECT MAX(Codigo) AS UltimoCodigo FROM Empleados";

            DataTable dt = oConexion.RetornaRegistros(query);

            int siguiente = 1;

            if (dt.Rows.Count > 0 &&
                dt.Rows[0]["UltimoCodigo"] != DBNull.Value &&
                dt.Rows[0]["UltimoCodigo"] != null)
            {
                string ultimo = dt.Rows[0]["UltimoCodigo"].ToString();

                string soloNumeros = new string(
                    ultimo.Where(char.IsDigit).ToArray()
                );

                if (int.TryParse(soloNumeros, out int numero))
                {
                    siguiente = numero + 1;
                }
            }

            txtCodigo.Text = "SC" + siguiente.ToString("D3");
        }
        private void CargarEmpleado(string codigo)
        {
            csConectaSQL oConexion = new csConectaSQL();

            string codigoEsc = codigo.Replace("'", "''");
            string query = @"SELECT Nombres, Apellidos, Cedula, FechaNacimiento,
                        Genero, Telefono, Correo, Direccion, Cargo,
                        Departamento, FechaIngreso, Salario,
                        TipoContrato, Estado, ContactoEmergencia,
                        TelefonoEmergencia, RutaFoto
                 FROM Empleados
                 WHERE Codigo = '" + codigoEsc + "'";

            DataTable dt = oConexion.RetornaRegistros(query);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                rutaFoto = dr["RutaFoto"].ToString();
                if (!string.IsNullOrWhiteSpace(rutaFoto) && System.IO.File.Exists(rutaFoto))
                {
                    pbxImagenEmple.Image = Image.FromFile(rutaFoto);
                    pbxImagenEmple.SizeMode = PictureBoxSizeMode.Zoom;
                }

                txtCodigo.Text = codigo;
                txtNombre.Text = dr["Nombres"].ToString();
                txtApellidos.Text = dr["Apellidos"].ToString();
                txtCedula.Text = dr["Cedula"].ToString();

                if (dr["FechaNacimiento"] != DBNull.Value)
                    dtpFechaNacimiento.Value = Convert.ToDateTime(dr["FechaNacimiento"]);

                cmbGenero.Text = dr["Genero"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtCorreo.Text = dr["Correo"].ToString();
                txtDirreccion.Text = dr["Direccion"].ToString();
                cmbCargo.Text = dr["Cargo"].ToString();
                cmbDepartamento.Text = dr["Departamento"].ToString();

                if (dr["FechaIngreso"] != DBNull.Value)
                    dtpFechaIngreso.Value = Convert.ToDateTime(dr["FechaIngreso"]);

                txtSalario.Text = dr["Salario"].ToString();
                cmbTipoContrato.Text = dr["TipoContrato"].ToString();

                cmbEstado.Text = Convert.ToBoolean(dr["Estado"])
                    ? "Activo"
                    : "Inactivo";

                txtEmerNombre.Text = dr["ContactoEmergencia"].ToString();
                txtTeleEmergencia.Text = dr["TelefonoEmergencia"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios (ya NO incluye usuario/contraseña/rol)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }

            // Determinar si el empleado tendrá acceso al sistema
            bool tieneUsuario = !string.IsNullOrWhiteSpace(txtUsuario.Text);
            bool tieneContrasena = !string.IsNullOrWhiteSpace(txtContrasena.Text);
            bool tieneRol = !string.IsNullOrWhiteSpace(cmbRol.Text);

            // Si llenó solo alguno de los tres, se le pide completar todos
            if ((tieneUsuario || tieneContrasena || tieneRol) &&
                !(tieneUsuario && tieneContrasena && tieneRol))
            {
                MessageBox.Show("Para crear acceso al sistema debes completar Usuario, Contraseña y Rol. " +
                                 "Si el empleado no tendrá acceso, deja los tres campos vacíos.");
                return;
            }

            bool crearAccesoSistema = tieneUsuario && tieneContrasena && tieneRol;

            using (SqlConnection con = csConexionRemota.ObtenerConexion())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    int idRol = 0;

                    // 1. Solo buscar el rol si se va a crear acceso al sistema
                    if (crearAccesoSistema)
                    {
                        string queryRol = "SELECT IdRol FROM Rol WHERE NombreRol = @nombreRol";

                        SqlCommand cmdRol = new SqlCommand(queryRol, con, tran);
                        cmdRol.Parameters.AddWithValue("@nombreRol", cmbRol.Text.Trim());

                        object idRolObj = cmdRol.ExecuteScalar();

                        if (idRolObj == null)
                        {
                            MessageBox.Show("El rol '" + cmbRol.Text +
                                            "' no existe. Selecciona un rol válido.");
                            tran.Rollback();
                            return;
                        }

                        idRol = Convert.ToInt32(idRolObj);
                    }

                    // 2. Insertar el empleado (siempre)
                    string queryEmpleado;

                    if (codigoEditar == null)
                    {
                        queryEmpleado = @"INSERT INTO Empleados
(Codigo, Nombres, Apellidos, Cedula, FechaNacimiento, Genero,
Telefono, Correo, Direccion, Cargo, Departamento, FechaIngreso,
Salario, TipoContrato, Estado, ContactoEmergencia, TelefonoEmergencia, RutaFoto)
VALUES
(@codigo, @nombres, @apellidos, @cedula, @fechaNac, @genero,
@telefono, @correo, @direccion, @cargo, @departamento, @fechaIngreso,
@salario, @tipoContrato, @estado, @contactoEmerg, @telEmerg, @rutaFoto)";
                    }
                    else
                    {
                        queryEmpleado = @"UPDATE Empleados SET
    Nombres = @nombres,
    Apellidos = @apellidos,
    Cedula = @cedula,
    FechaNacimiento = @fechaNac,
    Genero = @genero,
    Telefono = @telefono,
    Correo = @correo,
    Direccion = @direccion,
    Cargo = @cargo,
    Departamento = @departamento,
    FechaIngreso = @fechaIngreso,
    Salario = @salario,
    TipoContrato = @tipoContrato,
    Estado = @estado,
    ContactoEmergencia = @contactoEmerg,
TelefonoEmergencia = @telEmerg,
RutaFoto = @rutaFoto
WHERE Codigo = @codigo";
                    }

                    SqlCommand cmdEmp = new SqlCommand(queryEmpleado, con, tran);

                    cmdEmp.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@nombres", txtNombre.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@apellidos", txtApellidos.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@cedula", txtCedula.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@fechaNac", dtpFechaNacimiento.Value);
                    cmdEmp.Parameters.AddWithValue("@genero", cmbGenero.Text);
                    cmdEmp.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@direccion", txtDirreccion.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@cargo", cmbCargo.Text);
                    cmdEmp.Parameters.AddWithValue("@departamento", cmbDepartamento.Text);
                    cmdEmp.Parameters.AddWithValue("@fechaIngreso", dtpFechaIngreso.Value);

                    cmdEmp.Parameters.AddWithValue(
                        "@salario",
                        string.IsNullOrWhiteSpace(txtSalario.Text)
                            ? 0
                            : decimal.Parse(txtSalario.Text)
                    );

                    cmdEmp.Parameters.AddWithValue("@tipoContrato", cmbTipoContrato.Text);

                    cmdEmp.Parameters.AddWithValue(
                        "@estado",
                        cmbEstado.Text == "Activo" ? 1 : 0
                    );

                    cmdEmp.Parameters.AddWithValue(
                        "@contactoEmerg",
                        txtEmerNombre.Text.Trim()
                    );

                    cmdEmp.Parameters.AddWithValue(
                        "@telEmerg",
                        txtTeleEmergencia.Text.Trim()
                    );
                    cmdEmp.Parameters.AddWithValue(
    "@rutaFoto",
    string.IsNullOrWhiteSpace(rutaFoto)
        ? (object)DBNull.Value
        : rutaFoto
);

                    cmdEmp.ExecuteNonQuery();

                    // 3. Solo crear el usuario si el empleado tendrá acceso al sistema
                    if (crearAccesoSistema)
                    {
                        string queryId = "SELECT IdEmpleado FROM Empleados WHERE Codigo = @codigo";

                        SqlCommand cmdId = new SqlCommand(queryId, con, tran);
                        cmdId.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());

                        int idEmpleado = Convert.ToInt32(cmdId.ExecuteScalar());

                        string queryUsuario = @"INSERT INTO Usuario
                        (IdEmpleado, IdRol, Usuario, Contrasena, Estado)
                        VALUES
                        (@idEmp, @idRol, @usuario, @clave, @estado)";

                        SqlCommand cmdUser = new SqlCommand(queryUsuario, con, tran);

                        cmdUser.Parameters.AddWithValue("@idEmp", idEmpleado);
                        cmdUser.Parameters.AddWithValue("@idRol", idRol);
                        cmdUser.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@clave", txtContrasena.Text);
                        cmdUser.Parameters.AddWithValue("@estado", 1);

                        cmdUser.ExecuteNonQuery();
                    }

                    // 4. Confirmar todo
                    tran.Commit();

                    MessageBox.Show(crearAccesoSistema
                        ? "Empleado y usuario registrados con éxito."
                        : "Empleado registrado con éxito (sin acceso al sistema).");

                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }
    }
}
