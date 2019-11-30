using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._3_Constructor
{
    public class Computer1Builder : IComputadora
    {
        ModeloComputadora pc = new ModeloComputadora();

        public void SetMarca()
        {
             pc.Marca = "DELL";
        }
        public void SetProcesor()
        {
             pc.Procesador = "Intel Core I7";
        }
        public void SetRam()
        {
             pc.Ram = "16 GB DDR4";
        }
        public void SetHdd()
        {
             pc.HDD = "1000 GB 7200 RPM";
        }

        public void SetGraphic()
        {
             pc.Grafica = "RX 570";
        }

        public void Getcomputer()
        {
            Console.WriteLine(pc.Ram.ToString()); 
        }
    }
}
