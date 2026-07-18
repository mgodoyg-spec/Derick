using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form FormAct = null;
        public string usuarioActual;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //label de la parte superior
            lblusuario.Text = usuarioActual;
            pnl_submenu.Visible = false;
        }
        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
            "¿Estás seguro que deseas cerrar sesión?",
            "Cerrar sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close(); // cierra el menú principal
            }
        }
        private void Abr_form(Form form)
        {
            if (FormAct != null)
            {
                FormAct.Close();
            }
            FormAct = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnl_inv.Controls.Clear();
            pnl_inv.Controls.Add(form);
            form.BringToFront();
            form.Show();

        }
        private void btnproductos_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pnl_submenu.Visible = true;
        }

        private void btn_volverinicio_Click(object sender, EventArgs e)
        {
            if (FormAct != null)
            {
                FormAct.Close();
                FormAct = null;
            }
            pnl_inv.Controls.Clear();
            pnl_submenu.Visible = false;
            panel2.Visible = true;
        }

        private void bnt_invnt_Click(object sender, EventArgs e)
        {
            Abr_form(new Form_invnt());
        }
    }
}
