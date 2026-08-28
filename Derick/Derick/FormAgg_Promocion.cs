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
        private int? idPromocionEditar = null;
        public FormAgg_Promocion()
        {
            InitializeComponent();
        }
        public FormAgg_Promocion(int idPromocion) : this()
        {
            idPromocionEditar = idPromocion;
        }

        private void FormAgg_Promocion_Load(object sender, EventArgs e)
        {
            if (idPromocionEditar != null)
            {
                CPR_editar();
            }
        }
        private void CPR_editar()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros("select Nombre, Descripcion, TipoDescuento, " +
                "ValorDescuento, " + "FechaInicio, FechaFin, Estado, AplicaTodos " +
                "from Promociones " + "where IdPromocion = " + idPromocionEditar.Value
            );

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow fila = dt.Rows[0];
            txt_p1.Text = fila["Nombre"].ToString();
            txt_Pdsp.Text = fila["Descripcion"].ToString();
            cmb_p1.Text = fila["TipoDescuento"].ToString();
            decimal descuento = Convert.ToDecimal(fila["ValorDescuento"]);
            txt_p2.Text = descuento.ToString("0.##");
            dtp_inicio.Value = Convert.ToDateTime(fila["FechaInicio"]);
            dtp_fin.Value = Convert.ToDateTime(fila["FechaFin"]);
            bool activo = Convert.ToBoolean(fila["Estado"]);
            cmb_p3.Text = activo ? "Activo" : "Inactivo";
            bool aplicaTodos = Convert.ToBoolean(fila["AplicaTodos"]);

            if (aplicaTodos)
            {
                rb_tp.Checked = true;
            }
            else
            {
                rb_ps.Checked = true;
                Cargar_PRM();
            }
        }
        private void Cargar_PRM()
        {
            prd_selct.Clear();

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select IdProducto " +
                "from PromocionProducto " + "where IdPromocion = " + idPromocionEditar.Value
            );
            if (dt == null)
            {
                return;
            }

            foreach (DataRow fila in dt.Rows)
            {
                prd_selct.Add(Convert.ToInt32(fila["IdProducto"]));
            }
            lblP9.Text = prd_selct.Count + " productos seleccionados";
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
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                prd_selct = frm.prd_selet;
                lblP9.Text = prd_selct.Count + " productos seleccionados";
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // nombre de la promoción
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
            // tipo de promoción
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
            // descuento
            decimal descuento;
            string textoDescuento = txt_p2.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(textoDescuento, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,out descuento))
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
            // descuento mayor a 0
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
            // validar descuento porcental
            if (cmb_p1.Text == "Descuento porcentual" && descuento > 100)
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
            // valida fecha
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
            // valida el estado
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
            // descripción
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
            // aplicar a (a que producto se le quiere aplicar)
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
            // productos que se seleccionen
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
            string nombre = txt_p1.Text.Trim();
            string descripcion = txt_Pdsp.Text.Trim();
            string tipoDescuento = cmb_p1.Text.Trim();

            DateTime fechaInicio = dtp_inicio.Value.Date;
            DateTime fechaFin = dtp_fin.Value.Date;
            int estado = cmb_p3.Text.Equals( "Activo",StringComparison.OrdinalIgnoreCase)? 1: 0;
            int aplicaTodos = rb_tp.Checked ? 1 : 0;

            csConectaSQL conexion = new csConectaSQL();
            string datosActualizar =
                   $"Nombre = '{nombre}', " +
                   $"Descripcion = '{descripcion}', " +
                   $"TipoDescuento = '{tipoDescuento}', " +
                   $"ValorDescuento = {descuento.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                   $"FechaInicio = '{fechaInicio:yyyy-MM-dd}', " +
                   $"FechaFin = '{fechaFin:yyyy-MM-dd}', " +
                   $"Estado = {estado}, " +
                   $"AplicaTodos = {aplicaTodos}";

            int idPromocion;
            if (idPromocionEditar == null)
            {
                string campos ="Nombre, Descripcion, TipoDescuento, ValorDescuento, " +
                    "FechaInicio, FechaFin, IdSucursal, Estado, AplicaTodos";
                string datos =
                    $"'{nombre}', " +
                    $"'{descripcion}', " +
                    $"'{tipoDescuento}', " +
                    $"{descuento.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                    $"'{fechaInicio:yyyy-MM-dd}', " +
                    $"'{fechaFin:yyyy-MM-dd}', " +
                    $"NULL, " +
                    $"{estado}, " +
                    $"{aplicaTodos}";

                idPromocion = conexion.Ins_RetrID("Promociones",campos,datos);
                if (idPromocion == -1)
                {
                    MessageBox.Show(
                        "No se pudo guardar la promoción.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }
            else
            {
                idPromocion = idPromocionEditar.Value;
                bool actualizado = conexion.actualizarDatos("Promociones",datosActualizar,
                    $"IdPromocion = {idPromocion}");

                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se pudo actualizar la promoción.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
                conexion.ejecutarComando("delete from PromocionProducto where IdPromocion = @id",
                    new Microsoft.Data.SqlClient.SqlParameter("@id",idPromocion));
            }
            if (rb_ps.Checked)
            {
                foreach (int idProducto in prd_selct)
                {
                    bool guardado = conexion.insertDatos("PromocionProducto","IdPromocion, IdProducto",
                        $"{idPromocion}, {idProducto}");
                    if (!guardado)
                    {
                        MessageBox.Show(
                            "La promoción se guardó, pero hubo un problema al asociar uno de los productos.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (idPromocionEditar == null)
            {
                MessageBox.Show(
                    "Promoción registrada correctamente.",
                    "Promoción",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Promoción actualizada correctamente.",
                    "Promoción",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_salirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
