using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormPromociones : Form
    {
        public FormPromociones()
        {
            InitializeComponent();
        }

        private void FormPromociones_Load(object sender, EventArgs e)
        {
            Edt();

            CargarTiposPromocion();
            CargarEstadosPromocion();
            C_Prm();
        }
        private void Edt()
        {
            dgvPromociones.EnableHeadersVisualStyles = false;
            // configuracion general del data
            dgvPromociones.BorderStyle = BorderStyle.None;
            dgvPromociones.BackgroundColor = Color.White;
            dgvPromociones.GridColor = Color.FromArgb(235, 235, 235);
            dgvPromociones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPromociones.ReadOnly = true;
            dgvPromociones.MultiSelect = false;
            dgvPromociones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromociones.AllowUserToAddRows = false;
            dgvPromociones.AllowUserToDeleteRows = false;
            dgvPromociones.AllowUserToResizeRows = false;
            dgvPromociones.AllowUserToResizeColumns = false;
            dgvPromociones.RowHeadersVisible = false;
            // encabezado
            dgvPromociones.ColumnHeadersHeight = 50;
            dgvPromociones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPromociones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvPromociones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPromociones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPromociones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // filas
            dgvPromociones.RowTemplate.Height = 55;
            dgvPromociones.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPromociones.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvPromociones.DefaultCellStyle.BackColor = Color.White;
            dgvPromociones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvPromociones.DefaultCellStyle.Padding = new Padding(5);
            // seleeción de celdas
            dgvPromociones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvPromociones.DefaultCellStyle.SelectionForeColor = Color.Black;
            // tamaño de las columnas
            dgvPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromociones.Columns["clId"].FillWeight = 6;
            dgvPromociones.Columns["clNombrePromocion"].FillWeight = 16;
            dgvPromociones.Columns["clTipo"].FillWeight = 11;
            dgvPromociones.Columns["clDescuento"].FillWeight = 10;
            dgvPromociones.Columns["clFechaInicio"].FillWeight = 11;
            dgvPromociones.Columns["clFechaFin"].FillWeight = 11;
            dgvPromociones.Columns["clEstado"].FillWeight = 9;
            dgvPromociones.Columns["clDescripcion"].FillWeight = 17;
            dgvPromociones.Columns["clEditar"].FillWeight = 6;
            dgvPromociones.Columns["clEliminar"].FillWeight = 6;
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvPromociones.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvPromociones.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            // centrar columnas
            string[] columnasCentro =
            {
                "clId",
                "clNombrePromocion",
                "clTipo",
                "clDescuento",
                "clFechaInicio",
                "clFechaFin",
                "clEstado",
                "clEditar",
                "clEliminar"
            };
            foreach (string columna in columnasCentro)
            {
                dgvPromociones.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // Descripción a la izquierda
            dgvPromociones.Columns["clDescripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // carga el data y lo deja vacio
            dgvPromociones.Rows.Clear();
        }
        private void C_Prm()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "select IdPromocion, Nombre, TipoDescuento, ValorDescuento, " +
                "FechaInicio, FechaFin, Estado, Descripcion " +
                "from Promociones order by IdPromocion");

            if (dt == null)
            {
                return;
            }

            dgvPromociones.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"]) ? "Activo" : "Inactivo";
                int indice = dgvPromociones.Rows.Add(
                    fila["IdPromocion"].ToString(),
                    fila["Nombre"].ToString(),
                    fila["TipoDescuento"].ToString(),
                    fila["ValorDescuento"].ToString(),
                    Convert.ToDateTime(fila["FechaInicio"]).ToString("dd/MM/yyyy"),
                    Convert.ToDateTime(fila["FechaFin"]).ToString("dd/MM/yyyy"),
                    estado,
                    fila["Descripcion"].ToString(),
                    null,
                    null
                );
                dgvPromociones.Rows[indice].Tag = Convert.ToInt32(fila["IdPromocion"]);
            }
        }
        private void FiltrarPromociones()
        {
            string texto = txt_busqPrm.Text.Trim();
            string tipo = cmbP.Text.Trim();
            string estado = cmbP2.Text.Trim();

            string sql = @"select IdPromocion, Nombre, TipoDescuento, ValorDescuento, FechaInicio,
                FechaFin, Estado, Descripcion from Promociones where 1 = 1";

            // busca por código o nombre del producto
            if (texto != "")
            {
                texto = texto.Replace("'", "''");
                sql += @"and (Nombre like'%" + texto + @"%' or
                 Descripcion like '%" + texto + @"%')";
            }

            // filtra por el tipo
            if (tipo != "Todos" && tipo != "")
            {
                tipo = tipo.Replace("'", "''");
                sql += @"and TipoDescuento = '" + tipo + "'";
            }

            // filtra por el estado
            if (estado == "Activo")
            {
                sql += " and Estado = 1";
            }
            if (estado == "Inactivo")
            {
                sql += " and Estado = 0";
            }
            sql += " order by IdPromocion";

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);
            if (dt == null)
            {
                return;
            }
            dgvPromociones.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto = "";
                bool estadoPromocion = Convert.ToBoolean(fila["Estado"]);

                if (estadoPromocion == true)
                {
                    estadoTexto = "Activo";
                }

                if (estadoPromocion == false)
                {
                    estadoTexto = "Inactivo";
                }

                decimal descuento = Convert.ToDecimal(fila["ValorDescuento"]);
                string tipoDescuento = fila["TipoDescuento"].ToString();
                string descuentoTexto = "";
                if (tipoDescuento == "Descuento porcentual")
                {
                    descuentoTexto = descuento.ToString("0.##") + "%";
                }

                if (tipoDescuento == "Descuento fijo")
                {
                    descuentoTexto = "$" + descuento.ToString("0.00");
                }
                int indice =
                    dgvPromociones.Rows.Add(
                        fila["IdPromocion"].ToString(),
                        fila["Nombre"].ToString(),
                        tipoDescuento,
                        descuentoTexto,
                        Convert.ToDateTime(
                            fila["FechaInicio"])
                            .ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(
                            fila["FechaFin"])
                            .ToString("dd/MM/yyyy"),
                        estadoTexto,
                        fila["Descripcion"].ToString(),
                        null,
                        null
                    );
                dgvPromociones.Rows[indice].Tag = Convert.ToInt32(fila["IdPromocion"]);
            }
        }
        private void CargarTiposPromocion()
        {
            cmbP.Items.Clear();
            cmbP.Items.Add("Todos");
            cmbP.Items.Add("Descuento porcentual");
            cmbP.Items.Add("Descuento fijo");
            cmbP.SelectedIndex = 0;
        }
        private void CargarEstadosPromocion()
        {
            cmbP2.Items.Clear();
            cmbP2.Items.Add("Todos");
            cmbP2.Items.Add("Activo");
            cmbP2.Items.Add("Inactivo");

            cmbP2.SelectedIndex = 0;
        }
        private void txt_busqPrm_TextChanged(object sender, EventArgs e)
        {
            FiltrarPromociones();
        }
        private void cmbP_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPromociones();
        }

        private void cmbP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPromociones();
        }
        private void btn_limpP_Click(object sender, EventArgs e)
        {
            txt_busqPrm.Clear();
            cmbP.SelectedIndex = 0;
            cmbP2.SelectedIndex = 0;
            C_Prm();
        }
        private void btn_aggP_Click(object sender, EventArgs e)
        {
            FormAgg_Promocion frm = new FormAgg_Promocion();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                C_Prm();
            }
        }

        private void dgvPromociones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columna = dgvPromociones.Columns[e.ColumnIndex].Name;

            // editar
            if (columna == "clEditar")
            {
                int idPromocion = Convert.ToInt32(dgvPromociones.Rows[e.RowIndex].Tag);
                FormAgg_Promocion frm = new FormAgg_Promocion(idPromocion);
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    C_Prm();
                }
            }
            //eliminar
            else if (columna == "clEliminar")
            {
                int idPromocion = Convert.ToInt32(dgvPromociones.Rows[e.RowIndex].Tag);
                string nombre = dgvPromociones.Rows[e.RowIndex].Cells["clNombrePromocion"].Value?.ToString() ?? "";
                DialogResult resultado =
                    MessageBox.Show(
                        "¿Está seguro de eliminar la promoción \"" +
                        nombre + "\"?",
                        "Eliminar promoción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultado == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();
                    // eliminar productos de la promoción
                    bool relacionesEliminadas = conexion.ejecutarComando("delete from PromocionProducto " +
                         "where IdPromocion = @id",
                            new SqlParameter("@id", idPromocion));

                    if (!relacionesEliminadas)
                    {
                        MessageBox.Show(
                            "No se pudieron eliminar los productos asociados a la promoción.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }
                    // eliminar promoción
                    bool eliminado = conexion.ejecutarComando("delete from Promociones " +
                            "whereIdPromocion = @id",
                            new SqlParameter("@id",idPromocion));

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Promoción eliminada correctamente.",
                            "Promoción",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        C_Prm();
                    }
                }
            }
        }

        private void lblSalirV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
             MessageBox.Show(
             "¿Está seguro de salir?",
             "Confirmar salida",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
