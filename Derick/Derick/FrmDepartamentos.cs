using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Desea regresar? Se perderán los cambios realizados.",
        "Regresar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FrmEmpleados frm = this.Parent.Parent as FrmEmpleados;

                if (frm != null)
                {
                    frm.MostrarFrm();
                }
            }
        }
        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvDepa.EnableHeadersVisualStyles = false;
            dgvDepa.BorderStyle = BorderStyle.None;
            dgvDepa.BackgroundColor = Color.White;
            dgvDepa.GridColor = Color.FromArgb(235, 235, 235);
            dgvDepa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDepa.ReadOnly = true;
            dgvDepa.MultiSelect = false;
            dgvDepa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepa.AllowUserToAddRows = false;
            dgvDepa.AllowUserToDeleteRows = false;
            dgvDepa.AllowUserToResizeRows = false;
            dgvDepa.AllowUserToResizeColumns = false;
            dgvDepa.RowHeadersVisible = false;
            //encabezado
            dgvDepa.ColumnHeadersHeight = 50;
            dgvDepa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDepa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvDepa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDepa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDepa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //filas
            dgvDepa.RowTemplate.Height = 45;
            dgvDepa.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDepa.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvDepa.DefaultCellStyle.BackColor = Color.White;
            dgvDepa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvDepa.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvDepa.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDepa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDepa.DefaultCellStyle.Padding = new Padding(5);
            //columnas
            dgvDepa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepa.Columns["clCodigo"].FillWeight = 8;
            dgvDepa.Columns["clDepartamento"].FillWeight = 20;
            dgvDepa.Columns["clDescripcion"].FillWeight = 12;
            dgvDepa.Columns["clEmpleados"].FillWeight = 20;
            dgvDepa.Columns["clEstado"].FillWeight = 13;
            dgvDepa.Columns["clEditar"].FillWeight = 8;
            dgvDepa.Columns["clEliminar"].FillWeight = 8;
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvDepa.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvDepa.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //columnas centradas
            string[] columnasCentro = { "clCodigo", "clDepartamento", "clDescripcion", "clEmpleados", "clEstado", "clEditar", "clEliminar"};
            foreach (string columna in columnasCentro)
            {
                dgvDepa.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
