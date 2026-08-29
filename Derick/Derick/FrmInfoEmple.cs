using System;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            // Conectar el ComboBox a tu base de datos
            cmbSucursal.DataSource = new csEmpleado().ObtenerSucursales();

            // Mostrar los nombres largos (Ej: "Derick Guayaquil")
            cmbSucursal.DisplayMember = "NombreSucursal";

            // Ocultar el ID para SQL (Ej: 4)
            cmbSucursal.ValueMember = "IdSucursal";

            // Dejarlo en blanco al abrir la pantalla
            cmbSucursal.SelectedIndex = -1;

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
            cmbSucursal.SelectedValue = empleadoEditado.IdSucursal;

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

            // Nombres
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los nombres.");
                txtNombre.Focus();
                return false;
            }

            // Apellidos
            if (txtApellidos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los apellidos.");
                txtApellidos.Focus();
                return false;
            }

            // Cédula
            if (txtCedula.Text.Trim().Length != 10)
            {
                MessageBox.Show("La cédula debe tener 10 números.");
                txtCedula.Focus();
                return false;
            }

            // Edad
            int edad = CalcularEdad(dtpFechaNacimiento.Value);

            if (edad < 18 || edad > 65)
            {
                MessageBox.Show("El empleado debe tener entre 18 y 65 años.");
                return false;
            }

            // Género
            if (cmbGenero.Text == "")
            {
                MessageBox.Show("Seleccione el género.");
                return false;
            }

            // Teléfono
            if (txtTelefono.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 números.");
                txtTelefono.Focus();
                return false;
            }

            // Correo
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el correo.");
                txtCorreo.Focus();
                return false;
            }

            if (cmbDominioCorreo.Text == "")
            {
                MessageBox.Show("Seleccione el dominio del correo.");
                return false;
            }

            correoCompleto =
                txtCorreo.Text.Trim() + cmbDominioCorreo.Text;

            // Dirección
            if (txtDirreccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la dirección.");
                txtDirreccion.Focus();
                return false;
            }

            // Cargo
            if (cmbCargo.Text == "")
            {
                MessageBox.Show("Seleccione el cargo.");
                return false;
            }

            // Departamento
            if (cmbDepartamento.Text == "")
            {
                MessageBox.Show("Seleccione el departamento.");
                return false;
            }

            // Fecha ingreso
            if (dtpFechaIngreso.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de ingreso no puede ser futura.");
                return false;
            }

            // Salario
            string textoSalario =
                txtSalario.Text.Trim().Replace(",", ".");

            if (!decimal.TryParse(
                textoSalario,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out salario))
            {
                MessageBox.Show("Ingrese un salario válido.");
                txtSalario.Focus();
                return false;
            }

            if (salario < 100)
            {
                MessageBox.Show("El salario debe ser mínimo 100.");
                txtSalario.Focus();
                return false;
            }

            // Tipo contrato
            if (cmbTipoContrato.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de contrato.");
                return false;
            }

            // Estado
            if (cmbEstado.Text == "")
            {
                MessageBox.Show("Seleccione el estado.");
                return false;
            }

            // Contacto emergencia
            if (txtEmerNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el contacto de emergencia.");
                return false;
            }

            // Teléfono emergencia
            if (txtTeleEmergencia.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono de emergencia debe tener 10 números.");
                return false;
            }

            // Usuario
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario.");
                return false;
            }

            if (txtUsuario.Text.Trim().Length < 4)
            {
                MessageBox.Show("El usuario debe tener mínimo 4 caracteres.");
                return false;
            }

            // Contraseña
            if (txtContrasena.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener mínimo 6 caracteres.");
                return false;
            }

            // Rol
            if (cmbRol.Text == "")
            {
                MessageBox.Show("Seleccione el rol.");
                return false;
            }

            return true;
        }

        private int CalcularEdad(DateTime fecha)
        {
            int edad = DateTime.Today.Year - fecha.Year;
            if (fecha.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad;
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

            csEmpleado emp;

            if (editar == true)
            {
                emp = empleadoEditado;
            }
            else
            {
                emp = new csEmpleado();
            }
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
            emp.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);

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
            bool correcto;

            if (editar == true)
            {
                correcto = emp.Editar();
            }
            else
            {
                correcto = emp.Registrar();
            }
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
            if (editar == true)
            {
                MessageBox.Show("Empleado actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Empleado registrado correctamente.");
            }
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