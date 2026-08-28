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
    public partial class FormAgg_Product : Form
    {
        private List<PictureBox> piclist;
        private List<PictureBox> piclist1;
        private List<string> rt = new List<string>();
        private PictureBox? picSelect = null;
        private List<DetalleStock> detallesStock = new List<DetalleStock>();
        private bool stockModificado = false;
        private int? idProductoEditar = null;
        public FormAgg_Product()
        {
            InitializeComponent();

            piclist = new List<PictureBox>()
            {
                pic_img1,
                pic_img2,
                pic_img3,
                pic_img4,
                pic_img5
            };
            piclist1 = new List<PictureBox>()
            {
                pic2,
                pic3,
                pic4,
                pic5,
                pic6
            };
        }
        public FormAgg_Product(int idProducto) : this()
        {
            idProductoEditar = idProducto;
        }
        private void FormAgg_Product_Load(object sender, EventArgs e)
        {
            CTalla();
            CTColor();
            C_CTG();
            if (idProductoEditar != null)
            {
                CP_editar();
                CargarImagenesEditar();
            }
            Cargar_sucursales();
        }
        private void CTalla()
        {
            cmTallas.Items.Clear();
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros( "select Nombre from Tallas order by IdTalla");
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
        private void CTColor()
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
        private void seleccionarImagen_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Image != null)
            {
                foreach (PictureBox p in piclist)
                {
                    p.BorderStyle = BorderStyle.FixedSingle;
                }
                picSelect = pic;
                picSelect.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private bool GuardarImagenesProducto(int idProducto)
        {
            csConectaSQL conexion = new csConectaSQL();

            for (int i = 0; i < rt.Count; i++)
            {
                string ruta = rt[i];

                if (!File.Exists(ruta))
                {
                    continue;
                }

                byte[] imagenBytes = File.ReadAllBytes(ruta);
                string nombreArchivo = Path.GetFileName(ruta);
                bool esPrincipal = (i == 0);
                string sql = @"insert into ProductoImagenes(IdProductos, RutaImagen, Imagen, EsPrincipal)
                      VALUES (@IdProducto, @RutaImagen, @Imagen, @EsPrincipal)";
                SqlParameter parametroImagen = new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);

                parametroImagen.Value = imagenBytes;
                bool guardado = conexion.ejecutarComando( sql,
                    new SqlParameter("@IdProducto", idProducto),
                    new SqlParameter("@RutaImagen", nombreArchivo),
                    parametroImagen,
                    new SqlParameter("@EsPrincipal",esPrincipal));

                if (!guardado)
                {
                    return false; ;
                }
            }
            return true;
        }
        private void CargarImagenesEditar()
        {
            if (idProductoEditar == null)
            {
                return;
            }

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select top 5 Imagen " +
                "from ProductoImagenes " + "where IdProductos = " + idProductoEditar.Value + " " +
                "and Imagen IS NOT NULL " + "order by EsPrincipal desc, IdImagen");

            if (dt == null)
            {
                return;
            }

            // Limpiar los PictureBox primero
            for (int i = 0; i < piclist.Count; i++)
            {
                if (piclist[i].Image != null)
                {
                    piclist[i].Image.Dispose();
                    piclist[i].Image = null;
                }

                piclist1[i].Visible = true;
            }

            // Cargar imágenes guardadas en SQL
            for (int i = 0; i < dt.Rows.Count && i < piclist.Count; i++)
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
                        piclist[i].Image = new Bitmap(temporal);
                    }
                }
                piclist[i].SizeMode = PictureBoxSizeMode.Zoom;
                piclist1[i].Visible = false;
            }
        }
        private void C_CTG()
        {
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select Nombre from Categorias where Estado = 1 " +
                "order by Nombre");

            if (dt == null)
            {
                return;
            }
            cmb_ctg.Items.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                cmb_ctg.Items.Add(fila["Nombre"].ToString());
            }

        }
        private void CP_editar()
        {
            if (idProductoEditar == null)
            {
                return;
            }

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select Codigo, Nombre, Categoria, Talla, " +
                "Color, Precio, Estado " + "from Productos where IdProductos = " + idProductoEditar.Value);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];
            txt_cd.Text = fila["Codigo"].ToString();
            txt_nmb.Text = fila["Nombre"].ToString();
            cmb_ctg.Text = fila["Categoria"].ToString();
            txt_prc.Text = Convert.ToDecimal(fila["Precio"]).ToString("0.00");

            // carga los estados 
            bool activo = Convert.ToBoolean(fila["Estado"]);
            cmb_est.Text = activo ? "Activo" : "Inactivo";

            // carga las tallas que hayan
            string[] tallas = fila["Talla"].ToString().Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    foreach (string talla in tallas)
                    {
                        if (item.Text.Equals(talla.Trim(),StringComparison.OrdinalIgnoreCase))
                        {
                            item.Checked = true;
                            break;
                        }
                    }
                }
            }

            // carga los colores que hayan
            string[] colores = fila["Color"].ToString().Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    foreach (string color in colores)
                    {
                        if (item.Text.Equals(color.Trim(),StringComparison.OrdinalIgnoreCase))
                        {
                            item.Checked = true;
                            break;
                        }
                    }
                }
            }
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

            cmb_sucursal.DataSource = dt;
            cmb_sucursal.DisplayMember = "NombreSucursal";
            cmb_sucursal.ValueMember = "IdSucursal";
            cmb_sucursal.SelectedIndex = -1;
        }
        private bool Guardar_stock(int idProducto, int idSucursal)
        {
            csConectaSQL conexion = new csConectaSQL();
            foreach (DetalleStock detalle in detallesStock)
            {
                string sql = @" insert into Inventario(IdProducto, IdSucursal, Talla,
                Color, Stock) values (@IdProducto, @IdSucursal, @Talla, @Color, @Stock)";

                bool resultado = conexion.ejecutarComando(sql,
                    new SqlParameter("@IdProducto", idProducto),
                    new SqlParameter("@IdSucursal", idSucursal),
                    new SqlParameter("@Talla", detalle.Talla),
                    new SqlParameter("@Color", detalle.Color),
                    new SqlParameter("@Stock", detalle.stock));

                if (!resultado)
                {
                    return false;
                }
            }
            return true;
        }
        private bool Actualizar_stock(int idProducto, int idSucursal)
        {
            csConectaSQL conexion = new csConectaSQL();
            try
            {
                foreach (DetalleStock detalle in detallesStock)
                {
                    //verifica si la combinación ya existe
                    string consulta = @"select IdInventario from Inventario 
                        where IdProducto = " + idProducto + @" and IdSucursal = " + idSucursal + @"
                        and Talla = '" + detalle.Talla.Replace("'", "''") + @"'
                        and Color = '" + detalle.Color.Replace("'", "''") + "'";
                    DataTable dt = conexion.RetornaRegistros(consulta);

                    // si ya existe la combinación, la atualiza
                    if (dt.Rows.Count > 0)
                    {
                        string sql = @"update Inventario set Stock = @Stock
                             where IdProducto = @IdProducto and IdSucursal = @IdSucursal
                             and Talla = @Talla and Color = @Color";

                        bool actualizado = conexion.ejecutarComando(sql,
                                new SqlParameter("@Stock",detalle.stock),
                                new SqlParameter("@IdProducto",idProducto),
                                new SqlParameter("@IdSucursal",idSucursal),
                                new SqlParameter("@Talla",detalle.Talla),
                                new SqlParameter("@Color",detalle.Color));

                        if (!actualizado)
                        {
                            return false;
                        }
                    }

                    // si la combinación no existe la inserta
                    else
                    {
                        string sql = @"insert to Inventario(IdProducto, IdSucursal, Talla,
                             Color, Stock) values(IdProducto, @IdSucursal, @Talla, @Color, @Stock)";
                        bool insertado = conexion.ejecutarComando(sql,
                                new SqlParameter("@IdProducto",idProducto),
                                new SqlParameter("@IdSucursal",idSucursal),
                                new SqlParameter("@Talla",detalle.Talla),
                                new SqlParameter("@Color",detalle.Color),
                                new SqlParameter("@Stock",detalle.stock));

                        if (!insertado)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el stock: " +
                    ex.Message);

                return false;
            }
        }
        private List<DetalleStock> CargarStockProducto(int idProducto, int idSucursal)
        {
            List<DetalleStock> lista = new List<DetalleStock>();
            csConectaSQL conexion = new csConectaSQL();

            string sql = @"select Talla, Color, Stock from Inventario
                where IdProducto = " + idProducto + @" and IdSucursal = " + idSucursal;
            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
            {
                return lista;
            }

            foreach (DataRow fila in dt.Rows)
            {
                DetalleStock detalle = new DetalleStock();
                detalle.Talla = fila["Talla"].ToString();
                detalle.Color = fila["Color"].ToString();
                detalle.stock = Convert.ToInt32(fila["Stock"]);
                lista.Add(detalle);
            }
            return lista;
        }
        ////////////////////////////////////////////////////////////
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
            frm.Location = new Point(
                this.Right + 10,
                this.Top
            );

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
            frm.Location = new Point(
                this.Right + 10,
                this.Top
            );

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

        private void pic2_e_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tallas_Click(object sender, EventArgs e)
        {
            cmTallas.Width = lbl_tallas.Width;
            cmTallas.Show(lbl_tallas, new Point(0, lbl_tallas.Height));

            btn_tallas.Visible = false;
            btn_tallas1.Visible = true;
        }

        private void btn_tallas1_Click(object sender, EventArgs e)
        {
            cmTallas.Close();

            btn_tallas1.Visible = false;
            btn_tallas.Visible = true;
        }

        private void cmTallas_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            btn_tallas1.Visible = false;
            btn_tallas.Visible = true;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cmColores.Width = lbl_color.Width;
            cmColores.Show(lbl_color, new Point(0, lbl_color.Height));

            btn_color.Visible = false;
            btn_color1.Visible = true;
        }

        private void btn_color1_Click(object sender, EventArgs e)
        {
            cmColores.Close();

            btn_color1.Visible = false;
            btn_color.Visible = true;
        }

        private void cmColores_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            btn_color1.Visible = false;
            btn_color.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar == '.' && !txt_prc.Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }
        private void cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sucursal.SelectedIndex == -1)
            {
                btn_abr.Text = "Configurar stock";
                return;
            }
            if (idProductoEditar != null)
            {
                int idSucursal = Convert.ToInt32(cmb_sucursal.SelectedValue);
                List<DetalleStock> stock = CargarStockProducto(idProductoEditar.Value,idSucursal);

                int total = 0;

                foreach (DetalleStock detalle in stock)
                {
                    total += detalle.stock;
                }

                btn_abr.Text = total + " unidades";

                // IMPORTANTE:
                // Solo estamos mostrando el stock.
                // Todavía no lo marcamos como modificado.
                stockModificado = false;
            }
            else
            {
                btn_abr.Text = "Configurar stock";
                detallesStock.Clear();
                stockModificado = false;
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // se valida el código
            if (string.IsNullOrWhiteSpace(txt_cd.Text))
            {
                MessageBox.Show(
                    "Ingrese el código del producto.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_cd.Focus();
                return;
            }

            // valida nombre
            if (string.IsNullOrWhiteSpace(txt_nmb.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_nmb.Focus();
                return;
            }

            if (txt_nmb.Text.Trim().Length < 3)
            {
                MessageBox.Show(
                    "El nombre del producto debe tener al menos 3 caracteres.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_nmb.Focus();
                return;
            }

            // valida el precio
            decimal precio;

            if (!decimal.TryParse(txt_prc.Text, out precio))
            {
                MessageBox.Show(
                    "Ingrese un precio válido.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_prc.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show(
                    "El precio debe ser mayor que 0.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_prc.Focus();
                return;
            }

            // valida la categoria
            if (string.IsNullOrWhiteSpace(cmb_ctg.Text))
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Categoría obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmb_ctg.Focus();
                return;
            }

            // obtiene las tallas 
            List<string> tallasSeleccionadas = new List<string>();
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    tallasSeleccionadas.Add(item.Text);
                }
            }

            if (tallasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos una talla.",
                    "Talla obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // obtiene los colores
            List<string> coloresSeleccionados = new List<string>();

            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    coloresSeleccionados.Add(item.Text);
                }
            }

            if (coloresSeleccionados.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos un color.",
                    "Color obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // valida las sucursales
            if (cmb_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una sucursal.",
                    "Sucursal obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_sucursal.Focus();
                return;
            }

            // en un producto nuevo, editar el stock es obligatorio
            if (idProductoEditar == null && detallesStock.Count == 0)
            {
                MessageBox.Show(
                    "Configure el stock del producto.",
                    "Stock obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // convierte las lista a texto
            string tallas = string.Join(", ", tallasSeleccionadas);
            string colores = string.Join(", ", coloresSeleccionados);

            // ontiene datos
            string codigo = txt_cd.Text.Trim();
            string nombre = txt_nmb.Text.Trim();
            string categoria = cmb_ctg.Text.Trim();
            string estadoTexto = cmb_est.Text.Trim();

            // obtiene la id de la sucursal
            int idSucursal = Convert.ToInt32(cmb_sucursal.SelectedValue);

            // valida el estado
            if (string.IsNullOrWhiteSpace(estadoTexto))
            {
                MessageBox.Show(
                    "Seleccione el estado del producto.",
                    "Estado obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_est.Focus();
                return;
            }

            int estado;
            if (estadoTexto.Equals( "Activo", StringComparison.OrdinalIgnoreCase))
            {
                estado = 1;
            }
            else if (estadoTexto.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
            {
                estado = 0;
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un estado válido.",
                    "Estado inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_est.Focus();
                return;
            }

            csConectaSQL conexion = new csConectaSQL();
            // producto nuevo
            if (idProductoEditar == null)
            {
                string campos = "Codigo, Nombre, Categoria, Talla, Color, Precio, Estado";
                string datos =
                    $"'{codigo}', " +
                    $"'{nombre}', " +
                    $"'{categoria}', " +
                    $"'{tallas}', " +
                    $"'{colores}', " +
                    $"{precio.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                    $"{estado}";

                int idProducto = conexion.Ins_RetrID("Productos", campos, datos);
                if (idProducto == -1)
                {
                    MessageBox.Show(
                        "No se pudo guardar el producto.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // guarda el stock
                bool stockGuardado = Guardar_stock(idProducto,idSucursal);
                if (!stockGuardado)
                {
                    MessageBox.Show(
                        "El producto se guardó, pero no se pudo guardar el stock.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // guarda las imagenes
                if (rt.Count > 0)
                {
                    bool imagenesGuardadas = GuardarImagenesProducto(idProducto);
                    if (!imagenesGuardadas)
                    {
                        MessageBox.Show(
                            "El producto y el stock se guardaron, pero hubo un problema al guardar las imágenes.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show(
                    "Producto guardado correctamente.",
                    "Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            // edita el producto
            else
            {
                bool actualizado = conexion.ejecutarComando(@"updat Productos
                     set Codigo = @Codigo, Nombre = @Nombre, Categoria = @Categoria, Talla = @Talla,
                     Color = @Color, Precio = @Precio, Estado = @Estado where IdProductos = @IdProducto",
                        new SqlParameter("@Codigo",codigo),
                        new SqlParameter("@Nombre",nombre),
                        new SqlParameter("@Categoria",categoria),
                        new SqlParameter("@Talla",tallas),
                        new SqlParameter("@Color",colores),
                        new SqlParameter("@Precio",precio),
                        new SqlParameter("@Estado",estado),
                        new SqlParameter("@IdProducto",idProductoEditar.Value));

                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se pudo actualizar el producto.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // actualiza solo si entra en la configuración del stock
                if (stockModificado)
                {
                    bool stockActualizado = Actualizar_stock(idProductoEditar.Value,idSucursal);
                    if (!stockActualizado)
                    {
                        MessageBox.Show(
                            "El producto se actualizó, pero no se pudo actualizar el stock.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                // reemplaza la imagen solo si se seleccionan nuevas
                if (rt.Count > 0)
                {
                    bool eliminadas = conexion.ejecutarComando(@"delete from ProductoImagenes
                         where IdProductos = @id",
                         new SqlParameter("@id",idProductoEditar.Value));

                    if (!eliminadas)
                    {
                        MessageBox.Show(
                            "El producto se actualizó, pero no se pudieron reemplazar las imágenes.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    bool imagenesGuardadas = GuardarImagenesProducto(idProductoEditar.Value);
                    if (!imagenesGuardadas)
                    {
                        MessageBox.Show(
                            "El producto se actualizó, pero hubo un problema al guardar las nuevas imágenes.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show(
                    "Producto actualizado correctamente.",
                    "Actualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_subir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opn = new OpenFileDialog())
            {
                opn.Title = "Seleccionar imagen";
                opn.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                opn.Multiselect = true;

                if (opn.ShowDialog() == DialogResult.OK)
                {
                    if (opn.FileNames.Length > 5)
                    {
                        MessageBox.Show(
                            "No se pueden seleccionar más de 5 imágenes.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    foreach (PictureBox pic in piclist)
                    {
                        pic.Image = null;
                    }
                    rt.Clear();
                    for (int i = 0; i < opn.FileNames.Length; i++)
                    {
                        string ruta = opn.FileNames[i];
                        piclist[i].Image = Image.FromFile(ruta);
                        piclist[i].SizeMode = PictureBoxSizeMode.Zoom;
                        piclist1[i].Visible = false;
                        rt.Add(ruta);
                    }
                }
            }

        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (picSelect == null)
            {
                MessageBox.Show(
                    "Primero seleccione una imagen.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int posicion = piclist.IndexOf(picSelect);

            // Eliminar la ruta
            if (posicion >= 0 && posicion < rt.Count)
            {
                rt.RemoveAt(posicion);
            }

            // Reorganizar las imágenes
            for (int i = 0; i < piclist.Count; i++)
            {
                piclist[i].Image = null;

                if (i < rt.Count)
                {
                    piclist[i].Image = Image.FromFile(rt[i]);
                    piclist[i].SizeMode = PictureBoxSizeMode.Zoom;
                    piclist1[i].Visible = false;
                }
                else
                {
                    piclist1[i].Visible = true;
                }
            }
            if (picSelect != null)
            {
                picSelect.BorderStyle = BorderStyle.FixedSingle;
            }
            picSelect = null;
        }

        private void btn_abr_Click(object sender, EventArgs e)
        {
            // valida la sucursal
            if (cmb_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Primero seleccione una sucursal.",
                    "Sucursal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmb_sucursal.Focus();
                return;
            }

            bool hayTallas = false;
            bool hayColores = false;
            // comprueba las tallas
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    hayTallas = true;
                    break;
                }
            }

            // comprueba los colores
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    hayColores = true;
                    break;
                }
            }

            if (!hayTallas || !hayColores)
            {
                MessageBox.Show(
                    "Primero seleccione al menos una talla y un color.",
                    "Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            // obtiene las tallas que hayan
            List<string> tallas = new List<string>();
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    tallas.Add(item.Text);
                }
            }
            // obtiene los colores que hayan
            List<string> colores = new List<string>();
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    colores.Add(item.Text);
                }
            }
            int idSucursal = Convert.ToInt32(cmb_sucursal.SelectedValue);
            List<DetalleStock> stockActual = new List<DetalleStock>();
            // si esta en editar, se carga el stock sql
            if (idProductoEditar != null)
            {
                stockActual = CargarStockProducto(idProductoEditar.Value, idSucursal);
            }
            // si es un producto nuevo y ya se configuro el stock, conserva lo que ya haya guardado
            else if (detallesStock.Count > 0)
            {
                stockActual = detallesStock;
            }
            frmEditar_stock frm = new frmEditar_stock(tallas, colores, stockActual);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Right + 10, this.Top);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                int total = frm.S_total;
                detallesStock = frm.DetallesStock;
                btn_abr.Text = total + " unidades";
                stockModificado = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAgg_Categoria frmAgg_Categoria = new FrmAgg_Categoria();
            frmAgg_Categoria.StartPosition = FormStartPosition.Manual;
            frmAgg_Categoria.Location = new Point( this.Left - 10, this.Top
            );
            if (frmAgg_Categoria.ShowDialog(this) == DialogResult.OK)
            {
                string nuevaCategoria = frmAgg_Categoria.CategoriaCreada;
                cmb_ctg.Items.Add(nuevaCategoria);
                cmb_ctg.SelectedItem = nuevaCategoria;
            }
        }
    }
}
