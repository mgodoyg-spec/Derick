using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 12);

            e.Graphics.DrawString("REPORTE DE VENTAS", fuente, Brushes.Black, 100, 50);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), fuente, Brushes.Black, 100, 80);

            // Aquí luego irán los datos de la base de datos.
        }

    }
}
