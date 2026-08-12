using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Derick
{
    public partial class frm_secundario3 : Form
    {
        private static List<(string Nombre, Image Imagen)> iconsG= new List<(string, Image)>();
        private Image? iconoSeleccionado = null;
        private string nombreIconoSeleccionado = "";
        public Image? IconoSeleccionado
        {
            get { return iconoSeleccionado; }
        }
        public string NombreIconoSeleccionado
        {
            get { return nombreIconoSeleccionado; }
        }
        public frm_secundario3()
        {
            InitializeComponent();
        }
        private void frm_secundario3_Load(object sender, EventArgs e)
        {
            flp_icons.Controls.Clear();
            foreach (var icono in iconsG)
            {
                AgregarIconoAlFlow(
                    icono.Nombre,
                    icono.Imagen
                );
            }
        }
        private void AgregarIconoAlFlow(string nombre, Image imagen)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(78, 68);
            tarjeta.Margin = new Padding(4);
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Cursor = Cursors.Hand;

            PictureBox pic = new PictureBox();
            pic.Size = new Size(30, 30);
            pic.Location = new Point(24, 5);
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;

            Label lbl = new Label();
            lbl.Text = nombre;
            lbl.Size = new Size(70, 20);
            lbl.Location = new Point(4, 42);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 7.5F);
            lbl.Cursor = Cursors.Hand;

            tarjeta.Click += (s, e) => SeleccionarIcono(tarjeta, nombre, imagen);
            pic.Click += (s, e) => SeleccionarIcono(tarjeta, nombre, imagen);
            lbl.Click += (s, e) => SeleccionarIcono(tarjeta, nombre, imagen);
            tarjeta.Controls.Add(pic);
            tarjeta.Controls.Add(lbl);
            flp_icons.Controls.Add(tarjeta);
        }
        private void SeleccionarIcono(Panel tarjeta, string nombre, Image imagen)
        {
            foreach (Control control in flp_icons.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = Color.White;
                }
            }
            tarjeta.BackColor = Color.FromArgb(225, 235, 250);
            iconoSeleccionado = imagen;
            nombreIconoSeleccionado = nombre;
        }
        private void pnl_icons4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar ícono";
                ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image imagen;
                    using (Image temporal = Image.FromFile(ofd.FileName))
                    {
                        imagen = new Bitmap(temporal);
                    }
                    string nombre = Interaction.InputBox(
                        "Ingrese el nombre del ícono:",
                        "Nombre del ícono",
                        ""
                    ).Trim();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        MessageBox.Show(
                            "Debe ingresar un nombre para el ícono.",
                            "Ícono",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        imagen.Dispose();
                        return;
                    }
                    // Verificar que no se repita el nombre
                    foreach (var icono in iconsG)
                    {
                        if (icono.Nombre.Equals(
                            nombre,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "Ya existe un ícono con ese nombre.",
                                "Ícono duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            imagen.Dispose();
                            return;
                        }
                    }
                    // Guardar para futuras aperturas
                    iconsG.Add((nombre, imagen));
                    // Mostrarlo inmediatamente
                    AgregarIconoAlFlow(nombre, imagen);
                }
            }
        }
        private void btn_acpt_Click(object sender, EventArgs e)
        {
            if (iconoSeleccionado == null)
            {
                MessageBox.Show(
                    "Seleccione un ícono de la lista.",
                    "Seleccionar ícono",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_ccl_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
