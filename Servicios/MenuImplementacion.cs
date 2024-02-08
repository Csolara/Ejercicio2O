using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2O.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MENU()
        {
            int opcionseleccionada;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Crear un usuario.");
            Console.WriteLine("2. Ordenar usuario.");
            Console.WriteLine("#####################");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionseleccionada;
        }
    }
}
