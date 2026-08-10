using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormPromociones : Form
    {
        public FormPromociones()
        {
            InitializeComponent();
        }

        private void FormPromociones_Load(object sender, EventArgs e)
        {
            Edt();
        }
        private void Edt()
        {
            dgvPromociones.EnableHeadersVisualStyles = false;
            // ==============================
            // CONFIGURACIÓN GENERAL
            // ==============================
            dgvPromociones.BorderStyle = BorderStyle.None;
            dgvPromociones.BackgroundColor = Color.White;
            dgvPromociones.GridColor = Color.FromArgb(235, 235, 235);
            dgvPromociones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPromociones.ReadOnly = true;
            dgvPromociones.MultiSelect = false;
            dgvPromociones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromociones.AllowUserToAddRows = false;
            dgvPromociones.AllowUserToDeleteRows = false;
            dgvPromociones.AllowUserToResizeRows = false;
            dgvPromociones.AllowUserToResizeColumns = false;
            dgvPromociones.RowHeadersVisible = false;
            // ==============================
            // ENCABEZADOS
            // ==============================
            dgvPromociones.ColumnHeadersHeight = 50;
            dgvPromociones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPromociones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvPromociones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPromociones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPromociones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // ==============================
            // FILAS
            // ==============================
            dgvPromociones.RowTemplate.Height = 55;
            dgvPromociones.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPromociones.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvPromociones.DefaultCellStyle.BackColor = Color.White;
            dgvPromociones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvPromociones.DefaultCellStyle.Padding = new Padding(5);
            // ==============================
            // SELECCIÓN
            // ==============================
            dgvPromociones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvPromociones.DefaultCellStyle.SelectionForeColor = Color.Black;
            // ==============================
            // TAMAÑO DE COLUMNAS
            // ==============================
            dgvPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromociones.Columns["clId"].FillWeight = 8;
            dgvPromociones.Columns["clNombrePromocion"].FillWeight = 20;
            dgvPromociones.Columns["clTipo"].FillWeight = 13;
            dgvPromociones.Columns["clDescuento"].FillWeight = 12;
            dgvPromociones.Columns["clFechaInicio"].FillWeight = 14;
            dgvPromociones.Columns["clFechaFin"].FillWeight = 14;
            dgvPromociones.Columns["clEstado"].FillWeight = 12;
            dgvPromociones.Columns["clDescripcion"].FillWeight = 25;
            dgvPromociones.Columns["clEditar"].FillWeight = 7;
            dgvPromociones.Columns["clEliminar"].FillWeight = 7;
            // ==============================
            // EDITAR
            // ==============================
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvPromociones.Columns["clEditar"];
            editar.Image = img_promociones.Images[0];
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // ==============================
            // ELIMINAR
            // ==============================
            DataGridViewImageColumn eliminar =(DataGridViewImageColumn)dgvPromociones.Columns["clEliminar"];
            eliminar.Image = img_promociones.Images[1];
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // ==============================
            // CENTRAR COLUMNAS
            // ==============================
            string[] columnasCentro =
            {
                "clId",
                "clNombrePromocion",
                "clTipo",
                "clDescuento",
                "clFechaInicio",
                "clFechaFin",
                "clEstado",
                "clEditar",
                "clEliminar"
            };
            foreach (string columna in columnasCentro)
            {
                dgvPromociones.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // Descripción a la izquierda
            dgvPromociones.Columns["clDescripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // ==============================
            // EMPEZAR VACÍO
            // ==============================
            dgvPromociones.Rows.Clear();
        }
    }
}
