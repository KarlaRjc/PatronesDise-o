using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._5_InstanciaUnica
{
    class Singleton //la clase llamada singleton
    {
        private static Singleton _instance = null;

        public string message = "";


        // constructor privado el cual impide crear una instancia fuera de esta clase 
        private Singleton()
        {
            message = "Hello A";
        }

        //global access point que permite crear una única instancia y asegurar que solo exista una sola
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

    }
}
