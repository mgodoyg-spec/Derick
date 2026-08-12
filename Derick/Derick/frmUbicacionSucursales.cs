using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmUbicacionSucursales : Form
    {
        private csSucursal sucursal;

        public frmUbicacionSucursales()
        {
            InitializeComponent();
        }
        public frmUbicacionSucursales(csSucursal sucursal)
        {
            InitializeComponent();

            this.sucursal = sucursal;
        }
        private void CargarDatos()
        {
            lblSucursal.Text =
                sucursal.NombreSucursal;

            lblCiudad.Text =
                sucursal.Ciudad;

            lblEstado.Text =
                sucursal.Estado;

            lblDireccion.Text= 
                sucursal.Direccion;
        }


        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUbicacionSucursales_Load(object sender, EventArgs e)
        {
            if (sucursal != null)
            {
                CargarDatos();
            }
        }
    }
}
