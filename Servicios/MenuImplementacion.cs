using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Dar de alta nuevo Cliente");
            Console.WriteLine("2. Ordenar lista de Clientes");
            Console.WriteLine("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
