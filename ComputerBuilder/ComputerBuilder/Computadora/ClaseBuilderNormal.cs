using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Computadora
{
    class ClaseBuilderNormal : IbuilderFinal
    {
        private ProductoComputadora computadora = new ProductoComputadora();

        public void ConstruyeComputadora()
        {
            computadora.CreaComputadora(new ClaseComputadora1());
        }

        public ProductoComputadora ObtenerPC()
        {
            return computadora;
        }
    }
}
