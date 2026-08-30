using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;

namespace Derick
{
    public partial class FrmAgg_Categoria : Form
    {
        private Image? iconoCategoria = null;
        public string CategoriaCreada { get; private set; } = "";
        private int? idCategoriaEditar = null;

        public FrmAgg_Categoria()
        {
            InitializeComponent();
        }

        private byte[] ImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public FrmAgg_Categoria(int idCategoria) : this()
        {
            idCategoriaEditar = idCategoria;
        }

        private void FrmAgg_Categoria_Load(object sender, EventArgs e)
        {
            CM();
            if (idCategoriaEditar != null)
            {
                CC_editar();
            }
        }

        private void AggIcons_Click(object sender, EventArgs e)
        {
            frm_secundario3 frm = new frm_secundario3();
            frm.StartPosition = FormStartPosition.Manual;
            int x = this.Right + 10;
            int y = this.Top + (this.Height - frm.Height) / 2;
            frm.Location = new Point(x, y);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                iconoCategoria = frm.IconoSeleccionado;
                lbl_icono.Text = frm.NombreIconoSeleccionado;
            }
        }

        private void CM()
        {
            ctmCategoria.Items.Clear();
            ToolStripMenuItem agregar = new ToolStripMenuItem("+ Agregar ícono");
            agregar.Click += AggIcons_Click;
            ctmCategoria.Items.Add(agregar);
        }

        private void CC_editar()
        {
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(
                "select Nombre, Descripcion, Estado, Imagen " +
                "from Categorias where IdCategoria = " + idCategoriaEditar.Value);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];
            txt_ctg1.Text = fila["Nombre"].ToString();
            txt1.Text = fila["Descripcion"].ToString();
            bool activo = Convert.ToBoolean(fila["Estado"]);
            cmb_ctg.Text = activo ? "Activo" : "Inactivo";

            if (fila["Imagen"] != DBNull.Value)
            {
                byte[] bytes = (byte[])fila["Imagen"];

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    using (Image temporal = Image.FromStream(ms))
                    {
                        iconoCategoria = new Bitmap(temporal);
                    }
                }

                lbl_icono.Text = "Ícono cargado";
            }
        }

        private void btn_abajo_Click(object sender, EventArgs e)
        {
            ctmCategoria.Width = lbl_icono.Width;
            ctmCategoria.Show(lbl_icono, new Point(0, lbl_icono.Height));
            btn_abajo.Visible = false;
            btn_arriba.Visible = true;
        }

        private void btn_arriba_Click(object sender, EventArgs e)
        {
            ctmCategoria.Close();
            btn_arriba.Visible = false;
            btn_abajo.Visible = true;
        }

        private void ctmCategoria_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            btn_arriba.Visible = false;
            btn_abajo.Visible = true;
        }

        private void txt_ctg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_grd_Click(object sender, EventArgs e)
        {
            string nombre = txt_ctg1.Text.Trim();
            string descripcion = txt1.Text.Trim();
            string estadoTexto = cmb_ctg.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la categoría.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_ctg1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(estadoTexto))
            {
                MessageBox.Show(
                    "Seleccione un estado.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmb_ctg.Focus();
                return;
            }

            int estado;

            if (estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase))
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }

            csConectaSQL conexion = new csConectaSQL();

            if (idCategoriaEditar == null)
            {
                string sql = @"insert into Categorias(Nombre, Descripcion, Estado, Imagen)
                               values(@Nombre, @Descripcion, @Estado, @Imagen)";

                SqlParameter parametroImagen =
                    new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);

                if (iconoCategoria != null)
                {
                    parametroImagen.Value = ImagenABytes(iconoCategoria);
                }
                else
                {
                    parametroImagen.Value = DBNull.Value;
                }

                bool guardado = conexion.ejecutarComando(
                    sql,
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@Descripcion", descripcion),
                    new SqlParameter("@Estado", estado),
                    parametroImagen
                );

                if (!guardado)
                {
                    MessageBox.Show(
                        "No se pudo guardar la categoría.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CategoriaCreada = nombre;

                conexion.RegistrarActividad(
                    "Se agregó la categoría " + nombre
                );

                MessageBox.Show(
                    "Categoría guardada correctamente.",
                    "Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string sql = @"update Categorias
                               set Nombre = @Nombre,
                                   Descripcion = @Descripcion,
                                   Estado = @Estado,
                                   Imagen = @Imagen
                               where IdCategoria = @IdCategoria";

                SqlParameter parametroImagen =
                    new SqlParameter("@Imagen", SqlDbType.VarBinary, -1);

                if (iconoCategoria != null)
                {
                    parametroImagen.Value = ImagenABytes(iconoCategoria);
                }
                else
                {
                    parametroImagen.Value = DBNull.Value;
                }

                bool actualizado = conexion.ejecutarComando(
                    sql,
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@Descripcion", descripcion),
                    new SqlParameter("@Estado", estado),
                    parametroImagen,
                    new SqlParameter("@IdCategoria", idCategoriaEditar.Value)
                );

                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se pudo actualizar la categoría.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                conexion.RegistrarActividad(
                    "Se editó la categoría " + nombre
                );

                MessageBox.Show(
                    "Categoría actualizada correctamente.",
                    "Actualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}