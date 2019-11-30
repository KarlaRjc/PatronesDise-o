using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.BasesDeDatosConexion
{   
    class SQLServerConexion:Conexion
    {
        public SQLServerConexion() {

        }


        public override String descripcion()
        {
            return "Conectado a la Base de Datos SQLServer.";
        }
    }
}
