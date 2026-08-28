using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frm_secundario4 : Form
    {
        public List<int> prd_selet { get; private set; } = new List<int>();
        public List<string> nm_selet { get; private set; } = new List<string>();
        public frm_secundario4()
        {
            InitializeComponent();
            C_prm();
        }
        private void frm_secundario4_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void C_prm()
        {
            dgv_prm.EnableHeadersVisualStyles = false;

            dgv_prm.BorderStyle = BorderStyle.None;
            dgv_prm.BackgroundColor = Color.White;
            dgv_prm.GridColor = Color.FromArgb(235, 235, 235);
            dgv_prm.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            // IMPORTANTE:
            // No ponemos todo el DataGridView en ReadOnly
            // porque necesitamos marcar los CheckBox.
            dgv_prm.ReadOnly = false;
            dgv_prm.MultiSelect = false;
            dgv_prm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_prm.AllowUserToAddRows = false;
            dgv_prm.AllowUserToDeleteRows = false;
            dgv_prm.AllowUserToResizeRows = false;
            dgv_prm.AllowUserToResizeColumns = false;
            dgv_prm.RowHeadersVisible = false;

            dgv_prm.ColumnHeadersHeight = 45;
            dgv_prm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_prm.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgv_prm.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_prm.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_prm.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_prm.RowTemplate.Height = 45;
            dgv_prm.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_prm.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgv_prm.DefaultCellStyle.BackColor = Color.White;
            dgv_prm.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgv_prm.DefaultCellStyle.Padding = new Padding(5);

            dgv_prm.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgv_prm.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv_prm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_prm.Columns["clSeleccionar"].FillWeight = 12;
            dgv_prm.Columns["clCodigo"].FillWeight = 25;
            dgv_prm.Columns["clProducto"].FillWeight = 45;
            dgv_prm.Columns["clPrecio"].FillWeight = 22;

            // checkbox editable
            dgv_prm.Columns["clSeleccionar"].ReadOnly = false;
            dgv_prm.Columns["clCodigo"].ReadOnly = true;
            dgv_prm.Columns["clProducto"].ReadOnly = true;
            dgv_prm.Columns["clPrecio"].ReadOnly = true;

            dgv_prm.Columns["clSeleccionar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_prm.Columns["clCodigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_prm.Columns["clPrecio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_prm.Columns["clProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv_prm.Rows.Clear();
        }
        private void CargarProductos()
        {
            csConectaSQL conexion = new csConectaSQL();
            DataTable dt = conexion.RetornaRegistros( "select IdProductos, Codigo, Nombre, Precio " +
                "from Productos order by Nombre"
            );

            if (dt == null)
            {
                return;
            }

            dgv_prm.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                int indice = dgv_prm.Rows.Add(
                    false,
                    fila["Codigo"].ToString(),
                    fila["Nombre"].ToString(),
                    Convert.ToDecimal(fila["Precio"]).ToString("0.00")
                );
                dgv_prm.Rows[indice].Tag = Convert.ToInt32(fila["IdProductos"]);
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            prd_selet.Clear();
            nm_selet.Clear();
            foreach (DataGridViewRow fila in dgv_prm.Rows)
            {
                bool seleccionado = Convert.ToBoolean(fila.Cells["clSeleccionar"].Value ?? false);
                if (seleccionado)
                {
                    int idProducto = Convert.ToInt32(fila.Tag);
                    string nombreProducto = fila.Cells["clProducto"].Value?.ToString() ?? "";
                    prd_selet.Add(idProducto);
                    nm_selet.Add(nombreProducto);
                }
            }
            if (prd_selet.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione al menos un producto.",
                    "Productos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_cerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
