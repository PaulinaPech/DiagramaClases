using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppO
{
    public class Presupuesto : Acciones
    {
        public decimal CostoClic;
        public decimal GasoTotal;

        public Oferta? Oferta { get; set; }
    }
}