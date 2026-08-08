using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormAgg_Product : Form
    {
        public FormAgg_Product()
        {
            InitializeComponent();

        }
        private void FormAgg_Product_Load(object sender, EventArgs e)
        {
            CTalla();
            CTColor();
        }
        private void CTalla()
        {
            cmTallas.Items.Clear();
            string[] tlls = { "S", "M", "L", };
            foreach (string tll in tlls)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(tll);
                item.CheckOnClick = true;
                item.CheckedChanged += Talla_CheckedChanged;

                cmTallas.Items.Add(item);
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
            string[] clrs = { "Negro", "Azul", "Blanco"};
            foreach (string clr in clrs)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(clr);
                item.CheckOnClick = true;
                item.CheckedChanged += Color_CheckedChanged;

                cmColores.Items.Add(item);
            }

            cmColores.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem agregarColor = new ToolStripMenuItem();
            agregarColor.Text = "+ Agregar color";
            agregarColor.Click += Agg_Colores_Click;

            cmColores.Items.Add(agregarColor);
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
        private void Agg_Tallas_Click(object sender, EventArgs e)
        {
            //Formulario para agregar una nueva talla
        }
        private void Agg_Colores_Click(object sender, EventArgs e)
        {
            //Formulario para agregar un nuevo color
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
    }
}
