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
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("|0. Cerrar aplicación             |");
            Console.WriteLine("|1. Dar de alta cliente           |");
            Console.WriteLine("|2. Dar de alta cuenta bancaria   |");
            Console.WriteLine("|3. Modificar cliente             |");
            Console.WriteLine("|4. Eliminar cliente              |");
            Console.WriteLine("|5. Ver cliente                   |");
            Console.WriteLine("|---------------------------------|");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }

        public string pedirDni()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }
    }
}
