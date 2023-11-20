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

            //Instanciamos la clase donde se encuentran los métodos 
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz sci = new ClienteImplementacion();

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
                }
            } while (!cerrarMenu);
        }
    }
}