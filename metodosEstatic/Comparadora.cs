using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEstatic
{
    class Comparadora
    {
        /// <summary>
        /// este metodo muestra el mayor
        /// </summary>
        /// <param name="numero1">primer numero entero</param>
        /// <param name="numero2">segundo numero entero</param>
        /// <returns>mayor</returns>
        public static int retornarMayor(int numero1, int numero2)
        {

            int retorno= 0;

            if (numero1 > numero2)
                retorno = numero1;
            else
                retorno = numero2;
            return retorno;

        }
        /// <summary>
        /// retorna valor del medio
        /// </summary>
        /// <param name="numero1">
        ///</param>
        /// <param name="numero2"></param>
        /// <param name="numero3"></param>
        /// <returns></returns>

        public static int mostrarElDelMedio(int numero1, int numero2,int numero3)
        {

            int retorno = 0;

            if (numero1 > numero2 || numero1>numero3)
            {
                if (numero1 < numero2 || numero1 < numero3)
                {
                    retorno = numero1;
                }
            }
            if (numero2 > numero1 || numero2 > numero3)
            {
                if (numero2 < numero1 || numero2 < numero3)
                {
                    retorno = numero2;
                }
            }

            if (numero3 > numero2 || numero3 > numero1)
            {
                if (numero3 < numero1 || numero3 < numero2)
                {
                    retorno = numero3;
                }
            } 

            return retorno;

        }

    }
}
