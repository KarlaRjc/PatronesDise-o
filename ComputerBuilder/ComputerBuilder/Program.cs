using ComputerBuilder.Computadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDirectorComputadora director = new ClaseDirectorComputadora();

            ClaseBuilderNormal normal = new ClaseBuilderNormal();

            director.ConstruyeComputadora(normal);

            ProductoComputadora computadora1 = normal.ObtenerPC();

            computadora1.ShowFinalProduct();

            Console.WriteLine("________________________________________________________");
            Console.ReadKey();
        }
    }
}
