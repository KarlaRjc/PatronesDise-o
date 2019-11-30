using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.BasesDeDatosConexion
{
    class OracleConexion:Conexion
    {
        public OracleConexion(){

        }


        public override String descripcion()
        {
            return "Conectado a la Base de Datos Oracle.";
        }

    }
}
