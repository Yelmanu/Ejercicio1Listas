using Ejercicio1Listas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la cuenta bancaria
    /// 201123 - MDN
    /// </summary>
    internal interface CuentaBancariaInterfaz
    {
        /// <summary>
        /// Método para dar de alta una nueva cuenta bancaria
        /// 201123 - MDN
        /// </summary>
        /// <param name="listaCuentas"></param>
        public void darAltaCuentaBancaria(List<CuentaBancariaDto> listaCuentas);
    }
}
