using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppO
{
    public class Anunciante : Plan
    {
        public string? Nombre;
        public string? Correo;
        public string? Telefono;
        public string? Direccion;
        public string? Contrasena;
        public string? Foto;
        public Programacion? Programacion { get; set; }
        public Audiencia? Audiencia { get; set; }
        public Acciones? Acciones { get; set; }
    }
}