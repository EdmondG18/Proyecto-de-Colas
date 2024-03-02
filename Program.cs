using System;

namespace Proyecto_de_Colas
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu(); // Se crea el menu
            /*
             * Testing de POP()
             * 
            Cola cola = new Cola();
            cola.PUSH("Sexo");
            cola.PUSH("Pene");
            cola.POP();
            cola.Mostrar();
             
             */
            m.CrearColas();
        }
    }
}


