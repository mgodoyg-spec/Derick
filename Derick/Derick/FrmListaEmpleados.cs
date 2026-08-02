using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void pnlListEmpleados_Paint(object sender, PaintEventArgs e)
        {
            dgvEmpleados.Rows.Add("EMP-001", null , "Juan Pérez", "Gerente", "Gerencia", "0991234567", "juan@derick.com", "Activo", Properties.Resources.picEditar,
    Properties.Resources.picEliminar);
            dgvEmpleados.Rows.Add("EMP-002", null, "María López", "Empleado", "Ventas", "0987654321", "maria@derick.com", "Activo", Properties.Resources.picEditar,
                Properties.Resources.picEliminar);

            dgvEmpleados.Rows.Add("EMP-003", null, "Carlos Ruiz", "Empleado", "Caja", "0971112233", "carlos@derick.com", "Inactivo", Properties.Resources.picEditar,
                Properties.Resources.picEliminar);

        }


        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado frm = new FrmNuevoEmpleado();
            frm.ShowDialog();
        }
    }
}
