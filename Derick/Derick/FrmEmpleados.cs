using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmEmpleados : Form
    {
        private Form activo = null;
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        public void AbrirFormulario(Form formulario)
        {
            if (activo != null)
            {
                activo.Close();
            }

            activo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlMostrarEmpleadosForm.Controls.Clear();
            pnlMostrarEmpleadosForm.Controls.Add(formulario);
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

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmple());
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
           
        }

        private void btndepa_Click(object sender, EventArgs e)
        {
        }
    }
}
