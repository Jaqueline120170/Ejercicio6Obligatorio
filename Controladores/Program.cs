using Ejercicio6Obligatorio.Dtos;
using Ejercicio6Obligatorio.Servicios;

namespace Ejercicio6Obligatorio.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// @author JRT - 18/01/2024
    /// </summary>
    /// <param name="args"></param>
    internal class Program
    {
        /// <summary>
        /// metodo de entrada de la aplicacion 
        /// @author JRT - 18/01/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
          

            List<ClienteDto> listaCliente = new List<ClienteDto>();

            bool cerrarMenu = false;
            int opcionUsuario;

            do
            {
                opcionUsuario = mi.mostrarMenuYSeleccion();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Se cierra la aplicación.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Dar alta nuevo cliente");
                        oi.darAltaCliente(listaCliente);
                        //el valor de la referencia de dar alta clientes pasará a lista antigua
                        foreach (ClienteDto clienteNuevo in listaCliente)
                        {
                            Console.WriteLine(clienteNuevo.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ordenar lista de Clientes");
                        oi.ordenarListaClientes(listaCliente);
                        foreach (ClienteDto clienteNuevo in listaCliente)
                        {
                            Console.WriteLine(clienteNuevo.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("La opción elegida no existe.");
                        break;
                }

            } while (!cerrarMenu);

        }
    }
}