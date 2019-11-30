using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._6_Adaptador
{
    /// <summary>
    /// Interface de robot
    /// </summary>Todos los robots que se creen implementaran esta interface 
    interface CoolCorpInterface
    {
        //variable current speed In kilometers per hour 
        float CurrentSpeedInKilometersPerHour { get; set; }
        //Jump method which receive the type flow parameter meters
        void Jump(float meters);

    }
}
