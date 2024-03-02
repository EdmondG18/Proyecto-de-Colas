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

        #region PUSH
        public void PUSH(object dato)
        {
            if (Llena())
            {
                Console.WriteLine("ERROR, cola llena");
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
            if (!Vacia())
            {
                for (int i = 0; i < tope; i++)
                {
                    Elements[i] = Elements[i + 1];
                }

                Elements[tope] = "";

                tope--;
            }
            else
            {
                Console.WriteLine("ERROR, cola vacia");
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
