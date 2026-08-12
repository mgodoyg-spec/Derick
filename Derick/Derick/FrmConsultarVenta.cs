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

        private void FrmConsultarVenta_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvCVF.EnableHeadersVisualStyles = false;
            dgvCVF.BorderStyle = BorderStyle.None;
            dgvCVF.BackgroundColor = Color.White;
            dgvCVF.GridColor = Color.FromArgb(235, 235, 235);
            dgvCVF.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCVF.ReadOnly = true;
            dgvCVF.MultiSelect = false;
            dgvCVF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCVF.AllowUserToAddRows = false;
            dgvCVF.AllowUserToDeleteRows = false;
            dgvCVF.AllowUserToResizeRows = false;
            dgvCVF.AllowUserToResizeColumns = false;
            dgvCVF.RowHeadersVisible = false;

            //encabezado
            dgvCVF.ColumnHeadersHeight = 50;
            dgvCVF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCVF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvCVF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCVF.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCVF.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvCVF.RowTemplate.Height = 45;
            dgvCVF.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCVF.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvCVF.DefaultCellStyle.BackColor = Color.White;
            dgvCVF.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvCVF.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvCVF.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCVF.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCVF.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvCVF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCVF.Columns["colCodigo"].FillWeight = 10;
            dgvCVF.Columns["colFecha"].FillWeight = 12;
            dgvCVF.Columns["colHora"].FillWeight = 10;
            dgvCVF.Columns["colVendedor"].FillWeight = 16;
            dgvCVF.Columns["colSucursal"].FillWeight = 14;
            dgvCVF.Columns["colSubtotal"].FillWeight = 12;
            dgvCVF.Columns["colDescuento"].FillWeight = 12;
            dgvCVF.Columns["colTotal"].FillWeight = 12;
            dgvCVF.Columns["colEstado"].FillWeight = 10;
            dgvCVF.Columns["colAcciones"].FillWeight = 10;
            dgvCVF.Columns["colEditar"].FillWeight = 8;
            dgvCVF.Columns["colEliminar"].FillWeight = 8;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvCVF.Columns["colEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvCVF.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //columnas centradas
            string[] columnasCentro =
            {
    "colCodigo",
    "colFecha",
    "colHora",
    "colVendedor",
    "colSucursal",
    "colSubtotal",
    "colDescuento",
    "colTotal",
    "colEstado",
    "colAcciones",
    "colEditar",
    "colEliminar"
};

            foreach (string columna in columnasCentro)
            {
                dgvCVF.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
