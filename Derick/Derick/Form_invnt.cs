using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class Form_invnt : Form
    {
        public Form_invnt()
        {
            InitializeComponent();
        }
        private void Form_invnt_Load(object sender, EventArgs e)
        {
            ccm.Rows.Add("2M4M2", "Camisa Casual Negra", "Caqueta Negra", "M", "Sucursal-Centro de Quevedo");
            ccm.Rows.Add("3M2L4", "Camisa Casual Blanca", "Camisa Casual Azul", "L", "Sucursal-Centro de Quito");
        }
    }
}
