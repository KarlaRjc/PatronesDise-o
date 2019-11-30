using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
   public class AmMeter : IDevice
    {
        private Random r = null;
        public AmMeter()
        {
            r = new Random();
        }
        public int Measure() { return r.Next(-25, 60); }
        public void TurnOff() { Console.WriteLine("Amperímetro parpadea luces para apagarse!"); }
        public void TurnOn() { Console.WriteLine("Amperímetro está encendiendo..."); }

    }
}
