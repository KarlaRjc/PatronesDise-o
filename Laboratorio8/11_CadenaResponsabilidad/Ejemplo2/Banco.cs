using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._11_CadenaResponsabilidad
{
    /// <summary>
    /// Clase Manejador
    /// </summary>
    class Banco : IAprobador
    {
        private IAprobador siguiente; //se crea variable de tipo IAprobador

        public IAprobador GetSiguiente() //Retorna el IAprovador siguiente en la cadena de responsabilidad
        {
            return siguiente;
        }

        //asigna el siguiente IAprobador de la cadena de responsabilidad
        public void SetSiguiente(IAprobador aprobador)
        {
            siguiente = aprobador;
        }

        public void SolicitudPrestamo(int monto)
        {
            EjecutivoDeCuenta ejecutivo = new EjecutivoDeCuenta();
            this.SetSiguiente(ejecutivo);//se asigna el primer manejador concreto 

            LiderEjecutivo liderEjecutivo = new LiderEjecutivo();
            ejecutivo.SetSiguiente(liderEjecutivo); //se asigna el segundo manejador concreto 

            Gerente gerente = new Gerente();//se asigna el ultimo manejador concreto 
            liderEjecutivo.SetSiguiente(gerente);

            siguiente.SolicitudPrestamo(monto); //Se llama el metodo para determinar quien aprueba el prestamo

        }
    }
}
