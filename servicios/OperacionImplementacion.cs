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


        public void igualdad()
        {
            Console.WriteLine("Introduzca la primera expresion");
            string expresion1 = DameExpresion();
            Console.WriteLine("Introduzca la segunda expresion");
            string expresion2 = DameExpresion();
            Console.WriteLine("Resultado:");
            Console.WriteLine(expresion1==expresion2);

        }

        public void desigualdad()
        {
            Console.WriteLine("Introduzca la primera expresion");
            string expresion1 = DameExpresion();
            Console.WriteLine("Introduzca la segunda expresion");
            string expresion2 = DameExpresion();
            Console.WriteLine("Resultado: ");
            Console.WriteLine(expresion1!=expresion2);
        }
    }
}
