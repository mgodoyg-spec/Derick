using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormProductos : Form
    {
        private Form activo;
        public FormProductos()
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

            pnl_cont_product.Controls.Clear();
            pnl_cont_product.Controls.Add(formulario);
            formulario.Show();
        }
        public void MostrarFrm()
        {
            AbrirFormulario(new FormProductos());
        }
    }
}
