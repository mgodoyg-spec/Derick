using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace Derick
{
    public partial class frmRegistroSucursales : Form
    {
        string rutaImagen = "";
        public frmRegistroSucursales()
        {
            InitializeComponent();
        }
        private void frmRegistroSucursales_Load(object sender, EventArgs e)
        {
            CargarEncargados();
        }

        // cargar encargados en el combo
        private void CargarEncargados()
        {
            csConectaSQL oConexion = new csConectaSQL();
            string query = "SELECT Nombres + ' ' + Apellidos AS Encargado FROM Empleados";
            DataTable dt = oConexion.RetornaRegistros(query);
            cbxEncargadoSucursal.DataSource = dt;
            cbxEncargadoSucursal.DisplayMember = "Encargado";
            cbxEncargadoSucursal.ValueMember = "Encargado";
            cbxEncargadoSucursal.Text = "";
        }
        // seleccionar imagen
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImagenSucursal.Image = Image.FromFile(ofd.FileName);
                pbxImagenSucursal.SizeMode = PictureBoxSizeMode.Zoom;
                rutaImagen = ofd.FileName;
                pbxAgregarImagen.Visible = false;
                lblSeleccionarImag.Visible = false;
            }
        }
        // quitar imagen
        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar la imagen?",
                "Eliminar imagen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (pbxImagenSucursal.Image != null)
                    pbxImagenSucursal.Image.Dispose();

                pbxImagenSucursal.Image = null;
                rutaImagen = "";
                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        // generar codigo de sucursal
        private string GenerarCodigo()
        {
            csConectaSQL oConexion = new csConectaSQL();
            string query = "SELECT MAX(IdSucursal) FROM Sucursales";
            DataTable dt = oConexion.RetornaRegistros(query);
            string codigo = "SUC001";
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                int ultimo = Convert.ToInt32(dt.Rows[0][0]);
                codigo = "SUC" + (ultimo + 1).ToString("D3");
            }
            return codigo;
        }

        // registrar sucursal
        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreSucursal.Text) ||
               string.IsNullOrWhiteSpace(txtCiudadSucursal.Text) ||
               string.IsNullOrWhiteSpace(txtDireccionSucursal.Text) ||
               string.IsNullOrWhiteSpace(txtTelefonoSucursal.Text) ||
               string.IsNullOrWhiteSpace(cbxEncargadoSucursal.Text) ||
               string.IsNullOrWhiteSpace(cbxEstadoSucursal.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos obligatorios",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                csConectaSQL oConexion = new csConectaSQL();

                // escapamos comillas simples para que nombres o direcciones con apostrofe no rompan el insert, ya que insertDatos recibe el
                // sql armado como texto
                string codigo = GenerarCodigo();
                string nombreEsc = txtNombreSucursal.Text.Trim().Replace("'", "''");
                string ciudadEsc = txtCiudadSucursal.Text.Trim().Replace("'", "''");
                string direccionEsc = txtDireccionSucursal.Text.Trim().Replace("'", "''");
                string telefonoEsc = txtTelefonoSucursal.Text.Trim().Replace("'", "''");
                string correoEsc = txtCorreoSucursal.Text.Trim().Replace("'", "''");
                string encargadoEsc = cbxEncargadoSucursal.Text.Replace("'", "''");
                string fotoEsc = rutaImagen.Replace("'", "''");
                string campos = "Codigo,NombreSucursal,Ciudad,Direccion,Telefono,Correo,EncargadoSucursal,RutaFoto";
                string datos = "'" + codigo + "','" + nombreEsc + "','" + ciudadEsc + "','" + direccionEsc
                    + "','" + telefonoEsc + "','" + correoEsc + "','" + encargadoEsc + "','" + fotoEsc + "'";
                oConexion.insertDatos("Sucursales", campos, datos);
                MessageBox.Show(
                    "Sucursal registrada correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}