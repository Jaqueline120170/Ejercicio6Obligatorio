using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);
        public void ordenarListaClientes(List<ClienteDto> listaAntigua);
    }
}
