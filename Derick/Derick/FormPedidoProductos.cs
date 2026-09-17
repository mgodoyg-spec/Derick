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
    public partial class FormPedidoProductos : Form
    {

        public FormPedidoProductos()
        {
            InitializeComponent();
        }

        private void FormPedidoProductos_Load(object sender, EventArgs e)
        {
            dvg_pedidoProducto.EnableHeadersVisualStyles = false;

            dvg_pedidoProducto.BorderStyle = BorderStyle.None;
            dvg_pedidoProducto.BackgroundColor = Color.White;
            dvg_pedidoProducto.GridColor = Color.FromArgb(235, 235, 235);
            dvg_pedidoProducto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dvg_pedidoProducto.ReadOnly = true;
            dvg_pedidoProducto.MultiSelect = false;
            dvg_pedidoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dvg_pedidoProducto.AllowUserToAddRows = false;
            dvg_pedidoProducto.AllowUserToDeleteRows = false;
            dvg_pedidoProducto.AllowUserToResizeRows = false;
            dvg_pedidoProducto.AllowUserToResizeColumns = false;

            dvg_pedidoProducto.RowHeadersVisible = false;

            dvg_pedidoProducto.ColumnHeadersHeight = 50;
            dvg_pedidoProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dvg_pedidoProducto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dvg_pedidoProducto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dvg_pedidoProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dvg_pedidoProducto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvg_pedidoProducto.RowTemplate.Height = 45;
            dvg_pedidoProducto.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvg_pedidoProducto.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dvg_pedidoProducto.DefaultCellStyle.BackColor = Color.White;
            dvg_pedidoProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);

            // selección
            dvg_pedidoProducto.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dvg_pedidoProducto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dvg_pedidoProducto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvg_pedidoProducto.DefaultCellStyle.Padding = new Padding(5);
            dvg_pedidoProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_pedidoProducto.Columns["clCodigo"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clNombre"].FillWeight = 17;
            dvg_pedidoProducto.Columns["clProveedor"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clTallas"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clColores"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clFechaInicio"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clFechaFinal"].FillWeight = 13;
            dvg_pedidoProducto.Columns["clEstado"].FillWeight = 9;

            dvg_pedidoProducto.Columns["clEditar"].FillWeight = 8;
            dvg_pedidoProducto.Columns["clEliminar"].FillWeight = 8;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dvg_pedidoProducto.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dvg_pedidoProducto.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            string[] columnasCentro =
            {
                  "clCodigo",
                  "clNombre",
                  "clProveedor",
                  "clTallas",
                  "clColores",
                  "clFechaInicio",
                  "clFechaFinal",
                  "clEstado",
                  "clEditar",
                  "clEliminar",
            };

            foreach (string columna in columnasCentro)
            {
                dvg_pedidoProducto.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dvg_pedidoProducto.Rows.Clear();
            Cargar_proveedores();
            Cargar_pedidos();
        }
        private void Cargar_pedidos()
        {
            string sql = @"select P.IdPedido, P.NumeroOrden, P.Producto, PR.Nombre AS Proveedor, P.FechaPedido, P.FechaLlegadaEsperada, P.Estado 
                from Pedidos P inner join Proveedores PR on P.IdProveedor = PR.IdProveedor where 1 = 1";

            // filtro de busqueda
            if (!string.IsNullOrWhiteSpace(txt1.Text))
            {
                string buscar = txt1.Text.Trim().Replace("'", "''");
                sql += @" and (P.NumeroOrden like '%" + buscar + @"%' or P.Producto like '%" + buscar + @"%' 
                  or PR.Nombre like '%" + buscar + @"%')";
            }

            // filtro de proveedor
            if (cmb_proveedor.SelectedIndex > 0)
            {
                int idProveedor = Convert.ToInt32(cmb_proveedor.SelectedValue);
                sql += " and P.IdProveedor = " + idProveedor;
            }

            sql += " order by P.FechaPedido desc";
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);

            dvg_pedidoProducto.Rows.Clear();

            if (dt == null)
            {
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                int idPedido = Convert.ToInt32(fila["IdPedido"]);
                string sqlDetalle = @"select Talla, Color from DetallePedidos where IdPedido = " + idPedido;
                DataTable dtDetalle = conexion.RetornaRegistros(sqlDetalle);

                List<string> tallas = new List<string>();
                List<string> colores = new List<string>();

                foreach (DataRow detalle in dtDetalle.Rows)
                {
                    string talla = detalle["Talla"].ToString();
                    string color = detalle["Color"].ToString();

                    if (!tallas.Contains(talla))
                    {
                        tallas.Add(talla);
                    }

                    if (!colores.Contains(color))
                    {
                        colores.Add(color);
                    }
                }

                int filaNueva = dvg_pedidoProducto.Rows.Add(
                    fila["NumeroOrden"].ToString(),
                    fila["Producto"].ToString(),
                    fila["Proveedor"].ToString(),
                    string.Join(", ", tallas),
                    string.Join(", ", colores),
                    Convert.ToDateTime(fila["FechaPedido"]).ToString("dd/MM/yyyy"),
                    Convert.ToDateTime(fila["FechaLlegadaEsperada"]).ToString("dd/MM/yyyy"),
                    fila["Estado"].ToString()
                );

                dvg_pedidoProducto.Rows[filaNueva].Tag = idPedido;
            }
        }
        private void Cargar_proveedores()
        {
            csConectaSQL conexion = new csConectaSQL();
            string sql = @"select IdProveedor, Nombre from Proveedores where Estado = 1 order by Nombre";
            DataTable dt = conexion.RetornaRegistros(sql);
            cmb_proveedor.DataSource = null;

            if (dt == null)
            {
                return;
            }

            DataRow fila = dt.NewRow();
            fila["IdProveedor"] = 0;
            fila["Nombre"] = "Todos los proveedores";
            dt.Rows.InsertAt(fila, 0);

            cmb_proveedor.DataSource = dt;
            cmb_proveedor.DisplayMember = "Nombre";
            cmb_proveedor.ValueMember = "IdProveedor";
            cmb_proveedor.SelectedIndex = 0;
        }
        private void btn_orden_Click(object sender, EventArgs e)
        {
            FormPedidos frm_pedido = new FormPedidos();
            frm_pedido.StartPosition = FormStartPosition.CenterScreen;

            if (frm_pedido.ShowDialog(this) == DialogResult.OK)
            {
                Cargar_pedidos();
            }
        }

        private void dvg_pedidoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dvg_pedidoProducto.Columns["clEditar"].Index)
            {
                int idPedido = Convert.ToInt32(dvg_pedidoProducto.Rows[e.RowIndex].Tag);

                FormPedidos frm = new FormPedidos(idPedido);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    Cargar_pedidos();
                }
            }

            if (e.ColumnIndex == dvg_pedidoProducto.Columns["clEliminar"].Index)
            {
                int idPedido = Convert.ToInt32(dvg_pedidoProducto.Rows[e.RowIndex].Tag);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este pedido?",
                    "Eliminar pedido",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();

                    string sqlDetalle = "delete from DetallePedidos where IdPedido = @IdPedido";

                    SqlParameter parametroDetalle = new SqlParameter("@IdPedido", idPedido);

                    conexion.ejecutarComando(sqlDetalle, parametroDetalle);

                    string sqlPedido = "delete from Pedidos where IdPedido = @IdPedido";

                    SqlParameter parametroPedido = new SqlParameter("@IdPedido", idPedido);

                    bool eliminado = conexion.ejecutarComando(sqlPedido, parametroPedido);

                    if (eliminado)
                    {
                        MessageBox.Show("Pedido eliminado correctamente.");
                        Cargar_pedidos();
                    }
                }
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

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            Cargar_pedidos();
        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_proveedor.SelectedIndex >= 0)
            {
                Cargar_pedidos();
            }
        }
    }
}
