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
        /// Método para borrar cliente por su DNI
        /// 281123 - MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void borrarCliente(List<ClienteDto> listaClientes)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniBuscar = mi.pedirDni();

            //Objeto
            ClienteDto clienteABorrar = new ClienteDto();
            foreach(ClienteDto cliente in listaClientes)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaClientes.Remove(clienteABorrar);

            //Posición
            /*
            int i;
            bool aBorrar = false;
            for(i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].DniCliente.Equals(dniBuscar))
                {
                    aBorrar = true;
                    break;
                }
                if (aBorrar)
                {
                    listaClientes.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                }
                

            }*/
        }

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

        public void modificarCliente(List<ClienteDto> listaClientes)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.pedirDni();


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
