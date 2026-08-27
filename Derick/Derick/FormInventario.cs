using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormInventario : Form
    {
        csConectaSQL conect = new csConectaSQL();
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            dvgInventario.EnableHeadersVisualStyles = false;

            dvgInventario.BorderStyle = BorderStyle.None;
            dvgInventario.BackgroundColor = Color.White;
            dvgInventario.GridColor = Color.FromArgb(235, 235, 235);
            dvgInventario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dvgInventario.ReadOnly = true;
            dvgInventario.MultiSelect = false;
            dvgInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dvgInventario.AllowUserToAddRows = false;
            dvgInventario.AllowUserToDeleteRows = false;
            dvgInventario.AllowUserToResizeRows = false;
            dvgInventario.AllowUserToResizeColumns = false;

            dvgInventario.RowHeadersVisible = false;

            dvgInventario.ColumnHeadersHeight = 50;
            dvgInventario.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.None;

            dvgInventario.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(46, 57, 75);

            dvgInventario.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dvgInventario.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dvgInventario.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dvgInventario.RowTemplate.Height = 45;

            dvgInventario.DefaultCellStyle.Font =
            new Font("Segoe UI", 10);

            dvgInventario.DefaultCellStyle.ForeColor =
            Color.FromArgb(45, 45, 45);

            dvgInventario.DefaultCellStyle.BackColor =
            Color.White;

            dvgInventario.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 251);

            // Selección
            dvgInventario.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(225, 235, 250);

            dvgInventario.DefaultCellStyle.SelectionForeColor =
            Color.Black;

            dvgInventario.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dvgInventario.DefaultCellStyle.Padding =
            new Padding(5);

            dvgInventario.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dvgInventario.Columns["clCodigo"].FillWeight = 13;
            dvgInventario.Columns["clImagen"].FillWeight = 10;
            dvgInventario.Columns["clNombreProducto"].FillWeight = 17;
            dvgInventario.Columns["clCategoria"].FillWeight = 13;
            dvgInventario.Columns["clTallas"].FillWeight = 9;
            dvgInventario.Columns["clColores"].FillWeight = 11;
            dvgInventario.Columns["clPrecio"].FillWeight = 9;
            dvgInventario.Columns["clStock"].FillWeight = 8;
            dvgInventario.Columns["clEstado"].FillWeight = 9;

            DataGridViewImageColumn imagenProducto = (DataGridViewImageColumn)dvgInventario.Columns["clImagen"];
            imagenProducto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagenProducto.DefaultCellStyle.Padding = new Padding(8);

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
            };

            foreach (string columna in columnasCentro)
            {
                dvgInventario.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            //////////////////////////////////////////////////
            //Tipo de estado
            cmb_estado.Items.Clear();
            cmb_estado.Items.Add("Todos");
            cmb_estado.Items.Add("Activo");
            cmb_estado.Items.Add("Inactivo");
            cmb_estado.SelectedIndex = 0;
            /////////////////////////////////////////////////
            //Cargar los datos de los comboBox
            Cargar_Categorias();
            Cargar_Sucursal();
        }

        private void Cargar_Sucursal()
        {
            csConectaSQL conect = new csConectaSQL();

            string query = @"select IdSucursal, NombreSucursal from Sucursales
                           where Estado = 'activo' order by NombreSucursal";

            DataTable dt = conect.RetornaRegistros(query);
            cmb_sucursal.DataSource = dt;
            cmb_sucursal.DisplayMember = "NombreSucursal";
            cmb_sucursal.ValueMember = "IdSucursal";
            cmb_sucursal.SelectedIndex = -1;
        }

        private void Cargar_Inventario()
        {
            if (cmb_sucursal.SelectedIndex == -1 || cmb_categoria.SelectedIndex == null)
            {
                return;
            }

            string buscar = txt_buscar.Text.Trim();
            string estado = cmb_estado.Text;
            int idSucursal = Convert.ToInt32(cmb_sucursal.SelectedValue);
            int idCategoria = Convert.ToInt32(cmb_categoria.SelectedValue);

            string query = @"select p.Codigo, p.Nombre, p.Categoria, .Talla,
                           i.Color, p.Precio, i.Stock, p.Estado from Inventario i
                           inner join Productos p on i.IdProducto = p.IdProducto
                           where i.IdSucursal = " + idSucursal + @"
                           and( p.Codigo LIKE '%" + buscar + @"%' or p.Nombre LIKE '%" + buscar + @"%')";
            // FILTRO DE ESTADO
            if (estado != "Todos" && estado != "")
            {
                query += " AND p.Estado = '" + estado + "'";
            }
            // FILTRO DE CATEGORÍA
            if (idCategoria != 0)
            {
                query += " AND p.IdCategoria = " + idCategoria;
            }

            dvgInventario.DataSource = conect.RetornaRegistros(query);
        }

        private void Cargar_Categorias()
        {
            string query = "select IdCategoria, NombreCategoria from Categorias " +
                           "where Estado = 'activo' order by NombreCategoria";
            DataTable dt = conect.RetornaRegistros(query);

            DataRow fila = dt.NewRow();
            fila["IdCategoria"] = 0;
            fila["NombreCategoria"] = "Todas";
            dt.Rows.InsertAt(fila, 0);

            cmb_categoria.DataSource = dt;
            cmb_categoria.DisplayMember = "NombreCategoria";
            cmb_categoria.ValueMember = "IdCategoria";
            cmb_categoria.SelectedIndex = 0;
        }

        private void cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
                Cargar_Inventario();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Inventario();
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Inventario();
        }
        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Inventario();
        }
    }
}
