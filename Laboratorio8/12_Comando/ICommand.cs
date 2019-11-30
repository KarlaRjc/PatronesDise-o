using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8._12_Comando
{
    // La interfas Commando declara el metodo para ejecutar un comando
    public interface ICommand
    {
        void Execute();
    }
}
