using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            C_Proveedor();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void C_Proveedor()
        {
            dgvProveedor.EnableHeadersVisualStyles = false;
            // ==============================
            // CONFIGURACIÓN GENERAL
            // ==============================
            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.GridColor = Color.FromArgb(235, 235, 235);
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ReadOnly = true;
            dgvProveedor.MultiSelect = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.RowHeadersVisible = false;
            // ==============================
            // ENCABEZADOS
            // ==============================
            dgvProveedor.ColumnHeadersHeight = 50;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvProveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProveedor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // ==============================
            // FILAS
            // ==============================
            dgvProveedor.RowTemplate.Height = 55;
            dgvProveedor.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProveedor.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvProveedor.DefaultCellStyle.BackColor = Color.White;
            dgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvProveedor.DefaultCellStyle.Padding = new Padding(5);
            // ==============================
            // SELECCIÓN
            // ==============================
            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvProveedor.DefaultCellStyle.SelectionForeColor = Color.Black;
            // ==============================
            // TAMAÑO DE COLUMNAS
            // ==============================
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.Columns["clId"].FillWeight = 8;
            dgvProveedor.Columns["clNombreProveedor"].FillWeight = 25;
            dgvProveedor.Columns["clContacto"].FillWeight = 20;
            dgvProveedor.Columns["clTelefono"].FillWeight = 15;
            dgvProveedor.Columns["clCorreo"].FillWeight = 25;
            dgvProveedor.Columns["clEstado"].FillWeight = 12;
            dgvProveedor.Columns["clEditar"].FillWeight = 8;
            dgvProveedor.Columns["clEliminar"].FillWeight = 8;
            // ==============================
            // EDITAR
            // ==============================
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvProveedor.Columns["clEditar"];
            editar.Image = imgProveedor.Images[0];
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // ==============================
            // ELIMINAR
            // ==============================
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvProveedor.Columns["clEliminar"];
            eliminar.Image = imgProveedor.Images[1];
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // ==============================
            // CENTRAR COLUMNAS
            // ==============================
            string[] columnasCentro =
            {
                  "clId",
                  "clTelefono",
                  "clEstado",
                  "clEditar",
                  "clEliminar"
            };
            foreach (string columna in columnasCentro)
            {
                dgvProveedor.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // ==============================
            // COLUMNAS A LA IZQUIERDA
            // ==============================
            dgvProveedor.Columns["clNombreProveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clContacto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clCorreo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // ==============================
            // EMPEZAR VACÍO
            // ==============================
            dgvProveedor.Rows.Clear();
        }
        private void CargarProveedores()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT IdProveedor, Nombre, Contacto, Telefono, Correo, Estado " +
                "FROM Proveedores ORDER BY IdProveedor"
            );

            if (dt == null)
                return;

            dgvProveedor.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

                dgvProveedor.Rows.Add(
                    fila["IdProveedor"].ToString(),
                    fila["Nombre"].ToString(),
                    fila["Contacto"].ToString(),
                    fila["Telefono"].ToString(),
                    fila["Correo"].ToString(),
                    estado,
                    null,
                    null
                );
            }
        }

        private void btn_ctg1_Click(object sender, EventArgs e)
        {
            FormAgg_Proveedores frm_aggPR = new FormAgg_Proveedores();
            frm_aggPR.StartPosition = FormStartPosition.CenterScreen;

            if (frm_aggPR.ShowDialog(this) == DialogResult.OK)
            {
                CargarProveedores();
            }
        }
    }
}
