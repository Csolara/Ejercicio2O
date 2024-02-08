using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2O.Dtos
{
    internal class ClienteDto
    {

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string DNICliente = "aaaaa";

        int añosExpTrabCliente = 111;

        public string Nombre { get => nombreCliente; set => nombreCliente = value; }
        public string Apellidos { get => apellidosCliente; set => apellidosCliente = value; }
        public string DNI1 { get => DNICliente; set => DNICliente = value; }
        public int AñosExpTrab { get => añosExpTrabCliente; set => añosExpTrabCliente = value; }

        public ClienteDto(string nombre, string apellidos, string dNI, int añosExpTrab)
        {
            this.nombreCliente = nombre;
            this.apellidosCliente = apellidos;
            this.DNICliente = dNI;
            this.añosExpTrabCliente = añosExpTrab;
        }

        public ClienteDto()
        {

        }       
        override
        public string ToString()
        {
            string cliente = "nombreCliente: " + this.nombreCliente +
                "apellidiosCliente: " + this.apellidosCliente +
                "nombreCompletoCliente: " + this.nombreCliente + this.apellidosCliente +
                "años de experiencia trabajados: " + this.AñosExpTrab;
            return cliente;
        }
    }
}
