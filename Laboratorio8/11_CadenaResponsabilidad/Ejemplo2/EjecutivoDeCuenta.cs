using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._11_CadenaResponsabilidad
{
    class EjecutivoDeCuenta : IAprobador
    {
        /// <summary>
        /// Clase manejador concreto 1
        /// </summary>
        private IAprobador siguiente; // se crea variable de tipo IAprobador

        public IAprobador GetSiguiente()
        {
            return siguiente; //Retorna el IAprovador siguiente en la cadena de responsabilidad
        }

        public void SetSiguiente(IAprobador aprovador) //asigna el siguiente IAprobador de la cadena de responsabilidad
        {
            siguiente = aprovador;
        }

        public void SolicitudPrestamo(int monto)
        {
            if (monto <= 10000) //Si el monto es menor o igual $10,000
            {
                Console.WriteLine("Esta cuenta la aprueba el ejecutivo de cuentas "); //se muestra en consola 
            }
            else
            {//si el monto es mayor a $10,000 
                siguiente.SolicitudPrestamo(monto); //pasa la peticion al siguiente en la cadena 
            }

        }
    }
}
