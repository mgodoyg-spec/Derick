using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmVentasN : Form
    {
        public FrmVentasN()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void picNVB_Click(object sender, EventArgs e)
        {
            FrmBuscarClienteV ventana = new FrmBuscarClienteV();
            ventana.ShowDialog();
        }

        private void lblSalirV_Click(object sender, EventArgs e)
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

        private void btnNVAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lblSalirV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
