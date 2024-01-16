using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            listaAntigua.Add(crearNuevoCliente());
        }

        private ClienteDto crearNuevoCliente()
        {

            Console.WriteLine("Introduzca el id: ");
            long idCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre: ");
            string nombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca sus apellidos: ");
            string apellidosCliente = Console.ReadLine();

            Console.WriteLine("Indique su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            return new ClienteDto (idCliente, nombreCliente, apellidosCliente, edad);

        }

        public void ordenarListaClientes(List<ClienteDto> listaAntigua)
        {
            if(listaAntigua.Count >= 3)
            {

            }
            else
            {
                Console.WriteLine("Necesita introducir más clientes a la lista");
            }
        }
    }
}
