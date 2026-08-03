using System;
using System.Collections.Generic;
using System.Text;

namespace Derick
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }

        public Producto()
        {
        }
        public Producto(int id, string nom, string desc, string cat, string clr, string tll, decimal pre, int stk, string estd, string cdg)
        {
            Id = id;
            Nombre = nom;
            Descripcion = desc;
            Categoria = cat;
            Color = clr;
            Talla = tll;
            Precio = pre;
            Stock = stk;
            Estado = estd;
            Codigo = cdg;
        }
    }
}
