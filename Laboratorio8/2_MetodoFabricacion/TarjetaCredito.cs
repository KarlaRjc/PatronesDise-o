using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{

    /// <summary>
    /// Clase Producto. Este es el producto final al usuario, sin importar el tipo. Clase abstracta generica.
    /// </summary>
    abstract class TarjetaCredito
    {
        public abstract string TypoTarjeta { get; }
        public abstract int LimiteCredito { get; set; }
        public abstract int CargoAnual { get; set; }

    }
}
