using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
    public class OhmMeter : IDevice
    {
        private Random r = null;
        public OhmMeter()
        {
            r = new Random();
        }
        public int Measure() { return r.Next(0, 1000000); }
        public void TurnOff() { Console.WriteLine("Medidor de resistencia parpadea luces para apagarse!"); }
        public void TurnOn() { Console.WriteLine("Medidor de resistencia está encendiendo..."); }

    }
}
