using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmInfoEmple : Form
    {
        private bool editar = false;
        private csEmpleado empleadoEditado = null;
        private byte[] fotoBytes = null;

        public FrmInfoEmple()
        {
            InitializeComponent();
            ConfigurarValidaciones();
        }

        public FrmInfoEmple(string codigo) : this()
        {
            empleadoEditado = new csEmpleado().BuscarPorCodigo(codigo);
            editar = empleadoEditado != null;
        }

        private void FrmInfoEmple_Load(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = true;

            // Primero ponemos valores válidos y luego limitamos los calendarios.
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-18);
            dtpFechaNacimiento.MinDate = DateTime.Today.AddYears(-65);
            dtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);

            dtpFechaIngreso.Value = DateTime.Today;
            dtpFechaIngreso.MaxDate = DateTime.Today;

            if (cmbDominioCorreo.Items.Count == 0)
            {
                cmbDominioCorreo.Items.Add("@gmail.com");
                cmbDominioCorreo.Items.Add("@hotmail.com");
                cmbDominioCorreo.Items.Add("@outlook.com");
            }

            if (!editar)
            {
                txtCodigo.Text = new csEmpleado().GenerarCodigo();
                cmbDominioCorreo.SelectedIndex = -1;
                ActualizarFechaIngreso();
            }
            else
            {
                CargarDatosEditar();
            }
        }

        private void CargarDatosEditar()
        {
            if (empleadoEditado == null)
            {
                MessageBox.Show("No se encontró el empleado.");
                Close();
                return;
            }

            txtCodigo.Text = empleadoEditado.Codigo;
            txtNombre.Text = empleadoEditado.Nombres;
            txtApellidos.Text = empleadoEditado.Apellidos;
            txtCedula.Text = empleadoEditado.Cedula;

            // Si el empleado antiguo tiene una fecha fuera del rango permitido,
            // no dejamos que el formulario se caiga.
            if (empleadoEditado.FechaNacimiento >= dtpFechaNacimiento.MinDate &&
                empleadoEditado.FechaNacimiento <= dtpFechaNacimiento.MaxDate)
            {
                dtpFechaNacimiento.Value = empleadoEditado.FechaNacimiento;
            }
            else
            {
                dtpFechaNacimiento.Value = dtpFechaNacimiento.MaxDate;

                MessageBox.Show(
                    "La fecha de nacimiento guardada está fuera del rango permitido (18 a 65 años).\n" +
                    "Seleccione la fecha correcta antes de guardar.",
                    "Fecha de nacimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            cmbGenero.Text = empleadoEditado.Genero;
            txtTelefono.Text = empleadoEditado.Telefono;
            CargarCorreo(empleadoEditado.Correo);
            txtDirreccion.Text = empleadoEditado.Direccion;
            cmbCargo.Text = empleadoEditado.Cargo;
            cmbDepartamento.Text = empleadoEditado.Departamento;

            ActualizarFechaIngreso();
            if (empleadoEditado.FechaIngreso >= dtpFechaIngreso.MinDate &&
                empleadoEditado.FechaIngreso <= dtpFechaIngreso.MaxDate)
                dtpFechaIngreso.Value = empleadoEditado.FechaIngreso;

            txtSalario.Text = empleadoEditado.Salario.ToString("0.00");
            cmbTipoContrato.Text = empleadoEditado.TipoContrato;
            cmbEstado.Text = empleadoEditado.Estado ? "Activo" : "Inactivo";
            txtEmerNombre.Text = empleadoEditado.ContactoEmergencia;
            txtTeleEmergencia.Text = empleadoEditado.TelefonoEmergencia;

            // Recuperar acceso al editar.
            txtUsuario.Text = empleadoEditado.Usuario;
            txtContrasena.Text = empleadoEditado.Contrasena;
            cmbRol.Text = empleadoEditado.Rol;

            fotoBytes = empleadoEditado.Foto;
            MostrarFoto();
        }

        private void CargarCorreo(string correo)
        {
            txtCorreo.Clear();
            cmbDominioCorreo.SelectedIndex = -1;

            if (string.IsNullOrWhiteSpace(correo)) return;

            int pos = correo.IndexOf('@');
            if (pos <= 0)
            {
                txtCorreo.Text = correo;
                return;
            }

            txtCorreo.Text = correo.Substring(0, pos);
            string dominio = correo.Substring(pos);
            int indice = cmbDominioCorreo.FindStringExact(dominio);
            if (indice >= 0) cmbDominioCorreo.SelectedIndex = indice;
        }

        private void ConfigurarValidaciones()
        {
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtApellidos.KeyPress += SoloLetras_KeyPress;
            txtEmerNombre.KeyPress += SoloLetras_KeyPress;
            txtCedula.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
            txtTeleEmergencia.KeyPress += SoloNumeros_KeyPress;
            txtSalario.KeyPress += SoloDecimal_KeyPress;
            txtCorreo.KeyPress += Correo_KeyPress;
            txtDirreccion.KeyPress += Direccion_KeyPress;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;

            TextBox txt = (TextBox)sender;
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txt.Text.Contains(".") && !txt.Text.Contains(",")) return;

            e.Handled = true;
        }

        private void Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) ||
                e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-') return;

            e.Handled = true;
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '#' || e.KeyChar == '-' ||
                e.KeyChar == '/' || e.KeyChar == '°') return;

            e.Handled = true;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFechaIngreso();
        }

        private void ActualizarFechaIngreso()
        {
            dtpFechaIngreso.MinDate = new DateTime(2000, 1, 1);
            dtpFechaIngreso.MaxDate = DateTime.Today;

            if (dtpFechaIngreso.Value < dtpFechaIngreso.MinDate ||
                dtpFechaIngreso.Value > dtpFechaIngreso.MaxDate)
            {
                dtpFechaIngreso.Value = DateTime.Today;
            }
        }

        private bool ValidarFormulario(out decimal salario, out string correoCompleto)
        {
            salario = 0;
            correoCompleto = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !Regex.IsMatch(txtNombre.Text.Trim(), @"^[\p{L}\s]+$"))
                return Error("Ingrese nombres válidos, solo con letras y espacios.", txtNombre);

            if (string.IsNullOrWhiteSpace(txtApellidos.Text) || !Regex.IsMatch(txtApellidos.Text.Trim(), @"^[\p{L}\s]+$"))
                return Error("Ingrese apellidos válidos, solo con letras y espacios.", txtApellidos);

            string cedula = txtCedula.Text.Trim();
            if (!Regex.IsMatch(cedula, @"^\d{10}$"))
                return Error("La cédula debe contener exactamente 10 números.", txtCedula);
            if (!CedulaValida(cedula))
                return Error("La cédula ingresada no es válida.", txtCedula);

            int edad = CalcularEdad(dtpFechaNacimiento.Value);
            if (edad < 18 || edad > 65)
                return Error("El empleado debe tener entre 18 y 65 años.", dtpFechaNacimiento);

            if (string.IsNullOrWhiteSpace(cmbGenero.Text))
                return Error("Seleccione el género.", cmbGenero);

            if (!Regex.IsMatch(txtTelefono.Text.Trim(), @"^\d{10}$"))
                return Error("El teléfono debe contener exactamente 10 números.", txtTelefono);

            string correo = txtCorreo.Text.Trim();
            if (correo.Length < 3 || !Regex.IsMatch(correo, @"^[A-Za-z0-9][A-Za-z0-9._-]*[A-Za-z0-9]$") || !correo.Any(char.IsLetter))
                return Error("Ingrese correctamente la parte inicial del correo.", txtCorreo);
            if (cmbDominioCorreo.SelectedIndex == -1)
                return Error("Seleccione el dominio del correo.", cmbDominioCorreo);
            correoCompleto = correo + cmbDominioCorreo.Text;

            string direccion = txtDirreccion.Text.Trim();
            if (direccion.Length < 5 || !direccion.Any(char.IsLetter))
                return Error("Ingrese una dirección válida.", txtDirreccion);

            if (string.IsNullOrWhiteSpace(cmbCargo.Text))
                return Error("Seleccione el cargo.", cmbCargo);
            if (string.IsNullOrWhiteSpace(cmbDepartamento.Text))
                return Error("Seleccione el departamento.", cmbDepartamento);
            if (dtpFechaIngreso.Value.Date > DateTime.Today)
            {
                return Error(
                    "La fecha de ingreso no puede ser futura.",
                    dtpFechaIngreso
                );
            }

            string salarioTexto = txtSalario.Text.Trim();
            if (!Regex.IsMatch(salarioTexto, @"^\d+([.,]\d{1,2})?$"))
                return Error("El salario acepta máximo 2 decimales.", txtSalario);
            if (!ObtenerSalario(out salario) || salario < 100)
                return Error("El salario debe ser mínimo 100.00.", txtSalario);

            if (string.IsNullOrWhiteSpace(cmbTipoContrato.Text))
                return Error("Seleccione el tipo de contrato.", cmbTipoContrato);
            if (string.IsNullOrWhiteSpace(cmbEstado.Text))
                return Error("Seleccione el estado.", cmbEstado);

            if (string.IsNullOrWhiteSpace(txtEmerNombre.Text) || !Regex.IsMatch(txtEmerNombre.Text.Trim(), @"^[\p{L}\s]+$"))
                return Error("Ingrese correctamente el nombre de emergencia.", txtEmerNombre);

            if (!Regex.IsMatch(txtTeleEmergencia.Text.Trim(), @"^\d{10}$"))
                return Error("El teléfono de emergencia debe tener 10 números.", txtTeleEmergencia);

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                return Error("Ingrese el usuario.", txtUsuario);
            if (!Regex.IsMatch(txtUsuario.Text.Trim(), @"^[A-Za-z0-9._-]{4,20}$"))
                return Error("El usuario debe tener entre 4 y 20 caracteres.", txtUsuario);

            if (string.IsNullOrWhiteSpace(txtContrasena.Text) || txtContrasena.Text.Length < 6 ||
                !txtContrasena.Text.Any(char.IsLetter) || !txtContrasena.Text.Any(char.IsDigit))
                return Error("La contraseña debe tener mínimo 6 caracteres, una letra y un número.", txtContrasena);

            if (string.IsNullOrWhiteSpace(cmbRol.Text))
                return Error("Seleccione el rol.", cmbRol);

            return true;
        }

        private bool CedulaValida(string cedula)
        {
            if ((cedula[2] - '0') >= 6) return false;

            int suma = 0;
            for (int i = 0; i < 9; i++)
            {
                int numero = cedula[i] - '0';
                if (i % 2 == 0)
                {
                    numero *= 2;
                    if (numero > 9) numero -= 9;
                }
                suma += numero;
            }

            int verificador = (10 - (suma % 10)) % 10;
            return verificador == (cedula[9] - '0');
        }

        private int CalcularEdad(DateTime fecha)
        {
            int edad = DateTime.Today.Year - fecha.Year;
            if (fecha.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad;
        }

        private bool ObtenerSalario(out decimal salario)
        {
            string texto = txtSalario.Text.Trim().Replace(",", ".");
            return decimal.TryParse(texto, NumberStyles.Number,
                CultureInfo.InvariantCulture, out salario);
        }

        private bool Error(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                FileInfo archivo = new FileInfo(ofd.FileName);
                if (archivo.Length > 5 * 1024 * 1024)
                {
                    MessageBox.Show("La imagen no puede superar los 5 MB.");
                    return;
                }

                fotoBytes = File.ReadAllBytes(ofd.FileName);
                MostrarFoto();
            }
        }

        private void MostrarFoto()
        {
            if (fotoBytes == null || fotoBytes.Length == 0)
            {
                pbxImagenEmple.Image = null;
                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
                return;
            }

            using (MemoryStream ms = new MemoryStream(fotoBytes))
            using (Image temporal = Image.FromStream(ms))
            {
                if (pbxImagenEmple.Image != null) pbxImagenEmple.Image.Dispose();
                pbxImagenEmple.Image = new Bitmap(temporal);
            }

            pbxImagenEmple.SizeMode = PictureBoxSizeMode.Zoom;
            pbxAgregarImagen.Visible = false;
            lblSeleccionarImag.Visible = false;
            pbxImagenEmple.BringToFront();
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar la imagen?", "Eliminar imagen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            fotoBytes = null;
            if (pbxImagenEmple.Image != null)
            {
                pbxImagenEmple.Image.Dispose();
                pbxImagenEmple.Image = null;
            }
            pbxAgregarImagen.Visible = true;
            lblSeleccionarImag.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario(out decimal salario, out string correoCompleto)) return;

            csEmpleado emp = empleadoEditado ?? new csEmpleado();
            emp.Codigo = txtCodigo.Text.Trim();
            emp.Nombres = txtNombre.Text.Trim();
            emp.Apellidos = txtApellidos.Text.Trim();
            emp.Cedula = txtCedula.Text.Trim();
            emp.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            emp.Genero = cmbGenero.Text.Trim();
            emp.Telefono = txtTelefono.Text.Trim();
            emp.Correo = correoCompleto;
            emp.Direccion = txtDirreccion.Text.Trim();
            emp.Cargo = cmbCargo.Text.Trim();
            emp.Departamento = cmbDepartamento.Text.Trim();
            emp.FechaIngreso = dtpFechaIngreso.Value.Date;
            emp.Salario = salario;
            emp.TipoContrato = cmbTipoContrato.Text.Trim();
            emp.Estado = cmbEstado.Text == "Activo";
            emp.ContactoEmergencia = txtEmerNombre.Text.Trim();
            emp.TelefonoEmergencia = txtTeleEmergencia.Text.Trim();
            emp.Foto = fotoBytes;
            emp.Usuario = txtUsuario.Text.Trim();
            emp.Contrasena = txtContrasena.Text;
            emp.Rol = cmbRol.Text.Trim();

            if (emp.CedulaExiste())
            {
                MessageBox.Show("Ya existe un empleado con esa cédula.");
                return;
            }

            if (emp.UsuarioExiste())
            {
                MessageBox.Show("Ese usuario ya está siendo utilizado.");
                return;
            }

            bool correcto = editar ? emp.Editar() : emp.Registrar();
            if (!correcto)
            {
                MessageBox.Show("No se pudo guardar el empleado.");
                return;
            }

            if (!emp.GuardarAcceso())
            {
                MessageBox.Show("El empleado se guardó, pero no se pudo guardar el acceso.");
                return;
            }

            MessageBox.Show(editar ? "Empleado actualizado correctamente." : "Empleado registrado correctamente.");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar? Los datos no se guardarán.", "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}