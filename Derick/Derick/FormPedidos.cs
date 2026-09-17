using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormPedidos : Form
    {
        private List<DetalleStock> detallesStock = new List<DetalleStock>();
        private int totalStock = 0;
        private int idPedidoEditar = 0;
        private bool modoEditar = false;
        private int idSucursalSeleccionada;

        public FormPedidos()
        {
            InitializeComponent();
        }
        public FormPedidos(int idPedido)
        {
            InitializeComponent();

            idPedidoEditar = idPedido;
            modoEditar = true;
        }
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            Cargar_proveedor();
            Cargar_sucursales();
            Cargar_talla();
            Cargar_color();

            dtp_fechaInicio.MinDate = DateTime.Today;
            dtp_fechaFin.MinDate = dtp_fechaInicio.Value.Date;

            if (modoEditar)
            {
                Cargar_pedido();
            }
        }
        public void Cargar_proveedor()
        {
            string sql = "select IdProveedor, Nombre from Proveedores where Estado = 1";
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);

            DataRow fila = dt.NewRow();
            fila["IdProveedor"] = 0;
            fila["Nombre"] = "Seleccione un proveedor";
            dt.Rows.InsertAt(fila, 0);

            cmb_proveedor.DataSource = dt;
            cmb_proveedor.DisplayMember = "Nombre";
            cmb_proveedor.ValueMember = "IdProveedor";
            cmb_proveedor.SelectedIndex = 0;
        }
        private void Cargar_pedido()
        {
            string sql = @"select IdProveedor, IdSucursal, Producto, FechaLlegadaEsperada, Observacion
                   from Pedidos
                   where IdPedido = " + idPedidoEditar;

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el pedido.");
                return;
            }

            DataRow fila = dt.Rows[0];

            // cargar proveedor
            cmb_proveedor.SelectedValue = Convert.ToInt32(fila["IdProveedor"]);

            // cargar sucursal
            if (fila["IdSucursal"] != DBNull.Value)
            {
                cmb_sucursal.SelectedValue = Convert.ToInt32(fila["IdSucursal"]);
            }
            else
            {
                cmb_sucursal.SelectedIndex = 0;
            }

            // cargar producto
            txt_producto.Text = fila["Producto"].ToString();

            // cargar fecha
            dtp_fechaFin.Value = Convert.ToDateTime(fila["FechaLlegadaEsperada"]);

            // cargar observación
            txt_observacion.Text = fila["Observacion"].ToString();

            // cargar detalles del pedido
            string sqlDetalle = @"select Talla, Color, Cantidad
                          from DetallePedidos
                          where IdPedido = " + idPedidoEditar;

            DataTable dtDetalle = conexion.RetornaRegistros(sqlDetalle);

            detallesStock.Clear();
            totalStock = 0;

            List<string> tallas = new List<string>();
            List<string> colores = new List<string>();

            foreach (DataRow detalle in dtDetalle.Rows)
            {
                DetalleStock nuevoDetalle = new DetalleStock();

                nuevoDetalle.Talla = detalle["Talla"].ToString();
                nuevoDetalle.Color = detalle["Color"].ToString();
                nuevoDetalle.stock = Convert.ToInt32(detalle["Cantidad"]);

                detallesStock.Add(nuevoDetalle);
                totalStock += nuevoDetalle.stock;

                if (!tallas.Contains(nuevoDetalle.Talla))
                {
                    tallas.Add(nuevoDetalle.Talla);
                }

                if (!colores.Contains(nuevoDetalle.Color))
                {
                    colores.Add(nuevoDetalle.Color);
                }
            }

            // marcar tallas
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    if (tallas.Contains(item.Text))
                    {
                        item.Checked = true;
                    }
                }
            }

            // marcar colores
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    if (colores.Contains(item.Text))
                    {
                        item.Checked = true;
                    }
                }
            }

            // mostrar tallas y colores
            if (tallas.Count > 0)
            {
                lbl_tallas.Text = string.Join(", ", tallas);
            }

            if (colores.Count > 0)
            {
                lbl_color.Text = string.Join(", ", colores);
            }

            // mostrar cantidad total
            btn_abr.Text = totalStock + " unidades";
        }
        private void Cargar_sucursales()
        {
            csConectaSQL conect = new csConectaSQL();

            string query = @"select IdSucursal, NombreSucursal from Sucursales
           where Estado = 'Activa'
           order by NombreSucursal";

            DataTable dt = conect.RetornaRegistros(query);

            if (dt == null)
            {
                return;
            }

            DataRow fila = dt.NewRow();
            fila["IdSucursal"] = 0;
            fila["NombreSucursal"] = "Seleccione una sucursal";
            dt.Rows.InsertAt(fila, 0);

            cmb_sucursal.DataSource = dt;
            cmb_sucursal.DisplayMember = "NombreSucursal";
            cmb_sucursal.ValueMember = "IdSucursal";
            cmb_sucursal.SelectedIndex = 0;
        }
        private void Cargar_talla()
        {
            cmTallas.Items.Clear();
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select Nombre from Tallas order by IdTalla");
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    string talla = fila["Nombre"].ToString();
                    ToolStripMenuItem item = new ToolStripMenuItem(talla);
                    item.CheckOnClick = true;
                    item.CheckedChanged += Talla_CheckedChanged;
                    cmTallas.Items.Add(item);
                }
            }
            cmTallas.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem agregarTalla = new ToolStripMenuItem();
            agregarTalla.Text = "+ Agregar talla";
            agregarTalla.Click += Agg_Tallas_Click;
            cmTallas.Items.Add(agregarTalla);
        }
        private void Cargar_color()
        {
            cmColores.Items.Clear();
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select Nombre from Colores order by IdColor");
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    string color = fila["Nombre"].ToString();
                    ToolStripMenuItem item = new ToolStripMenuItem(color);
                    item.CheckOnClick = true;
                    item.CheckedChanged += Color_CheckedChanged;
                    cmColores.Items.Add(item);
                }
            }
            cmColores.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem agregarColor = new ToolStripMenuItem("+ Agregar color");
            agregarColor.Click += Agg_Colores_Click;
            cmColores.Items.Add(agregarColor);
        }
        private void Talla_CheckedChanged(object sender, EventArgs e)
        {
            List<string> tallasSeleccionadas = new List<string>();

            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    tallasSeleccionadas.Add(item.Text);
                }
            }

            if (tallasSeleccionadas.Count > 0)
            {
                lbl_tallas.Text = string.Join(", ", tallasSeleccionadas);
            }
            else
            {
                lbl_tallas.Text = "Seleccionar talla(s)";
            }
        }
        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            List<string> coloresSeleccionados = new List<string>();
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    coloresSeleccionados.Add(item.Text);
                }
            }
            if (coloresSeleccionados.Count > 0)
            {
                lbl_color.Text = string.Join(", ", coloresSeleccionados);
            }
            else
            {
                lbl_color.Text = "Seleccionar color(es)";
            }
        }
        private void Agg_Tallas_Click(object? sender, EventArgs e)
        {
            frm_secundario1 frm = new frm_secundario1();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Right + 10, this.Top);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                string tallaNueva = frm.Ntll.Trim().ToUpper();
                foreach (ToolStripItem elemento in cmTallas.Items)
                {
                    if (elemento is ToolStripMenuItem item)
                    {
                        if (item.Text.Equals(
                            tallaNueva,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "La talla " + tallaNueva + " ya existe.",
                                "Talla duplicada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }
                ToolStripMenuItem nuevaTalla = new ToolStripMenuItem(tallaNueva);
                nuevaTalla.CheckOnClick = true;
                nuevaTalla.CheckedChanged += Talla_CheckedChanged;
                cmTallas.Items.Insert(cmTallas.Items.Count - 2, nuevaTalla
                );
            }
        }
        private void Agg_Colores_Click(object sender, EventArgs e)
        {
            frm_secundario2 frm = new frm_secundario2();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Right + 10, this.Top);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                string nuevoColor = frm.ncolor;
                bool existe = false;
                foreach (ToolStripItem elemento in cmColores.Items)
                {
                    if (elemento is ToolStripMenuItem item)
                    {
                        if (item.Text.Equals(
                            nuevoColor,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                if (existe)
                {
                    MessageBox.Show("Ese color ya existe.");
                    return;
                }
                ToolStripMenuItem nuevoItem = new ToolStripMenuItem(nuevoColor);
                nuevoItem.CheckOnClick = true;
                nuevoItem.CheckedChanged += Color_CheckedChanged;
                int posicion = cmColores.Items.Count - 2;
                cmColores.Items.Insert(posicion, nuevoItem);
            }
        }
        private void btn_pedido_Click(object sender, EventArgs e)
        {
            if (cmb_proveedor.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            if (cmb_sucursal.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            if (txt_producto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el producto.");
                return;
            }

            if (detallesStock.Count == 0)
            {
                MessageBox.Show("Agregue el detalle del pedido.");
                return;
            }

            int idProveedor = Convert.ToInt32(cmb_proveedor.SelectedValue);
            int idSucursal = Convert.ToInt32(cmb_sucursal.SelectedValue);

            csConectaSQL conexion = new csConectaSQL();

            // determina el estado del pedido
            string estadoPedido = "Pendiente";

            if (dtp_fechaFin.Value.Date == DateTime.Now.Date)
            {
                estadoPedido = "Finalizado";
            }

            // EDITAR PEDIDO
            if (modoEditar)
            {
                string sql = "update Pedidos set IdProveedor = @IdProveedor, IdSucursal = @IdSucursal, Producto = @Producto, " +
                             "Cantidad = @Cantidad, FechaLlegadaEsperada = @FechaLlegada, Estado = @Estado, Observacion = @Observacion " +
                             "where IdPedido = @IdPedido";

                SqlParameter[] parametros ={new SqlParameter("@IdProveedor", idProveedor),new SqlParameter("@IdSucursal", idSucursal),
                             new SqlParameter("@Producto", txt_producto.Text.Trim()),new SqlParameter("@Cantidad", totalStock),
                             new SqlParameter("@FechaLlegada", dtp_fechaFin.Value.Date),new SqlParameter("@Estado", estadoPedido),
                             new SqlParameter("@Observacion", txt_observacion.Text.Trim()),new SqlParameter("@IdPedido", idPedidoEditar)};

                bool actualizado = conexion.ejecutarComando(sql, parametros);
                if (actualizado)
                {
                    string sqlEliminar = "delete from DetallePedidos where IdPedido = @IdPedido";
                    SqlParameter parametroEliminar = new SqlParameter("@IdPedido", idPedidoEditar);
                    conexion.ejecutarComando(sqlEliminar, parametroEliminar);

                    foreach (DetalleStock detalle in detallesStock)
                    {
                        string sqlDetalle = "insert into DetallePedidos " + "(IdPedido, Talla, Color, Cantidad) " +
                                            "values (@IdPedido, @Talla, @Color, @Cantidad)";

                        SqlParameter[] parametrosDetalle ={new SqlParameter("@IdPedido", idPedidoEditar),new SqlParameter("@Talla", detalle.Talla),
                                    new SqlParameter("@Color", detalle.Color),new SqlParameter("@Cantidad", detalle.stock)};

                        conexion.ejecutarComando(sqlDetalle, parametrosDetalle);
                    }

                    MessageBox.Show("Pedido actualizado correctamente.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                return;
            }

            // CREAR PEDIDO
            string numeroOrden = "PED-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string sqlNuevo = "insert into Pedidos " +
                              "(NumeroOrden, IdProveedor, IdSucursal, Producto, Cantidad, FechaPedido, FechaLlegadaEsperada, " +
                              "Estado, Observacion) " +
                              "values (@NumeroOrden, @IdProveedor, @IdSucursal, @Producto, @Cantidad, GETDATE(), @FechaLlegada, " +
                              "@Estado, @Observacion)";

            SqlParameter[] parametrosNuevo ={new SqlParameter("@NumeroOrden", numeroOrden),new SqlParameter("@IdProveedor", idProveedor),
                        new SqlParameter("@IdSucursal", idSucursal),new SqlParameter("@Producto", txt_producto.Text.Trim()),
                        new SqlParameter("@Cantidad", totalStock),new SqlParameter("@FechaLlegada", dtp_fechaFin.Value.Date),
                        new SqlParameter("@Estado", estadoPedido),new SqlParameter("@Observacion", txt_observacion.Text.Trim())};

            int idPedido = conexion.EjecutarConRetorno(sqlNuevo, parametrosNuevo);
            if (idPedido > 0)
            {
                foreach (DetalleStock detalle in detallesStock)
                {
                    string sqlDetalle = "insert into DetallePedidos " + "(IdPedido, Talla, Color, Cantidad) " +
                                        "values (@IdPedido, @Talla, @Color, @Cantidad)";

                    SqlParameter[] parametrosDetalle ={new SqlParameter("@IdPedido", idPedido), new SqlParameter("@Talla", detalle.Talla),
                                new SqlParameter("@Color", detalle.Color),new SqlParameter("@Cantidad", detalle.stock)};

                    conexion.ejecutarComando(sqlDetalle, parametrosDetalle);
                }

                MessageBox.Show("Pedido registrado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmTallas_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            btn_tallas1.Visible = false;
            btn_tallas.Visible = true;
        }
        private void cmColores_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            btn_color1.Visible = false;
            btn_color.Visible = true;
        }
        private void btn_tallas1_Click_1(object sender, EventArgs e)
        {
            cmTallas.Close();

            btn_tallas1.Visible = false;
            btn_tallas.Visible = true;
        }
        private void btn_tallas_Click_1(object sender, EventArgs e)
        {
            cmTallas.Width = lbl_tallas.Width;
            cmTallas.Show(lbl_tallas, new Point(0, lbl_tallas.Height));

            btn_tallas.Visible = false;
            btn_tallas1.Visible = true;
        }

        private void btn_color1_Click(object sender, EventArgs e)
        {
            cmColores.Close();

            btn_color1.Visible = false;
            btn_color.Visible = true;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cmColores.Width = lbl_color.Width;
            cmColores.Show(lbl_color, new Point(0, lbl_color.Height));

            btn_color.Visible = false;
            btn_color1.Visible = true;
        }

        private void btn_abr_Click(object sender, EventArgs e)
        {
            // obtiene las tallas seleccionadas
            List<string> tallas = new List<string>();

            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    tallas.Add(item.Text);
                }
            }

            // obtiene los colores seleccionados
            List<string> colores = new List<string>();

            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    colores.Add(item.Text);
                }
            }

            if (tallas.Count == 0 || colores.Count == 0)
            {
                MessageBox.Show(
                    "Primero seleccione al menos una talla y un color.",
                    "Detalle del pedido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // abre el formulario para indicar las cantidades
            frmEditar_stock frm = new frmEditar_stock(tallas, colores, detallesStock);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                detallesStock = frm.DetallesStock;
                totalStock = frm.S_total;
                btn_abr.Text = totalStock + " unidades";
            }
        }
        private void cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sucursal.SelectedIndex == 0)
            {
                idSucursalSeleccionada = 0;
                return;
            }

            idSucursalSeleccionada = Convert.ToInt32(cmb_sucursal.SelectedValue);
        }

        private void pic2_e_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechaInicio.MinDate = DateTime.Today;
            if (dtp_fechaFin.Value.Date < dtp_fechaInicio.Value.Date)
            {
                dtp_fechaFin.Value = dtp_fechaInicio.Value.Date;
            }
            dtp_fechaFin.MinDate = dtp_fechaInicio.Value.Date;
        }
    }
}
