using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._7_Compuesto
{
    //Hereda sobre component
    class Composite : Component
    {
        //lista para todos los ingredientes 
        private List<Component> ingredientes = new List<Component>();


        //Obtener el costo Total de los ingredientes y el valor que les doy (recorrido recursivo)
        public decimal costoTotal
        { //Método recursivo
            get
            {
                decimal costo = 0;
                foreach (var elemento in ingredientes) //recorre la lista de ingredientes
                {
                    if (elemento.GetType().Name == "Composite")
                        costo += ((Composite)elemento).costoTotal;
                    else
                        costo += elemento.costo;
                }
                return costo;
            }
        }

        //Agregar ingrediente (hijos de component) 
        public void Add(Component elemento)
        {
            ingredientes.Add(elemento);
        }

        //Eliminar ingrediente 
        public void Remove(Component elemento)
        {
            ingredientes.Remove(elemento);
        }

        //Constructor que recibe el Nombre y el Costo (del Padre)
        public Composite(string nombre, decimal costo = 0) : base(nombre, costo)
        {
        }
    }
}
