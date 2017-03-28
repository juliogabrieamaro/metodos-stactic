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
            string dato;
            
        dato= sello.armarMensaje();
        return dato;
        
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
            string dato = "holasa";
            string dato2;
            int i;
            int num=6;
            int j;





            for (i = 0; i < dato.Length; i++)
            {
                
                    for (j = 0; j <dato.Length; j++)
                {
                    if (j == 0)
                    {

                           
                            Console.WriteLine("********");
                            dato2 = dato.Insert(0, "*");
                            dato2 = dato.Insert(dato.Length, "*");
                            Console.WriteLine("{0}", dato2);
                      
                    
                     }
                        
                    
                        
                    }
                    if (j == 0)
                    {
                        Console.WriteLine("********");
                    }

                
                }
            sello.borrar();
            return dato;
            
            }
           
            

            
        
        }
  
      
    }

