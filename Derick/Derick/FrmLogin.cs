using Microsoft.Data.SqlClient;
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

            string cadena = @"Data Source=MICHELLE\SQLEXPRESS;Initial Catalog=Derick;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();

                    string consulta = @"SELECT IdRol 
                                FROM Usuario 
                                WHERE Usuario = @usuario 
                                AND Contrasena = @contrasena 
                                AND Estado = 1";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        int idRol = Convert.ToInt32(resultado);

                        if (idRol == 1)
                        {
                            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                            frmMenu.usuarioActual = usuario;
                            frmMenu.Show();
                            this.Hide();
                        }
                        else if (idRol == 2)
                        {
                            FrmMenuEmpleados frmMenu = new FrmMenuEmpleados();
                            frmMenu.usuarioActual = usuario;
                            frmMenu.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.",
                            "Error de acceso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
