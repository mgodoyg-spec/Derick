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

            pnl_product1.Controls.Clear();
            pnl_product1.Controls.Add(formulario);
            formulario.Show();
        }
        public void MostrarFrm()
        {
            AbrirFormulario(new FormProductos());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_product1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAgg_Product());
        }

        private void btn_product2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormBusc_Product());
        }
    }
}
