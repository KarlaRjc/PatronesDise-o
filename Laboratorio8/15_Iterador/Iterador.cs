using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._15_Iterador
{
    public class Iterador
    {
        public string Ultimo(IEnumerable<string> elements)
        {
            return elements.Last();
        }

        public string Posicion(IEnumerable<string> elements, int posicion)
        {
            return elements.ElementAt(posicion);
        }

        public string Inicio(IEnumerable<string> elements)
        {
            return elements.First();
        }
    }
}
