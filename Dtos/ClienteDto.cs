using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Dtos
{
    internal class ClienteDto
    {
        long idCliente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edad;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.edad = edad;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosCliente;
        }

        

        public ClienteDto()
        {
        }

        override
        public string ToString()
        {
            string clienteString= this.nombreCompletoCliente + " " + this.edad;
            return clienteString;
        }

    }
}
