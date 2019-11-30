using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
    public class VolMeter : IDevice
    {

        private Random r = null;
        public VolMeter()
        {
            r = new Random();
        }
        public int Measure() { return r.Next(-230, 230); }
        public void TurnOff() { Console.WriteLine("Volímetro parpadea luces para apagarse!"); }
        public void TurnOn() { Console.WriteLine("Volímetro está encendiendo..."); }

    }
}
