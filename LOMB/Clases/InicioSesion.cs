using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMB.Clases
{
    public class InicioSesion
    {
        public static bool login(string usuario, string contrasenna)
        {
            return usuario.Equals("FRAN") && contrasenna.Equals("4321");
        }
    }
}
