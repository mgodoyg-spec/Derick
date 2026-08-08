using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load_1(object sender, EventArgs e)
        {
            cmb_agg1.Items.Add("Todas");
            cmb_agg1.SelectedIndex = 0;
            cmb_agg2.Items.Add("Todos");
            cmb_agg2.SelectedIndex = 0;

            /////////////////////////////////////////////////////////

            dvg_agg.EnableHeadersVisualStyles = false;

            dvg_agg.BorderStyle = BorderStyle.None;
            dvg_agg.BackgroundColor = Color.White;
            dvg_agg.GridColor = Color.FromArgb(235, 235, 235);
            dvg_agg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dvg_agg.ReadOnly = true;
            dvg_agg.MultiSelect = false;
            dvg_agg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dvg_agg.AllowUserToAddRows = false;
            dvg_agg.AllowUserToDeleteRows = false;
            dvg_agg.AllowUserToResizeRows = false;
            dvg_agg.AllowUserToResizeColumns = false;

            dvg_agg.RowHeadersVisible = false;

            dvg_agg.ColumnHeadersHeight = 50;
            dvg_agg.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.None;

            dvg_agg.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(46, 57, 75);

            dvg_agg.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dvg_agg.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dvg_agg.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dvg_agg.RowTemplate.Height = 55;

            dvg_agg.DefaultCellStyle.Font =
            new Font("Segoe UI", 10);

            dvg_agg.DefaultCellStyle.ForeColor =
            Color.FromArgb(45, 45, 45);

            dvg_agg.DefaultCellStyle.BackColor =
            Color.White;

            dvg_agg.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);

            // Selección
            dvg_agg.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(225, 235, 250);

            dvg_agg.DefaultCellStyle.SelectionForeColor =
            Color.Black;

            dvg_agg.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dvg_agg.DefaultCellStyle.Padding =
            new Padding(5);

            dvg_agg.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dvg_agg.Columns["clCodigo"].FillWeight = 18;
            dvg_agg.Columns["clImagen"].FillWeight = 15;
            dvg_agg.Columns["clNombreProducto"].FillWeight = 18;
            dvg_agg.Columns["clCategoria"].FillWeight = 15;
            dvg_agg.Columns["clTallas"].FillWeight = 12;
            dvg_agg.Columns["clColores"].FillWeight = 15;
            dvg_agg.Columns["clPrecio"].FillWeight = 10;
            dvg_agg.Columns["clStock"].FillWeight = 10;
            dvg_agg.Columns["clEstado"].FillWeight = 10;

            dvg_agg.Columns["clEditar"].FillWeight = 7;
            dvg_agg.Columns["clEliminar"].FillWeight = 7;
            dvg_agg.Columns["clVerTodo"].FillWeight = 7;

            // Editar
            DataGridViewImageColumn editar =
            (DataGridViewImageColumn)dvg_agg.Columns["clEditar"];
            editar.Image = img_icons.Images[0];
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Eliminar
            DataGridViewImageColumn eliminar =
            (DataGridViewImageColumn)dvg_agg.Columns["clEliminar"];
            eliminar.Image = img_icons.Images[1];
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // Ver todo
            DataGridViewImageColumn ver =
            (DataGridViewImageColumn)dvg_agg.Columns["clVerTodo"];
            ver.Image = img_icons.Images[2];
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;

            string[] columnasCentro =
            {
                "clCodigo",
                "clImagen",
                "clNombreProducto",
                "clCategoria",
                "clTallas",
                "clColores",
                "clPrecio",
                "clStock",
                "clEstado",
                "clEditar",
                "clEliminar",
                "clVerTodo"
            };

            foreach (string columna in columnasCentro)
            {
                dvg_agg.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            dvg_agg.Rows.Clear();
            dvg_agg.Rows.Add(
                  "P001", null, "Camiseta Oversize", "Camisetas", "S, M, L", "Negro, Blanco",
                  "$25.00", "35", "Activo", null, null, null
            );
        }
        private void dvg_agg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columna = dvg_agg.Columns[e.ColumnIndex].Name;

            if (columna == "clEditar")
            {
                MessageBox.Show("Editar producto");
            }
            else if (columna == "clEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Eliminar producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dvg_agg.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (columna == "clVerTodo")
            {
                MessageBox.Show("Ver información del producto");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormAgg_Product frm_agg = new FormAgg_Product();
            frm_agg.StartPosition = FormStartPosition.CenterScreen;
            frm_agg.ShowDialog(this);
        }
    }
}