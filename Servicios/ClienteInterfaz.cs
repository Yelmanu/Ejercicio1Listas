using Ejercicio1Listas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    /// <summary>
    /// Interfaz que se usará para pedir los datos del cliente
    /// 151123 - MDN
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// Método para pedir los datos del cliente y guardarlos en una lista
        /// 151123 - MDN
        /// </summary>
        /// <param name="listaclientes"></param>
        public void darAltaCliente(List<ClienteDto> listaClientes);

        /// <summary>
        /// Método para borrar cliente mediante DNI
        /// 281123 - MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void borrarCliente(List<ClienteDto> listaClientes);

        /// <summary>
        /// Método para modificar clientes buscados por DNI
        /// 281123 - MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void modificarCliente(List<ClienteDto> listaClientes);
    }
}
