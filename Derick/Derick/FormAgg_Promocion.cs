using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormAgg_Promocion : Form
    {
        private List<int> prd_selct = new List<int>();
        public FormAgg_Promocion()
        {
            InitializeComponent();
        }

        private void FormAgg_Promocion_Load(object sender, EventArgs e)
        {

        }

        private void txt_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Solo permitir un punto o coma decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt_p2.Text.Contains(".") || txt_p2.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void rb_tp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_tp.Checked)
            {
                btn_vnt.Enabled = false;
                lblP9.Text = "Todos los productos";
            }
        }
        private void rb_ps_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ps.Checked)
            {
                btn_vnt.Enabled = true;
                if (prd_selct.Count == 0)
                {
                    lblP9.Text = "Seleccionar productos...";
                }
            }
        }
        private void btn_vnt_Click(object sender, EventArgs e)
        {
            frm_secundario4 frm = new frm_secundario4();
            frm.StartPosition = FormStartPosition.Manual;

            frm.Location = new Point(
                this.Right + 10,
                this.Top
            );
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                prd_selct = frm.prd_selet;
                lblP9.Text = prd_selct.Count + " productos seleccionados";
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. NOMBRE DE LA PROMOCIÓN
            // ==========================================
            if (string.IsNullOrWhiteSpace(txt_p1.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la promoción.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_p1.Focus();
                return;
            }
            // ==========================================
            // 2. TIPO DE PROMOCIÓN
            // ==========================================
            if (cmb_p1.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el tipo de promoción.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cmb_p1.Focus();
                return;
            }
            // ==========================================
            // 3. DESCUENTO
            // ==========================================
            decimal descuento;
            string textoDescuento = txt_p2.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(
                textoDescuento,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out descuento))
            {
                MessageBox.Show(
                    "Ingrese un descuento válido.",
                    "Descuento inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_p2.Focus();
                return;
            }
            // ==========================================
            // 4. DESCUENTO MAYOR A 0
            // ==========================================
            if (descuento <= 0)
            {
                MessageBox.Show(
                    "El descuento debe ser mayor que 0.",
                    "Descuento inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_p2.Focus();
                return;
            }
            // ==========================================
            // 5. VALIDAR DESCUENTO PORCENTUAL
            // ==========================================
            if (cmb_p1.Text == "Descuento porcentual" &&
                descuento > 100)
            {
                MessageBox.Show(
                    "El descuento porcentual no puede ser mayor al 100%.",
                    "Descuento inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_p2.Focus();
                return;
            }
            // ==========================================
            // 6. VALIDAR FECHAS
            // ==========================================
            if (dtp_fin.Value.Date < dtp_inicio.Value.Date)
            {
                MessageBox.Show(
                    "La fecha de fin no puede ser anterior a la fecha de inicio.",
                    "Fechas inválidas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                dtp_fin.Focus();
                return;
            }
            // ==========================================
            // 7. ESTADO
            // ==========================================
            if (cmb_p3.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el estado de la promoción.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cmb_p3.Focus();
                return;
            }
            // ==========================================
            // 8. DESCRIPCIÓN
            // ==========================================
            if (txt_Pdsp.Text.Length > 250)
            {
                MessageBox.Show(
                    "La descripción no puede superar los 250 caracteres.",
                    "Descripción demasiado larga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_Pdsp.Focus();
                return;
            }
            // ==========================================
            // 9. APLICAR A
            // ==========================================
            if (!rb_tp.Checked && !rb_ps.Checked)
            {
                MessageBox.Show(
                    "Seleccione a qué productos se aplicará la promoción.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // ==========================================
            // 10. PRODUCTOS SELECCIONADOS
            // ==========================================
            if (rb_ps.Checked && prd_selct.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos un producto para aplicar la promoción.",
                    "Productos requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                btn_vnt.Focus();
                return;
            }
            MessageBox.Show(
                "Promoción registrada correctamente.",
                "Promoción",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            // Más adelante aquí irá el INSERT a SQL Server.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_salirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
