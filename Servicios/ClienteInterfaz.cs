using Ejercicio2O.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2O.Servicios
{
    internal interface ClienteInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua);

        public void ordenarCliente(List<ClienteDto> listaAntigua);

    }
}
