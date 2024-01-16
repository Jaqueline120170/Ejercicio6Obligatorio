using Ejercicio6Obligatorio.Dtos;
using Ejercicio6Obligatorio.Servicios;

namespace Ejercicio6Obligatorio.Controladores
{
    internal class Program
    {
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
                        //el valor de la referencia nde dar alta clientes pasará a lista antigua
                        foreach (ClienteDto clienteNuevo in listaCliente)
                        {
                            Console.WriteLine(clienteNuevo.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ordenar lista de Clientes");
                        break;
                    default:
                        Console.WriteLine("La opción elegida no existe.");
                        break;
                }

            } while (!cerrarMenu);

        }
    }
}