using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Computadora
{
    class ClaseDirectorComputadora
    {
        public void ConstruyeComputadora(IbuilderFinal builderPC)
        {
            builderPC.ConstruyeComputadora();
        }
    }
}
