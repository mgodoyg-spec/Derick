using System;
using System.Drawing;
using System.IO;
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
            csEmpleado emp = new csEmpleado().BuscarPorCodigo(codigoEmpleado);

            if (emp == null)
            {
                MessageBox.Show("No se encontró la información del empleado.");
                Close();
                return;
            }

            lblCodigo.Text = emp.Codigo;
            lblNombres.Text = emp.Nombres;
            lblApellidos.Text = emp.Apellidos;
            lblCedula.Text = emp.Cedula;
            lblFechaNacimiento.Text = emp.FechaNacimiento.ToString("dd/MM/yyyy");
            lblGenero.Text = emp.Genero;
            lblTelefono.Text = emp.Telefono;
            lblCorreo.Text = emp.Correo;
            lblDireccion.Text = emp.Direccion;
            lblCargo.Text = emp.Cargo;
            lblDepartamento.Text = emp.Departamento;
            lblFechaIngreso.Text = emp.FechaIngreso.ToString("dd/MM/yyyy");
            lblSalario.Text = emp.Salario.ToString("0.00");
            lblTipoContrato.Text = emp.TipoContrato;
            lblEstado.Text = emp.Estado ? "Activo" : "Inactivo";
            lblEmergencia.Text = emp.ContactoEmergencia;
            lblTelEmergencia.Text = emp.TelefonoEmergencia;

            if (emp.Foto != null && emp.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(emp.Foto))
                using (Image temporal = Image.FromStream(ms))
                    pbxFotoEmpleado.Image = new Bitmap(temporal);
            }
            else
            {
                pbxFotoEmpleado.Image = Properties.Resources.person_icon_31846;
            }

            pbxFotoEmpleado.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}