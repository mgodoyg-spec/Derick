using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmBuscarSucursal : Form
    {
        public frmBuscarSucursal()
        {
            InitializeComponent();
        }

        private void frmBuscarSucursal_Load(object sender, EventArgs e)
        {
            dgvSucursales.EnableHeadersVisualStyles = false;

            // Fondo general
            dgvSucursales.BackgroundColor = Color.White;
            dgvSucursales.BorderStyle = BorderStyle.None;
            dgvSucursales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSucursales.GridColor = Color.FromArgb(235, 235, 235);

            // Encabezado
            dgvSucursales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSucursales.ColumnHeadersHeight = 48;

            dgvSucursales.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(225, 229, 235);

            dgvSucursales.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvSucursales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Calibri", 12, FontStyle.Bold);

            dgvSucursales.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // Filas
            dgvSucursales.DefaultCellStyle.BackColor = Color.White;
            dgvSucursales.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgvSucursales.DefaultCellStyle.Font =
                new Font("Calibri", 12);

            dgvSucursales.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 240, 255);

            dgvSucursales.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // Filas alternas (muy sutil)
            dgvSucursales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(252, 252, 252);

            // Tamaños
            dgvSucursales.RowTemplate.Height = 42;
            dgvSucursales.RowHeadersVisible = false;

            // Ajustes
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.MultiSelect = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.AllowUserToAddRows = false;

            // Márgenes internos
            dgvSucursales.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
        }
    }
}
