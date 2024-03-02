using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Colas
{
    internal class Paciente(string? nombre, int tipo, int edad, int prioridad)
    {
        #region Atributos
        private readonly string? nombre = nombre;
        private readonly int tipo = tipo; // Puede ser Normal o con Prioridad
        private readonly int prioridad = prioridad; // Va del 0 al 4 sera para saber en que cola se asignara al paciente
        private readonly int edad = edad; // Sera 0 para ninio y 1 para adulto
        #endregion

        #region Metodos

        #region getNombre
        public string? GetNombre()
        {
            return nombre;
        }
        #endregion

        public int GetTipo()
        {
            return tipo;
        }

        public int GetPrioridad()
        {
            return prioridad;
        }

        public int GetEdad()
        {
            return edad;
        }

        #endregion
    }
}
