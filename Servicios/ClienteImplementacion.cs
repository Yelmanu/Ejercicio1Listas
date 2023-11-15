using Ejercicio1Listas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    /// <summary>
    /// Implementación de la interfaz para solicitar los datos del cliente
    /// 151123 - MDN
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {
        /// <summary>
        /// Método para pedir los datos del cliente
        /// 151123 - MDN
        /// </summary>
        /// <param name="listaclientes"></param>
        public void solicitarCliente(List<ClienteDto> listaclientes)
        {
            //Instanciamos la clase donde se encuentran las variables necesitadas 
            ClienteDto cliente = new ClienteDto();

            //Pedimos los datos del nuevo cliente por consola 
            Console.WriteLine("Introduzca el nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el DNI: ");
            cliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el email: ");
            cliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el número de teléfono");
            cliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha de nacimiento (formato -> XXXX(año)/XX(mes)/XX(dia): ");
            cliente.FchNacimientoCliente = Console.ReadLine();

            //Usamos una función para determinar la fecha de alta del cliente 
            cliente.FchAltaCliente = Convert.ToString(DateTime.Now);

            //Al ser un cliente nuevo vamos a poner la fecha de baja del cliente null
            cliente.FchBajaCliente = Convert.ToString(null);

            //Guardamos los datos del cliente 
            listaclientes.Add(cliente);
            Console.WriteLine(cliente.ToString());
        }
    }
}
