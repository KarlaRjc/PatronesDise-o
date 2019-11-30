using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            BebidaEmbriagante oBebida = Creador.creadorBebida(Creador.CERVEZA);
            Console.WriteLine("La cerveza me embriaga por hora un "+oBebida.cuantoMeEmbriagaPorHora() +"%");
         
            BebidaEmbriagante oBebida2 = Creador.creadorBebida(Creador.VINO_BLANCO);
            Console.WriteLine("El vino blanco me embriaga por hora un " + oBebida2.cuantoMeEmbriagaPorHora() + "%");
            Console.ReadLine();
        }
    }
}
