using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppO
{
    public class Oferta : Compra
    {
        public decimal Descuento;
        public string? Tipo;
        public bool EsAplicable()
        {
            return true;
        }
    }
}