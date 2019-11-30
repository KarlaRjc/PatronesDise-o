using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._7_Compuesto
{
    class Hoja : Rama
    {
        public Hoja(string nombre) : base(nombre)
        {
        }

        public override void Brotar(ComponenteArbol componente)
        {
            throw new NotImplementedException();
        }

        public override void Cortar(ComponenteArbol componente)
        {
            throw new NotImplementedException();
        }

        public override void Pintar(int nivel)
        {
            Console.WriteLine(new String('-', nivel) + " " + Nombre);
        }
    }
}
