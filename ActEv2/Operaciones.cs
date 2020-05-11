using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Biz
{
    public class Operaciones
    {
        private int num1; 
        private int num2;
        public readonly int CualEsMayor;

        #region Constructor
        /// <summary>
        /// Nos da los numeros para nuestras operaciones
        /// </summary>
        /// <param name="n1">El primer numero que recibe</param>
        /// <param name="n2">El segundo numero que recibe</param>
        public Operaciones(int n1, int n2)
        {
            if (n1 >= n2)
            {
                this.CualEsMayor = n1;
                num1 = n1;
                num2 = n2;
            } 
            else 
            { 
               this.CualEsMayor = n2;
                num1 = n2;
                num2 = n1;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Suma los dos numeros recibidos
        /// </summary>
        /// <returns>EL rtesultado de la suma de los nuemeros</returns>
        public int Sumar()
        {
            return num1 + num2;
        }

        /// <summary>
        /// Resta el numero mayor del menor
        /// </summary>
        /// <returns>El resultado de la resta</returns>
        public int Restar()
        {
            return num1 - num2;
        }

        /// <summary>
        /// Multiplica los dos numeros recibidos
        /// </summary>
        /// <returns>El resultado de la multiplicacion</returns>
        public int Multiplicar()
        {
            return num1 * num2;
        }
        #endregion
    }
}
