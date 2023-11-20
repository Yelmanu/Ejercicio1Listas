using Ejercicio1Listas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Servicios
{
    internal class CuentaBancariaImplementacion : CuentaBancariaInterfaz
    {
        /// <summary>
        /// Método que se encarga de dar de alta la nueva cuenta bancaria
        /// 201123 - MDN
        /// </summary>
        /// <param name="listaCuentas"></param>
        public void darAltaCuentaBancaria(List<CuentaBancariaDto> listaCuentas)
        {
            //Creo una nueva cuenta bancaria 
            CuentaBancariaDto cuentaBancaria = crearNuevaCuentaBancaria();

            //Añado la nueva cuneta bancaria a la lista
            listaCuentas.Add(cuentaBancaria);
        }

        private CuentaBancariaDto crearNuevaCuentaBancaria()
        {
            CuentaBancariaDto nuevaCuenta = new CuentaBancariaDto();

            Console.WriteLine("Introduzca el ID: ");
            nuevaCuenta.IdCuentaBancaria = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el IBAN: ");
            nuevaCuenta.IbanCuentaBancaria = Console.ReadLine();
            Console.WriteLine("Introduzca el código SWIFT/BIC: ");
            nuevaCuenta.SwiftCuentaBancaria = Console.ReadLine();
            Console.WriteLine("Introduzca el DNI del cliente asociado a la cuenta: ");
            nuevaCuenta.DniClienteAsociado = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevaCuenta.FechaAlta = Console.ReadLine();

            return nuevaCuenta;
        }
    }
}
