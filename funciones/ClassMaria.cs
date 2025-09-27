using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    public static class ClassMaria
    {
        // Verifica si la contraseña cumple con un mínimo de longitud
        public static bool ValidarPassword(string password, int minimoCaracteres)
        {
            return password.Length >= minimoCaracteres;
        }
    }
}
