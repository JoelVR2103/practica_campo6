using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    public static class ClassAna
    {
        // Genera un ID de usuario a partir del nombre y el año de ingreso
        public static string GenerarID(string nombre, int anioIngreso)
        {
            return nombre.Substring(0, 3).ToUpper() + anioIngreso;
        }
    }
}
