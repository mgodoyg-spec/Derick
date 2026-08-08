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


        // ============================
        // CARGAR ENCARGADOS DEL COMBO
        // ============================

        private void CargarEncargados()
        {
            using (SqlConnection con = csConexion.ObtenerConexion())
            {
                con.Open();

                string query = @"SELECT 
                                Nombres + ' ' + Apellidos AS Encargado
                                FROM Empleados";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);


                cbxEncargadoSucursal.DataSource = dt;
                cbxEncargadoSucursal.DisplayMember = "Encargado";
                cbxEncargadoSucursal.ValueMember = "Encargado";

                cbxEncargadoSucursal.Text = "";
            }
        }



        // ============================
        // SELECCIONAR IMAGEN
        // ============================

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



        // ============================
        // QUITAR IMAGEN
        // ============================

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
                {
                    pbxImagenSucursal.Image.Dispose();
                }


                pbxImagenSucursal.Image = null;

                rutaImagen = "";

                pbxAgregarImagen.Visible = true;
                lblSeleccionarImag.Visible = true;
            }

        }



        // ============================
        // GENERAR CODIGO
        // ============================

        private string GenerarCodigo()
        {

            string codigo = "SUC001";


            using (SqlConnection con = csConexion.ObtenerConexion())
            {

                con.Open();


                string query = @"SELECT MAX(IdSucursal) 
                                 FROM Sucursales";


                SqlCommand cmd = new SqlCommand(query, con);


                object resultado = cmd.ExecuteScalar();


                if (resultado != DBNull.Value && resultado != null)
                {

                    int ultimo = Convert.ToInt32(resultado);

                    codigo = "SUC" + (ultimo + 1)
                            .ToString("D3");

                }

            }


            return codigo;

        }





        // ============================
        // REGISTRAR SUCURSAL
        // ============================

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



            using (SqlConnection con = csConexion.ObtenerConexion())
            {

                con.Open();


                try
                {


                    string query = @"

                    INSERT INTO Sucursales
                    (
                    Codigo,
                    NombreSucursal,
                    Ciudad,
                    Direccion,
                    Telefono,
                    Correo,
                    EncargadoSucursal,
                    RutaFoto
                    )

                    VALUES
                    (
                    @codigo,
                    @nombre,
                    @ciudad,
                    @direccion,
                    @telefono,
                    @correo,
                    @encargado,
                    @foto
                    )";


                    SqlCommand cmd = new SqlCommand(query, con);



                    cmd.Parameters.AddWithValue(
                        "@codigo",
                        GenerarCodigo()
                    );


                    cmd.Parameters.AddWithValue(
                        "@nombre",
                        txtNombreSucursal.Text.Trim()
                    );


                    cmd.Parameters.AddWithValue(
                        "@ciudad",
                        txtCiudadSucursal.Text.Trim()
                    );


                    cmd.Parameters.AddWithValue(
                        "@direccion",
                        txtDireccionSucursal.Text.Trim()
                    );


                    cmd.Parameters.AddWithValue(
                        "@telefono",
                        txtTelefonoSucursal.Text.Trim()
                    );


                    cmd.Parameters.AddWithValue(
                        "@correo",
                        txtCorreoSucursal.Text.Trim()
                    );


                    cmd.Parameters.AddWithValue(
                        "@encargado",
                        cbxEncargadoSucursal.Text
                    );


                    cmd.Parameters.AddWithValue(
                        "@foto",
                        rutaImagen
                    );



                    cmd.ExecuteNonQuery();



                    MessageBox.Show(
                        "Sucursal registrada correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                    this.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(
                        "Error al registrar: " + ex.Message);

                }


            }


        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}