using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            //====================== DISEÑO DEL DATAGRIDVIEW ======================

            dgvSucursales.EnableHeadersVisualStyles = false;

            // General
            dgvSucursales.BorderStyle = BorderStyle.None;
            dgvSucursales.BackgroundColor = Color.White;
            dgvSucursales.GridColor = Color.FromArgb(235, 235, 235);

            dgvSucursales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvSucursales.ReadOnly = true;
            dgvSucursales.MultiSelect = false;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;

            dgvSucursales.RowHeadersVisible = false;


            //====================== ENCABEZADO ======================

            dgvSucursales.ColumnHeadersHeight = 50;
            dgvSucursales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvSucursales.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 57, 75); // #2E394B

            dgvSucursales.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvSucursales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSucursales.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            //====================== FILAS ======================

            dgvSucursales.RowTemplate.Height = 45;

            dgvSucursales.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvSucursales.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);

            dgvSucursales.DefaultCellStyle.BackColor =
                Color.White;


            dgvSucursales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);


            // Selección elegante
            dgvSucursales.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 250);

            dgvSucursales.DefaultCellStyle.SelectionForeColor =
                Color.Black;


            // Alineación general
            dgvSucursales.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // Espaciado interno
            dgvSucursales.DefaultCellStyle.Padding =
                new Padding(5);


            //====================== AJUSTE DE COLUMNAS ======================

            dgvSucursales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // Distribución equilibrada

            dgvSucursales.Columns["clCodigo"].FillWeight = 8;
            dgvSucursales.Columns["clFechaRegistro"].FillWeight = 12;
            dgvSucursales.Columns["clNombreSucursal"].FillWeight = 20;
            dgvSucursales.Columns["clCiudad"].FillWeight = 12;
            dgvSucursales.Columns["clDireccion"].FillWeight = 20;
            dgvSucursales.Columns["clTelefono"].FillWeight = 13;
            dgvSucursales.Columns["clEncargado"].FillWeight = 18;
            dgvSucursales.Columns["clEstado"].FillWeight = 10;

            dgvSucursales.Columns["clEditar"].FillWeight = 8;
            dgvSucursales.Columns["clUbicacion"].FillWeight = 8;
            dgvSucursales.Columns["clVer"].FillWeight = 8;

            // Icono editar

            DataGridViewImageColumn editar =
            (DataGridViewImageColumn)dgvSucursales.Columns["clEditar"];

            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;



            // Icono ubicación

            DataGridViewImageColumn ubicacion =
            (DataGridViewImageColumn)dgvSucursales.Columns["clUbicacion"];

            ubicacion.Image = Properties.Resources.ubicacionnnnbtn;
            ubicacion.ImageLayout = DataGridViewImageCellLayout.Zoom;



            // Icono ver

            DataGridViewImageColumn ver =
            (DataGridViewImageColumn)dgvSucursales.Columns["clVer"];

            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;


            //====================== COLUMNAS CENTRADAS ======================

            string[] columnasCentro =
            {
                 "clCodigo",
                "clFechaRegistro",
                "clCiudad",
                "clTelefono",
               "clEstado",
               "clEditar",
                "clUbicacion",
                  "clVer"
            };

            foreach (string columna in columnasCentro)
            {
                dgvSucursales.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }


            //====================== DATOS DE EJEMPLO ======================

            dgvSucursales.Rows.Clear();

            dgvSucursales.Rows.Add(
                "SC001",
                "06/08/2026",
                "Sucursal Norte",
                "Quito",
                "Av. Amazonas",
                "0999999999",
                "Juan Piguave",
                "Activa"
            );
        }

        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            string columna =
            dgvSucursales.Columns[e.ColumnIndex].Name;


            if (columna == "clEditar")
            {
                MessageBox.Show("Editar sucursal");
            }


            if (columna == "clUbicacion")
            {
                frmUbicacionSucursales frm = new frmUbicacionSucursales();
                frm.Show();
            }


            if (columna == "clVer")
            {
                MessageBox.Show("Ver información");
            }
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            frmRegistroSucursales form = new frmRegistroSucursales();
            form.Show();

        }

        private void lblSalirV_Click_1(object sender, EventArgs e)
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
    }
}