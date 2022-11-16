using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMB.Entities
{
    public class Autor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string pais_origen { get; set; }
        public Categoria categoria { get; set; }
        public Editorial editorial { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0} Nombre: {1}", id, nombre);
        }
    }
}
