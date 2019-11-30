using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
    /// <summary>
    /// Clase de la fabrica en general que crea las tarjetas. Abstracta para que apartir de esta clase hereden las otras fabricas.
    /// </summary>
    abstract class FabricaTarjetas
    {
        public abstract TarjetaCredito ObtenerTarjetaCredito();
    }
}
