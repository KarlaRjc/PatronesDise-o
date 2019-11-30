using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8._12_Comando
{
    //El Invocador se asocial con uno o varios comandos, y es el que manda el request del comando
    class Invoker
    {
        private ICommand onStart;
        private ICommand onFinish;

        //Inicializa el comando
        public void SetOnStart(ICommand command)
        {
            this.onStart = command;
        }
        public void SetOnFinish(ICommand command)
        {
            this.onFinish = command;
        }

        //El invocador no depende de las clases crear comando o recibir comando.
        //El invocador passa el request a un receiver indirectamente ejecutando un comando
        public void DoSomethingImportant()
        {
            Console.WriteLine("\nInvocador: Alguien ocupa que haga algo antes de que empieze?");
            if(this.onStart is ICommand)
            {
                this.onStart.Execute();
            }

            Console.WriteLine("\n\n\nInvocador: ...estoy haciendo algo super importante .....computando...");

            Console.WriteLine("\n\n\nInvocador: Alguien ocupa que haga algo desp de que termine?");
            if (this.onFinish is ICommand)
            {
                this.onFinish.Execute();
            }
        }


    }
}
