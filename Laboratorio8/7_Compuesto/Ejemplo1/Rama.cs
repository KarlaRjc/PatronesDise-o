using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._7_Compuesto
{
    public class Rama : ComponenteArbol
    {
        private readonly List<ComponenteArbol> _componentes;

        public Rama(string nombre) : base(nombre)
        {
            _componentes = new List<ComponenteArbol>();
        }

        public override void Brotar(ComponenteArbol componente)
        {
            _componentes.Add(componente);
        }

        public override void Cortar(ComponenteArbol componente)
        {
            _componentes.Remove(componente);
        }

        public override void Pintar(int nivel)
        {
            Console.WriteLine(new String('-', nivel) + " " + Nombre);

            foreach (ComponenteArbol hojaORama in _componentes)
            {
                hojaORama.Pintar(nivel + 1);
            }
        }
    }
}
