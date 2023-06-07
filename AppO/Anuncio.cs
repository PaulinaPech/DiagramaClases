using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppO
{
    public class Anuncio
    {
        public string? Titulo;
        public string? Imagen;
        public string? Descripcion;
        public decimal? Precio;
        public string? Telefono;
        public Audiencia? Audiencia { get; set; }
        public Servicio? Servicio { get; set; }
    }
}