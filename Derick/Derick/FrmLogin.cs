using Microsoft.Data.SqlClient;
using System.Data;
namespace Derick
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool contrasenaVisible = false;
        private void btnInisesion_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string contrasena = txtcontrasena.Text.Trim();
            try
            {
                csConectaSQL oConexion = new csConectaSQL();
                string usuarioEsc = usuario.Replace("'", "''");
                string contrasenaEsc = contrasena.Replace("'", "''");
                string cadena = @"select IdUsuario, IdEmpleado, IdRol from Usuario where Usuario = '" + usuarioEsc + @"'
                                    and Contrasena = '" + contrasenaEsc + @"'and Estado = 1";
                DataTable dt = oConexion.RetornaRegistros(cadena);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int idUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]);
                    int idEmpleado = Convert.ToInt32(dt.Rows[0]["IdEmpleado"]);
                    int idRol = Convert.ToInt32(dt.Rows[0]["IdRol"]);
                    if (idRol == 1)
                    {
                        FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                        frmMenu.usuarioActual = usuario;
                        frmMenu.idUsuarioActual = idUsuario;
                        frmMenu.idEmpleadoActual = idEmpleado;
                        frmMenu.Show();
                        this.Hide();
                    }
                    else if (idRol == 2)
                    {
                        DataTable dtEmpleado = oConexion.RetornaRegistros("SELECT IdSucursal FROM Empleados " +
                         "WHERE IdEmpleado = " + idEmpleado);

                        if (dtEmpleado.Rows.Count > 0)
                        {
                            string idSucursal =
                                dtEmpleado.Rows[0]["IdSucursal"].ToString();

                            FrmMenuEmpleados frmMenu =
                                new FrmMenuEmpleados(usuario, idSucursal);

                            frmMenu.idEmpleadoActual = idEmpleado;

                            frmMenu.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Error de acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void pbojo_Click(object sender, EventArgs e)
        {
            if (contrasenaVisible)
            {
                txtcontrasena.UseSystemPasswordChar = true;
                pbojo.Image = Properties.Resources.esconder;
                contrasenaVisible = false;
            }
            else
            {
                txtcontrasena.UseSystemPasswordChar = false;
                pbojo.Image = Properties.Resources.mostrar;
                contrasenaVisible = true;
            }
        }
        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
