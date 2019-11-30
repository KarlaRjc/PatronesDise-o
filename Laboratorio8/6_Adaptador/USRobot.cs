using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._6_Adaptador
{
    class USRobot: USRobotsInterface
    {
        private float CurrentSpeed;
        public float CurrentSpeedInmilesPerHour
        {
            get { return CurrentSpeed; }
            set { CurrentSpeed = value; }
        }

        public USRobot()
        {
            this.CurrentSpeed = 100;
        }

        public void EnablePartialFirstLawMode()
        {
            Console.WriteLine("Partial first law enabled");
        }

        
        public void Jump(float feet)
        {
            Console.WriteLine("Jump " + feet + "!!");
        }
    }
}
