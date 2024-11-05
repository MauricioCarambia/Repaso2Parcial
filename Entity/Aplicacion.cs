﻿using System.Reflection;

namespace Entity
{
    public class Aplicacion
    {
        public int IdAplicacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Desarrolladora { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }
    }
}
