using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creador
    {
        public const int VINO_BLANCO = 1;
        public const int CERVEZA = 2;

        public static BebidaEmbriagante creadorBebida(int Tipo)
        {
            switch (Tipo)
            {

                case VINO_BLANCO:
                    return new VinoBlanco();
                case CERVEZA:
                    return new Cerveza();
                default: return null;

            }

        }
    }
}