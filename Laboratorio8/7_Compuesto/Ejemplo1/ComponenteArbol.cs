using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._7_Compuesto
{
    public abstract class ComponenteArbol
    {
        protected ComponenteArbol(string nombreComponente)
        {
            Nombre = nombreComponente;
        }

        protected string Nombre { get; }

        public abstract void Brotar(ComponenteArbol componente);
        public abstract void Cortar(ComponenteArbol componente);
        public abstract void Pintar(int nivel);
    }
}
