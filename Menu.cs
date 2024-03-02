using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_de_Colas
{
    internal class Menu
    {
        #region Constructor 
        public Menu()
        {
        }
        #endregion

        #region Atributos 
        private int op;
        private readonly int tipos = 5; // Tipos de afecciones (Accidentes, Infartos, Afecciones Respiratorias, Partos/Pediatria, Normal)
        private int fullNinios = 0; // El tope sera 25 ninios (5 por enfermedad)
        private int fullAdultos = 0; // El tope sera 25 adultos (5 por enfermedad)
        private readonly int maxPorMedico = 25;
        #endregion

        #region Metodos

        #region SubMenu
        public void SubMenu(Cola[] ninios, Cola[] adultos)
        {
            var random = new Random();
            int edad;
            do
            {

                Console.WriteLine("\nIngrese la opcion que desee realizar: ");
                Console.WriteLine("1. Ingresar paciente");
                Console.WriteLine("2. Atender paciente");
                Console.WriteLine("3. Mostrar todos los pacientes en cola");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                op = int.Parse(s: Console.ReadLine()!);

                switch (op)
                {
                    #region INGRESAR
                    case 1:
                        edad = random.Next(2); // Si el random es 0 es ninio, si sale 1 es adulto
                        int tipo;
                        string? nombre; ;

                        if (edad == 0) // Es un niño
                        {
                            if (fullNinios != maxPorMedico)
                            {
                                fullNinios++; // Se incrementa la cantidad de ninios en cola

                                do
                                {
                                    Console.Write("Ingrese el nombre del paciente: ");
                                    nombre = Console.ReadLine();

                                    if (string.IsNullOrEmpty(nombre))
                                    {
                                        Console.WriteLine("No ingreso ningun nombre.");
                                    }

                                } while (string.IsNullOrEmpty(nombre));

                                do
                                {
                                    Console.WriteLine("Ingrese <0> si el paciente no tiene nada grave.");
                                    Console.WriteLine("Ingrese <1> si el paciente se esta muriendo.");

                                    Console.Write("Opcion: ");

                                    tipo = int.Parse(s: Console.ReadLine()!);

                                    tipo = int.Parse(Console.ReadLine());
                                    
                                    if ((tipo < 0) || (tipo > 1))
                                    {
                                        Console.WriteLine("ERROR. Tipo Invalido");
                                    }

                                } while ((tipo < 0) || (tipo > 1));

                                } while ((tipo < 0) || (tipo > 1));                                   

                                if (tipo == 0) // Se asigna al paciente como paciente normal
                                {
                                    Paciente nuevoPaciente = new(nombre, edad, tipo, 4);
                                    ninios[4].PUSH(nuevoPaciente);
                                    MostrarDatosPaciente(nuevoPaciente);
                                }
                                else // El paciente se asigna con alguna prioridad random
                                {
                                    int prioridad = random.Next(4); // Aleatoriamente se saca la prioridad del paciente para ver en que cola ira

                                    Paciente nuevoPaciente = new(nombre, edad, tipo, prioridad);

                                    ninios[prioridad].PUSH(nuevoPaciente);

                                    MostrarDatosPaciente(nuevoPaciente);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo siento. Ya no se pueden registrar mas ninios.");
                            }
                        }
                        else // Es un adulto
                        {
                            if (fullAdultos != maxPorMedico)
                            {
                                fullAdultos++; // Se incrementa la cantidad de adultos en cola

                                do
                                {
                                    Console.Write("Ingrese el nombre del paciente: ");
                                    nombre = Console.ReadLine();

                                    if (string.IsNullOrEmpty(nombre))
                                    {
                                        Console.WriteLine("No ingreso ningun nombre.");
                                    }

                                } while (string.IsNullOrEmpty(nombre));

                                do
                                {
                                    Console.WriteLine("Ingrese <0> si el paciente no tiene nada grave.");
                                    Console.WriteLine("Ingrese <1> si el paciente se esta muriendo.");

                                    Console.Write("Opcion: ");

                                    tipo = int.Parse(s: Console.ReadLine()!);


                                    tipo = int.Parse(s: Console.ReadLine());
                                 
                                    if ((tipo < 0) || (tipo > 1))
                                    {
                                        Console.WriteLine("ERROR. Tipo Invalido");
                                    }
                                } while ((tipo < 0) || (tipo > 1));
                               
                                if (tipo == 0) // Se asigna al paciente como paciente normal
                                {
                                    Paciente nuevoPaciente = new(nombre, edad, tipo, 4);

                                    adultos[4].PUSH(nuevoPaciente);

                                    MostrarDatosPaciente(nuevoPaciente);
                                    
                                }
                                else
                                {
                                    int prioridad = random.Next(4);       

                                    Paciente nuevoPaciente = new(nombre, edad, tipo, prioridad);

                                    adultos[prioridad].PUSH(nuevoPaciente);
                                  
                                    MostrarDatosPaciente(nuevoPaciente);
        
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo siento. Ya no se pueden registrar mas adultos.");
                            }
                        }

                        break;

                    #endregion

                    #region ATENDER
                    case 2: // Remover Paciente
                        edad = random.Next(2);

                        if ((edad == 0) && (fullNinios > 0)) // Se removera a un nino si es que hay
                        {
                            fullNinios--;

                            for (int i = 0; i < tipos; i++)
                            {
                                if (!(ninios[i].Vacia()))
                                {
                                    Console.WriteLine("\nSe esta atendiendo a este paciente: ");
                                    MostrarDatosPaciente(ninios[i].POPINICIAL());
                                    ninios[i].POP();
                                    break;
                                }
                            }
                        }
                        else if (fullAdultos > 0) // Se removera a un adulto si es que hay
                        {
                            fullAdultos--;

                            for (int i = 0; i < tipos; i++)
                            {
                                if (!(adultos[i].Vacia()))
                                {
                                    Console.WriteLine("Se esta atendiendo a este paciente: \n");
                                    MostrarDatosPaciente(adultos[i].POPINICIAL());
                                    ninios[i].POP();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay nadie en la cola\n");
                        }

                        break;
                    #endregion

                    #region MOSTRAR
                    case 3: // Mostrar Colas de Pacientes
                        break;
                    #endregion

                    #region SALIR
                    case 4:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    #endregion

                    #region DEFAULT
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

        #region CREAR COLAS
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
                adultos[i] = new Cola();
            }

            SubMenu(ninios, adultos);
        }
        #endregion

        #region MOSTRAR PACIENTE
        
        public static void MostrarDatosPaciente(Paciente paciente)

        {
            Console.WriteLine("\n\nDATOS DEL PACIENTE");
            Console.WriteLine($"Nombre: {paciente.GetNombre()}");
            if (paciente.GetEdad() == 0)
            {
                Console.WriteLine("Persona: Ninio");
            }
            else
            {
                Console.WriteLine("Persona: Adulto");
            }

            BuscarPrioridad(paciente.GetPrioridad(), paciente.GetEdad());
        }

        #endregion

        #region BUSCAR PRIORIDAD

        public static void BuscarPrioridad(int prioridad, int edad)
        {
            switch (prioridad)
            {
                case 0:
                    Console.WriteLine("Prioridad: Maxima");
                    Console.WriteLine("Paciente sufrio Accidente Aparatoso");
                    break;

                case 1:
                    Console.WriteLine("Prioridad: Altisima");
                    Console.WriteLine("Paciente sufrio Infarto");
                    break;

                case 2:
                    Console.WriteLine("Prioridad: Muy alta");
                    Console.WriteLine("Paciente sufrio Afeccion Respiratoria");
                    break;

                case 3:
                    Console.WriteLine("Prioridad: Alta");
                    if (edad == 0)
                    {
                        Console.WriteLine("Paciente debe ir a Pediatria");
                    }
                    else
                    {
                        Console.WriteLine("Paciente debe ir a Sala de Partos");
                    }
                    break;

                case 4:
                    Console.WriteLine("Prioridad: Normal");
                    Console.WriteLine("No sufre nada grave");
                    break;
            }
        }

        #endregion


        #endregion
    }
}