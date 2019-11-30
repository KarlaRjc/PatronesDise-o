using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8._12_Comando
{
    //La clase Receiver contienen logica importante. Ellos saber hacer las operaciones
    //asociadas con algun request. cualquier clase puede actuar como recividora
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"\n\n\nRecibidor: Estoy trabajando en: {a}.");

        }
        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Recibidor: Estoy TRA BA JANDO en: {b}.");

        }
    }
}
