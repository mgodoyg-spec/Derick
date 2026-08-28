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
                           where Estado = 'activo' order by NombreSucursal";
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
            int idSucursal = Convert.ToInt32(cmb_sucursalOrigen.SelectedValue);
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
            if (cmb_sucursalOrigen.SelectedIndex == -1 || cmb_productos.SelectedIndex == -1)
            {
                cmb_tallas.DataSource = null;
                return;
            }

            int idSucursal = Convert.ToInt32(cmb_sucursalOrigen.SelectedValue);
            int idProducto = Convert.ToInt32(cmb_productos.SelectedValue);
            csConectaSQL conect = new csConectaSQL();
            string query = @"select distinct Talla from Inventario
                           where IdSucursal = " + idSucursal + @" and IdProducto = " + idProducto + @"
                           and Stock > 0 order by Talla";

            DataTable dt = conect.RetornaRegistros(query);
            cmb_tallas.DataSource = dt;
            cmb_tallas.DisplayMember = "Talla";
            cmb_tallas.ValueMember = "Talla";
            cmb_tallas.SelectedIndex = -1;
        }

        //Muestra solo los colores de la sucursal seleccionada en el combo de origen
        private void Cargar_Colores()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1 || cmb_productos.SelectedIndex == -1 ||
                cmb_tallas.SelectedIndex == -1)
            {
                cmb_colores.DataSource = null;
                return;
            }

            int idSucursal = Convert.ToInt32(cmb_sucursalOrigen.SelectedValue);
            int idProducto = Convert.ToInt32(cmb_productos.SelectedValue);
            string talla = cmb_tallas.SelectedValue.ToString().Replace("'", "''");
            csConectaSQL conect = new csConectaSQL();
            string query = @"select distinct Color from Inventario
                           where IdSucursal = " + idSucursal + @" and IdProducto = " + idProducto + @"
                           and Talla = '" + talla + @"' and Stock > 0 order by Color";

            DataTable dt = conect.RetornaRegistros(query);
            cmb_colores.DataSource = dt;
            cmb_colores.DisplayMember = "Color";
            cmb_colores.ValueMember = "Color";
            cmb_colores.SelectedIndex = -1;
        }

        private void Cargar_StockDisponible()
        {
            if (cmb_sucursalOrigen.SelectedIndex == -1 || cmb_productos.SelectedIndex == -1 ||
                cmb_tallas.SelectedIndex == -1 || cmb_colores.SelectedIndex == -1)
            {
                lbl_texto.Text = "0 unidades";
                nud_cantidad.Minimum = 1;
                nud_cantidad.Maximum = 1;
                nud_cantidad.Value = 1;
                return;
            }
            int idSucursal = Convert.ToInt32(cmb_sucursalOrigen.SelectedValue);
            int idProducto = Convert.ToInt32(cmb_productos.SelectedValue);
            string talla = cmb_tallas.SelectedValue.ToString().Replace("'", "''");
            string color = cmb_colores.SelectedValue.ToString().Replace("'", "''");

            csConectaSQL conect = new csConectaSQL();
            string query = @"select Stock from Inventario where IdSucursal = " + idSucursal + @"
                           and IdProducto = " + idProducto + @" and Talla = '" + talla + @"'
                           and Color = '" + color + "'";

            DataTable dt = conect.RetornaRegistros(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                int stock = Convert.ToInt32(dt.Rows[0]["Stock"]);
                lbl_texto.Text = stock + " unidades";
                if (stock > 0)
                {
                    nud_cantidad.Minimum = 1;
                    nud_cantidad.Maximum = stock;
                    nud_cantidad.Value = 1;
                    nud_cantidad.Enabled = true;
                }
                else
                {
                    lbl_texto.Text = "Sin stock";
                    nud_cantidad.Minimum = 0;
                    nud_cantidad.Maximum = 0;
                    nud_cantidad.Value = 0;
                    nud_cantidad.Enabled = false;
                }
            }
            else
            {
                lbl_texto.Text = "0 unidades";
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
            Cargar_Tallas();
        }
        private void cmb_tallas_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_colores.DataSource = null;
            Cargar_Colores();
        }

        private void cmb_colores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_StockDisponible();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // VALIDAR SUCURSAL ORIGEN
            if (cmb_sucursalOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la sucursal de origen.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmb_sucursalOrigen.Focus();
                return;
            }

            // VALIDAR SUCURSAL DESTINO
            if (cmb_sucursalDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la sucursal de destino.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmb_sucursalDestino.Focus();
                return;
            }
            // VALIDAR PRODUCTO
            if (cmb_productos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // VALIDAR TALLA
            if (cmb_tallas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una talla.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // VALIDAR COLOR
            if (cmb_colores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un color.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            int idOrigen = Convert.ToInt32(cmb_sucursalOrigen.SelectedValue);
            int idDestino = Convert.ToInt32(cmb_sucursalDestino.SelectedValue);
            int idProducto = Convert.ToInt32(cmb_productos.SelectedValue);
            string talla = cmb_tallas.SelectedValue.ToString();
            string color = cmb_colores.SelectedValue.ToString();
            int cantidad = Convert.ToInt32(nud_cantidad.Value);

            // ORIGEN Y DESTINO NO PUEDEN SER IGUALES
            if (idOrigen == idDestino)
            {
                MessageBox.Show("La sucursal de origen y destino deben ser diferentes.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // CANTIDAD
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad a transferir debe ser mayor a 0.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            csConectaSQL conexion = new csConectaSQL();
            // CONSULTAR STOCK ACTUAL
            string consultaStock = @"select Stock from Inventario where IdSucursal = " + idOrigen + @"
                                   and IdProducto = " + idProducto + @" and Talla = '" + talla.Replace("'", "''") + @"'
                                   and Color = '" + color.Replace("'", "''") + "'";
            DataTable dtStock = conexion.RetornaRegistros(consultaStock);

            if (dtStock == null || dtStock.Rows.Count == 0)
            {
                MessageBox.Show("No existe inventario para el producto seleccionado.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            int stockActual = Convert.ToInt32(dtStock.Rows[0]["Stock"]);

            if (cantidad > stockActual)
            {
                MessageBox.Show("No hay suficiente stock disponible.", "Transferencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // RESTAR STOCK EN ORIGEN
            bool restado = conexion.ejecutarComando(@"update Inventario set Stock = Stock - @Cantidad
                    where IdSucursal = @IdSucursal and IdProducto = @IdProducto
                    and Talla = @Talla and Color = @Color",
                    new SqlParameter("@Cantidad", cantidad),
                    new SqlParameter("@IdSucursal", idOrigen),
                    new SqlParameter("@IdProducto", idProducto),
                    new SqlParameter("@Talla", talla),
                    new SqlParameter("@Color", color));
            if (!restado)
            {
                MessageBox.Show("No se pudo descontar el stock de la sucursal origen.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // VERIFICAR SI YA EXISTE EN DESTINO
            string consultaDestino = @"select Stock from Inventario where IdSucursal = " + idDestino + @"
                                     and IdProducto = " + idProducto + @" and Talla = '" + talla.Replace("'", "''") + @"'
                                     and Color = '" + color.Replace("'", "''") + "'";
            DataTable dtDestino = conexion.RetornaRegistros(consultaDestino);

            bool resultadoDestino;
            if (dtDestino != null && dtDestino.Rows.Count > 0)
            {
                // YA EXISTE → SUMAR STOCK
                resultadoDestino = conexion.ejecutarComando(@"update Inventario set Stock = Stock + @Cantidad
                        where IdSucursal = @IdSucursal and IdProducto = @IdProducto
                        and Talla = @Talla and Color = @Color",
                        new SqlParameter("@Cantidad", cantidad),
                        new SqlParameter("@IdSucursal", idDestino),
                        new SqlParameter("@IdProducto", idProducto),
                        new SqlParameter("@Talla", talla),
                        new SqlParameter("@Color", color));
            }
            else
            {
                // NO EXISTE → CREAR REGISTRO
                resultadoDestino = conexion.ejecutarComando(@"insert into Inventario (
                      IdProducto,
                      IdSucursal,
                      Talla,
                      Color,
                      Stock) VALUES (
                      @IdProducto,
                      @IdSucursal,
                      @Talla,
                      @Color,
                      @Stock)",
                      new SqlParameter("@IdProducto", idProducto),
                      new SqlParameter("@IdSucursal", idDestino),
                      new SqlParameter("@Talla", talla),
                      new SqlParameter("@Color", color),
                      new SqlParameter("@Stock", cantidad));
            }
            if (!resultadoDestino)
            {
                MessageBox.Show("Ocurrió un error al agregar el stock en la sucursal destino.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Producto transferido correctamente.", "Transferencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // ACTUALIZAR STOCK MOSTRADO
            Cargar_StockDisponible();
            // REINICIAR CANTIDAD
            if (nud_cantidad.Maximum >= 1)
            {
                nud_cantidad.Value = 1;
            }
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
