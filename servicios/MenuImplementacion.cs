using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int abrirMenuYrespuesta()
        {
            int Respuesta;

            Console.WriteLine("#################");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Igualdad");
            Console.WriteLine("3. Desigualdad");
            Console.WriteLine("Selecciona respueta");

           Respuesta = Console.ReadKey(true).KeyChar -('0');

            return Respuesta;
        }
    }
}
