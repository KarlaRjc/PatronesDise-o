using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._11_CadenaResponsabilidad
{
    /// <summary>
    /// Clase manejador concreto 2
    /// </summary>
    class LiderEjecutivo : IAprobador
    {
        private IAprobador siguiente; //se crea variable de tipo IAprobador

        public IAprobador GetSiguiente() //Retorna el IAprovador siguiente en la cadena de responsabilidad
        {
            return siguiente;
        }

        //asigna el siguiente IAprobador de la cadena de responsabilidad
        public void SetSiguiente(IAprobador aprovador)
        {
            siguiente = aprovador;
        }

        public void SolicitudPrestamo(int monto)
        {
            if (monto > 10000 && monto <= 50000)//Si el monto es mayor a $10,000 y menor o igual a $50,000
            {
                Console.WriteLine("Esta cuenta la aprueba el lider ejecutivo "); //Se muestra en consola quien aprueba el prestamo
            }
            else
            { //de otra manera pasa la peticion  al siguiente en la cadena 
                siguiente.SolicitudPrestamo(monto);
            }

        }
    }
}
