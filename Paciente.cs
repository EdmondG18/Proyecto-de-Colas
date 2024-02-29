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
        public Paciente(string nombre, int tipo, string edad) {
            nombre = this.nombre;
            tipo = this.tipo;
            edad = this.edad;
        }
        #endregion

        #region Atributos
        private string nombre;
        private int tipo;
        private string edad;
        #endregion

        #region Metodos

        #region getNombre
        public string getNombre(){
            return nombre;
        }
        #endregion


        #endregion
    }
}
