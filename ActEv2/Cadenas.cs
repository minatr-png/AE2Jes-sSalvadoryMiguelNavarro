using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Biz
{
    public class Cadenas
    {
        private string cadena;

        #region Constructor
        /// <summary>
        /// Construye un objeto que tiene una cadena de texto
        /// </summary>
        /// <param name="cadena">La cadena de texto</param>
        public Cadenas(string cadena)
        {
            this.cadena = cadena;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Dada una cadena devuelve su primer caracter
        /// </summary>
        /// <returns>Devuelve la el primer caracter de la cadena</returns>
        public char cadenaPri() { return cadena[0]; }

        /// <summary>
        ///  Dada una cadena devuelve su último caracter
        /// </summary>
        /// <returns>Devuelve la el último caracter de la cadena</returns>
        public char cadenaUlt() { return cadena[cadena.Length - 1]; }

        /// <summary>
        /// Dada una cadena devuelve el caracter indicado
        /// </summary>
        /// <param name="i">Número de caracter indicado</param>
        /// <returns>Devuelve el caracter indicado de la cadena</returns>
        public char cadenaDet(int i) { return cadena[i]; }
        #endregion
    }
}
