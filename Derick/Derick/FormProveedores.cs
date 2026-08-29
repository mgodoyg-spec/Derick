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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            C_Proveedor();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarEstadosProveedor();
            CargarOrdenProveedor();
            CargarProveedores();
        }
        private void C_Proveedor()
        {
            dgvProveedor.EnableHeadersVisualStyles = false;

            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.GridColor = Color.FromArgb(235, 235, 235);
            dgvProveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedor.ReadOnly = true;
            dgvProveedor.MultiSelect = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.RowHeadersVisible = false;

            dgvProveedor.ColumnHeadersHeight = 50;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvProveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProveedor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProveedor.RowTemplate.Height = 55;
            dgvProveedor.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProveedor.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvProveedor.DefaultCellStyle.BackColor = Color.White;
            dgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvProveedor.DefaultCellStyle.Padding = new Padding(5);

            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvProveedor.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.Columns["clId"].FillWeight = 8;
            dgvProveedor.Columns["clNombreProveedor"].FillWeight = 25;
            dgvProveedor.Columns["clContacto"].FillWeight = 20;
            dgvProveedor.Columns["clTelefono"].FillWeight = 15;
            dgvProveedor.Columns["clCorreo"].FillWeight = 25;
            dgvProveedor.Columns["clEstado"].FillWeight = 12;
            dgvProveedor.Columns["clEditar"].FillWeight = 8;
            dgvProveedor.Columns["clEliminar"].FillWeight = 8;
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvProveedor.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvProveedor.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            string[] columnasCentro =
            {
                  "clId",
                  "clTelefono",
                  "clEstado",
                  "clEditar",
                  "clEliminar"
            };
            foreach (string columna in columnasCentro)
            {
                dgvProveedor.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvProveedor.Columns["clNombreProveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clContacto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clCorreo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvProveedor.Rows.Clear();
        }
        private void CargarProveedores()
        {
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros("select IdProveedor, Nombre, Contacto, Telefono, " +
                "Correo, Estado " + "from Proveedores order by IdProveedor"
            );
            if (dt == null)
            {
                return;
            }
            dgvProveedor.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto = Convert.ToBoolean(fila["Estado"]) ? "Activo": "Inactivo";
                int indice = dgvProveedor.Rows.Add(
                    fila["IdProveedor"].ToString(),
                    fila["Nombre"].ToString(),
                    fila["Contacto"].ToString(),
                    fila["Telefono"].ToString(),
                    fila["Correo"].ToString(),
                    estadoTexto,
                    null,
                    null
                );
                dgvProveedor.Rows[indice].Tag = Convert.ToInt32(fila["IdProveedor"]);
            }
        }
        private void FiltrarProveedores()
        {
            string texto = txt01.Text.Trim();
            string estado = cmb01.Text.Trim();
            string ordenar = cmb02.Text.Trim();
            string sql = @"select IdProveedor, Nombre, Contacto, Telefono, Correo,
                Estado from Proveedores WHERE 1 = 1";

            // buscar por nombre, contacto, correo o telefono
            if (texto != "")
            {
                texto = texto.Replace("'", "''");
                sql += @"and (Nombre like '%" + texto + @"%'
                or Contacto like '%" + texto + @"%' or Telefono like '%" + texto + @"%'
                or Correo like '%" + texto + @"%')";
            }

            // filtrar por estado
            if (estado == "Activo")
            {
                sql += " and Estado = 1";
            }

            if (estado == "Inactivo")
            {
                sql += " and Estado = 0";
            }

            // ordenar por letra
            if (ordenar == "Nombre A-Z")
            {
                sql += " order by Nombre asc";
            }

            if (ordenar == "Nombre Z-A")
            {
                sql += " order by Nombre desc";
            }

            if (ordenar == "Más recientes")
            {
                sql += " order by IdProveedor desc";
            }

            if (ordenar == "Predeterminado")
            {
                sql += " order by IdProveedor asc";
            }

            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(sql);
            if (dt == null)
            {
                return;
            }
            dgvProveedor.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto = "";
                bool estadoProveedor = Convert.ToBoolean(fila["Estado"]);

                if (estadoProveedor == true)
                {
                    estadoTexto = "Activo";
                }

                if (estadoProveedor == false)
                {
                    estadoTexto = "Inactivo";
                }

                int indice =
                    dgvProveedor.Rows.Add(
                        fila["IdProveedor"].ToString(),
                        fila["Nombre"].ToString(),
                        fila["Contacto"].ToString(),
                        fila["Telefono"].ToString(),
                        fila["Correo"].ToString(),
                        estadoTexto,
                        null,
                        null
                    );

                dgvProveedor.Rows[indice].Tag = Convert.ToInt32(fila["IdProveedor"]);
            }
        }
        private void CargarEstadosProveedor()
        {
            cmb01.Items.Clear();
            cmb01.Items.Add("Todos");
            cmb01.Items.Add("Activo");
            cmb01.Items.Add("Inactivo");
            cmb01.SelectedIndex = 0;
        }
        private void CargarOrdenProveedor()
        {
            cmb02.Items.Clear();
            cmb02.Items.Add("Predeterminado");
            cmb02.Items.Add("Nombre A-Z");
            cmb02.Items.Add("Nombre Z-A");
            cmb02.Items.Add("Más recientes");
            cmb02.SelectedIndex = 0;
        }
        private void txt01_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void cmb01_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void cmb02_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt01.Clear();
            cmb01.SelectedIndex = 0;
            cmb02.SelectedIndex = 0;
            CargarProveedores();
        }
        private void btn_ctg1_Click(object sender, EventArgs e)
        {
            FormAgg_Proveedores frm_aggPR = new FormAgg_Proveedores();
            frm_aggPR.StartPosition = FormStartPosition.CenterScreen;
            if (frm_aggPR.ShowDialog(this) == DialogResult.OK)
            {
                CargarProveedores();
            }
        }
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columna = dgvProveedor.Columns[e.ColumnIndex].Name;

            //editar
            if (columna == "clEditar")
            {
                int idProveedor = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Tag);
                FormAgg_Proveedores frm = new FormAgg_Proveedores(idProveedor);
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarProveedores();
                }
            }
            else if (columna == "clEliminar")
            {
                int idProveedor = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Tag);
                string nombre = dgvProveedor.Rows[e.RowIndex].Cells["clNombreProveedor"].Value?.ToString() ?? "";
                DialogResult resultado =
                    MessageBox.Show(
                        "¿Está seguro de eliminar el proveedor \"" +
                        nombre + "\"?",
                        "Eliminar proveedor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if (resultado == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();
                    bool eliminado =conexion.ejecutarComando(
                            "delete from Proveedores " + "where IdProveedor = @id",
                            new SqlParameter("@id",idProveedor));
                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Proveedor eliminado correctamente.",
                            "Proveedor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarProveedores();
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
