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
        private int idSucursalSeleccionada;
        private string nombreSucursalSeleccionada = "";
        private int? idProductoEditar = null;
        private string tallaEditar = "";
        private string colorEditar = "";

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
        public FormAgg_Product(int idSucursal,string nombreSucursal): this()
        {
            idSucursalSeleccionada = idSucursal;
            nombreSucursalSeleccionada = nombreSucursal;
        }
        public FormAgg_Product(int idProducto, int idSucursal, string nombreSucursal, string talla, string color)
            :this(idSucursal, nombreSucursal)
        {
            idProductoEditar = idProducto;
            tallaEditar = talla;
            colorEditar = color;
        }
        private void FormAgg_Product_Load(object sender, EventArgs e)
        {
            CTalla();
            CTColor();
            C_CTG();

            // muestra la sucursal que viene del formulario productos
            cmb_sucursal.Items.Clear();
            cmb_sucursal.Items.Add(nombreSucursalSeleccionada);
            cmb_sucursal.SelectedIndex = 0;

            // evita cambiar la sucursal desde este formulario
            cmb_sucursal.Enabled = false;
            if (idProductoEditar != null)
            {
                CP_editar();
                CargarImagenesEditar();
            }
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

            DataTable dt = conexion.RetornaRegistros("select Codigo, Nombre, Categoria, Precio, Descripcion " +
                "from Productos where IdProductos = " + idProductoEditar.Value);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];

            txt_cd.Text = fila["Codigo"].ToString();
            txt_nmb.Text = fila["Nombre"].ToString();
            cmb_ctg.Text = fila["Categoria"].ToString();
            txt_prc.Text = Convert.ToDecimal(fila["Precio"]).ToString("0.00");
            txt_dsp.Text = fila["Descripcion"].ToString();

            // carga el estado de la variante seleccionada
            DataTable dtEstado = conexion.RetornaRegistros(@"select Estado from Inventario
                     where IdProducto = " + idProductoEditar.Value + @"
                     and IdSucursal = " + idSucursalSeleccionada + @"
                     and Talla = '" + tallaEditar.Replace("'", "''") + @"'
                     and Color = '" + colorEditar.Replace("'", "''") + "'");

            if (dtEstado != null && dtEstado.Rows.Count > 0)
            {
                bool activo = Convert.ToBoolean(dtEstado.Rows[0]["Estado"]);

                if (activo)
                {
                    cmb_est.Text = "Activo";
                }

                if (!activo)
                {
                    cmb_est.Text = "Inactivo";
                }
            }

            // marca solamente la talla seleccionada
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    item.Checked = false;

                    if (item.Text.Equals(tallaEditar, StringComparison.OrdinalIgnoreCase))
                    {
                        item.Checked = true;
                    }
                }
            }

            // marca solamente el color seleccionado
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item)
                {
                    item.Checked = false;

                    if (item.Text.Equals(colorEditar, StringComparison.OrdinalIgnoreCase))
                    {
                        item.Checked = true;
                    }
                }
            }

            // carga solamente el stock de la variante seleccionada
            List<DetalleStock> stock = CargarStockProducto(idProductoEditar.Value, idSucursalSeleccionada);

            detallesStock.Clear();

            foreach (DetalleStock detalle in stock)
            {
                if (detalle.Talla.Equals(tallaEditar, StringComparison.OrdinalIgnoreCase) &&
                    detalle.Color.Equals(colorEditar, StringComparison.OrdinalIgnoreCase))
                {
                    DetalleStock detalleEditar = new DetalleStock();
                    detalleEditar.Talla = detalle.Talla;
                    detalleEditar.Color = detalle.Color;
                    detalleEditar.stock = detalle.stock;

                    detallesStock.Add(detalleEditar);

                    btn_abr.Text = detalle.stock + " unidades";
                    break;
                }
            }
            stockModificado = false;
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
        private bool Guardar_stock(int idProducto, int idSucursal, int estado)
        {
            csConectaSQL conexion = new csConectaSQL();
            foreach (DetalleStock detalle in detallesStock)
            {
                // solo guarda combinaciones que tengan stock
                if (detalle.stock > 0)
                {
                    string sql = @"insert into Inventario(IdProducto, IdSucursal, Talla,
                Color, Stock, Estado) values (@IdProducto, @IdSucursal, @Talla,
                @Color, @Stock, @Estado)";
                    bool resultado = conexion.ejecutarComando(sql,
                        new SqlParameter("@IdProducto", idProducto),
                        new SqlParameter("@IdSucursal", idSucursal),
                        new SqlParameter("@Talla", detalle.Talla),
                        new SqlParameter("@Color", detalle.Color),
                        new SqlParameter("@Stock", detalle.stock),
                        new SqlParameter("@Estado", estado));

                    if (!resultado)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Actualizar_stock(int idProducto, int idSucursal)
        {
            csConectaSQL conexion = new csConectaSQL();
            try
            {
                // elimina el stock anterior solamente de la sucursal seleccionada
                bool eliminado = conexion.ejecutarComando(@"delete from Inventario
                    where IdProducto = @IdProducto and IdSucursal = @IdSucursal",
                    new SqlParameter("@IdProducto", idProducto),
                    new SqlParameter("@IdSucursal", idSucursal));

                if (!eliminado)
                {
                    return false;
                }
                // guarda nuevamente las combinaciones actuales
                foreach (DetalleStock detalle in detallesStock)
                {
                    // no guarda combinaciones con stock 0
                    if (detalle.stock > 0)
                    {
                        string sql = @"insert into Inventario (IdProducto, IdSucursal, Talla, Color, Stock)
                            values(@IdProducto, @IdSucursal, @Talla, @Color, @Stock)";
                        bool insertado = conexion.ejecutarComando(sql,
                            new SqlParameter("@IdProducto", idProducto),
                            new SqlParameter("@IdSucursal", idSucursal),
                            new SqlParameter("@Talla", detalle.Talla),
                            new SqlParameter("@Color", detalle.Color),
                            new SqlParameter("@Stock", detalle.stock));

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
        private bool Actualizar_stock_variante(int idProducto, int idSucursal, int estado)
        {
            if (detallesStock.Count == 0)
            {
                return false;
            }

            DetalleStock detalle = detallesStock[0];

            csConectaSQL conexion = new csConectaSQL();

            // comprueba si la nueva talla y color ya existen
            string consulta = @"select IdInventario from Inventario
                  where IdProducto = " + idProducto + @"
                  and IdSucursal = " + idSucursal + @"
                  and Talla = '" + detalle.Talla.Replace("'", "''") + @"'
                  and Color = '" + detalle.Color.Replace("'", "''") + @"'
                  and not (Talla = '" + tallaEditar.Replace("'", "''") + @"'
                  and Color = '" + colorEditar.Replace("'", "''") + "')";

            DataTable dt = conexion.RetornaRegistros(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Ya existe una variante con esa talla y color.",
                    "Variante existente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            bool actualizado = conexion.ejecutarComando(@"update Inventario
                set Talla = @TallaNueva, Color = @ColorNuevo,
                Stock = @Stock, Estado = @Estado
                where IdProducto = @IdProducto and IdSucursal = @IdSucursal
                and Talla = @TallaAnterior and Color = @ColorAnterior",
                new SqlParameter("@TallaNueva", detalle.Talla),
                new SqlParameter("@ColorNuevo", detalle.Color),
                new SqlParameter("@Stock", detalle.stock),
                new SqlParameter("@Estado", estado),
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@IdSucursal", idSucursal),
                new SqlParameter("@TallaAnterior", tallaEditar),
                new SqlParameter("@ColorAnterior", colorEditar));

            return actualizado;
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
                int idSucursal = idSucursalSeleccionada;
                List<DetalleStock> stock = CargarStockProducto(idProductoEditar.Value, idSucursal);
                int total = 0;
                foreach (DetalleStock detalle in stock)
                {
                    total += detalle.stock;
                }
                btn_abr.Text = total + " unidades";

                // solo estamos mostrando el stock
                // todavía no lo marcamos como modificado
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

            string precioTexto = txt_prc.Text.Trim().Replace(",", ".");

            if (!decimal.TryParse(
                precioTexto,
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture,
                out precio))
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

            // valida la sucursal
            if (idSucursalSeleccionada <= 0)
            {
                MessageBox.Show(
                    "No se ha seleccionado una sucursal válida.",
                    "Sucursal obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // en producto nuevo el stock es obligatorio
            if (idProductoEditar == null && detallesStock.Count == 0)
            {
                MessageBox.Show(
                    "Configure el stock del producto.",
                    "Stock obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // obtiene datos
            string codigo = txt_cd.Text.Trim();
            string nombre = txt_nmb.Text.Trim();
            string categoria = cmb_ctg.Text.Trim();
            string descripcion = txt_dsp.Text.Trim();
            string estadoTexto = cmb_est.Text.Trim();

            int idSucursal = idSucursalSeleccionada;

            // valida el estado
            int estado = 0;

            if (estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase))
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
                int idProducto = 0;
                bool productoExistente = false;

                string consultaCodigo = @"select IdProductos, Codigo, Nombre from Productos where Codigo = '" +
                    codigo.Replace("'", "''") + "'";

                DataTable dtCodigo = conexion.RetornaRegistros(consultaCodigo);

                if (dtCodigo != null && dtCodigo.Rows.Count > 0)
                {
                    string nombreGuardado = dtCodigo.Rows[0]["Nombre"].ToString();

                    if (!nombreGuardado.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "El código ingresado ya pertenece al producto \"" +
                            nombreGuardado + "\".",
                            "Código existente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txt_cd.Focus();
                        return;
                    }

                    idProducto = Convert.ToInt32(dtCodigo.Rows[0]["IdProductos"]);
                    productoExistente = true;
                }

                if (productoExistente)
                {
                    string consultaSucursal = @"select IdInventario from Inventario
                          where IdProducto = " + idProducto + @" and IdSucursal = " + idSucursal;

                    DataTable dtSucursal = conexion.RetornaRegistros(consultaSucursal);

                    if (dtSucursal != null && dtSucursal.Rows.Count > 0)
                    {
                        MessageBox.Show(
                            "Este producto ya se encuentra registrado en esta sucursal.",
                            "Producto existente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    bool stockGuardado = Guardar_stock(idProducto, idSucursal, estado);

                    if (!stockGuardado)
                    {
                        MessageBox.Show(
                            "No se pudo guardar el stock del producto en la sucursal.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    MessageBox.Show(
                        "Producto agregado correctamente a la sucursal.",
                        "Guardado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                if (!productoExistente)
                {
                    string campos = "Codigo, Nombre, Categoria, Precio, Estado, Descripcion";

                    string datos =
                        $"'{codigo.Replace("'", "''")}', " +
                        $"'{nombre.Replace("'", "''")}', " +
                        $"'{categoria.Replace("'", "''")}', " +
                        $"{precio.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                        $"{estado}, " +
                        $"'{descripcion.Replace("'", "''")}'";

                    idProducto = conexion.Ins_RetrID("Productos", campos, datos);

                    if (idProducto == -1)
                    {
                        MessageBox.Show(
                            "No se pudo guardar el producto.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    bool stockGuardado = Guardar_stock(idProducto, idSucursal, estado);

                    if (!stockGuardado)
                    {
                        MessageBox.Show(
                            "El producto se guardó, pero no se pudo guardar el stock.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

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
            }

            // edita el producto
            if (idProductoEditar != null)
            {
                string consultaCodigo = @"select IdProductos from Productos where Codigo = '" +
                    codigo.Replace("'", "''") + "' and IdProductos <> " + idProductoEditar.Value;

                DataTable dtCodigo = conexion.RetornaRegistros(consultaCodigo);

                if (dtCodigo != null && dtCodigo.Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Ya existe otro producto con ese código.",
                        "Código duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_cd.Focus();
                    return;
                }

                // actualiza datos generales
                bool actualizado = conexion.ejecutarComando(@"update Productos
                    set Codigo = @Codigo, Nombre = @Nombre, Categoria = @Categoria,
                    Precio = @Precio, Descripcion = @Descripcion where IdProductos = @IdProducto",
                    new SqlParameter("@Codigo", codigo),
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@Categoria", categoria),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@Descripcion", descripcion),
                    new SqlParameter("@IdProducto", idProductoEditar.Value));

                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se pudo actualizar el producto.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // si modificó talla, color o stock
                if (stockModificado)
                {
                    bool varianteActualizada = Actualizar_stock_variante(
                        idProductoEditar.Value,
                        idSucursal,
                        estado);

                    if (!varianteActualizada)
                    {
                        return;
                    }
                }
                else
                {
                    // actualiza únicamente el estado de esta variante
                    bool estadoActualizado = conexion.ejecutarComando(@"update Inventario
                        set Estado = @Estado where IdProducto = @IdProducto
                        and IdSucursal = @IdSucursal and Talla = @Talla and Color = @Color",
                        new SqlParameter("@Estado", estado),
                        new SqlParameter("@IdProducto", idProductoEditar.Value),
                        new SqlParameter("@IdSucursal", idSucursal),
                        new SqlParameter("@Talla", tallaEditar),
                        new SqlParameter("@Color", colorEditar));

                    if (!estadoActualizado)
                    {
                        MessageBox.Show(
                            "No se pudo actualizar el estado.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }
                }

                // reemplaza imágenes solo si seleccionó nuevas
                if (rt.Count > 0)
                {
                    bool eliminadas = conexion.ejecutarComando(@"delete from ProductoImagenes
                        where IdProductos = @id",
                        new SqlParameter("@id", idProductoEditar.Value));

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
            if (idSucursalSeleccionada <= 0)
            {
                MessageBox.Show(
                    "Primero seleccione una sucursal.",
                    "Sucursal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

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
                    "Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // al editar solamente permite una talla y un color
            if (idProductoEditar != null)
            {
                if (tallas.Count > 1)
                {
                    MessageBox.Show(
                        "Al editar una variante solamente puede seleccionar una talla.",
                        "Editar variante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (colores.Count > 1)
                {
                    MessageBox.Show(
                        "Al editar una variante solamente puede seleccionar un color.",
                        "Editar variante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            List<DetalleStock> stockActual = new List<DetalleStock>();

            // si esta editando carga solamente el stock de la variante seleccionada
            if (idProductoEditar != null)
            {
                List<DetalleStock> stockProducto = CargarStockProducto(
                    idProductoEditar.Value,
                    idSucursalSeleccionada
                );

                int stockAnterior = 0;

                foreach (DetalleStock detalle in stockProducto)
                {
                    if (detalle.Talla.Equals(tallaEditar, StringComparison.OrdinalIgnoreCase) &&
                        detalle.Color.Equals(colorEditar, StringComparison.OrdinalIgnoreCase))
                    {
                        stockAnterior = detalle.stock;
                        break;
                    }
                }

                DetalleStock detalleActual = new DetalleStock();
                detalleActual.Talla = tallas[0];
                detalleActual.Color = colores[0];
                detalleActual.stock = stockAnterior;

                stockActual.Add(detalleActual);
            }

            // si es producto nuevo conserva el stock configurado
            if (idProductoEditar == null && detallesStock.Count > 0)
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
