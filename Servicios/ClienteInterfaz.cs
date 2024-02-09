using Ejercicio2O.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2O.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa del cliente.
    /// CSL - 080224
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de crear y dar de alta a un nuevo cliente.
        /// CSL - 080224
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);
        /// <summary>
        /// Metodo que se encarga de ordenar los clientes segun sus años de experiencias trabajados.
        /// CSL - 080224
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void ordenarCliente(List<ClienteDto> listaAntigua);

    }
}
