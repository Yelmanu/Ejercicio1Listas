using Ejercicio1Listas.Dto;
using Ejercicio1Listas.Servicios;

namespace Ejercicio1Listas.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaramos la lista para guardar los datos del cliente
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaBancariaDto> listaCuentas = new List<CuentaBancariaDto>();

            //Instanciamos la clase donde se encuentran los métodos 
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz sci = new ClienteImplementacion();
            CuentaBancariaInterfaz cbi = new CuentaBancariaImplementacion();

            //Declaramos las variables para controlar el menú
            bool cerrarMenu = false;
            int opcionSeleccionada;

            //bucle del menu
            do
            {
                opcionSeleccionada = mi.menu();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] ALTA NUEVO CLIENTE");
                        sci.darAltaCliente(listaClientes);
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("[INFO] ALTA NUEVA CUENTA BANCARIA");
                        cbi.darAltaCuentaBancaria(listaCuentas);
                        foreach(CuentaBancariaDto cuentaBancaria in listaCuentas)
                        {
                            Console.WriteLine(cuentaBancaria.ToString());
                        }
                        break;
                }
            } while (!cerrarMenu);
        }
    }
}