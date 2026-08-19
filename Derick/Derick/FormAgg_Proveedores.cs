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
        private int? idProveedorEditar = null;
        public FormAgg_Proveedores()
        {
            InitializeComponent();
        }
        public FormAgg_Proveedores(int idProveedor) : this()
        {
            idProveedorEditar = idProveedor;
        }
        private void FormAgg_Proveedores_Load(object sender, EventArgs e)
        {
            if (idProveedorEditar != null)
            {
                CPRV_editar();
            }
        }
        private void CPRV_editar()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT Nombre, Contacto, Telefono, Correo, Direccion, Estado " +
                "FROM Proveedores " +
                "WHERE IdProveedor = " + idProveedorEditar.Value
            );

            if (dt == null || dt.Rows.Count == 0)
                return;

            DataRow fila = dt.Rows[0];

            txt_NP.Text = fila["Nombre"].ToString();
            txt_CNC.Text = fila["Contacto"].ToString();
            txt_TL.Text = fila["Telefono"].ToString();
            txt_CE.Text = fila["Correo"].ToString();
            txt_DRC.Text = fila["Direccion"].ToString();

            bool activo = Convert.ToBoolean(fila["Estado"]);

            cmb_Estado.Text = activo
                ? "Activo"
                : "Inactivo";
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

            if (idProveedorEditar == null)
            {
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
            }
            else
            {
                string datosActualizar =
                    $"Nombre = '{nombre}', " +
                    $"Contacto = '{contacto}', " +
                    $"Telefono = '{telefono}', " +
                    $"Correo = '{correo}', " +
                    $"Direccion = '{direccion}', " +
                    $"Estado = {estado}";
                string condicion = $"IdProveedor = {idProveedorEditar.Value}";
                bool actualizado = conexion.actualizarDatos(
                    "Proveedores",
                    datosActualizar,
                    condicion
                );
                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se pudo actualizar el proveedor.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
                MessageBox.Show(
                    "Proveedor actualizado correctamente.",
                    "Proveedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
