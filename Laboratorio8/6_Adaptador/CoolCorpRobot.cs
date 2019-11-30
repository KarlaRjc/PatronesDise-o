using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._6_Adaptador
{
    class CoolCorpRobot:CoolCorpInterface
    {
        private USRobot robot;
        public CoolCorpRobot()
        {
            this.robot = new USRobot();
        }

        public float CurrentSpeedInKilometersPerHour
        {
            get { return this.robot.CurrentSpeedInmilesPerHour * 1.6093f; }
            set { this.robot.CurrentSpeedInmilesPerHour = value * 0.62137f; }
        }

        public void Jump(float feet)
        {
            this.robot.Jump(feet * 0.3048f);
        }

    }
}
