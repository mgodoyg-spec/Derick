using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormCategoria : Form
    {
        private BindingList<Producto> listaproductos = new BindingList<Producto>();
        public FormCategoria()
        {
            InitializeComponent();

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            // ==============================
            // CONFIGURACIÓN GENERAL
            // ==============================

            dgv_catg.EnableHeadersVisualStyles = false;

            dgv_catg.BorderStyle = BorderStyle.None;
            dgv_catg.BackgroundColor = Color.White;
            dgv_catg.GridColor = Color.FromArgb(235, 235, 235);

            dgv_catg.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgv_catg.ReadOnly = true;
            dgv_catg.MultiSelect = false;

            dgv_catg.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv_catg.AllowUserToAddRows = false;
            dgv_catg.AllowUserToDeleteRows = false;
            dgv_catg.AllowUserToResizeRows = false;
            dgv_catg.AllowUserToResizeColumns = false;

            dgv_catg.RowHeadersVisible = false;


            // ==============================
            // ENCABEZADOS
            // ==============================

            dgv_catg.ColumnHeadersHeight = 50;

            dgv_catg.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgv_catg.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(46, 57, 75);

            dgv_catg.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv_catg.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv_catg.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // ==============================
            // FILAS
            // ==============================

            dgv_catg.RowTemplate.Height = 55;

            dgv_catg.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv_catg.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);

            dgv_catg.DefaultCellStyle.BackColor =
                Color.White;

            dgv_catg.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);

            dgv_catg.DefaultCellStyle.Padding =
                new Padding(5);


            // ==============================
            // COLOR DE SELECCIÓN
            // ==============================

            dgv_catg.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 235, 250);

            dgv_catg.DefaultCellStyle.SelectionForeColor =
                Color.Black;


            // ==============================
            // TAMAÑO DE LAS COLUMNAS
            // ==============================

            dgv_catg.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv_catg.Columns["clId"].FillWeight = 10;

            dgv_catg.Columns["clIcono"].FillWeight = 12;

            dgv_catg.Columns["clCategoria"].FillWeight = 22;

            dgv_catg.Columns["clEstado"].FillWeight = 14;

            dgv_catg.Columns["clDescripcion"].FillWeight = 30;

            dgv_catg.Columns["clEditar"].FillWeight = 7;

            dgv_catg.Columns["clEliminar"].FillWeight = 7;


            // ==============================
            // COLUMNA ICONO
            // ==============================

            DataGridViewImageColumn icono =
                (DataGridViewImageColumn)dgv_catg.Columns["clIcono"];

            icono.ImageLayout =
                DataGridViewImageCellLayout.Zoom;


            // ==============================
            // COLUMNA EDITAR
            // ==============================

            DataGridViewImageColumn editar =
                (DataGridViewImageColumn)dgv_catg.Columns["clEditar"];

            editar.Image = img_ctg.Images[0];

            editar.ImageLayout =
                DataGridViewImageCellLayout.Zoom;


            // ==============================
            // COLUMNA ELIMINAR
            // ==============================

            DataGridViewImageColumn eliminar =
                (DataGridViewImageColumn)dgv_catg.Columns["clEliminar"];

            eliminar.Image = img_ctg.Images[1];

            eliminar.ImageLayout =
                DataGridViewImageCellLayout.Zoom;


            // ==============================
            // ALINEACIÓN
            // ==============================

            string[] columnasCentro =
            {
                   "clId",
                   "clIcono",
                   "clCategoria",
                   "clEstado",
                   "clEditar",
                   "clEliminar"
            };

            foreach (string columna in columnasCentro)
            {
                dgv_catg.Columns[columna]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }


            // Descripción alineada a la izquierda
            dgv_catg.Columns["clDescripcion"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;


            // ==============================
            // DATA VACÍO AL INICIAR
            // ==============================

            dgv_catg.Rows.Clear();

            CargarCategorias();
        }
        private void CargarCategorias()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT IdCategoria, Nombre, Descripcion, Estado " +
                "FROM Categorias ORDER BY IdCategoria"
            );

            if (dt == null)
                return;

            dgv_catg.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

                dgv_catg.Rows.Add(
                    fila["IdCategoria"].ToString(),
                    null,                               // Ícono
                    fila["Nombre"].ToString(),
                    estado,
                    fila["Descripcion"].ToString(),
                    null,                               // Editar
                    null                                // Eliminar
                );
            }
        }

        private void btn_ctg1_Click(object sender, EventArgs e)
        {
            FrmAgg_Categoria frnctg = new FrmAgg_Categoria();
            frnctg.StartPosition = FormStartPosition.CenterScreen;
            if (frnctg.ShowDialog(this) == DialogResult.OK)
            {
                CargarCategorias();
            }
        }
    }
}
