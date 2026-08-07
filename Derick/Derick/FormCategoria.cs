using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Derick
{
    public partial class FormCategoria : Form
    {
        private BindingList<Producto> listaproductos = new BindingList<Producto>();
        public FormCategoria()
        {
            InitializeComponent();

        }
    }
}
