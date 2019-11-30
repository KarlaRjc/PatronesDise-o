using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._3_Constructor
{
    public class Computer2Builder : IComputadora
    {
        ModeloComputadora pc2 = new ModeloComputadora();

        public void SetMarca()
        {
             pc2.Marca = "ACER";
        }

        public void SetProcesor()
        {
             pc2.Procesador = "AMD RYZEN 6 3200 G";
        }

        public void SetRam()
        {
             pc2.Ram = "12 GB DDR4";
        }

        public void SetHdd()
        {
             pc2.HDD = "500 GB 7200 RPM";
        }

        public void SetGraphic()
        {
             pc2.Grafica = "NVIDIA RTX 2070";
        }

        public void Getcomputer()
        {
            Console.WriteLine(pc2); 
        }
    }
}
