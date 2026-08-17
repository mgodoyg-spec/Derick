using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmDetalleTodo1 : Form
    {
        private int idproducto;
        public FrmDetalleTodo1()
        {
            InitializeComponent();
        }
        public FrmDetalleTodo1(int idproducto)
        {
            InitializeComponent();
            this.idproducto = idproducto;
        }
        private void FrmDetalleTodo1_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }
        private void CargarProducto()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT Codigo, Nombre, Categoria, Talla, Color, Precio, Estado, Descripcion " +
                "FROM Productos " +
                "WHERE IdProductos = " + idproducto
            );

            if (dt == null || dt.Rows.Count == 0)
                return;

            DataRow fila = dt.Rows[0];

            lblCodigo.Text = fila["Codigo"].ToString();
            lblNombreP.Text = fila["Nombre"].ToString();
            lblCategoria.Text = fila["Categoria"].ToString();
            lblTalla.Text = fila["Talla"].ToString();
            lblColor.Text = fila["Color"].ToString();
            lblDescripcion.Text = fila["Descripcion"].ToString();

            decimal precio = Convert.ToDecimal(fila["Precio"]);
            lblPrecio.Text = "$" + precio.ToString("0.00");

            bool activo = Convert.ToBoolean(fila["Estado"]);
            lblEstado.Text = activo ? "Activo" : "Inactivo";

            // Por ahora dejamos el stock en 0
            // hasta conectar bien Inventario.
            lblStock.Text = "0";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
