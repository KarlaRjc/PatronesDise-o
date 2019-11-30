using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Computadora
{
    class ClaseComputadora1 : IBuilderComputadora
    {
        ModeloComputadora modelo = new ModeloComputadora();

        public string BuildGPU()
        {
            modelo.gpu = "RX 570";
            return modelo.gpu;
        }

        public string BuildHdd()
        {
            modelo.hdd = "HDD DE 1000 GB";
            return modelo.hdd;
        }

        public string BuildProcessor()
        {
            modelo.processor = "INTEL COREO I7 7400K";
            return modelo.processor;
        }

        public string BuildRam()
        {
            modelo.ram = "16 GB DDR4";
            return modelo.ram;
        }

        public string ShowComputer()
        {
           return "Primera computadora personalizada: " + "\n" 
                +"Procesador: "+ BuildProcessor()+"\n"+
                "Disco Duro: "+BuildHdd()+"\n"+
                "Memoria Ram: "+BuildRam()+"\n"+
                "Tarjeta de video: "+BuildGPU();
        }
    }
}
