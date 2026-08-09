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
            if(string.IsNullOrWhiteSpace(txt_cd.Text))
            {
                MessageBox.Show("Ingrese una talla");
                return;
            }
            Ntll = txt_cd.Text.Trim().ToUpper();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
