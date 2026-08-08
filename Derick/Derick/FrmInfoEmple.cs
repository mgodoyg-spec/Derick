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
        public FrmInfoEmple()
        {
            InitializeComponent();
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
                pbxImagenEmple.Image = Image.FromFile(ofd.FileName);
                pbxImagenEmple.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r2 = MessageBox.Show("¿Esta seguro de eliminar la imagen?", "Eliminar imagen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r2 == DialogResult.Yes)
            {
                pbxImagenEmple.Image.Dispose();
                pbxImagenEmple.Image = null;
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
            GenerarCodigo();
        }
        private void GenerarCodigo()
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT MAX(Codigo) FROM Empleados";
                SqlCommand cmd = new SqlCommand(query, con);
                object resultado = cmd.ExecuteScalar();

                int siguiente = 1;
                if (resultado != DBNull.Value && resultado != null)
                {
                    string ultimo = resultado.ToString();
                    string soloNumeros = new string(ultimo.Where(char.IsDigit).ToArray());
                    if (int.TryParse(soloNumeros, out int numero))
                    {
                        siguiente = numero + 1;
                    }
                }

                txtCodigo.Text = "SC" + siguiente.ToString("D3");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
    string.IsNullOrWhiteSpace(txtCedula.Text) ||
    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
    string.IsNullOrWhiteSpace(txtContrasena.Text) ||
    string.IsNullOrWhiteSpace(cmbRol.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }

            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // 1. Buscar el IdRol correspondiente al texto seleccionado
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

                    int idRol = Convert.ToInt32(idRolObj);


                    // 2. Insertar el empleado
                    string queryEmpleado = @"INSERT INTO Empleados
        (Codigo, Nombres, Apellidos, Cedula, FechaNacimiento, Genero,
         Telefono, Correo, Direccion, Cargo, Departamento, FechaIngreso,
         Salario, TipoContrato, Estado, ContactoEmergencia, TelefonoEmergencia)
        VALUES
        (@codigo, @nombres, @apellidos, @cedula, @fechaNac, @genero,
         @telefono, @correo, @direccion, @cargo, @departamento, @fechaIngreso,
         @salario, @tipoContrato, @estado, @contactoEmerg, @telEmerg)";


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

                    cmdEmp.ExecuteNonQuery();


                    // 3. Obtener el IdEmpleado recién creado
                    string queryId = "SELECT IdEmpleado FROM Empleados WHERE Codigo = @codigo";

                    SqlCommand cmdId = new SqlCommand(queryId, con, tran);
                    cmdId.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());

                    int idEmpleado = Convert.ToInt32(cmdId.ExecuteScalar());


                    // 4. Insertar el usuario
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


                    // 5. Confirmar todo
                    tran.Commit();

                    MessageBox.Show("Empleado y usuario registrados con éxito.");

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
