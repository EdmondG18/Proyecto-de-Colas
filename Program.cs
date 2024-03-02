using System;

namespace Proyecto_de_Colas
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Testing de POP()
             * 
            Cola cola = new Cola();
            cola.PUSH("Sexo");
            cola.PUSH("Pene");
            cola.POP();
            cola.Mostrar();
             
             */

            Menu m = new Menu();
            m.CrearColas();
        }
    }
}


