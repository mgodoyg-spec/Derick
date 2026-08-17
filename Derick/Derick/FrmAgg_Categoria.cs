using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            int y = this.Top +
                    (this.Height - frm.Height) / 2;
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
                "SELECT Nombre, Descripcion, Estado " +
                "FROM Categorias " +
                "WHERE IdCategoria = " + idCategoriaEditar.Value
            );

            if (dt == null || dt.Rows.Count == 0)
                return;

            DataRow fila = dt.Rows[0];

            txt_ctg1.Text = fila["Nombre"].ToString();
            txt1.Text = fila["Descripcion"].ToString();

            bool activo = Convert.ToBoolean(fila["Estado"]);

            cmb_ctg.Text = activo ? "Activo" : "Inactivo";
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
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
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
            if (estadoTexto.Equals(
                "Activo",
                StringComparison.OrdinalIgnoreCase))
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
                string campos =
                    "Nombre, Descripcion, Estado";

                string datos =
                    $"'{nombre}', " +
                    $"'{descripcion}', " +
                    $"{estado}";

                bool guardado = conexion.insertDatos(
                    "Categorias",
                    campos,
                    datos
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

                MessageBox.Show(
                    "Categoría guardada correctamente.",
                    "Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string datos =
                    $"Nombre = '{nombre}', " +
                    $"Descripcion = '{descripcion}', " +
                    $"Estado = {estado}";

                string condicion =
                    $"IdCategoria = {idCategoriaEditar.Value}";

                bool actualizado = conexion.actualizarDatos(
                    "Categorias",
                    datos,
                    condicion
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
