﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._16_Mediador
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>

    class Beatle : Participant
    {
        // Constructor

        public Beatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
