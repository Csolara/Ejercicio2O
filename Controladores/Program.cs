using Ejercicio2O.Dtos;
using Ejercicio2O.Servicios;

namespace Ejercicio2O.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {

            List<ClienteDto> listaClientes = new List<ClienteDto>();

            ClienteInterfaz ci = new ClienteImplementacion();
            MenuInterfaz mi = new MenuImplementacion();

            bool cerrarMenu = false;

            while(!cerrarMenu)
            {

                int recogido = mi.MENU();

                switch(recogido)
                {
                    case 0:
                        Console.WriteLine("La aplicación se cerrara");
                        cerrarMenu = true;
                        break;
                    case 1:
                        ci.darAltaCliente(listaClientes);
                        break;
                    case 2:
                        ci.ordenarCliente(listaClientes);
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna");
                        break;
                }
            }            
        }
    }
}