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
        private int idPedidoSeleccionado = 0;
        private List<DetalleStock> detallesPedido = new List<DetalleStock>();
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
        public FormAgg_Product(int idSucursal, string nombreSucursal) : this()
        {
            idSucursalSeleccionada = idSucursal;
            nombreSucursalSeleccionada = nombreSucursal;
        }
        public FormAgg_Product(int idProducto, int idSucursal, string nombreSucursal, string talla, string color)
            : this(idSucursal, nombreSucursal)
        {
            idProductoEditar = idProducto;
            tallaEditar = talla;
            colorEditar = color;
        }
        private void FormAgg_Product_Load(object sender, EventArgs e)
        {
            C_CTG();

            // muestra la sucursal que viene del formulario productos
            cmb_sucursal.Items.Clear();
            cmb_sucursal.Items.Add(nombreSucursalSeleccionada);
            cmb_sucursal.SelectedIndex = 0;

            // evita cambiar la sucursal desde este formulario
            cmb_sucursal.Enabled = false;
            Cargar_productospedidos();
            if (idProductoEditar != null)
            {
                CP_editar();
                CargarImagenesEditar();
            }
        }
        private void Cargar_productospedidos()
        {
            csConectaSQL conexion = new csConectaSQL();
            string sql = @"select IdPedido, Producto from Pedidos where IdSucursal = " + idSucursalSeleccionada + @"
                   and Estado = 'Finalizado' order by Producto";

            DataTable dt = conexion.RetornaRegistros(sql);
            cmb_productos.DataSource = null;

            if (dt == null)
            {
                return;
            }

            DataRow fila = dt.NewRow();
            fila["IdPedido"] = 0;
            fila["Producto"] = "Seleccione un producto";
            dt.Rows.InsertAt(fila, 0);

            cmb_productos.DataSource = dt;
            cmb_productos.DisplayMember = "Producto";
            cmb_productos.ValueMember = "IdPedido";
            cmb_productos.SelectedIndex = 0;
        }
        private void Cargar_detallesPedido()
        {
            detallesPedido.Clear();

            csConectaSQL conexion = new csConectaSQL();

            string sql = @"select Talla, Color, Cantidad
                   from DetallePedidos
                   where IdPedido = " + idPedidoSeleccionado;

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
            {
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                DetalleStock detalle = new DetalleStock();

                detalle.Talla = fila["Talla"].ToString();
                detalle.Color = fila["Color"].ToString();
                detalle.stock = Convert.ToInt32(fila["Cantidad"]);

                detallesPedido.Add(detalle);
            }
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
                bool guardado = conexion.ejecutarComando(sql,
                    new SqlParameter("@IdProducto", idProducto),
                    new SqlParameter("@RutaImagen", nombreArchivo),
                    parametroImagen,
                    new SqlParameter("@EsPrincipal", esPrincipal));

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

            DataTable dt = conexion.RetornaRegistros(
                "select Codigo, Nombre, Categoria, Precio, Descripcion " +
                "from Productos where IdProductos = " + idProductoEditar.Value);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];

            // carga los datos generales del producto
            txt_cd.Text = fila["Codigo"].ToString();
            txt_dsp.Text = fila["Descripcion"].ToString();
            txt_prc.Text = Convert.ToDecimal(fila["Precio"]).ToString("0.00");
            cmb_ctg.Text = fila["Categoria"].ToString();

            // muestra el producto que se esta editando
            cmb_productos.DataSource = null;
            cmb_productos.Items.Clear();
            cmb_productos.Items.Add(fila["Nombre"].ToString());
            cmb_productos.SelectedIndex = 0;

            // no permite cambiar el producto mientras se edita
            cmb_productos.Enabled = false;

            // carga el estado de la variante seleccionada
            DataTable dtEstado = conexion.RetornaRegistros(@"select Stock, Estado from Inventario  where IdProducto = " + idProductoEditar.Value + @"
                     and IdSucursal = " + idSucursalSeleccionada + @" and Talla = '" + tallaEditar.Replace("'", "''") + @"'
                     and Color = '" + colorEditar.Replace("'", "''") + "'");

            if (dtEstado != null && dtEstado.Rows.Count > 0)
            {
                int stock = Convert.ToInt32(dtEstado.Rows[0]["Stock"]);
                bool activo = Convert.ToBoolean(dtEstado.Rows[0]["Estado"]);

                // guarda la variante actual en detallesStock
                detallesStock.Clear();
                DetalleStock detalle = new DetalleStock();
                detalle.Talla = tallaEditar;
                detalle.Color = colorEditar;
                detalle.stock = stock;

                detallesStock.Add(detalle);

                // muestra el estado actual
                if (activo)
                {
                    cmb_est.Text = "Activo";
                }

                if (!activo)
                {
                    cmb_est.Text = "Inactivo";
                }
                // muestra el stock actual
                btn_abr.Text = stock + " unidades";
            }
            stockModificado = false;
        }
        private bool Guardar_stock(int idProducto, int idSucursal, int estado)
        {
            csConectaSQL conexion = new csConectaSQL();

            bool guardar_algo = false;

            foreach (DetalleStock detalle in detallesStock)
            {
                if (detalle.stock <= 0)
                {
                    continue;
                }

                string consulta = @"select IdInventario, Stock from Inventario
                            where IdProducto = " + idProducto + @" and IdSucursal = " + idSucursal + @"
                            and Talla = '" + detalle.Talla.Replace("'", "''") + @"' and Color = '" + detalle.Color.Replace("'", "''") + "'";

                DataTable dt = conexion.RetornaRegistros(consulta);

                // la variante ya existe
                if (dt != null && dt.Rows.Count > 0)
                {
                    int idInventario = Convert.ToInt32(dt.Rows[0]["IdInventario"]);
                    int stockActual = Convert.ToInt32(dt.Rows[0]["Stock"]);
                    int nuevoStock = stockActual + detalle.stock;

                    bool actualizado = conexion.ejecutarComando(@"update Inventario set Stock = @Stock,
                                       Estado = @Estado where IdInventario = @IdInventario",
                        new SqlParameter("@Stock", nuevoStock),
                        new SqlParameter("@Estado", estado),
                        new SqlParameter("@IdInventario", idInventario)
                    );

                    if (!actualizado)
                    {
                        return false;
                    }

                    guardar_algo = true;
                }
                else
                {
                    // la variante no existe, se crea una nueva entrada en la tabla Inventario
                    string sql = @"insert into Inventario(IdProducto, IdSucursal, Talla, Color, Stock, Estado)
                           values(@IdProducto, @IdSucursal, @Talla, @Color, @Stock, @Estado)";

                    bool insertado = conexion.ejecutarComando(sql,
                        new SqlParameter("@IdProducto", idProducto),
                        new SqlParameter("@IdSucursal", idSucursal),
                        new SqlParameter("@Talla", detalle.Talla),
                        new SqlParameter("@Color", detalle.Color),
                        new SqlParameter("@Stock", detalle.stock),
                        new SqlParameter("@Estado", estado)
                    );
                    if (!insertado)
                    {
                        return false;
                    }
                    guardar_algo = true;
                }
            }
            return guardar_algo;
        }
        private bool Actualizar_stock_variante(int idProducto, int idSucursal, int estado)
        {
            if (detallesStock.Count == 0)
            {
                return false;
            }

            DetalleStock detalle = detallesStock[0];

            csConectaSQL conexion = new csConectaSQL();

            string sql = @"update Inventario set Stock = @Stock,Estado = @Estado where IdProducto = @IdProducto
                   and IdSucursal = @IdSucursal and Talla = @Talla and Color = @Color";

            bool actualizado = conexion.ejecutarComando(sql,
                new SqlParameter("@Stock", detalle.stock),
                new SqlParameter("@Estado", estado),
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@IdSucursal", idSucursal),
                new SqlParameter("@Talla", tallaEditar),
                new SqlParameter("@Color", colorEditar)
            );

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

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_productos.SelectedIndex <= 0)
            {
                idPedidoSeleccionado = 0;
                detallesPedido.Clear();
                return;
            }

            idPedidoSeleccionado = Convert.ToInt32(cmb_productos.SelectedValue);

            Cargar_detallesPedido();
        }

        private void pic2_e_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // valida el codigo
            if (txt_cd.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código del producto.");
                txt_cd.Focus();
                return;
            }

            // cuando es un producto nuevo debe venir de un pedido finalizado
            if (idProductoEditar == null)
            {
                if (cmb_productos.SelectedIndex <= 0 || idPedidoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un producto proveniente de un pedido finalizado.");
                    cmb_productos.Focus();
                    return;
                }
            }

            // valida la categoria
            if (cmb_ctg.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                cmb_ctg.Focus();
                return;
            }

            // valida el precio
            if (txt_prc.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio del producto.");
                txt_prc.Focus();
                return;
            }

            decimal precio;

            if (!decimal.TryParse(txt_prc.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                txt_prc.Focus();
                return;
            }

            // valida la sucursal
            if (idSucursalSeleccionada == 0)
            {
                MessageBox.Show("No se ha seleccionado una sucursal.");
                return;
            }

            // valida el estado
            int estado = 0;

            if (cmb_est.Text == "Activo")
            {
                estado = 1;
            }

            if (cmb_est.Text == "Inactivo")
            {
                estado = 0;
            }

            // valida el stock solamente al agregar
            if (idProductoEditar == null)
            {
                if (detallesStock.Count == 0)
                {
                    MessageBox.Show("Configure el stock del producto.");
                    return;
                }
            }

            csConectaSQL conexion = new csConectaSQL();

            // nombre del producto
            string nombre = "";

            if (idProductoEditar == null)
            {
                nombre = cmb_productos.Text.Trim();
            }

            //agregar prioducto nuevo
            if (idProductoEditar == null)
            {
                // verifica si ya existe el codigo
                DataTable dtCodigo = conexion.RetornaRegistros("select IdProductos from Productos where Codigo = '" +
                    txt_cd.Text.Trim().Replace("'", "''") + "'");

                if (dtCodigo != null && dtCodigo.Rows.Count > 0)
                {
                    int idProductoExistente = Convert.ToInt32(dtCodigo.Rows[0]["IdProductos"]);

                    // el producto ya existe, solamente agrega el stock
                    bool stockGuardado = Guardar_stock(idProductoExistente,idSucursalSeleccionada,estado);
                    if (!stockGuardado)
                    {
                        MessageBox.Show("No se pudo guardar el stock.");
                        return;
                    }

                    MessageBox.Show("El stock del producto se actualizó correctamente.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    return;
                }

                // inserta el producto nuevo
                string sqlProducto = @"insert into Productos(Codigo, Nombre, Categoria, Precio, Descripcion, Estado)
                      values(@Codigo, @Nombre, @Categoria, @Precio, @Descripcion, @Estado)";

                SqlParameter[] parametros = {new SqlParameter("@Codigo", txt_cd.Text.Trim()),new SqlParameter("@Nombre", nombre),
                      new SqlParameter("@Categoria", cmb_ctg.Text),new SqlParameter("@Precio", precio),new SqlParameter("@Descripcion", txt_dsp.Text.Trim()),
                      new SqlParameter("@Estado", estado)};

                int idProducto = conexion.EjecutarConRetorno(sqlProducto,parametros);
                if (idProducto <= 0)
                {
                    MessageBox.Show("No se pudo registrar el producto.");
                    return;
                }

                // guarda las combinaciones de talla, color y stock
                bool guardoStock = Guardar_stock(idProducto,idSucursalSeleccionada,estado);
                if (!guardoStock)
                {
                    MessageBox.Show("El producto se registró, pero no se pudo guardar el stock.");
                    return;
                }

                MessageBox.Show("Producto registrado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();

                return;
            }

            // edita un producto existente

            // verifica si el codigo pertenece a otro producto
            DataTable dtCodigoEditar = conexion.RetornaRegistros(
                "select IdProductos from Productos where Codigo = '" +
                txt_cd.Text.Trim().Replace("'", "''") + "'");

            if (dtCodigoEditar != null && dtCodigoEditar.Rows.Count > 0)
            {
                int idCodigo = Convert.ToInt32(dtCodigoEditar.Rows[0]["IdProductos"]);
                if (idCodigo != idProductoEditar.Value)
                {
                    MessageBox.Show("El código ya pertenece a otro producto.");
                    txt_cd.Focus();
                    return;
                }
            }

            // actualiza los datos generales del producto
            string sqlActualizar = @"update Productos set Codigo = @Codigo, Categoria = @Categoria, Precio = @Precio,
                             Descripcion = @Descripcion where IdProductos = @IdProducto";

            bool productoActualizado = conexion.ejecutarComando(sqlActualizar,
                new SqlParameter("@Codigo", txt_cd.Text.Trim()),
                new SqlParameter("@Categoria", cmb_ctg.Text),
                new SqlParameter("@Precio", precio),
                new SqlParameter("@Descripcion", txt_dsp.Text.Trim()),
                new SqlParameter("@IdProducto", idProductoEditar.Value)
            );

            if (!productoActualizado)
            {
                MessageBox.Show("No se pudo actualizar el producto.");
                return;
            }

            // actualiza el stock y estado de la variante seleccionada
            if (detallesStock.Count == 0)
            {
                MessageBox.Show("No se encontró la variante del producto.");
                return;
            }

            bool varianteActualizada = Actualizar_stock_variante(
                idProductoEditar.Value,
                idSucursalSeleccionada,
                estado);

            if (!varianteActualizada)
            {
                MessageBox.Show("No se pudo actualizar la variante del producto.");
                return;
            }

            MessageBox.Show("Producto actualizado correctamente.");

            this.DialogResult = DialogResult.OK;
            this.Close();
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
                        if (pic.Image != null)
                        {
                            pic.Image.Dispose();
                            pic.Image = null;
                        }
                    }

                    foreach (PictureBox pic in piclist1)
                    {
                        pic.Visible = true;
                    }

                    rt.Clear();
                    picSelect = null;

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
            // si estamos editando un producto existente
            if (idProductoEditar != null)
            {
                if (detallesStock.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontró el stock de la variante.",
                        "Sin stock",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // crea una lista solamente con la variante que se está editando
                List<DetalleStock> stockEditar = new List<DetalleStock>();

                DetalleStock detalle = new DetalleStock();
                detalle.Talla = tallaEditar;
                detalle.Color = colorEditar;
                detalle.stock = detallesStock[0].stock;

                stockEditar.Add(detalle);

                // abre el formulario para modificar el stock
                frmEditar_stock frm = new frmEditar_stock(stockEditar);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    detallesStock = frm.DetallesStock;

                    int total = 0;

                    foreach (DetalleStock detalleStock in detallesStock)
                    {
                        total += detalleStock.stock;
                    }

                    btn_abr.Text = total + " unidades";

                    stockModificado = true;
                }

                return;
            }

            // si estamos agregando un producto nuevo
            if (idSucursalSeleccionada == 0)
            {
                MessageBox.Show(
                    "No se ha seleccionado una sucursal.",
                    "Sucursal obligatoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmb_productos.SelectedIndex <= 0 || idPedidoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto proveniente de un pedido finalizado.",
                    "Producto obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_productos.Focus();
                return;
            }

            if (detallesPedido == null || detallesPedido.Count == 0)
            {
                MessageBox.Show(
                    "El pedido seleccionado no tiene tallas y colores registrados.",
                    "Sin detalles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // abre el formulario con las combinaciones que llegaron en el pedido
            frmEditar_stock frmPedido = new frmEditar_stock(detallesPedido);

            if (frmPedido.ShowDialog() == DialogResult.OK)
            {
                detallesStock = frmPedido.DetallesStock;

                int total = 0;

                foreach (DetalleStock detalleStock in detallesStock)
                {
                    total += detalleStock.stock;
                }

                btn_abr.Text = total + " unidades";

                stockModificado = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAgg_Categoria frmAgg_Categoria = new FrmAgg_Categoria();
            frmAgg_Categoria.StartPosition = FormStartPosition.Manual;
            frmAgg_Categoria.Location = new Point(this.Left - 10, this.Top
            );
            if (frmAgg_Categoria.ShowDialog(this) == DialogResult.OK)
            {
                string nuevaCategoria = frmAgg_Categoria.CategoriaCreada;
                cmb_ctg.Items.Add(nuevaCategoria);
                cmb_ctg.SelectedItem = nuevaCategoria;
            }
        }

        private void pnlcont1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
