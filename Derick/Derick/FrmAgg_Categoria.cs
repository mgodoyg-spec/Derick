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
        public FrmAgg_Categoria()
        {
            InitializeComponent();
            CM();
        }

        private void FrmAgg_Categoria_Load(object sender, EventArgs e)
        {

        }
        private void CM()
        {
            ctmCategoria.Items.Clear();

            ToolStripMenuItem opcion1 = new ToolStripMenuItem("Ropa");
            ToolStripMenuItem opcion2 = new ToolStripMenuItem("Calzado");

            ctmCategoria.Items.Add(opcion1);
            ctmCategoria.Items.Add(opcion2);
        }

        private void btn_abajo_Click(object sender, EventArgs e)
        {
            ctmCategoria.Show(btn_abajo,new Point(0, btn_abajo.Height));
        }
    }
}
