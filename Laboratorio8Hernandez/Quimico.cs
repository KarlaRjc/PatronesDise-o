using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8Hernandez
{
    public  class Quimico
    {
        public Quimico() {

        }
        ~Quimico() {

        }
        public virtual void Dispose() {

        }
        /// <summary>
        /// metodo que devuelve adaptación que haga
        /// </summary>
        /// <param name="compuesto"></param>
        /// <returns></returns>
        public int GetPesoMolecular(string compuesto) {
            int valor = 0;
            switch (compuesto) {
                case "Agua":
                    valor = 10;
                    break;
                case "Aceite":
                    valor = 50;
                    break;
            }
            return valor;
        }
    }
}
