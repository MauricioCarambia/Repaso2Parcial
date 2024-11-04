using System.Reflection;

namespace Entity
{
    public class Aplicacion
    {
        private int ID;
        private string Titulo;
        private string Descripcion;
        private string Desarrolladora;
        private decimal Precio;
        private Categoria categoria;

        public int ID1 { get => ID; set => ID = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Desarrolladora1 { get => Desarrolladora; set => Desarrolladora = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
