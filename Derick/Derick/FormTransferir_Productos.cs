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
    public partial class FormTransferir_Productos : Form
    {
        csConectaSQL conect = new csConectaSQL();
        public FormTransferir_Productos()
        {
            InitializeComponent();
        }

        private void FormTransferir_Productos_Load(object sender, EventArgs e)
        {
            Cargar_Sucurcales();
        }
        private void Cargar_Sucurcales()
        {
            csConectaSQL conect = new csConectaSQL();
            string query = @"select IdSucursal, NombreSucursal from Sucursales
                           where Estado = 'activa' order by NombreSucursal";
            DataTable dt = conect.RetornaRegistros(query);

            // SUCURSAL ORIGEN
            cmb_sucursalOrigen.DataSource = dt.Copy();
            cmb_sucursalOrigen.DisplayMember = "NombreSucursal";
            cmb_sucursalOrigen.ValueMember = "IdSucursal";
            cmb_sucursalOrigen.SelectedIndex = -1;

            // SUCURSAL DESTINO
            cmb_sucursalDestino.DataSource = dt.Copy();
            cmb_sucursalDestino.DisplayMember = "NombreSucursal";
            cmb_sucursalDestino.ValueMember = "IdSucursal";
            cmb_sucursalDestino.SelectedIndex = -1;
            if (Convert.ToInt32(cmb_sucursalOrigen.SelectedValue) == Convert.ToInt32(cmb_sucursalDestino.SelectedValue))
            {
                MessageBox.Show("La sucursal de origen y destino deben ser diferentes.");
                return;
            }
        }

        //Muestra solo los productos de la sucursal seleccionada en el combo de origen
        private void Cargar_Productos()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                cmb_productos.DataSource = null;
                return;
            }
            int idSucursal = Convert.ToInt32(((DataRowView)cmb_sucursalOrigen.SelectedItem)["IdSucursal"]);
            csConectaSQL conect = new csConectaSQL();

            string query = @"select distinct P.IdProductos, P.Nombre from Inventario I
                           inner join Productos P on I.IdProducto = P.IdProductos
                           where I.IdSucursal = " + idSucursal + @"  and I.Stock > 0
                           and P.Estado = 1 order by P.Nombre";

            DataTable dt = conect.RetornaRegistros(query);
            cmb_productos.DataSource = dt;
            cmb_productos.DisplayMember = "Nombre";
            cmb_productos.ValueMember = "IdProductos";
            cmb_productos.SelectedIndex = -1;
        }

        //Muestra solo las tallas de la sucursal seleccionada en el combo de origen
        private void Cargar_Tallas()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_productos.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_sucursalOrigen.SelectedItem == null)
            {
                return;
            }

            if (cmb_productos.SelectedItem == null)
            {
                return;
            }

            DataRowView filaSucursal = (DataRowView)cmb_sucursalOrigen.SelectedItem;
            DataRowView filaProducto = (DataRowView)cmb_productos.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            int idProducto = Convert.ToInt32(filaProducto["IdProductos"]);

            csConectaSQL conect = new csConectaSQL();
           string query = @"select distinct Talla from Inventario where IdSucursal = " + idSucursal + @"
                and IdProducto = " + idProducto + @" and Stock > 0 order by Talla";

            DataTable dt = conect.RetornaRegistros(query);
            if (dt == null)
            {
                return;
            }

            cmb_tallas.DataSource = dt;
            cmb_tallas.DisplayMember = "Talla";
            cmb_tallas.ValueMember = "Talla";
            cmb_tallas.SelectedIndex = -1;
        }

        //Muestra solo los colores de la sucursal seleccionada en el combo de origen
        private void Cargar_Colores()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_productos.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_tallas.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_sucursalOrigen.SelectedItem == null)
            {
                return;
            }

            if (cmb_productos.SelectedItem == null)
            {
                return;
            }

            string talla = cmb_tallas.Text.Trim();
            if (talla == "")

            {
                return;
            }

            DataRowView filaSucursal = (DataRowView)cmb_sucursalOrigen.SelectedItem;
            DataRowView filaProducto = (DataRowView)cmb_productos.SelectedItem;
            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            int idProducto = Convert.ToInt32(filaProducto["IdProductos"]);
            talla = talla.Replace("'", "''");

            csConectaSQL conect = new csConectaSQL();
            string query = @"select distinct Color from Inventario where IdSucursal = " + idSucursal + @"
                and IdProducto = " + idProducto + @" and Talla = '" + talla + @"'
                and Stock > 0 order by Color";

            DataTable dt = conect.RetornaRegistros(query);
            if (dt == null)
            {
                return;
            }

            cmb_colores.DataSource = dt;
            cmb_colores.DisplayMember = "Color";
            cmb_colores.ValueMember = "Color";
            cmb_colores.SelectedIndex = -1;
        }

        private void Cargar_StockDisponible()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_productos.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_tallas.SelectedIndex == -1)
            {
                return;
            }

            if (cmb_colores.SelectedIndex == -1)
            {
                return;
            }

            DataRowView filaSucursal = (DataRowView)cmb_sucursalOrigen.SelectedItem;
            DataRowView filaProducto = (DataRowView)cmb_productos.SelectedItem;

            int idSucursal = Convert.ToInt32(filaSucursal["IdSucursal"]);
            int idProducto = Convert.ToInt32(filaProducto["IdProductos"]);
            string talla = cmb_tallas.Text.Trim().Replace("'", "''");
            string color = cmb_colores.Text.Trim().Replace("'", "''");

            csConectaSQL conect = new csConectaSQL();
            string query = @"select Stock from Inventario where IdSucursal = " + idSucursal + @"
                and IdProducto = " + idProducto + @"and Talla = '" + talla + @"' and Color = '" + color + "'";
            DataTable dt = conect.RetornaRegistros(query);

            if (dt == null)
            {
                return;
            }

            if (dt.Rows.Count == 0)
            {
                lbl_texto.Text = "0";
                nud_cantidad.Minimum = 0;
                nud_cantidad.Maximum = 0;
                nud_cantidad.Value = 0;
                nud_cantidad.Enabled = false;
                return;
            }

            int stock = Convert.ToInt32(dt.Rows[0]["Stock"]);
            lbl_texto.Text = stock.ToString();

            if (stock > 0)
            {
                nud_cantidad.Enabled = true;
                nud_cantidad.Minimum = 1;
                nud_cantidad.Maximum = stock;
                nud_cantidad.Value = 1;
            }

            if (stock == 0)
            {
                nud_cantidad.Minimum = 0;
                nud_cantidad.Maximum = 0;
                nud_cantidad.Value = 0;
                nud_cantidad.Enabled = false;
            }
        }
        private void cmb_sucursalOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_productos.DataSource = null;
            cmb_tallas.DataSource = null;
            cmb_colores.DataSource = null;
            Cargar_Productos();
        }
        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_tallas.DataSource = null;
            cmb_colores.DataSource = null;
            lbl_texto.Text = "";

            if (cmb_productos.SelectedIndex != -1)
            {
                Cargar_Tallas();
            }
        }
        private void cmb_tallas_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_colores.DataSource = null;
            lbl_texto.Text = "";

            if (cmb_tallas.SelectedIndex != -1)
            {
                Cargar_Colores();
            }
        }

        private void cmb_colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_colores.SelectedIndex != -1)
            {
                Cargar_StockDisponible();
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // validar sucursal origen
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione la sucursal de origen.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_sucursalOrigen.Focus();
                return;
            }

            // validar sucursal destino
            if (cmb_sucursalDestino.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione la sucursal de destino.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_sucursalDestino.Focus();
                return;
            }

            // validar producto
            if (cmb_productos.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_productos.Focus();
                return;
            }

            // validar talla
            if (cmb_tallas.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una talla.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_tallas.Focus();
                return;
            }

            // validar color
            if (cmb_colores.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un color.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_colores.Focus();
                return;
            }

            // obtener las filas seleccionadas
            DataRowView filaOrigen = (DataRowView)cmb_sucursalOrigen.SelectedItem;
            DataRowView filaDestino = (DataRowView)cmb_sucursalDestino.SelectedItem;
            DataRowView filaProducto = (DataRowView)cmb_productos.SelectedItem;

            // obtener los id
            int idOrigen = Convert.ToInt32( filaOrigen["IdSucursal"]);
            int idDestino = Convert.ToInt32( filaDestino["IdSucursal"]);
            int idProducto = Convert.ToInt32( filaProducto["IdProductos"]);

            // obtener talla y color
            string talla = cmb_tallas.Text.Trim();
            string color = cmb_colores.Text.Trim();

            // obtener cantidad a transferir
            int cantidad = Convert.ToInt32( nud_cantidad.Value);

            // validar que origen y destino sean diferentes
            if (idOrigen == idDestino)
            {
                MessageBox.Show(
                    "La sucursal de origen y destino deben ser diferentes.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // validar cantidad
            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad a transferir debe ser mayor a 0.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            csConectaSQL conexion = new csConectaSQL();

            // consultar stock actual de la sucursal origen
            string consultaStock = @"select Stock from Inventario where IdSucursal = " + idOrigen + @"
                   and IdProducto = " + idProducto + @" and Talla = '" + talla.Replace("'", "''") + @"'
                   and Color = '" + color.Replace("'", "''") + "'";

            DataTable dtStock = conexion.RetornaRegistros(consultaStock);

            // validar que se pudo consultar el inventario
            if (dtStock == null)
            {
                MessageBox.Show(
                    "No se pudo consultar el stock.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // validar que exista el producto en el inventario
            if (dtStock.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No existe inventario para el producto seleccionado.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // obtener stock actual
            int stockActual = Convert.ToInt32(dtStock.Rows[0]["Stock"]);

            // validar que exista suficiente stock
            if (cantidad > stockActual)
            {
                MessageBox.Show(
                    "No hay suficiente stock disponible.",
                    "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // restar stock de la sucursal origen
            bool restado =
                conexion.ejecutarComando(@"update Inventario set Stock = Stock - @Cantidad
                        where IdSucursal = @IdSucursal and IdProducto = @IdProducto and Talla = @Talla
                        and Color = @Color",

                    new SqlParameter("@Cantidad",cantidad),
                    new SqlParameter("@IdSucursal",idOrigen),
                    new SqlParameter("@IdProducto",idProducto),
                    new SqlParameter("@Talla",talla),
                    new SqlParameter("@Color",color));

            // validar que se haya restado el stock
            if (!restado)
            {
                MessageBox.Show(
                    "No se pudo descontar el stock de la sucursal origen.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // consultar si el producto ya existe en la sucursal destino
            string consultaDestino = @"select Stock from Inventario where IdSucursal = " + idDestino + @"
                   and IdProducto = " + idProducto + @"and Talla = '" + talla.Replace("'", "''") + @"'
                   and Color = '" + color.Replace("'", "''") + "'";
            DataTable dtDestino = conexion.RetornaRegistros(consultaDestino);

            bool resultadoDestino = false;
            // si ya existe la misma talla y color, sumar el stock
            if (dtDestino != null &&
                dtDestino.Rows.Count > 0)
            {
                resultadoDestino =
                    conexion.ejecutarComando(@"update Inventario set Stock = Stock + @Cantidad
                    where IdSucursal = @IdSucursal and IdProducto = @IdProducto and Talla = @Talla
                    and Color = @Color",
                    new SqlParameter("@Cantidad",cantidad),
                    new SqlParameter("@IdSucursal",idDestino),
                    new SqlParameter("@IdProducto",idProducto),
                    new SqlParameter("@Talla",talla),
                    new SqlParameter("@Color",color));
            }

            // si no existe la talla y color en destino, crear el registro
            if (dtDestino == null || dtDestino.Rows.Count == 0)
            {
                resultadoDestino = conexion.ejecutarComando(@"insert into Inventario
                  (IdProducto, IdSucursal, Talla, Color, Stock)values
                  (@IdProducto, @IdSucursal, @Talla, @Color, @Stock)",
                  new SqlParameter("@IdProducto",idProducto),
                  new SqlParameter("@IdSucursal",idDestino),
                  new SqlParameter("@Talla",talla),
                  new SqlParameter("@Color",color),
                  new SqlParameter("@Stock",cantidad));
            }

            // validar que se haya agregado el stock al destino
            if (!resultadoDestino)
            {
                MessageBox.Show(
                    "Ocurrió un error al agregar el stock en la sucursal destino.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // mostrar mensaje de transferencia correcta
            MessageBox.Show(
                "Producto transferido correctamente.",
                "Transferencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // devolver resultado correcto al formulario inventario
            DialogResult = DialogResult.OK;

            // cerrar formulario de transferencia
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
               MessageBox.Show(
               "¿Está seguro de salir?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
