using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._4_Prototipo
{
    public class Animales : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }
        //____________________________________________________
        //profunda ejemplo
        public Detalles Rasgos { get; set; }
        //__________________________________________________
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        //___________________________________________________

    }

    //Profunda ejemplo
    public class Detalles
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }
}