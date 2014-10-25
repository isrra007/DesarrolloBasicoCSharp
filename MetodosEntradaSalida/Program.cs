using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            //para mostrar
            Console.WriteLine("Esta una cadena de ejemplo");

            string nombreCadena = "Todos";
            Console.WriteLine("Escribe un cualquier texto");
            // Ingreso de datos
            //Este metodo devuelve una cadena ingresada por consola hasta final de linea
            nombreCadena=Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine(nombreCadena);

            //No olvides
            Console.ReadKey();
        }
    }
}
