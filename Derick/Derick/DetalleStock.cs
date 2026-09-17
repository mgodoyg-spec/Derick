using System;
using System.Collections.Generic;
using System.Text;

namespace Derick
{
    public class DetalleStock
    {
        public int IdDetallePedido { get; set; }
        public string Talla { get; set; } = "";
        public string Color { get; set; } = "";
        public int stock { get; set; }
        public int cantidadDisponible { get; set; }
    }
}
