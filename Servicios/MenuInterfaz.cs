using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    /// <summary>
    /// Interfaz para la funcionalidad del menú 
    /// 151123 - MDN
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que contiene el menú
        /// 151123 - MDN
        /// </summary>
        public int menu();

        /// <summary>
        /// Método para pedir el DNI de un cliente
        /// 281123 - MDN
        /// </summary>
        /// <returns></returns>
        public string pedirDni();
    }
}
