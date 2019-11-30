using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._6_Adaptador
{
    /// <summary>
    /// Interfaz utlizada por una empresa fabricante de robots en USA
    /// Esta Interfaz utiliza millas y pies para atribuir a los robots
    /// Ademas utiliza 
    /// </summary>
    interface USRobotsInterface
    {
        float CurrentSpeedInmilesPerHour { get; set; }
        void EnablePartialFirstLawMode();
        void Jump(float feet);
    }
}
