using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola1
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 10, b = 30,c = 0,d=1,edad=20;

            bool res;


            res = a == b;

            res = a != b;

            res = a < b;



            res = a <= b && b<=c;

            res = a <= b && b <= c && c<=d;



            res = a <= b || b <= c;

            res = a <= b || b <= c || c <= d;



            if(edad>=18)
            {

                Console.WriteLine("Es mayor de edad");

            }
            else
            {

                Console.WriteLine("Es menor de edad");

            }


            






            Console.ReadKey();
        }
    }
}
