using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Colas
{
    internal class Cola
    {
        #region Atributos 
        protected const int MAX = 25; 
        Paciente[] Elements;
        int tope;
        #endregion
        #region Constructor
        public Cola()
        {
            tope = -1;
            Elements = new Paciente[MAX];
        }
        #endregion
        #region Metodos

        #region PUSH
<<<<<<< HEAD
        public void PUSH(Paciente dato)
        {
            if (Llena())
            {
                Console.WriteLine("\nLo siento, ya no aceptamos mas pacientes con esta condicion.\n");
=======
        public void PUSH(object dato)
        {
            if (Llena())
            {
                Console.WriteLine("ERROR, cola llena");
>>>>>>> 7604d4a54ed850e39904e445964c70db1172a2a9
                Console.ReadKey();
            }
            else
            {
                Elements[++tope] = dato;
            }
        }
        #endregion

        #region POP
        public void POP()
        {
<<<<<<< HEAD
            // Desarrollar Metodo para Sacar de Cola
=======
>>>>>>> 7604d4a54ed850e39904e445964c70db1172a2a9
            if (!Vacia())
            {
                for (int i = 0; i < tope; i++)
                {
                    Elements[i] = Elements[i + 1];
                }

<<<<<<< HEAD
                Elements[tope] = null;
=======
                Elements[tope] = "";
>>>>>>> 7604d4a54ed850e39904e445964c70db1172a2a9

                tope--;
            }
            else
            {
<<<<<<< HEAD
                Console.WriteLine("No hay nadie con este tipo de condicion para atender.");
=======
                Console.WriteLine("ERROR, cola vacia");
>>>>>>> 7604d4a54ed850e39904e445964c70db1172a2a9
            }

        }
        #endregion

        #region POPTOPE
        public object POPTOPE()
        {
            if (Vacia())
            {
                return null;
            }
            return Elements[tope];
        }
        #endregion

        #region LLENA
        public bool Llena()
        {
            return tope == MAX;
        }
        #endregion

        #region VACIA
        public bool Vacia()
        {
            return tope == -1;
        }
        #endregion

        #region MOSTRAR
        public void Mostrar()
        {
            if (!Vacia())
            {
                for (int i = 0; i < tope + 1; i++)
                {
                    Console.WriteLine(Elements[i]);
                }

            }
            else
            {
                Console.WriteLine("La cola se encuentra vacía");
            }
            else
            {
                Console.WriteLine("No hay pacientes con esta condicion.");
            }
        }
        #endregion

        #region CONTAR
        public int Contar()
        {
            int cantidad = 0;
            for (int i = 0; i < tope + 1; i++)
            {
                cantidad++;
            }

            return cantidad;
        }
        #endregion

        #endregion


    }
}
