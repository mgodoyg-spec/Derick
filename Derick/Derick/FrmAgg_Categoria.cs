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
        public FrmAgg_Categoria()
        {
            InitializeComponent();
        }
        private void FrmAgg_Categoria_Load(object sender, EventArgs e)
        {
            CM();
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
            if (estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                estado = 1;
            else
                estado = 0;
            csConectaSQL conexion = new csConectaSQL();
            string campos = "Nombre, Descripcion, Estado";
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
