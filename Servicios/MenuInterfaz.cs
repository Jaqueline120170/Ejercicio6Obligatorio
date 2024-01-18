using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Obligatorio.Servicios
{
    /// <summary>
    /// Interfaz que contiene la relaciòn de metodos con la funcionalidad del menú
    /// @author JRT - 18/01/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la opcion introducida por el usuario
        /// @author JRT - 18/01/2024
        /// </summary>
        /// <returns>un tipo int que contendrà la opcion que seleccione el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
