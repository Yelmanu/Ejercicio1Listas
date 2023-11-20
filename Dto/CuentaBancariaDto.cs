using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Dto
{
    internal class CuentaBancariaDto
    {
        //Atributos

        long idCuentaBancaria; //PK

        private string ibanCuentaBancaria = "aaaa";

        private string swiftCuentaBancaria = "CSI1SSXX";

        private string fechaAlta = "9999/12/31";

        private string fechaBaja = "9999/12/31";

        private string dniClienteAsociado = "aaaa";

        //Getters y Setters

        public long IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public string IbanCuentaBancaria { get => ibanCuentaBancaria; set => ibanCuentaBancaria = value; }
        public string SwiftCuentaBancaria { get => swiftCuentaBancaria; set => swiftCuentaBancaria = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string DniClienteAsociado { get => dniClienteAsociado; set => dniClienteAsociado = value; }

        //Constructores
        
        public CuentaBancariaDto(long idCuentaBancaria, string ibanCuentaBancaria, string swiftCuentaBancaria, string fechaAlta, string fechaBaja, string dniClienteAsociado)
        {
            this.idCuentaBancaria = idCuentaBancaria;
            this.ibanCuentaBancaria = ibanCuentaBancaria;
            this.swiftCuentaBancaria = swiftCuentaBancaria;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.dniClienteAsociado = dniClienteAsociado;
        }
        public CuentaBancariaDto()
        {

        }

        //Método ToString
        override
        public string ToString()
        {
            string cuentaBancariaString = "Id cuenta bancaria: " + this.idCuentaBancaria +
                " IBAN cuenta bancaria: " + this.ibanCuentaBancaria +
                " Código SWIFT/BIC cuenta bancaria: " + this.swiftCuentaBancaria +
                " DNI cliente asociado a la cuenta bancaria: " + this.dniClienteAsociado +
                " Fecha de alta: " + this.fechaAlta +
                " Fecha de baja: " + this.fechaBaja;

            return cuentaBancariaString;
        }
    }
}
