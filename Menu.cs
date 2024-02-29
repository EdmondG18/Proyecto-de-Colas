using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Colas {
    internal class Menu
    {
        #region Constructor 
        public Menu(){
        }
        #endregion

        #region Atributos 
        private int op;
        private int tipos = 5; 
        private int fullNinios = 0; // El tope sera 25 ninios (5 por enfermedad)
        private int fullAdultos = 0; // El tope sera 25 adultos (5 por enfermedad)


        #endregion

        #region Metodos

        #region SubMenu
        public void SubMenu(Cola[] ninios, Cola[] adultos)
        {
            do
            {
                Console.WriteLine("\nIngrese la opcion que desee realizar: ");
                Console.WriteLine("1. Ingresar paciente");
                Console.WriteLine("2. Atender paciente");
                Console.WriteLine("3. Mostrar todos los pacientes en cola");
                Console.WriteLine("4. Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    #region Ingresar
                    case 1: 





                        break;
                        
                    #endregion

                    #region Atender
                    case 2: // Remover Paciente
                        break;
                    #endregion

                    #region Mostrar
                    case 3: // Mostrar Colas de Pacientes
                        break;
                    #endregion

                    #region Salir
                    case 4:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    #endregion

                    #region Default
                    default:
                        Console.WriteLine("\nERROR. Opcion Invalida");
                        break;
                    #endregion
                }
                if (op != 4)
                {
                    Console.WriteLine("\nIngrese cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (op != 4);
        }
        #endregion

        #region Crear Colas
        public void CrearColas()
        {
            Console.WriteLine("Bienvenido al Centro Clinico de Emergencias\n");

            // Se crea la cola de ninios
            Cola[] ninios = new Cola[tipos];
            for (int i = 0; i < tipos; i++) // i=0 (Accidente) // i=1 (Infarto) // i=2 (Afeccion) // i=3 (Pediatria) // i=4 (Normal)
            {
                ninios[i] = new Cola();
            }

            // Se crea la cola de adultos
            Cola[] adultos = new Cola[5];
            for (int i = 0; i < tipos; i++) // i=0 (Accidente) // i=1 (Infarto) // i=2 (Afeccion) // i=3 (Partos) // i=4 (Normal)
            {
                ninios[i] = new Cola();
            }

            SubMenu(ninios, adultos);
        }
        #endregion


        #endregion
    }
}

