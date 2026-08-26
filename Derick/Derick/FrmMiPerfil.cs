using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmMiPerfil : Form
    {
        public int idUsuarioActual;
        public int idEmpleadoActual;
        public string usuarioActual;
        public FrmMiPerfil()
        {
            InitializeComponent();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMiPerfil_Load(object sender, EventArgs e)
        {
            CargarPerfil();
        }
        private void CargarPerfil()
        {
            csConectaSQL oConexion = new csConectaSQL();
            string consulta = @"select E.Codigo,E.Cedula,E.Nombres,E.Apellidos,E.FechaNacimiento,E.Correo, E.Estado,E.Foto, E.Genero,E.Telefono,E.Direccion,
            E.Cargo,E.Departamento,E.FechaIngreso,E.TipoContrato,E.ContactoEmergencia,E.TelefonoEmergencia,U.Usuario,
            U.Contrasena,R.NombreRol from Empleados E
            inner join Usuario U on E.IdEmpleado = U.IdEmpleado
            inner join Rol R on U.IdRol = R.IdRol
            where E.IdEmpleado = " + idEmpleadoActual;
            DataTable dt = oConexion.RetornaRegistros(consulta);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                txtcodigo.Text = fila["Codigo"].ToString();
                txtcedula.Text = fila["Cedula"].ToString();
                txtnombre.Text = fila["Nombres"].ToString();
                txtapellido.Text = fila["Apellidos"].ToString();
                if (fila["FechaNacimiento"] != DBNull.Value)
                {
                    txtfechan.Text = Convert.ToDateTime(fila["FechaNacimiento"]).ToString("dd/MM/yyyy");
                }
                txtgenero.Text = fila["Genero"].ToString();
                txttelefono.Text = fila["Telefono"].ToString();
                txtdireccion.Text = fila["Direccion"].ToString();
                txtcargo.Text = fila["Cargo"].ToString();
                txtdep.Text = fila["Departamento"].ToString();
                if (fila["FechaIngreso"] != DBNull.Value)
                {
                    txtfechai.Text = Convert.ToDateTime(fila["FechaIngreso"]).ToString("dd/MM/yyyy");
                }
                txtcorreo.Text = fila["Correo"].ToString();
                txtestado.Text = Convert.ToBoolean(fila["Estado"]) ? "Activo" : "Inactivo";
                txttipocon.Text = fila["TipoContrato"].ToString();
                txtusuario.Text = fila["Usuario"].ToString();
                txtrol.Text = fila["NombreRol"].ToString();
                txtcontraa.Text = fila["Contrasena"].ToString();
                txtcontacemer.Text = fila["ContactoEmergencia"].ToString();
                txttelemerg.Text = fila["TelefonoEmergencia"].ToString();
                if (fila["Foto"] != DBNull.Value)
                {
                    byte[] foto = (byte[])fila["Foto"];
                    MemoryStream ms = new MemoryStream(foto);
                    pbFoto.Image = Image.FromStream(ms);
                    pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                MessageBox.Show("No se encontró la información del empleado.");
            }
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                byte[] foto = File.ReadAllBytes(ofd.FileName);
                csConectaSQL oConexion = new csConectaSQL();
                string sql = "update Empleados set Foto=@Foto where IdEmpleado=@IdEmpleado";
                SqlParameter pFoto = new SqlParameter("@Foto", foto);
                SqlParameter pIdEmpleado = new SqlParameter("@IdEmpleado", idEmpleadoActual);
                if (oConexion.ejecutarComando(sql, pFoto, pIdEmpleado))
                {
                    MessageBox.Show("Foto actualizada correctamente.");
                }
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null)
                return;
            Form frmFoto = new Form();
            frmFoto.Text = "Foto de Perfil";
            frmFoto.StartPosition = FormStartPosition.CenterScreen;
            frmFoto.Size = new Size(500, 500);
            frmFoto.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmFoto.MaximizeBox = false;
            PictureBox fotoGrande = new PictureBox();
            fotoGrande.Dock = DockStyle.Fill;
            fotoGrande.Image = pbFoto.Image;
            fotoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            frmFoto.Controls.Add(fotoGrande);
            frmFoto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csConectaSQL oConexion = new csConectaSQL();

            string telefono = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string datos = "Telefono='" + telefono.Replace("'", "''") + "',Correo='" + correo.Replace("'", "''") +
                           "',Direccion='" + direccion.Replace("'", "''") + "'";
            string condicion = "IdEmpleado=" + idEmpleadoActual;
            if (oConexion.actualizarDatos("Empleados", datos, condicion))
            {
                MessageBox.Show("Información actualizada correctamente.");
                CargarPerfil();
            }
        }

        private void btnAcContra_Click(object sender, EventArgs e)
        {
            string nueva = txtcambcontr.Text.Trim();
            string confirmar = txtconfcont.Text.Trim();
            if (nueva == "" || confirmar == "")
            {
                MessageBox.Show("Debe completar ambos campos.");
                return;
            }
            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            csConectaSQL oConexion = new csConectaSQL();
            string datos = "Contrasena='" + nueva.Replace("'", "''") + "'";
            string condicion = "IdUsuario=" + idUsuarioActual;
            if (oConexion.actualizarDatos("Usuario", datos, condicion))
            {
                MessageBox.Show("Contraseña actualizada correctamente.");
                txtcontraa.Text = nueva;
                txtcambcontr.Clear();
                txtconfcont.Clear();
            }
        }

        private void btnEditInf_Click(object sender, EventArgs e)
        {
            csConectaSQL oConexion = new csConectaSQL();
            string contacto = txtcontacemer.Text.Trim();
            string telefono = txttelemerg.Text.Trim();
            string datos = "ContactoEmergencia='" + contacto.Replace("'", "''") +
                           "',TelefonoEmergencia='" + telefono.Replace("'", "''") + "'";
            if (contacto == "" || telefono == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }
            string condicion = "IdEmpleado=" + idEmpleadoActual;
            if (oConexion.actualizarDatos("Empleados", datos, condicion))
            {
                MessageBox.Show("Información adicional actualizada correctamente.");
                CargarPerfil();
            }
        }
    }
}
