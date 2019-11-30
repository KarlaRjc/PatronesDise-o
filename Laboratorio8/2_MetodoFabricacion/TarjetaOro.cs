using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{

    /// <summary>
    /// Clase de Objeto Concreto, en este caso una clase de un tipo de tarjetas en especifico
    /// </summary>
    class TarjetaOro : TarjetaCredito
    {
        private readonly string _tipoTarjeta;
        private int _limiteCredito;
        private int _cargoAnual;

        public TarjetaOro(int creditLimit, int annualCharge)
        {
            _tipoTarjeta = "Oro";
            _limiteCredito = creditLimit;
            _cargoAnual = annualCharge;
        }

        public override string TypoTarjeta
        {
            get { return _tipoTarjeta; }
        }

        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public override int CargoAnual
        {
            get { return _cargoAnual; }
            set { _cargoAnual = value; }
        }
    }
}
