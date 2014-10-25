using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesProcedimientos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1234, b=0;
            string cad, d;
            Console.WriteLine("------------------Procedimientos");
            descdig(ref a, ref b, out cad, out d);
            Console.WriteLine("a= {0} b={1} c={2} d={3}", a, b, cad, d);

            Console.WriteLine("------------------Funciones");
            Console.WriteLine("Factorial de :");
            Console.WriteLine(factorial(int.Parse(Console.ReadLine())));

            Console.ReadKey();
        }

        private static int factorial(int n) {


            int f = 1;


            for (int i = 1; i <= n; i++)
            {

                f *= i;

            }
            
    
            return f;

        }


        private static void descdig(ref int num, ref int dig, out string c, out string d)
        {

            c = ""; d = "";

            while (num != 0)
            {

                dig = num % 10;

                num = num / 10;

                c = c + dig;

                d = dig + d;

            }

        }


        
    }
}
