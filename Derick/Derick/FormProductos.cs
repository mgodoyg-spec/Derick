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
        csConectaSQL conect = new csConectaSQL();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load_1(object sender, EventArgs e)
        {
            CargarCategoriasFiltro();
            CargarEstadosFiltro();
            CargarSucursales();


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

            // selección
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
                dvg_agg.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dvg_agg.Rows.Clear();
        }
        private void CargarSucursales()
        {
            string query = @"select IdSucursal, NombreSucursal from Sucursales
                where Estado = 'Activa' order by NombreSucursal";

            DataTable dt = conect.RetornaRegistros(query);

            if (dt == null)
            {
                return;
            }

            cmb_sucursal.DataSource = dt;
            cmb_sucursal.DisplayMember = "NombreSucursal";
            cmb_sucursal.ValueMember = "IdSucursal";
            cmb_sucursal.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            dvg_agg.Rows.Clear();
            if (cmb_sucursal.SelectedIndex == -1)
            {
                return;
            }

            DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            csConectaSQL conexion = new csConectaSQL();

            string consulta = @"select P.IdProductos, P.Codigo, P.Nombre, P.Categoria,
                   I.Talla, I.Color, P.Precio, I.Stock, I.Estado, (select top 1 Imagen from ProductoImagenes
                   where IdProductos = P.IdProductos order by EsPrincipal desc, IdImagen) as Imagen
                   from Inventario I inner join Productos P on I.IdProducto = P.IdProductos
                   where I.IdSucursal = " + idSucursal;

            // filtro de busqueda
            if (!string.IsNullOrWhiteSpace(txt1.Text))
            {
                string buscar = txt1.Text.Trim().Replace("'", "''");

                consulta += @" and (P.Codigo like '%" + buscar + @"%' or P.Nombre like '%" + buscar + @"%')";
            }

            // filtro de categoria
            if (cmb_agg1.SelectedIndex > 0)
            {
                string categoria = cmb_agg1.Text.Trim().Replace("'", "''");

                consulta += " and P.Categoria = '" + categoria + "'";
            }

            // filtro de estado
            if (cmb_agg2.Text == "Activo")
            {
                consulta += " and I.Estado = 1";
            }

            if (cmb_agg2.Text == "Inactivo")
            {
                consulta += " and I.Estado = 0";
            }

            consulta += " order by P.Nombre, I.Talla, I.Color";
            DataTable dt = conexion.RetornaRegistros(consulta);

            if (dt == null)
            {
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                int posicion = dvg_agg.Rows.Add();

                DataGridViewRow row = dvg_agg.Rows[posicion];

                row.Tag = Convert.ToInt32(fila["IdProductos"]);

                row.Cells["clCodigo"].Value = fila["Codigo"].ToString();
                row.Cells["clNombreProducto"].Value = fila["Nombre"].ToString();
                row.Cells["clCategoria"].Value = fila["Categoria"].ToString();
                row.Cells["clTallas"].Value = fila["Talla"].ToString();
                row.Cells["clColores"].Value = fila["Color"].ToString();
                row.Cells["clPrecio"].Value = Convert.ToDecimal(fila["Precio"]).ToString("0.00");
                row.Cells["clStock"].Value = Convert.ToInt32(fila["Stock"]);

                bool estado = Convert.ToBoolean(fila["Estado"]);

                if (estado)
                {
                    row.Cells["clEstado"].Value = "Activo";
                }

                if (!estado)
                {
                    row.Cells["clEstado"].Value = "Inactivo";
                }

                if (fila["Imagen"] != DBNull.Value)
                {
                    byte[] imagenBytes = (byte[])fila["Imagen"];

                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        using (Image imagenTemporal = Image.FromStream(ms))
                        {
                            row.Cells["clImagen"].Value = new Bitmap(imagenTemporal);
                        }
                    }
                }
            }
        }
        private void CargarCategoriasFiltro()
        {
            cmb_agg1.Items.Clear();
            cmb_agg1.Items.Add("Todas");

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select Nombre from Categorias order by Nombre");
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    cmb_agg1.Items.Add(fila["Nombre"].ToString());
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
        private void dvg_agg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string columna = dvg_agg.Columns[e.ColumnIndex].Name;

            if (columna == "clEditar")
            {
                // valida que se haya seleccionado una sucursal
                if (cmb_sucursal.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione primero una sucursal.",
                        "Sucursal obligatoria",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmb_sucursal.Focus();
                    return;
                }

                // obtiene el producto seleccionado
                int idProducto = Convert.ToInt32(dvg_agg.Rows[e.RowIndex].Tag);

                // obtiene talla y color de la fila seleccionada
                string talla = dvg_agg.Rows[e.RowIndex].Cells["clTallas"].Value?.ToString() ?? "";
                string color = dvg_agg.Rows[e.RowIndex].Cells["clColores"].Value?.ToString() ?? "";

                // obtiene los datos de la sucursal seleccionada
                DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;

                int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
                string nombreSucursal = filaSucursal["NombreSucursal"].ToString();

                // abre editar producto enviando producto, sucursal, talla y color
                FormAgg_Product frm = new FormAgg_Product(idProducto, idSucursal, nombreSucursal, talla, color);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarProductos();
                }
            }

            if (columna == "clEliminar")
            {
                // valida que se haya seleccionado una sucursal
                if (cmb_sucursal.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione primero una sucursal.",
                        "Sucursal obligatoria",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmb_sucursal.Focus();
                    return;
                }

                // obtiene el producto seleccionado
                int idProducto = Convert.ToInt32(dvg_agg.Rows[e.RowIndex].Tag);
                string nombreProducto = dvg_agg.Rows[e.RowIndex].Cells["clNombreProducto"].Value?.ToString() ?? "";

                // obtiene talla y color de la fila seleccionada
                string talla = dvg_agg.Rows[e.RowIndex].Cells["clTallas"].Value?.ToString() ?? "";
                string color = dvg_agg.Rows[e.RowIndex].Cells["clColores"].Value?.ToString() ?? "";

                // obtiene la sucursal seleccionada
                DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;
                int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
                string nombreSucursal = filaSucursal["NombreSucursal"].ToString();

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar \"" +
                    nombreProducto + "\" talla \"" +
                    talla + "\" color \"" +
                    color + "\" de la sucursal \"" +
                    nombreSucursal + "\"?",
                    "Eliminar producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();

                    // elimina solamente la talla y color seleccionados
                    bool eliminado = conexion.ejecutarComando(@"delete from Inventario
                        where IdProducto = @IdProducto and IdSucursal = @IdSucursal
                        and Talla = @Talla and Color = @Color",
                        new SqlParameter("@IdProducto", idProducto),
                        new SqlParameter("@IdSucursal", idSucursal),
                        new SqlParameter("@Talla", talla),
                        new SqlParameter("@Color", color)
                    );

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Producto eliminado correctamente de la sucursal.",
                            "Producto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarProductos();
                    }

                    if (!eliminado)
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el producto de la sucursal.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }

            if (columna == "clVerTodo")
            {
                // valida que se haya seleccionado una sucursal
                if (cmb_sucursal.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione primero una sucursal.",
                        "Sucursal obligatoria",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmb_sucursal.Focus();
                    return;
                }

                // obtiene el producto seleccionado
                int idProducto = Convert.ToInt32(dvg_agg.Rows[e.RowIndex].Tag);

                // obtiene la sucursal seleccionada
                DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;
                int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);

                // obtiene la talla y color de la fila seleccionada
                string talla = dvg_agg.Rows[e.RowIndex].Cells["clTallas"].Value?.ToString() ?? "";
                string color = dvg_agg.Rows[e.RowIndex].Cells["clColores"].Value?.ToString() ?? "";

                // abre los detalles del producto
                FrmDetalleTodo1 frm = new FrmDetalleTodo1(idProducto, idSucursal, talla, color);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void cmb_agg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void cmb_agg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            cmb_agg1.SelectedIndex = 0;
            cmb_agg2.SelectedIndex = 0;
            if (cmb_sucursal.SelectedIndex != -1)
            {
                CargarProductos();
            }
            txt1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // valida que se haya seleccionado una sucursal
            if (cmb_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione primero una sucursal.",
                    "Sucursal obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmb_sucursal.Focus();
                return;
            }

            // obtiene los datos de la sucursal seleccionada
            DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            string nombreSucursal = filaSucursal["NombreSucursal"].ToString();

            // abre agregar producto enviando la sucursal
            FormAgg_Product frm_agg = new FormAgg_Product(idSucursal, nombreSucursal);
            frm_agg.StartPosition = FormStartPosition.CenterScreen;
            if (frm_agg.ShowDialog(this) == DialogResult.OK)
            {
                CargarProductos();
            }
        }
        private void btn_transferir_Click(object sender, EventArgs e)
        {
            // valida que se haya seleccionado una sucursal
            if (cmb_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione primero una sucursal.",
                    "Sucursal obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_sucursal.Focus();
                return;
            }

            // obtiene la sucursal seleccionada
            DataRowView filaSucursal = (DataRowView)cmb_sucursal.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);

            // abre el formulario de transferencia
            FormTransferir_Productos frmTransferir = new FormTransferir_Productos(idSucursal);
            frmTransferir.StartPosition = FormStartPosition.CenterScreen;

            if (frmTransferir.ShowDialog(this) == DialogResult.OK)
            {
                CargarProductos();
            }
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
    }
}