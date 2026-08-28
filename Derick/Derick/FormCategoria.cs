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
    public partial class FormCategoria : Form
    {
        private BindingList<Producto> listaproductos = new BindingList<Producto>();
        public FormCategoria()
        {
            InitializeComponent();

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CargarCategoriasFiltro();
            CargarEstadosFiltro();
            CargarCategorias();

            // CONFIGURACIÓN GENERAL
            dgv_catg.EnableHeadersVisualStyles = false;
            dgv_catg.BorderStyle = BorderStyle.None;
            dgv_catg.BackgroundColor = Color.White;
            dgv_catg.GridColor = Color.FromArgb(235, 235, 235);
            dgv_catg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_catg.ReadOnly = true;
            dgv_catg.MultiSelect = false;
            dgv_catg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_catg.AllowUserToAddRows = false;
            dgv_catg.AllowUserToDeleteRows = false;
            dgv_catg.AllowUserToResizeRows = false;
            dgv_catg.AllowUserToResizeColumns = false;
            dgv_catg.RowHeadersVisible = false;
            // ENCABEZADOS
            dgv_catg.ColumnHeadersHeight = 50;
            dgv_catg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_catg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgv_catg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_catg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_catg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS
            dgv_catg.RowTemplate.Height = 55;
            dgv_catg.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_catg.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgv_catg.DefaultCellStyle.BackColor = Color.White;
            dgv_catg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgv_catg.DefaultCellStyle.Padding = new Padding(5);

            // COLOR DE SELECCIÓN
            dgv_catg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgv_catg.DefaultCellStyle.SelectionForeColor = Color.Black;

            // TAMAÑO DE LAS COLUMNAS
            dgv_catg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_catg.Columns["clId"].FillWeight = 10;
            dgv_catg.Columns["clIcono"].FillWeight = 12;
            dgv_catg.Columns["clCategoria"].FillWeight = 22;
            dgv_catg.Columns["clEstado"].FillWeight = 14;
            dgv_catg.Columns["clDescripcion"].FillWeight = 30;
            dgv_catg.Columns["clEditar"].FillWeight = 7;
            dgv_catg.Columns["clEliminar"].FillWeight = 7;

            // COLUMNA ICONO
            DataGridViewImageColumn icono = (DataGridViewImageColumn)dgv_catg.Columns["clIcono"];
            icono.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgv_catg.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgv_catg.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // ALINEACIÓN
            string[] columnasCentro =
            {
                   "clId",
                   "clIcono",
                   "clCategoria",
                   "clEstado",
                   "clEditar",
                   "clEliminar"
            };
            foreach (string columna in columnasCentro)
            {
                dgv_catg.Columns[columna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // Descripción alineada a la izquierda
            dgv_catg.Columns["clDescripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // DATA VACÍO AL INICIAR
            dgv_catg.Rows.Clear();
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros(
                "SELECT IdCategoria, Nombre, Descripcion, Estado, Imagen " +
                "FROM Categorias ORDER BY IdCategoria"
            );
            if (dt == null)
            {
                return;
            }
            dgv_catg.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                string estado = Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";
                Image icono = null;

                // CONVERTIR LOS BYTES DE SQL A IMAGEN
                if (fila["Imagen"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])fila["Imagen"];

                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        using (Image temporal = Image.FromStream(ms))
                        {
                            icono = new Bitmap(temporal);
                        }
                    }
                }

                int indice = dgv_catg.Rows.Add(
                    fila["IdCategoria"].ToString(),
                    icono, // AQUÍ APARECE EL ÍCONO
                    fila["Nombre"].ToString(),
                    estado,
                    fila["Descripcion"].ToString(),
                    null,
                    null
                );

                dgv_catg.Rows[indice].Tag = Convert.ToInt32(fila["IdCategoria"]);
            }
        }
        private void FiltrarCategorias()
        {
            string texto = txt_busqctg.Text.Trim();
            string categoria = cmb_ctg1.Text.Trim();
            string estado = cmb_ctg2.Text.Trim();
            string sql = @"
            SELECT
            IdCategoria,
            Nombre,
            Descripcion,
            Estado
            FROM Categorias
            WHERE 1 = 1 ";

            // Buscar por nombre o descripción
            if (!string.IsNullOrWhiteSpace(texto))
            {
                sql += $" AND (Nombre LIKE '%{texto}%' " +
                       $"OR Descripcion LIKE '%{texto}%')";
            }

            // Filtrar por categoría
            if (categoria != "Todas" &&
                !string.IsNullOrWhiteSpace(categoria))
            {
                sql += $" AND Nombre = '{categoria}'";
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

            sql += " ORDER BY IdCategoria";

            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(sql);

            if (dt == null)
                return;

            dgv_catg.Rows.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                string estadoTexto =
                    Convert.ToBoolean(fila["Estado"])
                    ? "Activo"
                    : "Inactivo";

                dgv_catg.Rows.Add(
                    fila["IdCategoria"].ToString(),
                    null, // Ícono
                    fila["Nombre"].ToString(),
                    estadoTexto,
                    fila["Descripcion"].ToString(),
                    null, // Editar
                    null  // Eliminar
                );
            }
        }
        private void CargarCategoriasFiltro()
        {
            cmb_ctg1.Items.Clear();

            cmb_ctg1.Items.Add("Todas");

            csConectaSQL conexion = new csConectaSQL();

            DataTable dt = conexion.RetornaRegistros(
                "SELECT Nombre FROM Categorias ORDER BY Nombre"
            );

            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    cmb_ctg1.Items.Add(
                        fila["Nombre"].ToString()
                    );
                }
            }

            cmb_ctg1.SelectedIndex = 0;
        }
        private void CargarEstadosFiltro()
        {
            cmb_ctg2.Items.Clear();

            cmb_ctg2.Items.Add("Todos");
            cmb_ctg2.Items.Add("Activo");
            cmb_ctg2.Items.Add("Inactivo");

            cmb_ctg2.SelectedIndex = 0;
        }
        private void btn_bus1_Click(object sender, EventArgs e)
        {
            FiltrarCategorias();
        }

        private void btn_limp1_Click(object sender, EventArgs e)
        {
            txt_busqctg.Clear();
            cmb_ctg1.SelectedIndex = 0;
            cmb_ctg2.SelectedIndex = 0;
            CargarCategorias();
        }

        private void btn_ctg1_Click(object sender, EventArgs e)
        {
            FrmAgg_Categoria frmctg = new FrmAgg_Categoria();
            frmctg.StartPosition = FormStartPosition.CenterScreen;

            if (frmctg.ShowDialog(this) == DialogResult.OK)
            {
                CargarCategorias();
            }
        }

        private void dgv_catg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columna = dgv_catg.Columns[e.ColumnIndex].Name;

            if (columna == "clEditar")
            {
                int idCategoria = Convert.ToInt32(dgv_catg.Rows[e.RowIndex].Tag);
                FrmAgg_Categoria frm = new FrmAgg_Categoria(idCategoria);
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarCategorias();
                }
            }
            else if (columna == "clEliminar")
            {
                int idCategoria =
                    Convert.ToInt32(dgv_catg.Rows[e.RowIndex].Tag);

                string nombre =
                    dgv_catg.Rows[e.RowIndex]
                    .Cells["clCategoria"]
                    .Value?.ToString() ?? "";

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de eliminar la categoría \"" +
                    nombre + "\"?",
                    "Eliminar categoría",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    csConectaSQL conexion = new csConectaSQL();

                    bool eliminado = conexion.ejecutarComando(
                         "DELETE FROM Categorias WHERE IdCategoria = @id",
                          new SqlParameter("@id", idCategoria)
                    );

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Categoría eliminada correctamente.",
                            "Categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        CargarCategorias();
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
