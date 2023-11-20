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

        //Esta forma esta bien pero está hecho de manera más "sucia"

        /*public void solicitarCliente(List<ClienteDto> listaclientes)
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
        }*/
        /// <summary>
        /// Método que se usa para dar de alta a un nuevo cliente
        /// 201123 - MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void darAltaCliente(List<ClienteDto> listaClientes)
        {
            //Creo un nuevo cliente 
            ClienteDto cliente = crearNuevoCliente();

            //Añado el cliente creado a la lista
            listaClientes.Add(cliente);
            
        }

        /// <summary>
        /// Método para pedir todos los datos de un nuevo cliente
        /// 201123 - MDN
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el ID: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el DNI: ");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el número de teléfono");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            return nuevoCliente;
        }
    }
}
