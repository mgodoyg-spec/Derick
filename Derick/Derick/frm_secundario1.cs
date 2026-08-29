using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frm_secundario1 : Form
    {
        public string Ntll { get; private set; } = "";
        public frm_secundario1()
        {
            InitializeComponent();
        }

        private void frm_secundario1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string talla = txt_cd.Text.Trim().ToUpper();

            // Validar que haya escrito una talla
            if (string.IsNullOrWhiteSpace(talla))
            {
                MessageBox.Show(
                    "Ingrese una talla.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_cd.Focus();
                return;
            }

            csConectaSQL conexion = new csConectaSQL();
            // Verificar si la talla ya existe
            DataTable dt = conexion.RetornaRegistros($"select IdTalla from Tallas where Nombre = '{talla}'");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "La talla ya existe.",
                    "Talla duplicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            // Guardar la nueva talla
            bool guardado = conexion.insertDatos("Tallas", "Nombre", $"'{talla}'");
            if (!guardado)
            {
                MessageBox.Show(
                    "No se pudo guardar la talla.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            // Devolver la talla a FormAgg_Product
            Ntll = talla;
            MessageBox.Show(
                "Talla guardada correctamente.",
                "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
