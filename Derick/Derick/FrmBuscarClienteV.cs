using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmBuscarClienteV : Form
    {
        public FrmBuscarClienteV()
        {
            InitializeComponent();
        }

        private void FrmBuscarClienteV_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvNVBC.EnableHeadersVisualStyles = false;
            dgvNVBC.BorderStyle = BorderStyle.None;
            dgvNVBC.BackgroundColor = Color.White;
            dgvNVBC.GridColor = Color.FromArgb(235, 235, 235);
            dgvNVBC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVBC.ReadOnly = true;
            dgvNVBC.MultiSelect = false;
            dgvNVBC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVBC.AllowUserToAddRows = false;
            dgvNVBC.AllowUserToDeleteRows = false;
            dgvNVBC.AllowUserToResizeRows = false;
            dgvNVBC.AllowUserToResizeColumns = false;
            dgvNVBC.RowHeadersVisible = false;

            //encabezado
            dgvNVBC.ColumnHeadersHeight = 50;
            dgvNVBC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVBC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVBC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVBC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVBC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvNVBC.RowTemplate.Height = 45;
            dgvNVBC.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVBC.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVBC.DefaultCellStyle.BackColor = Color.White;
            dgvNVBC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVBC.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVBC.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVBC.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVBC.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvNVBC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNVBC.Columns["colNombre"].FillWeight = 25;
            dgvNVBC.Columns["colTel"].FillWeight = 18;
            dgvNVBC.Columns["colAcciones"].FillWeight = 15;
            dgvNVBC.Columns["colEditar"].FillWeight = 10;
            dgvNVBC.Columns["colEliminar"].FillWeight = 10;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvNVBC.Columns["colEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvNVBC.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //columnas centradas
            string[] columnasCentro =
            {
    "colNombre",
    "colTel",
    "colAcciones",
    "colEditar",
    "colEliminar"
};

            foreach (string columna in columnasCentro)
            {
                dgvNVBC.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnNVBC_Click(object sender, EventArgs e)
        {
            FrmNuevoClienteV ventana = new FrmNuevoClienteV();
            ventana.ShowDialog();
        }
    }
}
