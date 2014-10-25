using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa algun numero entero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero entero diferente de cero");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de "+a+" + "+b+" es " + (a+b));

            Console.WriteLine("La diferencia {0} - {1} es {2}",a,b,(a-b));

            Console.WriteLine("El producto {0} * {1} es {2}", a, b, (a * b));

            Console.WriteLine("El cociente entero {0} / {1} es {2}", a, b, (a / b));

            Console.WriteLine("El resto {0} % {1} es {2}", a, b, (a % b));

            

            Console.ReadKey();
            
        }
    }
}
