using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.servicios
{
    /// <summary>
    /// Contendra la cabezera de los metodos
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y lee respuesta del usuario por consola 
        /// </summary>
        /// <param name="Respuesta"></param>
        /// <returns> Valor tipo int </returns>
        public int abrirMenuYrespuesta();
    }
}
