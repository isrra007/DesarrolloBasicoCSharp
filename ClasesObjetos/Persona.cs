using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{

    class Persona
    {
        //atributos
        private int fono { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        private int ci { get; set; }
        private string genero { get; set; }
        public float altura { get; set; }
        private bool lentes { get; set; }
        private float peso { get; set; }

        //metodos 
        //constructor 
        public Persona()
        {
          
        }
        public void caminar() { 

        }
        public void correr() { 

        }
        //destructor(no es necesario)
        ~Persona()
        {

        }
    }





}
