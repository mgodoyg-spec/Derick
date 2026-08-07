using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmVentas : Form
    {
        private Form activo = null;
        public frmVentas()
        {
            InitializeComponent();
        }
        public void AbrirFormulario(Form formulario)
        {
            if(activo != null)
            {
                activo.Close();
            }
            activo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlMostrarFrmV.Controls.Clear();
            pnlMostrarFrmV.Controls.Add(formulario);
            formulario.Show();
        }
        public void MostrarFrm()
        {
            if (activo != null)
            {
                activo.Close();
                activo = null;
            }

        }

        private void lblConsultarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta frm = new FrmNuevaVenta();
            AbrirFormulario(frm);
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            FrmConsultarVentas frm = new FrmConsultarVentas();
            AbrirFormulario(frm);
        }
    }
}
