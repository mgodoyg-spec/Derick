using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Derick
{
    public partial class FrmDetalleTodo1 : Form
    {
        private int idproducto;
        private int idSucursal;
        private string talla;
        private string color;

        public FrmDetalleTodo1()
        {
            InitializeComponent();
        }

        public FrmDetalleTodo1(int idproducto, int idSucursal, string talla, string color)
        {
            InitializeComponent();

            this.idproducto = idproducto;
            this.idSucursal = idSucursal;
            this.talla = talla;
            this.color = color;

            CargarProducto();
            CargarImagenesProducto();
        }
        private void FrmDetalleTodo1_Load(object sender, EventArgs e)
        {
            
        }
        private void CargarProducto()
        {
            csConectaSQL conexion = new csConectaSQL();

            string sql = @"select P.Codigo, P.Nombre, P.Categoria, P.Precio, P.Descripcion,
                   I.Estado, I.Talla, I.Color, I.Stock from Productos P inner join Inventario I
                   on P.IdProductos = I.IdProducto where P.IdProductos = " + idproducto + @"
                   and I.IdSucursal = " + idSucursal + @"
                   and I.Talla = '" + talla.Replace("'", "''") + @"'
                   and I.Color = '" + color.Replace("'", "''") + "'";

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];

            lblCodigo.Text = fila["Codigo"].ToString();
            lblNombreP.Text = fila["Nombre"].ToString();
            lblCategoria.Text = fila["Categoria"].ToString();
            lblTalla.Text = fila["Talla"].ToString();
            lblColor.Text = fila["Color"].ToString();

            decimal precio = Convert.ToDecimal(fila["Precio"]);
            lblPrecio.Text = "$" + precio.ToString("0.00");

            bool activo = Convert.ToBoolean(fila["Estado"]);

            if (activo)
            {
                lblEstado.Text = "Activo";
            }

            if (!activo)
            {
                lblEstado.Text = "Inactivo";
            }

            lblStock.Text = fila["Stock"].ToString();
            if (fila["Descripcion"] != DBNull.Value && !string.IsNullOrWhiteSpace(fila["Descripcion"].ToString()))
            {
                lblDescripcion.Text = fila["Descripcion"].ToString();
            }
            else
            {
                lblDescripcion.Text = "Sin descripción";
            }
        }

        private void CargarImagenesProducto()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros("select top 5 Imagen " + "from ProductoImagenes " +
                "where IdProductos = " + idproducto + " " + "and Imagen IS NOT NULL " +
                "order by EsPrincipal desc, IdImagen");

            if (dt == null)
            {
                return;
            }

            PictureBox[] imagenes =
            {
                pic_img1,
                pic_img2,
                pic_img3,
                pic_img4,
                pic_img5
            };

            PictureBox[] iconosMas =
            {
                pic2,
                pic3,
                pic4,
                pic5,
                pic6
            };

            // primero dejamos todos los + visibles
            for (int i = 0; i < imagenes.Length; i++)
            {
                imagenes[i].Image = null;
                iconosMas[i].Visible = true;
            }

            // carga las imágenes
            for (int i = 0; i < dt.Rows.Count && i < imagenes.Length; i++)
            {
                if (dt.Rows[i]["Imagen"] == DBNull.Value)
                {
                    continue;
                }

                byte[] bytes = (byte[])dt.Rows[i]["Imagen"];

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    using (Image temporal = Image.FromStream(ms))
                    {
                        imagenes[i].Image = new Bitmap(temporal);
                    }
                }

                imagenes[i].SizeMode = PictureBoxSizeMode.Zoom;

                // oculta el + de esta posición
                iconosMas[i].Visible = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
