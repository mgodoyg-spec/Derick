using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmBuscarClienteV : Form
    {
        public FrmBuscarClienteV()
        {
            InitializeComponent();
        }

        private csCliente cliente = new csCliente();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdClienteSeleccionado { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NombreClienteSeleccionado { get; set; } = "";


        private void FrmBuscarClienteV_Load(object sender, EventArgs e)
        {
            //diseño del datagridview
            dgvNVBC.EnableHeadersVisualStyles = false;
            dgvNVBC.BorderStyle = BorderStyle.None;
            dgvNVBC.BackgroundColor = Color.White;
            dgvNVBC.GridColor = Color.FromArgb(235, 235, 235);
            dgvNVBC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNVBC.ReadOnly = true;
            dgvNVBC.MultiSelect = false;
            dgvNVBC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVBC.AllowUserToAddRows = false;
            dgvNVBC.AllowUserToDeleteRows = false;
            dgvNVBC.AllowUserToResizeRows = false;
            dgvNVBC.AllowUserToResizeColumns = false;
            dgvNVBC.RowHeadersVisible = false;

            //encabezado
            dgvNVBC.ColumnHeadersHeight = 50;
            dgvNVBC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNVBC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvNVBC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNVBC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNVBC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //filas
            dgvNVBC.RowTemplate.Height = 45;
            dgvNVBC.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNVBC.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvNVBC.DefaultCellStyle.BackColor = Color.White;
            dgvNVBC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvNVBC.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvNVBC.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNVBC.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNVBC.DefaultCellStyle.Padding = new Padding(5);

            //columnas
            dgvNVBC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvNVBC.Columns["colNombre"].FillWeight = 25;
            dgvNVBC.Columns["colTel"].FillWeight = 18;
            dgvNVBC.Columns["colEditar"].FillWeight = 10;
            dgvNVBC.Columns["colEliminar"].FillWeight = 10;

            DataGridViewImageColumn editar = (DataGridViewImageColumn)dgvNVBC.Columns["colEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar = (DataGridViewImageColumn)dgvNVBC.Columns["colEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //columnas centradas
            string[] columnasCentro =
            {
    "colNombre",
    "colTel",
    "colEditar",
    "colEliminar"
};

            foreach (string columna in columnasCentro)
            {
                dgvNVBC.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            CargarClientes();
        }

        private void CargarClientes(string filtro = "")
        {
            dgvNVBC.Rows.Clear();
            DataTable dt = cliente.Listar(filtro);

            if (dt == null) return;

            foreach (DataRow fila in dt.Rows)
            {
                int posicion = dgvNVBC.Rows.Add();
                DataGridViewRow row = dgvNVBC.Rows[posicion];

                row.Tag = Convert.ToInt32(fila["IdCliente"]);
                row.Cells["colNombre"].Value = fila["NombreCompleto"].ToString();
                row.Cells["colTel"].Value = fila["Telefono"].ToString();
            }
        }

        private void txtNVBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(txtNVBuscarCliente.Text.Trim());
        }

        private void picNVBC_Click(object sender, EventArgs e)
        {
            CargarClientes(txtNVBuscarCliente.Text.Trim());
        }

        private void btnNVBC_Click(object sender, EventArgs e)
        {
            FrmNuevoClienteV nuevo = new FrmNuevoClienteV();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                CargarClientes();
            }
        }

        private void dgvNVBC_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            IdClienteSeleccionado = Convert.ToInt32(dgvNVBC.Rows[e.RowIndex].Tag);
            NombreClienteSeleccionado = dgvNVBC.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
