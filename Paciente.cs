using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Colas
{
    internal class Paciente
    {

        #region Constructor

        public Paciente(string nombre, int edad, int tipo, int prioridad) {
            nombre = this.nombre;
            edad = this.edad;
            tipo = this.tipo;
            prioridad = this.prioridad;
        }
        #endregion

        #region Atributos
        private string nombre;
        private int tipo; // Puede ser Normal o con Prioridad
        private int prioridad; // Va del 0 al 4 sera para saber en que cola se asignara al paciente
        private int edad; // Sera 0 para ninio y 1 para adulto
        #endregion

        #region Metodos

        #region getNombre

        

        public string GetNombre()
        {

            return nombre;
        }
        #endregion

        public int GetTipo()
        {
            return tipo;
        }

        public int GetPrioridad() { 
            return prioridad;
        }

        public int GetEdad()
        {
            return edad;
        }

        #endregion
    }
}
