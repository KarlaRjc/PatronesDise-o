using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._11_CadenaResponsabilidad
{
    /// <summary>
    /// Clase Manejador Concreto 3
    /// </summary>
    class Gerente : IAprobador
    {
        private IAprobador siguiente; // se crea variable de tipo IAprobador

        public IAprobador GetSiguiente() //Retorna el IAprovador siguiente en la cadena de responsabilidad
        {
            return siguiente;
        }

        public void SetSiguiente(IAprobador aprovador) //asigna el siguiente IAprobador de la cadena de responsabilidad
        {
            siguiente = aprovador;
        }

        public void SolicitudPrestamo(int monto)
        {
            if (monto > 50000) //Si el monto es mayor a $50,000
            {
                Console.WriteLine("Esta cuenta la aprueba el gerente "); //Se muestra en consola quien aprueba el prestamo
            }

        }
    }
}
