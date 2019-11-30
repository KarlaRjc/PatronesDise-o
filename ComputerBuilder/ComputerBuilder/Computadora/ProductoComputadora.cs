using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Computadora
{
    class ProductoComputadora
    {
        private IBuilderComputadora builderComputadora;

        public void CreaComputadora(IBuilderComputadora buildComputer)
        {
            builderComputadora = buildComputer;
            Console.WriteLine("Contruyendo la Computadora:",builderComputadora.BuildProcessor());
        }

        public void ShowFinalProduct()
        {
            Console.WriteLine("Se termino de construir la primera computadora final:"+"\n"+ builderComputadora.ShowComputer());
        }
    }
}
