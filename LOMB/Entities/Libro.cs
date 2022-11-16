using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMB.Entities
{
    public class Libro
    {
        public string isbn { get; set; }
        public string nombre { get; set; }
        public string fecha_publicacion { get; set; }
        public List<Autor> autores { get; set; }
        public Idioma idioma { get; set; }
        public Editorial editorial { get; set; }
        public List<Categoria> categorias { get; set; }

        public override string ToString()
        {
            return String.Format("ISBN: {0}\nNombre: {1}\nFecha de publicación: {2}\nIdioma: {3}\nEditorial: {4}", isbn, nombre, fecha_publicacion, idioma, editorial);
        }
    }
}
