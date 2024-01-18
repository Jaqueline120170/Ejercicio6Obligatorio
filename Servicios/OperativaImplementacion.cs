using Ejercicio6Obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Clase que contiene la implementación de los métodos de la interfaz OperativaInterfaz
    /// @author JRT - 18/01/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            listaAntigua.Add(crearNuevoCliente());
        }


        /// <summary>
        /// Mètodo que recoge los atributos o datos que conformaran a un nuevo cliente para
        /// ser añadido a la lista, en este caso, se trata de un privado porque solo se harà o implementará en esta clase.
        /// @author JRT- 18/01/2024
        /// </summary>
        /// <returns></returns>
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
                for (int i = 0; i < listaAntigua.Count - 1; i++)
                {
                    for (int j = 0; j < listaAntigua.Count - 1 - i; j++)
                    {
                        if (listaAntigua[j].Edad < listaAntigua[j + 1].Edad)
                        {
                            ClienteDto aux = listaAntigua[j];
                            listaAntigua[j] = listaAntigua[j + 1];
                            listaAntigua[j + 1] = aux;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Necesita introducir más clientes a la lista");
            }
        }
    }
}
