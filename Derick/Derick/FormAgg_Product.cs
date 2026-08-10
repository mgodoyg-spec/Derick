using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections;
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
        private List<PictureBox> piclist;
        private List<PictureBox> piclist1;
        private List<string> rt = new List<string>();
        private PictureBox? picSelect = null;
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
            // Cuando presiones "+ Agregar talla"
            agregarTalla.Click += Agg_Tallas_Click;
            cmTallas.Items.Add(agregarTalla);
        }
        private void CTColor()
        {
            cmColores.Items.Clear();
            string[] clrs = { "Negro", "Azul", "Blanco" };
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
        private void btn_guardar_Click(object sender, EventArgs e)
        {
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

            MessageBox.Show(
                "Datos válidos.",
                "Correcto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
            bool hayTallas = false;
            bool hayColores = false;
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    hayTallas = true;
                    break;
                }
            }
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

            // Listas para guardar las selecciones
            List<string> tallas = new List<string>();
            List<string> colores = new List<string>();
            foreach (ToolStripItem elemento in cmTallas.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    tallas.Add(item.Text);
                }
            }
            foreach (ToolStripItem elemento in cmColores.Items)
            {
                if (elemento is ToolStripMenuItem item && item.Checked)
                {
                    colores.Add(item.Text);
                }
            }
            frmEditar_stock frm = new frmEditar_stock(tallas, colores);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(
                this.Right + 10,
                this.Top
            );
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                int total = frm.S_total;
                btn_abr.Text = total + " unidades";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAgg_Categoria frmAgg_Categoria = new FrmAgg_Categoria();
            frmAgg_Categoria.StartPosition = FormStartPosition.Manual;
            frmAgg_Categoria.Location = new Point(
                this.Left - 10,
                this.Top
            );
            frmAgg_Categoria.ShowDialog(this);
        }
    }
}
