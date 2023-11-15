using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Listas.Dto
{
    internal class ClienteDto
    {
        //Atributos
        long idCliente; //PK

        private string nombreCliente = "aaaa";

        private string apellidosCliente = "aaaa";

        private string dniCliente = "aaaa";

        private string fchNacimientoCliente = "9999/12/31";

        private string emailCliente = "aaaa";

        private int tlfCliente = 111111111;

        private string fchAltaCliente = "9999/12/31";

        private string fchBajaCliente = "9999/12/31";

        //Getters y Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        //Constructores (métodos que crean objetos)
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
        }
        public ClienteDto()
        {

        }

        //método toString
        override
        public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente +
                " Apellidos: " + this.apellidosCliente+
                " DNI: " + this.dniCliente +
                " Fecha de nacimiento: " + this.fchNacimientoCliente +
                " Email: " + this.emailCliente +
                " Telefono: " + this.tlfCliente +
                " Fecha de alta: " + this.fchAltaCliente +
                " Fecha de baja: " + this.fchBajaCliente;

            return clienteString;
        }
    }
}
