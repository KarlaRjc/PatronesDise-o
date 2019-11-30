using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._3_Constructor
{
    public class ComputerCreator
    {
        private IComputadora _computadora;

        public ComputerCreator(IComputadora computerCreator)
        {
            _computadora = computerCreator;
        }

        public void CreateComputer()
        {
            _computadora.SetMarca();
            _computadora.SetProcesor();
            _computadora.SetHdd();
            _computadora.SetRam();
            _computadora.SetGraphic();
        }

        public void GetComputer()
        {
            Console.WriteLine(_computadora.ToString());
        }
    }
}
