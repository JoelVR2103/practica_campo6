using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    public static class ClassJuan
    {
        // Calcula la multa según días de retraso
        public static double CalcularMulta(int diasRetraso, double tarifaPorDia)
        {
            return diasRetraso * tarifaPorDia;
        }
    }
}
