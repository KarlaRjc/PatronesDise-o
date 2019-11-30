using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._11_CadenaResponsabilidad
{
    /// <summary>
    /// Interfaz de la cual heredaran las clases que manejan la peticion, el manejador y el manejador concreto
    /// </summary>
    interface IAprobador
    {
        /// <summary>
        /// Método para asignar el siguiente manejador concreto en la cadena de responsabilidad
        /// </summary>
        /// <param name="aprovador"></param>
        void SetSiguiente(IAprobador aprovador);
        /// <summary>
        /// Método para obtener el manejador concreto que sigue en la cadena
        /// </summary>
        /// <returns> retorna un objeto de tipo IAprobador</returns>
        IAprobador GetSiguiente();
        /// <summary>
        /// Método que muestra que tipo de empleado aprueba la solicitud 
        /// del cliente, recibe el monto del prestamo para determinar la aprobación
        /// </summary>
        /// <param name="monto"></param>
        void SolicitudPrestamo(int monto);
    }

}
