using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmConsultarVenta : Form
    {
        public FrmConsultarVenta()
        {
            InitializeComponent();
        }

        private void lblSalirCV_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentasN frm = new FrmVentasN();
            frm.ShowDialog();
        }
    }
}
