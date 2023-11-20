using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    /// <summary>
    /// Implementación de la interfaz del menú
    /// 151123 - MDN
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            int opcionIntroducida;

            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|0. Cerrar aplicación        |");
            Console.WriteLine("|1. Darse de alta            |");
            Console.WriteLine("|----------------------------|");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
