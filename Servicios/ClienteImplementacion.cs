using Ejercicio2O.Dtos;
using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2O.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
            Console.WriteLine(listaAntigua.ToString());
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();            

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.Nombre = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Introduzca el DNI: ");
            nuevoCliente.DNI1 = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad de años de experiencia: ");
            nuevoCliente.AñosExpTrab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("Nombre: " + nuevoCliente.Nombre);
            Console.WriteLine("Apellidos: " + nuevoCliente.Apellidos);
            Console.WriteLine("DNI: " + nuevoCliente.DNI1);
            Console.WriteLine("Años de experiencia trabajados: " + nuevoCliente.AñosExpTrab);
            Console.WriteLine("--------------------");

            return nuevoCliente;
        }

        public void ordenarCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto temp;
            bool x;

            do
            {
                x = false;
                for (int i = 0; i < listaAntigua.Count - 1; i++)
                {
                    if (listaAntigua[i].AñosExpTrab > listaAntigua[i + 1].AñosExpTrab)
                    {                        
                        temp = listaAntigua[i];
                        listaAntigua[i] = listaAntigua[i + 1];
                        listaAntigua[i + 1] = temp;
                        x = true;
                    }
                }
            } while (x);

            Console.WriteLine("Datos ordenados: ");
            foreach (ClienteDto Cliente in listaAntigua)
            {
                Console.WriteLine("");
                Console.WriteLine(Cliente.Nombre + " tiene " + Cliente.AñosExpTrab + " años de experiencia.");
                Console.WriteLine("");
            }
        }
    }
}
