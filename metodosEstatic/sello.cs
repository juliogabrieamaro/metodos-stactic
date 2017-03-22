using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEstatic
{
    class sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        
          public static string imprimir()
        { 
        
        return mensaje;
        
        }

        public static void borrar()
        {
         sello.mensaje= "";
        }
        
       /// <summary>
       /// imprime mensaje con color y asteriscos
       /// </summary>

        
        public static void imprimirColor()
        {
         

          Console.ForegroundColor = sello.color;
            Console.WriteLine(sello.mensaje);

    
        }
        private static string armarMensaje()
        {
            string dato = "sadasd";
        
        }
    }
}
