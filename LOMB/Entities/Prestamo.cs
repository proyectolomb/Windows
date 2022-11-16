using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMB.Entities
{
    public class Prestamo
    {
        public Libro libro { get; set; }
        public Ejemplar ejemplar { get; set; }
        public Lector lector { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_devolucion { get; set; }
    }
}
