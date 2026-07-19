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
        bool sbmn = true;
        private int posMenu;
        private int posAgg;
        private int posEliminar;
        private int posVolver;
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

            posMenu = pic_menu.Left;
            posAgg = pic_agg.Left;
            posEliminar = pic_eliminar.Left;
            posVolver = pic_volver.Left;
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

        private void btn_mn_Click(object sender, EventArgs e)
        {
            tm_submenu.Start();
        }

        private void tm_submenu_Tick(object sender, EventArgs e)
        {
            if (sbmn) // Contraer
            {
                pnl_submenu.Width -= 10;
                pnl_inv.Left = pnl_submenu.Width;
                pnl_inv.Width = this.ClientSize.Width - pnl_submenu.Width;
                if (pnl_submenu.Width <= 60)
                {
                    pnl_submenu.Width = 60;
                    tm_submenu.Stop();
                    sbmn = false;

                    pic_menu.Left = 15;
                    pic_agg.Left = 15;
                    pic_eliminar.Left = 15;
                    pic_volver.Left = 15;
                }
            }
            else // Expandir
            {
                pnl_submenu.Width += 10;
                pnl_inv.Left = pnl_submenu.Width;
                pnl_inv.Width = this.ClientSize.Width - pnl_submenu.Width;
                if (pnl_submenu.Width >= 250)
                {
                    pnl_submenu.Width = 250;
                    tm_submenu.Stop();
                    sbmn = true;

                    pic_menu.Left = posMenu;
                    pic_agg.Left = posAgg;
                    pic_eliminar.Left = posEliminar;
                    pic_volver.Left = posVolver;
                }
            }
        }
    }
}
