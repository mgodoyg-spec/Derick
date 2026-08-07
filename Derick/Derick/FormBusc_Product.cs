using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormBusc_Product : Form
    {
        private BindingList<Producto> listaproductos = new BindingList<Producto>();
        public FormBusc_Product()
        {
            InitializeComponent();

        }
    }
}
