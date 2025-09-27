using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using funciones;

namespace PracticaCampo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EncabezadoPie.MostrarEncabezado();

            // Caso Juan: multa por retraso
            Console.WriteLine("\n[Juan] Ingrese días de retraso:");
            int dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tarifa por día:");
            double tarifa = double.Parse(Console.ReadLine());
            Console.WriteLine("Multa total: S/. " + ClassJuan.CalcularMulta(dias, tarifa));

            // Caso Ana: generar ID de usuario
            Console.WriteLine("\n[Ana] Ingrese nombre del usuario:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese año de ingreso:");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("ID generado: " + ClassAna.GenerarID(nombre, anio));

            // Caso Luis: promedio de notas
            Console.WriteLine("\n[Luis] Ingrese 3 notas:");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Promedio: " + ClassLuis.CalcularPromedio(n1, n2, n3));

            // Caso María: validar contraseña
            Console.WriteLine("\n[María] Ingrese una contraseña:");
            string pass = Console.ReadLine();
            Console.WriteLine("Ingrese longitud mínima:");
            int min = int.Parse(Console.ReadLine());
            bool valida = ClassMaria.ValidarPassword(pass, min);
            Console.WriteLine(valida ? "Contraseña válida" : "Contraseña demasiado corta");

            EncabezadoPie.MostrarPiePagina();
        }
    }
}
