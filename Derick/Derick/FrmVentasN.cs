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

        private void FrmVentasN_Load_1(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvNVPA.EnableHeadersVisualStyles = false;
            dgvNVPA.BorderStyle = BorderStyle.None;
            dgvNVPA.BackgroundColor = Color.White;
            dgvNVPA.GridColor = Color.FromArgb(235, 235, 235);
            dgvNVPA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVPA.ReadOnly = true;
            dgvNVPA.MultiSelect = false;
            dgvNVPA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVPA.AllowUserToAddRows = false;
            dgvNVPA.AllowUserToDeleteRows = false;
            dgvNVPA.AllowUserToResizeRows = false;
            dgvNVPA.AllowUserToResizeColumns = false;
            dgvNVPA.RowHeadersVisible = false;

            //encabezado
            dgvNVPA.ColumnHeadersHeight = 50;
            dgvNVPA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVPA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVPA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVPA.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVPA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvNVPA.RowTemplate.Height = 45;
            dgvNVPA.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVPA.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVPA.DefaultCellStyle.BackColor = Color.White;
            dgvNVPA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVPA.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVPA.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVPA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVPA.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvNVPA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNVPA.Columns["colCodigo"].FillWeight = 10;
            dgvNVPA.Columns["colProducto"].FillWeight = 20;
            dgvNVPA.Columns["colTalla"].FillWeight = 10;
            dgvNVPA.Columns["colColor"].FillWeight = 12;
            dgvNVPA.Columns["colCantidad"].FillWeight = 12;
            dgvNVPA.Columns["colPrecio"].FillWeight = 12;
            dgvNVPA.Columns["colSubtotal"].FillWeight = 14;
            dgvNVPA.Columns["colAcciones"].FillWeight = 10;
            dgvNVPA.Columns["colEditar"].FillWeight = 8;
            dgvNVPA.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn Editar = (DataGridViewImageColumn)dgvNVPA.Columns["colEditar"];
            Editar.Image = Properties.Resources.editarrbtn;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn Eliminar = (DataGridViewImageColumn)dgvNVPA.Columns["colEliminar"];
            Eliminar.Image = Properties.Resources.picEliminar;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //columnas centradas
            string[] columnasCentro =
            {
    "colCodigo",
    "colProducto",
    "colTalla",
    "colColor",
    "colCantidad",
    "colPrecio",
    "colSubtotal",
    "colAcciones",
    "colEditar",
    "colEliminar"
};

            foreach (string columna in columnasCentro)
            {
                dgvNVPA.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void picNVB_Click_1(object sender, EventArgs e)
        {
            FrmBuscarClienteV ventana = new FrmBuscarClienteV();
            ventana.ShowDialog();
        }
    }
}
