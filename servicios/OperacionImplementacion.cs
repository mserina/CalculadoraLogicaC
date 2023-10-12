using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        private string DameExpresion()
        {
            string expresion = Console.ReadLine();
            return expresion;
        }


        public string igualdad()
        {
            Console.WriteLine("Introduzca la primera expresion");
            string expresion1 = DameExpresion();
            Console.WriteLine("Introduzca la segunda expresion");
            string expresion2 = DameExpresion();
            Console.WriteLine("Resultado de la igualdad: " + expresion1 == expresion2);

            return ;

        }

        public string desigualdad()
        {
            Console.WriteLine("Introduzca la primera expresion");
            string expresion1 = DameExpresion();
            Console.WriteLine("Introduzca la segunda expresion");
            string expresion2 = DameExpresion();
            Console.WriteLine("Resultado de la igualdad: " + expresion1 != expresion2);

            return ;
        }
    
    }
}
