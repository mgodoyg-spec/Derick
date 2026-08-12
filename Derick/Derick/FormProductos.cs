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
            CargarCategoriasFiltro();
            CargarEstadosFiltro();

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

            dvg_agg.RowTemplate.Height = 45;

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

            dvg_agg.Columns["clCodigo"].FillWeight = 8;
            dvg_agg.Columns["clImagen"].FillWeight = 12;
            dvg_agg.Columns["clNombreProducto"].FillWeight = 20;
            dvg_agg.Columns["clCategoria"].FillWeight = 12;
            dvg_agg.Columns["clTallas"].FillWeight = 20;
            dvg_agg.Columns["clColores"].FillWeight = 13;
            dvg_agg.Columns["clPrecio"].FillWeight = 18;
            dvg_agg.Columns["clStock"].FillWeight = 10;
            dvg_agg.Columns["clEstado"].FillWeight = 8;

            dvg_agg.Columns["clEditar"].FillWeight = 8;
            dvg_agg.Columns["clEliminar"].FillWeight = 8;
            dvg_agg.Columns["clVerTodo"].FillWeight = 8;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dvg_agg.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar =(DataGridViewImageColumn)dvg_agg.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn ver = (DataGridViewImageColumn)dvg_agg.Columns["clVerTodo"];
            ver.Image = Properties.Resources.ojo;
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
            CargarProductos();
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
        private void CargarProductos()
        {
            csConectaSQL conexion = new csConectaSQL();

            string sql = @"
                  SELECT 
                  Codigo,
                  Nombre,
                  Categoria,
                  Talla,
                  Color,
                  Precio,
                  Estado
                  FROM Productos";

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
                return;

            dvg_agg.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

                decimal precio = Convert.ToDecimal(fila["Precio"]);

                dvg_agg.Rows.Add(
                    fila["Codigo"].ToString(),
                    null,
                    fila["Nombre"].ToString(),
                    fila["Categoria"].ToString(),
                    fila["Talla"].ToString(),
                    fila["Color"].ToString(),
                    "$" + precio.ToString("0.00"),
                    "0",
                    estado,
                    null,
                    null,
                    null
                );
            }
        }
        private void FiltrarProductos()
        {
            string texto = txt1.Text.Trim();
            string categoria = cmb_agg1.Text.Trim();
            string estado = cmb_agg2.Text.Trim();

            string sql = @"
        SELECT
            Codigo,
            Nombre,
            Categoria,
            Talla,
            Color,
            Precio,
            Estado
        FROM Productos
        WHERE 1 = 1
    ";

            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql += $" AND (Codigo LIKE '%{texto}%' OR Nombre LIKE '%{texto}%')";
            }

            if (categoria != "Todas" && !string.IsNullOrWhiteSpace(categoria))
            {
                sql += $" AND Categoria = '{categoria}'";
            }

            if (estado != "Todos" && !string.IsNullOrWhiteSpace(estado))
            {
                if (estado == "Activo")
                    sql += " AND Estado = 1";
                else if (estado == "Inactivo")
                    sql += " AND Estado = 0";
            }

            sql += " ORDER BY Codigo";

            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
                return;

            dvg_agg.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto =
                    Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

                decimal precio = Convert.ToDecimal(fila["Precio"]);

                dvg_agg.Rows.Add(
                    fila["Codigo"].ToString(),
                    null,
                    fila["Nombre"].ToString(),
                    fila["Categoria"].ToString(),
                    fila["Talla"].ToString(),
                    fila["Color"].ToString(),
                    "$" + precio.ToString("0.00"),
                    "0",
                    estadoTexto,
                    null,
                    null,
                    null
                );
            }
        }
        private void CargarCategoriasFiltro()
        {
            cmb_agg1.Items.Clear();
            cmb_agg1.Items.Add("Todas");

            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT Nombre FROM Categorias ORDER BY Nombre"
            );

            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    cmb_agg1.Items.Add(
                        fila["Nombre"].ToString()
                    );
                }
            }

            cmb_agg1.SelectedIndex = 0;
        }
        private void CargarEstadosFiltro()
        {
            cmb_agg2.Items.Clear();

            cmb_agg2.Items.Add("Todos");
            cmb_agg2.Items.Add("Activo");
            cmb_agg2.Items.Add("Inactivo");

            cmb_agg2.SelectedIndex = 0;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            cmb_agg1.SelectedIndex = 0;
            cmb_agg2.SelectedIndex = 0;
            CargarProductos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAgg_Product frm_agg = new FormAgg_Product();
            frm_agg.StartPosition = FormStartPosition.CenterScreen;
            frm_agg.ShowDialog(this);
            CargarProductos();
        }
    }
}