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
        private bool editar = false;
        private csSucursal sucursalEditada;
        private byte[] imagenSucursal = null;
        public frmRegistroSucursales()
        {
            InitializeComponent();
            editar = false;
        }
        public frmRegistroSucursales(csSucursal sucursal)
        {
            InitializeComponent();

            editar = true;
            sucursalEditada = sucursal;
        }
        private void frmRegistroSucursales_Load(object sender, EventArgs e)
        {
            CargarEncargados();

            if (editar == false)
            {
                lblTitulo.Text = "Registrar sucursal";
                btnRegistrarSucursal.Text = "Registrar sucursal";
            }
            else
            {
                lblTitulo.Text = "Editar sucursal";
                btnRegistrarSucursal.Text = "Guardar cambios";
                CargarDatosEditar();
            }
        }
        private void CargarEncargados()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string sql = "select Nombres + ' ' + Apellidos as Encargado from Empleados";

            DataTable datos = oConexion.RetornaRegistros(sql);

            cbxEncargadoSucursal.DataSource = datos;
            cbxEncargadoSucursal.DisplayMember = "Encargado";
            cbxEncargadoSucursal.ValueMember = "Encargado";
            cbxEncargadoSucursal.Text = "";
        }
        private void CargarDatosEditar()
        {
            txtNombreSucursal.Text = sucursalEditada.NombreSucursal;
            cbxCiudad.Text = sucursalEditada.Ciudad;
            txtDireccionSucursal.Text = sucursalEditada.Direccion;
            txtTelefonoSucursal.Text = sucursalEditada.Telefono;
            txtCorreoSucursal.Text = sucursalEditada.Correo;
            cbxEncargadoSucursal.Text = sucursalEditada.EncargadoSucursal;
            cbxEstadoSucursal.Text = sucursalEditada.Estado;

            imagenSucursal = sucursalEditada.Imagen;

            if (imagenSucursal != null && imagenSucursal.Length > 0)
            {
                pbxImagenSucursal.Image = BytesAImagen(imagenSucursal);
                pbxImagenSucursal.SizeMode = PictureBoxSizeMode.Zoom;
                pbxAgregarImagen.Visible = false;
                lblSeleccionarImag.Visible = false;
            }
            else
            {
                pbxImagenSucursal.Image = null;
                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagenSucursal = File.ReadAllBytes(ofd.FileName);

                pbxImagenSucursal.Image =BytesAImagen(imagenSucursal);
                pbxImagenSucursal.SizeMode = PictureBoxSizeMode.Zoom;
                pbxAgregarImagen.Visible = false;
                lblSeleccionarImag.Visible = false;
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar la imagen?","Eliminar imagen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (pbxImagenSucursal.Image != null)
                {
                    pbxImagenSucursal.Image.Dispose();
                }

                pbxImagenSucursal.Image = null;
                imagenSucursal = null;

                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }
        }

        private string GenerarCodigo()
        {
            csConectaSQL oConexion = new csConectaSQL();

            string sql = "select max(IdSucursal) from Sucursales";

            DataTable datos = oConexion.RetornaRegistros(sql);

            string codigo = "SUC001";

            if (datos != null && datos.Rows.Count > 0 && datos.Rows[0][0] != DBNull.Value)
            {
                int ultimo = Convert.ToInt32(datos.Rows[0][0]);
                codigo = "SUC" + (ultimo + 1).ToString("D3");
            }

            return codigo;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreSucursal.Text) ||
                string.IsNullOrWhiteSpace(cbxCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionSucursal.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoSucursal.Text) ||
                string.IsNullOrWhiteSpace(cbxEncargadoSucursal.Text) ||
                string.IsNullOrWhiteSpace(cbxEstadoSucursal.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
                return;

            if (editar == false)
            {
                RegistrarSucursal();
            }
            else
            {
                EditarSucursal();
            }
        }

        private void RegistrarSucursal()
        {
            try
            {
                csConectaSQL oConexion = new csConectaSQL();

                string codigo = GenerarCodigo();

                string sql =
                    "insert into Sucursales " +
                    "(Codigo, NombreSucursal, Ciudad, Direccion, Telefono, Correo, " +
                    "EncargadoSucursal, Estado, Imagen) " +
                    "values (@Codigo, @Nombre, @Ciudad, @Direccion, @Telefono, @Correo, " +
                    "@Encargado, @Estado, @Imagen)";

                SqlParameter parametroImagen = new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);

                if (imagenSucursal != null && imagenSucursal.Length > 0)
                    parametroImagen.Value = imagenSucursal;
                else
                    parametroImagen.Value = DBNull.Value;

                bool resultado = oConexion.ejecutarComando(
                    sql,
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Nombre", txtNombreSucursal.Text.Trim()),
                    new SqlParameter("@Ciudad", cbxCiudad.Text.Trim()),
                    new SqlParameter("@Direccion", txtDireccionSucursal.Text.Trim()),
                    new SqlParameter("@Telefono", txtTelefonoSucursal.Text.Trim()),
                    new SqlParameter("@Correo", txtCorreoSucursal.Text.Trim()),
                    new SqlParameter("@Encargado", cbxEncargadoSucursal.Text.Trim()),
                    new SqlParameter("@Estado", cbxEstadoSucursal.Text.Trim()),
                    parametroImagen
                );

                if (resultado)
                {
                    MessageBox.Show(
                        "Sucursal registrada correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void EditarSucursal()
        {
            try
            {
                sucursalEditada.NombreSucursal = txtNombreSucursal.Text.Trim();
                sucursalEditada.Ciudad = cbxCiudad.Text.Trim();
                sucursalEditada.Direccion = txtDireccionSucursal.Text.Trim();
                sucursalEditada.Telefono = txtTelefonoSucursal.Text.Trim();
                sucursalEditada.Correo = txtCorreoSucursal.Text.Trim();
                sucursalEditada.EncargadoSucursal = cbxEncargadoSucursal.Text.Trim();
                sucursalEditada.Estado = cbxEstadoSucursal.Text.Trim();
                sucursalEditada.Imagen = imagenSucursal;

                if (sucursalEditada.Editar())
                {
                    MessageBox.Show("Sucursal actualizada correctamente","Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Image BytesAImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (Image imagenTemporal = Image.FromStream(ms))
                {
                    return new Bitmap(imagenTemporal);
                }
            }
        }

        private void txtTelefonoSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}