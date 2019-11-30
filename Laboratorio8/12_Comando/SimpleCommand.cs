using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8._12_Comando
{//Algunos comandos pueden implementar operaciones sencillas por si solos.
    class SimpleCommand : ICommand
    {
        private string payload = string.Empty;

        public SimpleCommand(string payload)
            {
            this.payload = payload;
            }
        public void Execute()
        {
            Console.WriteLine($"\nComando Simple: Puedo hacer cosas sencillas como imprimir: {this.payload}");
        }

    }
}
