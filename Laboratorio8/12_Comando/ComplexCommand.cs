using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8._12_Comando
{//En cambio otros comandos puede delegar las tareas mas compejas a otros objetos o Recievers
    class ComplexCommand : ICommand
    {
        private Receiver receiver;

        // Necesarios para poder mandar los metodos de Receiver

        private string a;
        private string b;

        //Los comandos complejos pueden aceptar uno o varios objetos de recividor via constructor
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this.receiver = receiver;
            this.a = a;
            this.b = b;
        }

        //Los comandos pueden delegear estos metodos de un recividor
        public void Execute()
        {
            Console.WriteLine("\n\nComandos Complejos: Si yo pero los comandos complejos deberian ser hechos por un objeto recibidor");
            this.receiver.DoSomething(this.a);
            this.receiver.DoSomethingElse(this.b);
        }
    }
}
