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
            // Usuario y contraseña temporales (solo para pruebas)
            if (usuario == "admin" && contrasena == "1234")
            {
                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
