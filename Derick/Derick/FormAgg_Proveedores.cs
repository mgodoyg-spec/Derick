using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormAgg_Proveedores : Form
    {
        public FormAgg_Proveedores()
        {
            InitializeComponent();
        }

        private void txt_NP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '.' &&
                e.KeyChar != '-' && e.KeyChar != '&' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool CorreoValido(string correo)
        {
            try
            {
                var direccion = new System.Net.Mail.MailAddress(correo);
                return direccion.Address == correo;
            }
            catch
            {
                return false;
            }
        }
        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. NOMBRE DEL PROVEEDOR
            // ==========================================
            if (string.IsNullOrWhiteSpace(txt_NP.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del proveedor.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_NP.Focus();
                return;
            }
            // ==========================================
            // 2. CONTACTO
            // ==========================================
            if (string.IsNullOrWhiteSpace(txt_CNC.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del contacto.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_CNC.Focus();
                return;
            }
            // ==========================================
            // 3. TELÉFONO
            // ==========================================
            if (string.IsNullOrWhiteSpace(txt_TL.Text))
            {
                MessageBox.Show(
                    "Ingrese el número de teléfono.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_TL.Focus();
                return;
            }
            if (txt_TL.Text.Length < 7)
            {
                MessageBox.Show(
                    "Ingrese un número de teléfono válido.",
                    "Teléfono inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_TL.Focus();
                return;
            }
            // ==========================================
            // 4. CORREO ELECTRÓNICO
            // ==========================================

            if (string.IsNullOrWhiteSpace(txt_CE.Text))
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_CE.Focus();
                return;
            }
            if (!CorreoValido(txt_CE.Text.Trim()))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Correo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_CE.Focus();
                return;
            }
            // ==========================================
            // 5. DIRECCIÓN
            // ==========================================
            if (txt_DRC.Text.Length > 200)
            {
                MessageBox.Show(
                    "La dirección no puede superar los 200 caracteres.",
                    "Dirección demasiado larga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_DRC.Focus();
                return;
            }
            // ==========================================
            // 6. ESTADO
            // ==========================================
            if (cmb_Estado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el estado del proveedor.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cmb_Estado.Focus();
                return;
            }
            // ==========================================
            // TODO CORRECTO
            // ==========================================
            string nombre = txt_NP.Text.Trim();
            string contacto = txt_CNC.Text.Trim();
            string telefono = txt_TL.Text.Trim();
            string correo = txt_CE.Text.Trim();
            string direccion = txt_DRC.Text.Trim();
            int estado = cmb_Estado.Text.Equals(
                "Activo",
                StringComparison.OrdinalIgnoreCase)
                ? 1
                : 0;

            csConectaSQL conexion = new csConectaSQL();

            string campos =
                "Nombre, Contacto, Telefono, Correo, Direccion, Estado";

            string datos =
                $"'{nombre}', " +
                $"'{contacto}', " +
                $"'{telefono}', " +
                $"'{correo}', " +
                $"'{direccion}', " +
                $"{estado}";

            bool guardado = conexion.insertDatos(
                "Proveedores",
                campos,
                datos
            );
            if (!guardado)
            {
                MessageBox.Show(
                    "No se pudo guardar el proveedor.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            MessageBox.Show(
                "Proveedor registrado correctamente.",
                "Proveedor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
