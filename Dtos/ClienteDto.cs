using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Dtos
{
    /// <summary>
    /// Clase principal que contendra todos los atributos de CubDtos
    /// @author JRT -18/01/2024
    /// </summary>
    internal class ClienteDto
    {
        long idCliente;
        string nombreCliente;
        string apellidosCliente;
        string nombreCompletoCliente;
        int edad;


        /// <summary>
        /// Métodos get y set los cuales formarán una estructura con caracteristicas que identifiquen de forma 
        /// univoca a cada elemento añadido, en este caso a cada cliente.
        /// @author JRT - 18/01/2024
        /// </summary>
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }



        /// <summary>
        /// Contructor al cual se llamara cuando se haga una copia (new) de los elementos que lo conforman,
        /// en este caso los atributos
        /// @author JRT - 18/01/2024
        /// </summary>
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.edad = edad;
            this.nombreCompletoCliente = nombreCliente + " " + apellidosCliente;
        }


        /// <summary>
        /// Contructor vacío por defecto 
        /// @author JRT - 18/01/2024
        /// </summary>
        public ClienteDto()
        {
        }


        /// <summary>
        /// Método to string el cual convierte de forma automatica el objeto a tipo string sin necesidad de tener que hacer
        /// la conversión al momento
        /// @author JRT - 01/01/2024
        /// </summary>
        /// <returns>un tipo string del objeto</returns>
        override
        public string ToString()
        {
            string clienteString= this.nombreCompletoCliente + " " + this.edad;
            return clienteString;
        }

    }
}
