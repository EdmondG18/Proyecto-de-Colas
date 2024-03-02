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

        public void PUSH(Paciente dato)
        {
            if (Llena())
            {
                Console.WriteLine("\nLo siento, ya no aceptamos mas pacientes con esta condicion.\n");
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
            // Desarrollar Metodo para Sacar de Cola
            if (!Vacia())
            {
                for (int i = 0; i < tope; i++)
                {
                    Elements[i] = Elements[i + 1];
                }
                Elements[tope] = null;
                tope--;
            }
            else
            {
                Console.WriteLine("No hay nadie con este tipo de condicion para atender.");
            }

        }
        #endregion

        #region POPTOPE
        public Paciente? POPTOPE()
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
