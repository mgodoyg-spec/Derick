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
            /////////////////////////////////////////////////
            dvgInventario.AutoGenerateColumns = false;
            dvgInventario.Columns["clCodigo"].DataPropertyName = "Codigo";
            dvgInventario.Columns["clNombreProducto"].DataPropertyName = "Nombre";
            dvgInventario.Columns["clCategoria"].DataPropertyName = "Categoria";
            dvgInventario.Columns["clTallas"].DataPropertyName = "Talla";
            dvgInventario.Columns["clColores"].DataPropertyName = "Color";
            dvgInventario.Columns["clPrecio"].DataPropertyName = "Precio";
            dvgInventario.Columns["clStock"].DataPropertyName = "Stock";
            dvgInventario.Columns["clEstado"].DataPropertyName = "Estado";
        }

        private void Cargar_Sucursal()
        {
            csConectaSQL conect = new csConectaSQL();

            string query = @"select IdSucursal, NombreSucursal from Sucursales
                           where Estado = 'activa' order by NombreSucursal";

            DataTable dt = conect.RetornaRegistros(query);
            cmb_sucursal.DataSource = dt;
            cmb_sucursal.DisplayMember = "NombreSucursal";
            cmb_sucursal.ValueMember = "IdSucursal";
            cmb_sucursal.SelectedIndex = -1;
        }

        private void Cargar_Inventario()
        {
            if (cmb_sucursal.SelectedIndex == -1)
            {
                dvgInventario.DataSource = null;
                return;
            }
            int idSucursal = Convert.ToInt32(((DataRowView)cmb_sucursal.SelectedItem)["IdSucursal"]);
            string buscar = txt_buscar.Text.Trim();
            string categoria = cmb_categoria.Text.Trim();
            string estado = cmb_estado.Text.Trim();

            string query = @"select P.Codigo, P.Nombre, P.Categoria, I.Talla, I.Color,
                    P.Precio, I.Stock, P.Estado from Inventario I inner join Productos P
                    on I.IdProducto = P.IdProductos where I.IdSucursal = " + idSucursal;

            // buscar por código o nombre
            if (buscar != "")
            {
                buscar = buscar.Replace("'", "''");
                query += @"and (P.Codigo LIKE '%" + buscar + @"%' or P.Nombre LIKE '%" + buscar + @"%')";
            }

            // filtrar por categoria
            if (categoria != "Todas" && categoria != "")
            {
                categoria = categoria.Replace("'", "''");
                query += @"and P.Categoria = '" + categoria + "'";
            }

            // filtrar estado activo
            if (estado == "Activo")
            {
                query += " and P.Estado = 1";
            }

            // filtrar estado inactivo
            if (estado == "Inactivo")
            {
                query += " and P.Estado = 0";
            }
            query += @"order by P.Nombre, I.Talla, I.Color";
            DataTable dt = conect.RetornaRegistros(query);
            if (dt == null)
            {
                return;
            }
            dvgInventario.DataSource = dt;
        }

        private void Cargar_Categorias()
        {
            string query = @"select Nombre from Categorias where Estado = 1 order by Nombre";
            DataTable dt = conect.RetornaRegistros(query);

            // agregar estado todas
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Todas";
            dt.Rows.InsertAt(fila, 0);
            cmb_categoria.DataSource = dt;
            cmb_categoria.DisplayMember = "Nombre";
            cmb_categoria.ValueMember = "Nombre";
            cmb_categoria.SelectedIndex = 0;
        }
        private void dvgInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvgInventario.Columns[e.ColumnIndex].Name == "clEstado")
            {
                if (e.Value != null)
                {
                    bool estado = Convert.ToBoolean(e.Value);
                    if (estado == true)
                    {
                        e.Value = "Activo";
                    }
                    if (estado == false)
                    {
                        e.Value = "Inactivo";
                    }
                    e.FormattingApplied = true;
                }
            }
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

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            FormTransferir_Productos frmTransferir = new FormTransferir_Productos();
            frmTransferir.StartPosition = FormStartPosition.CenterScreen;
            frmTransferir.ShowDialog(this);
            // actualiza el inventario cuando se cierra transferencia
            Cargar_Inventario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            cmb_categoria.SelectedIndex = 0;
            cmb_estado.SelectedIndex = 0;
            if (cmb_sucursal.SelectedIndex != -1)
            {
                Cargar_Inventario();
            }
            txt_buscar.Focus();
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
