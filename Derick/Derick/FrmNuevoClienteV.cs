using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmNuevoClienteV : Form
    {
        private csCliente cliente = new csCliente();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public FrmNuevoClienteV()
        {
            InitializeComponent();
        }

        private void FrmNuevoClienteV_Load(object sender, EventArgs e)
        {
            SendMessage(txtNC.Handle, EM_SETCUEBANNER, 0, "Ingrese sus nombres");
            SendMessage(txtApe.Handle, EM_SETCUEBANNER, 0, "Ingrese sus apellidos");
            SendMessage(txtCI.Handle, EM_SETCUEBANNER, 0, "Ingrese la cédula");
            SendMessage(txtTE.Handle, EM_SETCUEBANNER, 0, "Ingrese el teléfono");
            SendMessage(txtCOE.Handle, EM_SETCUEBANNER, 0, "Ingrese el correo electrónico");
        }

        private void btnNCG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNC.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNC.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApe.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtApe.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCI.Text))
            {
                MessageBox.Show("Ingrese la cédula.");
                txtCI.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTE.Text))
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTE.Focus();
                return;
            }

            if (txtCI.Text.Trim().Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                txtCI.Focus();
                return;
            }

            if (txtTE.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 dígitos.");
                txtTE.Focus();
                return;
            }

            if (cliente.CedulaExiste(txtCI.Text.Trim()))
            {
                MessageBox.Show("Ya existe un cliente registrado con esa cédula.");
                txtCI.Focus();
                return;
            }

            cliente.Codigo = cliente.GenerarCodigo();
            cliente.Nombres = txtNC.Text.Trim();
            cliente.Apellidos = txtApe.Text.Trim();
            cliente.Cedula = txtCI.Text.Trim();
            cliente.Telefono = txtTE.Text.Trim();
            cliente.Correo = txtCOE.Text.Trim();
            cliente.Direccion = txtDI.Text.Trim();

            bool guardado = cliente.Registrar();

            if (guardado)
            {
                csConectaSQL conexion = new csConectaSQL();

                string nombreCompleto =
                    cliente.Nombres + " " + cliente.Apellidos;

                conexion.RegistrarActividad(
                    "Se registró el cliente " + nombreCompleto
                );

                MessageBox.Show("Cliente registrado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el cliente.");
            }
        }

        private void btnNVC_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Solo letras y espacios (Nombres, Apellidos)
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Solo números (Cédula, Teléfono)
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}