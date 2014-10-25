using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            
            List<int> lista = new List<int>();
            var lista2 =new List<int>();
            lista2.FirstOrDefault();
            String.Format("Persona {0} su edad es {1}",20,9);
            int edad=20,a=1234,b=3,c=20,factorial=1,num=127,dig;
            string d = "",cad="";
            if (edad >= 18)
            {
                
                    
                Console.WriteLine("Es mayor de edad");

            }
            else
            {

                Console.WriteLine("Es menor de edad");

            }


            for (int i = 1; i <= 10; i++)
            {

                factorial = factorial * i;

            }

            Console.WriteLine(factorial);


            while(num!=0){

                dig=num%10;

                num = num / 10;

                Console.WriteLine(dig);

            }
            Console.WriteLine("--------------");
 

            Console.ReadKey();
        }




    }
}
