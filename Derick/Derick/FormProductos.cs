using Microsoft.Data.SqlClient;
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

            dvg_agg.Columns["clCodigo"].FillWeight = 13;
            dvg_agg.Columns["clImagen"].FillWeight = 10;
            dvg_agg.Columns["clNombreProducto"].FillWeight = 17;
            dvg_agg.Columns["clCategoria"].FillWeight = 13;
            dvg_agg.Columns["clTallas"].FillWeight = 9;
            dvg_agg.Columns["clColores"].FillWeight = 11;
            dvg_agg.Columns["clPrecio"].FillWeight = 9;
            dvg_agg.Columns["clStock"].FillWeight = 8;
            dvg_agg.Columns["clEstado"].FillWeight = 9;

            dvg_agg.Columns["clEditar"].FillWeight = 8;
            dvg_agg.Columns["clEliminar"].FillWeight = 8;
            dvg_agg.Columns["clVerTodo"].FillWeight = 8;

            DataGridViewImageColumn imagenProducto = (DataGridViewImageColumn)dvg_agg.Columns["clImagen"];
            imagenProducto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenProducto.DefaultCellStyle.Padding = new Padding(8);

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dvg_agg.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dvg_agg.Columns["clEliminar"];
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columna = dvg_agg.Columns[e.ColumnIndex].Name;

            if (columna == "clEditar")
            {
                int idProducto =
                    Convert.ToInt32(
                        dvg_agg.Rows[e.RowIndex].Tag
                    );

                FormAgg_Product frm =
                    new FormAgg_Product(idProducto);

                frm.StartPosition =
                    FormStartPosition.CenterScreen;

                DialogResult resultado =
                    frm.ShowDialog(this);

                // comprueba que tiene sql para editar
                csConectaSQL conexion = new csConectaSQL();

                DataTable dt = conexion.RetornaRegistros("select Estado " +
                    "from Productos " + "where IdProductos = " + idProducto);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bool activo = Convert.ToBoolean(dt.Rows[0]["Estado"]);
                    string estadoTexto = activo ? "Activo" : "Inactivo";

                    // ACTUALIZAR DIRECTAMENTE LA CELDA
                    dvg_agg.Rows[e.RowIndex].Cells["clEstado"].Value = estadoTexto;
                    dvg_agg.InvalidateCell(dvg_agg.Columns["clEstado"].Index,e.RowIndex);
                    dvg_agg.Refresh();
                }
            }
            else if (columna == "clEliminar")
            {
                int idProducto = Convert.ToInt32(dvg_agg.Rows[e.RowIndex].Tag);
                string nombreProducto = dvg_agg.Rows[e.RowIndex].Cells["clNombreProducto"].Value?.ToString() ?? "";

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar el producto \"" +
                    nombreProducto + "\"?",
                    "Eliminar producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();

                    bool eliminado = conexion.ejecutarComando(
                        "update Productos set Estado = 0 where IdProductos = @id",
                        new SqlParameter("@id", idProducto)
                    );

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Producto eliminado correctamente.",
                            "Producto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarProductos();
                    }
                }
            }
            else if (columna == "clVerTodo")
            {
                int idProducto = Convert.ToInt32(dvg_agg.Rows[e.RowIndex].Tag);
                FrmDetalleTodo1 frm = new FrmDetalleTodo1(idProducto);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);
            }
        }
        private void CargarProductos()
        {
            csConectaSQL conexion = new csConectaSQL();

            string sql = @"select P.IdProductos, P.Codigo, P.Nombre, P.Categoria,
                P.Talla, P.Color, P.Precio, P.Estado, ISNULL((
                select sum(I.Stock) from Inventario I
                where I.IdProducto = P.IdProductos), 0) as StockTotal,
                PI.Imagen from Productos P outer apply(
                select top 1 Imagen from ProductoImagenes where IdProductos = P.IdProductos
                and EsPrincipal = 1 order by IdImagen) pi order by P.Codigo";

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
            {
                return;
            }
            dvg_agg.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"]) ? "Activo" : "Inactivo";
                decimal precio = Convert.ToDecimal(fila["Precio"]);
                int stockTotal = Convert.ToInt32(fila["StockTotal"]);
                Image imagenProducto = null;
                if (fila["Imagen"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])fila["Imagen"];
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        using (Image temp = Image.FromStream(ms))
                        {
                            imagenProducto = new Bitmap(temp);
                        }
                    }
                }

                int indice = dvg_agg.Rows.Add(
                    fila["Codigo"].ToString(),
                    imagenProducto,
                    fila["Nombre"].ToString(),
                    fila["Categoria"].ToString(),
                    fila["Talla"].ToString(),
                    fila["Color"].ToString(),
                    "$" + precio.ToString("0.00"),
                    stockTotal,
                    estado,
                    null,
                    null,
                    null
                );

                dvg_agg.Rows[indice].Tag = Convert.ToInt32(fila["IdProductos"]);
            }
        }
        private void FiltrarProductos()
        {
            string texto = txt1.Text.Trim();
            string categoria = cmb_agg1.Text.Trim();
            string estado = cmb_agg2.Text.Trim();

            string sql = @"select P.IdProductos, P.Codigo, P.Nombre, P.Categoria,
                P.Talla, P.Color, P.Precio, P.Estado, ISNULL(
                (select sum(I.Stock) from Inventario I where I.IdProducto = P.IdProductos), 0
                ) as StockTotal, PI.Imagen from Productos P outer apply (
                select top 1 Imagen from ProductoImagenes where IdProductos = P.IdProductos
                and EsPrincipal = 1 order by IdImagen) pi where 1 = 1";

            // BUSCAR POR CÓDIGO O NOMBRE
            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql += $" AND (P.Codigo LIKE '%{texto}%' " + $"OR P.Nombre LIKE '%{texto}%')";
            }

            // FILTRAR POR CATEGORÍA
            if (categoria != "Todas" && !string.IsNullOrWhiteSpace(categoria))
            {
                sql += $" AND P.Categoria = '{categoria}'";
            }
            // FILTRAR POR ESTADO
            if (estado != "Todos" && !string.IsNullOrWhiteSpace(estado))
            {
                if (estado == "Activo")
                {
                    sql += " AND P.Estado = 1";
                }
                else if (estado == "Inactivo")
                {
                    sql += " AND P.Estado = 0";
                }
            }
            sql += " ORDER BY P.Codigo";
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);
            if (dt == null)
            {
                return;
            }
            dvg_agg.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto = Convert.ToBoolean(fila["Estado"]) ? "Activo" : "Inactivo";
                decimal precio = Convert.ToDecimal(fila["Precio"]);
                int stockTotal = Convert.ToInt32(fila["StockTotal"]);
                Image imagenProducto = null;

                if (fila["Imagen"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])fila["Imagen"];
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        using (Image temp = Image.FromStream(ms))
                        {
                            imagenProducto = new Bitmap(temp);
                        }
                    }
                }
                int indice = dvg_agg.Rows.Add(
                        fila["Codigo"].ToString(),
                        imagenProducto,
                        fila["Nombre"].ToString(),
                        fila["Categoria"].ToString(),
                        fila["Talla"].ToString(),
                        fila["Color"].ToString(),
                        "$" + precio.ToString("0.00"),
                        stockTotal,
                        estadoTexto,
                        null,
                        null,
                        null);
                dvg_agg.Rows[indice].Tag = Convert.ToInt32(fila["IdProductos"]);
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
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmb_agg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmb_agg2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
               MessageBox.Show(
               "¿Está seguro de salir?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInventario formInventario = new FormInventario();
            formInventario.StartPosition = FormStartPosition.CenterScreen;
            formInventario.ShowDialog(this);
        }
    }
}