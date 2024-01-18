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
        /// <summary>
        /// Mètodo para dar de alta un nuevo elemento a la lista de clientes que  ya existen o lista antigua
        /// @author JRT - 18/01/2024
        /// </summary>
        /// <param name="listaAntigua">Devuelve el nombre completo y edad del nuevo cliente</param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Mètodo para ordenar de forma descendente la lista de clientes mediante el campo edad.
        /// @author JRT - 18/01/2024
        /// </summary>
        /// <param name="listaAntigua">Devuelve la lista ordenada de forma ascendente con el nombre completo y edad del nuevo cliente</param>
        public void ordenarListaClientes(List<ClienteDto> listaAntigua);
    }
}
