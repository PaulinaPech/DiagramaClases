using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppO
{
    public class Compra : Usuario
    {
        public decimal Monto;
        public string? PoS;
        public Oferta AplicarOferta()
        {
            return new Oferta();
        }
    }
}