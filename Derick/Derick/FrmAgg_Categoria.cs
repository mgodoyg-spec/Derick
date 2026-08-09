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
        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
