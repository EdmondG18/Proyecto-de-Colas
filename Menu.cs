using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private int fullNinios = 0; // El tope sera 25 ninios
        private int fullAdultos = 0; // El tope sera 25 adultos
        private readonly int maxPorMedico = 25;
        private Paciente? pacienteAtendido = null;
        #endregion

        #region Metodos

        #region SUBMENU
        public void SubMenu(Cola[] ninios, Cola[] adultos)
        {
            do
            {
                Console.WriteLine("Bienvenido al Centro Clinico de Emergencias\n");
                Console.WriteLine("Ingrese la opcion que desee realizar: ");
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
                        var random1 = new Random();
                        int edad = random1.Next(2); // Si el random es 0 es ninio, si sale 1 es adulto
                        int tipo;
                        string? nombre;

                        if (edad == 0) // Es un niño
                        {
                            if (fullNinios != maxPorMedico)
                            {
                                fullNinios++; // Se incrementa la cantidad de ninios en cola

                                do
                                {
                                    Console.Write("\nIngrese el nombre del paciente: ");
                                    nombre = Console.ReadLine();

                                    if (string.IsNullOrEmpty(nombre))
                                    {
                                        Console.WriteLine("No ingreso ningun nombre.");
                                    }

                                } while (string.IsNullOrEmpty(nombre));

                                do
                                {
                                    Console.WriteLine("\nIngrese <0> si el paciente no tiene nada grave o ingrese <1> si el paciente se esta muriendo.");
                                    Console.Write("Opcion: ");
                                    tipo = int.Parse(s: Console.ReadLine()!);

                                    if ((tipo < 0) || (tipo > 1))
                                    {
                                        Console.WriteLine("ERROR. Tipo Invalido");
                                    }

                                } while ((tipo < 0) || (tipo > 1));

                                if (tipo == 0) // Se asigna al paciente como paciente normal
                                {
                                    Paciente nuevoPaciente = new(nombre, tipo, edad, 4);

                                    ninios[4].PUSH(nuevoPaciente);
                                    MostrarDatosPaciente(nuevoPaciente);
                                }
                                else // El paciente se asigna con alguna prioridad random
                                {
                                    int prioridad = random1.Next(4); // Aleatoriamente se saca la prioridad del paciente para ver en que cola ira

                                    Paciente nuevoPaciente = new(nombre, tipo, edad, prioridad);

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
                                    Console.Write("\nIngrese el nombre del paciente: ");
                                    nombre = Console.ReadLine();

                                    if (string.IsNullOrEmpty(nombre))
                                    {
                                        Console.WriteLine("No ingreso ningun nombre.");
                                    }

                                } while (string.IsNullOrEmpty(nombre));

                                do
                                {
                                    Console.WriteLine("Ingrese <0> si el paciente no tiene nada grave o ingrese <1> si el paciente se esta muriendo.");
                                    Console.Write("Opcion: ");
                                    tipo = int.Parse(s: Console.ReadLine()!);

                                    if ((tipo < 0) || (tipo > 1))
                                    {
                                        Console.WriteLine("ERROR. Tipo Invalido");
                                    }
                                } while ((tipo < 0) || (tipo > 1));

                                if (tipo == 0) // Se asigna al paciente como paciente normal
                                {
                                    Paciente nuevoPaciente = new(nombre, tipo, edad, 4);

                                    adultos[4].PUSH(nuevoPaciente);

                                    MostrarDatosPaciente(nuevoPaciente);
                                }
                                else
                                {
                                    var random2 = new Random();
                                    int prioridad = random2.Next(4);

                                    Paciente nuevoPaciente = new(nombre, tipo, edad, prioridad);

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
                        var random = new Random();
                        edad = random.Next(2);

                        if (edad == 0) //Se remueve a un ninio
                        {
                            if (fullNinios > 0) // Se comprueba si hay ninios para remover
                            {
                                fullNinios--;

                                for (int i = 0; i < tipos; i++)
                                {
                                    if (!(ninios[i].Vacia()))
                                    {
                                        Console.WriteLine("\nSe esta atendiendo a este ninio: ");
                                        MostrarDatosPaciente(ninios[i].POPINICIAL());
                                        pacienteAtendido = ninios[i].POPINICIAL();
                                        ninios[i].POP();
                                        break;
                                    }
                                }
                            }
                            else if (fullAdultos > 0) // Si no, se remueve adulto, si es que hay
                            {
                                fullAdultos--;

                                for (int i = 0; i < tipos; i++)
                                {

                                    if (!(adultos[i].Vacia()))
                                    {
                                        Console.WriteLine("\nSe esta atendiendo a este adulto: ");
                                        MostrarDatosPaciente(adultos[i].POPINICIAL());
                                        pacienteAtendido = adultos[i].POPINICIAL();
                                        adultos[i].POP();
                                        break;
                                    }
                                }
                            }
                            else // Si no, no se remueve a nadie
                            {
                                Console.WriteLine("\nNo hay nadie en la cola");
                            }
                        }

                        else // Se remueve un adulto
                        {
                            if (fullAdultos > 0) // Se comprueba si hay adultos para remover
                            {
                                fullAdultos--;

                                for (int i = 0; i < tipos; i++)
                                {
                                    if (!(adultos[i].Vacia()))
                                    {
                                        Console.WriteLine("\nSe esta atendiendo a este paciente: ");
                                        MostrarDatosPaciente(adultos[i].POPINICIAL());
                                        pacienteAtendido = adultos[i].POPINICIAL();
                                        adultos[i].POP();
                                        break;
                                    }
                                }
                            }
                            else if (fullNinios > 0) // Si no, se remueve un ninio si es que hay
                            {
                                fullNinios--;

                                for (int i = 0; i < tipos; i++)
                                {
                                    if (!(ninios[i].Vacia()))
                                    {
                                        Console.WriteLine("\nSe esta atendiendo a este paciente: ");
                                        MostrarDatosPaciente(ninios[i].POPINICIAL());
                                        pacienteAtendido = ninios[i].POPINICIAL();
                                        ninios[i].POP();
                                        break;
                                    }
                                }
                            }
                            else // Si no, no se remueve a nadie
                            {
                                Console.WriteLine("\nNo hay nadie en la cola");
                            }
                        }
                        break;
                    #endregion

                    #region MOSTRAR
                    case 3: // Mostrar Colas de Pacientes

                        if (fullNinios == 0 && fullAdultos == 0)
                        {
                            if (pacienteAtendido != null)
                            {
                                Console.WriteLine("\nEN CONSULTA: ");
                                MostrarDatosPaciente(pacienteAtendido);
                            }
                            Console.WriteLine("\n\nEN COLA: ");
                            Console.WriteLine("\nNo se encuentran pacientes para mostrar");
                        }
                        else
                        {
                            if (pacienteAtendido != null)
                            {
                                Console.WriteLine("\nEN CONSULTA: ");
                                MostrarDatosPaciente(pacienteAtendido);
                            }
                            Console.WriteLine("\n\nEN COLA: ");
                            MostrarPacientes(ninios, adultos);
                        }

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

        #region MOSTRAR DATOS PACIENTE
        public static void MostrarDatosPaciente(Paciente? paciente)
        {
            Console.WriteLine("\n       DATOS DEL PACIENTE");
            Console.WriteLine($"Nombre: {paciente?.GetNombre()}");

            if (paciente?.GetEdad() == 0)
            {
                Console.WriteLine("Persona: Ninio");
            }
            else
            {
                Console.WriteLine("Persona: Adulto");
            }

            BuscarPrioridad(paciente?.GetPrioridad(), paciente?.GetEdad());
        }

        #endregion

        #region BUSCAR PRIORIDAD

        public static void BuscarPrioridad(int? prioridad, int? edad)
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
                        Console.WriteLine("Paciente a Pediatria");
                    }
                    else
                    {
                        Console.WriteLine("Paciente a Sala de Partos");
                    }
                    break;

                case 4:
                    Console.WriteLine("Prioridad: Normal");
                    Console.WriteLine("No sufre nada grave");
                    break;
            }
        }

        #endregion

        #region MOSTRAR PACIENTES
        public void MostrarPacientes(Cola[] pacientesNinios, Cola[] pacientesAdultos)
        {
            if (fullNinios > 0)
            {
                Console.WriteLine("\n\nCola de Ninios: ");
            }
            if (fullNinios > 0)
            {
                MostrarPacientesDePrioridad(pacientesNinios);
            }
            if (fullNinios > 0)
            {
                MostrarPacientesNormales(pacientesNinios);
            }

            if (fullAdultos > 0)
            {
                Console.WriteLine("\n\nCola de Adultos: ");
            }
            if (fullAdultos > 0)
            {
                MostrarPacientesDePrioridad(pacientesAdultos);
            }
            if (fullAdultos > 0)
            {
                MostrarPacientesNormales(pacientesAdultos);
            }
        }
        #endregion

        #region MOSTRAR PACIENTES DE PRIORIDAD
        private static void MostrarPacientesDePrioridad(Cola[] pacientes)
        {

            Cola auxiliar = new();
            for (int i = 0; i < 4; i++)
            {
                int length = pacientes[i].GetPacientesLength();

                for (int j = -1; j < length; j++)
                {
                    MostrarDatosPaciente(pacientes[i].POPINICIAL());
                    auxiliar.PUSH(dato: pacientes[i].POPINICIAL()!);
                    pacientes[i].POP();

                }
                pacientes[i] = auxiliar;
                auxiliar = new();
            }
        }
        #endregion

        #region MOSTRAR PACIENTES NORMALES
        private static void MostrarPacientesNormales(Cola[] pacientes)
        {
            Cola auxiliar = new();
            int length = pacientes[4].GetPacientesLength();
            for (int j = -1; j < length; j++)
            {
                MostrarDatosPaciente(pacientes[4].POPINICIAL());
                auxiliar.PUSH(dato: pacientes[4].POPINICIAL()!);
                pacientes[4].POP();
            }
            pacientes[4] = auxiliar;
        }
    }
    #endregion

    #endregion
}