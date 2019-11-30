using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasesDeDatosConexion;

namespace AbstractFactory.Fabrica
{
    public abstract class FabricaAbstracta
    {
        public FabricaAbstracta()
        {

        }

        public abstract Conexion creaConexion(String tipo);
    }
    
}
