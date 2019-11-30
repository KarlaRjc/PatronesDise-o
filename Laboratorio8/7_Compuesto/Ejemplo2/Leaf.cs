using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._7_Compuesto
{
    //Hereda sobre component
    class Leaf : Component
    {
        public int cantidad { get; set; }
        public string unidad { get; set; } //Tipo de Unidad del ingrediente

        //Constructor de la clase
        public Leaf(string nombre, decimal costo, int cantidad, string unidad) : base(nombre, costo)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
        }
    }
}
