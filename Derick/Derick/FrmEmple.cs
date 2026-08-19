using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmEmple : Form
    {
        private bool cargandoFiltros = false;

        public FrmEmple()
        {
            InitializeComponent();
        }

        private void FrmEmple_Load(object sender, EventArgs e)
        {
            // DISEÑO DEL DATAGRIDVIEW - se conserva como estaba originalmente
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.GridColor = Color.FromArgb(235, 235, 235);
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.RowHeadersVisible = false;

            // ENCABEZADO
            dgvEmpleados.ColumnHeadersHeight = 50;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 57, 75);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS
            dgvEmpleados.RowTemplate.Height = 45;
            dgvEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvEmpleados.DefaultCellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            dgvEmpleados.DefaultCellStyle.BackColor = Color.White;
            dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251);
            dgvEmpleados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 250);
            dgvEmpleados.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvEmpleados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.DefaultCellStyle.Padding = new Padding(5);

            // TAMAÑO DE COLUMNAS
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.Columns["clCodigo"].FillWeight = 8;
            dgvEmpleados.Columns["clEmpleado"].FillWeight = 20;
            dgvEmpleados.Columns["clCargo"].FillWeight = 12;
            dgvEmpleados.Columns["clDepartamento"].FillWeight = 20;
            dgvEmpleados.Columns["clTelefono"].FillWeight = 13;
            dgvEmpleados.Columns["clCorreo"].FillWeight = 18;
            dgvEmpleados.Columns["clEstado"].FillWeight = 10;
            dgvEmpleados.Columns["clEditar"].FillWeight = 8;
            dgvEmpleados.Columns["clEliminar"].FillWeight = 8;
            dgvEmpleados.Columns["clVer"].FillWeight = 8;
            dgvEmpleados.Columns["ClImagen"].FillWeight = 8;

            // ICONOS
            DataGridViewImageColumn editar =
                (DataGridViewImageColumn)dgvEmpleados.Columns["clEditar"];
            editar.Image = Properties.Resources.editarrbtn;
            editar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn eliminar =
                (DataGridViewImageColumn)dgvEmpleados.Columns["clEliminar"];
            eliminar.Image = Properties.Resources.picEliminar;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn ver =
                (DataGridViewImageColumn)dgvEmpleados.Columns["clVer"];
            ver.Image = Properties.Resources.ojo;
            ver.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn imagen =
                (DataGridViewImageColumn)dgvEmpleados.Columns["ClImagen"];
            imagen.Image = Properties.Resources.person_icon_31846;
            imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // CENTRAR COLUMNAS
            string[] columnasCentro =
            {
                "clCodigo",
                "clEmpleado",
                "clCargo",
                "clDepartamento",
                "clTelefono",
                "clCorreo",
                "clEstado",
                "clEditar",
                "clEliminar",
                "clVer",
                "ClImagen"
            };

            foreach (string columna in columnasCentro)
            {
                dgvEmpleados.Columns[columna].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            // CARGAR FILTROS
            cargandoFiltros = true;
            CargarCombos();
            cbxDepa.SelectedIndex = -1;
            cbxSucursal.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            cbxDepa.Text = "";
            cbxSucursal.Text = "";
            cbxEstado.Text = "";
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DimGray;
            cargandoFiltros = false;

            CargarEmpleados();
        }

        private void CargarCombos()
        {
            csEmpleado emp = new csEmpleado();

            cbxDepa.DataSource = emp.ObtenerDepartamentos();
            cbxDepa.DisplayMember = "Departamento";
            cbxDepa.SelectedIndex = -1;

            cbxSucursal.DataSource = emp.ObtenerSucursales();
            cbxSucursal.DisplayMember = "NombreSucursal";
            cbxSucursal.SelectedIndex = -1;

            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            cbxEstado.SelectedIndex = -1;
        }

        private void AplicarFiltros()
        {
            string buscar = txtBuscar.Text.Trim();

            if (buscar == "Buscar")
                buscar = "";

            CargarEmpleados(
                buscar,
                cbxDepa.Text,
                cbxEstado.Text,
                cbxSucursal.Text
            );
        }

        private void CargarEmpleados(string buscar = "", string departamento = "", string estado = "", string sucursal = "")
        {
            DataTable dt = new csEmpleado().Listar(buscar, departamento, estado, sucursal);
            if (dt == null) return;

            dt.Columns.Add("ImagenEmpleado", typeof(Image));

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["Foto"] != DBNull.Value)
                {
                    try
                    {
                        byte[] bytes = (byte[])fila["Foto"];
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
                        using (Image temporal = Image.FromStream(ms))
                            fila["ImagenEmpleado"] = new Bitmap(temporal);
                    }
                    catch
                    {
                        fila["ImagenEmpleado"] = Properties.Resources.person_icon_31846;
                    }
                }
                else
                {
                    fila["ImagenEmpleado"] = Properties.Resources.person_icon_31846;
                }
            }

            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns["clCodigo"].DataPropertyName = "Codigo";
            dgvEmpleados.Columns["clEmpleado"].DataPropertyName = "Empleado";
            dgvEmpleados.Columns["clCargo"].DataPropertyName = "Cargo";
            dgvEmpleados.Columns["clDepartamento"].DataPropertyName = "Departamento";
            dgvEmpleados.Columns["clTelefono"].DataPropertyName = "Telefono";
            dgvEmpleados.Columns["clCorreo"].DataPropertyName = "Correo";
            dgvEmpleados.Columns["clEstado"].DataPropertyName = "Estado";
            dgvEmpleados.Columns["ClImagen"].DataPropertyName = "ImagenEmpleado";
            dgvEmpleados.DataSource = dt;
        }
        // EVENTOS DE LOS FILTROS Ya NO buscan automáticamente. La búsqueda se hace solamente con el botón Buscar.
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            string buscar = txtBuscar.Text;

            if (buscar == "Buscar")
                buscar = "";

            CargarEmpleados(
                buscar,
                cbxDepa.Text,
                cbxEstado.Text,
                cbxSucursal.Text
            );
        }

        private void cbxDepa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            AplicarFiltros();
        }

        private void cbxSucursal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cargandoFiltros)
                return;

            AplicarFiltros();
        }

        private void cbxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cargandoFiltros)
                return;

            AplicarFiltros();
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmInfoEmple frm = new FrmInfoEmple();
            frm.ShowDialog();

            CargarEmpleados();
        }

        // BOTÓN LIMPIAR

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar";
            txtBuscar.ForeColor = Color.DimGray;

            cbxDepa.SelectedIndex = -1;
            cbxSucursal.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;

            cbxDepa.Text = "";
            cbxSucursal.Text = "";
            cbxEstado.Text = "";

            CargarEmpleados();
        }

        // Este era el botón verde "Nuevo".
        // Ahora ese botón es BUSCAR.
        private void btnNuevoEmple_Click_1(object sender, EventArgs e)
        {
            btnBuscarEmpleado_Click(sender, e);
        }


        // Este era el botón Departamentos.
        // Ahora ese botón es NUEVO EMPLEADO.
        private void btnDepa_Click_1(object sender, EventArgs e)
        {
            btnNuevoEmpleado_Click(sender, e);
        }

        private void dgvEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string codigo = dgvEmpleados.Rows[e.RowIndex].Cells["clCodigo"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(codigo)) return;

            string columna = dgvEmpleados.Columns[e.ColumnIndex].Name;

            if (columna == "clEditar")
            {
                new FrmInfoEmple(codigo).ShowDialog();
                AplicarFiltros();
            }
            else if (columna == "clVer")
            {
                new FrmDetalleEmpleado(codigo).ShowDialog();
            }
            else if (columna == "clEliminar")
            {
                string nombre =
                    dgvEmpleados.Rows[e.RowIndex]
                    .Cells["clEmpleado"]
                    .Value?
                    .ToString();

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de eliminar al empleado " + nombre + "?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                if (respuesta != DialogResult.Yes)
                    return;

                csEmpleado emp =
                    new csEmpleado()
                    .BuscarPorCodigo(codigo);

                if (emp == null)
                {
                    MessageBox.Show(
                        "No se encontró el empleado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (emp.Eliminar())
                {
                    MessageBox.Show(
                        "Empleado eliminado correctamente.",
                        "Eliminar empleado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    AplicarFiltros();
                }
                else
                {
                    MessageBox.Show(
                        "No se puede eliminar este empleado porque tiene ventas registradas.",
                        "Eliminar empleado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }


        private void lblSalirV_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }
    }
}