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
            // ==============================
            // CONFIGURACIÓN GENERAL
            // ==============================
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
            // ==============================
            // ENCABEZADOS
            // ==============================
            dgvProveedor.ColumnHeadersHeight = 50;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvProveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProveedor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // ==============================
            // FILAS
            // ==============================
            dgvProveedor.RowTemplate.Height = 55;
            dgvProveedor.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProveedor.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvProveedor.DefaultCellStyle.BackColor = Color.White;
            dgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvProveedor.DefaultCellStyle.Padding = new Padding(5);
            // ==============================
            // SELECCIÓN
            // ==============================
            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvProveedor.DefaultCellStyle.SelectionForeColor = Color.Black;
            // ==============================
            // TAMAÑO DE COLUMNAS
            // ==============================
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
            // ==============================
            // CENTRAR COLUMNAS
            // ==============================
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
            // ==============================
            // COLUMNAS A LA IZQUIERDA
            // ==============================
            dgvProveedor.Columns["clNombreProveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clContacto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedor.Columns["clCorreo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // ==============================
            // EMPEZAR VACÍO
            // ==============================
            dgvProveedor.Rows.Clear();
        }
        private void CargarProveedores()
        {
            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT IdProveedor, Nombre, Contacto, Telefono, Correo, Estado " +
                "FROM Proveedores ORDER BY IdProveedor"
            );
            if (dt == null)
                return;
            dgvProveedor.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto =
                    Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

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

                dgvProveedor.Rows[indice].Tag =
                    Convert.ToInt32(fila["IdProveedor"]);
            }
        }
        private void FiltrarProveedores()
        {
            string texto = txt01.Text.Trim();
            string estado = cmb01.Text.Trim();
            string ordenar = cmb02.Text.Trim();

            string sql = @"
        SELECT
            IdProveedor,
            Nombre,
            Contacto,
            Telefono,
            Correo,
            Estado
        FROM Proveedores
        WHERE 1 = 1
    ";

            // Buscar por varios campos
            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql +=
                    $" AND (Nombre LIKE '%{texto}%' " +
                    $"OR Contacto LIKE '%{texto}%' " +
                    $"OR Telefono LIKE '%{texto}%' " +
                    $"OR Correo LIKE '%{texto}%')";
            }

            // Filtrar por estado
            if (estado != "Todos" &&
                !string.IsNullOrWhiteSpace(estado))
            {
                if (estado == "Activo")
                    sql += " AND Estado = 1";
                else if (estado == "Inactivo")
                    sql += " AND Estado = 0";
            }

            // Ordenar
            if (ordenar == "Nombre A-Z")
                sql += " ORDER BY Nombre ASC";
            else if (ordenar == "Nombre Z-A")
                sql += " ORDER BY Nombre DESC";
            else if (ordenar == "Más recientes")
                sql += " ORDER BY IdProveedor DESC";
            else
                sql += " ORDER BY IdProveedor ASC";

            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
                return;

            dgvProveedor.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto =
                    Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

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
        private void btnBuscar_Click(object sender, EventArgs e)
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
                return;

            string columna =
                dgvProveedor.Columns[e.ColumnIndex].Name;

            // ==============================
            // EDITAR
            // ==============================
            if (columna == "clEditar")
            {
                int idProveedor =
                    Convert.ToInt32(
                        dgvProveedor.Rows[e.RowIndex].Tag
                    );

                FormAgg_Proveedores frm = new FormAgg_Proveedores(idProveedor);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarProveedores();
                }
            }
            else if (columna == "clEliminar")
            {
                int idProveedor =
                    Convert.ToInt32(
                        dgvProveedor.Rows[e.RowIndex].Tag
                    );

                string nombre =
                    dgvProveedor.Rows[e.RowIndex]
                    .Cells["clNombreProveedor"]
                    .Value?.ToString() ?? "";

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
                    csConectaSQL conexion =
                        new csConectaSQL();

                    bool eliminado =
                        conexion.ejecutarComando(
                            "DELETE FROM Proveedores " +
                            "WHERE IdProveedor = @id",
                            new SqlParameter(
                                "@id",
                                idProveedor
                            )
                        );
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
    }
}
