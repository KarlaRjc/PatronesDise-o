using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Computadora
{
    interface IBuilderComputadora
    {
        string BuildProcessor();
        string BuildRam();
        string BuildHdd();
        string BuildGPU();
        string ShowComputer();

    }
}
