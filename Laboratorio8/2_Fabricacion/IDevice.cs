using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
    public interface IDevice
    {
        int Measure();
        void TurnOff();
        void TurnOn();

    }
}
