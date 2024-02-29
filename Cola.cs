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
        protected const int MAX = 30; // Definir el maximo para que una cola se llene
        object[] Elements;
        int tope;
        #endregion
        #region Constructor
        public Cola()
        {
            tope = -1;
            Elements = new object[MAX];
        }
        #endregion
        #region Metodos

        #region Push
        public void PUSH(object dato)
        {
            if (Llena())
            {
                Console.WriteLine("ERROR, pila llena");
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
            // Desarrollar Metodo para Sacar de Cola
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

        #region Llena
        public bool Llena()
        {
            return tope == MAX;
        }
        #endregion

        #region Vacia
        public bool Vacia()
        {
            return tope == -1;
        }
        #endregion

        #region Mostrar
        public void Mostrar()
        {
            if (!Vacia())
            {
                for (int i = 0; i < tope + 1; i++)
                {
                    Console.WriteLine(Elements[i]);
                }
            }
        }
        #endregion

        #region Contar
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
