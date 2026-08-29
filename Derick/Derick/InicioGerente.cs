using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class InicioGerente : Form
    {
        public InicioGerente()
        {
            InitializeComponent();
        }

        private void lblSalir_Click(object sender, EventArgs e)
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
        private void InicioGerente_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now
           .ToString("dd MMM yyyy")
           .ToUpper();

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            CargarResumen();
        }

        // cargar los conteos del resumen de sucursales y empleados
        private void CargarResumen()
        {
            csConectaSQL oConexion = new csConectaSQL();

            DataTable dtSucursales = oConexion.RetornaRegistros("SELECT COUNT(*) AS Total FROM Sucursales");
            label2.Text = dtSucursales.Rows[0]["Total"].ToString();
            DataTable dtEmpleados = oConexion.RetornaRegistros("SELECT COUNT(*) AS Total FROM Empleados WHERE Estado = 1");
            label5.Text = dtEmpleados.Rows[0]["Total"].ToString();
            DataTable dtProductos = oConexion.RetornaRegistros("SELECT COUNT(*) AS Total FROM Productos WHERE Estado = 1");
            NumProductos.Text = dtProductos.Rows[0]["Total"].ToString();
        }
        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now
           .ToString("dd MMM yyyy")
           .ToUpper();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
