using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Common
{
    public static class CosasDeFechas
    {
        /// <summary>
        /// Dada la fecha si el valor no es null devuelve el día de la semana
        /// </summary>
        /// <param name="fecha">Esta es la fecha que da el usuario</param>
        /// <returns>Devuelve el día de la semana</returns>
        public static string DiaSemana(DateTime fecha)
        {
            if (fecha != null) return fecha.DayOfWeek.ToString();
            else return "No has introducido un valor adecuado";
        }

        /// <summary>
        /// Dada la fecha y la fecha de cumpleaños te devuelve cuanto queda para que este llegue
        /// </summary>
        /// <param name="fecha">Esta es la fecha que da el usuario</param>
        /// <param name="cumple">Este es la fecha de cumpleaños que proporciona el usuario</param>
        /// <returns>Devuelve el número de días que faltan para que llegue el cumpleaños</returns>
        public static string CuantoFalta(DateTime fecha, DateTime cumple)
        {
            TimeSpan falta = cumple - fecha;
            return "Faltan " + falta.Days + " días.";
        }

        /// <summary>
        /// Es una función que devuelve a que día estamos
        /// </summary>
        /// <returns>Devuelve la fecha actual</returns>
        public static DateTime FechaActual() { return DateTime.Today; } //Como no sabemos y no hemos sabido encontrar que es la especificación del método simplemente hemos creado esta función y sabiendo a que te refieres con esto ya podríamos usarla ahí
    }
}
