using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frm_secundario2 : Form
    {
        public string ncolor { get; private set; }
        public Color clrSelect { get; private set; }
        public frm_secundario2()
        {
            InitializeComponent();
        }

        private void btn_elig_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pnl_clr1.BackColor = colorDialog.Color;
                    clrSelect = colorDialog.Color;
                }
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_clr.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Ingrese el nombre del color.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_clr.Focus();
                return;
            }
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(
                $"SELECT IdColor FROM Colores WHERE Nombre = '{nombre}'"
            );
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "El color ya existe.",
                    "Color duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            string codigoHex = ColorTranslator.ToHtml(clrSelect);
            bool guardado = conexion.insertDatos("Colores","Nombre, CodigoHex",$"'{nombre}', '{codigoHex}'");
            if (!guardado)
            {
                MessageBox.Show(
                    "No se pudo guardar el color.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            ncolor = nombre;
            MessageBox.Show(
                "Color guardado correctamente.",
                "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_clr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
