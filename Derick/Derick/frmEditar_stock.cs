using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmEditar_stock : Form
    {
        private List<string> tallas;
        private List<string> colores;
        public int S_total { get; private set; }
        public frmEditar_stock()
        {
            InitializeComponent();
        }
        public frmEditar_stock(List<string> tallasSeleccionadas, List<string> coloresSeleccionados)
        {
            InitializeComponent();
            tallas = tallasSeleccionadas;
            colores = coloresSeleccionados;
        }

        private void frmEditar_stock_Load(object sender, EventArgs e)
        {
            dgv_stock.EnableHeadersVisualStyles = false;

            dgv_stock.BorderStyle = BorderStyle.None;
            dgv_stock.BackgroundColor = Color.White;
            dgv_stock.GridColor = Color.FromArgb(235, 235, 235);
            dgv_stock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv_stock.ReadOnly = false;
            dgv_stock.MultiSelect = false;
            dgv_stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_stock.AllowUserToAddRows = false;
            dgv_stock.AllowUserToDeleteRows = false;
            dgv_stock.AllowUserToResizeRows = false;
            dgv_stock.AllowUserToResizeColumns = false;

            dgv_stock.RowHeadersVisible = false;

            dgv_stock.ColumnHeadersHeight = 40;
            dgv_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv_stock.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(46, 57, 75);

            dgv_stock.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dgv_stock.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dgv_stock.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dgv_stock.RowTemplate.Height = 38;

            dgv_stock.DefaultCellStyle.Font =
            new Font("Segoe UI", 10);

            dgv_stock.DefaultCellStyle.ForeColor =
            Color.FromArgb(45, 45, 45);

            dgv_stock.DefaultCellStyle.BackColor =
            Color.White;

            dgv_stock.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(248, 249, 251);

            dgv_stock.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(225, 235, 250);

            dgv_stock.DefaultCellStyle.SelectionForeColor =
            Color.Black;

            dgv_stock.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dgv_stock.DefaultCellStyle.Padding = new Padding(5);

            dgv_stock.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            // Tamaño de columnas
            dgv_stock.Columns["clTalla"].FillWeight = 30;
            dgv_stock.Columns["clColor"].FillWeight = 40;
            dgv_stock.Columns["clStock"].FillWeight = 30;

            // Solo Stock se puede editar
            dgv_stock.Columns["clTalla"].ReadOnly = true;
            dgv_stock.Columns["clColor"].ReadOnly = true;
            dgv_stock.Columns["clStock"].ReadOnly = false;

            // Centrar contenido
            string[] columnasCentro =
            {
               "clTalla",
               "clColor",
               "clStock"
            };

            foreach (string columna in columnasCentro)
            {
                dgv_stock.Columns[columna].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }
            dgv_stock.Rows.Clear();

            CargarStock();
        }
        private void CargarStock()
        {
            dgv_stock.Rows.Clear();

            foreach (string talla in tallas)
            {
                foreach (string color in colores)
                {
                    dgv_stock.Rows.Add(
                        talla,
                        color,
                        0
                    );
                }
            }
        }
        private void CalcularStockTotal()
        {
            int total = 0;
            foreach (DataGridViewRow fila in dgv_stock.Rows)
            {
                if (fila.IsNewRow)
                    continue;
                if (int.TryParse(
                    fila.Cells["clStock"].Value?.ToString(),
                    out int stock))
                {
                    total += stock;
                }
            }
            S_total = total;
            lbl_total.Text = total.ToString();
        }
        private void dgv_stock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularStockTotal();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (DataGridViewRow fila in dgv_stock.Rows)
            {
                if (fila.IsNewRow)
                    continue;
                string valor = fila.Cells["clStock"].Value?.ToString() ?? "";
                if (!int.TryParse(valor, out int stock))
                {
                    MessageBox.Show(
                        "Ingrese un stock válido en todas las filas.",
                        "Stock inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (stock < 0)
                {
                    MessageBox.Show(
                        "El stock no puede ser negativo.",
                        "Stock inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                total += stock;
            }
            S_total = total;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
